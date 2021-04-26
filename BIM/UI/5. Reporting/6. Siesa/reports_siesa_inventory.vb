﻿Imports APDA.Object.Controls
Imports DevExpress.Data.Filtering
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraEditors.Repository
Imports Microsoft.Reporting.WinForms

Public Class reports_siesa_inventory
    Private reporting As Reporting = Reporting.Instance

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()

        crv_object_report.BorderStyle = BorderStyle.None
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        objects_condition()
    End Sub
#End Region

#Region "behaviors"
    Private Sub objects_condition()
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Centro de costo", "convert(varchar(50),w.ID_CO)", GetType(String), New RepositoryChecked(reporting.reporting_siesa_centers("[CODIGO] is not null"), "center_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Referencia", "convert(varchar(50),w.ID_ITEM)", GetType(String), New RepositoryChecked(reporting.reporting_siesa_products("[ID_ITEM] is not null"), "product_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Linea", "convert(varchar(50),i.ID_LINEA1)", GetType(String), New RepositoryChecked(reporting.reporting_siesa_categorys("[ID_LINEA] is not null"), "line_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Bodega", "convert(varchar(50),w.ID_LOCAL)", GetType(String), New RepositoryChecked(reporting.reporting_siesa_wineries("[ID_LOCAL] is not null"), "winerie_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Estado", "convert(int,w.CAN_DISPONIBLE)", GetType(Integer), New RepositoryListed(reporting.reporting_siesa_satus, "status_name"), FilterColumnClauseClass.Lookup))
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
    Private Sub search_option(sender As Object, e As EventArgs) Handles btn_object_find.Click
        If txt_rules_criteria.FilterString = "" Then
            message_text("Debe seleccionar minimo un criterio de busqueda", MessageBoxButtons.OK)
            Exit Sub
        Else
            'retorna el valor buscado a la variable
            Dim condition_search As String = criteria_condition()


            If condition_search <> "" Then
                'valida si en el parametro esta la condicion de disponibles seleccionada
                If condition_search.Contains("convert(int,w.CAN_DISPONIBLE)=1") Then
                    condition_search = Replace(condition_search, "convert(int,w.CAN_DISPONIBLE)=1", "convert(int,w.CAN_DISPONIBLE)>=1")
                End If

                'create instance of all objects
                Dim source As DataTable = reporting.reporting_siesa_available(condition_search & " and w.LAPSO_DOC='" & fn_date_oracle(Now) & "'")

                'check if source have rows to show
                If source.Rows.Count > 0 Then
                    With crv_object_report
                        .ProcessingMode = ProcessingMode.Local
                        .LocalReport.DataSources.Clear()
                        .LocalReport.DataSources.Add(New ReportDataSource("BIM", source))
                        .LocalReport.ReportEmbeddedResource = "BIM.reports_siesa_inventory.rdlc"
                        .RefreshReport()
                    End With
                End If
            Else
                message_text("No se encontrarón ventas con los criterios seleccionados", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub clean_option(sender As Object, e As EventArgs) Handles btn_object_clean.Click
        txt_rules_criteria.FilterCriteria = Nothing
        crv_object_report.LocalReport.DataSources.Clear()
        crv_object_report.Clear()
    End Sub

    Private Sub export_option(sender As Object, e As EventArgs) Handles btn_object_pdf.Click
        With crv_object_report
            If .LocalReport.DataSources IsNot Nothing Then
                If xfs_path.ShowDialog = DialogResult.OK Then
                    Dim DataToExport As Byte() = .LocalReport.Render("Excel", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                    Dim ExcelToExport As New IO.FileStream(xfs_path.FileName & ".xls", System.IO.FileMode.Create)
                    ExcelToExport.Write(DataToExport, 0, DataToExport.Length)
                    ExcelToExport.Close()

                    'mensaje de finalizacion del proceso
                    message_text("El reporte fué exportado exitosamente", MessageBoxButtons.OK)
                End If
            End If
        End With
    End Sub

    Private Sub next_page(sender As Object, e As EventArgs) Handles btn_object_right.Click
        With crv_object_report
            If .LocalReport.DataSources IsNot Nothing Then
                .CurrentPage = .CurrentPage + 1
            End If
        End With
    End Sub

    Private Sub before_page(sender As Object, e As EventArgs) Handles btn_object_left.Click
        With crv_object_report
            If .LocalReport.DataSources IsNot Nothing Then
                .CurrentPage = .CurrentPage - 1
            End If
        End With
    End Sub

    Private Sub printer_option(sender As Object, e As EventArgs) Handles btn_object_print.Click
        With crv_object_report
            If .LocalReport.DataSources IsNot Nothing Then
                .PrintDialog()
            End If
        End With
    End Sub

    Private Sub update_option(sender As Object, e As EventArgs) Handles btn_object_update.Click
        With crv_object_report
            If .LocalReport.DataSources IsNot Nothing Then
                .RefreshReport()
            End If
        End With
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_close.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
