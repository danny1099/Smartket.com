Public Class wholesales_returns_closed
    Private returns As Returns = Returns.Instance
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
        search_object()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub search_object()
        Dim table_search As DataTable = returns.wholesale_returns_search("r.Id=" & record_affected)

        If table_search.Rows.Count = 1 Then
            With table_search.Rows(0)
                txt_results_invoice.EditValue = .Item("number_invoice").ToString
            End With

            'Carga el listado de causales de cierre
            cmb_returns_status.Datasources(causal.request_causal_search("row_visible=1 and c.module_code=6 and c.causal_type='S'"), "causal_name")
        End If
    End Sub

    Private Sub characters_count(sender As Object, e As EventArgs) Handles txt_results_description.EditValueChanged
        lbl_object_caracters.Text = Len(txt_results_description.EditValue) & "/500"
    End Sub

    Private Sub description_spelling(sender As Object, e As EventArgs) Handles txt_results_description.Leave
        xvp_spell.Check(sender)
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With returns.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "wholesales_master_returns_closed"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
                .Parameters.Add("@causal_closed", SqlDbType.SmallInt).Value = cmb_returns_status.EditValue
                .Parameters.Add("@purchase_order", SqlDbType.VarChar, 50).Value = txt_returns_number.EditValue
                .Parameters.Add("@description_text", SqlDbType.VarChar, 300).Value = If(txt_results_description.Text <> "", txt_results_description.EditValue, "El usuario " & sessions.person_name & " finalizo la gestión por devolución con orden de compra  " & txt_returns_number.EditValue)
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If returns.execute_procedure = True Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class