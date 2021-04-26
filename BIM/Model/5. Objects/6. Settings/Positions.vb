Public Class Positions
    Inherits Execute

    Private Shared current_instance As Positions = Nothing
    Private Shared ReadOnly sync As New Object

#Region "constructors"
    Public Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As Positions
        Get
            If current_instance Is Nothing Then
                SyncLock sync
                    If current_instance Is Nothing Then
                        current_instance = New Positions()
                    End If
                End SyncLock
            End If

            Return current_instance
        End Get
    End Property
#End Region

#Region "methods"
    Public Function settings_positions_query() As DataTable
        Dim source As New DataTable

        With source.Columns
            .Add("Id")
            .Add("query_level")
        End With

        With source.Rows
            .Add("A", "Administrador del sistema")
            .Add("G", "Consulta  general de registros vigentes")
            .Add("P", "Busqueda de registros por permisos de agencia")
            .Add("O", "Busqueda de registros propios del usuario")
        End With

        Return source
    End Function

    Public Function settings_position_search(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "entities_bussines_positions_search"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function settings_position_erase(record_affected As Integer, Optional message As Boolean = True) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "entities_bussines_positions_erased"

            .Parameters.Clear()
            .Parameters.Add("@row_affected", SqlDbType.TinyInt).Value = record_affected
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
