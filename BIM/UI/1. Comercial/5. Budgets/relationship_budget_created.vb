Public Class relationship_budget_created
    Private agencys As Agencys = Agencys.Instance
    Private budget As Budgets = Budgets.Instance
    Private parameter As Parameters = Parameters.Instance
    Private scales As Scales = Scales.Instance
    Private category As Categorys = Categorys.Instance

#Region "contructors"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_budget_agency.Datasources(agencys.settings_agencys_search("row_visible=1"), "agency_name")
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

    Private Sub conserve_changed(sender As Object, e As EventArgs) Handles chk_object_conserve.CheckedChanged
        conserve_structure(chk_object_conserve.Checked)
    End Sub

    Private Sub conserve_structure(conserve_status As Boolean)
        cmb_budget_agency.Properties.ReadOnly = conserve_status
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
                .CommandText = "relationship_customer_budgets_create"

                .Parameters.Clear()
                .Parameters.Add("@agency_code", SqlDbType.TinyInt).Value = cmb_budget_agency.EditValue
                .Parameters.Add("@budget_total", SqlDbType.Decimal, 18, 2).Value = value_type(txt_budget_total)
                .Parameters.Add("@operand_type", SqlDbType.Char, 1).Value = cmb_budget_type.EditValue
                .Parameters.Add("@segment_code", SqlDbType.TinyInt).Value = cmb_budget_segment.EditValue
                .Parameters.Add("@validity_month", SqlDbType.TinyInt).Value = Month(txt_budget_month.EditValue)
                .Parameters.Add("@validity_year", SqlDbType.SmallInt).Value = Year(txt_budget_month.EditValue)
                .Parameters.Add("@description_text", SqlDbType.VarChar, 500).Value = If(txt_attention_desc.EditValue, DBNull.Value)
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
                    start_home.removed_tabbed()
                End If
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
