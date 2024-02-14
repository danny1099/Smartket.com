<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class model_object_comentary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(model_object_comentary))
        Me.object_panel_actions = New System.Windows.Forms.FlowLayoutPanel()
        Me.object_button_saved = New System.Windows.Forms.Button()
        Me.object_separator_spliter1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.object_button_clean = New System.Windows.Forms.Button()
        Me.object_button_closed = New System.Windows.Forms.Button()
        Me.object_component_tool = New DevExpress.Utils.DefaultToolTipController(Me.components)
        Me.object_panel_container = New DevExpress.XtraEditors.PanelControl()
        Me.chk_keep_form = New DevExpress.XtraEditors.CheckEdit()
        Me.lbl_object_caracters = New DevExpress.XtraEditors.LabelControl()
        Me.txt_object_note = New DevExpress.XtraEditors.MemoEdit()
        Me.object_label_status = New DevExpress.XtraEditors.LabelControl()
        Me.object_label_info = New DevExpress.XtraEditors.LabelControl()
        Me.object_label_title = New DevExpress.XtraEditors.LabelControl()
        Me.object_component_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.object_panel_actions.SuspendLayout()
        CType(Me.object_separator_spliter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_panel_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.object_panel_container.SuspendLayout()
        CType(Me.chk_keep_form.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_object_note.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_component_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'object_panel_actions
        '
        Me.object_component_tool.SetAllowHtmlText(Me.object_panel_actions, DevExpress.Utils.DefaultBoolean.[Default])
        Me.object_panel_actions.Controls.Add(Me.object_button_saved)
        Me.object_panel_actions.Controls.Add(Me.object_separator_spliter1)
        Me.object_panel_actions.Controls.Add(Me.object_button_clean)
        Me.object_panel_actions.Controls.Add(Me.object_button_closed)
        Me.object_panel_actions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.object_panel_actions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.object_panel_actions.Location = New System.Drawing.Point(1, 383)
        Me.object_panel_actions.Margin = New System.Windows.Forms.Padding(0)
        Me.object_panel_actions.Name = "object_panel_actions"
        Me.object_panel_actions.Padding = New System.Windows.Forms.Padding(5, 5, 30, 5)
        Me.object_panel_actions.Size = New System.Drawing.Size(614, 50)
        Me.object_panel_actions.TabIndex = 0
        '
        'object_button_saved
        '
        Me.object_component_tool.SetAllowHtmlText(Me.object_button_saved, DevExpress.Utils.DefaultBoolean.[Default])
        Me.object_button_saved.Cursor = System.Windows.Forms.Cursors.Hand
        Me.object_button_saved.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.object_button_saved.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.object_button_saved.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.object_button_saved.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.object_button_saved.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.object_button_saved.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_button_saved.ForeColor = System.Drawing.Color.DimGray
        Me.object_button_saved.Image = CType(resources.GetObject("object_button_saved.Image"), System.Drawing.Image)
        Me.object_button_saved.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.object_button_saved.Location = New System.Drawing.Point(489, 5)
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
        Me.object_component_tool.SetAllowHtmlText(Me.object_separator_spliter1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.object_separator_spliter1.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.object_separator_spliter1.LineColor = System.Drawing.Color.Silver
        Me.object_separator_spliter1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.object_separator_spliter1.Location = New System.Drawing.Point(482, 5)
        Me.object_separator_spliter1.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_separator_spliter1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_separator_spliter1.Margin = New System.Windows.Forms.Padding(0)
        Me.object_separator_spliter1.Name = "object_separator_spliter1"
        Me.object_separator_spliter1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.object_separator_spliter1.Size = New System.Drawing.Size(7, 40)
        Me.object_separator_spliter1.TabIndex = 2
        '
        'object_button_clean
        '
        Me.object_component_tool.SetAllowHtmlText(Me.object_button_clean, DevExpress.Utils.DefaultBoolean.[Default])
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
        Me.object_button_clean.Location = New System.Drawing.Point(404, 5)
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
        Me.object_component_tool.SetAllowHtmlText(Me.object_button_closed, DevExpress.Utils.DefaultBoolean.[Default])
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
        Me.object_button_closed.Location = New System.Drawing.Point(328, 5)
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
        'object_component_tool
        '
        '
        '
        '
        Me.object_component_tool.DefaultController.Appearance.BackColor = System.Drawing.Color.Black
        Me.object_component_tool.DefaultController.Appearance.BackColor2 = System.Drawing.Color.Black
        Me.object_component_tool.DefaultController.Appearance.BorderColor = System.Drawing.Color.Black
        Me.object_component_tool.DefaultController.Appearance.Font = New System.Drawing.Font("Roboto Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_component_tool.DefaultController.Appearance.ForeColor = System.Drawing.Color.White
        Me.object_component_tool.DefaultController.Appearance.Options.UseBackColor = True
        Me.object_component_tool.DefaultController.Appearance.Options.UseBorderColor = True
        Me.object_component_tool.DefaultController.Appearance.Options.UseFont = True
        Me.object_component_tool.DefaultController.Appearance.Options.UseForeColor = True
        Me.object_component_tool.DefaultController.AppearanceTitle.BackColor = System.Drawing.Color.Black
        Me.object_component_tool.DefaultController.AppearanceTitle.BackColor2 = System.Drawing.Color.Black
        Me.object_component_tool.DefaultController.AppearanceTitle.BorderColor = System.Drawing.Color.Black
        Me.object_component_tool.DefaultController.AppearanceTitle.Font = New System.Drawing.Font("Open Sans Condensed Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_component_tool.DefaultController.AppearanceTitle.ForeColor = System.Drawing.Color.White
        Me.object_component_tool.DefaultController.AppearanceTitle.Options.UseBackColor = True
        Me.object_component_tool.DefaultController.AppearanceTitle.Options.UseBorderColor = True
        Me.object_component_tool.DefaultController.AppearanceTitle.Options.UseFont = True
        Me.object_component_tool.DefaultController.AppearanceTitle.Options.UseForeColor = True
        Me.object_component_tool.DefaultController.KeepWhileHovered = True
        Me.object_component_tool.DefaultController.ToolTipLocation = DevExpress.Utils.ToolTipLocation.BottomCenter
        Me.object_component_tool.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.Flyout
        '
        'object_panel_container
        '
        Me.object_component_tool.SetAllowHtmlText(Me.object_panel_container, DevExpress.Utils.DefaultBoolean.[Default])
        Me.object_panel_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.object_panel_container.Controls.Add(Me.chk_keep_form)
        Me.object_panel_container.Controls.Add(Me.lbl_object_caracters)
        Me.object_panel_container.Controls.Add(Me.txt_object_note)
        Me.object_panel_container.Controls.Add(Me.object_label_status)
        Me.object_panel_container.Controls.Add(Me.object_label_info)
        Me.object_panel_container.Controls.Add(Me.object_label_title)
        Me.object_panel_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.object_panel_container.Location = New System.Drawing.Point(1, 1)
        Me.object_panel_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_panel_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_panel_container.Margin = New System.Windows.Forms.Padding(0)
        Me.object_panel_container.Name = "object_panel_container"
        Me.object_panel_container.Size = New System.Drawing.Size(614, 382)
        Me.object_panel_container.TabIndex = 0
        '
        'chk_keep_form
        '
        Me.chk_keep_form.EditValue = True
        Me.chk_keep_form.Location = New System.Drawing.Point(394, 326)
        Me.chk_keep_form.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_keep_form.Name = "chk_keep_form"
        Me.chk_keep_form.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.chk_keep_form.Properties.Appearance.Options.UseForeColor = True
        Me.chk_keep_form.Properties.Caption = "Desea conservar el formulario?"
        Me.chk_keep_form.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgToggle1
        Me.chk_keep_form.Properties.CheckBoxOptions.SvgColorChecked = System.Drawing.Color.LightSeaGreen
        Me.chk_keep_form.Properties.CheckBoxOptions.SvgColorGrayed = System.Drawing.Color.GhostWhite
        Me.chk_keep_form.Properties.CheckBoxOptions.SvgColorUnchecked = System.Drawing.Color.Gainsboro
        Me.chk_keep_form.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chk_keep_form.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.chk_keep_form.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.chk_keep_form.Size = New System.Drawing.Size(175, 22)
        Me.chk_keep_form.TabIndex = 0
        '
        'lbl_object_caracters
        '
        Me.lbl_object_caracters.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_caracters.Appearance.Options.UseForeColor = True
        Me.lbl_object_caracters.Location = New System.Drawing.Point(45, 326)
        Me.lbl_object_caracters.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_caracters.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_caracters.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_caracters.Name = "lbl_object_caracters"
        Me.lbl_object_caracters.Size = New System.Drawing.Size(27, 16)
        Me.lbl_object_caracters.TabIndex = 0
        Me.lbl_object_caracters.Text = "0/500"
        '
        'txt_object_note
        '
        Me.txt_object_note.Location = New System.Drawing.Point(45, 145)
        Me.txt_object_note.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_object_note.Name = "txt_object_note"
        Me.txt_object_note.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_object_note.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_object_note.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_object_note.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_object_note.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_object_note.Properties.Appearance.Options.UseBackColor = True
        Me.txt_object_note.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_object_note.Properties.Appearance.Options.UseFont = True
        Me.txt_object_note.Properties.Appearance.Options.UseForeColor = True
        Me.txt_object_note.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_object_note.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_object_note.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_object_note.Size = New System.Drawing.Size(522, 178)
        Me.txt_object_note.TabIndex = 1
        Me.txt_object_note.Tag = "Comentario"
        '
        'object_label_status
        '
        Me.object_label_status.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_status.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_label_status.Appearance.Options.UseFont = True
        Me.object_label_status.Appearance.Options.UseForeColor = True
        Me.object_label_status.Location = New System.Drawing.Point(45, 125)
        Me.object_label_status.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_status.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_status.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_status.Name = "object_label_status"
        Me.object_label_status.Size = New System.Drawing.Size(316, 16)
        Me.object_label_status.TabIndex = 0
        Me.object_label_status.Text = "Registre una nota al registro seleccionado en la vista de resultados*"
        '
        'object_label_info
        '
        Me.object_label_info.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_info.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_label_info.Appearance.Options.UseFont = True
        Me.object_label_info.Appearance.Options.UseForeColor = True
        Me.object_label_info.Appearance.Options.UseTextOptions = True
        Me.object_label_info.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.object_label_info.Location = New System.Drawing.Point(45, 72)
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
        Me.object_label_title.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_title.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.object_label_title.Appearance.Options.UseFont = True
        Me.object_label_title.Appearance.Options.UseForeColor = True
        Me.object_label_title.Appearance.Options.UseTextOptions = True
        Me.object_label_title.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.object_label_title.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.object_label_title.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.object_label_title.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.object_label_title.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.object_label_title.Location = New System.Drawing.Point(44, 42)
        Me.object_label_title.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_title.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_title.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_title.Name = "object_label_title"
        Me.object_label_title.Size = New System.Drawing.Size(84, 33)
        Me.object_label_title.TabIndex = 0
        Me.object_label_title.Text = "Crear Nota"
        '
        'object_component_validate
        '
        Me.object_component_validate.ValidateHiddenControls = False
        Me.object_component_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.[Auto]
        '
        'model_object_comentary
        '
        Me.object_component_tool.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.[Default])
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.object_panel_container)
        Me.Controls.Add(Me.object_panel_actions)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "model_object_comentary"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(616, 434)
        Me.object_panel_actions.ResumeLayout(False)
        CType(Me.object_separator_spliter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_panel_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.object_panel_container.ResumeLayout(False)
        Me.object_panel_container.PerformLayout()
        CType(Me.chk_keep_form.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_object_note.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_component_validate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents object_panel_actions As FlowLayoutPanel
    Protected WithEvents object_button_saved As Button
    Friend WithEvents object_separator_spliter1 As DevExpress.XtraEditors.SeparatorControl
    Protected WithEvents object_button_clean As Button
    Protected WithEvents object_button_closed As Button
    Friend WithEvents object_component_tool As DevExpress.Utils.DefaultToolTipController
    Friend WithEvents object_component_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents object_panel_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents object_label_status As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_label_info As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_label_title As DevExpress.XtraEditors.LabelControl
    Private WithEvents txt_object_note As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lbl_object_caracters As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chk_keep_form As DevExpress.XtraEditors.CheckEdit
End Class
