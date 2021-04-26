Public Class Chances
    Inherits Execute

    Private Shared current_instance As Chances = Nothing
    Private Shared ReadOnly sync As New Object

#Region "constructors"
    Public Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As Chances
        Get
            If current_instance Is Nothing Then
                SyncLock sync
                    If current_instance Is Nothing Then
                        current_instance = New Chances()
                    End If
                End SyncLock
            End If

            Return current_instance
        End Get
    End Property
#End Region

#Region "methods"
    Public Function commercial_chances_show(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_customer_chance_show"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function commercial_chances_search(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_customer_chance_search"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function commercial_chances_lapses() As DataTable
        Dim table As New DataTable

        With table
            .Columns.Add("Id")
            .Columns.Add("time_lapse")

            .Rows.Add("convert(date,dateadd(year,-1,getdate()))", "Hace un año atras")
            .Rows.Add("convert(date,dateadd(year,-2,getdate()))", "Hace dos años atras")
            .Rows.Add("convert(date,dateadd(year,-3,getdate()))", "Hace tres años atras")
            .Rows.Add("convert(date,dateadd(month,-1,getdate()))", "Hace un mes atras")
            .Rows.Add("convert(date,dateadd(month,-2,getdate()))", "Hace dos meses atras")
            .Rows.Add("convert(date,dateadd(month,-3,getdate()))", "Hace tres meses atras")
        End With

        Return table
    End Function

    Public Function commercial_chances_erase(record_affected As Integer, Optional message As Boolean = False) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_customer_chance_erased"

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

    Public Function chances_taked_showed(chance_code As Integer, Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_customer_taked_show"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search
            .Parameters.Add("@chance_code", SqlDbType.Int).Value = chance_code

            Return execute_table()
        End With
    End Function
#End Region
End Class
Public Class TakedChance
    Property wholesales_code As Integer
    Property customer_code As Integer
    Property chance_code As Integer
    Property services_code As Integer
End Class