Public Class comercial_attention_closed
    Private attention As Attentions = Attentions.Instance
    Private causal As Request = Request.Instance
    Private record_affected As Integer

#Region "contructors"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        record_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        search_attention()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub search_attention()
        Dim table_source As DataTable = attention.commercial_attention_search("t.Id=" & record_affected)

        If table_source.Rows.Count = 1 Then
            With table_source.Rows(0)
                txt_attention_ticket.EditValue = .Item("ticket_number").ToString
                txt_attention_date.EditValue = CDate(.Item("created_date").ToString)
                txt_attention_quotation.Text = .Item("quotation_total").ToString & If(.Item("quotation_total").ToString = "1", " (Cotización)", " (Cotizaciones)")
            End With

            'Carga el listado de soluciones
            cmb_attention_causal.Datasources(causal.request_causal_search("row_visible=1 and c.module_code=5 and c.causal_type='S'"), "causal_name")
        End If
    End Sub

    Private Sub characters_count(sender As Object, e As EventArgs) Handles txt_attention_description.EditValueChanged
        lbl_object_caracters.Text = Len(txt_attention_description.EditValue) & "/500"
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With attention.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "relationship_comercial_attention_edited"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
                .Parameters.Add("@cause_closure", SqlDbType.SmallInt).Value = cmb_attention_causal.EditValue
                .Parameters.Add("@description_text", SqlDbType.VarChar, 500).Value = txt_attention_description.EditValue
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If attention.execute_procedure = True Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class