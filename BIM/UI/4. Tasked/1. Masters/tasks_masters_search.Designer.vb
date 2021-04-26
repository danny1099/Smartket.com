<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tasks_masters_search
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tasks_masters_search))
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.dgv_object_node = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dgv_object_grid = New APDA.[Object].Controls.CustomGrid()
        Me.dgv_object_view = New APDA.[Object].Controls.CustomGridView()
        Me.rpt_picture_option = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.txt_object_notes = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.txt_object_tips = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_object_update = New System.Windows.Forms.Button()
        Me.btn_object_clean = New System.Windows.Forms.Button()
        Me.btn_object_export = New System.Windows.Forms.Button()
        Me.btn_object_panel = New System.Windows.Forms.Button()
        Me.pnl_object_top = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_module_subtitle = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_module_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_close = New System.Windows.Forms.Button()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.pnl_object_grid = New DevExpress.XtraEditors.PanelControl()
        Me.pnl_object_flyout = New DevExpress.Utils.FlyoutPanel()
        Me.pnl_object_menu = New DevExpress.XtraEditors.PanelControl()
        Me.pnl_object_actions = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_object_edit = New System.Windows.Forms.Button()
        Me.btn_object_erase = New System.Windows.Forms.Button()
        Me.btn_object_transfer = New System.Windows.Forms.Button()
        Me.btn_object_notes = New System.Windows.Forms.Button()
        Me.pnl_object_search = New DevExpress.XtraEditors.PanelControl()
        Me.txt_object_search = New DevExpress.XtraEditors.SearchControl()
        Me.pnl_object_options = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_object_count = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_total = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_separator_line1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txt_object_navigate = New DevExpress.XtraEditors.ControlNavigator()
        Me.lbl_separator1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.object_button_fields = New System.Windows.Forms.Button()
        Me.lbl_object_separator1 = New DevExpress.XtraEditors.LabelControl()
        Me.pnl_object_filter = New DevExpress.XtraEditors.PanelControl()
        Me.txt_rules_criteria = New APDA.[Object].Controls.TextboxFilter()
        Me.btn_object_find = New System.Windows.Forms.Button()
        CType(Me.dgv_object_node, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_object_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_object_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpt_picture_option, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_object_notes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_top.SuspendLayout()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        CType(Me.pnl_object_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_grid.SuspendLayout()
        CType(Me.pnl_object_flyout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_flyout.SuspendLayout()
        CType(Me.pnl_object_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_menu.SuspendLayout()
        Me.pnl_object_actions.SuspendLayout()
        CType(Me.pnl_object_search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_search.SuspendLayout()
        CType(Me.txt_object_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_options, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_options.SuspendLayout()
        CType(Me.lbl_separator_line1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_separator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_filter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_filter.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_object_node
        '
        Me.dgv_object_node.Appearance.VertLine.BackColor = System.Drawing.Color.White
        Me.dgv_object_node.Appearance.VertLine.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_node.Appearance.VertLine.BorderColor = System.Drawing.Color.White
        Me.dgv_object_node.Appearance.VertLine.Options.UseBackColor = True
        Me.dgv_object_node.Appearance.VertLine.Options.UseBorderColor = True
        Me.dgv_object_node.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.dgv_object_node.ColumnPanelRowHeight = 45
        Me.dgv_object_node.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.dgv_object_node.GridControl = Me.dgv_object_grid
        Me.dgv_object_node.Name = "dgv_object_node"
        Me.dgv_object_node.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgv_object_node.PaintStyleName = "Skin"
        '
        'dgv_object_grid
        '
        Me.dgv_object_grid.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.dgv_object_node
        GridLevelNode1.RelationName = "NotesView"
        Me.dgv_object_grid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.dgv_object_grid.Location = New System.Drawing.Point(2, 37)
        Me.dgv_object_grid.LookAndFeel.SkinName = "My Office 2019 White"
        Me.dgv_object_grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.dgv_object_grid.MainView = Me.dgv_object_view
        Me.dgv_object_grid.Margin = New System.Windows.Forms.Padding(0)
        Me.dgv_object_grid.Name = "dgv_object_grid"
        Me.dgv_object_grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpt_picture_option, Me.txt_object_notes})
        Me.dgv_object_grid.Size = New System.Drawing.Size(894, 364)
        Me.dgv_object_grid.TabIndex = 2
        Me.dgv_object_grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgv_object_view, Me.dgv_object_node})
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
        Me.dgv_object_view.Appearance.EvenRow.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.dgv_object_view.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_object_view.Appearance.FocusedCell.Options.UseFont = True
        Me.dgv_object_view.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightSeaGreen
        Me.dgv_object_view.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightSeaGreen
        Me.dgv_object_view.Appearance.FocusedRow.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.dgv_object_view.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.dgv_object_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_object_view.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.DimGray
        Me.dgv_object_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.dgv_object_view.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.dgv_object_view.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.dgv_object_view.Appearance.OddRow.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_object_view.Appearance.OddRow.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.dgv_object_view.Appearance.Row.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_object_view.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.dgv_object_view.Appearance.Row.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.Row.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.Row.Options.UseFont = True
        Me.dgv_object_view.Appearance.Row.Options.UseForeColor = True
        Me.dgv_object_view.Appearance.RowSeparator.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_object_view.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.dgv_object_view.Appearance.RowSeparator.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_object_view.Appearance.RowSeparator.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.RowSeparator.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.RowSeparator.Options.UseFont = True
        Me.dgv_object_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.LightSeaGreen
        Me.dgv_object_view.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.LightSeaGreen
        Me.dgv_object_view.Appearance.SelectedRow.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.dgv_object_view.Appearance.SelectedRow.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.dgv_object_view.AppearancePrint.Row.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_object_view.AppearancePrint.Row.ForeColor = System.Drawing.Color.Black
        Me.dgv_object_view.AppearancePrint.Row.Options.UseBackColor = True
        Me.dgv_object_view.AppearancePrint.Row.Options.UseBorderColor = True
        Me.dgv_object_view.AppearancePrint.Row.Options.UseFont = True
        Me.dgv_object_view.AppearancePrint.Row.Options.UseForeColor = True
        Me.dgv_object_view.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.dgv_object_view.ColumnPanelRowHeight = 45
        Me.dgv_object_view.FixedLineWidth = 1
        Me.dgv_object_view.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.dgv_object_view.GridControl = Me.dgv_object_grid
        Me.dgv_object_view.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Id", Nothing, " | Total: {0}")})
        Me.dgv_object_view.Name = "dgv_object_view"
        Me.dgv_object_view.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.dgv_object_view.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgv_object_view.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgv_object_view.OptionsBehavior.AutoExpandAllGroups = True
        Me.dgv_object_view.OptionsBehavior.Editable = False
        Me.dgv_object_view.OptionsBehavior.ReadOnly = True
        Me.dgv_object_view.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
        Me.dgv_object_view.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.dgv_object_view.OptionsCustomization.CustomizationFormSearchBoxVisible = True
        Me.dgv_object_view.OptionsDetail.AutoZoomDetail = True
        Me.dgv_object_view.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded
        Me.dgv_object_view.OptionsDetail.ShowDetailTabs = False
        Me.dgv_object_view.OptionsMenu.EnableFooterMenu = False
        Me.dgv_object_view.OptionsPrint.EnableAppearanceEvenRow = True
        Me.dgv_object_view.OptionsPrint.EnableAppearanceOddRow = True
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
        Me.dgv_object_view.OptionsView.EnableAppearanceOddRow = True
        Me.dgv_object_view.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag
        Me.dgv_object_view.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.dgv_object_view.OptionsView.ShowGroupedColumns = True
        Me.dgv_object_view.OptionsView.ShowGroupPanel = False
        Me.dgv_object_view.OptionsView.ShowGroupPanelColumnsAsSingleRow = True
        Me.dgv_object_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.dgv_object_view.OptionsView.ShowIndicator = False
        Me.dgv_object_view.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgv_object_view.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgv_object_view.PaintStyleName = "Skin"
        Me.dgv_object_view.RowHeight = 30
        '
        'rpt_picture_option
        '
        Me.rpt_picture_option.LookAndFeel.SkinName = "Office 2019 White"
        Me.rpt_picture_option.LookAndFeel.UseDefaultLookAndFeel = False
        Me.rpt_picture_option.Name = "rpt_picture_option"
        Me.rpt_picture_option.ShowMenu = False
        '
        'txt_object_notes
        '
        Me.txt_object_notes.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txt_object_notes.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_object_notes.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_object_notes.Name = "txt_object_notes"
        '
        'btn_object_update
        '
        Me.btn_object_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_update.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_object_update.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_update.FlatAppearance.BorderSize = 0
        Me.btn_object_update.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_object_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_update.Image = CType(resources.GetObject("btn_object_update.Image"), System.Drawing.Image)
        Me.btn_object_update.Location = New System.Drawing.Point(736, 1)
        Me.btn_object_update.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_update.MinimumSize = New System.Drawing.Size(25, 25)
        Me.btn_object_update.Name = "btn_object_update"
        Me.btn_object_update.Size = New System.Drawing.Size(30, 28)
        Me.btn_object_update.TabIndex = 0
        Me.btn_object_update.TabStop = False
        Me.btn_object_update.Tag = ""
        Me.txt_object_tips.SetToolTip(Me.btn_object_update, "Actualizar")
        Me.btn_object_update.UseVisualStyleBackColor = True
        '
        'btn_object_clean
        '
        Me.btn_object_clean.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_clean.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_object_clean.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_clean.FlatAppearance.BorderSize = 0
        Me.btn_object_clean.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_object_clean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_clean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_clean.Image = CType(resources.GetObject("btn_object_clean.Image"), System.Drawing.Image)
        Me.btn_object_clean.Location = New System.Drawing.Point(766, 1)
        Me.btn_object_clean.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_clean.MinimumSize = New System.Drawing.Size(25, 25)
        Me.btn_object_clean.Name = "btn_object_clean"
        Me.btn_object_clean.Size = New System.Drawing.Size(30, 28)
        Me.btn_object_clean.TabIndex = 0
        Me.btn_object_clean.TabStop = False
        Me.btn_object_clean.Tag = ""
        Me.txt_object_tips.SetToolTip(Me.btn_object_clean, "Limpiar")
        Me.btn_object_clean.UseVisualStyleBackColor = True
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
        Me.btn_object_export.Location = New System.Drawing.Point(796, 1)
        Me.btn_object_export.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_object_export.MinimumSize = New System.Drawing.Size(25, 25)
        Me.btn_object_export.Name = "btn_object_export"
        Me.btn_object_export.Size = New System.Drawing.Size(30, 28)
        Me.btn_object_export.TabIndex = 0
        Me.btn_object_export.TabStop = False
        Me.btn_object_export.Tag = "Exportar"
        Me.btn_object_export.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txt_object_tips.SetToolTip(Me.btn_object_export, "Exportar")
        Me.btn_object_export.UseVisualStyleBackColor = True
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
        Me.btn_object_panel.Location = New System.Drawing.Point(826, 1)
        Me.btn_object_panel.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_object_panel.MinimumSize = New System.Drawing.Size(25, 25)
        Me.btn_object_panel.Name = "btn_object_panel"
        Me.btn_object_panel.Size = New System.Drawing.Size(30, 28)
        Me.btn_object_panel.TabIndex = 0
        Me.btn_object_panel.TabStop = False
        Me.btn_object_panel.Tag = "Modo Flex"
        Me.btn_object_panel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txt_object_tips.SetToolTip(Me.btn_object_panel, "Modo Flex")
        Me.btn_object_panel.UseVisualStyleBackColor = True
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
        Me.lbl_module_subtitle.Size = New System.Drawing.Size(1287, 40)
        Me.lbl_module_subtitle.TabIndex = 0
        Me.lbl_module_subtitle.Text = "Las opciones del modulo están condicionadas a los permisos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "asignados al usuario" &
    "*"
        '
        'lbl_module_title
        '
        Me.lbl_module_title.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lbl_module_title.Size = New System.Drawing.Size(1287, 49)
        Me.lbl_module_title.TabIndex = 0
        Me.lbl_module_title.Text = "Busqueda de asignaciones"
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
        Me.btn_object_close.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.pnl_object_container.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.pnl_object_container.Appearance.Options.UseBackColor = True
        Me.pnl_object_container.Appearance.Options.UseBorderColor = True
        Me.pnl_object_container.Appearance.Options.UseForeColor = True
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.pnl_object_grid)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_separator1)
        Me.pnl_object_container.Controls.Add(Me.pnl_object_filter)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 96)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Padding = New System.Windows.Forms.Padding(45, 10, 45, 10)
        Me.pnl_object_container.Size = New System.Drawing.Size(1348, 453)
        Me.pnl_object_container.TabIndex = 0
        '
        'pnl_object_grid
        '
        Me.pnl_object_grid.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_grid.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_grid.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnl_object_grid.Appearance.Options.UseBackColor = True
        Me.pnl_object_grid.Appearance.Options.UseBorderColor = True
        Me.pnl_object_grid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.pnl_object_grid.Controls.Add(Me.pnl_object_flyout)
        Me.pnl_object_grid.Controls.Add(Me.dgv_object_grid)
        Me.pnl_object_grid.Controls.Add(Me.pnl_object_search)
        Me.pnl_object_grid.Controls.Add(Me.pnl_object_options)
        Me.pnl_object_grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_grid.Location = New System.Drawing.Point(405, 10)
        Me.pnl_object_grid.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.pnl_object_grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_grid.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_grid.Name = "pnl_object_grid"
        Me.pnl_object_grid.Size = New System.Drawing.Size(898, 433)
        Me.pnl_object_grid.TabIndex = 0
        '
        'pnl_object_flyout
        '
        Me.pnl_object_flyout.AnimationRate = 70
        Me.pnl_object_flyout.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_flyout.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_flyout.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnl_object_flyout.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_object_flyout.Appearance.Options.UseBackColor = True
        Me.pnl_object_flyout.Appearance.Options.UseBorderColor = True
        Me.pnl_object_flyout.Appearance.Options.UseFont = True
        Me.pnl_object_flyout.Controls.Add(Me.pnl_object_menu)
        Me.pnl_object_flyout.Location = New System.Drawing.Point(3, 84)
        Me.pnl_object_flyout.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_flyout.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_flyout.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_flyout.Name = "pnl_object_flyout"
        Me.pnl_object_flyout.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Manual
        Me.pnl_object_flyout.Options.CloseOnOuterClick = True
        Me.pnl_object_flyout.OptionsBeakPanel.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Slide
        Me.pnl_object_flyout.OptionsBeakPanel.BackColor = System.Drawing.Color.White
        Me.pnl_object_flyout.OptionsBeakPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.pnl_object_flyout.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top
        Me.pnl_object_flyout.OwnerControl = Me.dgv_object_grid
        Me.pnl_object_flyout.Size = New System.Drawing.Size(260, 179)
        Me.pnl_object_flyout.TabIndex = 1
        '
        'pnl_object_menu
        '
        Me.pnl_object_menu.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_menu.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_menu.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnl_object_menu.Appearance.Options.UseBackColor = True
        Me.pnl_object_menu.Appearance.Options.UseBorderColor = True
        Me.pnl_object_menu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.pnl_object_menu.Controls.Add(Me.pnl_object_actions)
        Me.pnl_object_menu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_menu.Location = New System.Drawing.Point(0, 0)
        Me.pnl_object_menu.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_menu.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.pnl_object_menu.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_menu.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_menu.Name = "pnl_object_menu"
        Me.pnl_object_menu.Size = New System.Drawing.Size(260, 179)
        Me.pnl_object_menu.TabIndex = 0
        '
        'pnl_object_actions
        '
        Me.pnl_object_actions.BackColor = System.Drawing.Color.White
        Me.pnl_object_actions.Controls.Add(Me.btn_object_edit)
        Me.pnl_object_actions.Controls.Add(Me.btn_object_erase)
        Me.pnl_object_actions.Controls.Add(Me.btn_object_transfer)
        Me.pnl_object_actions.Controls.Add(Me.btn_object_notes)
        Me.pnl_object_actions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_actions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.pnl_object_actions.Location = New System.Drawing.Point(2, 2)
        Me.pnl_object_actions.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_actions.Name = "pnl_object_actions"
        Me.pnl_object_actions.Padding = New System.Windows.Forms.Padding(3)
        Me.pnl_object_actions.Size = New System.Drawing.Size(256, 175)
        Me.pnl_object_actions.TabIndex = 0
        Me.pnl_object_actions.WrapContents = False
        '
        'btn_object_edit
        '
        Me.btn_object_edit.BackColor = System.Drawing.Color.White
        Me.btn_object_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_edit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_edit.FlatAppearance.BorderSize = 0
        Me.btn_object_edit.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_object_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_edit.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_object_edit.ForeColor = System.Drawing.Color.DimGray
        Me.btn_object_edit.Image = CType(resources.GetObject("btn_object_edit.Image"), System.Drawing.Image)
        Me.btn_object_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_object_edit.Location = New System.Drawing.Point(4, 4)
        Me.btn_object_edit.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_object_edit.MaximumSize = New System.Drawing.Size(250, 40)
        Me.btn_object_edit.MinimumSize = New System.Drawing.Size(250, 0)
        Me.btn_object_edit.Name = "btn_object_edit"
        Me.btn_object_edit.Size = New System.Drawing.Size(250, 40)
        Me.btn_object_edit.TabIndex = 0
        Me.btn_object_edit.Text = "Finalizar"
        Me.btn_object_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_object_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_object_edit.UseVisualStyleBackColor = False
        '
        'btn_object_erase
        '
        Me.btn_object_erase.BackColor = System.Drawing.Color.White
        Me.btn_object_erase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_erase.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_erase.FlatAppearance.BorderSize = 0
        Me.btn_object_erase.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_object_erase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_erase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_erase.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_object_erase.ForeColor = System.Drawing.Color.DimGray
        Me.btn_object_erase.Image = CType(resources.GetObject("btn_object_erase.Image"), System.Drawing.Image)
        Me.btn_object_erase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_object_erase.Location = New System.Drawing.Point(4, 46)
        Me.btn_object_erase.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_object_erase.MaximumSize = New System.Drawing.Size(250, 40)
        Me.btn_object_erase.MinimumSize = New System.Drawing.Size(250, 0)
        Me.btn_object_erase.Name = "btn_object_erase"
        Me.btn_object_erase.Size = New System.Drawing.Size(250, 40)
        Me.btn_object_erase.TabIndex = 0
        Me.btn_object_erase.Text = "Eliminar"
        Me.btn_object_erase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_object_erase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_object_erase.UseVisualStyleBackColor = False
        '
        'btn_object_transfer
        '
        Me.btn_object_transfer.BackColor = System.Drawing.Color.White
        Me.btn_object_transfer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_transfer.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_transfer.FlatAppearance.BorderSize = 0
        Me.btn_object_transfer.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_object_transfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_transfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_transfer.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_object_transfer.ForeColor = System.Drawing.Color.DimGray
        Me.btn_object_transfer.Image = CType(resources.GetObject("btn_object_transfer.Image"), System.Drawing.Image)
        Me.btn_object_transfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_object_transfer.Location = New System.Drawing.Point(4, 88)
        Me.btn_object_transfer.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_object_transfer.MaximumSize = New System.Drawing.Size(250, 40)
        Me.btn_object_transfer.MinimumSize = New System.Drawing.Size(250, 0)
        Me.btn_object_transfer.Name = "btn_object_transfer"
        Me.btn_object_transfer.Size = New System.Drawing.Size(250, 40)
        Me.btn_object_transfer.TabIndex = 0
        Me.btn_object_transfer.Tag = ""
        Me.btn_object_transfer.Text = "Transferir"
        Me.btn_object_transfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_object_transfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_object_transfer.UseVisualStyleBackColor = False
        '
        'btn_object_notes
        '
        Me.btn_object_notes.BackColor = System.Drawing.Color.White
        Me.btn_object_notes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_notes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_notes.FlatAppearance.BorderSize = 0
        Me.btn_object_notes.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_object_notes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_notes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_notes.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_object_notes.ForeColor = System.Drawing.Color.DimGray
        Me.btn_object_notes.Image = CType(resources.GetObject("btn_object_notes.Image"), System.Drawing.Image)
        Me.btn_object_notes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_object_notes.Location = New System.Drawing.Point(4, 130)
        Me.btn_object_notes.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_object_notes.MaximumSize = New System.Drawing.Size(250, 40)
        Me.btn_object_notes.MinimumSize = New System.Drawing.Size(250, 0)
        Me.btn_object_notes.Name = "btn_object_notes"
        Me.btn_object_notes.Size = New System.Drawing.Size(250, 40)
        Me.btn_object_notes.TabIndex = 0
        Me.btn_object_notes.Text = "Ver Notas"
        Me.btn_object_notes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_object_notes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_object_notes.UseVisualStyleBackColor = False
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
        Me.pnl_object_search.Size = New System.Drawing.Size(894, 35)
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
        Me.txt_object_search.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_object_search.Properties.Client = Me.dgv_object_grid
        Me.txt_object_search.Properties.FilterCondition = DevExpress.Data.Filtering.FilterCondition.Contains
        Me.txt_object_search.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_object_search.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_object_search.Properties.ShowClearButton = False
        Me.txt_object_search.Properties.ShowSearchButton = False
        Me.txt_object_search.Size = New System.Drawing.Size(892, 33)
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
        Me.pnl_object_options.Controls.Add(Me.btn_object_update)
        Me.pnl_object_options.Controls.Add(Me.btn_object_clean)
        Me.pnl_object_options.Controls.Add(Me.lbl_object_count)
        Me.pnl_object_options.Controls.Add(Me.lbl_object_total)
        Me.pnl_object_options.Controls.Add(Me.lbl_separator_line1)
        Me.pnl_object_options.Controls.Add(Me.btn_object_export)
        Me.pnl_object_options.Controls.Add(Me.txt_object_navigate)
        Me.pnl_object_options.Controls.Add(Me.btn_object_panel)
        Me.pnl_object_options.Controls.Add(Me.lbl_separator1)
        Me.pnl_object_options.Controls.Add(Me.object_button_fields)
        Me.pnl_object_options.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_object_options.Location = New System.Drawing.Point(2, 401)
        Me.pnl_object_options.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_options.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_options.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_options.Name = "pnl_object_options"
        Me.pnl_object_options.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_options.Size = New System.Drawing.Size(894, 30)
        Me.pnl_object_options.TabIndex = 0
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
        Me.lbl_object_count.LookAndFeel.SkinName = "Office 2019 White"
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
        'lbl_separator1
        '
        Me.lbl_separator1.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_separator1.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.lbl_separator1.LineColor = System.Drawing.Color.Silver
        Me.lbl_separator1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.lbl_separator1.Location = New System.Drawing.Point(856, 1)
        Me.lbl_separator1.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_separator1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_separator1.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_separator1.Name = "lbl_separator1"
        Me.lbl_separator1.Padding = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.lbl_separator1.Size = New System.Drawing.Size(7, 28)
        Me.lbl_separator1.TabIndex = 0
        '
        'object_button_fields
        '
        Me.object_button_fields.Cursor = System.Windows.Forms.Cursors.Hand
        Me.object_button_fields.Dock = System.Windows.Forms.DockStyle.Right
        Me.object_button_fields.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.object_button_fields.FlatAppearance.BorderSize = 0
        Me.object_button_fields.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.object_button_fields.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.object_button_fields.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.object_button_fields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.object_button_fields.Image = CType(resources.GetObject("object_button_fields.Image"), System.Drawing.Image)
        Me.object_button_fields.Location = New System.Drawing.Point(863, 1)
        Me.object_button_fields.Margin = New System.Windows.Forms.Padding(0)
        Me.object_button_fields.MaximumSize = New System.Drawing.Size(30, 28)
        Me.object_button_fields.Name = "object_button_fields"
        Me.object_button_fields.Size = New System.Drawing.Size(30, 28)
        Me.object_button_fields.TabIndex = 0
        Me.object_button_fields.TabStop = False
        Me.object_button_fields.Tag = ""
        Me.object_button_fields.UseVisualStyleBackColor = True
        '
        'lbl_object_separator1
        '
        Me.lbl_object_separator1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_object_separator1.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_object_separator1.ImageOptions.Image = Global.BIM.My.Resources.Resources.options_left
        Me.lbl_object_separator1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical
        Me.lbl_object_separator1.Location = New System.Drawing.Point(395, 10)
        Me.lbl_object_separator1.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_separator1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_separator1.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_separator1.Name = "lbl_object_separator1"
        Me.lbl_object_separator1.Size = New System.Drawing.Size(10, 433)
        Me.lbl_object_separator1.TabIndex = 0
        '
        'pnl_object_filter
        '
        Me.pnl_object_filter.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_filter.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_filter.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnl_object_filter.Appearance.Options.UseBackColor = True
        Me.pnl_object_filter.Appearance.Options.UseBorderColor = True
        Me.pnl_object_filter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.pnl_object_filter.Controls.Add(Me.txt_rules_criteria)
        Me.pnl_object_filter.Controls.Add(Me.btn_object_find)
        Me.pnl_object_filter.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_object_filter.Location = New System.Drawing.Point(45, 10)
        Me.pnl_object_filter.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_filter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.pnl_object_filter.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_filter.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_filter.Name = "pnl_object_filter"
        Me.pnl_object_filter.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.pnl_object_filter.Size = New System.Drawing.Size(350, 433)
        Me.pnl_object_filter.TabIndex = 0
        '
        'txt_rules_criteria
        '
        Me.txt_rules_criteria.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_rules_criteria.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_rules_criteria.Appearance.BorderColor = System.Drawing.Color.White
        Me.txt_rules_criteria.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.txt_rules_criteria.Appearance.Options.UseBackColor = True
        Me.txt_rules_criteria.Appearance.Options.UseBorderColor = True
        Me.txt_rules_criteria.Appearance.Options.UseForeColor = True
        Me.txt_rules_criteria.AppearanceTreeLine.BackColor = System.Drawing.Color.LightSeaGreen
        Me.txt_rules_criteria.AppearanceTreeLine.BackColor2 = System.Drawing.Color.LightSeaGreen
        Me.txt_rules_criteria.AppearanceTreeLine.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.txt_rules_criteria.AppearanceTreeLine.Options.UseBackColor = True
        Me.txt_rules_criteria.AppearanceTreeLine.Options.UseBorderColor = True
        Me.txt_rules_criteria.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txt_rules_criteria.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_rules_criteria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_rules_criteria.Location = New System.Drawing.Point(2, 12)
        Me.txt_rules_criteria.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_rules_criteria.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_rules_criteria.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_rules_criteria.Name = "txt_rules_criteria"
        Me.txt_rules_criteria.Padding = New System.Windows.Forms.Padding(1)
        Me.txt_rules_criteria.ShowOperandTypeIcon = True
        Me.txt_rules_criteria.Size = New System.Drawing.Size(346, 386)
        Me.txt_rules_criteria.TabIndex = 0
        Me.txt_rules_criteria.Tag = "Condición"
        '
        'btn_object_find
        '
        Me.btn_object_find.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_find.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_object_find.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_find.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_find.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_find.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_object_find.ForeColor = System.Drawing.Color.DimGray
        Me.btn_object_find.Image = CType(resources.GetObject("btn_object_find.Image"), System.Drawing.Image)
        Me.btn_object_find.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_object_find.Location = New System.Drawing.Point(2, 398)
        Me.btn_object_find.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_find.Name = "btn_object_find"
        Me.btn_object_find.Size = New System.Drawing.Size(346, 33)
        Me.btn_object_find.TabIndex = 0
        Me.btn_object_find.TabStop = False
        Me.btn_object_find.Text = "Realizar Busqueda"
        Me.btn_object_find.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_object_find.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_object_find.UseVisualStyleBackColor = True
        '
        'tasks_masters_search
        '
        Me.AccessibleName = "Entities.Projects.Task"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnl_object_container)
        Me.Controls.Add(Me.pnl_object_top)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "tasks_masters_search"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(1350, 550)
        Me.Tag = "Busqueda de asignaciones"
        CType(Me.dgv_object_node, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_object_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_object_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpt_picture_option, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_object_notes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_top.ResumeLayout(False)
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        CType(Me.pnl_object_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_grid.ResumeLayout(False)
        CType(Me.pnl_object_flyout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_flyout.ResumeLayout(False)
        CType(Me.pnl_object_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_menu.ResumeLayout(False)
        Me.pnl_object_actions.ResumeLayout(False)
        CType(Me.pnl_object_search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_search.ResumeLayout(False)
        CType(Me.txt_object_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_options, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_options.ResumeLayout(False)
        Me.pnl_object_options.PerformLayout()
        CType(Me.lbl_separator_line1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_separator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_filter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_filter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_object_tips As ToolTip
    Friend WithEvents pnl_object_top As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_module_subtitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_module_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_close As Button
    Protected WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Protected WithEvents pnl_object_grid As DevExpress.XtraEditors.PanelControl
    Protected WithEvents pnl_object_search As DevExpress.XtraEditors.PanelControl
    Protected WithEvents txt_object_search As DevExpress.XtraEditors.SearchControl
    Protected WithEvents pnl_object_options As DevExpress.XtraEditors.PanelControl
    Protected WithEvents btn_object_update As Button
    Protected WithEvents btn_object_clean As Button
    Friend WithEvents lbl_separator1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents lbl_object_count As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_total As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_separator_line1 As DevExpress.XtraEditors.SeparatorControl
    Protected WithEvents btn_object_export As Button
    Protected WithEvents txt_object_navigate As DevExpress.XtraEditors.ControlNavigator
    Protected WithEvents btn_object_panel As Button
    Friend WithEvents lbl_object_separator1 As DevExpress.XtraEditors.LabelControl
    Protected WithEvents pnl_object_filter As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txt_rules_criteria As APDA.Object.Controls.TextboxFilter
    Protected WithEvents pnl_object_flyout As DevExpress.Utils.FlyoutPanel
    Protected WithEvents pnl_object_menu As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnl_object_actions As FlowLayoutPanel
    Protected WithEvents btn_object_edit As Button
    Protected WithEvents btn_object_erase As Button
    Protected WithEvents btn_object_notes As Button
    Protected WithEvents btn_object_transfer As Button
    Protected WithEvents object_button_fields As Button
    Protected WithEvents btn_object_find As Button
    Friend WithEvents dgv_object_grid As APDA.Object.Controls.CustomGrid
    Friend WithEvents dgv_object_node As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgv_object_view As APDA.Object.Controls.CustomGridView
    Friend WithEvents rpt_picture_option As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents txt_object_notes As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
End Class
