﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class comercial_chances_lookup
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(comercial_chances_lookup))
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.pnl_object_grid = New DevExpress.XtraEditors.PanelControl()
        Me.dgv_object_grid = New APDA.[Object].Controls.CustomGrid()
        Me.dgv_object_view = New APDA.[Object].Controls.CustomGridView()
        Me.rpt_picture_option = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.pnl_object_search = New DevExpress.XtraEditors.PanelControl()
        Me.txt_object_search = New DevExpress.XtraEditors.SearchControl()
        Me.pnl_object_options = New DevExpress.XtraEditors.PanelControl()
        Me.btn_object_update = New System.Windows.Forms.Button()
        Me.lbl_separator1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.lbl_object_count = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_total = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_separator_line1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txt_object_navigate = New DevExpress.XtraEditors.ControlNavigator()
        Me.btn_object_export = New System.Windows.Forms.Button()
        Me.btn_object_print = New System.Windows.Forms.Button()
        Me.btn_object_panel = New System.Windows.Forms.Button()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
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
        Me.SuspendLayout()
        '
        'xvp_validate
        '
        Me.xvp_validate.ValidateHiddenControls = False
        Me.xvp_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.pnl_object_grid)
        Me.pnl_object_container.Controls.Add(Me.btn_object_cancel)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_title)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_info)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 1)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_container.Size = New System.Drawing.Size(848, 448)
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
        Me.pnl_object_grid.Controls.Add(Me.dgv_object_grid)
        Me.pnl_object_grid.Controls.Add(Me.pnl_object_search)
        Me.pnl_object_grid.Controls.Add(Me.pnl_object_options)
        Me.pnl_object_grid.Location = New System.Drawing.Point(41, 99)
        Me.pnl_object_grid.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.pnl_object_grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_grid.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_grid.Name = "pnl_object_grid"
        Me.pnl_object_grid.Size = New System.Drawing.Size(764, 324)
        Me.pnl_object_grid.TabIndex = 0
        '
        'dgv_object_grid
        '
        Me.dgv_object_grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_object_grid.Location = New System.Drawing.Point(2, 37)
        Me.dgv_object_grid.LookAndFeel.SkinName = "My Office 2019 White"
        Me.dgv_object_grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.dgv_object_grid.MainView = Me.dgv_object_view
        Me.dgv_object_grid.Margin = New System.Windows.Forms.Padding(0)
        Me.dgv_object_grid.Name = "dgv_object_grid"
        Me.dgv_object_grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpt_picture_option})
        Me.dgv_object_grid.Size = New System.Drawing.Size(760, 255)
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
        Me.dgv_object_view.Appearance.OddRow.BorderColor = System.Drawing.Color.White
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
        Me.dgv_object_view.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.RowSeparator.BorderColor = System.Drawing.Color.White
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
        Me.dgv_object_view.ColumnPanelRowHeight = 40
        Me.dgv_object_view.FixedLineWidth = 1
        Me.dgv_object_view.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.dgv_object_view.GridControl = Me.dgv_object_grid
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
        Me.dgv_object_view.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded
        Me.dgv_object_view.OptionsDetail.ShowDetailTabs = False
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
        Me.dgv_object_view.OptionsView.EnableAppearanceOddRow = True
        Me.dgv_object_view.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag
        Me.dgv_object_view.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.dgv_object_view.OptionsView.ShowGroupedColumns = True
        Me.dgv_object_view.OptionsView.ShowGroupPanel = False
        Me.dgv_object_view.OptionsView.ShowGroupPanelColumnsAsSingleRow = True
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
        Me.pnl_object_search.Size = New System.Drawing.Size(760, 35)
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
        Me.txt_object_search.Size = New System.Drawing.Size(758, 33)
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
        Me.pnl_object_options.Controls.Add(Me.lbl_separator1)
        Me.pnl_object_options.Controls.Add(Me.lbl_object_count)
        Me.pnl_object_options.Controls.Add(Me.lbl_object_total)
        Me.pnl_object_options.Controls.Add(Me.lbl_separator_line1)
        Me.pnl_object_options.Controls.Add(Me.txt_object_navigate)
        Me.pnl_object_options.Controls.Add(Me.btn_object_export)
        Me.pnl_object_options.Controls.Add(Me.btn_object_print)
        Me.pnl_object_options.Controls.Add(Me.btn_object_panel)
        Me.pnl_object_options.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_object_options.Location = New System.Drawing.Point(2, 292)
        Me.pnl_object_options.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_options.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_options.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_options.Name = "pnl_object_options"
        Me.pnl_object_options.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_options.Size = New System.Drawing.Size(760, 30)
        Me.pnl_object_options.TabIndex = 0
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
        Me.btn_object_update.Location = New System.Drawing.Point(632, 1)
        Me.btn_object_update.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_update.MaximumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_update.MinimumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_update.Name = "btn_object_update"
        Me.btn_object_update.Size = New System.Drawing.Size(30, 28)
        Me.btn_object_update.TabIndex = 0
        Me.btn_object_update.TabStop = False
        Me.btn_object_update.Tag = "Actualizar"
        Me.btn_object_update.UseVisualStyleBackColor = True
        '
        'lbl_separator1
        '
        Me.lbl_separator1.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_separator1.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.lbl_separator1.LineColor = System.Drawing.Color.Silver
        Me.lbl_separator1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.lbl_separator1.Location = New System.Drawing.Point(662, 1)
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
        Me.lbl_separator_line1.LineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
        Me.btn_object_export.Location = New System.Drawing.Point(669, 1)
        Me.btn_object_export.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_object_export.MaximumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_export.MinimumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_export.Name = "btn_object_export"
        Me.btn_object_export.Size = New System.Drawing.Size(30, 28)
        Me.btn_object_export.TabIndex = 0
        Me.btn_object_export.TabStop = False
        Me.btn_object_export.Tag = "Exportar"
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
        Me.btn_object_print.Location = New System.Drawing.Point(699, 1)
        Me.btn_object_print.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_print.MaximumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_print.MinimumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_print.Name = "btn_object_print"
        Me.btn_object_print.Size = New System.Drawing.Size(30, 28)
        Me.btn_object_print.TabIndex = 0
        Me.btn_object_print.TabStop = False
        Me.btn_object_print.Tag = "Imprimir"
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
        Me.btn_object_panel.Location = New System.Drawing.Point(729, 1)
        Me.btn_object_panel.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_object_panel.MaximumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_panel.MinimumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_panel.Name = "btn_object_panel"
        Me.btn_object_panel.Size = New System.Drawing.Size(30, 28)
        Me.btn_object_panel.TabIndex = 0
        Me.btn_object_panel.TabStop = False
        Me.btn_object_panel.Tag = "Modo Flex"
        Me.btn_object_panel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_object_panel.UseVisualStyleBackColor = True
        '
        'btn_object_cancel
        '
        Me.btn_object_cancel.BackColor = System.Drawing.Color.White
        Me.btn_object_cancel.CausesValidation = False
        Me.btn_object_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_object_cancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_cancel.FlatAppearance.BorderSize = 0
        Me.btn_object_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_cancel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_object_cancel.ForeColor = System.Drawing.Color.DimGray
        Me.btn_object_cancel.Location = New System.Drawing.Point(818, 2)
        Me.btn_object_cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_cancel.Name = "btn_object_cancel"
        Me.btn_object_cancel.Size = New System.Drawing.Size(28, 31)
        Me.btn_object_cancel.TabIndex = 0
        Me.btn_object_cancel.TabStop = False
        Me.btn_object_cancel.Text = "X"
        Me.btn_object_cancel.UseVisualStyleBackColor = False
        '
        'lbl_object_title
        '
        Me.lbl_object_title.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 21.0!)
        Me.lbl_object_title.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lbl_object_title.Appearance.Options.UseFont = True
        Me.lbl_object_title.Appearance.Options.UseForeColor = True
        Me.lbl_object_title.Location = New System.Drawing.Point(40, 24)
        Me.lbl_object_title.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_title.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_title.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_title.Name = "lbl_object_title"
        Me.lbl_object_title.Size = New System.Drawing.Size(170, 38)
        Me.lbl_object_title.TabIndex = 0
        Me.lbl_object_title.Text = "Vista de resultados"
        '
        'lbl_object_info
        '
        Me.lbl_object_info.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_object_info.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_info.Appearance.Options.UseFont = True
        Me.lbl_object_info.Appearance.Options.UseForeColor = True
        Me.lbl_object_info.Location = New System.Drawing.Point(41, 60)
        Me.lbl_object_info.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_info.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_info.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_info.Name = "lbl_object_info"
        Me.lbl_object_info.Size = New System.Drawing.Size(232, 18)
        Me.lbl_object_info.TabIndex = 0
        Me.lbl_object_info.Text = "Los campos marcados con asterico (*) son requeridos..."
        '
        'comercial_chances_lookup
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.btn_object_cancel
        Me.ClientSize = New System.Drawing.Size(850, 450)
        Me.Controls.Add(Me.pnl_object_container)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IconOptions.Icon = CType(resources.GetObject("comercial_chances_lookup.IconOptions.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Office 2019 White"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "comercial_chances_lookup"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.TopMost = True
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents xvp_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_object_cancel As Button
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_info As DevExpress.XtraEditors.LabelControl
    Protected WithEvents pnl_object_grid As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgv_object_grid As APDA.Object.Controls.CustomGrid
    Friend WithEvents dgv_object_view As APDA.Object.Controls.CustomGridView
    Friend WithEvents rpt_picture_option As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Protected WithEvents pnl_object_search As DevExpress.XtraEditors.PanelControl
    Protected WithEvents txt_object_search As DevExpress.XtraEditors.SearchControl
    Protected WithEvents pnl_object_options As DevExpress.XtraEditors.PanelControl
    Protected WithEvents btn_object_update As Button
    Friend WithEvents lbl_separator1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents lbl_object_count As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_total As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_separator_line1 As DevExpress.XtraEditors.SeparatorControl
    Protected WithEvents txt_object_navigate As DevExpress.XtraEditors.ControlNavigator
    Protected WithEvents btn_object_export As Button
    Protected WithEvents btn_object_print As Button
    Protected WithEvents btn_object_panel As Button
End Class
