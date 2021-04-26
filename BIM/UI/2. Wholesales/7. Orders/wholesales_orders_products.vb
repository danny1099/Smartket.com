Imports APDA.Object.Controls
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Public Class wholesales_orders_products
    Private orders_ As Orders = Orders.Instance
    Private column_product As New RepositorySearch
    Private product As Products = Products.Instance
    Private source_products As DataTable
    Private record_affected As Integer

#Region "constructor"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        record_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
        search_object()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        'Carga los datos de clientes y productos en tablas independientes
        source_products = product.services_products_listed("s.row_visible=1 and s.segment_code=3")

        'Carga los listados de datos
        column_product.Datasources(source_products, "Nombre del producto")

        'Carga los permisos de usuario para el modulo
        search_permits()
    End Sub

    Private Sub search_permits()
        If sessions.admin_user <> 1 Then
            Dim table As DataTable = sessions.search_permission

            If table.Rows.Count > 0 Then
                With table
                    'check if options new is enabled
                    If .Select("action_object='btn_object_updated' and option_showed='wholesales_orders_showed'").Count = 0 Then
                        btn_object_updated.Size = btn_object_updated.MinimumSize
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub search_object()
        Dim table_search As DataTable = orders_.wholesale_orders_search("o.Id=" & record_affected)

        If table_search.Rows.Count = 1 Then
            With table_search.Rows(0)
                create_datagrid(fn_transform_deserialize(.Item("product_added").ToString))
            End With
        End If
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

    Private Function products_added(data_source As DataTable) As String
        Return fn_transform_serialize(data_source)
    End Function
#End Region

#Region "helpers"
    Private Sub create_datagrid(copy_source As DataTable)
        'Define el origen de datos al grid control
        dgv_object_grid.DataSource = datagrid_columns(copy_source)
        column_product.View.BestFitColumns(True)

        'parametriza las columnas de la vista
        With dgv_object_view
            .Columns("col_remision_product").Caption = "Nombre del producto"
            .Columns("col_remision_code").Caption = "SKU"
            .Columns("col_remision_value").Caption = "Valor Unitario"
            .Columns("col_remision_ammount").Caption = "Cantidad"
            .Columns("col_remision_serial").Caption = "Serial"

            'Define la columna de producto para seleccion con listado
            .Columns("col_remision_product").ColumnEdit = column_product

            'Ajusta las columnas agregadas
            datagrid_ajusted()
            lbl_object_count.Text = total_values()
        End With
    End Sub

    Private Function datagrid_columns(copy_source As DataTable) As DataTable
        Dim source_data As New DataTable

        With source_data
            .Columns.Add("col_remision_product", GetType(String))
            .Columns.Add("col_remision_code", GetType(String))
            .Columns.Add("col_remision_value", GetType(Decimal))
            .Columns.Add("col_remision_ammount", GetType(Integer))
            .Columns.Add("col_remision_serial", GetType(String))
        End With

        'Copia los valores a la tabla fuente para la grilla de resultados
        source_data = copy_source.Copy

        Return source_data
    End Function

    Private Sub datagrid_ajusted()
        With dgv_object_view
            .Columns("col_remision_product").Width = 400
            .Columns("col_remision_code").Width = 55
            .Columns("col_remision_ammount").Width = 55
            .Columns("col_remision_value").Width = 125
            .Columns("col_remision_serial").Width = 100

            'Centra los datos de las celdas
            .Columns("col_remision_code").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_remision_ammount").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_remision_value").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_remision_serial").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            'Centra los encabezados de la columnas
            .Columns("col_remision_code").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_remision_ammount").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_remision_value").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_remision_serial").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            'Agrega el formato de valores para el total
            .Columns("col_remision_value").UnboundType = DevExpress.Data.UnboundColumnType.Decimal
            .Columns("col_remision_value").DisplayFormat.FormatType = FormatType.Numeric
            .Columns("col_remision_value").DisplayFormat.FormatString = "c0"
        End With
    End Sub

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

    Private Sub selected_copy(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv_object_view.KeyDown
        Dim view As GridView = CType(sender, GridView)
        If e.Control AndAlso e.KeyCode = Keys.C Then
            If view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn) IsNot Nothing AndAlso view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString() <> [String].Empty Then
                Clipboard.SetText(view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString())
            End If
            e.Handled = True
        End If
    End Sub
#End Region

#Region "options"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_updated.Click
        If dgv_object_view.RowCount > 0 Then
            If message_text("Está seguro que desea actualizar los productos agregados?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                With orders_.sql_command
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "wholesales_master_orders_products"

                    .Parameters.Clear()
                    .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
                    .Parameters.Add("@product_added", SqlDbType.VarChar).Value = products_added(TryCast(dgv_object_grid.DataSource, DataTable))
                    .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                    .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                    .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                    .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
                End With

                If orders_.execute_procedure = True Then
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub synchronize_option(sender As Object, e As EventArgs) Handles btn_object_update.Click

    End Sub

    Private Sub exported_option(sender As Object, e As EventArgs) Handles btn_object_export.Click
        If dgv_object_view.RowCount > 0 Then
            Using export As New model_object_export(dgv_object_view)
                export.ShowDialog(start_home)
            End Using
        End If
    End Sub

    Private Sub group_option(sender As Object, e As EventArgs) Handles btn_object_panel.Click
        With dgv_object_view.OptionsView
            .ShowGroupPanel = If(.ShowGroupPanel = False, True, False)
        End With
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_close.Click
        Dispose()
    End Sub
#End Region
End Class