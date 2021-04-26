Public Class Returns
    Inherits Execute

    Private Shared current_instance As Returns = Nothing
    Private Shared ReadOnly sync As New Object

#Region "constructors"
    Public Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As Returns
        Get
            If current_instance Is Nothing Then
                SyncLock sync
                    If current_instance Is Nothing Then
                        current_instance = New Returns()
                    End If
                End SyncLock
            End If

            Return current_instance
        End Get
    End Property
#End Region

#Region "methods"
    Public Function wholesale_returns_showed(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "wholesales_master_returns_showed"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function wholesale_returns_search(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "wholesales_master_returns_search"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function wholesale_returns_format(row_affected As Integer) As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "wholesales_master_returns_format"

            .Parameters.Clear()
            .Parameters.Add("@row_affected", SqlDbType.Int).Value = row_affected

            Return execute_table()
        End With
    End Function

    Public Function wholesale_returns_lookup(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "wholesales_master_returns_lookup"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function wholesale_returns_items(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "wholesales_master_returns_items"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table("table_items")
        End With
    End Function

    Public Function wholesale_returns_erase(record_affected As Integer, Optional message As Boolean = False) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "wholesales_master_returns_erased"

            .Parameters.Clear()
            .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
            .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
            .Parameters.Add("@trace_objects", SqlDbType.VarChar, 5000).Value = trace_to_edited("Estado", "Activo", "Anulada")
            .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
            .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
            .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
        End With

        Return Me.execute_procedure(message)
    End Function


    'Soportes Adjuntos
    Public Function wholesale_returns_documents(row_affected As Integer, source_images As List(Of String), Optional message As Boolean = False) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "wholesales_master_returns_documents"

            For Each item As String In source_images
                'Carga los parametros para el cargue de las fotos
                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = row_affected
                .Parameters.Add("@document_name", SqlDbType.VarChar, 50).Value = Replace(fn_text_filename(item), fn_text_extension(item), "")
                .Parameters.Add("@document_support", SqlDbType.VarBinary).Value = If(fn_text_extension(item) = ".pdf", fn_transform_bytes(item), fn_transform_bytes(Image.FromFile(item)))
                .Parameters.Add("@document_format", SqlDbType.VarChar, 10).Value = fn_text_extension(item)
                .Parameters.Add("@description_text", SqlDbType.VarChar, 100).Value = "El usuario " & sessions.person_name & " adjunto una imagen"
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output

                'Ejecuta el proceso de registro de imagenes
                If Me.execute_procedure(False) = True Then
                End If
            Next

            Return True
        End With
    End Function

    Public Function wholesale_returns_remove(record_affected As Integer, Optional message As Boolean = False) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "wholesales_master_returns_remove"

            .Parameters.Clear()
            .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
            .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
            .Parameters.Add("@trace_objects", SqlDbType.VarChar, 5000).Value = trace_to_edited("Estado", "Activo", "Anulada")
            .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
            .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
            .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
        End With

        Return Me.execute_procedure(message)
    End Function

    Public Function wholesale_returns_support(row_affected As Integer) As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "wholesales_master_returns_viewer"

            .Parameters.Clear()
            .Parameters.Add("@returns_code", SqlDbType.Int).Value = row_affected

            Return execute_table()
        End With
    End Function
#End Region
End Class
