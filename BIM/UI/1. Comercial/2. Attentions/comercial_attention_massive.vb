Public Class comercial_attention_massive
    Private person As Persons = Persons.Instance
    Private attention As Attentions = Attentions.Instance
    Private row_selected As List(Of Integer)

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Public Sub New(row_selected_ As List(Of Integer))
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        row_selected = row_selected_
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_attention_person.Datasources(person.settings_persons_listed("p.row_visible=1"), "Nombre del funcionario")
        cmb_attention_topic.Datasources(attention.commercial_attention_topic("row_visible=1"), "topic_name")
        txt_attention_date.EditValue = Now
        txt_attention_count.EditValue = row_selected.Count.ToString
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub topic_changed(sender As Object, e As EventArgs) Handles cmb_attention_topic.EditValueChanged
        If cmb_attention_topic.EditValue IsNot Nothing Then
            cmb_attention_theme.Datasources(attention.commercial_attention_themes("row_visible=1 and t.topic_code=" & cmb_attention_topic.EditValue), "theme_name")
        End If
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_attention_person.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            sender.Properties.View.Columns("Id").Visible = False
        End If
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub characters_count(sender As Object, e As EventArgs) Handles txt_attention_desc.EditValueChanged
        lbl_object_caracters.Text = Len(txt_attention_desc.EditValue) & "/500"
    End Sub

    Private Sub description_spelling(sender As Object, e As EventArgs) Handles txt_attention_desc.Leave
        xvp_spell.Check(sender)
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            For Each row_affected As Integer In row_selected
                With attention.sql_command
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "relationship_comercial_attention_create"

                    .Parameters.Clear()
                    .Parameters.Add("@customer_code", SqlDbType.Int).Value = row_affected
                    .Parameters.Add("@created_date", SqlDbType.DateTime).Value = txt_attention_date.EditValue
                    .Parameters.Add("@topic_code", SqlDbType.TinyInt).Value = cmb_attention_topic.EditValue
                    .Parameters.Add("@theme_code", SqlDbType.TinyInt).Value = cmb_attention_theme.EditValue
                    .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = cmb_attention_person.EditValue
                    .Parameters.Add("@agency_code", SqlDbType.TinyInt).Value = sessions.agency_code
                    .Parameters.Add("@closed_date", SqlDbType.DateTime).Value = DBNull.Value
                    .Parameters.Add("@description_text", SqlDbType.VarChar, 500).Value = If(txt_attention_desc.EditValue, "Creación de gestión comercial asignada por el usuario " & sessions.person_name)
                    .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                    .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                    .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                    .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                    .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
                End With

                If attention.execute_procedure(False) = True Then
                End If
            Next

            'mensaje de confirmacion de proceso finalizado
            If message_text("Los gestiones fueron asignadas exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then
                start_home.removed_tabbed()
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
