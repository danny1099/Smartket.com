<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wholesales_collections_search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wholesales_collections_search))
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_rules_condition = New DevExpress.XtraEditors.LabelControl()
        Me.txt_rules_criteria = New APDA.[Object].Controls.TextboxFilter()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.lbl_object_subtitle = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.lbl_rules_condition)
        Me.pnl_object_container.Controls.Add(Me.txt_rules_criteria)
        Me.pnl_object_container.Controls.Add(Me.btn_object_accept)
        Me.pnl_object_container.Controls.Add(Me.btn_object_cancel)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_subtitle)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_title)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 1)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_container.Size = New System.Drawing.Size(518, 548)
        Me.pnl_object_container.TabIndex = 0
        '
        'lbl_rules_condition
        '
        Me.lbl_rules_condition.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rules_condition.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_rules_condition.Appearance.Options.UseFont = True
        Me.lbl_rules_condition.Appearance.Options.UseForeColor = True
        Me.lbl_rules_condition.Location = New System.Drawing.Point(39, 126)
        Me.lbl_rules_condition.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_rules_condition.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_rules_condition.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_rules_condition.Name = "lbl_rules_condition"
        Me.lbl_rules_condition.Size = New System.Drawing.Size(195, 16)
        Me.lbl_rules_condition.TabIndex = 0
        Me.lbl_rules_condition.Text = "Condiciones y/o criterios de la busqueda*"
        '
        'txt_rules_criteria
        '
        Me.txt_rules_criteria.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_rules_criteria.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_rules_criteria.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_rules_criteria.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.txt_rules_criteria.Appearance.Options.UseBackColor = True
        Me.txt_rules_criteria.Appearance.Options.UseBorderColor = True
        Me.txt_rules_criteria.Appearance.Options.UseForeColor = True
        Me.txt_rules_criteria.AppearanceTreeLine.BackColor = System.Drawing.Color.LightSeaGreen
        Me.txt_rules_criteria.AppearanceTreeLine.BackColor2 = System.Drawing.Color.LightSeaGreen
        Me.txt_rules_criteria.AppearanceTreeLine.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.txt_rules_criteria.AppearanceTreeLine.Options.UseBackColor = True
        Me.txt_rules_criteria.AppearanceTreeLine.Options.UseBorderColor = True
        Me.txt_rules_criteria.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_rules_criteria.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_rules_criteria.Tag = "Condición"
        Me.txt_rules_criteria.Location = New System.Drawing.Point(39, 146)
        Me.txt_rules_criteria.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_rules_criteria.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_rules_criteria.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_rules_criteria.Name = "txt_rules_criteria"
        Me.txt_rules_criteria.Padding = New System.Windows.Forms.Padding(1)
        Me.txt_rules_criteria.ShowOperandTypeIcon = True
        Me.txt_rules_criteria.Size = New System.Drawing.Size(432, 326)
        Me.txt_rules_criteria.TabIndex = 0
        '
        'btn_object_accept
        '
        Me.btn_object_accept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_accept.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_accept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_accept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_accept.Font = New System.Drawing.Font("Open Sans Condensed Light", 20.0!)
        Me.btn_object_accept.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btn_object_accept.Location = New System.Drawing.Point(422, 498)
        Me.btn_object_accept.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_accept.Name = "btn_object_accept"
        Me.btn_object_accept.Size = New System.Drawing.Size(92, 46)
        Me.btn_object_accept.TabIndex = 0
        Me.btn_object_accept.TabStop = False
        Me.btn_object_accept.Text = "Aceptar"
        Me.btn_object_accept.UseVisualStyleBackColor = False
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
        Me.btn_object_cancel.Location = New System.Drawing.Point(487, 4)
        Me.btn_object_cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_cancel.Name = "btn_object_cancel"
        Me.btn_object_cancel.Size = New System.Drawing.Size(28, 31)
        Me.btn_object_cancel.TabIndex = 0
        Me.btn_object_cancel.TabStop = False
        Me.btn_object_cancel.Text = "X"
        Me.btn_object_cancel.UseVisualStyleBackColor = False
        '
        'lbl_object_subtitle
        '
        Me.lbl_object_subtitle.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_object_subtitle.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_subtitle.Appearance.Options.UseFont = True
        Me.lbl_object_subtitle.Appearance.Options.UseForeColor = True
        Me.lbl_object_subtitle.Location = New System.Drawing.Point(41, 76)
        Me.lbl_object_subtitle.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_subtitle.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_subtitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_subtitle.Name = "lbl_object_subtitle"
        Me.lbl_object_subtitle.Size = New System.Drawing.Size(272, 16)
        Me.lbl_object_subtitle.TabIndex = 0
        Me.lbl_object_subtitle.Text = "Defina los campos necesarios para realizar la busqueda..."
        '
        'lbl_object_title
        '
        Me.lbl_object_title.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 21.0!)
        Me.lbl_object_title.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lbl_object_title.Appearance.Options.UseFont = True
        Me.lbl_object_title.Appearance.Options.UseForeColor = True
        Me.lbl_object_title.Location = New System.Drawing.Point(39, 38)
        Me.lbl_object_title.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_title.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_title.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_title.Name = "lbl_object_title"
        Me.lbl_object_title.Size = New System.Drawing.Size(208, 38)
        Me.lbl_object_title.TabIndex = 0
        Me.lbl_object_title.Text = "Busqueda de recaudos"
        '
        'wholesales_collections_search
        '
        Me.AcceptButton = Me.btn_object_accept
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.BackColor2 = System.Drawing.Color.White
        Me.Appearance.BorderColor = System.Drawing.Color.White
        Me.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseBorderColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.btn_object_cancel
        Me.ClientSize = New System.Drawing.Size(520, 550)
        Me.Controls.Add(Me.pnl_object_container)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IconOptions.Icon = CType(resources.GetObject("wholesales_collections_search.IconOptions.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Office 2019 White"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "wholesales_collections_search"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Busqueda de recaudos"
        Me.TopMost = True
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_rules_condition As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_rules_criteria As APDA.Object.Controls.TextboxFilter
    Friend WithEvents btn_object_accept As Button
    Friend WithEvents btn_object_cancel As Button
    Friend WithEvents lbl_object_subtitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
End Class
