<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reports_wholesales_product
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reports_wholesales_product))
        Me.txt_object_tips = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_object_left = New System.Windows.Forms.Button()
        Me.btn_object_right = New System.Windows.Forms.Button()
        Me.btn_object_pdf = New System.Windows.Forms.Button()
        Me.btn_object_clean = New System.Windows.Forms.Button()
        Me.btn_object_print = New System.Windows.Forms.Button()
        Me.btn_object_update = New System.Windows.Forms.Button()
        Me.xfs_path = New DevExpress.XtraEditors.XtraSaveFileDialog(Me.components)
        Me.pnl_object_top = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_module_subtitle = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_module_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_close = New System.Windows.Forms.Button()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.pnl_object_visor = New DevExpress.XtraEditors.PanelControl()
        Me.crv_object_report = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnl_object_search = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_separator_line1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.lbl_object_separator1 = New DevExpress.XtraEditors.LabelControl()
        Me.pnl_object_filter = New DevExpress.XtraEditors.PanelControl()
        Me.txt_rules_criteria = New APDA.[Object].Controls.TextboxFilter()
        Me.btn_object_find = New System.Windows.Forms.Button()
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_top.SuspendLayout()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        CType(Me.pnl_object_visor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_visor.SuspendLayout()
        CType(Me.pnl_object_search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_search.SuspendLayout()
        CType(Me.lbl_separator_line1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_filter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_filter.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_object_tips
        '
        Me.txt_object_tips.Tag = ""
        '
        'btn_object_left
        '
        Me.btn_object_left.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_left.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_object_left.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_left.FlatAppearance.BorderSize = 0
        Me.btn_object_left.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_object_left.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_left.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_left.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btn_object_left.Image = CType(resources.GetObject("btn_object_left.Image"), System.Drawing.Image)
        Me.btn_object_left.Location = New System.Drawing.Point(671, 1)
        Me.btn_object_left.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_object_left.MinimumSize = New System.Drawing.Size(25, 25)
        Me.btn_object_left.Name = "btn_object_left"
        Me.btn_object_left.Size = New System.Drawing.Size(30, 33)
        Me.btn_object_left.TabIndex = 0
        Me.btn_object_left.TabStop = False
        Me.btn_object_left.Tag = "Exportar"
        Me.btn_object_left.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txt_object_tips.SetToolTip(Me.btn_object_left, "Anterior")
        Me.btn_object_left.UseVisualStyleBackColor = True
        '
        'btn_object_right
        '
        Me.btn_object_right.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_right.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_object_right.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_right.FlatAppearance.BorderSize = 0
        Me.btn_object_right.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_object_right.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_right.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_right.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btn_object_right.Image = CType(resources.GetObject("btn_object_right.Image"), System.Drawing.Image)
        Me.btn_object_right.Location = New System.Drawing.Point(701, 1)
        Me.btn_object_right.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_object_right.MinimumSize = New System.Drawing.Size(25, 25)
        Me.btn_object_right.Name = "btn_object_right"
        Me.btn_object_right.Size = New System.Drawing.Size(30, 33)
        Me.btn_object_right.TabIndex = 0
        Me.btn_object_right.TabStop = False
        Me.btn_object_right.Tag = "Exportar"
        Me.btn_object_right.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txt_object_tips.SetToolTip(Me.btn_object_right, "Siguiente")
        Me.btn_object_right.UseVisualStyleBackColor = True
        '
        'btn_object_pdf
        '
        Me.btn_object_pdf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_pdf.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_object_pdf.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_pdf.FlatAppearance.BorderSize = 0
        Me.btn_object_pdf.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_object_pdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_pdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_pdf.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btn_object_pdf.Image = CType(resources.GetObject("btn_object_pdf.Image"), System.Drawing.Image)
        Me.btn_object_pdf.Location = New System.Drawing.Point(741, 1)
        Me.btn_object_pdf.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_object_pdf.MinimumSize = New System.Drawing.Size(25, 25)
        Me.btn_object_pdf.Name = "btn_object_pdf"
        Me.btn_object_pdf.Size = New System.Drawing.Size(30, 33)
        Me.btn_object_pdf.TabIndex = 0
        Me.btn_object_pdf.TabStop = False
        Me.btn_object_pdf.Tag = "Exportar"
        Me.btn_object_pdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txt_object_tips.SetToolTip(Me.btn_object_pdf, "Exportar")
        Me.btn_object_pdf.UseVisualStyleBackColor = True
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
        Me.btn_object_clean.ForeColor = System.Drawing.Color.DarkCyan
        Me.btn_object_clean.Image = CType(resources.GetObject("btn_object_clean.Image"), System.Drawing.Image)
        Me.btn_object_clean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_object_clean.Location = New System.Drawing.Point(771, 1)
        Me.btn_object_clean.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_clean.MinimumSize = New System.Drawing.Size(25, 25)
        Me.btn_object_clean.Name = "btn_object_clean"
        Me.btn_object_clean.Size = New System.Drawing.Size(33, 33)
        Me.btn_object_clean.TabIndex = 2
        Me.btn_object_clean.TabStop = False
        Me.btn_object_clean.Tag = ""
        Me.btn_object_clean.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txt_object_tips.SetToolTip(Me.btn_object_clean, "Limpiar")
        Me.btn_object_clean.UseVisualStyleBackColor = True
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
        Me.btn_object_print.Location = New System.Drawing.Point(804, 1)
        Me.btn_object_print.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_print.MinimumSize = New System.Drawing.Size(25, 25)
        Me.btn_object_print.Name = "btn_object_print"
        Me.btn_object_print.Size = New System.Drawing.Size(35, 33)
        Me.btn_object_print.TabIndex = 0
        Me.btn_object_print.TabStop = False
        Me.btn_object_print.Tag = "Imprimir"
        Me.txt_object_tips.SetToolTip(Me.btn_object_print, "Imprimir")
        Me.btn_object_print.UseVisualStyleBackColor = True
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
        Me.btn_object_update.Location = New System.Drawing.Point(839, 1)
        Me.btn_object_update.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_update.MinimumSize = New System.Drawing.Size(25, 25)
        Me.btn_object_update.Name = "btn_object_update"
        Me.btn_object_update.Size = New System.Drawing.Size(35, 33)
        Me.btn_object_update.TabIndex = 0
        Me.btn_object_update.TabStop = False
        Me.btn_object_update.Tag = ""
        Me.txt_object_tips.SetToolTip(Me.btn_object_update, "Actualizar")
        Me.btn_object_update.UseVisualStyleBackColor = True
        '
        'xfs_path
        '
        Me.xfs_path.RestoreDirectory = True
        Me.xfs_path.Title = "BIM"
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
        Me.lbl_module_title.Text = "Ventas por producto"
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
        Me.pnl_object_container.Controls.Add(Me.pnl_object_visor)
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
        'pnl_object_visor
        '
        Me.pnl_object_visor.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_visor.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_visor.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnl_object_visor.Appearance.Options.UseBackColor = True
        Me.pnl_object_visor.Appearance.Options.UseBorderColor = True
        Me.pnl_object_visor.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.pnl_object_visor.Controls.Add(Me.crv_object_report)
        Me.pnl_object_visor.Controls.Add(Me.pnl_object_search)
        Me.pnl_object_visor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_visor.Location = New System.Drawing.Point(405, 10)
        Me.pnl_object_visor.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_visor.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.pnl_object_visor.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_visor.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_visor.Name = "pnl_object_visor"
        Me.pnl_object_visor.Size = New System.Drawing.Size(898, 433)
        Me.pnl_object_visor.TabIndex = 1
        '
        'crv_object_report
        '
        Me.crv_object_report.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.crv_object_report.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_object_report.Location = New System.Drawing.Point(2, 37)
        Me.crv_object_report.Margin = New System.Windows.Forms.Padding(0)
        Me.crv_object_report.Name = "crv_object_report"
        Me.crv_object_report.Padding = New System.Windows.Forms.Padding(30)
        Me.crv_object_report.ShowStopButton = False
        Me.crv_object_report.ShowToolBar = False
        Me.crv_object_report.Size = New System.Drawing.Size(894, 394)
        Me.crv_object_report.TabIndex = 0
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
        Me.pnl_object_search.Controls.Add(Me.btn_object_left)
        Me.pnl_object_search.Controls.Add(Me.btn_object_right)
        Me.pnl_object_search.Controls.Add(Me.lbl_separator_line1)
        Me.pnl_object_search.Controls.Add(Me.btn_object_pdf)
        Me.pnl_object_search.Controls.Add(Me.btn_object_clean)
        Me.pnl_object_search.Controls.Add(Me.btn_object_print)
        Me.pnl_object_search.Controls.Add(Me.btn_object_update)
        Me.pnl_object_search.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_object_search.Location = New System.Drawing.Point(2, 2)
        Me.pnl_object_search.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_search.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_search.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_search.Name = "pnl_object_search"
        Me.pnl_object_search.Padding = New System.Windows.Forms.Padding(40, 1, 20, 1)
        Me.pnl_object_search.Size = New System.Drawing.Size(894, 35)
        Me.pnl_object_search.TabIndex = 0
        '
        'lbl_separator_line1
        '
        Me.lbl_separator_line1.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_separator_line1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.lbl_separator_line1.Location = New System.Drawing.Point(731, 1)
        Me.lbl_separator_line1.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_separator_line1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_separator_line1.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_separator_line1.Name = "lbl_separator_line1"
        Me.lbl_separator_line1.Padding = New System.Windows.Forms.Padding(0, 8, 0, 6)
        Me.lbl_separator_line1.Size = New System.Drawing.Size(10, 33)
        Me.lbl_separator_line1.TabIndex = 1
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
        'reports_wholesales_product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnl_object_container)
        Me.Controls.Add(Me.pnl_object_top)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "reports_wholesales_product"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(1350, 550)
        Me.Tag = "Ventas por producto"
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_top.ResumeLayout(False)
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        CType(Me.pnl_object_visor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_visor.ResumeLayout(False)
        CType(Me.pnl_object_search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_search.ResumeLayout(False)
        CType(Me.lbl_separator_line1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_filter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_filter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_object_tips As ToolTip
    Friend WithEvents xfs_path As DevExpress.XtraEditors.XtraSaveFileDialog
    Friend WithEvents pnl_object_top As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_module_subtitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_module_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_close As Button
    Protected WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Protected WithEvents pnl_object_visor As DevExpress.XtraEditors.PanelControl
    Friend WithEvents crv_object_report As Microsoft.Reporting.WinForms.ReportViewer
    Protected WithEvents pnl_object_search As DevExpress.XtraEditors.PanelControl
    Protected WithEvents btn_object_left As Button
    Protected WithEvents btn_object_right As Button
    Friend WithEvents lbl_separator_line1 As DevExpress.XtraEditors.SeparatorControl
    Protected WithEvents btn_object_pdf As Button
    Protected WithEvents btn_object_clean As Button
    Protected WithEvents btn_object_print As Button
    Protected WithEvents btn_object_update As Button
    Friend WithEvents lbl_object_separator1 As DevExpress.XtraEditors.LabelControl
    Protected WithEvents pnl_object_filter As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txt_rules_criteria As APDA.Object.Controls.TextboxFilter
    Protected WithEvents btn_object_find As Button
End Class
