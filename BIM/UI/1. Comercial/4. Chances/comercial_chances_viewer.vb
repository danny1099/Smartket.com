Imports APDA.Object.Controls
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraEditors.Repository

Public Class comercial_chances_viewer
    Private operators As Operators = Operators.Instance
    Private dealer As Dealers = Dealers.Instance
    Private parameter As Parameters = Parameters.Instance
    Private product As Products = Products.Instance
    Private category As Categorys = Categorys.Instance
    Private brand As Brands = Brands.Instance
    Private agency As Agencys = Agencys.Instance
    Private person As Persons = Persons.Instance
    Private channel As Channels = Channels.Instance
    Private sale As Sales = Sales.Instance
    Private chance As Chances = Chances.Instance
    Private criteria_object As String
    Private segment_code As Integer

#Region "constructor"
    Public Sub New(criteria_selected As String, row_segment As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set values of parameters on variables
        criteria_object = criteria_selected
        segment_code = row_segment
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
        txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Fecha de venta", "s.date_sale", GetType(Date), New RepositoryDate, FilterColumnClauseClass.DateTime))
        txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Año de venta", "year(s.date_sale)", GetType(Integer), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Consultor", "s.person_code", GetType(Integer), New RepositoryChecked(person.settings_persons_listed("p.row_visible=1"), "Nombre del funcionario"), FilterColumnClauseClass.Lookup))
        txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Agencia", "s.agency_code", GetType(Integer), New RepositoryChecked(agency.settings_agencys_search("row_visible=1"), "agency_name"), FilterColumnClauseClass.Lookup))
        txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Distribuidor", "s.dealer_code", GetType(Integer), New RepositoryChecked(dealer.settings_dealers_search("row_visible=1"), "dealer_name"), FilterColumnClauseClass.Lookup))
        txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Cuotas", "s.quotas_code", GetType(Integer), New RepositoryChecked(parameter.settings_search_quotas("row_visible=1"), "quotas_name"), FilterColumnClauseClass.Lookup))
        txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Segmento", "s.segment_code", GetType(Integer), New RepositoryChecked(parameter.settings_search_segments("row_visible=1"), "segment_name"), FilterColumnClauseClass.Lookup))
        txt_chance_criteria.FilterColumns.Add(New UnboundFilterColumn("Canal", "s.channel_code", GetType(Integer), New RepositoryChecked(channel.settings_channels_search("row_visible=1"), "channel_name"), FilterColumnClauseClass.Lookup))
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

        'carga las condiciones de la regla
        txt_chance_criteria.FilterString = criteria_object
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        Close()
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class
