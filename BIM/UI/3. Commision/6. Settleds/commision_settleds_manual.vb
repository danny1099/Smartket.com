Public Class commision_settleds_manual
    Private parameters As Parameters = Parameters.Instance
    Private commission As Commision = Commision.Instance
    Private rules As Rules = Rules.Instance
    Private period As Periods = Periods.Instance
    Private sales As Sales = Sales.Instance
    Private last_control As Control
    Private rows_selected As List(Of PaymentManual)

#Region "constructor"
    Public Sub New(row_selected_ As List(Of PaymentManual), lasted_control As Control)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        rows_selected = row_selected_
        last_control = lasted_control
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_settled_segment.Datasources(parameters.settings_search_segments("row_visible=1"), "segment_name")
        cmb_settled_period.Datasources(period.commision_periods_search("p.row_visible in (3)"), "period_name")

        'carga la fecha de liquidacion del modulo
        txt_settled_date.EditValue = Now
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
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
            For Each row_manual As PaymentManual In rows_selected
                With commission.sql_command
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "wholesales_payment_settled_manual"

                    .Parameters.Clear()
                    .Parameters.Add("@wholesales_code", SqlDbType.Int).Value = row_manual.wholesale
                    .Parameters.Add("@value_payment", SqlDbType.Decimal, 18, 2).Value = CDec(txt_settled_payment.EditValue)
                    .Parameters.Add("@value_increase", SqlDbType.Decimal, 18, 2).Value = CDec(txt_settled_increase.EditValue)
                    .Parameters.Add("@rule_code", SqlDbType.Int).Value = 0
                    .Parameters.Add("@rule_name", SqlDbType.VarChar, 100).Value = txt_settled_rules.Text
                    .Parameters.Add("@period_code", SqlDbType.SmallInt).Value = cmb_settled_period.EditValue
                    .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = row_manual.person_code
                    .Parameters.Add("@payment_type", SqlDbType.TinyInt).Value = 1
                    .Parameters.Add("@status_code", SqlDbType.TinyInt).Value = 1
                    .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                    .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                    .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                    .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
                End With

                If commission.execute_procedure(False) = True Then
                End If
            Next

            'mensaje de salida con la confirmacion del proceso
            If message_text("La comisión manual fué registrada exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then
                      Dispose()
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
              Dispose()
    End Sub
#End Region
End Class
