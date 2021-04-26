Imports CrystalDecisions.Shared

Public Class attention_quotation_viewers
    Private quotation_ As Attentions = Attentions.Instance
    Private report_quotation As attention_quotation_proofs
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
        search_data()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub

    Private Sub search_data()
        If record_affected <> 0 Then
            'create instance of all objects
            Dim source As DataTable = quotation_.attention_quotation_proofs("c.attention_code=" & record_affected)

            'check if source have rows to show
            If source.Rows.Count > 0 Then
                report_quotation = New attention_quotation_proofs
                report_quotation.SetDataSource(source)
                crv_object_report.ReportSource = report_quotation
            End If
        End If
    End Sub
#End Region

#Region "options"
    Private Sub export_option(sender As Object, e As EventArgs) Handles btn_object_pdf.Click
        If report_quotation IsNot Nothing Then
            If xfs_path.ShowDialog = DialogResult.OK Then
                If xfs_path.FileName <> "" Then
                    Dim CrExportOptions As ExportOptions
                    Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
                    Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
                    CrDiskFileDestinationOptions.DiskFileName = xfs_path.FileName & ".pdf"
                    CrExportOptions = report_quotation.ExportOptions
                    With CrExportOptions
                        .ExportDestinationType = ExportDestinationType.DiskFile
                        .ExportFormatType = ExportFormatType.PortableDocFormat
                        .DestinationOptions = CrDiskFileDestinationOptions
                        .FormatOptions = CrFormatTypeOptions
                    End With
                    report_quotation.Export()

                    'message to confirm process
                    message_text("El formato de cotización fué exportado exitosamente", MessageBoxButtons.OK)
                End If
            End If
        End If
    End Sub

    Private Sub update_option(sender As Object, e As EventArgs) Handles btn_object_update.Click
        If report_quotation IsNot Nothing Then crv_object_report.RefreshReport()
    End Sub

    Private Sub printer_option(sender As Object, e As EventArgs) Handles btn_object_print.Click
        If report_quotation IsNot Nothing Then crv_object_report.PrintReport()
    End Sub

    Private Sub next_page(sender As Object, e As EventArgs) Handles btn_object_right.Click
        If report_quotation IsNot Nothing Then
            crv_object_report.ShowNextPage()
        End If
    End Sub

    Private Sub before_page(sender As Object, e As EventArgs) Handles btn_object_left.Click
        If report_quotation IsNot Nothing Then
            crv_object_report.ShowPreviousPage()
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class