Public Class tasks_masters_transfer
    Private person As Persons = Persons.Instance
    Private project As Projects = Projects.Instance
    Private row_selected As List(Of Integer)

#Region "contructors"
    Public Sub New(row_selected_ As List(Of Integer))
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        row_selected = row_selected_
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load lookup edit to show sellers listed
        object_listed()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_person_name.Datasources(person.settings_persons_listed("p.row_visible=1 and p.agency_code in (" & sessions.agency_permit & ")"), "Nombre del funcionario")
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_person_name.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            With sender.Properties
                .View.Columns("Id").Visible = False
                .View.Columns("IDR").Width = 40
                .View.RowHeight = 30
            End With
        End If
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            For Each row_affected As Integer In row_selected
                With project.sql_command
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "entities_projects_tasks_transfer"

                    .Parameters.Clear()
                    .Parameters.Add("@row_affected", SqlDbType.Int).Value = row_affected
                    .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = cmb_person_name.EditValue
                    .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                    .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                    .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                    .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                    .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
                End With

                If project.execute_procedure(False) = True Then
                End If
            Next

            'mensaje de confirmacion de proceso finalizado
            If message_text("Las tareas fueron transferidas exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class