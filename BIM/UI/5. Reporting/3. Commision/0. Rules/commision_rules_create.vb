Imports APDA.Object.Controls
Imports DevExpress.Data.Filtering
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraEditors.Repository

Public Class commision_rules_create
    Private operators As Operators = Operators.Instance
    Private dealer As Dealers = Dealers.Instance
    Private parameter As Parameters = Parameters.Instance
    Private product As Products = Products.Instance
    Private category As Categorys = Categorys.Instance
    Private brand As Brands = Brands.Instance
    Private agency As Agencys = Agencys.Instance
    Private person As Persons = Persons.Instance
    Private sale As Sales = Sales.Instance
    Private commision As Commision = Commision.Instance
    Private rules As Rules = Rules.Instance

#Region "objects"
    Private compare_object As String
    Private compare_fields As String
    Private search_object() As String = {"s.services_array", "s.category_code"}
#End Region

#Region "constructor"
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
        cmb_rules_operator.Datasources(operators.settings_operators_search("row_visible=1"), "operator_name")
        cmb_rules_segment.Datasources(parameter.settings_search_segments("row_visible=1"), "segment_name")
        cmb_rules_type.Datasources(rules.commision_rules_types(), "rule_type")
        cmb_rules_payment.Datasources(commision.commision_payments_types("row_visible=1"), "commision_type")
        cmb_rules_function.Datasources(commision.commision_payments_functions(), "function_name")
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub segment_change(sender As Object, e As EventArgs) Handles cmb_rules_segment.EditValueChanged
        If cmb_rules_segment.EditValue IsNot Nothing Then
            txt_rules_criteria.FilterCriteria = Nothing
            txt_rules_criteria.FilterColumns.Clear()

            'load conditions per segment code
            criteria_condition(cmb_rules_segment.EditValue)
        End If
    End Sub

    Private Sub criteria_condition(segment_code As Integer)
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Fecha de venta", "s.date_sale", GetType(Date), New RepositoryDate, FilterColumnClauseClass.DateTime))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Consultor", "s.person_code", GetType(Integer), New RepositoryChecked(person.settings_persons_listed("p.row_visible=1"), "Nombre del funcionario"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Agencia", "s.agency_code", GetType(Integer), New RepositoryChecked(agency.settings_agencys_search("row_visible=1"), "agency_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Distribuidor", "s.dealer_code", GetType(Integer), New RepositoryChecked(dealer.settings_dealers_search("row_visible=1"), "dealer_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Convergente", "s.mark_convergent", GetType(Integer), New RepositoryListed(parameter.settings_search_yesno, "yes_no"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Lider de venta", "s.leader_code", GetType(Integer), New RepositoryChecked(person.settings_persons_leaders("d.director_code=3"), "person_name"), FilterColumnClauseClass.Lookup))

        'fields exclusive of segment movil
        If segment_code = 1 Then
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Nombre del plan", "s.product_code1", GetType(Integer), New RepositoryChecked(product.services_products_listed("s.row_visible=1 and s.product_type=1 and s.segment_code=1"), "Nombre del producto"), FilterColumnClauseClass.Lookup))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Categoria", "s.category_code", GetType(Integer), New RepositoryChecked(category.services_categorys_search("row_visible=1"), "category_name"), FilterColumnClauseClass.Lookup))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Equipo", "s.product_code2", GetType(Integer), New RepositoryChecked(product.services_products_listed("s.row_visible=1 and s.product_type=2"), "Nombre del producto"), FilterColumnClauseClass.Lookup))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Cargo Fijo", "s.value_sales1", GetType(Integer), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Valor Equipo", "s.value_sales2", GetType(Integer), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Clasificación", "s.mark_mixed", GetType(Integer), New RepositoryListed(parameter.settings_search_clasification, "class_type"), FilterColumnClauseClass.Lookup))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Marca de equipo", "s.brand_code", GetType(Integer), New RepositoryChecked(brand.services_brands_search("row_visible=1"), "brandname"), FilterColumnClauseClass.Lookup))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Portabilidad", "s.mark_ported", GetType(Integer), New RepositoryListed(parameter.settings_search_yesno, "yes_no"), FilterColumnClauseClass.Lookup))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Migración", "s.mark_migration", GetType(Integer), New RepositoryListed(parameter.settings_search_yesno, "yes_no"), FilterColumnClauseClass.Lookup))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Cuotas", "s.quotas_code", GetType(Integer), New RepositoryChecked(parameter.settings_search_quotas("row_visible=1"), "quotas_name"), FilterColumnClauseClass.Lookup))

            'fields exclusive of segment hogar
        ElseIf segment_code = 2 Then
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Categoria", "s.category_code", GetType(Integer), New RepositoryChecked(category.services_categorys_search("row_visible=1"), "category_name"), FilterColumnClauseClass.Lookup))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Fecha Legalización", "s.date_reception", GetType(Date), New RepositoryDate, FilterColumnClauseClass.DateTime))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Nombre del producto", "s.services_array", GetType(Integer), New RepositoryChecked(product.services_products_listed("s.row_visible=1 and s.product_type=1 and s.segment_code=2"), "Nombre del producto"), FilterColumnClauseClass.Lookup))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Estrato", "s.stratum_code", GetType(Integer), New RepositoryChecked(parameter.settings_search_stratum("row_visible=1"), "stratum_name"), FilterColumnClauseClass.Lookup))

            'field special per type rule
            If cmb_rules_type.EditValue <> "C" Then txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Cargo Fijo", "s.value_sales1", GetType(Integer), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
            If cmb_rules_type.EditValue <> "C" Then txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Tipo de venta", "s.services_type", GetType(Integer), New RepositoryChecked(sale.wholesale_sales_types("row_visible=1"), "type_sale"), FilterColumnClauseClass.Lookup))


            'fields exclusive of segment hogar
        ElseIf segment_code = 3 Then
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Equipo", "s.product_code2", GetType(Integer), New RepositoryChecked(product.services_products_listed("s.row_visible=1 and s.product_type=2"), "Nombre del producto"), FilterColumnClauseClass.Lookup))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Accesorio", "s.product_code1", GetType(Integer), New RepositoryChecked(product.services_products_listed("s.row_visible=1 and s.product_type in (3,4) and s.segment_code=3"), "Nombre del producto"), FilterColumnClauseClass.Lookup))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Valor de venta", "s.value_sales1", GetType(Integer), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Valor del equipo", "s.value_sales2", GetType(Integer), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Cuotas", "s.quotas_code", GetType(Integer), New RepositoryChecked(parameter.settings_search_quotas("row_visible=1"), "quotas_name"), FilterColumnClauseClass.Lookup))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Marca", "s.brand_code", GetType(Integer), New RepositoryChecked(brand.services_brands_search("row_visible=1"), "brandname"), FilterColumnClauseClass.Lookup))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Tipo de producto (Accesorios)", "s.product_type1", GetType(Integer), New RepositoryListed(product.services_products_type("row_visible=1 and t.Id in (3,4)"), "product_type"), FilterColumnClauseClass.Lookup))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Tipo de producto (Equipos)", "s.product_type2", GetType(Integer), New RepositoryListed(product.services_products_type("row_visible=1 and t.Id in (2)"), "product_type"), FilterColumnClauseClass.Lookup))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Categoria", "s.category_code", GetType(Integer), New RepositoryChecked(category.services_categorys_search("row_visible=1 and c.segment_code=3"), "category_name"), FilterColumnClauseClass.Lookup))
            txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Proveedor", "s.provider_code", GetType(Integer), New RepositoryChecked(product.services_providers_search("row_visible=1"), "provider_name"), FilterColumnClauseClass.Lookup))
        End If
    End Sub

    Private Sub conserve_changed(sender As Object, e As EventArgs) Handles chk_object_conserve.CheckedChanged
        conserve_structure(chk_object_conserve.Checked)
    End Sub

    Private Sub conserve_structure(conserve_status As Boolean)
        cmb_rules_type.Properties.ReadOnly = conserve_status
        cmb_rules_operator.Properties.ReadOnly = conserve_status
        cmb_rules_segment.Properties.ReadOnly = conserve_status
        cmb_rules_payment.Properties.ReadOnly = conserve_status
        If conserve_status = True Then chk_keep_form.Checked = True
    End Sub
#End Region

#Region "helpers"
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

        'check if field existe in array comparison if segment are hogar
        If cmb_rules_segment.EditValue = 2 Then
            If (Array.Find(search_object, Function(s) s = value_property.PropertyName)) <> "" Then
                compare_object = Replace(value_type(value_operand1), " ", "")
                compare_fields = "trc_object"
                cmb_rules_function.EditValue = "C"
            End If
        End If

        Return CStr(value_property.PropertyName & operator_type(operand.OperatorType) & Replace(value_type(value_operand1), " ", ""))
    End Function

    Public Function operand_condition(operand As InOperator) As String
        Dim value_property As OperandProperty
        Dim value_operand1 As OperandValue

        value_property = TryCast(operand.LeftOperand, OperandProperty)
        value_operand1 = TryCast(operand.Operands(0), OperandValue)

        'check if field existe in array comparison if segment are hogar
        If cmb_rules_segment.EditValue = 2 Then
            If (Array.Find(search_object, Function(s) s = value_property.PropertyName)) <> "" Then
                compare_fields = "trc_object"
                cmb_rules_function.EditValue = "S"
            End If
        End If

        Return CStr(value_property.PropertyName & " in (" & Replace(value_operand1.Value, " ", "") & ")")
    End Function

    Public Function operand_condition(operand As UnaryOperator) As String
        Dim operand_object As InOperator = TryCast(operand.Operand, InOperator)
        Dim value_property As OperandProperty
        Dim value_operand1 As OperandValue

        value_property = TryCast(operand_object.LeftOperand, OperandProperty)
        value_operand1 = TryCast(operand_object.Operands(0), OperandValue)

        'check if field existe in array comparison if segment are hogar
        If cmb_rules_segment.EditValue = 2 Then
            If (Array.Find(search_object, Function(s) s = value_property.PropertyName)) <> "" Then
                compare_fields = "trc_object"
                cmb_rules_function.EditValue = "S"
            End If
        End If

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
            With rules.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "commision_scheme_rules_create"

                .Parameters.Clear()
                .Parameters.Add("@rule_name", SqlDbType.VarChar, 100).Value = txt_rules_name.EditValue
                .Parameters.Add("@segment_code", SqlDbType.TinyInt).Value = cmb_rules_segment.EditValue
                .Parameters.Add("@operator_code", SqlDbType.TinyInt).Value = cmb_rules_operator.EditValue
                .Parameters.Add("@rule_type", SqlDbType.Char, 1).Value = cmb_rules_type.EditValue
                .Parameters.Add("@code_search", SqlDbType.VarChar, 6).Value = "00000000".Substring(1, 6)
                .Parameters.Add("@payment_type", SqlDbType.TinyInt).Value = cmb_rules_payment.EditValue
                .Parameters.Add("@condition_text", SqlDbType.VarChar, 3000).Value = criteria_condition()
                .Parameters.Add("@condition_object", SqlDbType.VarChar, 3000).Value = txt_rules_criteria.FilterCriteria.ToString
                .Parameters.Add("@function_name", SqlDbType.Char, 1).Value = If(cmb_rules_function.EditValue = "U", DBNull.Value, cmb_rules_function.EditValue)
                .Parameters.Add("@compare_object", SqlDbType.VarChar, 100).Value = If(compare_object = "", DBNull.Value, compare_object)
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            'check if fields used are conditional funcion
            If compare_fields = "trc_object" And cmb_rules_function.EditValue = "U" Then
                message_text("La regla de comision no es valida con el metodo seleccionado", MessageBoxButtons.OK)
                Exit Sub

            ElseIf compare_fields = "" And cmb_rules_function.EditValue <> "U" Then
                message_text("La regla de comision no es valida con el metodo seleccionado", MessageBoxButtons.OK)
                Exit Sub

            ElseIf compare_fields = "trc_object" And cmb_rules_function.EditValue <> "U" Or compare_fields = "" And cmb_rules_function.EditValue = "U" Then
                If rules.execute_procedure = True Then
                    If chk_keep_form.Checked = True Then
                        If chk_object_conserve.Checked = False Then defaults_objects(pnl_object_container)
                        compare_object = ""
                    Else
                        start_home.removed_tabbed()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
