Public Class relationship_budget_edited
    Private agency As Agencys = Agencys.Instance
    Private budget As Budgets = Budgets.Instance
    Private parameter As Parameters = Parameters.Instance
    Private scales As Scales = Scales.Instance
    Private source_current As DataTable
    Private row_affected As Integer

#Region "contructors"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'define el valor del parametro en la variable
        row_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
        object_search()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_budget_agency.Datasources(agency.settings_agencys_search("row_visible=1"), "agency_name")
        cmb_budget_type.Datasources(scales.commision_scales_types(), "scale_type")
        cmb_budget_segment.Datasources(parameter.settings_search_segments("row_visible=1"), "segment_name")
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub typed_change(sender As Object, e As EventArgs) Handles cmb_budget_type.EditValueChanged
        If cmb_budget_type.EditValue IsNot Nothing Then
            txt_budget_total.Properties.Mask.EditMask = cmb_budget_type.GetColumnValue("format_type")
            txt_budget_total.Properties.DisplayFormat.FormatString = cmb_budget_type.GetColumnValue("format_type")
            txt_budget_total.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            txt_budget_total.Properties.Mask.UseMaskAsDisplayFormat = True
        End If
    End Sub

    Private Function value_type(object_value As Object) As Object
        Dim process_result As Object = Nothing

        If cmb_budget_type.EditValue = "U" Then
            process_result = CInt(object_value.EditValue)

        ElseIf cmb_budget_type.EditValue = "$" Then
            process_result = CDec(object_value.EditValue)
        End If

        Return process_result
    End Function

    Private Sub object_search()
        Dim table As DataTable = budget.relationship_budgets_search("b.Id=" & row_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                cmb_budget_agency.EditValue = cmb_budget_agency.Properties.GetKeyValueByDisplayText(.Item("agency_name").ToString)
                cmb_budget_segment.EditValue = cmb_budget_segment.Properties.GetKeyValueByDisplayText(.Item("segment_name").ToString)
                cmb_budget_type.EditValue = .Item("operand_type").ToString
                txt_budget_total.EditValue = .Item("budget_total")
                txt_budget_month.EditValue = CDate("01/" & .Item("validity_month").ToString & "/" & .Item("validity_year").ToString)
                If .Item("description_text").ToString <> "" Then txt_attention_desc.EditValue = .Item("description_text")
                chk_row_visible.Checked = CBool(.Item("row_visible"))

                'save data of current record
                source_current = trace_to_current(pnl_object_container)
            End With
        End If
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With budget.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "relationship_customer_budgets_edited"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = row_affected
                .Parameters.Add("@agency_code", SqlDbType.TinyInt).Value = cmb_budget_agency.EditValue
                .Parameters.Add("@budget_total", SqlDbType.Decimal, 18, 2).Value = value_type(txt_budget_total)
                .Parameters.Add("@operand_type", SqlDbType.Char, 1).Value = cmb_budget_type.EditValue
                .Parameters.Add("@segment_code", SqlDbType.TinyInt).Value = cmb_budget_segment.EditValue
                .Parameters.Add("@validity_month", SqlDbType.TinyInt).Value = Month(txt_budget_month.EditValue)
                .Parameters.Add("@validity_year", SqlDbType.SmallInt).Value = Year(txt_budget_month.EditValue)
                .Parameters.Add("@description_text", SqlDbType.VarChar, 500).Value = If(txt_attention_desc.EditValue, DBNull.Value)
                .Parameters.Add("@row_visible", SqlDbType.Bit).Value = chk_row_visible.Checked
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_edited(pnl_object_container, source_current)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If budget.execute_procedure = True Then
                start_home.removed_tabbed()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
