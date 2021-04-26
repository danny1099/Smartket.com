Imports APDA.Object.Controls
Imports DevExpress.Data.Filtering
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraEditors.Repository

Public Class comercial_chances_edited
    Private operators As Operators = Operators.Instance
    Private dealer As Dealers = Dealers.Instance
    Private parameter As Parameters = Parameters.Instance
    Private product As Products = Products.Instance
    Private category As Categorys = Categorys.Instance
    Private brand As Brands = Brands.Instance
    Private agency As Agencys = Agencys.Instance
    Private channel As Channels = Channels.Instance
    Private person As Persons = Persons.Instance
    Private sale As Sales = Sales.Instance
    Private chance As Chances = Chances.Instance
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
        object_listed()
        object_search()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_chance_segment.Datasources(parameter.settings_search_segments("row_visible=1"), "segment_name")
        cmb_chance_operator.Datasources(operators.settings_operators_search("row_visible=1"), "operator_name")
        cmb_chance_agency.Datasources(agency.settings_agencys_search("row_visible=1"), "agency_name")
    End Sub

    Private Sub object_search()
        Dim table As DataTable = chance.commercial_chances_search("c.Id=" & record_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                txt_chance_name.EditValue = .Item("chance_name").ToString
                cmb_chance_operator.EditValue = cmb_chance_operator.Properties.GetKeyValueByDisplayText(.Item("operator_name").ToString)
                cmb_chance_segment.EditValue = cmb_chance_segment.Properties.GetKeyValueByDisplayText(.Item("segment_name").ToString)
                cmb_chance_agency.SetEditValue(.Item("agency_code").ToString)
                txt_chance_criteria.FilterString = .Item("condition_object").ToString
                chk_row_visible.Checked = CBool(.Item("row_visible"))
                chk_object_global.Checked = CBool(.Item("mark_global"))

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

    Private Sub segment_change(sender As Object, e As EventArgs) Handles cmb_chance_segment.EditValueChanged
        If cmb_chance_segment.EditValue IsNot Nothing Then
            txt_chance_criteria.FilterCriteria = Nothing
            txt_chance_criteria.FilterColumns.Clear()

            'load conditions per segment code
            criteria_condition(cmb_chance_segment.EditValue)
        End If
    End Sub

    Private Sub criteria_condition(segment_code As Integer)
        txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Fecha de venta", "s.date_sale", GetType(Date), New RepositoryDate, FilterColumnClauseClass.DateTime))
        txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Año de venta", "year(s.date_sale)", GetType(Integer), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Consultor", "s.person_code", GetType(Integer), New RepositoryChecked(person.settings_persons_listed("p.row_visible=1"), "Nombre del funcionario"), FilterColumnClauseClass.Lookup))
        txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Agencia", "s.agency_code", GetType(Integer), New RepositoryChecked(agency.settings_agencys_search("row_visible=1"), "agency_name"), FilterColumnClauseClass.Lookup))
        txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Canal", "s.channel_code", GetType(Integer), New RepositoryChecked(channel.settings_channels_search("row_visible=1"), "channel_name"), FilterColumnClauseClass.Lookup))
        txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Distribuidor", "s.dealer_code", GetType(Integer), New RepositoryChecked(dealer.settings_dealers_search("row_visible=1"), "dealer_name"), FilterColumnClauseClass.Lookup))
        txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Cuotas", "s.quotas_code", GetType(Integer), New RepositoryChecked(parameter.settings_search_quotas("row_visible=1"), "quotas_name"), FilterColumnClauseClass.Lookup))
        txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Segmento", "s.segment_code", GetType(Integer), New RepositoryChecked(parameter.settings_search_segments("row_visible=1"), "segment_name"), FilterColumnClauseClass.Lookup))
        txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Total Ventas", "dbo.fn_relationship_customer_wholesales(s.customer_code)", GetType(Integer), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Puntaje", "c.credit_score", GetType(Integer), New RepositoryItemTextEdit, FilterColumnClauseClass.String))

        'fields exclusive of segment movil
        If segment_code = 1 Then
            txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Nombre del plan", "p.Id", GetType(Integer), New RepositoryChecked(product.services_products_listed("s.row_visible=1 and s.product_type=1 and s.segment_code=1"), "Nombre del producto"), FilterColumnClauseClass.Lookup))
            txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Categoria", "p.category_code", GetType(Integer), New RepositoryChecked(category.services_categorys_search("row_visible=1 and c.segment_code=1"), "category_name"), FilterColumnClauseClass.Lookup))
            txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Equipo", "p.product_type=2 and p.Id", GetType(Integer), New RepositoryChecked(product.services_products_listed("s.row_visible=1 and s.product_type=2"), "Nombre del producto"), FilterColumnClauseClass.Lookup))
            txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Cargo Fijo", "s.value_sales1", GetType(Integer), New RepositoryItemTextEdit, FilterColumnClauseClass.String))

            'fields exclusive of segment hogar
        ElseIf segment_code = 2 Then
            txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Nombre del servicio", "p.Id", GetType(Integer), New RepositoryChecked(product.services_products_listed("s.row_visible=1 and s.product_type=1 and s.segment_code=2"), "Nombre del producto"), FilterColumnClauseClass.Lookup))
            txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Estrato", "s.stratum_code", GetType(Integer), New RepositoryChecked(parameter.settings_search_stratum("row_visible=1"), "stratum_name"), FilterColumnClauseClass.Lookup))
            txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Categoria", "p.category_code", GetType(Integer), New RepositoryChecked(category.services_categorys_search("row_visible=1 and c.segment_code=2"), "category_name"), FilterColumnClauseClass.Lookup))

            'fields exclusive of segment hogar
        ElseIf segment_code = 3 Then
            txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Nombre de producto", "p.Id", GetType(Integer), New RepositoryChecked(product.services_products_listed("s.row_visible=1 and s.segment_code=3"), "Nombre del producto"), FilterColumnClauseClass.Lookup))
            txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Tipo de producto", "p.product_type", GetType(Integer), New RepositoryListed(product.services_products_type("row_visible=1"), "product_type"), FilterColumnClauseClass.Lookup))
            txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Equipo", "p.product_type=2 and p.Id", GetType(Integer), New RepositoryChecked(product.services_products_listed("s.row_visible=1 and s.product_type=2"), "Nombre del producto"), FilterColumnClauseClass.Lookup))
            txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Valor de venta", "s.value_sales1", GetType(Integer), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
            txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Valor de equipo", "s.value_sales2", GetType(Integer), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
            txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Marca de equipo", "p.brand_code", GetType(Integer), New RepositoryChecked(brand.services_brands_search("row_visible=1"), "brand_name"), FilterColumnClauseClass.Lookup))
            txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Categoria", "p.category_code", GetType(Integer), New RepositoryChecked(category.services_categorys_search("row_visible=1 and c.segment_code=3"), "category_name"), FilterColumnClauseClass.Lookup))
            txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Proveedor", "p.provider_code", GetType(Integer), New RepositoryChecked(product.services_providers_search("row_visible=1"), "provider_name"), FilterColumnClauseClass.Lookup))
            txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Cuotas Pendientes", "dbo.fn_wholesales_masters_quotas(q.time_lapse,s.date_sale)", GetType(Integer), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        End If
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            sender.Properties.View.Columns("Id").Visible = False
        End If
    End Sub
#End Region

#Region "helpers"
    Private Function criteria_condition() As String
        Dim type_group As GroupOperator = TryCast(txt_chance_criteria.FilterCriteria, GroupOperator)

        If type_group IsNot Nothing Then Return type_conditions(type_group) Else Return type_conditions(txt_chance_criteria.FilterCriteria)
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
            With chance.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "relationship_customer_chance_edited"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
                .Parameters.Add("@chance_name", SqlDbType.VarChar, 100).Value = txt_chance_name.EditValue
                .Parameters.Add("@segment_code", SqlDbType.TinyInt).Value = cmb_chance_segment.EditValue
                .Parameters.Add("@operator_code", SqlDbType.TinyInt).Value = cmb_chance_operator.EditValue
                .Parameters.Add("@agency_code", SqlDbType.VarChar, 100).Value = cmb_chance_agency.EditValue
                .Parameters.Add("@condition_text", SqlDbType.VarChar, 3000).Value = criteria_condition()
                .Parameters.Add("@condition_object", SqlDbType.VarChar, 3000).Value = txt_chance_criteria.FilterCriteria.ToString
                .Parameters.Add("@mark_global", SqlDbType.Bit).Value = chk_object_global.Checked
                .Parameters.Add("@row_visible", SqlDbType.Bit).Value = chk_row_visible.Checked
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_edited(pnl_object_container, source_current)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If chance.execute_procedure = True Then
                start_home.removed_tabbed()
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
