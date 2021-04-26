Public Class persons_channels_create
    Private channel As Channels = Channels.Instance
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
        object_listed()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_channel_name.Datasources(channel.settings_channels_search("row_visible=1"), "channel_name")
    End Sub

    Private Sub validate_listed(sender As Object, e As EventArgs) Handles cmb_channel_name.EditValueChanged
        With cmb_channel_name.Properties
            .Buttons(1).Visible = If(cmb_channel_name.EditValue IsNot Nothing, True, False)
        End With
    End Sub

    Private Sub validate_options(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_agency_date.ButtonClick, cmb_channel_name.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.OK Then
            objects_result("Defina la fecha de validez de la agencia seleccionada*", False, True)

        ElseIf e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Left Then
            objects_result("Seleccione el nombre del canal de ventas que desea asignar*", True, False)
        End If
    End Sub

    Private Sub objects_result(description_text As String, text_control As Boolean, listed_control As Boolean)
        lbl_assigned_name.Text = description_text
        cmb_channel_name.Visible = text_control
        txt_agency_date.Visible = listed_control
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With person.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_workforce_channels_create"

                .Parameters.Clear()
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = person_affected
                .Parameters.Add("@channel_code", SqlDbType.TinyInt).Value = cmb_channel_name.EditValue
                .Parameters.Add("@since_date", SqlDbType.Date).Value = txt_agency_date.EditValue
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