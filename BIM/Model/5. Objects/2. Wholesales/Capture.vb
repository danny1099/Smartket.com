Imports mshtml
Imports SHDocVw
Public Class Captures
    Inherits Execute

    Private Shared current_instance As Captures = Nothing
    Private Shared ReadOnly sync As New Object

#Region "objects"
    Property html_document As HTMLDocument
    Property url_page As String
    Property operator_code As Integer
#End Region

#Region "constructors"
    Public Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As Captures
        Get
            If current_instance Is Nothing Then
                SyncLock sync
                    If current_instance Is Nothing Then
                        current_instance = New Captures()
                    End If
                End SyncLock
            End If

            Return current_instance
        End Get
    End Property
#End Region

#Region "methods"
    Public Function settings_search_pages(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "settings_general_search_pages"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function settings_search_poliedro(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "settings_general_search_poliedro"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function
#End Region
End Class
