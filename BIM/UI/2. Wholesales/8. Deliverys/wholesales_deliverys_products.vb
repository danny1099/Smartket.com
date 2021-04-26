Imports APDA.Object.Controls
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Public Class wholesales_deliverys_products
    Private column_product As New RepositorySearch
    Private column_persons As New RepositorySearch
    Private product As Products = Products.Instance
    Private person As Persons = Persons.Instance
    Private delivery As Deliverys = Deliverys.Instance
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
        column_persons.Datasources(person.settings_persons_listed("p.row_visible=1"), "Nombre del funcionario")

        'Carga los permisos de usuario para el modulo
        search_permits()
    End Sub

    Private Sub search_permits()
        If sessions.admin_user <> 1 Then
            Dim table As DataTable = sessions.search_permission

            If table.Rows.Count > 0 Then
                With table
                    'check if options new is enabled
                    If .Select("action_object='btn_object_updated' and option_showed='wholesales_deliverys_showed'").Count = 0 Then
                        btn_object_updated.Size = btn_object_updated.MinimumSize
                        lbl_separator2.Visible = False
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub search_object()
        Dim table_search As DataTable = delivery.wholesale_deliverys_search("d.Id=" & record_affected)

        If table_search.Rows.Count = 1 Then
            With table_search.Rows(0)
                create_datagrid(fn_transform_deserialize(.Item("product_added").ToString))
            End With
        End If
    End Sub

    Private Function total_values() As String
        Dim value_ammount As Integer = 0
        Dim value_resmision As Double = 0
        Dim value_total As Double = 0

        Try
            For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                value_resmision = CDbl(Replace(Replace(Replace(dgv_object_view.GetRowCellValue(i, "col_order_value"), ".", ""), "$", ""), "- ", "-"))
                value_ammount = CInt(dgv_object_view.GetRowCellValue(i, "col_order_ammount"))
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

#Region "options"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_updated.Click
        If dgv_object_view.RowCount > 0 Then
            If message_text("Está seguro que desea asignar las ordenes de traslados de la gestión seleccionada?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                With delivery.sql_command
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "wholesales_master_sending_created"

                    For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                        .Parameters.Clear()
                        .Parameters.Add("@delivery_code", SqlDbType.Int).Value = record_affected
                        .Parameters.Add("@product_code", SqlDbType.Int).Value = dgv_object_view.GetRowCellValue(i, "col_order_product")
                        .Parameters.Add("@sending_amount", SqlDbType.SmallInt).Value = dgv_object_view.GetRowCellValue(i, "col_order_ammount")
                        .Parameters.Add("@sending_value", SqlDbType.Decimal, 18, 2).Value = dgv_object_view.GetRowCellValue(i, "col_order_value") * dgv_object_view.GetRowCellValue(i, "col_order_ammount")
                        .Parameters.Add("@center_output", SqlDbType.VarChar, 5).Value = dgv_object_view.GetRowCellValue(i, "col_order_output")
                        .Parameters.Add("@center_sending", SqlDbType.VarChar, 5).Value = dgv_object_view.GetRowCellValue(i, "col_order_center")
                        .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = dgv_object_view.GetRowCellValue(i, "col_order_person")
                        .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                        .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = DBNull.Value
                        .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                        .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                        .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output


                        'Ejecuta los datos seleccionados
                        If delivery.execute_procedure(False) = True Then
                        End If
                    Next

                    'Genera el mensaje de finalizado para el usuario
                    If message_text("Las ordenes de traslado fueron asignadas exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then
                        If delivery.wholesale_deliverys_product(record_affected, products_added(TryCast(dgv_object_grid.DataSource, DataTable)), False) = True Then
                            Close()
                        End If
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub synchronize_option(sender As Object, e As EventArgs) Handles btn_object_update.Click
        search_object()
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

#Region "helpers"
    Private Sub create_datagrid(copy_source As DataTable)
        'Define el origen de datos al grid control
        dgv_object_grid.DataSource = datagrid_columns(copy_source)
        column_product.View.BestFitColumns(True)

        'parametriza las columnas de la vista
        With dgv_object_view
            .Columns("col_order_product").Caption = "Nombre del producto"
            .Columns("col_order_code").Caption = "SKU"
            .Columns("col_order_value").Caption = "Valor Unitario"
            .Columns("col_order_ammount").Caption = "Cantidad"
            .Columns("col_order_output").Caption = "Bodega Salida"
            .Columns("col_order_center").Caption = "Bodega Entrada"
            .Columns("col_order_person").Caption = "Responsable"

            'Define la columna de producto para seleccion con listado
            .Columns("col_order_product").ColumnEdit = column_product
            .Columns("col_order_person").ColumnEdit = column_persons

            'Ajusta las columnas agregadas
            datagrid_ajusted()
            lbl_object_count.Text = total_values()
        End With
    End Sub

    Private Function datagrid_columns(copy_source As DataTable) As DataTable
        Dim source_data As New DataTable

        With source_data
            .Columns.Add("col_order_product", GetType(String))
            .Columns.Add("col_order_code", GetType(String))
            .Columns.Add("col_order_value", GetType(Decimal))
            .Columns.Add("col_order_ammount", GetType(Integer))
            .Columns.Add("col_order_output", GetType(String))
            .Columns.Add("col_order_center", GetType(String))
            .Columns.Add("col_order_person", GetType(String))
        End With

        'Copia los valores a la tabla fuente para la grilla de resultados
        source_data = copy_source.Copy

        Return source_data
    End Function

    Private Sub datagrid_ajusted()
        With dgv_object_view
            .Columns("col_order_product").Width = 200
            .Columns("col_order_code").Width = 55
            .Columns("col_order_ammount").Width = 55
            .Columns("col_order_value").Width = 125
            .Columns("col_order_center").Width = 55
            .Columns("col_order_output").Width = 55
            .Columns("col_order_person").Width = 200

            'Centra los datos de las celdas
            .Columns("col_order_code").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_order_ammount").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_order_value").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_order_center").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_order_output").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            'Centra los encabezados de la columnas
            .Columns("col_order_code").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_order_ammount").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_order_value").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_order_center").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_order_output").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            'Agrega el formato de valores para el total
            .Columns("col_order_value").UnboundType = DevExpress.Data.UnboundColumnType.Decimal
            .Columns("col_order_value").DisplayFormat.FormatType = FormatType.Numeric
            .Columns("col_order_value").DisplayFormat.FormatString = "c0"
        End With
    End Sub

    Private Sub selection_changed(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles dgv_object_view.CellValueChanged
        Dim grid_view As GridView = TryCast(sender, GridView)

        If grid_view IsNot Nothing Then
            With grid_view
                'Define el valor seleccionado
                If .GetRowCellValue(e.RowHandle, "col_order_product").ToString <> "" And .GetRowCellValue(e.RowHandle, "col_order_code").ToString = "" Then
                    Dim value_selected As String = .GetRowCellValue(e.RowHandle, "col_order_product").ToString
                    Dim row_search As DataRow() = TryCast(source_products.Select("Id='" & value_selected & "'"), DataRow())

                    .SetFocusedRowCellValue("col_order_code", row_search(0).Item("SKU").ToString)
                End If
            End With
        End If
    End Sub

    Private Sub row_updated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles dgv_object_view.RowUpdated
        lbl_object_count.Text = total_values()
    End Sub

    Private Sub count_rows(sender As Object, e As EventArgs) Handles dgv_object_view.ColumnFilterChanged
        lbl_object_count.Text = total_values()
    End Sub
#End Region
End Class