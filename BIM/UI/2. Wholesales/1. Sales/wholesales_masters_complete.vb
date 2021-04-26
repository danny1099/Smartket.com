Public Class wholesales_masters_complete
    Private dealer As Dealers = Dealers.Instance
    Private parameter As Parameters = Parameters.Instance
    Private wholesales As Sales = Sales.Instance
    Private message_result As String
    Private row_selected As List(Of Integer)


#Region "constructor"
    Public Sub New(row_selected_ As List(Of Integer))
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        row_selected = row_selected_
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_sales_quotas.Datasources(parameter.settings_search_quotas("row_visible=1"), "quotas_name")
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            For Each row_affected As Integer In row_selected
                With wholesales.sql_command
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "wholesales_master_sales_complete"

                    .Parameters.Clear()
                    .Parameters.Add("@row_affected", SqlDbType.Int).Value = row_affected
                    .Parameters.Add("@quotas_code", SqlDbType.TinyInt).Value = cmb_sales_quotas.EditValue
                    .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                    .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                    .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                    .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                    .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output

                    'comprueba el mensaje de salida segun el resultado del proceso
                    If wholesales.execute_procedure(False) = True Then
                    End If

                    'obtiene el mensaje de retorno del servidor
                    message_result += If(message_result = "", .Parameters("@text_message").Value.ToString, vbCrLf & .Parameters("@text_message").Value.ToString)
                End With
            Next

            'mensaje de confirmacion de proceso finalizado
            If message_text(message_result, MessageBoxButtons.OK) = DialogResult.OK Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class