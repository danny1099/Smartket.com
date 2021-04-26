Imports APDA.Object.Controls
Imports DevExpress.Data.Filtering
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraEditors.Repository

Public Class wholesales_guarantee_search
    Private customer As Customer = Customer.Instance
    Private agency As Agencys = Agencys.Instance
    Private person As Persons = Persons.Instance
    Private brand As Brands = Brands.Instance
    Private guarantee As Guarantee = Guarantee.Instance

#Region "objects"
    Public Property condition_criteria As String
#End Region

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load

        'load report to show data in lookupedit
        objects_condition()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub objects_condition()
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Fecha de venta", "g.date_sale", GetType(Date), New RepositoryDate, FilterColumnClauseClass.DateTime))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Fecha de registro", "convert(date,g.event_date)", GetType(Date), New RepositoryDate, FilterColumnClauseClass.DateTime))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Fecha de finalización", "g.close_date", GetType(Date), New RepositoryDate, FilterColumnClauseClass.DateTime))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Numero de serial", "g.number_serial", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Factura", "g.number_invoice", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("SKU", "g.sku_item", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Numero de radicado", "g.tracing_number", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Marca de producto", "g.brand_code", GetType(Integer), New RepositoryChecked(brand.services_brands_search("row_visible=1"), "brand_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Nombre del cliente", "g.customer_code", GetType(Integer), New RepositoryListed(customer.comercial_customer_listed("c.row_visible>=0 and c.agency_code in (" & sessions.agency_permit & ")"), "Nombre del cliente"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Documento", "c.number_document", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Agencia", "g.agency_code", GetType(Integer), New RepositoryChecked(agency.settings_agencys_search("row_visible=1 and a.Id in (" & sessions.agency_permit & ")"), "agency_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Nombre de funcionario", "g.person_code", GetType(Integer), New RepositoryChecked(person.settings_persons_listed("p.row_visible=1 and p.agency_code in (" & sessions.agency_permit & ")"), "Nombre del funcionario"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Estado", "g.row_visible", GetType(Integer), New RepositoryListed(guarantee.wholesale_guarantee_status(), "status_name"), FilterColumnClauseClass.Lookup))
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
#End Region

#Region "methods"
    Private Sub saved_option_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If txt_rules_criteria.FilterString = "" Then
            message_text("Debe seleccionar minimo un criterio de busqueda", MessageBoxButtons.OK)
            Exit Sub
        Else
            'define parameter with condition rules
            condition_criteria = criteria_condition()

            'check if condicion is not null to close
            If condition_criteria IsNot Nothing Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class