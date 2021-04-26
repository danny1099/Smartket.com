<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wholesales_returns_document
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wholesales_returns_document))
        Me.pnl_object_options = New DevExpress.XtraEditors.PanelControl()
        Me.btn_object_close = New System.Windows.Forms.Button()
        Me.txt_object_zoom = New DevExpress.XtraEditors.TrackBarControl()
        Me.pnl_object_nodes = New DevExpress.XtraEditors.ListBoxControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.view_object_images = New DevExpress.XtraEditors.PictureEdit()
        Me.view_object_pdf = New DevExpress.XtraPdfViewer.PdfViewer()
        Me.pnl_object_actions = New DevExpress.XtraEditors.SplitContainerControl()
        Me.btn_object_new = New System.Windows.Forms.Button()
        Me.btn_object_erase = New System.Windows.Forms.Button()
        Me.lbl_object_options = New DevExpress.XtraEditors.LabelControl()
        Me.xfd_path = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        CType(Me.pnl_object_options, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_options.SuspendLayout()
        CType(Me.txt_object_zoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_object_zoom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_nodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.view_object_images.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_actions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_actions.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_actions.Panel1.SuspendLayout()
        CType(Me.pnl_object_actions.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_actions.Panel2.SuspendLayout()
        Me.pnl_object_actions.SuspendLayout()
        Me.SuspendLayout()
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
        Me.pnl_object_options.Controls.Add(Me.btn_object_close)
        Me.pnl_object_options.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_object_options.Location = New System.Drawing.Point(1, 1)
        Me.pnl_object_options.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_options.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_options.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_options.Name = "pnl_object_options"
        Me.pnl_object_options.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_options.Size = New System.Drawing.Size(1048, 32)
        Me.pnl_object_options.TabIndex = 0
        '
        'btn_object_close
        '
        Me.btn_object_close.BackColor = System.Drawing.Color.White
        Me.btn_object_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_object_close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_object_close.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_close.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.btn_object_close.ForeColor = System.Drawing.Color.DimGray
        Me.btn_object_close.Location = New System.Drawing.Point(1017, 1)
        Me.btn_object_close.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_close.MaximumSize = New System.Drawing.Size(30, 30)
        Me.btn_object_close.MinimumSize = New System.Drawing.Size(30, 30)
        Me.btn_object_close.Name = "btn_object_close"
        Me.btn_object_close.Size = New System.Drawing.Size(30, 30)
        Me.btn_object_close.TabIndex = 0
        Me.btn_object_close.TabStop = False
        Me.btn_object_close.Text = "X"
        Me.btn_object_close.UseVisualStyleBackColor = False
        '
        'txt_object_zoom
        '
        Me.txt_object_zoom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txt_object_zoom.EditValue = 1
        Me.txt_object_zoom.Location = New System.Drawing.Point(266, 654)
        Me.txt_object_zoom.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_object_zoom.Name = "txt_object_zoom"
        Me.txt_object_zoom.Properties.LabelAppearance.Options.UseTextOptions = True
        Me.txt_object_zoom.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_object_zoom.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_object_zoom.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_object_zoom.Properties.Maximum = 4
        Me.txt_object_zoom.Properties.Minimum = 1
        Me.txt_object_zoom.Properties.ShowLabels = True
        Me.txt_object_zoom.Properties.ShowLabelsForHiddenTicks = True
        Me.txt_object_zoom.Size = New System.Drawing.Size(783, 45)
        Me.txt_object_zoom.TabIndex = 0
        Me.txt_object_zoom.Value = 1
        '
        'pnl_object_nodes
        '
        Me.pnl_object_nodes.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_nodes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_nodes.ItemHeight = 30
        Me.pnl_object_nodes.ItemPadding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_nodes.Location = New System.Drawing.Point(5, 26)
        Me.pnl_object_nodes.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_nodes.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_nodes.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_nodes.Name = "pnl_object_nodes"
        Me.pnl_object_nodes.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_nodes.Size = New System.Drawing.Size(235, 427)
        Me.pnl_object_nodes.TabIndex = 0
        '
        'lbl_object_title
        '
        Me.lbl_object_title.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lbl_object_title.Appearance.Options.UseForeColor = True
        Me.lbl_object_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_object_title.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.lbl_object_title.Location = New System.Drawing.Point(5, 5)
        Me.lbl_object_title.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_title.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_title.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_title.Name = "lbl_object_title"
        Me.lbl_object_title.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.lbl_object_title.Size = New System.Drawing.Size(58, 21)
        Me.lbl_object_title.TabIndex = 0
        Me.lbl_object_title.Text = "Documentos"
        '
        'view_object_images
        '
        Me.view_object_images.Dock = System.Windows.Forms.DockStyle.Right
        Me.view_object_images.Location = New System.Drawing.Point(1049, 33)
        Me.view_object_images.Margin = New System.Windows.Forms.Padding(0)
        Me.view_object_images.Name = "view_object_images"
        Me.view_object_images.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.[True]
        Me.view_object_images.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.[True]
        Me.view_object_images.Properties.AllowScrollViaMouseDrag = True
        Me.view_object_images.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.[True]
        Me.view_object_images.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.view_object_images.Properties.Caption.Alignment = System.Drawing.ContentAlignment.TopCenter
        Me.view_object_images.Properties.Caption.Appearance.BackColor = System.Drawing.Color.Black
        Me.view_object_images.Properties.Caption.Appearance.BackColor2 = System.Drawing.Color.Black
        Me.view_object_images.Properties.Caption.Appearance.BorderColor = System.Drawing.Color.Black
        Me.view_object_images.Properties.Caption.Appearance.ForeColor = System.Drawing.Color.White
        Me.view_object_images.Properties.Caption.Appearance.Options.UseBackColor = True
        Me.view_object_images.Properties.Caption.Appearance.Options.UseBorderColor = True
        Me.view_object_images.Properties.Caption.Appearance.Options.UseForeColor = True
        Me.view_object_images.Properties.Caption.Offset = New System.Drawing.Point(5, 5)
        Me.view_object_images.Properties.Caption.Text = "Nombre de archivo"
        Me.view_object_images.Properties.Caption.Visible = False
        Me.view_object_images.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.view_object_images.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.view_object_images.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.view_object_images.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.view_object_images.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.view_object_images.Size = New System.Drawing.Size(0, 621)
        Me.view_object_images.TabIndex = 0
        '
        'view_object_pdf
        '
        Me.view_object_pdf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.view_object_pdf.Location = New System.Drawing.Point(266, 33)
        Me.view_object_pdf.LookAndFeel.SkinName = "Office 2019 White"
        Me.view_object_pdf.LookAndFeel.UseDefaultLookAndFeel = False
        Me.view_object_pdf.Margin = New System.Windows.Forms.Padding(0)
        Me.view_object_pdf.Name = "view_object_pdf"
        Me.view_object_pdf.Size = New System.Drawing.Size(783, 621)
        Me.view_object_pdf.TabIndex = 0
        Me.view_object_pdf.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToVisible
        '
        'pnl_object_actions
        '
        Me.pnl_object_actions.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_object_actions.FireScrollEventOnMouseWheel = True
        Me.pnl_object_actions.Horizontal = False
        Me.pnl_object_actions.Location = New System.Drawing.Point(1, 33)
        Me.pnl_object_actions.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_actions.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_actions.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_actions.Name = "pnl_object_actions"
        Me.pnl_object_actions.Padding = New System.Windows.Forms.Padding(15, 5, 5, 5)
        '
        'pnl_object_actions.Panel1
        '
        Me.pnl_object_actions.Panel1.Controls.Add(Me.btn_object_new)
        Me.pnl_object_actions.Panel1.Controls.Add(Me.btn_object_erase)
        Me.pnl_object_actions.Panel1.Controls.Add(Me.lbl_object_options)
        Me.pnl_object_actions.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.pnl_object_actions.Panel1.Text = "Panel1"
        '
        'pnl_object_actions.Panel2
        '
        Me.pnl_object_actions.Panel2.AutoScroll = True
        Me.pnl_object_actions.Panel2.Controls.Add(Me.pnl_object_nodes)
        Me.pnl_object_actions.Panel2.Controls.Add(Me.lbl_object_title)
        Me.pnl_object_actions.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.pnl_object_actions.Panel2.Text = "Panel2"
        Me.pnl_object_actions.ShowSplitGlyph = DevExpress.Utils.DefaultBoolean.[True]
        Me.pnl_object_actions.Size = New System.Drawing.Size(265, 666)
        Me.pnl_object_actions.SplitterPosition = 188
        Me.pnl_object_actions.TabIndex = 0
        '
        'btn_object_new
        '
        Me.btn_object_new.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_object_new.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_new.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_object_new.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_object_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_object_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_object_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_new.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_object_new.ForeColor = System.Drawing.Color.DimGray
        Me.btn_object_new.Image = CType(resources.GetObject("btn_object_new.Image"), System.Drawing.Image)
        Me.btn_object_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_object_new.Location = New System.Drawing.Point(4, 40)
        Me.btn_object_new.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_object_new.Name = "btn_object_new"
        Me.btn_object_new.Size = New System.Drawing.Size(225, 40)
        Me.btn_object_new.TabIndex = 0
        Me.btn_object_new.Tag = ""
        Me.btn_object_new.Text = "Adjuntar"
        Me.btn_object_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_object_new.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_object_new.UseVisualStyleBackColor = False
        '
        'btn_object_erase
        '
        Me.btn_object_erase.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_object_erase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_erase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_object_erase.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_object_erase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_object_erase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_object_erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_erase.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_object_erase.ForeColor = System.Drawing.Color.DimGray
        Me.btn_object_erase.Image = CType(resources.GetObject("btn_object_erase.Image"), System.Drawing.Image)
        Me.btn_object_erase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_object_erase.Location = New System.Drawing.Point(4, 89)
        Me.btn_object_erase.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_object_erase.Name = "btn_object_erase"
        Me.btn_object_erase.Size = New System.Drawing.Size(225, 40)
        Me.btn_object_erase.TabIndex = 0
        Me.btn_object_erase.Tag = ""
        Me.btn_object_erase.Text = "Eliminar"
        Me.btn_object_erase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_object_erase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_object_erase.UseVisualStyleBackColor = False
        '
        'lbl_object_options
        '
        Me.lbl_object_options.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lbl_object_options.Appearance.Options.UseForeColor = True
        Me.lbl_object_options.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_object_options.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.lbl_object_options.Location = New System.Drawing.Point(5, 5)
        Me.lbl_object_options.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_options.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_options.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_options.Name = "lbl_object_options"
        Me.lbl_object_options.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.lbl_object_options.Size = New System.Drawing.Size(44, 21)
        Me.lbl_object_options.TabIndex = 0
        Me.lbl_object_options.Text = "Opciones"
        '
        'xfd_path
        '
        Me.xfd_path.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" &
    " *.png | Pdf Files (*.pdf) |*.pdf"
        Me.xfd_path.Location = New System.Drawing.Point(-4, 0)
        Me.xfd_path.Multiselect = True
        '
        'wholesales_returns_document
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.btn_object_close
        Me.ClientSize = New System.Drawing.Size(1050, 700)
        Me.Controls.Add(Me.view_object_pdf)
        Me.Controls.Add(Me.view_object_images)
        Me.Controls.Add(Me.txt_object_zoom)
        Me.Controls.Add(Me.pnl_object_actions)
        Me.Controls.Add(Me.pnl_object_options)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IconOptions.Image = CType(resources.GetObject("wholesales_returns_document.IconOptions.Image"), System.Drawing.Image)
        Me.LookAndFeel.SkinName = "Office 2019 White"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "wholesales_returns_document"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documentos"
        CType(Me.pnl_object_options, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_options.ResumeLayout(False)
        CType(Me.txt_object_zoom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_object_zoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_nodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.view_object_images.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_actions.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_actions.Panel1.ResumeLayout(False)
        Me.pnl_object_actions.Panel1.PerformLayout()
        CType(Me.pnl_object_actions.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_actions.Panel2.ResumeLayout(False)
        Me.pnl_object_actions.Panel2.PerformLayout()
        CType(Me.pnl_object_actions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_actions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected WithEvents pnl_object_options As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_object_close As Button
    Friend WithEvents txt_object_zoom As DevExpress.XtraEditors.TrackBarControl
    Friend WithEvents view_object_images As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents pnl_object_nodes As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents view_object_pdf As DevExpress.XtraPdfViewer.PdfViewer
    Friend WithEvents pnl_object_actions As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lbl_object_options As DevExpress.XtraEditors.LabelControl
    Protected WithEvents btn_object_erase As Button
    Protected WithEvents btn_object_new As Button
    Friend WithEvents xfd_path As DevExpress.XtraEditors.XtraOpenFileDialog
End Class
