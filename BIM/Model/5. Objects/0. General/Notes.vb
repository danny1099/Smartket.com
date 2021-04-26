Public Class Notes
    Inherits Execute

    Private Shared current_instance As Notes = Nothing
    Private Shared ReadOnly sync As New Object

#Region "constructors"
    Public Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As Notes
        Get
            If current_instance Is Nothing Then
                SyncLock sync
                    If current_instance Is Nothing Then
                        current_instance = New Notes()
                    End If
                End SyncLock
            End If

            Return current_instance
        End Get
    End Property
#End Region

#Region "methods"
    Public Function notes_master_show(table_name As String, record_affected As Integer) As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "entities_bussines_comment_show"

            .Parameters.Clear()
            .Parameters.Add("@table_name", SqlDbType.VarChar, 50).Value = table_name
            .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected

            Return execute_table()
        End With
    End Function

    Public Function notes_master_search(table_name As String, criteria_search As String, Optional source_name As String = "source_object") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "entities_bussines_comment_search"

            .Parameters.Clear()
            .Parameters.Add("@table_name", SqlDbType.VarChar, 50).Value = table_name
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table(source_name)
        End With
    End Function

    Public Function notes_master_erased_option(record_affected As Integer, Optional message As Boolean = False) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "entities_bussines_comment_erased"

            .Parameters.Clear()
            .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
            .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
            .Parameters.Add("@trace_objects", SqlDbType.VarChar, 5000).Value = trace_to_edited("Visible", 1, 0)
            .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
            .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
            .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
        End With

        Return Me.execute_procedure(message)
    End Function
#End Region
End Class
