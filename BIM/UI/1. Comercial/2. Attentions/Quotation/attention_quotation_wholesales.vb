
Public Class attention_quotation_wholesales
    Private services As Products = Products.Instance
    Private resumen As Resumen = Resumen.Instance
    Private dealer As Dealers = Dealers.Instance
    Private attention As Attentions = Attentions.Instance
    Private row_affected As Integer

#Region "constructor"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'define el valor del parametro en la variable
        row_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_quotation_type.Datasources(services.services_products_type("row_visible=1"), "product_type")
        cmb_quotation_dealers.Datasources(dealer.settings_dealers_search("row_visible=1 and d.Id in (select dealer_code from [Entities.Bussines.Distributary] where agency_code in (" & sessions.agency_permit & ") and segment_code=3 and row_visible=1)"), "dealer_name")
        cmb_quotation_services.Datasources(services.services_products_listed("s.row_visible=1 and s.segment_code=3"), "Nombre del producto")

        'Carga la cotizacion seleccionada
        search_quotation()
    End Sub

    Private Sub characters_count(sender As Object, e As EventArgs) Handles txt_quotation_desc.EditValueChanged
        lbl_object_caracters.Text = Len(txt_quotation_desc.EditValue) & "/500"
    End Sub

    Private Sub search_quotation()
        Dim table_source As DataTable = resumen.attention_quotation_search("q.Id=" & row_affected)

        If table_source.Rows.Count = 1 Then
            With table_source.Rows(0)
                cmb_quotation_type.EditValue = cmb_quotation_type.Properties.GetKeyValueByDisplayText(.Item("product_type").ToString)
                cmb_quotation_dealers.EditValue = cmb_quotation_dealers.Properties.GetKeyValueByDisplayText(.Item("dealer_name").ToString)
                txt_quotation_value.EditValue = CDec(.Item("purchase_value"))
                cmb_quotation_services.EditValue = CInt(.Item("services_code"))
                txt_number_invoice.EditValue = .Item("number_invoice").ToString
            End With
        End If
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With attention.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "relationship_comercial_quotation_associate"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = row_affected
                .Parameters.Add("@number_invoice", SqlDbType.VarChar, 50).Value = txt_number_invoice.Text
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If attention.execute_procedure = True Then
                Close()
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_close.Click
        Dispose()
    End Sub
#End Region
End Class