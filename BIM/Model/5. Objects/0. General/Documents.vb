Public Class Documents
    Inherits Execute

    Private Shared current_instance As Documents = Nothing
    Private Shared ReadOnly sync As New Object


#Region "constructors"
    Public Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As Documents
        Get
            If current_instance Is Nothing Then
                SyncLock sync
                    If current_instance Is Nothing Then
                        current_instance = New Documents()
                    End If
                End SyncLock
            End If

            Return current_instance
        End Get
    End Property
#End Region

#Region "methods"
    Public Function documents_master_create(row_affected As Integer, table_name As String, source_images As List(Of String)) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "entities_bussines_documents_create"

            For Each item As String In source_images
                'Carga los parametros para el cargue de las fotos
                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = row_affected
                .Parameters.Add("@table_name", SqlDbType.VarChar, 50).Value = table_name
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

    Public Function documents_master_create(row_affected As Integer, table_name As String, object_image As List(Of Image), Optional message As Boolean = False) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "entities_bussines_documents_create"

            For Each item As Image In object_image
                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = row_affected
                .Parameters.Add("@table_name", SqlDbType.VarChar, 50).Value = table_name
                .Parameters.Add("@document_name", SqlDbType.VarChar, 50).Value = item.Tag.ToString
                .Parameters.Add("@document_support", SqlDbType.VarBinary).Value = fn_transform_bytes(item)
                .Parameters.Add("@document_format", SqlDbType.VarChar, 10).Value = ".png"
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

    Public Function documents_master_search(row_affected As Integer, table_name As String, Optional source_name As String = "source_object") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "entities_bussines_documents_search"

            .Parameters.Clear()
            .Parameters.Add("@row_affected", SqlDbType.Int).Value = row_affected
            .Parameters.Add("@table_name", SqlDbType.VarChar, 50).Value = table_name

            Return execute_table(source_name)
        End With
    End Function

    Public Function documents_master_remove(record_affected As Integer, Optional message As Boolean = False) As Boolean
        With Me.sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "entities_bussines_documents_remove"

            .Parameters.Clear()
            .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
            .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
            .Parameters.Add("@trace_objects", SqlDbType.VarChar, 5000).Value = trace_to_edited("Estado", "Activo", "Inactivo")
            .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
            .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
            .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
        End With

        Return Me.execute_procedure(message)
    End Function
#End Region
End Class
