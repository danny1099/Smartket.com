Public Class Conditions
    Inherits Execute

    Private Shared current_instance As Conditions = Nothing
    Private Shared ReadOnly sync As New Object

#Region "constructors"
    Public Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As Conditions
        Get
            If current_instance Is Nothing Then
                SyncLock sync
                    If current_instance Is Nothing Then
                        current_instance = New Conditions()
                    End If
                End SyncLock
            End If

            Return current_instance
        End Get
    End Property
#End Region

#Region "methods"
    Public Function conditions_schemes_search(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "commision_scheme_condition_search"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function conditions_schemes_show(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "commision_scheme_condition_show"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function conditions_schemes_listed(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "commision_scheme_condition_listed"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function conditions_schemes_erase(record_affected As Integer, Optional message As Boolean = False) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "commision_scheme_condition_erased"

            .Parameters.Clear()
            .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
            .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
            .Parameters.Add("@trace_objects", SqlDbType.VarChar, 5000).Value = trace_to_edited("Estado", "Activo", "Anulado")
            .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
            .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
            .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
        End With

        Return Me.execute_procedure(message)
    End Function
#End Region

#Region "helpers"
    Public Function commision_count_erase(record_affected As Integer, Optional message As Boolean = False) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "commision_scheme_count_erased"

            .Parameters.Clear()
            .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
            .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
            .Parameters.Add("@trace_objects", SqlDbType.VarChar, 5000).Value = trace_to_edited("Estado", "Activo", "Anulado")
            .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
            .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
            .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
        End With

        Return Me.execute_procedure(message)
    End Function


    Public Function counts_combined_show(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "commision_scheme_counts_show"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function counts_combined_search(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "commision_scheme_mixed_search"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function counts_combined_erase(record_affected As Integer, Optional message As Boolean = False) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "commision_scheme_mixed_erased"

            .Parameters.Clear()
            .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
            .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
            .Parameters.Add("@trace_objects", SqlDbType.VarChar, 5000).Value = trace_to_edited("Estado", "Activo", "Anulado")
            .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
            .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
            .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
        End With

        Return Me.execute_procedure(message)
    End Function
#End Region
End Class
