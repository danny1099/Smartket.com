Imports APDA.Object.Controls
Imports CrystalDecisions.Shared
Imports DevExpress.Data.Filtering
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraEditors.Repository

Public Class commision_proofs_showed
    Private operators As Operators = Operators.Instance
    Private dealer As Dealers = Dealers.Instance
    Private parameter As Parameters = Parameters.Instance
    Private agency As Agencys = Agencys.Instance
    Private person As Persons = Persons.Instance
    Private channel As Channels = Channels.Instance
    Private period As Periods = Periods.Instance
    Private commision As Commision = Commision.Instance
    Private report_settled As commision_proofs_reported

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()

        crv_object_report.BorderStyle = BorderStyle.None
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load report to show data in lookupedit
        objects_condition()
    End Sub
#End Region

#Region "behaviors"
    Private Sub objects_condition()
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Fecha de venta", "s.date_sale", GetType(Date), New RepositoryDate, FilterColumnClauseClass.DateTime))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Fecha de liquidación", "convert(date,p.event_date)", GetType(Date), New RepositoryDate, FilterColumnClauseClass.DateTime))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Nombre de consultor", "s.person_code", GetType(Integer), New RepositoryListed(person.settings_persons_listed("p.row_visible=1"), "Nombre del funcionario"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Agencia", "s.agency_code", GetType(Integer), New RepositoryChecked(agency.settings_agencys_search("row_visible=1"), "agency_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Distribuidor", "s.dealer_code", GetType(Integer), New RepositoryChecked(dealer.settings_dealers_search("row_visible=1"), "dealer_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Canal de ventas", "s.channel_code", GetType(Integer), New RepositoryListed(channel.settings_channels_search("row_visible=1"), "channel_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Anticipo CFM", "s.mark_advance", GetType(Integer), New RepositoryListed(parameter.settings_search_yesno2, "yes_no"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Lider de venta", "s.leader_code", GetType(Integer), New RepositoryChecked(person.settings_persons_leaders("d.director_code=3"), "person_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("MIN", "s.number_serial1", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("ICCID", "s.number_serial2", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("IMEI", "s.number_serial3", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Numero de cuenta", "s.segment_code=2 and s.number_serial1", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Serial y/o Referencia", "s.segment_code=3 and s.number_serial1", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Contrato", "s.number_contract", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Factura", "s.number_invoice", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Comprobante", "p.proof_payment", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Periodo de liquidación", "p.period_code", GetType(Integer), New RepositoryChecked(period.commision_periods_search("p.row_visible in (1,3) and p.can_subsettled=0"), "period_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Tipo de liquidación", "p.payment_type", GetType(Integer), New RepositoryListed(commision.commision_payments_types("row_visible=1 and t.Id not in (4)"), "commision_type"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Segmento", "s.segment_code", GetType(Integer), New RepositoryChecked(parameter.settings_search_segments("row_visible=1"), "segment_name"), FilterColumnClauseClass.Lookup))
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_close.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Function criteria_condition() As String
        Dim type_group As GroupOperator = TryCast(txt_rules_criteria.FilterCriteria, GroupOperator)

        If type_group IsNot Nothing Then Return type_conditions(type_group) Else Return type_conditions(txt_rules_criteria.FilterCriteria)
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

    Private Sub separator_changed(sender As Object, e As EventArgs) Handles lbl_object_separator1.Click
        If pnl_object_filter.Width = 350 Then
            pnl_object_filter.Width = 0
            With lbl_object_separator1
                .ImageOptions.Image = My.Resources.options_right
                .Appearance.BackColor = Color.FromArgb(230, 242, 250)
                .Appearance.BackColor2 = Color.FromArgb(230, 242, 250)
            End With

        ElseIf pnl_object_filter.Width = 0 Then
            pnl_object_filter.Width = 350
            With lbl_object_separator1
                .ImageOptions.Image = My.Resources.options_left
                .Appearance.BackColor = Color.White
                .Appearance.BackColor2 = Color.White
            End With
        End If
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_find.Click
        If txt_rules_criteria.FilterString = "" Then
            message_text("Debe seleccionar minimo un criterio de busqueda", MessageBoxButtons.OK)
            Exit Sub
        Else
            If criteria_condition() <> "" Then
                'create instance of all objects
                Dim source As DataTable = commision.commision_payments_proofs(criteria_condition)

                'check if source have rows to show
                If source.Rows.Count > 0 Then
                    report_settled = New commision_proofs_reported
                    report_settled.SetDataSource(source)
                    crv_object_report.ReportSource = report_settled
                End If
            End If
        End If
    End Sub

    Private Sub clean_option(sender As Object, e As EventArgs) Handles btn_object_clean.Click
        txt_rules_criteria.FilterCriteria = Nothing
        txt_rules_criteria.FilterColumns.Clear()
        crv_object_report.ReportSource = Nothing
    End Sub

    Private Sub export_option(sender As Object, e As EventArgs) Handles btn_object_pdf.Click
        If report_settled IsNot Nothing Then
            If xfs_path.ShowDialog = DialogResult.OK Then
                If xfs_path.FileName <> "" Then
                    Dim CrExportOptions As ExportOptions
                    Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
                    Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
                    CrDiskFileDestinationOptions.DiskFileName = xfs_path.FileName & ".pdf"
                    CrExportOptions = report_settled.ExportOptions
                    With CrExportOptions
                        .ExportDestinationType = ExportDestinationType.DiskFile
                        .ExportFormatType = ExportFormatType.PortableDocFormat
                        .DestinationOptions = CrDiskFileDestinationOptions
                        .FormatOptions = CrFormatTypeOptions
                    End With
                    report_settled.Export()

                    'message to confirm process
                    message_text("El comprobante de pago fué exportado exitosamente", MessageBoxButtons.OK)
                End If
            End If
        End If
    End Sub

    Private Sub update_option(sender As Object, e As EventArgs) Handles btn_object_update.Click
        If report_settled IsNot Nothing Then crv_object_report.RefreshReport()
    End Sub

    Private Sub printer_option(sender As Object, e As EventArgs) Handles btn_object_print.Click
        If report_settled IsNot Nothing Then crv_object_report.PrintReport()
    End Sub

    Private Sub next_page(sender As Object, e As EventArgs) Handles btn_object_right.Click
        If report_settled IsNot Nothing Then
            crv_object_report.ShowNextPage()
        End If
    End Sub

    Private Sub before_page(sender As Object, e As EventArgs) Handles btn_object_left.Click
        If report_settled IsNot Nothing Then
            crv_object_report.ShowPreviousPage()
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_close.Click
       Dispose()
    End Sub
#End Region
End Class
