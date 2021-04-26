Imports APDA.Object.Controls
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls


Public Class wholesales_returns_created
    Private agency As Agencys = Agencys.Instance
    Private causal As Request = Request.Instance
    Private dealer As Dealers = Dealers.Instance
    Private document As Documents = Documents.Instance
    Private parameters As Parameters = Parameters.Instance
    Private product As Products = Products.Instance
    Private person As Persons = Persons.Instance
    Private returns As Returns = Returns.Instance
    Private sales As Sales = Sales.Instance

    Private column_product As New RepositorySearch
    Private column_status As New RepositoryListed
    Private source_products As DataTable
    Private source_images As New List(Of String)
    Private customer_code As Integer

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        'Limpia los datos existentes de las tablas
        If source_products IsNot Nothing Then If source_products.Rows.Count > 0 Then source_products.Rows.Clear()

        'Carga los datos de clientes y productos en tablas independientes
        source_products = product.services_products_listed("s.row_visible=1 and s.segment_code=3")

        'Carga los listados de datos
        cmb_returns_agency.Datasources(agency.settings_agencys_search("row_visible=1"), "agency_name")
        cmb_returns_dealer.Datasources(dealer.settings_dealers_search("row_visible=1 and d.operator_code=4"), "dealer_name")
        cmb_returns_provider.Datasources(parameters.settings_search_dispatch("row_visible=1"), "dispatch_name")
        cmb_returns_person.Datasources(person.settings_persons_listed("p.row_visible=1"), "Nombre del funcionario")
        cmb_returns_type.Datasources(causal.request_causal_search("row_visible=1 and c.module_code=6 and c.causal_type='R'"), "causal_name")

        column_product.Datasources(source_products, "Nombre del producto")
        column_status.Datasources(causal.request_causal_search("row_visible=1 and c.module_code=6 and c.causal_type='E'"), "causal_name")
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub agency_change(sender As Object, e As EventArgs) Handles cmb_returns_agency.EditValueChanged
        If cmb_returns_agency.EditValue IsNot Nothing Then
            cmb_returns_seller.Datasources(person.settings_persons_listed("p.row_visible=1 and p.agency_code=" & cmb_returns_agency.EditValue), "Nombre del funcionario")
        End If
    End Sub

    Private Function products_added(data_source As DataTable) As String
        Return fn_transform_serialize(data_source)
    End Function

    Private Sub wholesale_search(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_returns_center.ButtonClick
        If e.Button.Kind = ButtonPredefines.Search Then
            search_invoice()
        End If
    End Sub

    Private Sub wholesale_enter(sender As Object, e As KeyEventArgs) Handles txt_returns_center.KeyDown
        If txt_returns_invoice.EditValue IsNot Nothing Then
            If e.KeyData = Keys.Enter Then search_invoice()
        End If
    End Sub

    Private Sub search_invoice()
        Dim table_source As DataTable = sales.wholesale_sales_search("s.number_invoice='" & txt_returns_invoice.EditValue & "' and s.ceco_siesa='" & txt_returns_center.EditValue & "'")
        Dim json_product As String = String.Empty

        If table_source.Rows.Count > 0 Then
            With table_source
                txt_returns_customer.EditValue = .Rows(0).Item("customer_name").ToString
                txt_returns_date.EditValue = CDate(.Rows(0).Item("date_sale"))
                cmb_returns_dealer.EditValue = cmb_returns_dealer.Properties.GetKeyValueByDisplayText(.Rows(0).Item("dealer_name").ToString)
                cmb_returns_agency.EditValue = cmb_returns_agency.Properties.GetKeyValueByDisplayText(.Rows(0).Item("agency_name").ToString)
                cmb_returns_seller.EditValue = cmb_returns_seller.Properties.GetKeyValueByDisplayText(.Rows(0).Item("person_name").ToString)
                customer_code = .Rows(0).Item("customer_code").ToString

                'Recorre todos los items json de la venta consultada
                For i As Integer = 0 To .Rows.Count - 1
                    json_product += Replace(Replace(.Rows(i).Item("json_products").ToString, "[", ""), "]", "") & If(i = .Rows.Count - 1, "", ",")
                Next

                'Carga los datos de los productos agregados
                create_datagrid(fn_transform_deserialize("[" & json_product & "]"))
            End With
        Else
            message_text("No se encontró datos coincidentes", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub images_adding(sender As Object, e As EventArgs) Handles lbl_object_addimages.Click
        If xfd_path.ShowDialog = DialogResult.OK Then
            If message_text("Está seguro que desea agregar la(s) imagen(es) seleccionada(s)?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                For Each item_name As String In xfd_path.FileNames
                    With source_images
                        .Add(item_name)
                    End With
                Next

                'Comprueba que el listado de bytes este cargado para mostrar el mensaje de finalizado
                If source_images.Count >= 1 Then
                    message_text("Las imagenes fueron adjuntadas exitosamente", MessageBoxButtons.OK)
                    lbl_object_addimages.Text = "Adjuntar imagenes de soporte (" & source_images.Count.ToString & ")"
                End If
            End If
        End If
    End Sub

    Private Sub description_spelling(sender As Object, e As EventArgs) Handles txt_returns_description.Leave
        xvp_spell.Check(sender)
    End Sub

    Private Function validate_items() As Boolean
        With dgv_object_view
            If .RowCount >= 1 Then
                For i As Integer = 0 To .DataRowCount - 1
                    If dgv_object_view.GetRowCellValue(i, "Estado") = "" Then
                        Return False
                    End If
                Next

                Return True
            End If
        End With

        Return False
    End Function
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With returns.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "wholesales_master_returns_created"

                .Parameters.Clear()
                .Parameters.Add("@number_invoice", SqlDbType.VarChar, 50).Value = txt_returns_invoice.EditValue
                .Parameters.Add("@center_siesa", SqlDbType.VarChar, 10).Value = txt_returns_center.EditValue
                .Parameters.Add("@date_sale", SqlDbType.Date).Value = txt_returns_date.EditValue
                .Parameters.Add("@dealer_code", SqlDbType.TinyInt).Value = cmb_returns_dealer.EditValue
                .Parameters.Add("@customer_code", SqlDbType.Int).Value = customer_code
                .Parameters.Add("@product_added", SqlDbType.VarChar).Value = products_added(TryCast(dgv_object_grid.DataSource, DataTable))
                .Parameters.Add("@dispatch_number", SqlDbType.VarChar, 50).Value = txt_returns_dispatch.EditValue
                .Parameters.Add("@dispatch_provider", SqlDbType.TinyInt).Value = cmb_returns_provider.EditValue
                .Parameters.Add("@total_ammount", SqlDbType.SmallInt).Value = dgv_object_view.RowCount
                .Parameters.Add("@value_sales", SqlDbType.Decimal, 18, 2).Value = CDec(total_values(False))
                .Parameters.Add("@agency_code", SqlDbType.TinyInt).Value = cmb_returns_agency.EditValue
                .Parameters.Add("@seller_code", SqlDbType.SmallInt).Value = cmb_returns_seller.EditValue
                .Parameters.Add("@closed_date", SqlDbType.DateTime).Value = DBNull.Value
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = cmb_returns_person.EditValue
                .Parameters.Add("@devolution_type", SqlDbType.SmallInt).Value = cmb_returns_type.EditValue
                .Parameters.Add("@description_text", SqlDbType.VarChar, 500).Value = txt_returns_description.EditValue
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_resumen)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@row_affected", SqlDbType.Int).Direction = ParameterDirection.Output
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output


                'Ejecuta el proceso de registro y limpia los campos utilizados
                If returns.execute_procedure = True Then
                    'Obtiene el codigo de registro de la peticion para asociar a las fotos
                    Dim row_affected As Integer = CInt(.Parameters("@row_affected").Value.ToString)

                    If source_images.Count > 0 Then
                        'Ejecuta el metodo para crear las imagenes asociadas
                        If document.documents_master_create(row_affected, "Wholesales.Masters.Returns", source_images) = True Then
                            default_form()
                        End If
                    Else
                        default_form()
                    End If
                End If
            End With
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        start_home.removed_tabbed()
    End Sub

    Private Sub default_form()
        If chk_keep_form.Checked = True Then
            defaults_objects(pnl_object_resumen)
            clean_products()
        Else
            start_home.removed_tabbed()
        End If
    End Sub
#End Region

#Region "helpers"
    Private Sub create_datagrid(copy_source As DataTable)
        'Define el origen de datos al grid control
        dgv_object_grid.DataSource = datagrid_columns(copy_source)

        column_product.View.BestFitColumns(True)

        'parametriza las columnas de la vista
        With dgv_object_view
            .Columns("col_returns_product").Caption = "Nombre del producto"
            .Columns("col_returns_sku").Caption = "SKU"
            .Columns("col_returns_value").Caption = "Valor Unitario"
            .Columns("col_returns_serial").Caption = "Numero de serial"
            .Columns("col_returns_status").Caption = "Estado"

            'Define la columna de producto para seleccion con listado
            .Columns("col_returns_product").ColumnEdit = column_product
            .Columns("col_returns_status").ColumnEdit = column_status

            'Ajusta las columnas agregadas
            datagrid_ajusted()
        End With
    End Sub

    Private Function datagrid_columns(copy_source As DataTable) As DataTable
        Dim source_data As New DataTable

        With source_data
            .Columns.Add("col_returns_product", GetType(String))
            .Columns.Add("col_returns_sku", GetType(String))
            .Columns.Add("col_returns_value", GetType(Decimal))
            .Columns.Add("col_returns_serial", GetType(String))
            .Columns.Add("col_returns_status", GetType(String))
        End With

        'Copia los valores a la tabla fuente para la grilla de resultados
        source_data = copy_source.Copy

        Return source_data
    End Function

    Private Sub datagrid_ajusted()
        With dgv_object_view
            .Columns("col_returns_product").Width = 550
            .Columns("col_returns_sku").Width = 55
            .Columns("col_returns_value").Width = 125
            .Columns("col_returns_serial").Width = 125
            .Columns("col_returns_status").Width = 180

            'Centra los datos de las celdas
            .Columns("col_returns_sku").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_returns_value").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            'Centra los encabezados de la columnas
            .Columns("col_returns_product").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_returns_sku").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_returns_value").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            'Agrega el formato de valores para el total
            .Columns("col_returns_value").UnboundType = DevExpress.Data.UnboundColumnType.Decimal
            .Columns("col_returns_value").DisplayFormat.FormatType = FormatType.Numeric
            .Columns("col_returns_value").DisplayFormat.FormatString = "c0"
        End With
    End Sub

    Private Sub row_updated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles dgv_object_view.RowUpdated
        lbl_object_count.Text = total_values()
    End Sub

    Private Function total_values(Optional use_format As Boolean = True) As String
        Dim value_resmision As Double = 0
        Dim value_total As Double = 0

        Try
            For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                value_resmision = CDbl(Replace(Replace(Replace(dgv_object_view.GetRowCellValue(i, "col_returns_value"), ".", ""), "$", ""), "- ", "-"))
                value_total += value_resmision
            Next

        Catch ex As Exception
        End Try

        Return If(use_format = True, FormatCurrency(value_total, 0), value_total)
    End Function

    Private Sub selection_changed(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles dgv_object_view.CellValueChanged
        Dim grid_view As GridView = TryCast(sender, GridView)

        If grid_view IsNot Nothing Then
            With grid_view
                'Define el valor seleccionado
                If .GetRowCellValue(e.RowHandle, "col_returns_product").ToString <> "" And .GetRowCellValue(e.RowHandle, "col_returns_product").ToString = "" Then
                    Dim value_selected As String = .GetRowCellValue(e.RowHandle, "col_returns_product").ToString
                    Dim row_search As DataRow() = TryCast(source_products.Select("Id='" & value_selected & "'"), DataRow())

                    .SetFocusedRowCellValue("col_returns_sku", row_search(0).Item("SKU").ToString)
                End If
            End With
        End If
    End Sub

    Private Sub clean_products()
        'Limpia las filas cargadas
        If dgv_object_view.RowCount > 0 Then
            For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                dgv_object_view.DeleteRow(dgv_object_view.GetRowHandle(i))
            Next
        End If

        source_images.Clear()
        lbl_object_addimages.Text = "Adjuntar imagenes de soporte"
    End Sub
#End Region
End Class
