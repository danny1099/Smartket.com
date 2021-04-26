<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class attention_quotation_viewers
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(attention_quotation_viewers))
        Me.txt_object_tips = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_object_left = New System.Windows.Forms.Button()
        Me.btn_object_right = New System.Windows.Forms.Button()
        Me.btn_object_pdf = New System.Windows.Forms.Button()
        Me.btn_object_print = New System.Windows.Forms.Button()
        Me.btn_object_update = New System.Windows.Forms.Button()
        Me.xfs_path = New DevExpress.XtraEditors.XtraSaveFileDialog(Me.components)
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.pnl_object_search = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_separator_line1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.crv_object_report = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.lbl_object_subtitle = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        CType(Me.pnl_object_search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_search.SuspendLayout()
        CType(Me.lbl_separator_line1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btn_object_left.Location = New System.Drawing.Point(683, 1)
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
        Me.btn_object_right.Location = New System.Drawing.Point(713, 1)
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
        Me.btn_object_pdf.Location = New System.Drawing.Point(753, 1)
        Me.btn_object_pdf.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_object_pdf.MinimumSize = New System.Drawing.Size(25, 25)
        Me.btn_object_pdf.Name = "btn_object_pdf"
        Me.btn_object_pdf.Size = New System.Drawing.Size(30, 33)
        Me.btn_object_pdf.TabIndex = 0
        Me.btn_object_pdf.TabStop = False
        Me.btn_object_pdf.Tag = "Exportar"
        Me.btn_object_pdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txt_object_tips.SetToolTip(Me.btn_object_pdf, "PDF")
        Me.btn_object_pdf.UseVisualStyleBackColor = True
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
        Me.btn_object_print.Location = New System.Drawing.Point(783, 1)
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
        Me.btn_object_update.Location = New System.Drawing.Point(818, 1)
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
        'pnl_object_container
        '
        Me.pnl_object_container.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_container.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_container.Appearance.BorderColor = System.Drawing.Color.White
        Me.pnl_object_container.Appearance.Options.UseBackColor = True
        Me.pnl_object_container.Appearance.Options.UseBorderColor = True
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.pnl_object_search)
        Me.pnl_object_container.Controls.Add(Me.btn_object_cancel)
        Me.pnl_object_container.Controls.Add(Me.crv_object_report)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_subtitle)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_title)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 1)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_container.Size = New System.Drawing.Size(875, 598)
        Me.pnl_object_container.TabIndex = 1
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
        Me.pnl_object_search.Controls.Add(Me.btn_object_print)
        Me.pnl_object_search.Controls.Add(Me.btn_object_update)
        Me.pnl_object_search.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_object_search.Location = New System.Drawing.Point(1, 86)
        Me.pnl_object_search.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_search.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_search.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_search.Name = "pnl_object_search"
        Me.pnl_object_search.Padding = New System.Windows.Forms.Padding(40, 1, 20, 1)
        Me.pnl_object_search.Size = New System.Drawing.Size(873, 35)
        Me.pnl_object_search.TabIndex = 0
        '
        'lbl_separator_line1
        '
        Me.lbl_separator_line1.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_separator_line1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.lbl_separator_line1.Location = New System.Drawing.Point(743, 1)
        Me.lbl_separator_line1.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_separator_line1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_separator_line1.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_separator_line1.Name = "lbl_separator_line1"
        Me.lbl_separator_line1.Padding = New System.Windows.Forms.Padding(0, 8, 0, 8)
        Me.lbl_separator_line1.Size = New System.Drawing.Size(10, 33)
        Me.lbl_separator_line1.TabIndex = 0
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
        Me.btn_object_cancel.Location = New System.Drawing.Point(843, 4)
        Me.btn_object_cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_cancel.Name = "btn_object_cancel"
        Me.btn_object_cancel.Size = New System.Drawing.Size(28, 31)
        Me.btn_object_cancel.TabIndex = 0
        Me.btn_object_cancel.TabStop = False
        Me.btn_object_cancel.Text = "X"
        Me.btn_object_cancel.UseVisualStyleBackColor = False
        '
        'crv_object_report
        '
        Me.crv_object_report.ActiveViewIndex = -1
        Me.crv_object_report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_object_report.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_object_report.DisplayBackgroundEdge = False
        Me.crv_object_report.DisplayStatusBar = False
        Me.crv_object_report.DisplayToolbar = False
        Me.crv_object_report.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.crv_object_report.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crv_object_report.ForeColor = System.Drawing.Color.DimGray
        Me.crv_object_report.Location = New System.Drawing.Point(1, 121)
        Me.crv_object_report.Margin = New System.Windows.Forms.Padding(0)
        Me.crv_object_report.Name = "crv_object_report"
        Me.crv_object_report.ShowCloseButton = False
        Me.crv_object_report.ShowCopyButton = False
        Me.crv_object_report.ShowParameterPanelButton = False
        Me.crv_object_report.Size = New System.Drawing.Size(873, 476)
        Me.crv_object_report.TabIndex = 0
        Me.crv_object_report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'lbl_object_subtitle
        '
        Me.lbl_object_subtitle.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 9.75!)
        Me.lbl_object_subtitle.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_subtitle.Appearance.Options.UseFont = True
        Me.lbl_object_subtitle.Appearance.Options.UseForeColor = True
        Me.lbl_object_subtitle.Location = New System.Drawing.Point(42, 62)
        Me.lbl_object_subtitle.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_subtitle.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_subtitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_subtitle.Name = "lbl_object_subtitle"
        Me.lbl_object_subtitle.Size = New System.Drawing.Size(232, 18)
        Me.lbl_object_subtitle.TabIndex = 0
        Me.lbl_object_subtitle.Text = "Los campos marcados con asterico (*) son requeridos..."
        '
        'lbl_object_title
        '
        Me.lbl_object_title.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_object_title.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lbl_object_title.Appearance.Options.UseFont = True
        Me.lbl_object_title.Appearance.Options.UseForeColor = True
        Me.lbl_object_title.Location = New System.Drawing.Point(40, 30)
        Me.lbl_object_title.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_title.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_title.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_title.Name = "lbl_object_title"
        Me.lbl_object_title.Size = New System.Drawing.Size(168, 33)
        Me.lbl_object_title.TabIndex = 0
        Me.lbl_object_title.Text = "Formato de cotización"
        '
        'attention_quotation_viewers
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.BackColor2 = System.Drawing.Color.White
        Me.Appearance.BorderColor = System.Drawing.Color.White
        Me.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseBorderColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(877, 600)
        Me.Controls.Add(Me.pnl_object_container)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IconOptions.Image = CType(resources.GetObject("attention_quotation_viewers.IconOptions.Image"), System.Drawing.Image)
        Me.LookAndFeel.SkinName = "Office 2019 White"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "attention_quotation_viewers"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BIM"
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        CType(Me.pnl_object_search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_search.ResumeLayout(False)
        CType(Me.lbl_separator_line1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_object_tips As ToolTip
    Friend WithEvents xfs_path As DevExpress.XtraEditors.XtraSaveFileDialog
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Protected WithEvents pnl_object_search As DevExpress.XtraEditors.PanelControl
    Protected WithEvents btn_object_left As Button
    Protected WithEvents btn_object_right As Button
    Friend WithEvents lbl_separator_line1 As DevExpress.XtraEditors.SeparatorControl
    Protected WithEvents btn_object_pdf As Button
    Protected WithEvents btn_object_print As Button
    Protected WithEvents btn_object_update As Button
    Friend WithEvents btn_object_cancel As Button
    Friend WithEvents crv_object_report As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents lbl_object_subtitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
End Class
