Imports CrystalDecisions.Shared
Public Class wholesales_guarantee_viewer
    Private guarantee As Guarantee = Guarantee.Instance
    Private record_affected As Integer

#Region "contructors"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set default look and feel
        crv_object_report.BorderStyle = BorderStyle.None
        record_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load report to show data in lookupedit
        search_data()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub

    Private Sub search_data()
        If record_affected <> 0 Then
            'create instance of all objects
            Dim source As DataTable = guarantee.wholesale_guarantee_search(record_affected)

            'check if source have rows to show
            If source.Rows.Count > 0 Then
                Dim report_settled As New wholesales_guarantee_format
                report_settled.SetDataSource(source)
                crv_object_report.ReportSource = report_settled
            End If
        End If
    End Sub
#End Region

#Region "options"
    Private Sub proof_option(sender As Object, e As EventArgs) Handles btn_object_proof.Click
        If record_affected <> 0 Then
            'create instance of all objects
            Dim source As DataTable = guarantee.wholesale_guarantee_search(record_affected)

            'check if source have rows to show
            If source.Rows.Count > 0 Then
                Dim report_proof As New wholesales_guarantee_proof
                report_proof.SetDataSource(source)

                crv_object_report.ReportSource = Nothing
                crv_object_report.ReportSource = report_proof
            End If
        End If
    End Sub

    Private Sub export_option(sender As Object, e As EventArgs) Handles btn_object_pdf.Click
        If crv_object_report.ReportSource IsNot Nothing Then
            If xfs_path.ShowDialog = DialogResult.OK Then
                If xfs_path.FileName <> "" Then
                    Dim CrExportOptions As ExportOptions
                    Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
                    Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
                    CrDiskFileDestinationOptions.DiskFileName = xfs_path.FileName & ".pdf"
                    CrExportOptions = crv_object_report.ReportSource.ExportOptions
                    With CrExportOptions
                        .ExportDestinationType = ExportDestinationType.DiskFile
                        .ExportFormatType = ExportFormatType.PortableDocFormat
                        .DestinationOptions = CrDiskFileDestinationOptions
                        .FormatOptions = CrFormatTypeOptions
                    End With
                    crv_object_report.ReportSource.Export()

                    'message to confirm process
                    message_text("El formato fué exportado exitosamente", MessageBoxButtons.OK)
                End If
            End If
        End If
    End Sub

    Private Sub updated_option(sender As Object, e As EventArgs) Handles btn_object_update.Click
        If crv_object_report.ReportSource IsNot Nothing Then crv_object_report.RefreshReport()
    End Sub

    Private Sub printer_option(sender As Object, e As EventArgs) Handles btn_object_print.Click
        If crv_object_report.ReportSource IsNot Nothing Then crv_object_report.PrintReport()
    End Sub

    Private Sub next_page(sender As Object, e As EventArgs) Handles btn_object_right.Click
        If crv_object_report.ReportSource IsNot Nothing Then
            crv_object_report.ShowNextPage()
        End If
    End Sub

    Private Sub before_page(sender As Object, e As EventArgs) Handles btn_object_left.Click
        If crv_object_report.ReportSource IsNot Nothing Then
            crv_object_report.ShowPreviousPage()
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class