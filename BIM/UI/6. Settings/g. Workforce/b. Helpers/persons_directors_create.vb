﻿Public Class persons_directors_create
    Private director As Directors = Directors.Instance
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
        cmb_director_name.Datasources(director.settings_directors_search("row_visible=1"), "director_name")
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With person.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_workforce_directors_create"

                .Parameters.Clear()
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = person_affected
                .Parameters.Add("@director_code", SqlDbType.TinyInt).Value = cmb_director_name.EditValue
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If person.execute_procedure = True Then
                If chk_keep_form.Checked = True Then
                    defaults_objects(pnl_object_container)
                Else
                    Close()
                End If
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class