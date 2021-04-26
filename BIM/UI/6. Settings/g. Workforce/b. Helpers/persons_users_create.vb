Public Class persons_users_create
    Private person As Persons = Persons.Instance
    Private person_affected As Integer

#Region "contructors"
    Public Sub New(person_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        person_affected = person_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'execute procedure to load sources and search current object
        object_search()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_search()
        Dim table As DataTable = person.settings_persons_search("p.Id=" & person_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                txt_useraccess_name.EditValue = .Item("user_access").ToString
                chk_row_visible.Checked = CBool(.Item("user_blocked"))

                'save data of current record
                trace_to_current(pnl_object_container)
            End With
        End If
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With person.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_workforce_persons_access"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.SmallInt).Value = person_affected
                .Parameters.Add("@user_access", SqlDbType.VarChar, 50).Value = txt_useraccess_name.EditValue
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If person.execute_procedure = True Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class