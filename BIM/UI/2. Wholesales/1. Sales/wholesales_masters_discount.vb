Public Class wholesales_masters_discount
    Private commission As Commision = Commision.Instance
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
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_discount_type.Datasources(commission.commision_discount_type("row_visible=1"), "discount_name")
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            For Each row_affected As Integer In row_selected
                With commission.sql_command
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "wholesales_payment_discount_create"

                    .Parameters.Clear()
                    .Parameters.Add("@wholesales_code", SqlDbType.Int).Value = row_affected
                    .Parameters.Add("@value_discount", SqlDbType.Decimal, 18, 2).Value = CDec(txt_discount_value.EditValue)
                    .Parameters.Add("@discount_code", SqlDbType.TinyInt).Value = cmb_discount_type.EditValue
                    .Parameters.Add("@description_text", SqlDbType.VarChar, 300).Value = If(txt_discount_comment.EditValue, DBNull.Value)
                    .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                    .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                    .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                    .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                    .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
                End With

                If commission.execute_procedure(False) = True Then
                End If
            Next

            'mensage de salida con la confirmación del proceso
            If message_text("Los descuentos fueron aplicados exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then
                If chk_keep_form.Checked = True Then
                    defaults_objects(pnl_object_container)
                Else
                    Close()
                End If
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class