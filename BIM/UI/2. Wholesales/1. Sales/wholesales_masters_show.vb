Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class wholesales_masters_show
    Private criteria_search As String = "month(s.date_sale)=month('" & Now.ToString("yyyy-MM-dd") & "') and year(s.date_sale)=year('" & Now.ToString("yyyy-MM-dd") & "') and s.row_visible in (1,3) and s.agency_code in (" & sessions.agency_permit & ") and s." & sessions.query_permit
    Private sales As Sales = Sales.Instance

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()

        'apply all permits assigned per current module
        search_permits()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        reports_show(criteria_search)
    End Sub
#End Region

#Region "behaviors"
    Private Sub search_permits()
        If sessions.admin_user <> 1 Then
            Dim table As DataTable = sessions.search_permission

            If table.Rows.Count > 0 Then
                With table
                    'check if options new is enabled
                    If .Select("action_object='btn_object_new' and option_showed='" & Me.Name & "'").Count = 0 Then
                        btn_object_new.Size = btn_object_new.MinimumSize
                        lbl_separator2.Visible = False
                    End If

                    'run all options in panel actions
                    For Each options As Control In pnl_object_actions.Controls
                        If TypeOf options Is Button Then
                            If .Select("action_object='" & options.Name & "' and option_showed='" & Me.Name & "'").Count = 0 Then
                                options.Visible = False
                                pnl_object_flyout.Height = pnl_object_flyout.Height - 40
                            End If
                        End If
                    Next
                End With
            End If
        End If
    End Sub

    Public Sub reports_show(Optional criteria_search As String = "")
        Dim source As DataTable = sales.wholesale_sales_show(criteria_search)

        'limpia los origenes de datos anteriores
        dgv_object_grid.DataSource = Nothing
        dgv_object_view.Columns.Clear()
        lbl_object_count.Text = 0

        'comprueba si la consulta tiene filas para mostrar
        If source.Rows.Count > 0 Then
            'define el origen de datos al grid control
            dgv_object_grid.DataSource = source

            'parametriza las columnas de la vista
            With dgv_object_view
                .Columns("Id").Visible = False
                .Columns("Servicios").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .Columns("Estrato").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .Columns("Cuotas Pendientes").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                'formato moneda en campo'
                .Columns("Total Venta").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("Importe").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("Total Venta").DisplayFormat.FormatString = "c0"
                .Columns("Importe").DisplayFormat.FormatString = "c0"
                .BestFitColumns(True)
                .SelectRow(0)

                'comprueba el total de columnas para realizar el ajuste
                .OptionsView.ColumnAutoWidth = If(.Columns.Count <= 10, True, False)

                'define el total de filas en la etiqueta de totales
                lbl_object_count.Text = If(segment_changed(rgo_object_segment.SelectedIndex) = "3", total_values(), total_sales())
            End With

            'define la columna de opciones
            option_column()
            custom_layout()
        End If
    End Sub

    Private Sub count_rows(sender As Object, e As EventArgs) Handles dgv_object_view.ColumnFilterChanged
        lbl_object_count.Text = If(segment_changed(rgo_object_segment.SelectedIndex) = "3", total_values(), total_sales())
    End Sub

    Private Sub options_show(sender As Object, e As RowClickEventArgs) Handles dgv_object_view.RowClick
        If dgv_object_view.IsRowSelected(e.RowHandle) = True Then
            Dim hi As GridHitInfo = dgv_object_view.CalcHitInfo(e.Location)
            If hi.InRowCell Then
                Dim column As GridColumn = hi.Column
                If column.FieldName = "Opciones" Then
                    pnl_object_flyout.HidePopup()
                    pnl_object_flyout.Options.Location = If(If(hi.HitPoint.Y >= 100, New Point(hi.HitPoint.X, 1), hi.HitPoint).Y >= 100, New Point(If(hi.HitPoint.Y >= 100, New Point(hi.HitPoint.X, 1), hi.HitPoint).X, 1), If(hi.HitPoint.Y >= 100, New Point(hi.HitPoint.X, 1), hi.HitPoint))
                    pnl_object_flyout.ShowPopup(True)
                End If
            End If
        End If
    End Sub

    Private Sub segments_changed(sender As Object, e As EventArgs) Handles rgo_object_segment.SelectedIndexChanged
        reports_show(criteria_search & " and s.segment_code in (" & segment_changed(rgo_object_segment.SelectedIndex) & ")")
    End Sub

    Private Sub quick_search(sender As Object, e As EventArgs) Handles lbl_object_today.Click, lbl_object_month.Click, lbl_object_lastday.Click
        reports_show(sender.Tag.ToString & " and s.row_visible in (1,3) and s.agency_code in (" & sessions.agency_permit & ") and s." & sessions.query_permit)
    End Sub

    Private Sub customization_viewer(sender As Object, e As EventArgs) Handles dgv_object_view.HideCustomizationForm
        If message_text("Desea guardar la configuración de campos seleccionada?", MessageBoxButtons.YesNo) = DialogResult.Yes Then dgv_object_view.SaveLayoutToXml("C:\APDA\BIM\bin\" & Me.Name & ".xml")
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

    Private Function search_option(option_selected As Integer) As Boolean
        If sessions.admin_user <> 1 Then
            Dim table As DataTable = sessions.search_permission

            If table.Rows.Count > 0 Then
                With table
                    If option_selected = -1 Then Return True
                    If option_selected = 0 Then If .Select("action_object='btn_movil_visible' and option_showed='" & Me.Name & "'").Count >= 1 Then Return True
                    If option_selected = 1 Then If .Select("action_object='btn_hogar_visible' and option_showed='" & Me.Name & "'").Count >= 1 Then Return True
                    If option_selected = 2 Then If .Select("action_object='btn_free_visible' and option_showed='" & Me.Name & "'").Count >= 1 Then Return True
                End With
            End If
        Else
            Return True
        End If

        Return False
    End Function

    Private Function segment_changed(selected_index As Integer) As String
        Select Case selected_index
            Case -1 : Return "1,2,3"
            Case 0 : Return "1"
            Case 1 : Return "2"
            Case 2 : Return "3"
        End Select

        Return "1,2,3"
    End Function

    Private Function total_sales() As Integer
        Dim total As Integer = 0

        For i As Integer = 0 To dgv_object_view.DataRowCount
            total += CInt(dgv_object_view.GetRowCellValue(i, "Servicios"))
        Next

        Return total
    End Function

    Private Function total_values() As String
        Dim value_total As Double = 0

        For i As Integer = 0 To dgv_object_view.DataRowCount
            If dgv_object_view.GetRowCellValue(i, "Segmento") = "Libres" Then
                value_total += CDbl(Replace(Replace(Replace(dgv_object_view.GetRowCellValue(i, "Total Venta"), ".", ""), "$", ""), "- ", "-"))
            End If
        Next

        Return FormatCurrency((value_total), 0)
    End Function

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

    Private Sub custom_layout()
        If My.Computer.FileSystem.FileExists("C:\APDA\BIM\bin\" & Me.Name & ".xml") Then dgv_object_view.RestoreLayoutFromXml("C:\APDA\BIM\bin\" & Me.Name & ".xml")
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_close.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub
#End Region

#Region "options"
    Private Sub create_option(sender As Object, e As EventArgs) Handles btn_object_new.Click
        If search_option(rgo_object_segment.SelectedIndex) = True Then
            Select Case rgo_object_segment.SelectedIndex
                Case -1 : message_text("Seleccione el segmento de negocio requerido", MessageBoxButtons.OK)
                Case 0 : show_option(New wholesales_movil_create(Me))
                Case 1 : show_option(New wholesales_hogar_create(Me))
                Case 2 : show_option(New wholesales_frees_create(Me))
            End Select
        Else
            message_text("No tiene permisos para crear ventas para el segmento seleccionado", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub edited_option(sender As Object, e As EventArgs) Handles btn_object_edit.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea modificar el registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Select Case (dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Segmento"))
                    Case "Movil" : show_option(New wholesales_movil_edited(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id"), Me))
                    Case "Hogar" : show_option(New wholesales_hogar_edited(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id"), Me))
                    Case "Libres" : show_option(New wholesales_frees_edited(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id"), Me))
                End Select
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub erased_option(sender As Object, e As EventArgs) Handles btn_object_erase.Click
        If dgv_object_view.RowCount > 0 Then
            If message_text("Está seguro que desea anular los registros seleccionados?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                    If dgv_object_view.IsRowSelected(i) = True Then
                        sales.wholesale_sales_erase(dgv_object_view.GetRowCellValue(i, "Id"), 2, False)
                    End If
                Next

                'return message to end process
                If message_text("Los registros seleccionados fueron actualizados exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then reports_show(criteria_search)
            End If
        End If
    End Sub

    Private Sub search_option(sender As Object, e As EventArgs) Handles btn_object_search.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea ver el registro seleccionado en busqueda rapida?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                show_option(New wholesales_masters_details(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id")))
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub transfer_option(sender As Object, e As EventArgs) Handles btn_object_transfer.Click
        If dgv_object_view.RowCount > 0 Then
            If message_text("Está seguro que desea transferir el registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim rows_selected As New List(Of Integer)

                For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                    If dgv_object_view.IsRowSelected(i) = True Then
                        rows_selected.Add(CInt(dgv_object_view.GetRowCellValue(i, "Id")))
                    End If
                Next

                If rows_selected.Count > 0 Then
                    Using new_ As New wholesales_masters_transfer(rows_selected)
                        new_.ShowDialog(start_home)
                    End Using
                Else
                    message_text("No se detectó filas seleccionadas", MessageBoxButtons.OK)
                End If
            End If
        End If
    End Sub

    Private Sub completed_option(sender As Object, e As EventArgs) Handles btn_object_complete.Click
        If dgv_object_view.RowCount > 0 Then
            If message_text("Está seguro que desea completar los registros seleccionados?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim rows_selected As New List(Of Integer)

                For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                    If dgv_object_view.IsRowSelected(i) = True Then
                        rows_selected.Add(CInt(dgv_object_view.GetRowCellValue(i, "Id")))
                    End If
                Next

                If rows_selected.Count > 0 Then
                    Using new_ As New wholesales_masters_complete(rows_selected)
                        new_.ShowDialog(start_home)
                    End Using
                Else
                    message_text("No se detectó filas seleccionadas", MessageBoxButtons.OK)
                End If
            End If
        End If
    End Sub

    Private Sub requested_option(sender As Object, e As EventArgs) Handles btn_object_request.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea registrar una solicitud de modificación al registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                show_option(New wholesales_request_create(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id")))
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub synchronize_option(sender As Object, e As EventArgs) Handles btn_object_update.Click
        rgo_object_segment.SelectedIndex = -1
        reports_show(criteria_search)
    End Sub

    Private Sub exported_option(sender As Object, e As EventArgs) Handles btn_object_export.Click
        If dgv_object_view.RowCount > 0 Then
            Using export As New model_object_export(dgv_object_view)
                export.ShowDialog(start_home)
            End Using
        End If
    End Sub

    Private Sub fields_selector(sender As Object, e As EventArgs) Handles object_button_fields.Click
        If dgv_object_view.RowCount > 0 Then dgv_object_view.ShowCustomization()
    End Sub

    Private Sub group_option(sender As Object, e As EventArgs) Handles btn_object_panel.Click
        With dgv_object_view.OptionsView
            .ShowGroupPanel = If(.ShowGroupPanel = False, True, False)
        End With
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_close.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
