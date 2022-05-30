Public Class wholesales_guarantee_stages
    Private guarantees As Guarantee = Guarantee.Instance
    Private row_affected As Integer

#Region "contructors"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        row_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        object_listed_status.Datasources(guarantees.wholesale_guarantee_status("s.row_visible=1 and s.status_code not in (1)"), "description_text")
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles object_button_saved.Click
        If object_component_validate.Validate = True Then
            With guarantees.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "wholesales_master_guarantee_status2"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = row_affected
                .Parameters.Add("@status_code", SqlDbType.TinyInt).Value = object_listed_status.GetColumnValue("status_code")
                .Parameters.Add("@dispach_number", SqlDbType.VarChar, 50).Value = (If(object_text_dispach.EditValue = Nothing, DBNull.Value, object_text_dispach.EditValue))
                .Parameters.Add("@is_closed", SqlDbType.Char, 1).Value = object_listed_status.GetColumnValue("type_stage").ToString
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = fn_trace_number()
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(object_panel_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If guarantees.execute_procedure = True Then
                defaults_objects(object_panel_container)
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
