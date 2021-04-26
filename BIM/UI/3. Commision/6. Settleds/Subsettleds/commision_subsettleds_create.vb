﻿Imports APDA.Object.Controls
Imports DevExpress.Data.Filtering
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.XtraEditors.Filtering
Public Class commision_subsettleds_create
    Private parameter As Parameters = Parameters.Instance
    Private operators As Operators = Operators.Instance
    Private dealer As Dealers = Dealers.Instance
    Private agency As Agencys = Agencys.Instance
    Private person As Persons = Persons.Instance
    Private channel As Channels = Channels.Instance
    Private period As Periods = Periods.Instance
    Private commision As Commision = Commision.Instance

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load report to show data in lookupedit
        object_listed()
        criteria_object()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_settled_segment.Datasources(parameter.settings_search_segments("row_visible=1"), "segment_name")
        cmb_settled_period.Datasources(period.commision_periods_search("p.row_visible=3 and p.can_subsettled=1"), "period_name")
        cmb_settled_person.Datasources(person.settings_persons_listed("p.row_visible in (1)"), "Nombre del funcionario")
        cmb_settled_type.Datasources(parameter.settings_search_money(), "money_type")
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub period_changed(sender As Object, e As EventArgs) Handles cmb_settled_period.EditValueChanged
        If cmb_settled_period.EditValue IsNot Nothing Then
            txt_settled_since.EditValue = CDate(cmb_settled_period.GetColumnValue("since_date"))
            txt_settled_until.EditValue = CDate(cmb_settled_period.GetColumnValue("until_date"))
        End If
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_settled_person.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            sender.Properties.View.Columns("Id").Visible = False
        End If
    End Sub

    Private Sub criteria_object()
        txt_settled_criteria.FilterColumns.Add(New UnboundFilterColumn("Consultor", "s.person_code", GetType(Integer), New RepositoryListed(person.settings_persons_listed("p.row_visible=1"), "Nombre del funcionario"), FilterColumnClauseClass.Lookup))
        txt_settled_criteria.FilterColumns.Add(New UnboundFilterColumn("Lider de venta", "s.leader_code", GetType(Integer), New RepositoryChecked(person.settings_persons_leaders("d.director_code=3"), "person_name"), FilterColumnClauseClass.Lookup))
        txt_settled_criteria.FilterColumns.Add(New UnboundFilterColumn("Agencia", "s.agency_code", GetType(Integer), New RepositoryChecked(agency.settings_agencys_search("row_visible=1"), "agency_name"), FilterColumnClauseClass.Lookup))
        txt_settled_criteria.FilterColumns.Add(New UnboundFilterColumn("Distribuidor", "s.dealer_code", GetType(Integer), New RepositoryChecked(dealer.settings_dealers_search("row_visible=1"), "dealer_name"), FilterColumnClauseClass.Lookup))
        txt_settled_criteria.FilterColumns.Add(New UnboundFilterColumn("Canal de ventas", "s.channel_code", GetType(Integer), New RepositoryChecked(channel.settings_channels_search("row_visible=1"), "channel_name"), FilterColumnClauseClass.Lookup))
        txt_settled_criteria.FilterColumns.Add(New UnboundFilterColumn("Operador", "s.operator_code", GetType(Integer), New RepositoryChecked(operators.settings_operators_search("row_visible=1"), "operator_name"), FilterColumnClauseClass.Lookup))
        txt_settled_criteria.FilterColumns.Add(New UnboundFilterColumn("Anticipo CFM", "s.mark_advance", GetType(Integer), New RepositoryListed(parameter.settings_search_yesno2, "yes_no"), FilterColumnClauseClass.Lookup))
    End Sub

    Private Sub conserve_changed(sender As Object, e As EventArgs) Handles chk_object_conserve.CheckedChanged
        conserve_structure(chk_object_conserve.Checked)
    End Sub

    Private Sub conserve_structure(conserve_status As Boolean)
        cmb_settled_period.Properties.ReadOnly = conserve_status
        If conserve_status = True Then chk_keep_form.Checked = True Else chk_keep_form.Checked = False
    End Sub

    Private Sub created_period(sender As Object, e As EventArgs) Handles lbl_settled_newperiod.Click
        Using new_ As New commision_periods_create
            new_.ShowDialog(start_home)
        End Using
    End Sub

    Private Sub typed_change(sender As Object, e As EventArgs) Handles cmb_settled_type.EditValueChanged
        If cmb_settled_type.EditValue IsNot Nothing Then
            txt_settled_payment.Properties.ReadOnly = False
            txt_settled_payment.Properties.Mask.EditMask = cmb_settled_type.GetColumnValue("format_type")
            txt_settled_payment.Properties.DisplayFormat.FormatString = cmb_settled_type.GetColumnValue("format_type")
            txt_settled_payment.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            txt_settled_payment.Properties.Mask.UseMaskAsDisplayFormat = True
        End If
    End Sub

    Private Function value_type(object_value As Object) As Decimal
        Dim process_result As Decimal = Nothing

        If cmb_settled_type.EditValue = 1 Then
            process_result = CDec(object_value.EditValue)

        ElseIf cmb_settled_type.EditValue <> 1 Then
            process_result = CDec(object_value.EditValue) / 100
        End If

        Return process_result
    End Function

    Private Sub comision_change(sender As Object, e As EventArgs) Handles lbl_settles_comision.Click
        If lbl_settles_comision.Text = "Agregar valor de comisión" Then
            txt_settled_criteria.Size = txt_settled_criteria.MinimumSize
            txt_settled_payment.EditValue = Nothing
            cmb_settled_type.EditValue = Nothing
            lbl_settles_comision.Text = "Quitar valor de comisión"

        ElseIf lbl_settles_comision.Text = "Quitar valor de comisión" Then
            txt_settled_criteria.Size = txt_settled_criteria.MaximumSize
            txt_settled_payment.EditValue = Nothing
            cmb_settled_type.EditValue = Nothing
            txt_settled_payment.Properties.ReadOnly = True
            lbl_settles_comision.Text = "Agregar valor de comisión"
        End If
    End Sub

    Private Function settled_method(segment_code As Integer) As String
        Select Case segment_code
            Case 1 : Return "wholesales_payment_subsettled_movil"
            Case 2 : Return "wholesales_payment_subsettled_hogar"
            Case 3 : Return "wholesales_payment_subsettled_frees"
        End Select

        Throw New ArgumentOutOfRangeException(segment_code)
    End Function
#End Region

#Region "helpers"
    Private Function criteria_condition() As String
        Dim type_group As GroupOperator = TryCast(txt_settled_criteria.FilterCriteria, GroupOperator)

        If type_group IsNot Nothing Then Return type_conditions(type_group) Else Return type_conditions(txt_settled_criteria.FilterCriteria)
    End Function

    Private Function type_conditions(group_condition As GroupOperator) As String
        Dim condition_string As String = Nothing
        Dim condition_criteria As Object = Nothing

        If group_condition IsNot Nothing Then
            For Each condition As CriteriaOperator In group_condition.Operands
                If TypeOf condition Is BinaryOperator Then condition_criteria = TryCast(condition, BinaryOperator)
                If TypeOf condition Is InOperator Then condition_criteria = TryCast(condition, InOperator)
                If TypeOf condition Is BetweenOperator Then condition_criteria = TryCast(condition, BetweenOperator)
                If TypeOf condition Is UnaryOperator Then condition_criteria = TryCast(condition, UnaryOperator)

                If condition_string Is Nothing Then condition_string = operand_condition(condition_criteria) Else condition_string += condition_group(group_condition.OperatorType) & operand_condition(condition_criteria)
            Next
        End If

        Return condition_string
    End Function

    Private Function type_conditions(condition As CriteriaOperator) As String
        Dim condition_criteria As Object = Nothing

        If TypeOf condition Is BinaryOperator Then condition_criteria = TryCast(condition, BinaryOperator)
        If TypeOf condition Is InOperator Then condition_criteria = TryCast(condition, InOperator)
        If TypeOf condition Is BetweenOperator Then condition_criteria = TryCast(condition, BetweenOperator)
        If TypeOf condition Is UnaryOperator Then condition_criteria = TryCast(condition, UnaryOperator)

        Return operand_condition(condition_criteria)
    End Function

    Public Function operand_condition(operand As BinaryOperator) As String
        Dim value_property As OperandProperty
        Dim value_operand1 As OperandValue

        value_property = TryCast(operand.LeftOperand, OperandProperty)
        value_operand1 = TryCast(operand.RightOperand, OperandValue)

        Return CStr(value_property.PropertyName & operator_type(operand.OperatorType) & Replace(value_type(value_operand1), " ", ""))
    End Function

    Public Function operand_condition(operand As InOperator) As String
        Dim value_property As OperandProperty
        Dim value_operand1 As OperandValue

        value_property = TryCast(operand.LeftOperand, OperandProperty)
        value_operand1 = TryCast(operand.Operands(0), OperandValue)

        Return CStr(value_property.PropertyName & " in (" & Replace(value_operand1.Value, " ", "") & ")")
    End Function

    Public Function operand_condition(operand As UnaryOperator) As String
        Dim operand_object As InOperator = TryCast(operand.Operand, InOperator)
        Dim value_property As OperandProperty
        Dim value_operand1 As OperandValue

        value_property = TryCast(operand_object.LeftOperand, OperandProperty)
        value_operand1 = TryCast(operand_object.Operands(0), OperandValue)

        Return CStr(value_property.PropertyName & " not in (" & Replace(value_operand1.Value, " ", "") & ")")
    End Function

    Public Function operand_condition(operand As BetweenOperator) As String
        Dim value_property As OperandProperty
        Dim value_operand1 As OperandValue
        Dim value_operand2 As OperandValue

        value_property = TryCast(operand.TestExpression, OperandProperty)
        value_operand1 = TryCast(operand.BeginExpression, OperandValue)
        value_operand2 = TryCast(operand.EndExpression, OperandValue)

        Return CStr(value_property.PropertyName & " between " & value_type(value_operand1) & " and " & value_type(value_operand2))
    End Function

    Private Function operator_type(typeoperator As BinaryOperatorType) As String
        Dim operator_string As String = ""

        If typeoperator = BinaryOperatorType.Equal Then operator_string = "="
        If typeoperator = BinaryOperatorType.Less Then operator_string = "<"
        If typeoperator = BinaryOperatorType.LessOrEqual Then operator_string = "<="
        If typeoperator = BinaryOperatorType.Greater Then operator_string = ">"
        If typeoperator = BinaryOperatorType.GreaterOrEqual Then operator_string = ">="
        If typeoperator = BinaryOperatorType.NotEqual Then operator_string = " <> "

        Return operator_string
    End Function

    Private Function value_type(value_operator As OperandValue) As String
        Dim value_string As String = ""

        If TypeOf value_operator.Value Is Date Then
            value_string = "'" & CDate(value_operator.Value).ToString("yyyy-MM-dd") & "'"
        End If

        If TypeOf value_operator.Value Is Integer Then
            value_string = CInt(value_operator.Value)
        End If

        If TypeOf value_operator.Value Is String Then
            value_string = "'" & CStr(value_operator.Value).ToString & "'"
        End If

        Return value_string
    End Function

    Private Function condition_group(typeofoperator As GroupOperatorType) As String
        Dim condition_string As String = ""

        If typeofoperator = GroupOperatorType.And Then condition_string = " and "
        If typeofoperator = GroupOperatorType.Or Then condition_string = " or "

        Return condition_string
    End Function
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With commision.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 120
                .CommandText = settled_method(cmb_settled_segment.EditValue)

                .Parameters.Clear()
                .Parameters.Add("@period_code", SqlDbType.SmallInt).Value = cmb_settled_period.EditValue
                .Parameters.Add("@criteria_settlement", SqlDbType.VarChar, 1000).Value = criteria_condition()
                .Parameters.Add("@person_settled", SqlDbType.SmallInt).Value = cmb_settled_person.EditValue
                .Parameters.Add("@settles_replace", SqlDbType.Decimal, 18, 4).Value = If(txt_settled_payment.EditValue Is Nothing, DBNull.Value, value_type(txt_settled_payment))
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With 


            If commision.execute_procedure = True Then
                If chk_keep_form.Checked = True Then
                    If chk_object_conserve.Checked = False Then defaults_objects(pnl_object_container)
                Else
                   Dispose()
                End If
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
       Dispose()
    End Sub
#End Region
End Class
