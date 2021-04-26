Imports DevExpress.XtraEditors.Controls

Public Class tools_imports_show
    Private source As DataTable

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
#End Region

#Region "behaviors"
    Public Sub reports_show(source_ As DataTable)
        'limpia los origenes de datos anteriores
        dgv_object_grid.DataSource = Nothing
        dgv_object_view.Columns.Clear()
        lbl_object_count.Text = 0

        'comprueba si la consulta tiene filas para mostrar
        If source_.Rows.Count > 0 Or source IsNot Nothing Then
            'define el origen de datos al grid control
            dgv_object_grid.DataSource = source_

            'parametriza las columnas de la vista
            With dgv_object_view
                .BestFitColumns(True)
                .SelectRow(0)

                'comprueba el total de columnas para realizar el ajuste
                .OptionsView.ColumnAutoWidth = If(.Columns.Count <= 10, True, False)

                'define el total de filas en la etiqueta de totales
                lbl_object_count.Text = .RowCount.ToString
            End With
        End If
    End Sub

    Private Sub count_rows(sender As Object, e As EventArgs) Handles dgv_object_view.ColumnFilterChanged
        lbl_object_count.Text = dgv_object_view.RowCount.ToString
    End Sub

    Private Sub clean_objects()
        If source IsNot Nothing Then source.Clear()

        dgv_object_grid.DataSource = Nothing
        dgv_object_view.Columns.Clear()
        txt_object_filename.EditValue = Nothing
        lbl_object_count.Text = 0
    End Sub

    Private Sub search_filename1(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_object_filename.ButtonClick
        On Error Resume Next
        If source IsNot Nothing Then source.Clear()

        If xfd_path.ShowDialog = DialogResult.OK Then
            source = fn_excel_import(xfd_path.FileName)
            txt_object_filename.EditValue = xfd_path.FileName

            If source.Rows.Count > 0 Then
                With source
                    For i As Integer = 0 To .Columns.Count - 1
                        If .Columns(i).ColumnName.Contains("Fecha") Or .Columns(i).ColumnName.Contains("fecha") Then
                            .Columns(i).DataType = Type.GetType("System.Date")
                        Else
                            .Columns(i).DataType = Type.GetType("System.String")
                        End If
                    Next
                End With

                'set view of file in grid
                reports_show(source)
            End If
        End If
    End Sub

    Private Sub search_filename2(sender As Object, e As EventArgs) Handles txt_object_filename.Click
        On Error Resume Next
        If source IsNot Nothing Then source.Clear()

        If xfd_path.ShowDialog = DialogResult.OK Then
            source = fn_excel_import(xfd_path.FileName)
            txt_object_filename.EditValue = xfd_path.FileName

            If source.Rows.Count > 0 Then
                With source
                    For i As Integer = 0 To .Columns.Count - 1
                        If .Columns(i).ColumnName.Contains("Fecha") Or .Columns(i).ColumnName.Contains("fecha") Then
                            .Columns(i).DataType = Type.GetType("System.Date")
                        Else
                            .Columns(i).DataType = Type.GetType("System.String")
                        End If
                    Next
                End With

                'set view of file in grid
                reports_show(source)
            End If
        End If
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_close.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub
#End Region

#Region "options"
    Private Sub cloud_option(sender As Object, e As EventArgs) Handles btn_object_new.Click
        If message_text("Está seguro que desea importar el archivo seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If source IsNot Nothing Then
                If source.Rows.Count > 0 Then
                    Using cloud As New tools_imports_create(source)
                        cloud.ShowDialog(start_home)

                        'clean view imported files
                        reports_show(cloud.result_process)
                    End Using
                Else
                    message_text("No se encontró ningun archivo seleccionado", MessageBoxButtons.OK)
                End If
            Else
                message_text("No se encontró ningun archivo seleccionado", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub format_option(sender As Object, e As EventArgs) Handles btn_object_format.Click
        Using new_ As New tools_imports_format
            new_.ShowDialog(start_home)
        End Using
    End Sub

    Private Sub clean_option(sender As Object, e As ButtonPressedEventArgs) Handles txt_object_search.ButtonClick
        If e.Button.Kind = ButtonPredefines.Glyph Then clean_objects()
    End Sub

    Private Sub exported_option(sender As Object, e As EventArgs) Handles btn_object_export.Click
        If dgv_object_view.RowCount > 0 Then
            Using export As New model_object_export(dgv_object_view)
                export.ShowDialog(start_home)
            End Using
        End If
    End Sub

    Private Sub printer_option(sender As Object, e As EventArgs) Handles btn_object_print.Click
        If dgv_object_view.RowCount > 0 Then dgv_object_view.ShowPrintPreview()
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
