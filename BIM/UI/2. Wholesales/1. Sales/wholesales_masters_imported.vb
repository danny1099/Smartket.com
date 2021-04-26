Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Public Class wholesales_masters_imported
    Private parameters As Parameters = Parameters.Instance
    Private sales As Sales = Sales.Instance

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
        cmb_imports_process.Datasources(parameters.settings_search_imports("row_visible=0"), "type_import")
    End Sub

    Public Sub reports_show(Optional criteria_search As String = "")
        Dim source As DataTable = sales.wholesale_sales_processed(txt_sales_date.EditValue)

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
                .BestFitColumns(True)
                .SelectRow(0)

                'comprueba el total de columnas para realizar el ajuste
                .OptionsView.ColumnAutoWidth = If(.Columns.Count <= 10, True, False)

                'define el total de filas en la etiqueta de totales
                lbl_object_count.Text = total_values()
            End With
        End If

        'Carga la vista personalizada
        custom_layout()
    End Sub

    Private Sub count_rows(sender As Object, e As EventArgs) Handles dgv_object_view.ColumnFilterChanged
        lbl_object_count.Text = total_values()
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

    Private Sub event_date(sender As Object, e As EventArgs) Handles txt_sales_date.EditValueChanged
        If txt_sales_date.EditValue IsNot Nothing Then reports_show()
    End Sub

    Private Function total_values() As String
        Dim value_total As Double = 0

        For i As Integer = 0 To dgv_object_view.DataRowCount
            value_total += CDbl(Replace(Replace(Replace(dgv_object_view.GetRowCellValue(i, "Valor de venta"), ".", ""), "$", ""), "- ", "-"))
        Next

        Return FormatCurrency(value_total, 0)
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
    Private Sub imported_option(sender As Object, e As EventArgs) Handles cmb_imports_process.EditValueChanged
        If cmb_imports_process.EditValue IsNot Nothing Then
            If txt_sales_date.EditValue Is Nothing Then
                message_text("La fecha de ejecución no está definida", MessageBoxButtons.OK)
                Exit Sub
            ElseIf message_text("Está seguro que desea ejecutar el proceso de importación de siesa?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                With sales.sql_command
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 120
                    .CommandText = cmb_imports_process.GetColumnValue("process_name")


                    .Parameters.Clear()
                    .Parameters.Add("@until_date", SqlDbType.Date).Value = txt_sales_date.EditValue
                    .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                    .Parameters.Add("@trace_number", SqlDbType.VarChar, 10).Value = "00000000"
                    .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
                End With

                If sales.execute_procedure = True Then If txt_sales_date.EditValue IsNot Nothing Then reports_show()
            End If
        End If
    End Sub

    Private Sub synchronize_option_option(sender As Object, e As EventArgs) Handles btn_object_update.Click
        If txt_sales_date.EditValue IsNot Nothing Then reports_show()
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
