Public Class tools_imports_format
    Private parameters As Parameters = Parameters.Instance


#Region "contructors"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
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
        cmb_import_format.Datasources(parameters.settings_search_formats, "format_name")
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            If fn_generate_copy("C:\APDA\BIM\bin\" & cmb_import_format.EditValue, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & cmb_import_format.EditValue) = True Then
                If message_text("El formato de importación " & cmb_import_format.Text & " fué generado exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class