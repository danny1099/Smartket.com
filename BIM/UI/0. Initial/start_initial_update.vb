Imports mshtml
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports Ionic.Zip
Imports System.IO

Public Class start_initial_update
    Private general As Parameters = Parameters.Instance
    Private criteria_search As String = "row_visible=1"
    Private explorer_ As WebBrowser

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        reports_show(criteria_search)
    End Sub

    Private Sub module_frame(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Public Sub reports_show(Optional criteria_search As String = "")
        Dim source As DataTable = general.settings_search_versions(criteria_search)

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
                .Columns("object_data").Visible = False
                .BestFitColumns(True)
                .SelectRow(0)

                'define el total de filas en la etiqueta de totales
                lbl_object_count.Text = .RowCount.ToString
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

    Private Sub count_rows(sender As Object, e As EventArgs) Handles dgv_object_view.ColumnFilterChanged
        lbl_object_count.Text = dgv_object_view.RowCount.ToString
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

    Private Function stream_filename(ByVal filename As String) As Byte()
        Dim fs As FileStream = New FileStream(filename, FileMode.Open, FileAccess.Read)
        Dim ImageData As Byte() = New Byte(fs.Length - 1) {}
        fs.Read(ImageData, 0, System.Convert.ToInt32(fs.Length))
        fs.Close()
        Return ImageData
    End Function
#End Region

#Region "options"
    Private Sub update_upload(sender As Object, e As EventArgs) 
        If message_text("Está seguro que desea cargar el archivo de version seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If xfd_path.ShowDialog = DialogResult.OK Then
                With xfd_path
                    With general.sql_command
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "settings_general_search_updates"

                        .Parameters.Clear()
                        .Parameters.Add("@row_affected", SqlDbType.Int).Value = 1
                        .Parameters.Add("@version_name", SqlDbType.VarChar, 50).Value = "BIM v" & Replace(xfd_path.SafeFileName.ToString, ".zip", "")
                        .Parameters.Add("@file_name", SqlDbType.VarChar, 50).Value = xfd_path.SafeFileName.ToString
                        .Parameters.Add("@file_version", SqlDbType.VarChar, 50).Value = Replace(xfd_path.SafeFileName.ToString, ".zip", "")
                        .Parameters.Add("@object_data", SqlDbType.VarBinary).Value = stream_filename(xfd_path.FileName)
                        .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                        .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = 1
                        .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
                    End With

                    'Ejecuta el proceso de registro y limpia los campos utilizados
                    If general.execute_procedure = True Then
                        Close()
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub search_filename(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If message_text("Está seguro que desea aplicar el archivo de version seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If xfd_path.ShowDialog = DialogResult.OK Then
                Dim file_name As String = dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Nombre de archivo")

                'copia el archivo descargado en la carpeta de actualizaciones
                If Not My.Computer.FileSystem.FileExists("C:\APDA\BIM\updates\" + file_name) = True Then
                    My.Computer.FileSystem.CopyFile(xfd_path.FileName, "C:\APDA\BIM\updates\" & file_name)
                End If

                'descomprime el archivo seleccionado
                If decompress_file(file_name) = True Then
                    message_text("El archivo de actualización fué aplicado exitosamente", MessageBoxButtons.OK)
                    If chk_quit_app.Checked = True Then Application.ExitThread()
                End If
            End If
        End If
    End Sub

    Private Function decompress_file(file_name As String) As Boolean
        If My.Computer.FileSystem.FileExists("C:\APDA\BIM\updates\" + file_name) = True Then
            Using zipFile As ZipFile = ZipFile.Read("C:\APDA\BIM\updates\" + file_name)
                zipFile.ExtractAll("C:\APDA\BIM\", 1)
                Return True
            End Using
        End If

        Return False
    End Function

    Private Sub download_option(sender As Object, e As EventArgs) Handles btn_object_download.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea descargar la versión de BIM seleccionada?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim explorer_ As New HTMLDocument With {.url = dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Link").ToString}
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

    Private Sub printer_option(sender As Object, e As EventArgs) Handles btn_object_print.Click
        If dgv_object_view.RowCount > 0 Then dgv_object_view.ShowPrintPreview()
    End Sub

    Private Sub group_option(sender As Object, e As EventArgs) Handles btn_object_panel.Click
        With dgv_object_view.OptionsView
            .ShowGroupPanel = If(.ShowGroupPanel = False, True, False)
        End With
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Dispose()
    End Sub
#End Region
End Class