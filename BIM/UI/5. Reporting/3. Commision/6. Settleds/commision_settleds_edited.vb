Public Class commision_settleds_edited
    Private parameters As Parameters = Parameters.Instance
    Private period As Periods = Periods.Instance
    Private commission As Commision = Commision.Instance
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
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_settled_segment.Datasources(parameters.settings_search_segments("row_visible=1"), "segment_name")
        cmb_settled_period.Datasources(period.commision_periods_search("p.row_visible in (3)"), "period_name")
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            For Each row_affected As Integer In row_selected
                With commission.sql_command
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "wholesales_payment_settled_edited"

                    .Parameters.Clear()
                    .Parameters.Add("@row_affected", SqlDbType.Int).Value = row_affected
                    .Parameters.Add("@segment_code", SqlDbType.TinyInt).Value = cmb_settled_segment.EditValue
                    .Parameters.Add("@period_code", SqlDbType.SmallInt).Value = cmb_settled_period.EditValue
                    .Parameters.Add("@value_payment", SqlDbType.Decimal, 18, 2).Value = CDec(txt_settled_payment.EditValue)
                    .Parameters.Add("@value_increase", SqlDbType.Decimal, 18, 2).Value = CDec(txt_settled_increase.EditValue)
                    .Parameters.Add("@description_text", SqlDbType.VarChar, 300).Value = If(txt_condition_desc.EditValue, "El valor de comisión para la regla afectada es " + FormatCurrency((CDec(txt_settled_payment.EditValue) + CDec(txt_settled_increase.EditValue)), 0))
                    .Parameters.Add("@row_visible", SqlDbType.Bit).Value = chk_row_visible.Checked
                    .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                    .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                    .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                    .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                    .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
                End With

                If commission.execute_procedure = True Then
                End If
            Next

            'mensage de salida con la confirmación del proceso
            If message_text("Los pagos de comisión fueron modificados exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then
                start_home.removed_tabbed()
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
