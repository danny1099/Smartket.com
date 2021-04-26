Imports mshtml
Imports SHDocVw
Public Class wholesales_masters_capture
    Private poliedro As Captures = Captures.Instance


#Region "contructors"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Function capture_data() As WebBrowser
        Dim source As DataTable = poliedro.settings_search_pages("row_visible=1")
        Dim shellWindows As ShellWindows = New ShellWindowsClass()

        'comprueba que exista datos en la consulta de paginas
        If source.Rows.Count > 0 Then
            For Each explorer As WebBrowser In shellWindows
                If explorer.Name = "Internet Explorer" Then
                    With source
                        If .Select("url_object='" & explorer.LocationURL.ToString & "'").Count = 1 Then
                            Return explorer
                        End If
                    End With
                End If
            Next
        End If

        Return Nothing
    End Function
#End Region

#Region "methods"
    Private Sub saved_option_option(sender As Object, e As EventArgs) Handles btn_object_capture.Click
        Dim object_explorer As WebBrowser = capture_data()

        If object_explorer IsNot Nothing Then
            With poliedro
                .html_document = TryCast(object_explorer.Document(), HTMLDocument)
                .url_page = object_explorer.LocationURL.ToString
            End With

            'comprueba que el documento no este vacio
            search_form("wholesales_movil_capture", poliedro)
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class