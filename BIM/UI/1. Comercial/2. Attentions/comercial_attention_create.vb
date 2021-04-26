Public Class comercial_attention_create
    Private customer As Customer = Customer.Instance
    Private attention As Attentions = Attentions.Instance
    Private record_affected As Integer

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        record_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_attention_customer.Datasources(customer.comercial_customer_listed("c.row_visible=1"), "Nombre del cliente")
        cmb_attention_topic.Datasources(attention.commercial_attention_topic("row_visible=1"), "topic_name")

        'set date of created and check if paramter row affected is not null
        cmb_attention_customer.EditValue = CInt(record_affected)
        txt_attention_date.EditValue = Now
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub topic_changed(sender As Object, e As EventArgs) Handles cmb_attention_topic.EditValueChanged
        If cmb_attention_topic.EditValue IsNot Nothing Then
            cmb_attention_theme.Datasources(attention.commercial_attention_themes("row_visible=1 and t.topic_code=" & cmb_attention_topic.EditValue), "theme_name")
            txt_attention_ticket.EditValue = cmb_attention_topic.GetColumnValue("acronym")
        End If
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_attention_customer.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            sender.Properties.View.Columns("Id").Visible = False
        End If
    End Sub

    Private Sub customer_create(sender As Object, e As EventArgs) Handles lbl_attention_newcustomer.Click
        show_option(New comercial_customer_create(Me))
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub characters_count(sender As Object, e As EventArgs) Handles txt_attention_desc.EditValueChanged
        lbl_object_caracters.Text = Len(txt_attention_desc.EditValue) & "/500"
    End Sub

    Private Sub customer_changed(sender As Object, e As EventArgs) Handles cmb_attention_customer.EditValueChanged
        If cmb_attention_customer.EditValue IsNot Nothing Then
            If cmb_attention_customer.EditValue.ToString <> "" And cmb_attention_customer.EditValue.ToString <> "0" Then
                If message_text("Desea actualizar la información del cliente seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    show_option(New comercial_customer_edited(cmb_attention_customer.EditValue, Me))
                End If
            End If
        End If
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With customer.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "relationship_comercial_attention_create"

                .Parameters.Clear()
                .Parameters.Add("@customer_code", SqlDbType.Int).Value = cmb_attention_customer.EditValue
                .Parameters.Add("@created_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@topic_code", SqlDbType.TinyInt).Value = cmb_attention_topic.EditValue
                .Parameters.Add("@theme_code", SqlDbType.TinyInt).Value = cmb_attention_theme.EditValue
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@agency_code", SqlDbType.TinyInt).Value = sessions.agency_code
                .Parameters.Add("@closed_date", SqlDbType.DateTime).Value = DBNull.Value
                .Parameters.Add("@description_text", SqlDbType.VarChar, 500).Value = If(txt_attention_desc.EditValue, "Creación de gestión comercial al cliente " & cmb_attention_customer.Text & " por el usuario " & sessions.person_name)
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If customer.execute_procedure = True Then
                If cmb_attention_topic.EditValue <> 3 And cmb_attention_topic.EditValue <> 4 Then customer.customer_visited_create(cmb_attention_customer.EditValue)

                'return to listed of attentions
                Dim attention_code As Integer = attention.attention_ticket_lasted(cmb_attention_customer.EditValue, cmb_attention_theme.EditValue)
                show_option(New comercial_attention_details(attention_code))
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
