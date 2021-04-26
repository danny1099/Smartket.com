Public Class wholesales_movil_edited
    Private customer As Customer = Customer.Instance
    Private agency As Agencys = Agencys.Instance
    Private dealer As Dealers = Dealers.Instance
    Private parameter As Parameters = Parameters.Instance
    Private product As Products = Products.Instance
    Private person As Persons = Persons.Instance
    Private sales As Sales = Sales.Instance
    Private request As Request = Request.Instance
    Private source_current As DataTable
    Private last_control As Control
    Private request_code As Integer
    Private record_affected As Integer


#Region "constructor"
    Public Sub New(row_selected As Integer, lasted_control As Control)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        record_affected = row_selected
        last_control = lasted_control
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load report to show data in lookupeditt
        object_listed()
        search_object()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_sales_customer.Datasources(customer.comercial_customer_listed("c.row_visible=1"), "Nombre del cliente")
        cmb_sales_agency.Datasources(agency.settings_agencys_search("Id in (" & sessions.agency_permit & ") and a.row_visible=1"), "agency_name")
        cmb_sales_quotas.Datasources(parameter.settings_search_quotas("row_visible=1"), "quotas_name")
        cmb_sales_equipment.Datasources(product.services_products_listed("s.row_visible=1 and s.product_type=2 and s.segment_code=1"), "Nombre del producto")
    End Sub

    Private Sub search_object()
        Dim table As DataTable = sales.wholesale_sales_search("s.Id=" & record_affected)
        Dim requested As DataTable = request.wholesale_request_search("r.wholesale_code=" & record_affected & " and r.row_visible=3")

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                cmb_sales_customer.EditValue = CInt(.Item("customer_code"))
                cmb_sales_agency.EditValue = cmb_sales_agency.Properties.GetKeyValueByDisplayText(.Item("agency_name"))
                txt_sales_date.EditValue = CDate(.Item("date_sale"))
                cmb_sales_dealer.EditValue = cmb_sales_dealer.Properties.GetKeyValueByDisplayText(.Item("dealer_name"))
                txt_sales_value.EditValue = CInt(.Item("value_sales2"))
                txt_sales_import.EditValue = CInt(.Item("value_import"))
                cmb_sales_quotas.EditValue = cmb_sales_quotas.Properties.GetKeyValueByDisplayText(.Item("quotas_name"))
                cmb_sales_seller.EditValue = CInt(.Item("person_code"))
                txt_sales_serial1.EditValue = .Item("number_serial1")
                txt_sales_serial2.EditValue = .Item("number_serial2")
                txt_sales_serial3.EditValue = .Item("number_serial3")
                cmb_sales_plan.EditValue = CInt(.Item("product_code1"))
                chk_row_visible.Checked = CBool(.Item("row_visible"))

                'validate field to condicion of form
                If .Item("mark_ported").ToString = "1" Then chk_sales_ported.Checked = True
                If .Item("mark_migration").ToString = "1" Then chk_sales_migration.Checked = True
                If .Item("mark_convergent").ToString = "1" Then chk_sales_convergent.Checked = True
                If .Item("mark_advance").ToString = "1" Then chk_sales_cfm.Checked = True
                If .Item("number_invoice").ToString <> "CN-00000" Then txt_sales_invoice.EditValue = .Item("number_invoice").ToString
                If .Item("number_contract").ToString <> "FV-00000" Then txt_sales_contract.EditValue = .Item("number_contract").ToString
                If .Item("product_code2").ToString <> "0" Then cmb_sales_equipment.EditValue = CInt(.Item("product_code2")) Else chk_sales_equipment.Checked = False

                'save data of current record
                source_current = trace_to_current(pnl_object_container)
            End With

            'check if this sale have request pending
            If requested.Rows.Count = 1 Then request_code = requested.Rows(0).Item("Id").ToString
        End If
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub agency_change(sender As Object, e As EventArgs) Handles cmb_sales_agency.EditValueChanged
        If cmb_sales_agency.EditValue IsNot Nothing Then
            cmb_sales_dealer.Datasources(dealer.settings_dealers_search("row_visible=1 and d.Id in (select dealer_code from [Entities.Bussines.Distributary] where agency_code=" & cmb_sales_agency.EditValue & " and segment_code=1 and row_visible=1)"), "dealer_name")
            cmb_sales_seller.Datasources(person.settings_persons_sellers("p.row_visible=1 and p.agency_code=" & cmb_sales_agency.EditValue), "Nombre del funcionario")
        End If
    End Sub

    Private Sub dealer_change(sender As Object, e As EventArgs) Handles cmb_sales_dealer.EditValueChanged
        If cmb_sales_dealer.EditValue IsNot Nothing Then
            cmb_sales_plan.Datasources(product.services_products_listed("s.row_visible=1 and s.product_type=1 and s.segment_code=1 and s.operator_code=" & cmb_sales_dealer.GetColumnValue("operator_code")), "Nombre del producto")
        End If
    End Sub

    Private Sub equipment_change(sender As Object, e As EventArgs) Handles cmb_sales_equipment.EditValueChanged
        If cmb_sales_equipment.EditValue IsNot Nothing Then
            chk_sales_equipment.Checked = True
        End If
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_sales_plan.QueryPopUp, cmb_sales_equipment.QueryPopUp, cmb_sales_customer.QueryPopUp, cmb_sales_seller.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            With sender.Properties
                .View.Columns("Id").Visible = False
                .View.Columns("IDR").Width = 40
                .View.RowHeight = 30
            End With
        End If
    End Sub

    Private Sub values_enter(sender As Object, e As EventArgs) Handles txt_sales_value.Enter, txt_sales_import.Enter
        sender.EditValue = Nothing
    End Sub

    Private Sub values_leave(sender As Object, e As EventArgs) Handles txt_sales_value.Leave, txt_sales_import.Leave
        If sender.EditValue Is Nothing Then sender.EditValue = CInt(0)
    End Sub

    Private Sub customer_create(sender As Object, e As EventArgs) Handles lbl_sales_newcustomer.Click
        show_option(New comercial_customer_create(Me))
    End Sub

    Private Function fn_product_value(product_object As Object) As Integer
        Dim value_selected As Integer

        If product_object.Text = "" Then value_selected = 0
        If product_object.Text <> "" Then value_selected = product_object.EditValue

        Return value_selected
    End Function

    Private Sub check_equipment(sender As Object, e As EventArgs) Handles chk_sales_equipment.CheckedChanged
        If chk_sales_equipment.Checked = True Then
            cmb_sales_equipment.Properties.ReadOnly = False
            cmb_sales_equipment.EditValue = Nothing
            txt_sales_serial3.EditValue = Nothing
            txt_sales_serial3.Properties.ReadOnly = False
        Else
            cmb_sales_equipment.Properties.ReadOnly = True
            cmb_sales_equipment.EditValue = Nothing
            txt_sales_serial3.EditValue = StrDup(15, "0")
            txt_sales_serial3.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub seriales_checking(sender As Object, e As EventArgs) Handles txt_sales_serial1.Leave, txt_sales_serial2.Leave, txt_sales_serial3.Leave
        If sender.EditValue IsNot Nothing Then
            caracteres_count(sender)
        End If
    End Sub

    Private Function caracteres_count(text_control As Object) As String
        If Len(text_control.EditValue) < text_control.Properties.MaxLength Then Return message_text("El numero de serial " & text_control.Tag.ToString & " no tiene la cantidad de caracteres requeridos", MessageBoxButtons.OK)
    End Function
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With customer.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "wholesales_master_movil_edited"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
                .Parameters.Add("@segment_code", SqlDbType.TinyInt).Value = 1
                .Parameters.Add("@date_sale", SqlDbType.Date).Value = CDate(txt_sales_date.EditValue)
                .Parameters.Add("@number_serial1", SqlDbType.VarChar, 10).Value = txt_sales_serial1.EditValue
                .Parameters.Add("@number_serial2", SqlDbType.VarChar, 17).Value = txt_sales_serial2.EditValue
                .Parameters.Add("@number_serial3", SqlDbType.VarChar, 15).Value = txt_sales_serial3.EditValue
                .Parameters.Add("@dealer_code", SqlDbType.TinyInt).Value = cmb_sales_dealer.EditValue
                .Parameters.Add("@operator_code", SqlDbType.TinyInt).Value = cmb_sales_dealer.GetColumnValue("operator_code")
                .Parameters.Add("@number_contract", SqlDbType.VarChar, 50).Value = If(txt_sales_contract.EditValue IsNot Nothing, txt_sales_contract.EditValue, "CN-000000")
                .Parameters.Add("@number_invoice", SqlDbType.VarChar, 50).Value = If(txt_sales_invoice.EditValue IsNot Nothing, txt_sales_invoice.EditValue, "FE-000000")
                .Parameters.Add("@value_import", SqlDbType.Decimal, 18, 2).Value = CDbl(txt_sales_import.EditValue)
                .Parameters.Add("@product_code1", SqlDbType.Int).Value = cmb_sales_plan.EditValue
                .Parameters.Add("@product_code2", SqlDbType.Int).Value = fn_product_value(cmb_sales_equipment)
                .Parameters.Add("@value_sales1", SqlDbType.Decimal, 18, 2).Value = CDbl(cmb_sales_plan.Properties.View.GetFocusedRowCellValue("Valor de producto"))
                .Parameters.Add("@value_sales2", SqlDbType.Decimal, 18, 2).Value = CDbl(txt_sales_value.EditValue)
                .Parameters.Add("@quotas_code", SqlDbType.TinyInt).Value = cmb_sales_quotas.EditValue
                .Parameters.Add("@mark_ported", SqlDbType.TinyInt).Value = If(chk_sales_ported.Checked = True, 1, 2)
                .Parameters.Add("@mark_migration", SqlDbType.TinyInt).Value = If(chk_sales_migration.Checked = True, 1, 2)
                .Parameters.Add("@mark_convergent", SqlDbType.TinyInt).Value = If(chk_sales_convergent.Checked = True, 1, 2)
                .Parameters.Add("@mark_advance", SqlDbType.TinyInt).Value = If(chk_sales_cfm.Checked = True, 1, 2)
                .Parameters.Add("@customer_code", SqlDbType.Int).Value = cmb_sales_customer.EditValue
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = cmb_sales_seller.EditValue
                .Parameters.Add("@capture_code", SqlDbType.Char, 1).Value = "M"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_edited(pnl_object_container, source_current)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If customer.execute_procedure = True Then
                If request.wholesale_request_status(request_code, 1, False) = True Then
                End If

                'return to sales master show
                start_home.removed_tabbed()
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
               start_home.removed_tabbed()
    End Sub
#End Region
End Class
