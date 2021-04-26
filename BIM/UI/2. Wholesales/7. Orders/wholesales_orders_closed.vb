Public Class wholesales_orders_closed
    Private orders_ As Orders = Orders.Instance
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
        Dim table_search As DataTable = orders_.wholesale_orders_search("o.Id=" & record_affected)

        If table_search.Rows.Count = 1 Then
            With table_search.Rows(0)
                txt_orders_customers.EditValue = .Item("person_name").ToString
                txt_orders_purcharse.EditValue = .Item("purchase_order").ToString
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
            With orders_.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "wholesales_master_orders_closed"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
                .Parameters.Add("@number_invoice", SqlDbType.VarChar, 50).Value = txt_orders_invoice.EditValue
                .Parameters.Add("@description_text", SqlDbType.VarChar, 300).Value = If(txt_orders_description.Text <> "", txt_orders_description.EditValue, "El usuario " & sessions.person_name & " finalizo el pedido con numero de factura " & txt_orders_invoice.EditValue)
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If orders_.execute_procedure = True Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class