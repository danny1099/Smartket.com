<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class start_initial_connect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(start_initial_connect))
        Me.object_panel_header = New DevExpress.XtraEditors.PanelControl()
        Me.object_label_info = New DevExpress.XtraEditors.LabelControl()
        Me.object_label_title = New DevExpress.XtraEditors.LabelControl()
        Me.object_panel_actions = New System.Windows.Forms.FlowLayoutPanel()
        Me.object_panel_container = New System.Windows.Forms.Panel()
        Me.object_listed_connection = New APDA.[Object].Controls.ComboboxEdit()
        Me.object_label_name = New DevExpress.XtraEditors.LabelControl()
        Me.object_button_saved = New System.Windows.Forms.Button()
        Me.object_separator_spliter1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.object_button_clean = New System.Windows.Forms.Button()
        Me.object_button_closed = New System.Windows.Forms.Button()
        CType(Me.object_panel_header, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.object_panel_header.SuspendLayout()
        Me.object_panel_actions.SuspendLayout()
        Me.object_panel_container.SuspendLayout()
        CType(Me.object_listed_connection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_separator_spliter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'object_panel_header
        '
        Me.object_panel_header.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.object_panel_header.Controls.Add(Me.object_label_info)
        Me.object_panel_header.Controls.Add(Me.object_label_title)
        Me.object_panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.object_panel_header.Location = New System.Drawing.Point(1, 1)
        Me.object_panel_header.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_panel_header.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_panel_header.Margin = New System.Windows.Forms.Padding(0)
        Me.object_panel_header.Name = "object_panel_header"
        Me.object_panel_header.Padding = New System.Windows.Forms.Padding(1)
        Me.object_panel_header.Size = New System.Drawing.Size(586, 85)
        Me.object_panel_header.TabIndex = 0
        '
        'object_label_info
        '
        Me.object_label_info.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_info.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_label_info.Appearance.Options.UseFont = True
        Me.object_label_info.Appearance.Options.UseForeColor = True
        Me.object_label_info.Appearance.Options.UseTextOptions = True
        Me.object_label_info.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.object_label_info.Location = New System.Drawing.Point(46, 64)
        Me.object_label_info.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_info.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_info.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_info.Name = "object_label_info"
        Me.object_label_info.Size = New System.Drawing.Size(284, 16)
        Me.object_label_info.TabIndex = 0
        Me.object_label_info.Text = "Todos los campos marcados con asterico (*) son obligatorios"
        '
        'object_label_title
        '
        Me.object_label_title.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 20.25!)
        Me.object_label_title.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.object_label_title.Appearance.Options.UseFont = True
        Me.object_label_title.Appearance.Options.UseForeColor = True
        Me.object_label_title.Appearance.Options.UseTextOptions = True
        Me.object_label_title.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.object_label_title.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.object_label_title.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.object_label_title.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.object_label_title.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.object_label_title.Location = New System.Drawing.Point(45, 28)
        Me.object_label_title.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_title.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_title.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_title.Name = "object_label_title"
        Me.object_label_title.Size = New System.Drawing.Size(80, 37)
        Me.object_label_title.TabIndex = 0
        Me.object_label_title.Text = "Conexión"
        '
        'object_panel_actions
        '
        Me.object_panel_actions.Controls.Add(Me.object_button_saved)
        Me.object_panel_actions.Controls.Add(Me.object_separator_spliter1)
        Me.object_panel_actions.Controls.Add(Me.object_button_clean)
        Me.object_panel_actions.Controls.Add(Me.object_button_closed)
        Me.object_panel_actions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.object_panel_actions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.object_panel_actions.Location = New System.Drawing.Point(1, 304)
        Me.object_panel_actions.Margin = New System.Windows.Forms.Padding(0)
        Me.object_panel_actions.Name = "object_panel_actions"
        Me.object_panel_actions.Padding = New System.Windows.Forms.Padding(5, 5, 35, 5)
        Me.object_panel_actions.Size = New System.Drawing.Size(586, 50)
        Me.object_panel_actions.TabIndex = 0
        '
        'object_panel_container
        '
        Me.object_panel_container.Controls.Add(Me.object_listed_connection)
        Me.object_panel_container.Controls.Add(Me.object_label_name)
        Me.object_panel_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.object_panel_container.Location = New System.Drawing.Point(1, 86)
        Me.object_panel_container.Margin = New System.Windows.Forms.Padding(0)
        Me.object_panel_container.Name = "object_panel_container"
        Me.object_panel_container.Padding = New System.Windows.Forms.Padding(1)
        Me.object_panel_container.Size = New System.Drawing.Size(586, 218)
        Me.object_panel_container.TabIndex = 1
        '
        'object_listed_connection
        '
        Me.object_listed_connection.Location = New System.Drawing.Point(46, 91)
        Me.object_listed_connection.Margin = New System.Windows.Forms.Padding(0)
        Me.object_listed_connection.Name = "object_listed_connection"
        Me.object_listed_connection.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.object_listed_connection.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.object_listed_connection.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_connection.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.object_listed_connection.Properties.Appearance.Options.UseBackColor = True
        Me.object_listed_connection.Properties.Appearance.Options.UseBorderColor = True
        Me.object_listed_connection.Properties.Appearance.Options.UseForeColor = True
        Me.object_listed_connection.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.object_listed_connection.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.object_listed_connection.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_connection.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.object_listed_connection.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.object_listed_connection.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.object_listed_connection.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.object_listed_connection.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_connection.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.object_listed_connection.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.object_listed_connection.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.object_listed_connection.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.object_listed_connection.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_connection.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.object_listed_connection.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.object_listed_connection.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.object_listed_connection.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.object_listed_connection.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_connection.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.object_listed_connection.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.object_listed_connection.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.object_listed_connection.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.object_listed_connection.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_connection.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.object_listed_connection.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.object_listed_connection.Properties.AutoHeight = False
        Me.object_listed_connection.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.object_listed_connection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.object_listed_connection.Properties.DropDownItemHeight = 30
        Me.object_listed_connection.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_listed_connection.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_listed_connection.Properties.NullText = ""
        Me.object_listed_connection.Properties.ShowFooter = False
        Me.object_listed_connection.Properties.ShowHeader = False
        Me.object_listed_connection.Size = New System.Drawing.Size(480, 30)
        Me.object_listed_connection.TabIndex = 1
        '
        'object_label_name
        '
        Me.object_label_name.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_name.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_label_name.Appearance.Options.UseFont = True
        Me.object_label_name.Appearance.Options.UseForeColor = True
        Me.object_label_name.Location = New System.Drawing.Point(46, 71)
        Me.object_label_name.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_name.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_name.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.object_label_name.Name = "object_label_name"
        Me.object_label_name.Size = New System.Drawing.Size(185, 16)
        Me.object_label_name.TabIndex = 0
        Me.object_label_name.Text = "Defina la conexión al servidor a utilizar*"
        '
        'object_button_saved
        '
        Me.object_button_saved.Cursor = System.Windows.Forms.Cursors.Hand
        Me.object_button_saved.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.object_button_saved.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.object_button_saved.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.object_button_saved.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.object_button_saved.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.object_button_saved.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.object_button_saved.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_button_saved.ForeColor = System.Drawing.Color.DimGray
        Me.object_button_saved.Image = CType(resources.GetObject("object_button_saved.Image"), System.Drawing.Image)
        Me.object_button_saved.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.object_button_saved.Location = New System.Drawing.Point(456, 5)
        Me.object_button_saved.Margin = New System.Windows.Forms.Padding(0)
        Me.object_button_saved.MaximumSize = New System.Drawing.Size(90, 38)
        Me.object_button_saved.MinimumSize = New System.Drawing.Size(90, 38)
        Me.object_button_saved.Name = "object_button_saved"
        Me.object_button_saved.Size = New System.Drawing.Size(90, 38)
        Me.object_button_saved.TabIndex = 0
        Me.object_button_saved.TabStop = False
        Me.object_button_saved.Tag = ""
        Me.object_button_saved.Text = "Guardar"
        Me.object_button_saved.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.object_button_saved.UseVisualStyleBackColor = True
        '
        'object_separator_spliter1
        '
        Me.object_separator_spliter1.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.object_separator_spliter1.LineColor = System.Drawing.Color.Silver
        Me.object_separator_spliter1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.object_separator_spliter1.Location = New System.Drawing.Point(449, 5)
        Me.object_separator_spliter1.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_separator_spliter1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_separator_spliter1.Margin = New System.Windows.Forms.Padding(0)
        Me.object_separator_spliter1.Name = "object_separator_spliter1"
        Me.object_separator_spliter1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.object_separator_spliter1.Size = New System.Drawing.Size(7, 40)
        Me.object_separator_spliter1.TabIndex = 6
        '
        'object_button_clean
        '
        Me.object_button_clean.Cursor = System.Windows.Forms.Cursors.Hand
        Me.object_button_clean.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.object_button_clean.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.object_button_clean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.object_button_clean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.object_button_clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.object_button_clean.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_button_clean.ForeColor = System.Drawing.Color.DimGray
        Me.object_button_clean.Image = CType(resources.GetObject("object_button_clean.Image"), System.Drawing.Image)
        Me.object_button_clean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.object_button_clean.Location = New System.Drawing.Point(371, 5)
        Me.object_button_clean.Margin = New System.Windows.Forms.Padding(0)
        Me.object_button_clean.MaximumSize = New System.Drawing.Size(78, 38)
        Me.object_button_clean.MinimumSize = New System.Drawing.Size(78, 38)
        Me.object_button_clean.Name = "object_button_clean"
        Me.object_button_clean.Size = New System.Drawing.Size(78, 38)
        Me.object_button_clean.TabIndex = 0
        Me.object_button_clean.TabStop = False
        Me.object_button_clean.Tag = ""
        Me.object_button_clean.Text = "Limpiar"
        Me.object_button_clean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.object_button_clean.UseVisualStyleBackColor = True
        '
        'object_button_closed
        '
        Me.object_button_closed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.object_button_closed.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.object_button_closed.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.object_button_closed.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.object_button_closed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.object_button_closed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.object_button_closed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.object_button_closed.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_button_closed.ForeColor = System.Drawing.Color.DimGray
        Me.object_button_closed.Image = CType(resources.GetObject("object_button_closed.Image"), System.Drawing.Image)
        Me.object_button_closed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.object_button_closed.Location = New System.Drawing.Point(295, 5)
        Me.object_button_closed.Margin = New System.Windows.Forms.Padding(0)
        Me.object_button_closed.MaximumSize = New System.Drawing.Size(76, 38)
        Me.object_button_closed.MinimumSize = New System.Drawing.Size(76, 38)
        Me.object_button_closed.Name = "object_button_closed"
        Me.object_button_closed.Size = New System.Drawing.Size(76, 38)
        Me.object_button_closed.TabIndex = 0
        Me.object_button_closed.TabStop = False
        Me.object_button_closed.Tag = ""
        Me.object_button_closed.Text = " Cancelar"
        Me.object_button_closed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.object_button_closed.UseVisualStyleBackColor = True
        '
        'start_initial_connect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.object_panel_container)
        Me.Controls.Add(Me.object_panel_actions)
        Me.Controls.Add(Me.object_panel_header)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "start_initial_connect"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(588, 355)
        CType(Me.object_panel_header, System.ComponentModel.ISupportInitialize).EndInit()
        Me.object_panel_header.ResumeLayout(False)
        Me.object_panel_header.PerformLayout()
        Me.object_panel_actions.ResumeLayout(False)
        Me.object_panel_container.ResumeLayout(False)
        Me.object_panel_container.PerformLayout()
        CType(Me.object_listed_connection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_separator_spliter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents object_panel_header As DevExpress.XtraEditors.PanelControl
    Friend WithEvents object_label_info As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_label_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_panel_actions As FlowLayoutPanel
    Friend WithEvents object_panel_container As Panel
    Friend WithEvents object_label_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_listed_connection As APDA.Object.Controls.ComboboxEdit
    Protected WithEvents object_button_saved As Button
    Friend WithEvents object_separator_spliter1 As DevExpress.XtraEditors.SeparatorControl
    Protected WithEvents object_button_clean As Button
    Protected WithEvents object_button_closed As Button
End Class
