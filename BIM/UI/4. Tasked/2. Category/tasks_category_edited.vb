Public Class tasks_category_edited
    Private project As Projects = Projects.Instance
    Private source_current As DataTable
    Private record_affected As Integer

#Region "contructors"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'define el valor del parametro en la variable
        record_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'busca el registro seleccionado
        search_object()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub search_object()
        Dim table As DataTable = project.task_category_search("Id=" & record_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                txt_category_name.EditValue = .Item("category_name").ToString
                txt_category_index.EditValue = .Item("acronym").ToString
                chk_row_visible.Checked = CBool(.Item("row_visible"))

                'guarda el dato actual del registro seleccionado
                source_current = trace_to_current(pnl_object_container)
            End With
        End If
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With project.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_projects_category_edited"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.TinyInt).Value = record_affected
                .Parameters.Add("@category_name", SqlDbType.VarChar, 50).Value = txt_category_name.EditValue
                .Parameters.Add("@acronym", SqlDbType.Char, 2).Value = txt_category_index.EditValue
                .Parameters.Add("@row_visible", SqlDbType.Bit).Value = chk_row_visible.EditValue
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_edited(pnl_object_container, source_current)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If project.execute_procedure = True Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class