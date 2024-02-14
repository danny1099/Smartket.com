Public Class model_object_comentary
    Private table_name As String
    Private record_affected As Integer
    Private module_selected As String
    Private parameter As Parameters = Parameters.Instance

#Region "constructors"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Public Sub New(table_selected As String, row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set values of parameters in variables
        table_name = table_selected
        record_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
#End Region

#Region "behaviors"
    Private Sub characters_count(sender As Object, e As EventArgs) Handles txt_object_note.EditValueChanged
        lbl_object_caracters.Text = Len(txt_object_note.EditValue) & "/500"
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles object_button_saved.Click
        If object_component_validate.Validate = True Then
            With parameter.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_bussines_comment_create"

                .Parameters.Clear()
                .Parameters.Add("@table_name", SqlDbType.VarChar, 50).Value = table_name
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
                .Parameters.Add("@description_text", SqlDbType.VarChar, 500).Value = txt_object_note.EditValue
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = fn_trace_number("8")
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 5000).Value = trace_to_create(txt_object_note.Tag, txt_object_note.EditValue)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If parameter.execute_procedure = True Then
                If chk_keep_form.Checked = True Then
                    defaults_objects(object_panel_container)
                Else
                    Dispose()
                End If
            End If
        End If
    End Sub

    Private Sub cleaned_option(sender As Object, e As EventArgs) Handles object_button_clean.Click
        defaults_objects(object_panel_container)
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles object_button_closed.Click
        Dispose()
    End Sub
#End Region
End Class
