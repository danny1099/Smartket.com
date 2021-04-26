Public Class commision_periods_edited
    Private period As Periods = Periods.Instance
    Private commision As Commision = Commision.Instance
    Private source_current As DataTable
    Private record_affected As Integer

#Region "contructors"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        record_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load report to show data in lookupeditt
        object_listed()
        object_search()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_period_periodicity.Datasources(commision.commision_payments_periodicity("row_visible=1"), "periodicity_name")
    End Sub

    Private Sub object_search()
        Dim table As DataTable = period.commision_periods_search("p.Id=" & record_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                txt_period_name.EditValue = .Item("period_name").ToString
                cmb_period_periodicity.EditValue = cmb_period_periodicity.Properties.GetKeyValueByDisplayText(.Item("periodicity_name").ToString)
                txt_period_since.EditValue = CDate(.Item("since_date"))
                txt_period_until.EditValue = CDate(.Item("until_date"))
                chk_can_subsettled.Checked = CBool(.Item("can_subsettled"))
                If .Item("row_visible").ToString = "1" Or .Item("row_visible").ToString = "3" Then chk_row_visible.Checked = True
                If .Item("can_earrings").ToString = "1" Then chk_can_earrings.Checked = True

                'save data of current record
                source_current = trace_to_current(pnl_object_container)
            End With
        End If
    End Sub

    Private Sub validate_untildate(sender As Object, e As EventArgs) Handles txt_period_until.Leave
        If txt_period_until.EditValue IsNot Nothing Then
            If txt_period_until.EditValue < txt_period_since.EditValue Then
                message_text("La fecha de finalización no puede ser menor a la fecha de inicio", MessageBoxButtons.OK)
            End If
        End If
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With period.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "wholesales_payment_period_edited"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.SmallInt).Value = record_affected
                .Parameters.Add("@period_name", SqlDbType.VarChar, 100).Value = txt_period_name.EditValue
                .Parameters.Add("@since_date", SqlDbType.Date).Value = txt_period_since.EditValue
                .Parameters.Add("@until_date", SqlDbType.Date).Value = txt_period_until.EditValue
                .Parameters.Add("@periodicity_code", SqlDbType.TinyInt).Value = cmb_period_periodicity.EditValue
                .Parameters.Add("@can_earrings", SqlDbType.TinyInt).Value = If(chk_can_earrings.Checked = True, 1, 2)
                .Parameters.Add("@can_subsettled", SqlDbType.Bit).Value = chk_can_subsettled.Checked
                .Parameters.Add("@row_visible", SqlDbType.Bit).Value = chk_row_visible.Checked
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_edited(pnl_object_container, source_current)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If period.execute_procedure = True Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class