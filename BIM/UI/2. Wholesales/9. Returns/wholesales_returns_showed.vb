Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class wholesales_returns_showed
    Private criteria_search As String = "month(r.event_date)=month('" & Now.ToString("yyyy-MM-dd") & "') and year(r.event_date)=year('" & Now.ToString("yyyy-MM-dd") & "') and r.row_visible=1 and r.agency_code in (" & sessions.agency_permit & ") and r." & sessions.query_permit
    Private returns_ As Returns = Returns.Instance
    Private source_object As New DataTable
    Private notes_ As Notes = Notes.Instance

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
        If source_object IsNot Nothing Then source_object.Rows.Clear()

        'Carga el objecto tipado para realizar las consultas posteriores
        source_object = returns_.wholesale_returns_showed(criteria_search)

        'limpia los origenes de datos anteriores
        dgv_object_grid.DataSource = Nothing
        dgv_object_grid.LevelTree.Nodes.Clear()
        dgv_object_view.Columns.Clear()
        lbl_object_count.Text = 0

        'comprueba si la consulta tiene filas para mostrar
        If source_object.Rows.Count > 0 Then
            With source_object
                object_label_slopes.Text = String.Format("Pendientes: ({0})", .Select("Estado='En Tramite'").Count)
                object_label_isolates.Text = String.Format("En Verificación: ({0})", .Select("Estado='En Verificación'").Count)
                object_label_sending.Text = String.Format("Finalizados: ({0})", .Select("Estado='Finalizado'").Count)
                object_label_search.Text = String.Format("Todas las solicitudes: ({0})", .Rows.Count)

                'Ejecuta la opcion de pendientes
                quick_search(object_label_slopes, Nothing)
            End With
        End If
    End Sub

    Public Sub reports_show(table_source As DataTable)
        dgv_object_grid.DataSource = Nothing
        dgv_object_grid.LevelTree.Nodes.Clear()
        dgv_object_view.Columns.Clear()
        lbl_object_count.Text = 0

        'comprueba si la consulta tiene filas para mostrar
        If table_source.Rows.Count > 0 Then
            'define el origen de datos al grid control
            dgv_object_grid.DataSource = table_source

            'parametriza las columnas de la vista
            With dgv_object_view
                .Columns("Id").Visible = False
                .Columns("Cantidad").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .BestFitColumns(True)
                .SelectRow(0)

                'comprueba el total de columnas para realizar el ajuste
                .OptionsView.ColumnAutoWidth = If(.Columns.Count <= 10, True, False)

                'define el total de filas en la etiqueta de totales
                lbl_object_count.Text = total_values()
            End With

            'define la columna de opciones
            option_column()
            custom_layout()

            'Crea el nodo de notas para asociar a cada registro
            dgv_object_grid.LevelTree.Nodes.Add("node_table", custom_nodes(AccessibleName))
        End If
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

    Private Sub count_rows(sender As Object, e As EventArgs) Handles dgv_object_view.ColumnFilterChanged
        lbl_object_count.Text = dgv_object_view.RowCount.ToString
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

    Private Sub quick_search(sender As Object, e As EventArgs) Handles object_label_slopes.Click, object_label_sending.Click, object_label_search.Click, object_label_isolates.Click
        If source_object.Rows.Count > 0 Then
            reports_show(filter_search(source_object, sender.AccessibleDescription.ToString))
        End If
    End Sub

    Private Sub node_type(sender As Object, e As EventArgs) Handles rgo_object_node.EditValueChanged
        If dgv_object_view.RowCount > 0 Then
            If message_text("Desea actualizar la consulta para cargar el nodo seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then reports_show(criteria_search)
        End If
    End Sub

    Private Sub selected_rows(sender As Object, e As EventArgs) Handles dgv_object_grid.DoubleClick
        With dgv_object_view
            If .IsRowSelected(.FocusedRowHandle) = True Then
                Using new_ As New wholesales_returns_document(.GetRowCellValue(.FocusedRowHandle, "Id"))
                    new_.ShowDialog(start_home)
                End Using
            End If
        End With
    End Sub

    Private Function filter_search(table_source As DataTable, query_search As String) As DataTable
        Dim rows_filtered As DataRow()
        Dim table_result As DataTable

        ' Copia la estructura de los datos consultados
        table_result = table_source.Clone()

        'Realiza los filtros de los item a llamar
        rows_filtered = table_source.Select(query_search)

        'Importa las filas segun los datos filtrados
        For Each dr As DataRow In rows_filtered
            table_result.ImportRow(dr)
        Next

        ' return filtered dt
        Return table_result

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

    Private Function total_values() As String
        Dim value_total As Double = 0

        For i As Integer = 0 To dgv_object_view.DataRowCount
            value_total += CDbl(Replace(Replace(Replace(dgv_object_view.GetRowCellValue(i, "Total Devolución"), ".", ""), "$", ""), "- ", "-"))
        Next

        Return FormatCurrency(value_total, 0)
    End Function

    Private Function custom_nodes(table_name As String) As GridView
        If dgv_object_view.Columns.Count > 0 Then
            Dim tables_sources As New DataSet
            Dim row_affected As Integer() = TryCast(dgv_object_grid.DataSource, DataTable).AsEnumerable().Select(Function(x) x.Field(Of Integer)(0)).ToArray()
            Dim notes_source As DataTable = If(rgo_object_node.EditValue = 1, notes_.notes_master_search(table_name, "c.row_affected in (" & String.Join(","c, row_affected) & ")"), returns_.wholesale_returns_items("r.Id in (" & String.Join(","c, row_affected) & ")"))

            If notes_source.Rows.Count > 0 Then
                'Carga las tablas en el dataset
                With tables_sources
                    .Tables.Add(TryCast(dgv_object_grid.DataSource, DataTable)) '0
                    .Tables.Add(notes_source) '1

                    'Crea las columnas de relacion para el dataset
                    Dim columnkey_column As DataColumn = .Tables(0).Columns("Id")
                    Dim foreignkey_column As DataColumn = .Tables(1).Columns("row_affected")

                    'Crear la relacion entre las tablas
                    .Relations.Add("node_table", columnkey_column, foreignkey_column)
                End With

                'Ajusta las caracteristicas de la vista de notas para el nodo
                With dgv_object_node
                    .OptionsView.RowAutoHeight = True
                    .PopulateColumns(tables_sources.Tables(1))
                    .RefreshData()

                    'Ajusta las columnas a mostrar
                    .Columns("row_affected").VisibleIndex = -1

                    'Valida si el nodo es el visor de notas para ajustar las columnas
                    If rgo_object_node.EditValue = 1 Then
                        .Columns("Id").VisibleIndex = -1
                        .Columns("Descripcion").ColumnEdit = txt_object_notes
                        .Columns("Descripcion").Width = 400
                    End If
                End With

                'Retorna la vista para crear el nodo
                Return dgv_object_node
            End If
        End If

        Return Nothing
    End Function

    Private Sub custom_layout()
        If My.Computer.FileSystem.FileExists("C:\APDA\BIM\bin\" & Me.Name & ".xml") Then dgv_object_view.RestoreLayoutFromXml("C:\APDA\BIM\bin\" & Me.Name & ".xml")
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_close.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub selected_date(sender As Object, e As EventArgs) Handles txt_sales_date.EditValueChanged
        If txt_sales_date.EditValue IsNot Nothing Then
            reports_show("month(r.event_date)=month('" & Format(txt_sales_date.EditValue, "yyyy-MM-dd") & "') and year(r.event_date)=year('" & Format(txt_sales_date.EditValue, "yyyy-MM-dd") & "') and r.row_visible=1 and r.agency_code in (" & sessions.agency_permit & ") and r." & sessions.query_permit)
        End If
    End Sub
#End Region

#Region "options"
    Private Sub create_option(sender As Object, e As EventArgs) Handles btn_object_new.Click
        show_option(New wholesales_returns_created)
    End Sub

    Private Sub erased_option(sender As Object, e As EventArgs) Handles btn_object_erase.Click
        If dgv_object_view.RowCount > 0 Then
            If message_text("Está seguro que desea anular los registros seleccionados?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                    If dgv_object_view.IsRowSelected(i) = True Then
                        returns_.wholesale_returns_erase(dgv_object_view.GetRowCellValue(i, "Id"), False)
                    End If
                Next

                'return message to end process
                If message_text("Los registros seleccionados fueron actualizados exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then reports_show(criteria_search)
            End If
        End If
    End Sub

    Private Sub noted_option(sender As Object, e As EventArgs) Handles btn_object_notes.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            Using new_ As New model_object_notes("Wholesales.Masters.Returns", dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id"), "Devoluciones")
                new_.ShowDialog(start_home)
            End Using
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub documents_option(sender As Object, e As EventArgs) Handles btn_object_document.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea consultar los documentos adjuntos al registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using new_ As New wholesales_returns_document(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id"))
                    new_.ShowDialog(start_home)
                End Using

                'Actualiza el resultado del cambio
                reports_show(criteria_search)
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub finally_option(sender As Object, e As EventArgs) Handles btn_object_finally.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea finalizar el registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using new_ As New wholesales_returns_closed(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id"))
                    new_.ShowDialog(start_home)
                End Using

                'Actualiza el resultado del cambio
                reports_show(criteria_search)
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub transfer_option(sender As Object, e As EventArgs) Handles btn_object_transfer.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea transferir el registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using new_ As New wholesales_returns_transfer(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id"))
                    new_.ShowDialog(start_home)
                End Using

                'Actualiza el resultado del cambio
                reports_show(criteria_search)
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub status_option(sender As Object, e As EventArgs) Handles btn_object_status.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea cambiar el estado al registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using new_ As New wholesales_returns_status(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id"))
                    new_.ShowDialog(start_home)
                End Using

                'Actualiza el resultado del cambio
                reports_show(criteria_search)
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub proof_option(sender As Object, e As EventArgs) Handles btn_object_proof.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea generar el formato de garantía al registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim new_ As New wholesales_returns_viewer(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id"))
                new_.Show()
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub synchronize_option(sender As Object, e As EventArgs) Handles btn_object_update.Click
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
