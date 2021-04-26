Public Class Resumen
    Inherits Execute

    Private Shared current_instance As Resumen = Nothing
    Private Shared ReadOnly sync As New Object

#Region "constructors"
    Public Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As Resumen
        Get
            If current_instance Is Nothing Then
                SyncLock sync
                    If current_instance Is Nothing Then
                        current_instance = New Resumen()
                    End If
                End SyncLock
            End If

            Return current_instance
        End Get
    End Property
#End Region

#Region "methods"
    Public Function notes_master_search(criteria_search As String, Optional source_name As String = "source_notes") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "entities_bussines_comment_search"

            .Parameters.Clear()
            .Parameters.Add("@table_name", SqlDbType.VarChar, 50).Value = "Relationship.Customers.Tickets"
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table(source_name)
        End With
    End Function

    Public Function notes_master_searched(criteria_search As String, table_name As String) As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "entities_bussines_comment_search"

            .Parameters.Clear()
            .Parameters.Add("@table_name", SqlDbType.VarChar, 50).Value = table_name
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table("source_notes")
        End With
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

    Public Function attention_quotation_show(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_comercial_quotation_lookup"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

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

    Public Function wholesale_sales_show(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "wholesales_master_sales_showed"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function comercial_customer_hobbies(customer_selected As String) As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "relationship_customer_properties_showed"

            .Parameters.Clear()
            .Parameters.Add("@customer_code", SqlDbType.Int).Value = Integer.Parse(customer_selected)

            Return execute_table("features_customer")
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

    Public Function wholesale_datacredits_show(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "wholesales_master_datacredit_showed"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function financial_request_showed(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "entities_financial_request_showed"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function
#End Region
End Class
