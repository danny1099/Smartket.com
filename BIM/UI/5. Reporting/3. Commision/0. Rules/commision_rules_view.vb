Imports APDA.Object.Controls
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraEditors.Repository

Public Class commision_rules_view
    Private operators As Operators = Operators.Instance
    Private dealer As Dealers = Dealers.Instance
    Private parameter As Parameters = Parameters.Instance
    Private product As Products = Products.Instance
    Private category As Categorys = Categorys.Instance
    Private brand As Brands = Brands.Instance
    Private agency As Agencys = Agencys.Instance
    Private person As Persons = Persons.Instance
    Private sale As Sales = Sales.Instance
    Private segment_code As Integer
    Private criteria_object As String

#Region "constructor"
    Public Sub New(criteria_selected As String, segment_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set values of parameters on variables
        criteria_object = criteria_selected
        segment_code = segment_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        criteria_condition(segment_code)
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
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

        'carga las condiciones de la regla
        txt_rules_criteria.FilterString = criteria_object
    End Sub
#End Region

#Region "methods"
    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click, btn_object_accept.Click
        Close()
    End Sub
#End Region
End Class