Public Class start_initial_restore
    Private person As Persons = Persons.Instance

#Region "contructors"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub module_frame(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub show_password(sender As Object, e As EventArgs) Handles lbl_password_show.Click
        txt_object_password.Properties.PasswordChar = ""
    End Sub

    Private Sub generate_password(sender As Object, e As EventArgs) Handles lbl_password_generate.Click
        txt_object_password.EditValue = fn_generate_password(10)
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With person.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_workforce_password_create"

                .Parameters.Clear()
                .Parameters.Add("@user_name", SqlDbType.VarChar, 50).Value = txt_object_account.EditValue
                .Parameters.Add("@password_text", SqlDbType.VarChar, 50).Value = txt_object_password.EditValue
                .Parameters.Add("@temporary", SqlDbType.Char, 1).Value = "N"
                .Parameters.Add("@pc_name", SqlDbType.VarChar, 50).Value = fn_pc_name() & " |" & fn_version_number()
                .Parameters.Add("@ethernet_address", SqlDbType.VarChar, 100).Value = fn_ip_address()
                .Parameters.Add("@physical_address", SqlDbType.VarChar, 100).Value = fn_pc_mac()
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = fn_trace_number()
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
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