Public Class conditions_counts_create
    Private condition As Conditions = Conditions.Instance
    Private commission As Commision = Commision.Instance
    Private rules As Rules = Rules.Instance
    Private record_affected As Integer
    Private segment_code As Integer

#Region "contructors"
    Public Sub New(row_selected As Integer, segment_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        record_affected = row_selected
        segment_code = segment_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'carga el listado de reglas
        object_listed()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_condition_payment.Datasources(commission.commision_payments_types("row_visible=1"), "commision_type")
    End Sub

    Private Sub payment_changed(sender As Object, e As EventArgs) Handles cmb_condition_payment.EditValueChanged
        If cmb_condition_payment.EditValue IsNot Nothing Then
            cmb_condition_rule.Datasources(rules.commision_rules_search("r.row_visible=1 and r.rule_type='C' and r.payment_type=" & cmb_condition_payment.EditValue & " and r.segment_code=" & segment_code), "rule_name")
        End If
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With condition.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "commision_scheme_count_create"

                .Parameters.Clear()
                .Parameters.Add("@condition_code", SqlDbType.Int).Value = record_affected
                .Parameters.Add("@rule_code", SqlDbType.Int).Value = cmb_condition_rule.EditValue
                .Parameters.Add("@payment_type", SqlDbType.TinyInt).Value = cmb_condition_payment.EditValue
                .Parameters.Add("@compare_type", SqlDbType.Char, 1).Value = If(chk_object_compare.Checked = True, "B", "S")
                .Parameters.Add("@counters_type", SqlDbType.Char, 1).Value = If(chk_object_counters.Checked = True, "G", "R")
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If condition.execute_procedure = True Then
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