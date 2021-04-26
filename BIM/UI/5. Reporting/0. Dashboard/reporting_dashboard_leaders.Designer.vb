<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reporting_dashboard_leader
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StoredProcQuery1 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reporting_dashboard_leader))
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SplineAreaSeriesView1 As DevExpress.XtraCharts.SplineAreaSeriesView = New DevExpress.XtraCharts.SplineAreaSeriesView()
        Dim SplineAreaSeriesView2 As DevExpress.XtraCharts.SplineAreaSeriesView = New DevExpress.XtraCharts.SplineAreaSeriesView()
        Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim XyDiagram3 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim ChartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim DoughnutSeriesLabel1 As DevExpress.XtraCharts.DoughnutSeriesLabel = New DevExpress.XtraCharts.DoughnutSeriesLabel()
        Dim DoughnutSeriesView1 As DevExpress.XtraCharts.DoughnutSeriesView = New DevExpress.XtraCharts.DoughnutSeriesView()
        Dim DoughnutSeriesView2 As DevExpress.XtraCharts.DoughnutSeriesView = New DevExpress.XtraCharts.DoughnutSeriesView()
        Dim ChartTitle4 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim XyDiagram4 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView3 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim ChartTitle5 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim XyDiagram5 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series6 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim ChartTitle6 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.bds_wholesales = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbs_connections = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.pnl_object_top = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_module_subtitle = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_module_title = New DevExpress.XtraEditors.LabelControl()
        Me.rgo_object_segment = New DevExpress.XtraEditors.RadioGroup()
        Me.txt_sales_date = New APDA.[Object].Controls.TextboxDates()
        Me.btn_object_close = New System.Windows.Forms.Button()
        Me.pnl_object_container = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.pnl_object_rowgraph3 = New DevExpress.XtraEditors.PanelControl()
        Me.pnl_object_grid = New DevExpress.XtraEditors.PanelControl()
        Me.dgv_object_grid = New APDA.[Object].Controls.CustomGrid()
        Me.dgv_object_view = New APDA.[Object].Controls.CustomGridView()
        Me.Id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.segment_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.number_serial1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.date_sale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dealer_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.operator_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.product_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.product_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.brand_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.customer_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.person_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.agency_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.channel_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.total_sales = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.quotas_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.category_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.source_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.knowledge_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.services_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpt_picture_option = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.pnl_object_search = New DevExpress.XtraEditors.PanelControl()
        Me.txt_object_search = New DevExpress.XtraEditors.SearchControl()
        Me.pnl_object_options = New DevExpress.XtraEditors.PanelControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_separator1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.lbl_object_count = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_total = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_separator_line1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txt_object_navigate = New DevExpress.XtraEditors.ControlNavigator()
        Me.btn_object_export = New System.Windows.Forms.Button()
        Me.btn_object_print = New System.Windows.Forms.Button()
        Me.btn_object_panel = New System.Windows.Forms.Button()
        Me.lbl_object_separator3 = New DevExpress.XtraEditors.LabelControl()
        Me.pnl_object_budgets = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_object_wholesales = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_bugetname = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_budget = New DevExpress.XtraEditors.LabelControl()
        Me.cgt_object_gauge = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.cgt_object_circular = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
        Me.cgt_object_image = New DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent()
        Me.lbl_object_gauge = New DevExpress.XtraGauges.Win.Base.LabelComponent()
        Me.ArcScaleRangeBarComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
        Me.cgt_object_component = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.lbl_object_salesname = New DevExpress.XtraEditors.LabelControl()
        Me.pnl_object_rowgraph2 = New DevExpress.XtraEditors.PanelControl()
        Me.cgt_object_sellers = New DevExpress.XtraCharts.ChartControl()
        Me.lbl_object_separator2 = New DevExpress.XtraEditors.LabelControl()
        Me.cgt_object_brand = New DevExpress.XtraCharts.ChartControl()
        Me.lbl_object_separator1 = New DevExpress.XtraEditors.LabelControl()
        Me.cgt_object_dealer = New DevExpress.XtraCharts.ChartControl()
        Me.pnl_object_rowgraph1 = New DevExpress.XtraEditors.PanelControl()
        Me.cgt_object_channel = New DevExpress.XtraCharts.ChartControl()
        Me.cgt_object_types = New DevExpress.XtraCharts.ChartControl()
        Me.lbl_object_separator4 = New DevExpress.XtraEditors.LabelControl()
        Me.cgt_object_dates = New DevExpress.XtraCharts.ChartControl()
        Me.cgt_object_scales = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.ImageIndicatorComponent1 = New DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent()
        Me.LabelComponent1 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
        Me.cgt_object_percent = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
        Me.ArcScaleRangeBarComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
        CType(Me.bds_wholesales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_top.SuspendLayout()
        CType(Me.rgo_object_segment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sales_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sales_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        CType(Me.pnl_object_rowgraph3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_rowgraph3.SuspendLayout()
        CType(Me.pnl_object_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_grid.SuspendLayout()
        CType(Me.dgv_object_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_object_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpt_picture_option, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_search.SuspendLayout()
        CType(Me.txt_object_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_options, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_options.SuspendLayout()
        CType(Me.lbl_separator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_separator_line1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_budgets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_budgets.SuspendLayout()
        CType(Me.cgt_object_circular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cgt_object_image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_object_gauge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleRangeBarComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cgt_object_component, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_rowgraph2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_rowgraph2.SuspendLayout()
        CType(Me.cgt_object_sellers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cgt_object_brand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SplineAreaSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SplineAreaSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cgt_object_dealer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_rowgraph1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_rowgraph1.SuspendLayout()
        CType(Me.cgt_object_channel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DoughnutSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DoughnutSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DoughnutSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cgt_object_types, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cgt_object_dates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cgt_object_scales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageIndicatorComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cgt_object_percent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bds_wholesales
        '
        Me.bds_wholesales.DataMember = "reporting_search_wholesales_dashboard"
        Me.bds_wholesales.DataSource = Me.dbs_connections
        '
        'dbs_connections
        '
        Me.dbs_connections.ConnectionName = "localhost_BIMv4_Connection1"
        Me.dbs_connections.Name = "dbs_connections"
        StoredProcQuery1.Name = "reporting_search_wholesales_dashboard"
        QueryParameter1.Name = "@criteria_search"
        QueryParameter1.Type = GetType(String)
        QueryParameter1.ValueInfo = "s.agency_code<>0"
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.StoredProcName = "reporting_search_wholesales_dashboard"
        CustomSqlQuery1.Name = "reporting_search_wholesales_dashboard2"
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        Me.dbs_connections.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1, CustomSqlQuery1})
        Me.dbs_connections.ResultSchemaSerializable = resources.GetString("dbs_connections.ResultSchemaSerializable")
        '
        'pnl_object_top
        '
        Me.pnl_object_top.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_top.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_top.Appearance.BorderColor = System.Drawing.Color.White
        Me.pnl_object_top.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.pnl_object_top.Appearance.Options.UseBackColor = True
        Me.pnl_object_top.Appearance.Options.UseBorderColor = True
        Me.pnl_object_top.Appearance.Options.UseForeColor = True
        Me.pnl_object_top.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_top.Controls.Add(Me.lbl_module_subtitle)
        Me.pnl_object_top.Controls.Add(Me.lbl_module_title)
        Me.pnl_object_top.Controls.Add(Me.rgo_object_segment)
        Me.pnl_object_top.Controls.Add(Me.txt_sales_date)
        Me.pnl_object_top.Controls.Add(Me.btn_object_close)
        Me.pnl_object_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_object_top.Location = New System.Drawing.Point(1, 1)
        Me.pnl_object_top.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_top.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_top.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_top.Name = "pnl_object_top"
        Me.pnl_object_top.Padding = New System.Windows.Forms.Padding(30, 1, 1, 1)
        Me.pnl_object_top.Size = New System.Drawing.Size(1348, 95)
        Me.pnl_object_top.TabIndex = 0
        '
        'lbl_module_subtitle
        '
        Me.lbl_module_subtitle.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_module_subtitle.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_module_subtitle.Appearance.Options.UseFont = True
        Me.lbl_module_subtitle.Appearance.Options.UseForeColor = True
        Me.lbl_module_subtitle.Appearance.Options.UseTextOptions = True
        Me.lbl_module_subtitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_module_subtitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_module_subtitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_module_subtitle.Location = New System.Drawing.Point(30, 50)
        Me.lbl_module_subtitle.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_module_subtitle.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_module_subtitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_module_subtitle.Name = "lbl_module_subtitle"
        Me.lbl_module_subtitle.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.lbl_module_subtitle.Size = New System.Drawing.Size(982, 40)
        Me.lbl_module_subtitle.TabIndex = 0
        Me.lbl_module_subtitle.Text = "Los resultados del modulo están condicionadas a los permisos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "asignados al usuar" &
    "io*"
        '
        'lbl_module_title
        '
        Me.lbl_module_title.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_module_title.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lbl_module_title.Appearance.Options.UseFont = True
        Me.lbl_module_title.Appearance.Options.UseForeColor = True
        Me.lbl_module_title.Appearance.Options.UseTextOptions = True
        Me.lbl_module_title.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_module_title.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.lbl_module_title.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_module_title.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lbl_module_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_module_title.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.lbl_module_title.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_module_title.Location = New System.Drawing.Point(30, 1)
        Me.lbl_module_title.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_module_title.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_module_title.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_module_title.Name = "lbl_module_title"
        Me.lbl_module_title.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.lbl_module_title.Size = New System.Drawing.Size(982, 49)
        Me.lbl_module_title.TabIndex = 0
        Me.lbl_module_title.Text = "Dashboard"
        '
        'rgo_object_segment
        '
        Me.rgo_object_segment.Dock = System.Windows.Forms.DockStyle.Right
        Me.rgo_object_segment.EditValue = 3
        Me.rgo_object_segment.Location = New System.Drawing.Point(1012, 1)
        Me.rgo_object_segment.Margin = New System.Windows.Forms.Padding(0)
        Me.rgo_object_segment.MaximumSize = New System.Drawing.Size(170, 30)
        Me.rgo_object_segment.MinimumSize = New System.Drawing.Size(170, 30)
        Me.rgo_object_segment.Name = "rgo_object_segment"
        Me.rgo_object_segment.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.rgo_object_segment.Properties.Appearance.Options.UseForeColor = True
        Me.rgo_object_segment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rgo_object_segment.Properties.ColumnIndent = 1
        Me.rgo_object_segment.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Movil", True, 1), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Hogar", True, 2), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Libres", True, 3)})
        Me.rgo_object_segment.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.rgo_object_segment.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.rgo_object_segment.Size = New System.Drawing.Size(170, 30)
        Me.rgo_object_segment.TabIndex = 0
        '
        'txt_sales_date
        '
        Me.txt_sales_date.Dock = System.Windows.Forms.DockStyle.Right
        Me.txt_sales_date.EditValue = Nothing
        Me.txt_sales_date.Location = New System.Drawing.Point(1182, 1)
        Me.txt_sales_date.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_sales_date.MaximumSize = New System.Drawing.Size(200, 30)
        Me.txt_sales_date.Name = "txt_sales_date"
        Me.txt_sales_date.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_sales_date.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_sales_date.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_sales_date.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_sales_date.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sales_date.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_sales_date.Properties.Appearance.Options.UseForeColor = True
        Me.txt_sales_date.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_sales_date.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_sales_date.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_sales_date.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_sales_date.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_sales_date.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_sales_date.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_sales_date.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_sales_date.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.txt_sales_date.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.txt_sales_date.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.txt_sales_date.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_sales_date.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_sales_date.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_sales_date.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sales_date.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sales_date.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_sales_date.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sales_date.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_sales_date.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_sales_date.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_sales_date.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_sales_date.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_sales_date.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_sales_date.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_sales_date.Properties.AutoHeight = False
        Me.txt_sales_date.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txt_sales_date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_sales_date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sales_date.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic
        Me.txt_sales_date.Properties.DisplayFormat.FormatString = "y"
        Me.txt_sales_date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_sales_date.Properties.EditFormat.FormatString = "y"
        Me.txt_sales_date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_sales_date.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_sales_date.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_sales_date.Properties.Mask.EditMask = "y"
        Me.txt_sales_date.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView
        Me.txt_sales_date.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.txt_sales_date.Size = New System.Drawing.Size(135, 30)
        Me.txt_sales_date.TabIndex = 0
        Me.txt_sales_date.Tag = "Fecha de venta"
        '
        'btn_object_close
        '
        Me.btn_object_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_object_close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_object_close.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_close.FlatAppearance.BorderSize = 0
        Me.btn_object_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_close.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_object_close.ForeColor = System.Drawing.Color.DimGray
        Me.btn_object_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_object_close.Location = New System.Drawing.Point(1317, 1)
        Me.btn_object_close.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_close.MaximumSize = New System.Drawing.Size(30, 30)
        Me.btn_object_close.MinimumSize = New System.Drawing.Size(30, 30)
        Me.btn_object_close.Name = "btn_object_close"
        Me.btn_object_close.Size = New System.Drawing.Size(30, 30)
        Me.btn_object_close.TabIndex = 0
        Me.btn_object_close.TabStop = False
        Me.btn_object_close.Text = "X"
        Me.btn_object_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_object_close.UseVisualStyleBackColor = True
        '
        'pnl_object_container
        '
        Me.pnl_object_container.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_container.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_container.Appearance.BorderColor = System.Drawing.Color.White
        Me.pnl_object_container.Appearance.Options.UseBackColor = True
        Me.pnl_object_container.Appearance.Options.UseBorderColor = True
        Me.pnl_object_container.Controls.Add(Me.pnl_object_rowgraph3)
        Me.pnl_object_container.Controls.Add(Me.pnl_object_rowgraph2)
        Me.pnl_object_container.Controls.Add(Me.pnl_object_rowgraph1)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 96)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Size = New System.Drawing.Size(1348, 953)
        Me.pnl_object_container.TabIndex = 0
        '
        'pnl_object_rowgraph3
        '
        Me.pnl_object_rowgraph3.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_rowgraph3.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_rowgraph3.Appearance.BorderColor = System.Drawing.Color.White
        Me.pnl_object_rowgraph3.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.pnl_object_rowgraph3.Appearance.Options.UseBackColor = True
        Me.pnl_object_rowgraph3.Appearance.Options.UseBorderColor = True
        Me.pnl_object_rowgraph3.Appearance.Options.UseForeColor = True
        Me.pnl_object_rowgraph3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_rowgraph3.Controls.Add(Me.pnl_object_grid)
        Me.pnl_object_rowgraph3.Controls.Add(Me.lbl_object_separator3)
        Me.pnl_object_rowgraph3.Controls.Add(Me.pnl_object_budgets)
        Me.pnl_object_rowgraph3.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_object_rowgraph3.Location = New System.Drawing.Point(0, 560)
        Me.pnl_object_rowgraph3.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_rowgraph3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_rowgraph3.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_rowgraph3.MaximumSize = New System.Drawing.Size(0, 520)
        Me.pnl_object_rowgraph3.MinimumSize = New System.Drawing.Size(0, 320)
        Me.pnl_object_rowgraph3.Name = "pnl_object_rowgraph3"
        Me.pnl_object_rowgraph3.Padding = New System.Windows.Forms.Padding(55, 15, 20, 10)
        Me.pnl_object_rowgraph3.Size = New System.Drawing.Size(1348, 372)
        Me.pnl_object_rowgraph3.TabIndex = 0
        '
        'pnl_object_grid
        '
        Me.pnl_object_grid.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_grid.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_grid.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnl_object_grid.Appearance.Options.UseBackColor = True
        Me.pnl_object_grid.Appearance.Options.UseBorderColor = True
        Me.pnl_object_grid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.pnl_object_grid.Controls.Add(Me.dgv_object_grid)
        Me.pnl_object_grid.Controls.Add(Me.pnl_object_search)
        Me.pnl_object_grid.Controls.Add(Me.pnl_object_options)
        Me.pnl_object_grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_grid.Location = New System.Drawing.Point(55, 15)
        Me.pnl_object_grid.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.pnl_object_grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.pnl_object_grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_grid.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_grid.MinimumSize = New System.Drawing.Size(850, 326)
        Me.pnl_object_grid.Name = "pnl_object_grid"
        Me.pnl_object_grid.Size = New System.Drawing.Size(959, 347)
        Me.pnl_object_grid.TabIndex = 0
        '
        'dgv_object_grid
        '
        Me.dgv_object_grid.DataSource = Me.bds_wholesales
        Me.dgv_object_grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_object_grid.Location = New System.Drawing.Point(2, 37)
        Me.dgv_object_grid.LookAndFeel.SkinName = "My Office 2019 White"
        Me.dgv_object_grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.dgv_object_grid.MainView = Me.dgv_object_view
        Me.dgv_object_grid.Margin = New System.Windows.Forms.Padding(0)
        Me.dgv_object_grid.Name = "dgv_object_grid"
        Me.dgv_object_grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpt_picture_option})
        Me.dgv_object_grid.Size = New System.Drawing.Size(955, 278)
        Me.dgv_object_grid.TabIndex = 0
        Me.dgv_object_grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgv_object_view})
        '
        'dgv_object_view
        '
        Me.dgv_object_view.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DimGray
        Me.dgv_object_view.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.dgv_object_view.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.Empty.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.Empty.ForeColor = System.Drawing.Color.DimGray
        Me.dgv_object_view.Appearance.Empty.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.Empty.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.Empty.Options.UseForeColor = True
        Me.dgv_object_view.Appearance.EvenRow.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.EvenRow.BackColor2 = System.Drawing.Color.White
       Me.dgv_object_view.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_object_view.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.dgv_object_view.Appearance.EvenRow.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.EvenRow.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.EvenRow.Options.UseFont = True
        Me.dgv_object_view.Appearance.EvenRow.Options.UseForeColor = True
        Me.dgv_object_view.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.DimGray
        Me.dgv_object_view.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.FilterCloseButton.Options.UseFont = True
        Me.dgv_object_view.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.dgv_object_view.Appearance.FilterPanel.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.FilterPanel.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.FilterPanel.ForeColor = System.Drawing.Color.DimGray
        Me.dgv_object_view.Appearance.FilterPanel.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.FilterPanel.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.FilterPanel.Options.UseFont = True
        Me.dgv_object_view.Appearance.FilterPanel.Options.UseForeColor = True
        Me.dgv_object_view.Appearance.FixedLine.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_object_view.Appearance.FixedLine.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.dgv_object_view.Appearance.FixedLine.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_object_view.Appearance.FixedLine.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.FixedLine.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.FocusedCell.Options.UseFont = True
        Me.dgv_object_view.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightSeaGreen
        Me.dgv_object_view.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightSeaGreen
        Me.dgv_object_view.Appearance.FocusedRow.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.dgv_object_view.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.FocusedRow.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.FocusedRow.Options.UseFont = True
        Me.dgv_object_view.Appearance.FocusedRow.Options.UseForeColor = True
        Me.dgv_object_view.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.FooterPanel.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.FooterPanel.ForeColor = System.Drawing.Color.DimGray
        Me.dgv_object_view.Appearance.FooterPanel.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.FooterPanel.Options.UseFont = True
        Me.dgv_object_view.Appearance.FooterPanel.Options.UseForeColor = True
        Me.dgv_object_view.Appearance.GroupButton.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.GroupButton.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.GroupButton.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.GroupButton.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.GroupButton.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.GroupButton.Options.UseFont = True
        Me.dgv_object_view.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.GroupFooter.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.GroupFooter.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.dgv_object_view.Appearance.GroupFooter.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.GroupFooter.Options.UseFont = True
        Me.dgv_object_view.Appearance.GroupFooter.Options.UseForeColor = True
        Me.dgv_object_view.Appearance.GroupPanel.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.GroupPanel.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.GroupPanel.ForeColor = System.Drawing.Color.DimGray
        Me.dgv_object_view.Appearance.GroupPanel.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.GroupPanel.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.GroupPanel.Options.UseFont = True
        Me.dgv_object_view.Appearance.GroupPanel.Options.UseForeColor = True
        Me.dgv_object_view.Appearance.GroupRow.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.GroupRow.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.GroupRow.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.dgv_object_view.Appearance.GroupRow.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.GroupRow.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.GroupRow.Options.UseFont = True
        Me.dgv_object_view.Appearance.GroupRow.Options.UseForeColor = True
        Me.dgv_object_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_object_view.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.dgv_object_view.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_object_view.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.DimGray
        Me.dgv_object_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.dgv_object_view.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.dgv_object_view.Appearance.HideSelectionRow.Options.UseFont = True
      Me.dgv_object_view.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
       Me.dgv_object_view.Appearance.HorzLine.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
       Me.dgv_object_view.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_object_view.Appearance.HorzLine.ForeColor = System.Drawing.Color.DimGray
        Me.dgv_object_view.Appearance.HorzLine.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.HorzLine.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.HorzLine.Options.UseFont = True
        Me.dgv_object_view.Appearance.HorzLine.Options.UseForeColor = True
        Me.dgv_object_view.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.OddRow.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.dgv_object_view.Appearance.OddRow.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.OddRow.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.OddRow.Options.UseFont = True
        Me.dgv_object_view.Appearance.OddRow.Options.UseForeColor = True
        Me.dgv_object_view.Appearance.Preview.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.Preview.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.Preview.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.Preview.ForeColor = System.Drawing.Color.Black
        Me.dgv_object_view.Appearance.Preview.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.Preview.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.Preview.Options.UseFont = True
        Me.dgv_object_view.Appearance.Preview.Options.UseForeColor = True
        Me.dgv_object_view.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.Row.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_object_view.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.dgv_object_view.Appearance.Row.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.Row.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.Row.Options.UseFont = True
        Me.dgv_object_view.Appearance.Row.Options.UseForeColor = True
        Me.dgv_object_view.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.RowSeparator.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.RowSeparator.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.RowSeparator.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.RowSeparator.Options.UseFont = True
        Me.dgv_object_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.LightSeaGreen
        Me.dgv_object_view.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.LightSeaGreen
        Me.dgv_object_view.Appearance.SelectedRow.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.dgv_object_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.SelectedRow.Options.UseFont = True
        Me.dgv_object_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.dgv_object_view.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.TopNewRow.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.TopNewRow.ForeColor = System.Drawing.Color.DimGray
        Me.dgv_object_view.Appearance.TopNewRow.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.TopNewRow.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.TopNewRow.Options.UseFont = True
        Me.dgv_object_view.Appearance.TopNewRow.Options.UseForeColor = True
        Me.dgv_object_view.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_object_view.Appearance.VertLine.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_object_view.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_object_view.Appearance.VertLine.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.VertLine.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.VertLine.Options.UseFont = True
        Me.dgv_object_view.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.dgv_object_view.Appearance.ViewCaption.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.dgv_object_view.Appearance.ViewCaption.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.dgv_object_view.Appearance.ViewCaption.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.ViewCaption.Options.UseBorderColor = True
        Me.dgv_object_view.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.EvenRow.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.EvenRow.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.dgv_object_view.AppearancePrint.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.dgv_object_view.AppearancePrint.EvenRow.Options.UseBackColor = True
        Me.dgv_object_view.AppearancePrint.EvenRow.Options.UseBorderColor = True
        Me.dgv_object_view.AppearancePrint.EvenRow.Options.UseFont = True
        Me.dgv_object_view.AppearancePrint.EvenRow.Options.UseForeColor = True
        Me.dgv_object_view.AppearancePrint.FilterPanel.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.FilterPanel.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.FilterPanel.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.dgv_object_view.AppearancePrint.FilterPanel.Options.UseBackColor = True
        Me.dgv_object_view.AppearancePrint.FilterPanel.Options.UseBorderColor = True
        Me.dgv_object_view.AppearancePrint.FilterPanel.Options.UseFont = True
        Me.dgv_object_view.AppearancePrint.FooterPanel.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.FooterPanel.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.FooterPanel.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.FooterPanel.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.dgv_object_view.AppearancePrint.FooterPanel.Options.UseBackColor = True
        Me.dgv_object_view.AppearancePrint.FooterPanel.Options.UseBorderColor = True
        Me.dgv_object_view.AppearancePrint.FooterPanel.Options.UseFont = True
        Me.dgv_object_view.AppearancePrint.GroupFooter.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.GroupFooter.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.GroupFooter.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.GroupFooter.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.dgv_object_view.AppearancePrint.GroupFooter.Options.UseBackColor = True
        Me.dgv_object_view.AppearancePrint.GroupFooter.Options.UseBorderColor = True
        Me.dgv_object_view.AppearancePrint.GroupFooter.Options.UseFont = True
        Me.dgv_object_view.AppearancePrint.GroupRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_object_view.AppearancePrint.GroupRow.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.dgv_object_view.AppearancePrint.GroupRow.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_object_view.AppearancePrint.GroupRow.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.dgv_object_view.AppearancePrint.GroupRow.Options.UseBackColor = True
        Me.dgv_object_view.AppearancePrint.GroupRow.Options.UseBorderColor = True
        Me.dgv_object_view.AppearancePrint.GroupRow.Options.UseFont = True
        Me.dgv_object_view.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_object_view.AppearancePrint.HeaderPanel.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.dgv_object_view.AppearancePrint.HeaderPanel.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_object_view.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.dgv_object_view.AppearancePrint.HeaderPanel.Options.UseBackColor = True
        Me.dgv_object_view.AppearancePrint.HeaderPanel.Options.UseBorderColor = True
        Me.dgv_object_view.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.dgv_object_view.AppearancePrint.Lines.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_object_view.AppearancePrint.Lines.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_object_view.AppearancePrint.Lines.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_object_view.AppearancePrint.Lines.Options.UseBackColor = True
        Me.dgv_object_view.AppearancePrint.Lines.Options.UseBorderColor = True
        Me.dgv_object_view.AppearancePrint.OddRow.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.OddRow.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.OddRow.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.OddRow.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.dgv_object_view.AppearancePrint.OddRow.ForeColor = System.Drawing.Color.Black
        Me.dgv_object_view.AppearancePrint.OddRow.Options.UseBackColor = True
        Me.dgv_object_view.AppearancePrint.OddRow.Options.UseBorderColor = True
        Me.dgv_object_view.AppearancePrint.OddRow.Options.UseFont = True
        Me.dgv_object_view.AppearancePrint.OddRow.Options.UseForeColor = True
        Me.dgv_object_view.AppearancePrint.Preview.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.Preview.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.Preview.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.Preview.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.dgv_object_view.AppearancePrint.Preview.Options.UseBackColor = True
        Me.dgv_object_view.AppearancePrint.Preview.Options.UseBorderColor = True
        Me.dgv_object_view.AppearancePrint.Preview.Options.UseFont = True
        Me.dgv_object_view.AppearancePrint.Row.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.Row.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.Row.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.AppearancePrint.Row.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.dgv_object_view.AppearancePrint.Row.ForeColor = System.Drawing.Color.Black
        Me.dgv_object_view.AppearancePrint.Row.Options.UseBackColor = True
        Me.dgv_object_view.AppearancePrint.Row.Options.UseBorderColor = True
        Me.dgv_object_view.AppearancePrint.Row.Options.UseFont = True
        Me.dgv_object_view.AppearancePrint.Row.Options.UseForeColor = True
        Me.dgv_object_view.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.dgv_object_view.ColumnPanelRowHeight = 40
        Me.dgv_object_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Id, Me.segment_name, Me.number_serial1, Me.date_sale, Me.dealer_name, Me.operator_name, Me.product_name, Me.product_type, Me.brand_name, Me.customer_name, Me.person_name, Me.agency_name, Me.channel_name, Me.total_sales, Me.quotas_name, Me.category_name, Me.source_name, Me.knowledge_name, Me.services_type})
        Me.dgv_object_view.FixedLineWidth = 1
        Me.dgv_object_view.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.dgv_object_view.GridControl = Me.dgv_object_grid
        Me.dgv_object_view.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "services_type", Nothing, "({0})")})
        Me.dgv_object_view.Name = "dgv_object_view"
        Me.dgv_object_view.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.dgv_object_view.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgv_object_view.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgv_object_view.OptionsBehavior.Editable = False
        Me.dgv_object_view.OptionsBehavior.ReadOnly = True
        Me.dgv_object_view.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
        Me.dgv_object_view.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.dgv_object_view.OptionsCustomization.CustomizationFormSearchBoxVisible = True
        Me.dgv_object_view.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded
        Me.dgv_object_view.OptionsDetail.ShowDetailTabs = False
        Me.dgv_object_view.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.[True]
        Me.dgv_object_view.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.dgv_object_view.OptionsMenu.EnableFooterMenu = False
        Me.dgv_object_view.OptionsPrint.EnableAppearanceEvenRow = True
        Me.dgv_object_view.OptionsPrint.EnableAppearanceOddRow = True
        Me.dgv_object_view.OptionsPrint.PrintHorzLines = True
        Me.dgv_object_view.OptionsPrint.PrintVertLines = False
        Me.dgv_object_view.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.dgv_object_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.dgv_object_view.OptionsSelection.EnableAppearanceHideSelection = False
        Me.dgv_object_view.OptionsSelection.MultiSelect = True
        Me.dgv_object_view.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.dgv_object_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.dgv_object_view.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.dgv_object_view.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgv_object_view.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgv_object_view.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.dgv_object_view.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.dgv_object_view.OptionsView.ColumnAutoWidth = False
        Me.dgv_object_view.OptionsView.EnableAppearanceOddRow = True
        Me.dgv_object_view.OptionsView.ShowGroupedColumns = True
        Me.dgv_object_view.OptionsView.ShowGroupPanel = False
        Me.dgv_object_view.OptionsView.ShowGroupPanelColumnsAsSingleRow = True
        Me.dgv_object_view.OptionsView.ShowIndicator = False
        Me.dgv_object_view.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgv_object_view.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgv_object_view.PaintStyleName = "Skin"
        Me.dgv_object_view.RowHeight = 30
        '
        'Id
        '
        Me.Id.FieldName = "Id"
        Me.Id.Name = "Id"
        '
        'segment_name
        '
        Me.segment_name.Caption = "Segmento"
        Me.segment_name.FieldName = "segment_name"
        Me.segment_name.Name = "segment_name"
        Me.segment_name.Visible = True
        Me.segment_name.VisibleIndex = 0
        '
        'number_serial1
        '
        Me.number_serial1.Caption = "Numero de serial"
        Me.number_serial1.FieldName = "number_serial1"
        Me.number_serial1.Name = "number_serial1"
        Me.number_serial1.Visible = True
        Me.number_serial1.VisibleIndex = 1
        Me.number_serial1.Width = 102
        '
        'date_sale
        '
        Me.date_sale.Caption = "Fecha de venta"
        Me.date_sale.DisplayFormat.FormatString = "d"
        Me.date_sale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.date_sale.FieldName = "date_sale"
        Me.date_sale.Name = "date_sale"
        Me.date_sale.Visible = True
        Me.date_sale.VisibleIndex = 2
        Me.date_sale.Width = 95
        '
        'dealer_name
        '
        Me.dealer_name.Caption = "Distribuidor"
        Me.dealer_name.FieldName = "dealer_name"
        Me.dealer_name.Name = "dealer_name"
        Me.dealer_name.Visible = True
        Me.dealer_name.VisibleIndex = 3
        '
        'operator_name
        '
        Me.operator_name.Caption = "Operador"
        Me.operator_name.FieldName = "operator_name"
        Me.operator_name.Name = "operator_name"
        Me.operator_name.Visible = True
        Me.operator_name.VisibleIndex = 4
        '
        'product_name
        '
        Me.product_name.Caption = "Nombre de producto"
        Me.product_name.FieldName = "product_name"
        Me.product_name.Name = "product_name"
        Me.product_name.Visible = True
        Me.product_name.VisibleIndex = 5
        Me.product_name.Width = 118
        '
        'product_type
        '
        Me.product_type.Caption = "Tipo de producto"
        Me.product_type.FieldName = "product_type"
        Me.product_type.Name = "product_type"
        Me.product_type.Visible = True
        Me.product_type.VisibleIndex = 6
        Me.product_type.Width = 101
        '
        'brand_name
        '
        Me.brand_name.Caption = "Marca"
        Me.brand_name.FieldName = "brand_name"
        Me.brand_name.Name = "brand_name"
        Me.brand_name.Visible = True
        Me.brand_name.VisibleIndex = 7
        '
        'customer_name
        '
        Me.customer_name.Caption = "Nombre de cliente"
        Me.customer_name.FieldName = "customer_name"
        Me.customer_name.Name = "customer_name"
        Me.customer_name.Visible = True
        Me.customer_name.VisibleIndex = 8
        Me.customer_name.Width = 106
        '
        'person_name
        '
        Me.person_name.Caption = "Nombre de vendedor"
        Me.person_name.FieldName = "person_name"
        Me.person_name.Name = "person_name"
        Me.person_name.Visible = True
        Me.person_name.VisibleIndex = 9
        Me.person_name.Width = 123
        '
        'agency_name
        '
        Me.agency_name.Caption = "Agencia"
        Me.agency_name.FieldName = "agency_name"
        Me.agency_name.Name = "agency_name"
        Me.agency_name.Visible = True
        Me.agency_name.VisibleIndex = 10
        '
        'channel_name
        '
        Me.channel_name.Caption = "Canal de ventas"
        Me.channel_name.FieldName = "channel_name"
        Me.channel_name.Name = "channel_name"
        Me.channel_name.Visible = True
        Me.channel_name.VisibleIndex = 11
        Me.channel_name.Width = 98
        '
        'total_sales
        '
        Me.total_sales.Caption = "Total Venta"
        Me.total_sales.DisplayFormat.FormatString = "c0"
        Me.total_sales.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.total_sales.FieldName = "total_sales"
        Me.total_sales.Name = "total_sales"
        Me.total_sales.Visible = True
        Me.total_sales.VisibleIndex = 12
        '
        'quotas_name
        '
        Me.quotas_name.FieldName = "quotas_name"
        Me.quotas_name.Name = "quotas_name"
        '
        'category_name
        '
        Me.category_name.FieldName = "category_name"
        Me.category_name.Name = "category_name"
        '
        'source_name
        '
        Me.source_name.FieldName = "source_name"
        Me.source_name.Name = "source_name"
        '
        'knowledge_name
        '
        Me.knowledge_name.FieldName = "knowledge_name"
        Me.knowledge_name.Name = "knowledge_name"
        '
        'services_type
        '
        Me.services_type.FieldName = "services_type"
        Me.services_type.Name = "services_type"
        '
        'rpt_picture_option
        '
        Me.rpt_picture_option.LookAndFeel.SkinName = "Office 2019 White"
        Me.rpt_picture_option.LookAndFeel.UseDefaultLookAndFeel = False
        Me.rpt_picture_option.Name = "rpt_picture_option"
        Me.rpt_picture_option.ShowMenu = False
        '
        'pnl_object_search
        '
        Me.pnl_object_search.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_search.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_search.Appearance.BorderColor = System.Drawing.Color.White
        Me.pnl_object_search.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.pnl_object_search.Appearance.Options.UseBackColor = True
        Me.pnl_object_search.Appearance.Options.UseBorderColor = True
        Me.pnl_object_search.Appearance.Options.UseForeColor = True
        Me.pnl_object_search.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_search.Controls.Add(Me.txt_object_search)
        Me.pnl_object_search.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_object_search.Location = New System.Drawing.Point(2, 2)
        Me.pnl_object_search.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_search.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_search.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_search.Name = "pnl_object_search"
        Me.pnl_object_search.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_search.Size = New System.Drawing.Size(955, 35)
        Me.pnl_object_search.TabIndex = 0
        '
        'txt_object_search
        '
        Me.txt_object_search.Client = Me.dgv_object_grid
        Me.txt_object_search.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_object_search.Location = New System.Drawing.Point(1, 1)
        Me.txt_object_search.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_object_search.Name = "txt_object_search"
        Me.txt_object_search.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_object_search.Properties.Appearance.BorderColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_object_search.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.txt_object_search.Properties.Appearance.Options.UseBackColor = True
        Me.txt_object_search.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_object_search.Properties.Appearance.Options.UseFont = True
        Me.txt_object_search.Properties.Appearance.Options.UseForeColor = True
        Me.txt_object_search.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_object_search.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_object_search.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.txt_object_search.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.txt_object_search.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_object_search.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_object_search.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_object_search.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_object_search.Properties.AutoHeight = False
        Me.txt_object_search.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txt_object_search.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, True, True, True, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_object_search.Properties.Client = Me.dgv_object_grid
        Me.txt_object_search.Properties.FilterCondition = DevExpress.Data.Filtering.FilterCondition.Contains
        Me.txt_object_search.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_object_search.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_object_search.Properties.ShowClearButton = False
        Me.txt_object_search.Properties.ShowSearchButton = False
        Me.txt_object_search.Size = New System.Drawing.Size(953, 33)
        Me.txt_object_search.TabIndex = 0
        '
        'pnl_object_options
        '
        Me.pnl_object_options.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_options.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_options.Appearance.BorderColor = System.Drawing.Color.White
        Me.pnl_object_options.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_object_options.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.pnl_object_options.Appearance.Options.UseBackColor = True
        Me.pnl_object_options.Appearance.Options.UseBorderColor = True
        Me.pnl_object_options.Appearance.Options.UseFont = True
        Me.pnl_object_options.Appearance.Options.UseForeColor = True
        Me.pnl_object_options.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_options.Controls.Add(Me.Button1)
        Me.pnl_object_options.Controls.Add(Me.lbl_separator1)
        Me.pnl_object_options.Controls.Add(Me.lbl_object_count)
        Me.pnl_object_options.Controls.Add(Me.lbl_object_total)
        Me.pnl_object_options.Controls.Add(Me.lbl_separator_line1)
        Me.pnl_object_options.Controls.Add(Me.txt_object_navigate)
        Me.pnl_object_options.Controls.Add(Me.btn_object_export)
        Me.pnl_object_options.Controls.Add(Me.btn_object_print)
        Me.pnl_object_options.Controls.Add(Me.btn_object_panel)
        Me.pnl_object_options.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_object_options.Location = New System.Drawing.Point(2, 315)
        Me.pnl_object_options.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_options.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_options.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_options.Name = "pnl_object_options"
        Me.pnl_object_options.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_options.Size = New System.Drawing.Size(955, 30)
        Me.pnl_object_options.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(827, 1)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.MaximumSize = New System.Drawing.Size(30, 28)
        Me.Button1.MinimumSize = New System.Drawing.Size(30, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.TabStop = False
        Me.Button1.Tag = ""
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_separator1
        '
        Me.lbl_separator1.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_separator1.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.lbl_separator1.LineColor = System.Drawing.Color.Silver
        Me.lbl_separator1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.lbl_separator1.Location = New System.Drawing.Point(857, 1)
        Me.lbl_separator1.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_separator1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_separator1.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_separator1.Name = "lbl_separator1"
        Me.lbl_separator1.Padding = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.lbl_separator1.Size = New System.Drawing.Size(7, 28)
        Me.lbl_separator1.TabIndex = 0
        '
        'lbl_object_count
        '
        Me.lbl_object_count.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.75!)
        Me.lbl_object_count.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lbl_object_count.Appearance.Options.UseFont = True
        Me.lbl_object_count.Appearance.Options.UseForeColor = True
        Me.lbl_object_count.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.lbl_object_count.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_object_count.Location = New System.Drawing.Point(302, 1)
        Me.lbl_object_count.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.lbl_object_count.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_count.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_count.Name = "lbl_object_count"
        Me.lbl_object_count.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.lbl_object_count.Size = New System.Drawing.Size(8, 26)
        Me.lbl_object_count.TabIndex = 0
        Me.lbl_object_count.Text = "0"
        '
        'lbl_object_total
        '
        Me.lbl_object_total.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_object_total.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_total.Appearance.Options.UseFont = True
        Me.lbl_object_total.Appearance.Options.UseForeColor = True
        Me.lbl_object_total.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_object_total.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_object_total.Location = New System.Drawing.Point(196, 1)
        Me.lbl_object_total.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_total.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_total.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_total.Name = "lbl_object_total"
        Me.lbl_object_total.Size = New System.Drawing.Size(106, 28)
        Me.lbl_object_total.TabIndex = 0
        Me.lbl_object_total.Text = "Numero de registros: "
        '
        'lbl_separator_line1
        '
        Me.lbl_separator_line1.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_separator_line1.LineAlignment = DevExpress.XtraEditors.Alignment.Near
        Me.lbl_separator_line1.LineColor = System.Drawing.Color.Silver
        Me.lbl_separator_line1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.lbl_separator_line1.Location = New System.Drawing.Point(191, 1)
        Me.lbl_separator_line1.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_separator_line1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_separator_line1.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_separator_line1.Name = "lbl_separator_line1"
        Me.lbl_separator_line1.Padding = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.lbl_separator_line1.Size = New System.Drawing.Size(5, 28)
        Me.lbl_separator_line1.TabIndex = 0
        '
        'txt_object_navigate
        '
        Me.txt_object_navigate.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_object_navigate.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_object_navigate.Appearance.BorderColor = System.Drawing.Color.White
        Me.txt_object_navigate.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_object_navigate.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.txt_object_navigate.Appearance.Options.UseBackColor = True
        Me.txt_object_navigate.Appearance.Options.UseBorderColor = True
        Me.txt_object_navigate.Appearance.Options.UseFont = True
        Me.txt_object_navigate.Appearance.Options.UseForeColor = True
        Me.txt_object_navigate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txt_object_navigate.Buttons.Append.Visible = False
        Me.txt_object_navigate.Buttons.CancelEdit.Visible = False
        Me.txt_object_navigate.Buttons.Edit.Visible = False
        Me.txt_object_navigate.Buttons.EndEdit.Visible = False
        Me.txt_object_navigate.Buttons.Remove.Visible = False
        Me.txt_object_navigate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txt_object_navigate.Dock = System.Windows.Forms.DockStyle.Left
        Me.txt_object_navigate.Location = New System.Drawing.Point(1, 1)
        Me.txt_object_navigate.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_object_navigate.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_object_navigate.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_object_navigate.Name = "txt_object_navigate"
        Me.txt_object_navigate.NavigatableControl = Me.dgv_object_grid
        Me.txt_object_navigate.Padding = New System.Windows.Forms.Padding(1)
        Me.txt_object_navigate.ShowToolTips = True
        Me.txt_object_navigate.Size = New System.Drawing.Size(190, 28)
        Me.txt_object_navigate.TabIndex = 0
        '
        'btn_object_export
        '
        Me.btn_object_export.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_export.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_object_export.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_export.FlatAppearance.BorderSize = 0
        Me.btn_object_export.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_object_export.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_export.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btn_object_export.Image = CType(resources.GetObject("btn_object_export.Image"), System.Drawing.Image)
        Me.btn_object_export.Location = New System.Drawing.Point(864, 1)
        Me.btn_object_export.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_object_export.MaximumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_export.MinimumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_export.Name = "btn_object_export"
        Me.btn_object_export.Size = New System.Drawing.Size(30, 28)
        Me.btn_object_export.TabIndex = 0
        Me.btn_object_export.TabStop = False
        Me.btn_object_export.Tag = ""
        Me.btn_object_export.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_object_export.UseVisualStyleBackColor = True
        '
        'btn_object_print
        '
        Me.btn_object_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_print.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_object_print.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_print.FlatAppearance.BorderSize = 0
        Me.btn_object_print.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_object_print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_print.Image = CType(resources.GetObject("btn_object_print.Image"), System.Drawing.Image)
        Me.btn_object_print.Location = New System.Drawing.Point(894, 1)
        Me.btn_object_print.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_print.MaximumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_print.MinimumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_print.Name = "btn_object_print"
        Me.btn_object_print.Size = New System.Drawing.Size(30, 28)
        Me.btn_object_print.TabIndex = 0
        Me.btn_object_print.TabStop = False
        Me.btn_object_print.Tag = ""
        Me.btn_object_print.UseVisualStyleBackColor = True
        '
        'btn_object_panel
        '
        Me.btn_object_panel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_object_panel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_panel.FlatAppearance.BorderSize = 0
        Me.btn_object_panel.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_object_panel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_panel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_panel.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btn_object_panel.Image = CType(resources.GetObject("btn_object_panel.Image"), System.Drawing.Image)
        Me.btn_object_panel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_object_panel.Location = New System.Drawing.Point(924, 1)
        Me.btn_object_panel.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_object_panel.MaximumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_panel.MinimumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_panel.Name = "btn_object_panel"
        Me.btn_object_panel.Size = New System.Drawing.Size(30, 28)
        Me.btn_object_panel.TabIndex = 0
        Me.btn_object_panel.TabStop = False
        Me.btn_object_panel.Tag = ""
        Me.btn_object_panel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_object_panel.UseVisualStyleBackColor = True
        '
        'lbl_object_separator3
        '
        Me.lbl_object_separator3.Appearance.BackColor = System.Drawing.Color.White
        Me.lbl_object_separator3.Appearance.BackColor2 = System.Drawing.Color.White
        Me.lbl_object_separator3.Appearance.BorderColor = System.Drawing.Color.White
        Me.lbl_object_separator3.Appearance.Options.UseBackColor = True
        Me.lbl_object_separator3.Appearance.Options.UseBorderColor = True
        Me.lbl_object_separator3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_object_separator3.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_object_separator3.Location = New System.Drawing.Point(1014, 15)
        Me.lbl_object_separator3.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_separator3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_separator3.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_separator3.Name = "lbl_object_separator3"
        Me.lbl_object_separator3.Size = New System.Drawing.Size(10, 347)
        Me.lbl_object_separator3.TabIndex = 0
        '
        'pnl_object_budgets
        '
        Me.pnl_object_budgets.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_budgets.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_budgets.Appearance.BorderColor = System.Drawing.Color.White
        Me.pnl_object_budgets.Appearance.Options.UseBackColor = True
        Me.pnl_object_budgets.Appearance.Options.UseBorderColor = True
        Me.pnl_object_budgets.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_budgets.Controls.Add(Me.lbl_object_wholesales)
        Me.pnl_object_budgets.Controls.Add(Me.lbl_object_bugetname)
        Me.pnl_object_budgets.Controls.Add(Me.lbl_object_budget)
        Me.pnl_object_budgets.Controls.Add(Me.cgt_object_gauge)
        Me.pnl_object_budgets.Controls.Add(Me.lbl_object_salesname)
        Me.pnl_object_budgets.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_object_budgets.Location = New System.Drawing.Point(1024, 15)
        Me.pnl_object_budgets.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_budgets.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_budgets.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_budgets.Name = "pnl_object_budgets"
        Me.pnl_object_budgets.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_budgets.Size = New System.Drawing.Size(304, 347)
        Me.pnl_object_budgets.TabIndex = 0
        '
        'lbl_object_wholesales
        '
        Me.lbl_object_wholesales.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_object_wholesales.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_wholesales.Appearance.Options.UseFont = True
        Me.lbl_object_wholesales.Appearance.Options.UseForeColor = True
        Me.lbl_object_wholesales.Appearance.Options.UseTextOptions = True
        Me.lbl_object_wholesales.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_object_wholesales.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_object_wholesales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_object_wholesales.Location = New System.Drawing.Point(1, 286)
        Me.lbl_object_wholesales.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_wholesales.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_wholesales.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_wholesales.Name = "lbl_object_wholesales"
        Me.lbl_object_wholesales.Size = New System.Drawing.Size(302, 30)
        Me.lbl_object_wholesales.TabIndex = 0
        Me.lbl_object_wholesales.Text = "0"
        '
        'lbl_object_bugetname
        '
        Me.lbl_object_bugetname.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lbl_object_bugetname.Appearance.Options.UseForeColor = True
        Me.lbl_object_bugetname.Appearance.Options.UseTextOptions = True
        Me.lbl_object_bugetname.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_object_bugetname.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_object_bugetname.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_object_bugetname.Location = New System.Drawing.Point(1, 252)
        Me.lbl_object_bugetname.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_bugetname.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_bugetname.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_bugetname.Name = "lbl_object_bugetname"
        Me.lbl_object_bugetname.Size = New System.Drawing.Size(302, 16)
        Me.lbl_object_bugetname.TabIndex = 0
        Me.lbl_object_bugetname.Text = "Presupuesto"
        '
        'lbl_object_budget
        '
        Me.lbl_object_budget.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_object_budget.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lbl_object_budget.Appearance.Options.UseFont = True
        Me.lbl_object_budget.Appearance.Options.UseForeColor = True
        Me.lbl_object_budget.Appearance.Options.UseTextOptions = True
        Me.lbl_object_budget.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_object_budget.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_object_budget.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_object_budget.Location = New System.Drawing.Point(1, 209)
        Me.lbl_object_budget.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_budget.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_budget.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_budget.Name = "lbl_object_budget"
        Me.lbl_object_budget.Size = New System.Drawing.Size(302, 43)
        Me.lbl_object_budget.TabIndex = 0
        Me.lbl_object_budget.Text = "0"
        '
        'cgt_object_gauge
        '
        Me.cgt_object_gauge.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cgt_object_gauge.ColorScheme.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cgt_object_gauge.ColorScheme.TargetElements = CType(((DevExpress.XtraGauges.Core.Base.TargetElement.RangeBar Or DevExpress.XtraGauges.Core.Base.TargetElement.ImageIndicator) _
            Or DevExpress.XtraGauges.Core.Base.TargetElement.Label), DevExpress.XtraGauges.Core.Base.TargetElement)
        Me.cgt_object_gauge.Dock = System.Windows.Forms.DockStyle.Top
        Me.cgt_object_gauge.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.cgt_object_circular})
        Me.cgt_object_gauge.Location = New System.Drawing.Point(1, 1)
        Me.cgt_object_gauge.Margin = New System.Windows.Forms.Padding(0)
        Me.cgt_object_gauge.Name = "cgt_object_gauge"
        Me.cgt_object_gauge.Size = New System.Drawing.Size(302, 208)
        Me.cgt_object_gauge.TabIndex = 0
        '
        'cgt_object_circular
        '
        Me.cgt_object_circular.Bounds = New System.Drawing.Rectangle(6, 6, 290, 196)
        Me.cgt_object_circular.Images.AddRange(New DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent() {Me.cgt_object_image})
        Me.cgt_object_circular.Labels.AddRange(New DevExpress.XtraGauges.Win.Base.LabelComponent() {Me.lbl_object_gauge})
        Me.cgt_object_circular.Name = "cgt_object_circular"
        Me.cgt_object_circular.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent() {Me.ArcScaleRangeBarComponent2})
        Me.cgt_object_circular.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.cgt_object_component})
        '
        'cgt_object_image
        '
        Me.cgt_object_image.Image = CType(resources.GetObject("cgt_object_image.Image"), System.Drawing.Image)
        Me.cgt_object_image.Name = "circularGauge1_ImageIndicator1"
        Me.cgt_object_image.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(123.0!, 125.0!)
        Me.cgt_object_image.ZOrder = -1001
        '
        'lbl_object_gauge
        '
        Me.lbl_object_gauge.AppearanceText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_object_gauge.Name = "circularGauge3_Label1"
        Me.lbl_object_gauge.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(205.0!, 93.0!)
        Me.lbl_object_gauge.Size = New System.Drawing.SizeF(50.0!, 40.0!)
        Me.lbl_object_gauge.Text = "0%"
        Me.lbl_object_gauge.ZOrder = -1001
        '
        'ArcScaleRangeBarComponent2
        '
        Me.ArcScaleRangeBarComponent2.ArcScale = Me.cgt_object_component
        Me.ArcScaleRangeBarComponent2.Name = "circularGauge3_RangeBar2"
        Me.ArcScaleRangeBarComponent2.RoundedCaps = True
        Me.ArcScaleRangeBarComponent2.ShowBackground = True
        Me.ArcScaleRangeBarComponent2.StartOffset = 79.0!
        Me.ArcScaleRangeBarComponent2.Value = 0!
        Me.ArcScaleRangeBarComponent2.ZOrder = -10
        '
        'cgt_object_component
        '
        Me.cgt_object_component.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.cgt_object_component.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.cgt_object_component.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.cgt_object_component.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.cgt_object_component.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.cgt_object_component.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A")
        Me.cgt_object_component.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
        Me.cgt_object_component.EndAngle = -45.0!
        Me.cgt_object_component.MajorTickCount = 0
        Me.cgt_object_component.MajorTickmark.FormatString = "{0:F0}"
        Me.cgt_object_component.MajorTickmark.ShapeOffset = -14.0!
        Me.cgt_object_component.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1
        Me.cgt_object_component.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.cgt_object_component.MaxValue = 100.0!
        Me.cgt_object_component.MinorTickCount = 0
        Me.cgt_object_component.MinorTickmark.ShapeOffset = -7.0!
        Me.cgt_object_component.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2
        Me.cgt_object_component.Name = "scale1"
        Me.cgt_object_component.StartAngle = -270.0!
        '
        'lbl_object_salesname
        '
        Me.lbl_object_salesname.Appearance.Options.UseTextOptions = True
        Me.lbl_object_salesname.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_object_salesname.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_object_salesname.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_object_salesname.Location = New System.Drawing.Point(1, 316)
        Me.lbl_object_salesname.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_salesname.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_salesname.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_salesname.Name = "lbl_object_salesname"
        Me.lbl_object_salesname.Size = New System.Drawing.Size(302, 30)
        Me.lbl_object_salesname.TabIndex = 0
        Me.lbl_object_salesname.Text = "Ventas"
        '
        'pnl_object_rowgraph2
        '
        Me.pnl_object_rowgraph2.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_rowgraph2.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_rowgraph2.Appearance.BorderColor = System.Drawing.Color.White
        Me.pnl_object_rowgraph2.Appearance.Options.UseBackColor = True
        Me.pnl_object_rowgraph2.Appearance.Options.UseBorderColor = True
        Me.pnl_object_rowgraph2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_rowgraph2.Controls.Add(Me.cgt_object_sellers)
        Me.pnl_object_rowgraph2.Controls.Add(Me.lbl_object_separator2)
        Me.pnl_object_rowgraph2.Controls.Add(Me.cgt_object_brand)
        Me.pnl_object_rowgraph2.Controls.Add(Me.lbl_object_separator1)
        Me.pnl_object_rowgraph2.Controls.Add(Me.cgt_object_dealer)
        Me.pnl_object_rowgraph2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_object_rowgraph2.Location = New System.Drawing.Point(0, 280)
        Me.pnl_object_rowgraph2.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_rowgraph2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_rowgraph2.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_rowgraph2.Name = "pnl_object_rowgraph2"
        Me.pnl_object_rowgraph2.Padding = New System.Windows.Forms.Padding(35, 5, 20, 5)
        Me.pnl_object_rowgraph2.Size = New System.Drawing.Size(1348, 280)
        Me.pnl_object_rowgraph2.TabIndex = 1
        '
        'cgt_object_sellers
        '
        Me.cgt_object_sellers.AppearanceNameSerializable = "In A Fog"
        Me.cgt_object_sellers.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.cgt_object_sellers.DataSource = Me.bds_wholesales
        XyDiagram1.AxisX.Color = System.Drawing.Color.WhiteSmoke
        XyDiagram1.AxisX.GridLines.Color = System.Drawing.Color.WhiteSmoke
        XyDiagram1.AxisX.GridLines.MinorColor = System.Drawing.Color.WhiteSmoke
        XyDiagram1.AxisX.GridLines.MinorVisible = True
        XyDiagram1.AxisX.GridLines.Visible = True
        XyDiagram1.AxisX.Label.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Color = System.Drawing.Color.WhiteSmoke
        XyDiagram1.AxisY.GridLines.Color = System.Drawing.Color.WhiteSmoke
        XyDiagram1.AxisY.GridLines.MinorColor = System.Drawing.Color.WhiteSmoke
        XyDiagram1.AxisY.GridLines.MinorVisible = True
        XyDiagram1.AxisY.Label.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.DefaultPane.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        XyDiagram1.DefaultPane.BorderVisible = False
        XyDiagram1.DefaultPane.SelectionRectangle.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        XyDiagram1.Rotated = True
        Me.cgt_object_sellers.Diagram = XyDiagram1
        Me.cgt_object_sellers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cgt_object_sellers.Legend.Name = "Default Legend"
        Me.cgt_object_sellers.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.cgt_object_sellers.Location = New System.Drawing.Point(926, 5)
        Me.cgt_object_sellers.LookAndFeel.SkinName = "Office 2019 White"
        Me.cgt_object_sellers.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cgt_object_sellers.Margin = New System.Windows.Forms.Padding(0)
        Me.cgt_object_sellers.Name = "cgt_object_sellers"
        Me.cgt_object_sellers.PaletteName = "In A Fog"
        Me.cgt_object_sellers.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.[Single]
        Series1.ArgumentDataMember = "person_name"
        Series1.DataSource = Me.bds_wholesales
        SideBySideBarSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        SideBySideBarSeriesLabel1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Empty
        SideBySideBarSeriesLabel1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[False]
        SideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        SideBySideBarSeriesLabel1.TextColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        SideBySideBarSeriesLabel1.TextPattern = "{V:n0}"
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.Name = "Serie1"
        Series1.QualitativeSummaryOptions.SummaryFunction = "SUM([total_sales])"
        Series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
        Series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
        Series1.ToolTipHintDataMember = "person_name"
        Series1.ToolTipSeriesPattern = "{S:n0}"
        Series1.TopNOptions.Count = 10
        Series1.TopNOptions.Enabled = True
        Series1.TopNOptions.ShowOthers = False
        Series1.ValueDataMembersSerializable = "total_sales"
        SideBySideBarSeriesView1.ColorEach = True
        Series1.View = SideBySideBarSeriesView1
        Me.cgt_object_sellers.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.cgt_object_sellers.SeriesTemplate.ArgumentDataMember = "channel_name"
        Me.cgt_object_sellers.SeriesTemplate.ToolTipHintDataMember = "channel_name"
        Me.cgt_object_sellers.SeriesTemplate.ValueDataMembersSerializable = "total_sales"
        Me.cgt_object_sellers.Size = New System.Drawing.Size(402, 270)
        Me.cgt_object_sellers.TabIndex = 0
        ChartTitle1.Alignment = System.Drawing.StringAlignment.Near
        ChartTitle1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle1.Indent = 4
        ChartTitle1.Text = "Ventas por consultor | T10"
        ChartTitle1.TextColor = System.Drawing.Color.Gray
        Me.cgt_object_sellers.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'lbl_object_separator2
        '
        Me.lbl_object_separator2.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_object_separator2.Appearance.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.lbl_object_separator2.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_object_separator2.Appearance.Options.UseBackColor = True
        Me.lbl_object_separator2.Appearance.Options.UseBorderColor = True
        Me.lbl_object_separator2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_object_separator2.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_object_separator2.Location = New System.Drawing.Point(921, 5)
        Me.lbl_object_separator2.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_separator2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_separator2.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_separator2.Name = "lbl_object_separator2"
        Me.lbl_object_separator2.Size = New System.Drawing.Size(5, 270)
        Me.lbl_object_separator2.TabIndex = 0
        '
        'cgt_object_brand
        '
        Me.cgt_object_brand.BorderOptions.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cgt_object_brand.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.cgt_object_brand.DataSource = Me.bds_wholesales
        XyDiagram2.AxisX.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram2.AxisX.GridLines.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram2.AxisX.GridLines.MinorColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram2.AxisX.GridLines.MinorVisible = True
        XyDiagram2.AxisX.GridLines.Visible = True
        XyDiagram2.AxisX.Label.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        XyDiagram2.AxisX.MinorCount = 1
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisX.WholeRange.EndSideMargin = 0R
        XyDiagram2.AxisX.WholeRange.StartSideMargin = 0R
        XyDiagram2.AxisY.GridLines.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram2.AxisY.GridLines.MinorColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram2.AxisY.GridLines.MinorVisible = True
        XyDiagram2.AxisY.Label.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        XyDiagram2.AxisY.Label.TextColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        XyDiagram2.AxisY.Label.TextPattern = "{V:n0}"
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram2.EnableAxisXScrolling = True
        XyDiagram2.EnableAxisXZooming = True
        XyDiagram2.EnableAxisYScrolling = True
        XyDiagram2.EnableAxisYZooming = True
        Me.cgt_object_brand.Diagram = XyDiagram2
        Me.cgt_object_brand.Dock = System.Windows.Forms.DockStyle.Left
        Me.cgt_object_brand.Legend.Name = "Default Legend"
        Me.cgt_object_brand.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.cgt_object_brand.Location = New System.Drawing.Point(453, 5)
        Me.cgt_object_brand.LookAndFeel.SkinName = "Office 2019 White"
        Me.cgt_object_brand.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cgt_object_brand.Margin = New System.Windows.Forms.Padding(0)
        Me.cgt_object_brand.Name = "cgt_object_brand"
        Me.cgt_object_brand.PaletteName = "In A Fog"
        Me.cgt_object_brand.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.[Single]
        Me.cgt_object_brand.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Argument
        Series2.ArgumentDataMember = "brand_name"
        Series2.Name = "Serie1"
        Series2.QualitativeSummaryOptions.SummaryFunction = "SUM([total_sales])"
        Series2.ToolTipHintDataMember = "brand_name"
        Series2.ToolTipPointPattern = "{S:n0}"
        Series2.ToolTipSeriesPattern = "{S:n0}"
        Series2.ValueDataMembersSerializable = "total_sales"
        SplineAreaSeriesView1.Color = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        SplineAreaSeriesView1.ColorEach = True
        SplineAreaSeriesView1.LineTensionPercent = 90
        SplineAreaSeriesView1.Transparency = CType(97, Byte)
        Series2.View = SplineAreaSeriesView1
        Me.cgt_object_brand.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
        Me.cgt_object_brand.SeriesTemplate.ArgumentDataMember = "brand_name"
        Me.cgt_object_brand.SeriesTemplate.ToolTipHintDataMember = "brand_name"
        Me.cgt_object_brand.SeriesTemplate.ToolTipSeriesPattern = "{S:n0}"
        Me.cgt_object_brand.SeriesTemplate.ValueDataMembersSerializable = "total_sales"
        SplineAreaSeriesView2.Transparency = CType(0, Byte)
        Me.cgt_object_brand.SeriesTemplate.View = SplineAreaSeriesView2
        Me.cgt_object_brand.Size = New System.Drawing.Size(468, 270)
        Me.cgt_object_brand.TabIndex = 0
        ChartTitle2.Alignment = System.Drawing.StringAlignment.Near
        ChartTitle2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle2.Text = "Dispercion de ventas por marcas"
        ChartTitle2.TextColor = System.Drawing.Color.Gray
        Me.cgt_object_brand.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'lbl_object_separator1
        '
        Me.lbl_object_separator1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_object_separator1.Appearance.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.lbl_object_separator1.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_object_separator1.Appearance.Options.UseBackColor = True
        Me.lbl_object_separator1.Appearance.Options.UseBorderColor = True
        Me.lbl_object_separator1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_object_separator1.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_object_separator1.Location = New System.Drawing.Point(448, 5)
        Me.lbl_object_separator1.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_separator1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_separator1.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_separator1.Name = "lbl_object_separator1"
        Me.lbl_object_separator1.Size = New System.Drawing.Size(5, 270)
        Me.lbl_object_separator1.TabIndex = 0
        '
        'cgt_object_dealer
        '
        Me.cgt_object_dealer.BorderOptions.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cgt_object_dealer.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.cgt_object_dealer.DataSource = Me.bds_wholesales
        XyDiagram3.AxisX.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram3.AxisX.GridLines.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram3.AxisX.GridLines.MinorColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram3.AxisX.GridLines.MinorVisible = True
        XyDiagram3.AxisX.GridLines.Visible = True
        XyDiagram3.AxisX.Label.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        XyDiagram3.AxisX.MinorCount = 1
        XyDiagram3.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram3.AxisY.GridLines.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram3.AxisY.GridLines.MinorColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram3.AxisY.GridLines.MinorVisible = True
        XyDiagram3.AxisY.Label.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        XyDiagram3.AxisY.Label.TextPattern = "{V:n0}"
        XyDiagram3.AxisY.VisibleInPanesSerializable = "-1"
        Me.cgt_object_dealer.Diagram = XyDiagram3
        Me.cgt_object_dealer.Dock = System.Windows.Forms.DockStyle.Left
        Me.cgt_object_dealer.Legend.Name = "Default Legend"
        Me.cgt_object_dealer.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.cgt_object_dealer.Location = New System.Drawing.Point(35, 5)
        Me.cgt_object_dealer.LookAndFeel.SkinName = "Office 2019 White"
        Me.cgt_object_dealer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cgt_object_dealer.Margin = New System.Windows.Forms.Padding(0)
        Me.cgt_object_dealer.Name = "cgt_object_dealer"
        Me.cgt_object_dealer.PaletteName = "In A Fog"
        Me.cgt_object_dealer.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.[Single]
        Series3.ArgumentDataMember = "dealer_name"
        SideBySideBarSeriesLabel2.TextPattern = "{V:n0}"
        Series3.Label = SideBySideBarSeriesLabel2
        Series3.Name = "Serie1"
        Series3.QualitativeSummaryOptions.SummaryFunction = "SUM([total_sales])"
        Series3.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
        Series3.ToolTipHintDataMember = "dealer_name"
        Series3.ToolTipPointPattern = "{S:n0}"
        Series3.ToolTipSeriesPattern = "{S:n0}"
        Series3.ValueDataMembersSerializable = "total_sales"
        SideBySideBarSeriesView2.Color = System.Drawing.Color.Turquoise
        SideBySideBarSeriesView2.ColorEach = True
        Series3.View = SideBySideBarSeriesView2
        Me.cgt_object_dealer.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series3}
        Me.cgt_object_dealer.Size = New System.Drawing.Size(413, 270)
        Me.cgt_object_dealer.TabIndex = 1
        ChartTitle3.Alignment = System.Drawing.StringAlignment.Near
        ChartTitle3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle3.Text = "Ventas por distribuidor"
        ChartTitle3.TextColor = System.Drawing.Color.Gray
        Me.cgt_object_dealer.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle3})
        '
        'pnl_object_rowgraph1
        '
        Me.pnl_object_rowgraph1.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_rowgraph1.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_rowgraph1.Appearance.BorderColor = System.Drawing.Color.White
        Me.pnl_object_rowgraph1.Appearance.Options.UseBackColor = True
        Me.pnl_object_rowgraph1.Appearance.Options.UseBorderColor = True
        Me.pnl_object_rowgraph1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_rowgraph1.Controls.Add(Me.cgt_object_channel)
        Me.pnl_object_rowgraph1.Controls.Add(Me.cgt_object_types)
        Me.pnl_object_rowgraph1.Controls.Add(Me.lbl_object_separator4)
        Me.pnl_object_rowgraph1.Controls.Add(Me.cgt_object_dates)
        Me.pnl_object_rowgraph1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_object_rowgraph1.Location = New System.Drawing.Point(0, 0)
        Me.pnl_object_rowgraph1.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_rowgraph1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_rowgraph1.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_rowgraph1.Name = "pnl_object_rowgraph1"
        Me.pnl_object_rowgraph1.Padding = New System.Windows.Forms.Padding(35, 5, 20, 5)
        Me.pnl_object_rowgraph1.Size = New System.Drawing.Size(1348, 280)
        Me.pnl_object_rowgraph1.TabIndex = 0
        '
        'cgt_object_channel
        '
        Me.cgt_object_channel.AppearanceNameSerializable = "In A Fog"
        Me.cgt_object_channel.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.cgt_object_channel.DataSource = Me.bds_wholesales
        Me.cgt_object_channel.Dock = System.Windows.Forms.DockStyle.Left
        Me.cgt_object_channel.Legend.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cgt_object_channel.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.cgt_object_channel.Legend.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cgt_object_channel.Legend.Name = "Default Legend"
        Me.cgt_object_channel.Legend.TextColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.cgt_object_channel.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.cgt_object_channel.Location = New System.Drawing.Point(978, 5)
        Me.cgt_object_channel.LookAndFeel.SkinName = "Office 2019 White"
        Me.cgt_object_channel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cgt_object_channel.Margin = New System.Windows.Forms.Padding(0)
        Me.cgt_object_channel.Name = "cgt_object_channel"
        Me.cgt_object_channel.PaletteName = "In A Fog"
        Me.cgt_object_channel.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.[Single]
        Series4.ArgumentDataMember = "channel_name"
        Series4.DataSource = Me.bds_wholesales
        DoughnutSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        DoughnutSeriesLabel1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Empty
        DoughnutSeriesLabel1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DoughnutSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[False]
        DoughnutSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside
        DoughnutSeriesLabel1.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DoughnutSeriesLabel1.TextPattern = "{VP:0.0%}"
        Series4.Label = DoughnutSeriesLabel1
        Series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series4.LegendName = "Default Legend"
        Series4.LegendTextPattern = "{A}"
        Series4.Name = "Serie1"
        Series4.QualitativeSummaryOptions.SummaryFunction = "SUM([total_sales])"
        Series4.ToolTipHintDataMember = "channel_name"
        Series4.ToolTipPointPattern = "{S:n0}"
        Series4.ToolTipSeriesPattern = "{S:n0}"
        Series4.ValueDataMembersSerializable = "total_sales"
        DoughnutSeriesView1.HoleRadiusPercent = 70
        Series4.View = DoughnutSeriesView1
        Me.cgt_object_channel.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series4}
        Me.cgt_object_channel.SeriesTemplate.ArgumentDataMember = "channel_name"
        Me.cgt_object_channel.SeriesTemplate.ToolTipHintDataMember = "channel_name"
        Me.cgt_object_channel.SeriesTemplate.ToolTipSeriesPattern = "{S}" & Global.Microsoft.VisualBasic.ChrW(10) & "{A}"
        Me.cgt_object_channel.SeriesTemplate.ValueDataMembersSerializable = "total_sales"
        Me.cgt_object_channel.SeriesTemplate.View = DoughnutSeriesView2
        Me.cgt_object_channel.Size = New System.Drawing.Size(339, 270)
        Me.cgt_object_channel.TabIndex = 0
        ChartTitle4.Alignment = System.Drawing.StringAlignment.Near
        ChartTitle4.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle4.Indent = 4
        ChartTitle4.Text = "Participación por canal de ventas"
        ChartTitle4.TextColor = System.Drawing.Color.Gray
        Me.cgt_object_channel.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle4})
        '
        'cgt_object_types
        '
        Me.cgt_object_types.BorderOptions.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cgt_object_types.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.cgt_object_types.DataSource = Me.bds_wholesales
        XyDiagram4.AxisX.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram4.AxisX.GridLines.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram4.AxisX.GridLines.MinorColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram4.AxisX.GridLines.MinorVisible = True
        XyDiagram4.AxisX.GridLines.Visible = True
        XyDiagram4.AxisX.Label.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        XyDiagram4.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram4.AxisY.GridLines.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram4.AxisY.GridLines.MinorColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram4.AxisY.GridLines.MinorVisible = True
        XyDiagram4.AxisY.Label.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        XyDiagram4.AxisY.Label.TextPattern = "{V:n0}"
        XyDiagram4.AxisY.VisibleInPanesSerializable = "-1"
        Me.cgt_object_types.Diagram = XyDiagram4
        Me.cgt_object_types.Dock = System.Windows.Forms.DockStyle.Left
        Me.cgt_object_types.Legend.Name = "Default Legend"
        Me.cgt_object_types.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.cgt_object_types.Location = New System.Drawing.Point(509, 5)
        Me.cgt_object_types.LookAndFeel.SkinName = "Office 2019 White"
        Me.cgt_object_types.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cgt_object_types.Margin = New System.Windows.Forms.Padding(0)
        Me.cgt_object_types.Name = "cgt_object_types"
        Me.cgt_object_types.PaletteName = "In A Fog"
        Me.cgt_object_types.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.[Single]
        Series5.ArgumentDataMember = "product_type"
        Series5.Name = "Serie1"
        Series5.QualitativeSummaryOptions.SummaryFunction = "SUM([total_sales])"
        Series5.ToolTipHintDataMember = "product_type"
        Series5.ToolTipPointPattern = "{S:n0}"
        Series5.ToolTipSeriesPattern = "{S:n0}"
        SideBySideBarSeriesView3.ColorEach = True
        Series5.View = SideBySideBarSeriesView3
        Me.cgt_object_types.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series5}
        Me.cgt_object_types.SeriesTemplate.ArgumentDataMember = "product_type"
        Me.cgt_object_types.SeriesTemplate.ToolTipHintDataMember = "product_type"
        Me.cgt_object_types.SeriesTemplate.ValueDataMembersSerializable = "total_sales"
        Me.cgt_object_types.Size = New System.Drawing.Size(469, 270)
        Me.cgt_object_types.TabIndex = 0
        ChartTitle5.Alignment = System.Drawing.StringAlignment.Near
        ChartTitle5.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle5.Text = "Ventas por tipo de producto"
        ChartTitle5.TextColor = System.Drawing.Color.Gray
        Me.cgt_object_types.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle5})
        '
        'lbl_object_separator4
        '
        Me.lbl_object_separator4.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_object_separator4.Appearance.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.lbl_object_separator4.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_object_separator4.Appearance.Options.UseBackColor = True
        Me.lbl_object_separator4.Appearance.Options.UseBorderColor = True
        Me.lbl_object_separator4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_object_separator4.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_object_separator4.Location = New System.Drawing.Point(504, 5)
        Me.lbl_object_separator4.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_separator4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_separator4.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_separator4.Name = "lbl_object_separator4"
        Me.lbl_object_separator4.Size = New System.Drawing.Size(5, 270)
        Me.lbl_object_separator4.TabIndex = 0
        '
        'cgt_object_dates
        '
        Me.cgt_object_dates.BorderOptions.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cgt_object_dates.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.cgt_object_dates.DataSource = Me.bds_wholesales
        XyDiagram5.AxisX.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram5.AxisX.GridLines.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram5.AxisX.GridLines.MinorColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram5.AxisX.GridLines.MinorVisible = True
        XyDiagram5.AxisX.GridLines.Visible = True
        XyDiagram5.AxisX.Label.Font = New System.Drawing.Font("Arial Narrow", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        XyDiagram5.AxisX.Label.TextPattern = "{A:d/MM}"
        XyDiagram5.AxisX.MinorCount = 1
        XyDiagram5.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram5.AxisY.GridLines.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram5.AxisY.GridLines.MinorColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        XyDiagram5.AxisY.GridLines.MinorVisible = True
        XyDiagram5.AxisY.Label.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        XyDiagram5.AxisY.Label.TextPattern = "{V:n0}"
        XyDiagram5.AxisY.VisibleInPanesSerializable = "-1"
        Me.cgt_object_dates.Diagram = XyDiagram5
        Me.cgt_object_dates.Dock = System.Windows.Forms.DockStyle.Left
        Me.cgt_object_dates.Legend.Name = "Default Legend"
        Me.cgt_object_dates.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.cgt_object_dates.Location = New System.Drawing.Point(35, 5)
        Me.cgt_object_dates.LookAndFeel.SkinName = "Office 2019 White"
        Me.cgt_object_dates.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cgt_object_dates.Margin = New System.Windows.Forms.Padding(0)
        Me.cgt_object_dates.Name = "cgt_object_dates"
        Me.cgt_object_dates.PaletteName = "In A Fog"
        Me.cgt_object_dates.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.[Single]
        Series6.ArgumentDataMember = "date_sale"
        Series6.DateTimeSummaryOptions.SummaryFunction = "SUM([total_sales])"
        Series6.Name = "Serie1"
        Series6.QualitativeSummaryOptions.SummaryFunction = "SUM([total_sales])"
        Series6.ToolTipHintDataMember = "date_sale"
        Series6.ToolTipPointPattern = "{S:n0}"
        Series6.ToolTipSeriesPattern = "{S:n0}"
        Series6.ValueDataMembersSerializable = "total_sales"
        LineSeriesView1.Color = System.Drawing.Color.Turquoise
        LineSeriesView1.ColorEach = True
        LineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series6.View = LineSeriesView1
        Me.cgt_object_dates.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series6}
        Me.cgt_object_dates.SeriesTemplate.ArgumentDataMember = "date_sale"
        Me.cgt_object_dates.SeriesTemplate.ToolTipHintDataMember = "date_sale"
        Me.cgt_object_dates.SeriesTemplate.ValueDataMembersSerializable = "total_sales"
        Me.cgt_object_dates.SeriesTemplate.View = LineSeriesView2
        Me.cgt_object_dates.Size = New System.Drawing.Size(469, 270)
        Me.cgt_object_dates.TabIndex = 0
        ChartTitle6.Alignment = System.Drawing.StringAlignment.Near
        ChartTitle6.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle6.Text = "Tendencia de ventas"
        ChartTitle6.TextColor = System.Drawing.Color.Gray
        Me.cgt_object_dates.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle6})
        '
        'cgt_object_scales
        '
        Me.cgt_object_scales.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.cgt_object_scales.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.cgt_object_scales.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.cgt_object_scales.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.cgt_object_scales.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.cgt_object_scales.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A")
        Me.cgt_object_scales.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
        Me.cgt_object_scales.EndAngle = -45.0!
        Me.cgt_object_scales.MajorTickCount = 0
        Me.cgt_object_scales.MajorTickmark.FormatString = "{0:F0}"
        Me.cgt_object_scales.MajorTickmark.ShapeOffset = -14.0!
        Me.cgt_object_scales.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1
        Me.cgt_object_scales.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.cgt_object_scales.MaxValue = 100.0!
        Me.cgt_object_scales.MinorTickCount = 0
        Me.cgt_object_scales.MinorTickmark.ShapeOffset = -7.0!
        Me.cgt_object_scales.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2
        Me.cgt_object_scales.Name = "scale1"
        Me.cgt_object_scales.StartAngle = -270.0!
        Me.cgt_object_scales.Value = 40.0!
        '
        'ImageIndicatorComponent1
        '
        Me.ImageIndicatorComponent1.Image = CType(resources.GetObject("ImageIndicatorComponent1.Image"), System.Drawing.Image)
        Me.ImageIndicatorComponent1.Name = "circularGauge1_ImageIndicator1"
        Me.ImageIndicatorComponent1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(123.0!, 125.0!)
        Me.ImageIndicatorComponent1.ZOrder = -1001
        '
        'LabelComponent1
        '
        Me.LabelComponent1.AppearanceText.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LabelComponent1.Name = "circularGauge3_Label1"
        Me.LabelComponent1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(205.0!, 93.0!)
        Me.LabelComponent1.Size = New System.Drawing.SizeF(50.0!, 40.0!)
        Me.LabelComponent1.Text = "95"
        Me.LabelComponent1.ZOrder = -1001
        '
        'cgt_object_percent
        '
        Me.cgt_object_percent.Bounds = New System.Drawing.Rectangle(6, 6, 385, 232)
        Me.cgt_object_percent.Images.AddRange(New DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent() {Me.ImageIndicatorComponent1})
        Me.cgt_object_percent.Labels.AddRange(New DevExpress.XtraGauges.Win.Base.LabelComponent() {Me.LabelComponent1})
        Me.cgt_object_percent.Name = "cgt_object_percent"
        Me.cgt_object_percent.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.cgt_object_scales})
        '
        'ArcScaleRangeBarComponent1
        '
        Me.ArcScaleRangeBarComponent1.ArcScale = Me.cgt_object_scales
        Me.ArcScaleRangeBarComponent1.Name = "circularGauge3_RangeBar2"
        Me.ArcScaleRangeBarComponent1.RoundedCaps = True
        Me.ArcScaleRangeBarComponent1.ShowBackground = True
        Me.ArcScaleRangeBarComponent1.StartOffset = 79.0!
        Me.ArcScaleRangeBarComponent1.ZOrder = -10
        '
        'reporting_dashboard_leader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnl_object_container)
        Me.Controls.Add(Me.pnl_object_top)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "reporting_dashboard_leader"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(1350, 1050)
        Me.Tag = "Dashboard"
        CType(Me.bds_wholesales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_top.ResumeLayout(False)
        CType(Me.rgo_object_segment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sales_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sales_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        CType(Me.pnl_object_rowgraph3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_rowgraph3.ResumeLayout(False)
        CType(Me.pnl_object_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_grid.ResumeLayout(False)
        CType(Me.dgv_object_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_object_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpt_picture_option, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_search.ResumeLayout(False)
        CType(Me.txt_object_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_options, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_options.ResumeLayout(False)
        Me.pnl_object_options.PerformLayout()
        CType(Me.lbl_separator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_separator_line1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_budgets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_budgets.ResumeLayout(False)
        CType(Me.cgt_object_circular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cgt_object_image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_object_gauge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleRangeBarComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cgt_object_component, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_rowgraph2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_rowgraph2.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cgt_object_sellers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SplineAreaSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SplineAreaSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cgt_object_brand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cgt_object_dealer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_rowgraph1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_rowgraph1.ResumeLayout(False)
        CType(DoughnutSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DoughnutSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DoughnutSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cgt_object_channel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cgt_object_types, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cgt_object_dates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cgt_object_scales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageIndicatorComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cgt_object_percent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_object_top As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_module_subtitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_module_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_close As Button
    Friend WithEvents txt_sales_date As APDA.Object.Controls.TextboxDates
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents pnl_object_rowgraph1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dbs_connections As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents cgt_object_types As DevExpress.XtraCharts.ChartControl
    Friend WithEvents bds_wholesales As BindingSource
    Friend WithEvents cgt_object_channel As DevExpress.XtraCharts.ChartControl
    Friend WithEvents cgt_object_sellers As DevExpress.XtraCharts.ChartControl
    Friend WithEvents pnl_object_rowgraph2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cgt_object_brand As DevExpress.XtraCharts.ChartControl
    Friend WithEvents cgt_object_dates As DevExpress.XtraCharts.ChartControl
    Friend WithEvents cgt_object_dealer As DevExpress.XtraCharts.ChartControl
    Friend WithEvents lbl_object_separator2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_separator1 As DevExpress.XtraEditors.LabelControl
    Protected WithEvents pnl_object_rowgraph3 As DevExpress.XtraEditors.PanelControl
    Protected WithEvents pnl_object_grid As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgv_object_grid As APDA.Object.Controls.CustomGrid
    Friend WithEvents dgv_object_view As APDA.Object.Controls.CustomGridView
    Friend WithEvents Id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents segment_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents number_serial1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents date_sale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dealer_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents operator_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents product_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents product_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents brand_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customer_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents person_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents agency_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents channel_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents total_sales As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents quotas_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents category_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents source_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents knowledge_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents services_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpt_picture_option As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Protected WithEvents pnl_object_search As DevExpress.XtraEditors.PanelControl
    Protected WithEvents txt_object_search As DevExpress.XtraEditors.SearchControl
    Protected WithEvents pnl_object_options As DevExpress.XtraEditors.PanelControl
    Protected WithEvents Button1 As Button
    Friend WithEvents lbl_separator1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents lbl_object_count As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_total As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_separator_line1 As DevExpress.XtraEditors.SeparatorControl
    Protected WithEvents txt_object_navigate As DevExpress.XtraEditors.ControlNavigator
    Protected WithEvents btn_object_export As Button
    Protected WithEvents btn_object_print As Button
    Protected WithEvents btn_object_panel As Button
    Private WithEvents cgt_object_scales As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ImageIndicatorComponent1 As DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent
    Private WithEvents LabelComponent1 As DevExpress.XtraGauges.Win.Base.LabelComponent
    Friend WithEvents cgt_object_percent As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
    Private WithEvents ArcScaleRangeBarComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
    Friend WithEvents cgt_object_gauge As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents cgt_object_circular As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
    Private WithEvents cgt_object_image As DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent
    Private WithEvents lbl_object_gauge As DevExpress.XtraGauges.Win.Base.LabelComponent
    Private WithEvents ArcScaleRangeBarComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
    Private WithEvents cgt_object_component As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Friend WithEvents lbl_object_separator3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnl_object_budgets As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_object_wholesales As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_bugetname As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_budget As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_salesname As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_separator4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgo_object_segment As DevExpress.XtraEditors.RadioGroup
End Class
