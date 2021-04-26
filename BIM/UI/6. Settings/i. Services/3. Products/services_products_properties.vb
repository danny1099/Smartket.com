Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class services_products_properties
    Private product As Products = Products.Instance
    Private record_affected As Integer

#Region "constructor"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'setea el valor del parametro
        record_affected = row_selected
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
        cmb_features_type.Datasources(product.services_properties_type(), "properties_type")
    End Sub

    Private Sub type_changed(sender As Object, e As EventArgs) Handles cmb_features_type.EditValueChanged
        With cmb_features_type
            If .EditValue IsNot Nothing Then
                cmb_features_name.Datasources(product.services_properties_listed(.GetColumnValue("procedure_name")), .GetColumnValue("field_name"))

                'Ejecuta la consulta de propiedades seleccionadas
                reports_show(.EditValue)
            End If
        End With
    End Sub

    Private Sub features_create(sender As Object, e As EventArgs) Handles lbl_properties_features.Click
        Using new_ As New services_products_objects()
            new_.ShowDialog(start_home)

            'Refresca el listado de tipos de caracteristicas
            object_listed()
        End Using
    End Sub

    Public Sub reports_show(properties_type As String)
        Dim source As DataTable = product.services_properties_showed(record_affected, properties_type)

        'limpia los origenes de datos anteriores
        dgv_object_grid.DataSource = Nothing
        dgv_object_view.Columns.Clear()

        'comprueba si la consulta tiene filas para mostrar
        If source.Rows.Count > 0 Then
            'define el origen de datos al grid control
            dgv_object_grid.DataSource = source

            'parametriza las columnas de la vista
            With dgv_object_view
                .Columns("Id").Visible = False
                .BestFitColumns(True)
                .SelectRow(0)
            End With

            'define la columna de opciones
            option_column()
        End If
    End Sub

    Private Sub options_show(sender As Object, e As RowClickEventArgs) Handles dgv_object_view.RowClick
        If dgv_object_view.IsRowSelected(e.RowHandle) = True Then
            Dim hi As GridHitInfo = dgv_object_view.CalcHitInfo(e.Location)
            If hi.InRowCell Then
                Dim column As GridColumn = hi.Column
                If column.FieldName = "Opciones" Then
                    pnl_object_flyout.HidePopup()
                    pnl_object_flyout.Options.Location = If(hi.HitPoint.Y >= 100, New Point(hi.HitPoint.X, 1), hi.HitPoint)
                    pnl_object_flyout.ShowPopup(True)
                End If
            End If
        End If
    End Sub

    Private Sub option_column()
        If dgv_object_view.RowCount > 0 Then
            Dim column_option As GridColumn = dgv_object_view.Columns.AddVisible("column_option")

            With column_option
                .UnboundType = DevExpress.Data.UnboundColumnType.Object
                .ColumnEdit = rpt_picture_option
                .ImageOptions.Image = My.Resources.options_settings
                .ImageOptions.Alignment = StringAlignment.Center
                .FieldName = "Opciones"
                .AppearanceHeader.ForeColor = Color.DarkGray
                .Width = 40
                .MaxWidth = 40
                .MinWidth = 40
                .VisibleIndex = 0
            End With
        End If
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With product.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_products_properties_create"

                'Recorre todos los items seleccionados
                Dim selected_string As String = cmb_features_name.EditValue
                Dim selected_value = selected_string.Split(","c).Select(Function(n) Integer.Parse(n))

                If selected_value IsNot Nothing Then
                    For Each item As Integer In selected_value
                        .Parameters.Clear()
                        .Parameters.Add("@product_code", SqlDbType.Int).Value = record_affected
                        .Parameters.Add("@row_value", SqlDbType.SmallInt).Value = item
                        .Parameters.Add("@properties_type", SqlDbType.Char, 1).Value = cmb_features_type.EditValue
                        .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                        .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                        .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                        .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                        .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output

                        If product.execute_procedure(False) = True Then
                        End If
                    Next
                End If
            End With

            If message_text("Las caracteristicas de producto fueron registradas exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then
                If chk_keep_form.Checked = True Then
                    cmb_features_type.EditValue = Nothing
                    cmb_features_name.EditValue = Nothing
                Else
                    Close()
                End If
            End If
        End If
    End Sub

    Private Sub erased_option(sender As Object, e As EventArgs) Handles btn_object_erase.Click
        If dgv_object_view.RowCount > 0 Then
            If message_text("Está seguro que desea eliminar los registros seleccionados?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                    If dgv_object_view.IsRowSelected(i) = True Then
                        product.services_properties_erased(dgv_object_view.GetRowCellValue(i, "Id"), False)
                    End If
                Next

                'return message to end process
                If message_text("Los registros seleccionados fueron anulados exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then
                    If cmb_features_type.EditValue IsNot Nothing Then reports_show(cmb_features_type.EditValue)
                End If
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class