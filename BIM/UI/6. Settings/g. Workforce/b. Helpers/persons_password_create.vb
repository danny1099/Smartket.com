Public Class persons_password_create
    Private person As Persons = Persons.Instance
    Private person_code As Integer

#Region "contructors"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'define el valor de la propiedad con la variable parametro
        person_code = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub module_frame(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"

    Private Sub password_generate(sender As Object, e As EventArgs) Handles lbl_object_generate.Click
        Dim password_generate As String = fn_generate_password(10)

        txt_password_text.EditValue = password_generate
        txt_password_confirm.EditValue = password_generate
    End Sub

    Private Sub validate_name(sender As Object, e As EventArgs) Handles txt_password_text.EditValueChanged, txt_password_confirm.EditValueChanged
        With sender.Properties
            .Buttons(0).Visible = If(Len(sender.EditValue) > 0, True, False)
        End With
    End Sub

    Private Sub validate_options(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_password_text.ButtonClick, txt_password_confirm.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.OK Then
            objects_result("Confirme la contraseña definada para el cambio*", False, True)

        ElseIf e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Left Then
            objects_result("Defina la nueva contraseña a cambiar*", True, False)
        End If
    End Sub

    Private Sub objects_result(description_text As String, text_control1 As Boolean, text_control2 As Boolean)
        lbl_password_text.Text = description_text
        txt_password_text.Visible = text_control1
        txt_password_confirm.Visible = text_control2
    End Sub

    Private Sub password_confirm(sender As Object, e As EventArgs) Handles txt_password_confirm.Leave
        If txt_password_confirm.EditValue IsNot Nothing Then
            If txt_password_text.Text <> txt_password_confirm.Text Then message_text("La contraseñas ingresadas no coinciden", MessageBoxButtons.OK)
        End If
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With person.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_workforce_password_restore"

                .Parameters.Clear()
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = person_code
                .Parameters.Add("@password_text", SqlDbType.VarChar, 50).Value = txt_password_text.EditValue
                .Parameters.Add("@temporary", SqlDbType.Char, 1).Value = "S"
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