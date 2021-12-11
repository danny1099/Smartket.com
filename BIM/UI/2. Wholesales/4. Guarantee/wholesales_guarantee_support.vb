Public Class wholesales_guarantee_support
    Private customer As Customer = Customer.Instance
    Private brand As Brands = Brands.Instance
    Private causal As Request = Request.Instance
    Private guarantee As Guarantee = Guarantee.Instance
    Private lasted_control As Control
    Private record_affected As Integer

#Region "constructor"
    Public Sub New(row_selected As Integer, lasted_control_ As Control)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        record_affected = row_selected
        lasted_control = lasted_control_
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load report to show data in lookupeditt
        object_listed()
        search_object()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_guarantee_brand.Datasources(brand.services_brands_search("row_visible=1"), "brand_name")
        cmb_guarantee_causal.Datasources(causal.request_causal_search("row_visible=1 and c.module_code=2 and c.causal_type='E'"), "causal_name")
        cmb_guarantee_revision.Datasources(causal.request_causal_search("row_visible=1 and c.module_code=2 and c.causal_type='S'"), "causal_name")

        'Define la fecha de revision por defecto
        txt_guarantee_support.EditValue = Now
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub characters_count(sender As Object, e As EventArgs) Handles txt_guarantee_description.EditValueChanged
        lbl_object_caracters.Text = Len(txt_guarantee_description.EditValue) & "/500"
    End Sub

    Private Sub description_spelling(sender As Object, e As EventArgs) Handles txt_guarantee_description.Leave
        xvp_spell.Check(sender)
    End Sub

    Private Sub search_object()
        Dim table As DataTable = guarantee.wholesale_guarantee_search("g.Id=" & record_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                txt_guarantee_customer.EditValue = .Item("customer_name")
                txt_guarantee_serial.EditValue = .Item("number_serial")
                txt_guarantee_date.EditValue = CDate(.Item("date_sale"))
                txt_guarantee_invoice.EditValue = .Item("number_invoice")
                txt_guarantee_product.EditValue = .Item("product_name")
                txt_guarantee_sku.EditValue = .Item("sku_item")
                cmb_guarantee_brand.EditValue = cmb_guarantee_brand.Properties.GetKeyValueByDisplayText(.Item("brand_name"))
                cmb_guarantee_causal.SetEditValue(.Item("causals_split"))

                'valida si la garantia ya tiene una revision para actualizar
                If .Item("support_date").ToString <> "" Then txt_guarantee_date.EditValue = CDate(.Item("support_date"))
                If .Item("revision_type").ToString <> "" Then cmb_guarantee_revision.EditValue = cmb_guarantee_revision.Properties.GetKeyValueByDisplayText(.Item("revision_type"))
                If .Item("support_text").ToString <> "" Then txt_guarantee_description.EditValue = .Item("support_text")
            End With

            'save data of current record
            trace_to_current(pnl_object_container)
        End If
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            If cmb_guarantee_revision.Text <> "Pendiente Solución" Then
                With guarantee.sql_command
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "wholesales_master_guarantee_support"

                    .Parameters.Clear()
                    .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
                    .Parameters.Add("@revision_code", SqlDbType.TinyInt).Value = cmb_guarantee_revision.EditValue
                    .Parameters.Add("@support_date", SqlDbType.Date).Value = txt_guarantee_support.EditValue
                    .Parameters.Add("@description_text", SqlDbType.VarChar, 500).Value = txt_guarantee_description.EditValue
                    .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                    .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                    .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                    .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                    .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
                End With

                If guarantee.execute_procedure = True Then
                    start_home.removed_tabbed()
                End If
            Else
                message_text("La revisión no se puede finalizar con el estado seleccionado", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
