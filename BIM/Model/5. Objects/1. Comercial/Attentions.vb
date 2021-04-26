Public Class Attentions
    Inherits Execute

    Private Shared current_instance As Attentions = Nothing
    Private Shared ReadOnly sync As New Object

#Region "constructors"
    Public Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As Attentions
        Get
            If current_instance Is Nothing Then
                SyncLock sync
                    If current_instance Is Nothing Then
                        current_instance = New Attentions()
                    End If
                End SyncLock
            End If

            Return current_instance
        End Get
    End Property
#End Region

#Region "methods"
    Public Function commercial_attention_topic(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_comercial_attention_topics"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function commercial_attention_themes(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_comercial_attention_themes"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function commercial_attention_erase(record_affected As Integer, Optional message As Boolean = False) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_comercial_attention_erased"

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

    Public Function commercial_attention_show(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_comercial_attention_show"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function commercial_attention_search(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_comercial_attention_search"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function commercial_attention_listed(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_comercial_attention_listed"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function commercial_attention_suggested(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_customer_properties_suggested"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table("product_suggested")
        End With
    End Function
#End Region

#Region "helpers"
    Public Function attention_quotation_show(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_comercial_quotation_show"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function attention_quotation_proofs(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_comercial_quotation_proofs"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function attention_quotation_wholesales(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_comercial_quotation_wholesales"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function attention_quotation_search(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_comercial_quotation_search"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function attention_quotation_erase(record_affected As Integer, Optional message As Boolean = False) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_comercial_quotation_erased"

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

    Public Function attention_quotation_associate(record_affected As Integer, wholesales_code As Integer, number_serial As String, Optional message As Boolean = False) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_comercial_quotation_associate"

            .Parameters.Clear()
            .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
            .Parameters.Add("@wholesales_code", SqlDbType.Int).Value = wholesales_code
            .Parameters.Add("@number_serial", SqlDbType.VarChar, 50).Value = number_serial
            .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
            .Parameters.Add("@trace_objects", SqlDbType.VarChar, 5000).Value = trace_to_edited("Venta Asociada", "non-defined", number_serial)
            .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
            .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
            .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
        End With

        Return Me.execute_procedure(message)
    End Function

    Public Function attention_ticket_lasted(customer_code As Integer, theme_code As Integer) As Integer
        With Me.sql_command
            .CommandType = CommandType.Text
            .CommandText = "select dbo.fn_relationship_attentions_code(@customer_code,@theme_code)"

            .Parameters.Clear()
            .Parameters.Add("@customer_code", SqlDbType.Int).Value = customer_code
            .Parameters.Add("@theme_code", SqlDbType.TinyInt).Value = theme_code
        End With

        Return Me.execute_function(True)
    End Function
#End Region
End Class
