Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class chances_taked_showed
    Private chances As Chances = Chances.Instance
    Private rows_selected As New List(Of TakedChance)

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_chances_condition.Datasources(chances.commercial_chances_search(If(sessions.admin_user = 1, "c.row_visible=1", "c.row_visible=1 and c.agency_code in (select Existing  from dbo.fn_format_string_check('" & sessions.agency_permit & "', c.agency_code) where Existing is not null)  or c.mark_global=1 and c.row_visible=1")), "chance_name")
    End Sub
#End Region

#Region "behaviors"
    Public Sub reports_show(Optional criteria_search As String = "")
        Dim source As DataTable = chances.chances_taked_showed(cmb_chances_condition.EditValue, criteria_search)

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
                .Columns("service_code").Visible = False
                .Columns("customer_code").Visible = False
                .BestFitColumns(True)
                .SelectRow(0)

                'comprueba el total de columnas para realizar el ajuste
                .OptionsView.ColumnAutoWidth = If(.Columns.Count <= 10, True, False)

                'define el total de filas en la etiqueta de totales
                lbl_object_count.Text = .RowCount.ToString
            End With

            'define la columna de opciones
            option_column()
            custom_layout()
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

    Private Sub count_rows(sender As Object, e As EventArgs) Handles dgv_object_view.ColumnFilterChanged
        lbl_object_count.Text = dgv_object_view.RowCount.ToString
    End Sub

    Private Sub chance_changed(sender As Object, e As EventArgs) Handles cmb_chances_condition.EditValueChanged
        If cmb_chances_condition.EditValue IsNot Nothing Then
            reports_show(cmb_chances_condition.GetColumnValue("condition_text") & If(cmb_chances_condition.GetColumnValue("mark_global").ToString = "True", " and s.agency_code in (" & sessions.agency_permit & ")", ""))
        End If
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
    Private Sub taked_option(sender As Object, e As EventArgs) Handles btn_object_attention.Click
        If dgv_object_view.RowCount > 0 And cmb_chances_condition.EditValue IsNot Nothing Then
            If message_text("Está seguro que desea tomar las oportunidades de venta seleccionadas?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                With dgv_object_view
                    For i As Integer = 0 To .DataRowCount - 1
                        If .IsRowSelected(i) = True Then
                            rows_selected.Add(New TakedChance With {.chance_code = cmb_chances_condition.EditValue,
                                                                                                                  .customer_code = dgv_object_view.GetRowCellValue(i, "customer_code"),
                                                                                                                  .wholesales_code = dgv_object_view.GetRowCellValue(i, "Id"),
                                                                                                                  .services_code = dgv_object_view.GetRowCellValue(i, "service_code")})
                        End If
                    Next

                    'llama el modulo de creacion pasando el listado creado
                    show_option(New chances_taked_create(rows_selected))
                End With
            End If
        End If
    End Sub

    Private Sub massive_option(sender As Object, e As EventArgs)
        If dgv_object_view.RowCount > 0 And cmb_chances_condition.EditValue IsNot Nothing Then
            If message_text("Está seguro que desea tomar las oportunidades de venta seleccionadas?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                With dgv_object_view
                    For i As Integer = 0 To .DataRowCount - 1
                        If .IsRowSelected(i) = True Then
                            rows_selected.Add(New TakedChance With {.chance_code = cmb_chances_condition.EditValue,
                                                                                                                  .customer_code = dgv_object_view.GetRowCellValue(i, "customer_code"),
                                                                                                                  .wholesales_code = dgv_object_view.GetRowCellValue(i, "Id"),
                                                                                                                  .services_code = dgv_object_view.GetRowCellValue(i, "service_code")})
                        End If
                    Next
                End With

                'Confirma las oportunidades tomadas y carga el modulo rapido de asignacion
                If rows_selected.Count > 0 Then
                    Using new_ As New chances_taked_massive(rows_selected)
                        new_.ShowDialog(start_home)
                    End Using

                    If message_text("¿Desea ir al modulo de gestión comercial?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        show_option(New comercial_attention_show)
                    End If
                Else
                    message_text("No se detectó filas seleccionadas", MessageBoxButtons.OK)
                End If
            End If
        End If
    End Sub

    Private Sub synchronize_option(sender As Object, e As EventArgs) Handles btn_object_update.Click
        If cmb_chances_condition.EditValue IsNot Nothing Then
            reports_show(cmb_chances_condition.GetColumnValue("condition_text") & If(cmb_chances_condition.GetColumnValue("mark_global").ToString = "True", " and s.agency_code in (" & sessions.agency_permit & ")", ""))
        End If
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
