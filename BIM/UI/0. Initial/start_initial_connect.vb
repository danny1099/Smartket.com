Public Class start_initial_connect

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed_connection.Datasources(server_names(), "server_name")
        object_listed_connection.EditValue = My.Settings.connection_type
    End Sub
#End Region

#Region "behaviors"
    Private Function server_names() As DataTable
        Dim source_table As New DataTable

        With source_table.Columns
            .Add("Id")
            .Add("server_name")
        End With

        With source_table.Rows
            .Add("C0DB", fn_text_settings("C0DB", "DSO", "C:\APDA\BIM\settings.ini"))
            .Add("C0HD", "DESKTOP-GG063L8")
            .Add("L0DB", "DEVELOPMENT")
        End With

        Return source_table
    End Function
#End Region

#Region "options"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles object_button_saved.Click
        If object_listed_connection.EditValue IsNot Nothing Then
            With My.Settings
                .connection_type = object_listed_connection.EditValue
                .Save()
            End With
        End If
    End Sub

    Private Sub cleaned_option(sender As Object, e As EventArgs) Handles object_button_clean.Click
        object_listed_connection.EditValue = Nothing
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles object_button_closed.Click
        Dispose()
    End Sub
#End Region

End Class
