Public Class conditions_scales_create
    Private condition As Conditions = Conditions.Instance
    Private tables As Schemes = Schemes.Instance
    Private rules As Rules = Rules.Instance
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
        cmb_scales_rule.Datasources(rules.commision_rules_search("r.row_visible=1 and r.rule_type='C'"), "rule_name")
        cmb_scales_type.Datasources(scales.commision_scales_types(True), "scale_type")
        cmb_scales_tables.Datasources(tables.commision_tables_search("row_visible=1"), "table_commision")
    End Sub

    Private Sub typed_change(sender As Object, e As EventArgs) Handles cmb_scales_type.EditValueChanged
        If cmb_scales_type.EditValue IsNot Nothing Then
            txt_scales_since.Properties.Mask.EditMask = cmb_scales_type.GetColumnValue("format_type")
            txt_scales_since.Properties.DisplayFormat.FormatString = cmb_scales_type.GetColumnValue("format_type")
            txt_scales_since.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric

            txt_scales_until.Properties.Mask.EditMask = cmb_scales_type.GetColumnValue("format_type")
            txt_scales_until.Properties.DisplayFormat.FormatString = cmb_scales_type.GetColumnValue("format_type")
            txt_scales_until.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric

            txt_scales_since.Properties.Mask.UseMaskAsDisplayFormat = True
            txt_scales_until.Properties.Mask.UseMaskAsDisplayFormat = True
        End If
    End Sub

    Private Sub increase_change(sender As Object, e As EventArgs) Handles lbl_scales_addincrease.Click
        If lbl_scales_addincrease.Text = "Agregar incremento de comisión" Then
            txt_scales_since.Size = txt_scales_since.MinimumSize
            txt_scales_until.Size = txt_scales_until.MinimumSize

            'change position field until value
            lbl_scales_until.Location = New Point(186, 277)
            txt_scales_until.Location = New Point(186, 297)
            lbl_scales_increase.Visible = True
            txt_scales_increase.Visible = True
            lbl_scales_addincrease.Text = "Quitar incremento de comisión"

        ElseIf lbl_scales_addincrease.Text = "Quitar incremento de comisión" Then
            txt_scales_since.Size = txt_scales_since.MaximumSize
            txt_scales_until.Size = txt_scales_until.MaximumSize

            'change position field until value
            lbl_scales_until.Location = New Point(261, 277)
            txt_scales_until.Location = New Point(261, 297)
            lbl_scales_increase.Visible = False
            txt_scales_increase.Visible = False
            txt_scales_increase.EditValue = Nothing
            lbl_scales_addincrease.Text = "Agregar incremento de comisión"
        End If
    End Sub

    Private Function value_type(object_value As Object) As Object
        Dim process_result As Object = Nothing

        If cmb_scales_type.EditValue = "U" Then
            process_result = CInt(object_value.EditValue)

        ElseIf cmb_scales_type.EditValue = "%" Then
            process_result = CDec(Replace(object_value.EditValue, "%", "")) / 100

        ElseIf cmb_scales_type.EditValue = "$" Then
            process_result = CDec(object_value.EditValue)
        End If

        Return process_result
    End Function

    Private Sub conserve_structure(conserve_status As Boolean)
        cmb_scales_rule.Properties.ReadOnly = conserve_status
        cmb_scales_type.Properties.ReadOnly = conserve_status
        If conserve_status = True Then chk_keep_form.Checked = True Else chk_keep_form.Checked = False
    End Sub

    Private Sub conserve_changed(sender As Object, e As EventArgs) Handles chk_object_conserve.CheckedChanged
        conserve_structure(chk_object_conserve.Checked)
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With scales.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "commision_scheme_scales_create"

                .Parameters.Clear()
                .Parameters.Add("@condition_code", SqlDbType.Int).Value = record_affected
                .Parameters.Add("@since_value", SqlDbType.Decimal, 18, 4).Value = value_type(txt_scales_since)
                .Parameters.Add("@until_value", SqlDbType.Decimal, 18, 4).Value = value_type(txt_scales_until)
                .Parameters.Add("@operand_type", SqlDbType.Char, 1).Value = cmb_scales_type.EditValue
                .Parameters.Add("@increase_value", SqlDbType.VarChar, 50).Value = If(txt_scales_increase.EditValue, "0%")
                .Parameters.Add("@rule_code", SqlDbType.Int).Value = cmb_scales_rule.EditValue
                .Parameters.Add("@apply_rules", SqlDbType.Bit).Value = chk_object_apply.Checked
                .Parameters.Add("@table_commision", SqlDbType.SmallInt).Value = cmb_scales_tables.EditValue
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If scales.execute_procedure = True Then
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