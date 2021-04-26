Public Class wholesales_guarantee_solution
    Private person As Persons = Persons.Instance
    Private guarantee As Guarantee = Guarantee.Instance
    Private causal As Request = Request.Instance
    Private row_selected As List(Of Integer)

#Region "contructors"
    Public Sub New(row_selected_ As List(Of Integer))
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        row_selected = row_selected_
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
        object_search()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_guarantee_person.Datasources(person.settings_persons_listed("p.row_visible=1 and p.agency_code in (" & sessions.agency_permit & ")"), "Nombre del funcionario")
        cmb_guarantee_revision.Datasources(causal.request_causal_search("row_visible=1 and c.module_code=2 and c.causal_type='S'"), "causal_name")
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_guarantee_person.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            With sender.Properties
                .View.Columns("Id").Visible = False
                .View.Columns("IDR").Width = 40
                .View.RowHeight = 30
            End With
        End If
    End Sub

    Private Sub characters_count(sender As Object, e As EventArgs) Handles txt_guarantee_description.EditValueChanged
        lbl_object_caracters.Text = Len(txt_guarantee_description.EditValue) & "/500"
    End Sub

    Private Sub description_spelling(sender As Object, e As EventArgs) Handles txt_guarantee_description.Leave
        xvp_spell.Check(sender)
    End Sub

    Private Sub object_search()
        cmb_guarantee_person.EditValue = CInt(sessions.session_code)
        txt_guarantee_count.EditValue = row_selected.Count.ToString
        txt_guarantee_support.EditValue = Now
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With guarantee.sql_command
                For Each row_affected As Integer In row_selected
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "wholesales_master_guarantee_support"

                    .Parameters.Clear()
                    .Parameters.Add("@row_affected", SqlDbType.Int).Value = row_affected
                    .Parameters.Add("@revision_code", SqlDbType.TinyInt).Value = cmb_guarantee_revision.EditValue
                    .Parameters.Add("@support_date", SqlDbType.Date).Value = txt_guarantee_support.EditValue
                    .Parameters.Add("@description_text", SqlDbType.VarChar, 500).Value = txt_guarantee_description.EditValue
                    .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                    .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                    .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                    .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                    .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output

                    If guarantee.execute_procedure(False) = True Then
                    End If
                Next
            End With

            'Retorna el mensaje de finalizacion de proceso
            If message_text("Las gestiones fueron soluciónadas exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class