Public Class settings_budgets_create
    Private rules As Rules = Rules.Instance
    Private parameters As Parameters = Parameters.Instance
    Private budget As Budgets = Budgets.Instance
    Private scales As Scales = Scales.Instance
    Private record_affected As Integer

#Region "contructors"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        record_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'execute procedure to load sources and search current object
        object_listed()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_budget_segment.Datasources(parameters.settings_search_segments("row_visible=1"), "segment_name")
        cmb_budget_type.Datasources(scales.commision_scales_types(), "scale_type")
    End Sub

    Private Sub typed_change(sender As Object, e As EventArgs) Handles cmb_budget_type.EditValueChanged
        If cmb_budget_type.EditValue IsNot Nothing Then
            txt_budget_total.Properties.Mask.EditMask = cmb_budget_type.GetColumnValue("format_type")
            txt_budget_total.Properties.DisplayFormat.FormatString = cmb_budget_type.GetColumnValue("format_type")
            txt_budget_total.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            txt_budget_total.Properties.Mask.UseMaskAsDisplayFormat = True
        End If
    End Sub

    Private Sub segment_changed(sender As Object, e As EventArgs) Handles cmb_budget_segment.EditValueChanged
        If cmb_budget_segment.EditValue IsNot Nothing Then
            cmb_budget_rule.Datasources(rules.commision_rules_search("r.row_visible=1 and r.rule_type='C' and r.segment_code=" & cmb_budget_segment.EditValue), "rule_name")
        End If
    End Sub

    Private Function value_type(object_value As Object) As Object
        Dim process_result As Object = Nothing

        If cmb_budget_type.EditValue = "U" Then
            process_result = CInt(object_value.EditValue)

        ElseIf cmb_budget_type.EditValue = "%" Then
            process_result = CDec(object_value.EditValue) / 100

        ElseIf cmb_budget_type.EditValue = "$" Then
            process_result = CDec(object_value.EditValue)
        End If

        Return process_result
    End Function

    Private Sub conserve_changed(sender As Object, e As EventArgs) Handles chk_object_conserve.CheckedChanged
        conserve_structure(chk_object_conserve.Checked)
    End Sub

    Private Sub conserve_structure(conserve_status As Boolean)
        cmb_budget_segment.Properties.ReadOnly = conserve_status
        cmb_budget_type.Properties.ReadOnly = conserve_status
        txt_budget_month.Properties.ReadOnly = conserve_status
        If conserve_status = True Then chk_keep_form.Checked = True Else chk_keep_form.Checked = False
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With budget.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_workforce_budgets_create"

                .Parameters.Clear()
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = record_affected
                .Parameters.Add("@budget_total", SqlDbType.Decimal, 18, 2).Value = value_type(txt_budget_total)
                .Parameters.Add("@segment_code", SqlDbType.TinyInt).Value = cmb_budget_segment.EditValue
                .Parameters.Add("@operand_type", SqlDbType.Char, 1).Value = cmb_budget_type.EditValue
                .Parameters.Add("@rule_code", SqlDbType.Int).Value = cmb_budget_rule.EditValue
                .Parameters.Add("@validity_month", SqlDbType.TinyInt).Value = Month(txt_budget_month.EditValue)
                .Parameters.Add("@validity_year", SqlDbType.SmallInt).Value = Year(txt_budget_month.EditValue)
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If budget.execute_procedure = True Then
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