Imports APDA.Object.Controls
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Public Class wholesales_orders_created
    Private customer As Customer = Customer.Instance
    Private agency As Agencys = Agencys.Instance
    Private parameter As Parameters = Parameters.Instance
    Private dealer As Dealers = Dealers.Instance
    Private product As Products = Products.Instance
    Private person As Persons = Persons.Instance
    Private orders_ As Orders = Orders.Instance
    Private column_product As New RepositorySearch
    Private source_products As DataTable
    Private source_customer As DataTable

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
        create_datagrid()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        'Limpia los datos existentes de las tablas
        If source_products IsNot Nothing Then If source_products.Rows.Count > 0 Then source_products.Rows.Clear()
        If source_customer IsNot Nothing Then If source_customer.Rows.Count > 0 Then source_customer.Rows.Clear()

        'Carga los datos de clientes y productos en tablas independientes
        source_products = product.services_products_listed("s.row_visible=1 and s.segment_code=3")
        source_customer = customer.comercial_customer_listed("c.row_visible=1")

        'Carga los listados de datos
        cmb_orders_agency.Datasources(agency.settings_agencys_search("Id in (" & sessions.agency_permit & ") and a.row_visible=1"), "agency_name")
        cmb_orders_deptos.Datasources(parameter.settings_search_deptos("row_visible=1"), "department_name")
        cmb_orders_payment.Datasources(parameter.settings_search_payments("row_visible=1"), "payment_method")
        cmb_orders_platform.Datasources(dealer.settings_dealers_search("row_visible=1 and d.operator_code=4"), "dealer_name")
        cmb_orders_customer.Datasources(source_customer, "Nombre del cliente")
        column_product.Datasources(source_products, "Nombre del producto")
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub agency_change(sender As Object, e As EventArgs) Handles cmb_orders_agency.EditValueChanged
        If cmb_orders_agency.EditValue IsNot Nothing Then
            cmb_orders_person.Datasources(person.settings_persons_listed("p.row_visible=1 and p.agency_code=" & cmb_orders_agency.EditValue), "Nombre del funcionario")
        End If
    End Sub

    Private Sub deptos_changed(sender As Object, e As EventArgs) Handles cmb_orders_deptos.EditValueChanged
        If cmb_orders_deptos.EditValue IsNot Nothing Then
            cmb_orders_cities.Datasources(parameter.settings_search_cities("depto_code=" & cmb_orders_deptos.EditValue), "city_name")
        End If
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_orders_person.QueryPopUp, cmb_orders_customer.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            With sender.Properties
                .View.Columns("Id").Visible = False
                .View.Columns("IDR").Width = 40
                .View.RowHeight = 30
            End With
        End If
    End Sub

    Private Sub customer_newaddres(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_orders_address.ButtonClick
        Using new_ As New comercial_customer_address
            new_.ShowDialog(start_home)

            If new_.address_name <> "" Then
                txt_orders_address.EditValue = new_.address_name.ToString
            End If
        End Using
    End Sub

    Private Sub customer_create(sender As Object, e As EventArgs) Handles lbl_orders_newcustomer.Click
        show_option(New comercial_customer_create(Me))
    End Sub

    Private Sub customer_changed(sender As Object, e As EventArgs) Handles cmb_orders_customer.EditValueChanged
        'Valida si el cliente seleccionado no es vacio o igual a cero (0)
        If cmb_orders_customer.EditValue IsNot Nothing Then
            If cmb_orders_customer.EditValue.ToString <> "" And cmb_orders_customer.EditValue.ToString <> "0" Then
                If message_text("Desea actualizar la información del cliente seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    show_option(New comercial_customer_edited(cmb_orders_customer.EditValue, Me))
                End If
            End If
        End If
    End Sub

    Private Function products_added(data_source As DataTable) As String
        Return fn_transform_serialize(data_source)
    End Function

    Private Sub characters_count(sender As Object, e As EventArgs) Handles txt_orders_description.EditValueChanged
        lbl_object_caracters.Text = Len(txt_orders_description.EditValue) & "/500"
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True And dgv_object_view.RowCount > 0 Then
            With orders_.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "wholesales_master_orders_created"

                .Parameters.Clear()
                .Parameters.Add("@customer_code", SqlDbType.Int).Value = cmb_orders_customer.EditValue
                .Parameters.Add("@place_address", SqlDbType.VarChar, 100).Value = txt_orders_address.EditValue
                .Parameters.Add("@neighborhood", SqlDbType.VarChar, 50).Value = txt_orders_neighborhood.EditValue
                .Parameters.Add("@email", SqlDbType.VarChar, 100).Value = txt_orders_email.EditValue
                .Parameters.Add("@city_code", SqlDbType.SmallInt).Value = cmb_orders_cities.EditValue
                .Parameters.Add("@payment_method", SqlDbType.TinyInt).Value = cmb_orders_payment.EditValue
                .Parameters.Add("@purchase_order", SqlDbType.VarChar, 50).Value = txt_orders_purcharse.EditValue
                .Parameters.Add("@plataform_code", SqlDbType.TinyInt).Value = cmb_orders_platform.EditValue
                .Parameters.Add("@agency_code", SqlDbType.TinyInt).Value = cmb_orders_agency.EditValue
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = cmb_orders_person.EditValue
                .Parameters.Add("@product_added", SqlDbType.VarChar).Value = products_added(TryCast(dgv_object_grid.DataSource, DataTable))
                .Parameters.Add("@order_type", SqlDbType.Char, 1).Value = If(chk_orders_type.Checked = True, "R", "F")
                .Parameters.Add("@description_text", SqlDbType.VarChar, 500).Value = txt_orders_description.EditValue
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_resumen)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If orders_.execute_procedure = True Then
                If chk_keep_form.Checked = True Then
                    defaults_objects(pnl_object_resumen)
                    clean_products()
                Else
                    start_home.removed_tabbed()
                End If
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        start_home.removed_tabbed()
    End Sub
#End Region

#Region "helpers"
    Private Sub create_datagrid()
        'Define el origen de datos al grid control
        dgv_object_grid.DataSource = datagrid_columns()
        column_product.View.BestFitColumns(True)

        'parametriza las columnas de la vista
        With dgv_object_view
            .Columns("col_remision_product").Caption = "Nombre del producto"
            .Columns("col_remision_code").Caption = "SKU"
            .Columns("col_remision_value").Caption = "Valor Unitario"
            .Columns("col_remision_ammount").Caption = "Cantidad"
            .Columns("col_remision_serial").Visible = False

            'Define la columna de producto para seleccion con listado
            .Columns("col_remision_product").ColumnEdit = column_product

            'Ajusta las columnas agregadas
            datagrid_ajusted()
        End With
    End Sub

    Private Function datagrid_columns() As DataTable
        Dim source_data As New DataTable

        With source_data
            .Columns.Add("col_remision_product", GetType(String))
            .Columns.Add("col_remision_code", GetType(String))
            .Columns.Add("col_remision_value", GetType(Decimal))
            .Columns.Add("col_remision_ammount", GetType(Integer))
            .Columns.Add("col_remision_serial", GetType(String))
        End With

        Return source_data
    End Function

    Private Sub datagrid_ajusted()
        With dgv_object_view
            .Columns("col_remision_product").Width = 550
            .Columns("col_remision_code").Width = 55
            .Columns("col_remision_ammount").Width = 55
            .Columns("col_remision_value").Width = 125

            'Centra los datos de las celdas
            .Columns("col_remision_code").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_remision_ammount").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_remision_value").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            'Centra los encabezados de la columnas
            .Columns("col_remision_code").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_remision_ammount").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_remision_value").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            'Agrega el formato de valores para el total
            .Columns("col_remision_value").UnboundType = DevExpress.Data.UnboundColumnType.Decimal
            .Columns("col_remision_value").DisplayFormat.FormatType = FormatType.Numeric
            .Columns("col_remision_value").DisplayFormat.FormatString = "c0"
        End With
    End Sub

    Private Sub customization_viewer(sender As Object, e As EventArgs) Handles dgv_object_view.HideCustomizationForm
        dgv_object_view.SaveLayoutToXml("C:\APDA\BIM\bin\" & Me.Name & ".xml")
    End Sub

    Private Sub row_updated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles dgv_object_view.RowUpdated
        lbl_object_count.Text = total_values()
    End Sub

    Private Sub count_rows(sender As Object, e As EventArgs) Handles dgv_object_view.ColumnFilterChanged
        lbl_object_count.Text = total_values()
    End Sub

    Private Function total_values() As String
        Dim value_ammount As Integer = 0
        Dim value_resmision As Double = 0
        Dim value_total As Double = 0

        Try
            For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                value_resmision = CDbl(Replace(Replace(Replace(dgv_object_view.GetRowCellValue(i, "col_remision_value"), ".", ""), "$", ""), "- ", "-"))
                value_ammount = CInt(dgv_object_view.GetRowCellValue(i, "col_remision_ammount"))
                value_total += value_resmision * value_ammount
            Next
        Catch ex As Exception
        End Try

        Return FormatCurrency(value_total, 0)
    End Function

    Private Sub selection_changed(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles dgv_object_view.CellValueChanged
        Dim grid_view As GridView = TryCast(sender, GridView)

        If grid_view IsNot Nothing Then
            With grid_view
                'Define el valor seleccionado
                If .GetRowCellValue(e.RowHandle, "col_remision_product").ToString <> "" And .GetRowCellValue(e.RowHandle, "col_remision_code").ToString = "" Then
                    Dim value_selected As String = .GetRowCellValue(e.RowHandle, "col_remision_product").ToString
                    Dim row_search As DataRow() = TryCast(source_products.Select("Id='" & value_selected & "'"), DataRow())

                    .SetFocusedRowCellValue("col_remision_code", row_search(0).Item("SKU").ToString)
                End If
            End With
        End If
    End Sub

    Private Sub clean_products()
        If dgv_object_view.RowCount > 0 Then
            For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                dgv_object_view.DeleteRow(dgv_object_view.GetRowHandle(i))
            Next
        End If
    End Sub
#End Region
End Class
