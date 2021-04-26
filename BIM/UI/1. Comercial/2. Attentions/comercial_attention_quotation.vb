Public Class comercial_attention_quotation
    Private services As Products = Products.Instance
    Private dealer As Dealers = Dealers.Instance
    Private attention As Attentions = Attentions.Instance
    Private row_affected As Integer

#Region "constructor"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
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
    End Sub

    Private Sub typed_changed(sender As Object, e As EventArgs) Handles cmb_quotation_type.EditValueChanged
        If cmb_quotation_type.EditValue IsNot Nothing Then
            cmb_quotation_services.Datasources(services.services_products_listed("s.row_visible=1 and s.segment_code=3 and s.product_type=" & cmb_quotation_type.EditValue), "Nombre del producto")
        End If
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_quotation_services.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            sender.Properties.View.Columns("Id").Visible = False
        End If
    End Sub

    Private Sub characters_count(sender As Object, e As EventArgs) Handles txt_quotation_desc.EditValueChanged
        lbl_object_caracters.Text = Len(txt_quotation_desc.EditValue) & "/500"
    End Sub

    Private Sub description_spelling(sender As Object, e As EventArgs) Handles txt_quotation_desc.Leave
        xvp_spell.Check(sender)
    End Sub

    Private Sub default_object()
        txt_quotation_value.EditValue = 0
        lbl_object_caracters.Text = 0 / 500
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With attention.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "relationship_comercial_quotation_create"

                .Parameters.Clear()
                .Parameters.Add("@attention_code", SqlDbType.Int).Value = row_affected
                .Parameters.Add("@segment_code", SqlDbType.TinyInt).Value = 3
                .Parameters.Add("@operator_code", SqlDbType.TinyInt).Value = cmb_quotation_dealers.GetColumnValue("operator_code")
                .Parameters.Add("@dealer_code", SqlDbType.TinyInt).Value = cmb_quotation_dealers.EditValue
                .Parameters.Add("@services_code", SqlDbType.Int).Value = cmb_quotation_services.EditValue
                .Parameters.Add("@purchase_value", SqlDbType.Decimal, 18, 2).Value = CDec(txt_quotation_value.EditValue)
                .Parameters.Add("@description_text", SqlDbType.VarChar, 500).Value = If(txt_quotation_desc.EditValue, "Creación de cotización del producto " & cmb_quotation_services.Text & " por el usuario " & sessions.person_name)
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If attention.execute_procedure = True Then
                If chk_keep_form.Checked = True Then
                    defaults_objects(pnl_object_container)
                    default_object()
                Else
                    If My.Settings.window_tabs = True Then start_home.removed_tabbed() Else Close()
                End If
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class