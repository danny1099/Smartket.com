﻿Public Class wholesales_frees_edited
    Private customer As Customer = Customer.Instance
    Private agency As Agencys = Agencys.Instance
    Private dealer As Dealers = Dealers.Instance
    Private parameter As Parameters = Parameters.Instance
    Private product As Products = Products.Instance
    Private person As Persons = Persons.Instance
    Private request As Request = Request.Instance
    Private sales As Sales = Sales.Instance
    Private source_current As DataTable
    Private request_code As Integer
    Private record_affected As Integer
    Private last_control As Control

#Region "constructor"
    Public Sub New(row_selected As Integer, lasted_control As Control)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        record_affected = row_selected
        last_control = lasted_control
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load report to show data in lookupedit
        object_listed()
        search_object()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_sales_customer.Datasources(customer.comercial_customer_listed("c.row_visible=1"), "Nombre del cliente")
        cmb_sales_agency.Datasources(agency.settings_agencys_search("Id in (" & sessions.agency_permit & ") and a.row_visible=1"), "agency_name")
        cmb_sales_types.Datasources(product.services_products_type("row_visible=1"), "product_type")
        cmb_sales_quotas.Datasources(parameter.settings_search_quotas("row_visible=1"), "quotas_name")
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
                cmb_sales_quotas.EditValue = cmb_sales_quotas.Properties.GetKeyValueByDisplayText(.Item("quotas_name"))
                cmb_sales_seller.EditValue = CInt(.Item("person_code"))
                txt_sales_serial1.EditValue = .Item("number_serial1")
                txt_sales_invoice.EditValue = .Item("number_invoice").ToString
                txt_sales_import.EditValue = .Item("value_import").ToString
                chk_sales_customer.Checked = True
                chk_row_visible.Checked = CBool(.Item("row_visible"))

                'check services array and put on plan and equipment
                With fn_transform_deserialize(.Item("services_info").ToString)
                    If .Rows.Count > 0 Then
                        For i As Integer = 0 To .Rows.Count - 1
                            cmb_sales_types.EditValue = cmb_sales_types.Properties.GetKeyValueByDisplayText(.Rows(i).Item("product_type"))
                            cmb_sales_services.EditValue = CInt(.Rows(i).Item("Id"))
                        Next
                    End If
                End With

                'validate field value of sale or equipment
                txt_sales_value.EditValue = If(cmb_sales_types.EditValue = 2, CInt(.Item("value_sales2")), CInt(.Item("value_sales1")))
            End With

            'save data of current record
            source_current = trace_to_current(pnl_object_container)
        End If

        'check if this sale have request pending
        If requested.Rows.Count = 1 Then request_code = requested.Rows(0).Item("Id").ToString
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
            cmb_sales_dealer.Datasources(dealer.settings_dealers_search("row_visible=1 and d.Id in (select dealer_code from [Entities.Bussines.Distributary] where agency_code=" & cmb_sales_agency.EditValue & " and segment_code=3 and row_visible=1)"), "dealer_name")
            cmb_sales_seller.Datasources(person.settings_persons_sellers("p.row_visible=1 and p.agency_code=" & cmb_sales_agency.EditValue), "Nombre del funcionario")
            txt_sales_ceco.EditValue = cmb_sales_agency.GetColumnValue("center_operation")
        End If
    End Sub

    Private Sub types_changed(sender As Object, e As EventArgs) Handles cmb_sales_types.EditValueChanged
        If cmb_sales_types.EditValue IsNot Nothing Then
            cmb_sales_services.Datasources(product.services_products_listed("s.row_visible=1 and s.product_type=" & cmb_sales_types.EditValue & " and s.segment_code=3"), "Nombre del producto")
        End If
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_sales_seller.QueryPopUp, cmb_sales_customer.QueryPopUp, cmb_sales_services.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            With sender.Properties
                .View.Columns("Id").Visible = False
                .View.Columns("IDR").Width = 40
                .View.RowHeight = 30
            End With
        End If
    End Sub

    Private Sub customer_conserve(read_only As Boolean)
        cmb_sales_customer.Properties.ReadOnly = read_only
    End Sub

    Private Sub values_enter(sender As Object, e As EventArgs) Handles txt_sales_value.Enter, txt_sales_import.Enter
        sender.EditValue = Nothing
    End Sub

    Private Sub values_leave(sender As Object, e As EventArgs) Handles txt_sales_value.Leave, txt_sales_import.Leave
        If sender.EditValue Is Nothing Then sender.EditValue = CInt(0)
    End Sub

    Private Sub create_generate(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_sales_serial1.ButtonClick
        txt_sales_serial1.EditValue = fn_trace_number()
    End Sub

    Private Sub serial_generate(sender As Object, e As EventArgs) Handles lbl_sales_serial.Click
        txt_sales_serial1.EditValue = fn_trace_number()
    End Sub

    Private Sub customer_create(sender As Object, e As EventArgs) Handles lbl_sales_newcustomer.Click
        show_option(New comercial_customer_create(Me))
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With sales.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "wholesales_master_frees_edited"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
                .Parameters.Add("@segment_code", SqlDbType.TinyInt).Value = 3
                .Parameters.Add("@date_sale", SqlDbType.Date).Value = CDate(txt_sales_date.EditValue)
                .Parameters.Add("@number_serial1", SqlDbType.VarChar, 50).Value = Trim(txt_sales_serial1.EditValue)
                .Parameters.Add("@number_serial2", SqlDbType.VarChar, 19).Value = StrDup(17, "0")
                .Parameters.Add("@number_serial3", SqlDbType.VarChar, 15).Value = StrDup(15, "0")
                .Parameters.Add("@dealer_code", SqlDbType.TinyInt).Value = cmb_sales_dealer.EditValue
                .Parameters.Add("@operator_code", SqlDbType.TinyInt).Value = cmb_sales_dealer.GetColumnValue("operator_code")
                .Parameters.Add("@number_contract", SqlDbType.VarChar, 50).Value = "CN-000000"
                .Parameters.Add("@number_invoice", SqlDbType.VarChar, 50).Value = txt_sales_invoice.EditValue
                .Parameters.Add("@value_import", SqlDbType.Decimal, 18, 2).Value = CDbl(txt_sales_import.EditValue)
                .Parameters.Add("@ceco_siesa", SqlDbType.VarChar, 5).Value = txt_sales_ceco.EditValue
                .Parameters.Add("@product_code1", SqlDbType.Int).Value = If(cmb_sales_types.EditValue <> 2, cmb_sales_services.EditValue, 0)
                .Parameters.Add("@product_code2", SqlDbType.Int).Value = If(cmb_sales_types.EditValue = 2, cmb_sales_services.EditValue, 0)
                .Parameters.Add("@services_array", SqlDbType.VarChar, 300).Value = cmb_sales_services.EditValue
                .Parameters.Add("@value_sales1", SqlDbType.Decimal, 18, 2).Value = If(cmb_sales_types.EditValue <> 2, Replace(CDbl(Replace(txt_sales_value.EditValue, "$", "")), ",", "."), 0)
                .Parameters.Add("@value_sales2", SqlDbType.Decimal, 18, 2).Value = If(cmb_sales_types.EditValue = 2, Replace(CDbl(Replace(txt_sales_value.EditValue, "$", "")), ",", "."), 0)
                .Parameters.Add("@quotas_code", SqlDbType.TinyInt).Value = cmb_sales_quotas.EditValue
                .Parameters.Add("@mark_ported", SqlDbType.TinyInt).Value = 2
                .Parameters.Add("@mark_migration", SqlDbType.TinyInt).Value = 2
                .Parameters.Add("@mark_convergent", SqlDbType.TinyInt).Value = 2
                .Parameters.Add("@mark_advance", SqlDbType.TinyInt).Value = 2
                .Parameters.Add("@customer_code", SqlDbType.Int).Value = cmb_sales_customer.EditValue
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = cmb_sales_seller.EditValue
                .Parameters.Add("@capture_code", SqlDbType.Char, 1).Value = "M"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 5000).Value = trace_to_edited(pnl_object_container, source_current)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If sales.execute_procedure = True Then
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
