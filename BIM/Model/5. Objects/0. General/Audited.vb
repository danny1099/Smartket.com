Public Class Audited
    Inherits Execute

    Private Shared current_instance As Audited = Nothing
    Private Shared ReadOnly sync As New Object

#Region "constructors"
    Public Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As Audited
        Get
            If current_instance Is Nothing Then
                SyncLock sync
                    If current_instance Is Nothing Then
                        current_instance = New Audited()
                    End If
                End SyncLock
            End If

            Return current_instance
        End Get
    End Property
#End Region

#Region "methods"
    Public Function audits_search_tracing(table_name As String, record_affected As Integer) As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "tracing_control_audits_search"

            .Parameters.Clear()
            .Parameters.Add("@table_name", SqlDbType.VarChar, 50).Value = table_name
            .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected

            Return execute_table()
        End With
    End Function

    Public Function audits_search_showed(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "tracing_control_audits_showed"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function audits_search_movement(Optional criteria_search As String = "") As DataTable
        Dim table As New DataTable

        With table
            .Columns.Add("Id")
            .Columns.Add("movement_name")

            .Rows.Add(1, "Agregó y/o Registró un dato")
            .Rows.Add(2, "Modificó uno ó varios datos de un registro")
            .Rows.Add(3, "Eliminó uno ó varios registros")
        End With

        Return table
    End Function

    Public Function audits_search_reported(Optional criteria_search As String = "") As DataTable
        Dim table As New DataTable

        With table
            .Columns.Add("Id")
            .Columns.Add("report_name")

            .Rows.Add(2, "Consulta de sesiones de trabajo auditadas")
            .Rows.Add(1, "Movimiento de transacciones auditadas")
        End With

        Return table
    End Function

    Public Function audits_search_tables(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "tracing_control_audits_tables"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function audits_search_session(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "tracing_control_audits_tracing"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    'process to show notificacion and erased
    Public Function tracing_notification_search(person_code As Integer) As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "tracing_control_alerts_search"

            .Parameters.Clear()
            .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = person_code

            Return execute_table()
        End With
    End Function

    Public Function tracing_notification_erased(record_affected As Integer, Optional message As Boolean = False) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "tracing_control_alerts_edited"

            .Parameters.Clear()
            .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
            .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
            .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
            .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
        End With

        Return Me.execute_procedure(message)
    End Function

    Public Function tracing_notification_dismiss(person_code As Integer) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "tracing_control_alerts_dismiss"

            .Parameters.Clear()
            .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = person_code
            .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
            .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
        End With

        Return Me.execute_procedure(False)
    End Function
#End Region
End Class
