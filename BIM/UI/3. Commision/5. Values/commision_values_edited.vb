Public Class commision_values_edited
    Private scheme As Schemes = Schemes.Instance
    Private commissions As Commision = Commision.Instance
    Private condition As Conditions = Conditions.Instance
    Private rules As Rules = Rules.Instance
    Private values_ As Values = Values.Instance
    Private source_current As DataTable
    Private record_affected As Integer

#Region "constructor"
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
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_values_scheme.Datasources(scheme.commision_schemes_search("row_visible=1"), "scheme_name")
        cmb_values_calcule.Datasources(values_.commision_values_calcules(), "calcule_name")
        cmb_values_payment.Datasources(commissions.commision_payments_types("row_visible=1"), "commision_type")
        cmb_values_tables.Datasources(scheme.commision_tables_search("row_visible=1"), "table_commision")
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub validate_untildate(sender As Object, e As EventArgs) Handles txt_values_until.Leave
        If txt_values_until.EditValue IsNot Nothing Then
            If txt_values_until.EditValue < txt_values_since.EditValue Then
                message_text("La fecha de finalización no puede ser menor a la fecha de inicio", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub conserve_structure(conserve_status As Boolean)
        cmb_values_scheme.Properties.ReadOnly = conserve_status
        cmb_values_condition.Properties.ReadOnly = conserve_status
        txt_values_since.Properties.ReadOnly = conserve_status
        txt_values_until.Properties.ReadOnly = conserve_status
    End Sub

    Private Sub scheme_changed(sender As Object, e As EventArgs) Handles cmb_values_scheme.EditValueChanged
        If cmb_values_scheme.EditValue IsNot Nothing Then
            cmb_values_condition.Datasources(condition.conditions_schemes_listed("s.row_visible=1 and c.scheme_code=" & cmb_values_scheme.EditValue), "condition_name")
        End If
    End Sub

    Private Sub payment_changed(sender As Object, e As EventArgs) Handles cmb_values_payment.EditValueChanged
        If cmb_values_payment.EditValue IsNot Nothing Then
            cmb_values_rules.Datasources(rules.commision_rules_listed("r.row_visible=1 and r.rule_type<>'C' and r.segment_code=" & cmb_values_condition.GetColumnValue("segment_code") & " and r.payment_type=" & cmb_values_payment.EditValue), "Nombre de la regla")
        End If
    End Sub

    Private Sub typed_change(sender As Object, e As EventArgs) Handles cmb_values_calcule.EditValueChanged
        If cmb_values_calcule.EditValue IsNot Nothing Then
            txt_values_payment.Properties.Mask.EditMask = cmb_values_calcule.GetColumnValue("format_type")
            txt_values_payment.Properties.DisplayFormat.FormatString = cmb_values_calcule.GetColumnValue("format_type")
            txt_values_payment.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            txt_values_payment.Properties.Mask.UseMaskAsDisplayFormat = True
        End If
    End Sub

    Private Function value_type(object_value As Object) As Object
        Dim process_result As Object = Nothing

        If cmb_values_calcule.EditValue = 1 Then
            process_result = CDec(object_value.EditValue)

        ElseIf cmb_values_calcule.EditValue <> 1 Then
            process_result = CDec(object_value.EditValue) / 100
        End If

        Return process_result
    End Function

    Private Function define_value(object_value As Object) As Object
        Dim process_result As Object = Nothing

        If cmb_values_calcule.EditValue = 1 Then
            process_result = CInt(object_value)

        ElseIf cmb_values_calcule.EditValue <> 1 Then
            process_result = CDec(object_value)
        End If

        Return process_result
    End Function

    Private Sub object_search()
        Dim table As DataTable = values_.commision_values_search("v.Id=" & record_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                cmb_values_scheme.EditValue = cmb_values_scheme.Properties.GetKeyValueByDisplayText(.Item("scheme_name").ToString)
                cmb_values_calcule.EditValue = cmb_values_calcule.Properties.GetKeyValueByDisplayText(.Item("calcule_name").ToString)
                cmb_values_condition.EditValue = CInt(.Item("condition_code"))
                cmb_values_payment.EditValue = cmb_values_payment.Properties.GetKeyValueByDisplayText(.Item("commision_type").ToString)
                txt_values_payment.EditValue = define_value(.Item("value_payment"))
                cmb_values_rules.EditValue = cmb_values_rules.Properties.GetKeyValueByDisplayText(.Item("rule_name").ToString)
                cmb_values_tables.EditValue = cmb_values_tables.Properties.GetKeyValueByDisplayText(.Item("table_commision").ToString)
                txt_values_since.EditValue = CDate(.Item("since_date").ToString)
                txt_values_until.EditValue = CDate(.Item("until_date").ToString)
                chk_row_visible.Checked = CBool(.Item("row_visible"))
                If .Item("description_text").ToString <> "" Then txt_values_desc.EditValue = .Item("description_text").ToString
                If .Item("can_increase") = "1" Then chk_can_increase.Checked = True

                'save data of current record
                source_current = trace_to_current(pnl_object_container)
            End With
        End If
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With values_.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "commision_scheme_values_edited"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
                .Parameters.Add("@condition_code", SqlDbType.Int).Value = cmb_values_condition.EditValue
                .Parameters.Add("@rule_code", SqlDbType.Int).Value = cmb_values_rules.EditValue
                .Parameters.Add("@value_payment", SqlDbType.Decimal, 18, 2).Value = value_type(txt_values_payment)
                .Parameters.Add("@operand_type", SqlDbType.Char, 1).Value = If(cmb_values_calcule.EditValue = 1, "$", "%")
                .Parameters.Add("@can_increase", SqlDbType.TinyInt).Value = If(chk_can_increase.Checked = True, 1, 2)
                .Parameters.Add("@calcule_code", SqlDbType.TinyInt).Value = cmb_values_calcule.EditValue
                .Parameters.Add("@payment_type", SqlDbType.TinyInt).Value = cmb_values_payment.EditValue
                .Parameters.Add("@since_date", SqlDbType.Date).Value = txt_values_since.EditValue
                .Parameters.Add("@until_date", SqlDbType.Date).Value = txt_values_until.EditValue
                .Parameters.Add("@table_code", SqlDbType.SmallInt).Value = cmb_values_tables.EditValue
                .Parameters.Add("@description_text", SqlDbType.VarChar, 300).Value = If(txt_values_desc.EditValue, DBNull.Value)
                .Parameters.Add("@row_visible", SqlDbType.Bit).Value = chk_row_visible.Checked
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_edited(pnl_object_container, source_current)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If values_.execute_procedure = True Then
               Dispose()
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
       Dispose()
    End Sub
#End Region
End Class
