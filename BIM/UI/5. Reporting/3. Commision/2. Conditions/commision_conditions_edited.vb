Public Class commision_conditions_edited
    Private operators As Operators = Operators.Instance
    Private parameters As Parameters = Parameters.Instance
    Private scheme As Schemes = Schemes.Instance
    Private commissions As Commision = Commision.Instance
    Private condition As Conditions = Conditions.Instance
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
        cmb_condition_scheme.Datasources(scheme.commision_schemes_search("row_visible=1"), "scheme_name")
        cmb_condition_segment.Datasources(parameters.settings_search_segments("row_visible=1"), "segment_name")
        cmb_condition_operator.Datasources(operators.settings_operators_search("row_visible=1"), "operator_name")
        cmb_condition_payment.Datasources(commissions.commision_payments_types("row_visible=1"), "commision_type")
        cmb_condition_mode.Datasources(commissions.commision_payments_modes("row_visible=1"), "mode_name")
        cmb_condition_periodicity.Datasources(commissions.commision_payments_periodicity("row_visible=1"), "periodicity_name")
        cmb_condition_tables.Datasources(scheme.commision_tables_search("row_visible=1"), "table_commision")
    End Sub

    Private Sub object_search()
        Dim table As DataTable = condition.conditions_schemes_search("c.Id=" & record_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                txt_condition_name.EditValue = .Item("condition_name").ToString
                cmb_condition_scheme.EditValue = cmb_condition_scheme.Properties.GetKeyValueByDisplayText(.Item("scheme_name").ToString)
                cmb_condition_segment.EditValue = cmb_condition_segment.Properties.GetKeyValueByDisplayText(.Item("segment_name").ToString)
                cmb_condition_operator.EditValue = cmb_condition_operator.Properties.GetKeyValueByDisplayText(.Item("operator_name").ToString)
                cmb_condition_mode.EditValue = cmb_condition_mode.Properties.GetKeyValueByDisplayText(.Item("mode_name").ToString)
                cmb_condition_payment.EditValue = cmb_condition_payment.Properties.GetKeyValueByDisplayText(.Item("commision_type").ToString)
                cmb_condition_periodicity.EditValue = cmb_condition_periodicity.Properties.GetKeyValueByDisplayText(.Item("periodicity_name").ToString)
                cmb_condition_tables.EditValue = cmb_condition_tables.Properties.GetKeyValueByDisplayText(.Item("table_commision").ToString)
                txt_condition_since.EditValue = CDate(.Item("since_date").ToString)
                txt_condition_until.EditValue = CDate(.Item("until_date").ToString)
                If .Item("description_text").ToString <> "" Then txt_condition_desc.EditValue = .Item("description_text").ToString
                chk_row_visible.Checked = CBool(.Item("row_visible"))

                'save data of current record
                source_current = trace_to_current(pnl_object_container)
            End With
        End If
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub validate_untildate(sender As Object, e As EventArgs) Handles txt_condition_until.Leave
        If txt_condition_until.EditValue IsNot Nothing Then
            If txt_condition_until.EditValue < txt_condition_since.EditValue Then
                message_text("La fecha de finalización no puede ser menor a la fecha de inicio", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub conserve_structure(conserve_status As Boolean)
        cmb_condition_scheme.Properties.ReadOnly = conserve_status
        cmb_condition_operator.Properties.ReadOnly = conserve_status
        cmb_condition_payment.Properties.ReadOnly = conserve_status
        txt_condition_since.Properties.ReadOnly = conserve_status
        txt_condition_until.Properties.ReadOnly = conserve_status
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With condition.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "commision_scheme_condition_edited"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
                .Parameters.Add("@condition_name", SqlDbType.VarChar, 50).Value = txt_condition_name.EditValue
                .Parameters.Add("@scheme_code", SqlDbType.TinyInt).Value = cmb_condition_scheme.EditValue
                .Parameters.Add("@segment_code", SqlDbType.TinyInt).Value = cmb_condition_segment.EditValue
                .Parameters.Add("@operator_code", SqlDbType.TinyInt).Value = cmb_condition_operator.EditValue
                .Parameters.Add("@since_date", SqlDbType.Date).Value = txt_condition_since.EditValue
                .Parameters.Add("@until_date", SqlDbType.Date).Value = txt_condition_until.EditValue
                .Parameters.Add("@mode_code", SqlDbType.TinyInt).Value = cmb_condition_mode.EditValue
                .Parameters.Add("@can_mixed", SqlDbType.TinyInt).Value = 2
                .Parameters.Add("@payment_type", SqlDbType.TinyInt).Value = cmb_condition_payment.EditValue
                .Parameters.Add("@periodicity_code", SqlDbType.TinyInt).Value = cmb_condition_periodicity.EditValue
                .Parameters.Add("@table_code", SqlDbType.SmallInt).Value = cmb_condition_tables.EditValue
                .Parameters.Add("@description_text", SqlDbType.VarChar, 300).Value = If(txt_condition_desc.EditValue, DBNull.Value)
                .Parameters.Add("@row_visible", SqlDbType.Bit).Value = chk_row_visible.Checked
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_edited(pnl_object_container, source_current)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If condition.execute_procedure = True Then
                      start_home.removed_tabbed()
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
              start_home.removed_tabbed()
    End Sub
#End Region
End Class
