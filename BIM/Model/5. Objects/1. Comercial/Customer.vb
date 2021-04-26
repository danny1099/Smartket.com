Public Class Customer
    Inherits Execute

    Private Shared current_instance As Customer = Nothing
    Private Shared ReadOnly sync As New Object

#Region "constructors"
    Public Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As Customer
        Get
            If current_instance Is Nothing Then
                SyncLock sync
                    If current_instance Is Nothing Then
                        current_instance = New Customer()
                    End If
                End SyncLock
            End If

            Return current_instance
        End Get
    End Property
#End Region

#Region "methods"
    Public Function comercial_customer_source(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_customer_person_sources"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function comercial_customer_knowledge(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_customer_knowledge_search"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function comercial_customer_search(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_customer_person_search"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function comercial_customer_listed(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_customer_person_listed"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function comercial_customer_show(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_customer_person_show"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function comercial_customer_unassign(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_customer_person_unassing"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function comercial_customer_erase(record_affected As Integer, Optional message As Boolean = False) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_customer_person_erased"

            .Parameters.Clear()
            .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
            .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
            .Parameters.Add("@trace_objects", SqlDbType.VarChar, 5000).Value = trace_to_edited("Visible", "Activo", "Inactivo")
            .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
            .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
            .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
        End With

        Return Me.execute_procedure(message)
    End Function

    Public Function customer_visited_create(record_affected As Integer, Optional message As Boolean = False) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_customer_visited_create"

            .Parameters.Clear()
            .Parameters.Add("@customer_code", SqlDbType.Int).Value = record_affected
            .Parameters.Add("@agency_code", SqlDbType.TinyInt).Value = sessions.agency_code
            .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
            .Parameters.Add("@trace_objects", SqlDbType.VarChar, 5000).Value = trace_to_edited("Visita", "non-exists", Now.ToLongDateString)
            .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
            .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
            .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
        End With

        Return Me.execute_procedure(message)
    End Function

    Public Function customer_visited_show(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_customer_visited_show"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function comercial_customer_follow(record_affected As Integer, state_favorite As Boolean, Optional message As Boolean = False) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_customer_person_follow"

            .Parameters.Clear()
            .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
            .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
            .Parameters.Add("@trace_objects", SqlDbType.VarChar, 5000).Value = trace_to_edited("Seguimiento", 1, 0)
            .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
            .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
            .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
        End With

        Return Me.execute_procedure(message)
    End Function

    Public Function comercial_customer_code(number_document As String) As Object
        With sql_command
            .CommandType = CommandType.Text
            .CommandText = "select dbo.fn_relationship_customer_code(@number_document)"

            .Parameters.Clear()
            .Parameters.Add("@number_document", SqlDbType.VarChar, 50).Value = number_document

            Return execute_function()
        End With
    End Function

    Public Function comercial_customer_hobbies(customer_selected As Integer) As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_customer_properties_showed"

            .Parameters.Clear()
            .Parameters.Add("@customer_code", SqlDbType.Int).Value = customer_selected

            Return execute_table()
        End With
    End Function


    Public Function comercial_customer_fieldsearchs() As DataTable
        Dim table As New DataTable

        With table
            .Columns.Add("Id")
            .Columns.Add("type_search")

            .Rows.Add("c.number_document='", "Documento")
            .Rows.Add("c.number_cellphone='", "Numero de celular")
            .Rows.Add("c.code_search='", "WWID")
        End With

        Return table
    End Function
#End Region
End Class
