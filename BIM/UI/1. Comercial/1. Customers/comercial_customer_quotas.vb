Public Class comercial_customer_quotas
    Private financial As Financial = Financial.Instance
    Private customer As Customer = Customer.Instance
    Private row_affected As Integer

#Region "contructors"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        row_affected = row_selected
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
        Dim table_search As DataTable = customer.comercial_customer_search("c.Id=" & row_affected)

        If table_search.Rows.Count = 1 Then
            With table_search.Rows(0)
                txt_customer_name.EditValue = .Item("person_name").ToString
                txt_quotas_document.EditValue = .Item("number_document").ToString
            End With
        End If
    End Sub

    Private Sub characters_count(sender As Object, e As EventArgs) Handles txt_customer_description.EditValueChanged
        lbl_object_caracters.Text = Len(txt_customer_description.EditValue) & "/500"
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With financial.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "relationship_customer_credit_created"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = row_affected
                .Parameters.Add("@credit_value", SqlDbType.VarChar, 50).Value = CDec(txt_quotas_value.EditValue)
                .Parameters.Add("@recalculate_type", SqlDbType.Char, 1).Value = "A"
                .Parameters.Add("@description_text", SqlDbType.VarChar, 300).Value = If(txt_customer_description.Text <> "", txt_customer_description.EditValue, "El usuario " & sessions.person_name & " asigno un cupo de crédito por " & txt_quotas_value.Text & " al cliente " & txt_customer_name.EditValue)
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If financial.execute_procedure = True Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class