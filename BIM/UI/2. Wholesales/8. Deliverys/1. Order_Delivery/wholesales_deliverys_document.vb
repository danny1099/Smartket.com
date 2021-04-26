Public Class wholesales_deliverys_document
    Private delivery As Deliverys = Deliverys.Instance
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
        Dim table_search As DataTable = delivery.wholesale_sending_showed("s.Id=" & record_affected)

        If table_search.Rows.Count = 1 Then
            With table_search.Rows(0)
                txt_ticket_number.EditValue = .Item("Número de ticket").ToString
                txt_ticket_destiny.EditValue = .Item("Entrada").ToString
            End With
        End If
    End Sub

    Private Sub characters_count(sender As Object, e As EventArgs) Handles txt_orders_description.EditValueChanged
        lbl_object_caracters.Text = Len(txt_orders_description.EditValue) & "/500"
    End Sub

    Private Sub description_spelling(sender As Object, e As EventArgs) Handles txt_orders_description.Leave
        xvp_spell.Check(sender)
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With delivery.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "wholesales_master_sending_document"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
                .Parameters.Add("@number_document", SqlDbType.VarChar, 50).Value = txt_number_document.Text
                .Parameters.Add("@description_text", SqlDbType.VarChar, 300).Value = If(txt_orders_description.Text <> "", txt_orders_description.EditValue, "El usuario " & sessions.person_name & " actualizo el numero de traslado con el documento " & txt_number_document.Text)
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If delivery.execute_procedure = True Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class