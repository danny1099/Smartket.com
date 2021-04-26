<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class settings_permission_created
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings_permission_created))
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule5 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.pnl_object_top = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_refresh = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.cmb_permission_type = New APDA.[Object].Controls.ComboboxEdit()
        Me.cmb_permission_position = New APDA.[Object].Controls.ComboboxEdit()
        Me.cmb_permission_person = New APDA.[Object].Controls.ComboboxSearch()
        Me.dgv_sales_customers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmb_permission_module = New APDA.[Object].Controls.ComboboxEdit()
        Me.cmb_permission_option = New APDA.[Object].Controls.ComboboxEdit()
        Me.pnl_object_bottom = New DevExpress.XtraEditors.PanelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.chk_keep_form = New DevExpress.XtraEditors.CheckEdit()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.chk_object_conserve = New APDA.[Object].Controls.TextboxCheck()
        Me.lbl_permission_assigned = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_permission_actions = New DevExpress.XtraEditors.LabelControl()
        Me.lbc_permission_assigned = New DevExpress.XtraEditors.ListBoxControl()
        Me.lbc_permission_actions = New DevExpress.XtraEditors.ListBoxControl()
        Me.lbl_permission_option = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_permission_module = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_permission_affected = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_permission_type = New DevExpress.XtraEditors.LabelControl()
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_top.SuspendLayout()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_permission_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_permission_position.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_permission_person.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_sales_customers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_permission_module.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_permission_option.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_bottom.SuspendLayout()
        CType(Me.chk_keep_form.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        CType(Me.chk_object_conserve.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbc_permission_assigned, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbc_permission_actions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.pnl_object_top.Controls.Add(Me.lbl_object_info)
        Me.pnl_object_top.Controls.Add(Me.lbl_object_title)
        Me.pnl_object_top.Controls.Add(Me.btn_object_refresh)
        Me.pnl_object_top.Controls.Add(Me.btn_object_cancel)
        Me.pnl_object_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_object_top.Location = New System.Drawing.Point(1, 1)
        Me.pnl_object_top.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_top.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_top.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_top.Name = "pnl_object_top"
        Me.pnl_object_top.Padding = New System.Windows.Forms.Padding(30, 1, 10, 1)
        Me.pnl_object_top.Size = New System.Drawing.Size(1348, 75)
        Me.pnl_object_top.TabIndex = 0
        '
        'lbl_object_info
        '
        Me.lbl_object_info.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_object_info.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_info.Appearance.Options.UseFont = True
        Me.lbl_object_info.Appearance.Options.UseForeColor = True
        Me.lbl_object_info.Appearance.Options.UseTextOptions = True
        Me.lbl_object_info.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_object_info.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_object_info.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_object_info.Location = New System.Drawing.Point(30, 50)
        Me.lbl_object_info.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_info.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_info.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_info.Name = "lbl_object_info"
        Me.lbl_object_info.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.lbl_object_info.Size = New System.Drawing.Size(1198, 20)
        Me.lbl_object_info.TabIndex = 0
        Me.lbl_object_info.Text = "Todos los campos marcados con asterico (*) son obligatorios"
        '
        'lbl_object_title
        '
        Me.lbl_object_title.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 20.25!)
        Me.lbl_object_title.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lbl_object_title.Appearance.Options.UseFont = True
        Me.lbl_object_title.Appearance.Options.UseForeColor = True
        Me.lbl_object_title.Appearance.Options.UseTextOptions = True
        Me.lbl_object_title.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_object_title.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.lbl_object_title.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_object_title.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lbl_object_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_object_title.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.lbl_object_title.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_object_title.Location = New System.Drawing.Point(30, 1)
        Me.lbl_object_title.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_title.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_title.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_title.Name = "lbl_object_title"
        Me.lbl_object_title.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.lbl_object_title.Size = New System.Drawing.Size(1198, 49)
        Me.lbl_object_title.TabIndex = 0
        Me.lbl_object_title.Text = "Crear Permiso"
        '
        'btn_object_refresh
        '
        Me.btn_object_refresh.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.btn_object_refresh.Appearance.Options.UseFont = True
        Me.btn_object_refresh.Appearance.Options.UseForeColor = True
        Me.btn_object_refresh.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.btn_object_refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_refresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_object_refresh.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_object_refresh.ImageOptions.Image = CType(resources.GetObject("btn_object_refresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_object_refresh.Location = New System.Drawing.Point(1228, 1)
        Me.btn_object_refresh.LookAndFeel.SkinName = "Office 2019 White"
        Me.btn_object_refresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_object_refresh.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_refresh.MaximumSize = New System.Drawing.Size(80, 30)
        Me.btn_object_refresh.MinimumSize = New System.Drawing.Size(80, 30)
        Me.btn_object_refresh.Name = "btn_object_refresh"
        Me.btn_object_refresh.Size = New System.Drawing.Size(80, 30)
        Me.btn_object_refresh.TabIndex = 0
        Me.btn_object_refresh.Text = "Sincronizar"
        '
        'btn_object_cancel
        '
        Me.btn_object_cancel.BackColor = System.Drawing.Color.White
        Me.btn_object_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_object_cancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_object_cancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_cancel.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.btn_object_cancel.ForeColor = System.Drawing.Color.DimGray
        Me.btn_object_cancel.Location = New System.Drawing.Point(1308, 1)
        Me.btn_object_cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_cancel.MaximumSize = New System.Drawing.Size(30, 30)
        Me.btn_object_cancel.MinimumSize = New System.Drawing.Size(30, 30)
        Me.btn_object_cancel.Name = "btn_object_cancel"
        Me.btn_object_cancel.Size = New System.Drawing.Size(30, 30)
        Me.btn_object_cancel.TabIndex = 0
        Me.btn_object_cancel.TabStop = False
        Me.btn_object_cancel.Text = "X"
        Me.btn_object_cancel.UseVisualStyleBackColor = False
        '
        'xvp_validate
        '
        Me.xvp_validate.ValidateHiddenControls = False
        Me.xvp_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'cmb_permission_type
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_permission_type, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_permission_type.Location = New System.Drawing.Point(210, 97)
        Me.cmb_permission_type.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_permission_type.Name = "cmb_permission_type"
        Me.cmb_permission_type.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_permission_type.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_type.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_type.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_permission_type.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_permission_type.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_permission_type.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_permission_type.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_permission_type.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_type.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_type.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_permission_type.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_permission_type.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_permission_type.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_type.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_type.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_permission_type.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_permission_type.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_permission_type.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_type.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_type.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_permission_type.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_permission_type.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_permission_type.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_type.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_type.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_permission_type.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_permission_type.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_permission_type.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_type.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_type.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_permission_type.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_permission_type.Properties.AutoHeight = False
        Me.cmb_permission_type.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_permission_type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_permission_type.Properties.DropDownItemHeight = 30
        Me.cmb_permission_type.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_permission_type.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_permission_type.Properties.NullText = ""
        Me.cmb_permission_type.Properties.ShowFooter = False
        Me.cmb_permission_type.Properties.ShowHeader = False
        Me.cmb_permission_type.Size = New System.Drawing.Size(400, 30)
        Me.cmb_permission_type.TabIndex = 1
        Me.cmb_permission_type.Tag = "Tipo de permiso"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_permission_type, ConditionValidationRule1)
        '
        'cmb_permission_position
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_permission_position, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_permission_position.Location = New System.Drawing.Point(210, 166)
        Me.cmb_permission_position.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_permission_position.Name = "cmb_permission_position"
        Me.cmb_permission_position.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_permission_position.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_position.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_position.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_permission_position.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_permission_position.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_permission_position.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_permission_position.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_permission_position.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_position.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_position.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_permission_position.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_permission_position.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_permission_position.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_position.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_position.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_permission_position.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_permission_position.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_permission_position.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_position.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_position.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_permission_position.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_permission_position.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_permission_position.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_position.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_position.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_permission_position.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_permission_position.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_permission_position.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_position.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_position.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_permission_position.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_permission_position.Properties.AutoHeight = False
        Me.cmb_permission_position.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_permission_position.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_permission_position.Properties.DropDownItemHeight = 30
        Me.cmb_permission_position.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_permission_position.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_permission_position.Properties.NullText = ""
        Me.cmb_permission_position.Properties.ShowFooter = False
        Me.cmb_permission_position.Properties.ShowHeader = False
        Me.cmb_permission_position.Size = New System.Drawing.Size(400, 30)
        Me.cmb_permission_position.TabIndex = 2
        Me.cmb_permission_position.Tag = "Tipo de atención"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_permission_position, ConditionValidationRule2)
        '
        'cmb_permission_person
        '
        Me.cmb_permission_person.EditValue = ""
        Me.xvp_validate.SetIconAlignment(Me.cmb_permission_person, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_permission_person.Location = New System.Drawing.Point(210, 166)
        Me.cmb_permission_person.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_permission_person.Name = "cmb_permission_person"
        Me.cmb_permission_person.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_permission_person.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_person.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_person.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_permission_person.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_permission_person.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_permission_person.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_permission_person.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_permission_person.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_person.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_person.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmb_permission_person.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_permission_person.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_permission_person.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmb_permission_person.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_permission_person.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_person.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_person.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.cmb_permission_person.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_permission_person.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_permission_person.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.cmb_permission_person.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_permission_person.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_person.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_person.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.cmb_permission_person.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_permission_person.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_permission_person.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmb_permission_person.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_permission_person.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_person.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_person.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.cmb_permission_person.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_permission_person.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_permission_person.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.cmb_permission_person.Properties.AutoHeight = False
        Me.cmb_permission_person.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_permission_person.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_permission_person.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_permission_person.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_permission_person.Properties.NullText = ""
        Me.cmb_permission_person.Properties.PopupView = Me.dgv_sales_customers
        Me.cmb_permission_person.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.cmb_permission_person.Size = New System.Drawing.Size(400, 30)
        Me.cmb_permission_person.TabIndex = 2
        Me.cmb_permission_person.Tag = "Registro"
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_permission_person, ConditionValidationRule3)
        '
        'dgv_sales_customers
        '
        Me.dgv_sales_customers.Appearance.GroupPanel.BackColor = System.Drawing.Color.White
        Me.dgv_sales_customers.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.dgv_sales_customers.Appearance.GroupPanel.BorderColor = System.Drawing.Color.White
        Me.dgv_sales_customers.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.dgv_sales_customers.Appearance.GroupPanel.Options.UseBackColor = True
        Me.dgv_sales_customers.Appearance.GroupPanel.Options.UseBorderColor = True
        Me.dgv_sales_customers.Appearance.GroupPanel.Options.UseForeColor = True
        Me.dgv_sales_customers.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_sales_customers.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_sales_customers.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_sales_customers.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.dgv_sales_customers.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.dgv_sales_customers.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.dgv_sales_customers.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.dgv_sales_customers.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.dgv_sales_customers.Name = "dgv_sales_customers"
        Me.dgv_sales_customers.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.dgv_sales_customers.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.dgv_sales_customers.OptionsView.ShowGroupPanel = False
        Me.dgv_sales_customers.OptionsView.ShowIndicator = False
        '
        'cmb_permission_module
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_permission_module, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_permission_module.Location = New System.Drawing.Point(210, 236)
        Me.cmb_permission_module.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_permission_module.Name = "cmb_permission_module"
        Me.cmb_permission_module.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_permission_module.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_module.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_module.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_permission_module.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_permission_module.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_permission_module.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_permission_module.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_permission_module.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_module.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_module.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_permission_module.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_permission_module.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_permission_module.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_module.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_module.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_permission_module.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_permission_module.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_permission_module.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_module.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_module.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_permission_module.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_permission_module.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_permission_module.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_module.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_module.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_permission_module.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_permission_module.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_permission_module.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_module.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_module.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_permission_module.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_permission_module.Properties.AutoHeight = False
        Me.cmb_permission_module.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_permission_module.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_permission_module.Properties.DropDownItemHeight = 30
        Me.cmb_permission_module.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_permission_module.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_permission_module.Properties.NullText = ""
        Me.cmb_permission_module.Properties.ShowFooter = False
        Me.cmb_permission_module.Properties.ShowHeader = False
        Me.cmb_permission_module.Size = New System.Drawing.Size(400, 30)
        Me.cmb_permission_module.TabIndex = 3
        Me.cmb_permission_module.Tag = "Modulo"
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_permission_module, ConditionValidationRule4)
        '
        'cmb_permission_option
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_permission_option, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_permission_option.Location = New System.Drawing.Point(210, 305)
        Me.cmb_permission_option.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_permission_option.Name = "cmb_permission_option"
        Me.cmb_permission_option.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_permission_option.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_option.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_option.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_permission_option.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_permission_option.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_permission_option.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_permission_option.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_permission_option.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_option.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_option.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_permission_option.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_permission_option.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_permission_option.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_option.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_option.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_permission_option.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_permission_option.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_permission_option.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_option.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_option.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_permission_option.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_permission_option.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_permission_option.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_option.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_option.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_permission_option.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_permission_option.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_permission_option.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_permission_option.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_permission_option.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_permission_option.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_permission_option.Properties.AutoHeight = False
        Me.cmb_permission_option.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_permission_option.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_permission_option.Properties.DropDownItemHeight = 30
        Me.cmb_permission_option.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_permission_option.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_permission_option.Properties.NullText = ""
        Me.cmb_permission_option.Properties.ShowFooter = False
        Me.cmb_permission_option.Properties.ShowHeader = False
        Me.cmb_permission_option.Size = New System.Drawing.Size(400, 30)
        Me.cmb_permission_option.TabIndex = 4
        Me.cmb_permission_option.Tag = "Opcion"
        ConditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule5.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_permission_option, ConditionValidationRule5)
        '
        'pnl_object_bottom
        '
        Me.pnl_object_bottom.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_bottom.Controls.Add(Me.btn_object_accept)
        Me.pnl_object_bottom.Controls.Add(Me.chk_keep_form)
        Me.pnl_object_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_object_bottom.Location = New System.Drawing.Point(1, 497)
        Me.pnl_object_bottom.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_bottom.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_bottom.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_bottom.Name = "pnl_object_bottom"
        Me.pnl_object_bottom.Padding = New System.Windows.Forms.Padding(1, 1, 30, 1)
        Me.pnl_object_bottom.Size = New System.Drawing.Size(1348, 52)
        Me.pnl_object_bottom.TabIndex = 0
        '
        'btn_object_accept
        '
        Me.btn_object_accept.BackColor = System.Drawing.Color.White
        Me.btn_object_accept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_accept.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_object_accept.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_accept.FlatAppearance.BorderSize = 0
        Me.btn_object_accept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_accept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_accept.Font = New System.Drawing.Font("Open Sans Condensed Light", 20.0!)
        Me.btn_object_accept.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btn_object_accept.Location = New System.Drawing.Point(1227, 1)
        Me.btn_object_accept.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_accept.Name = "btn_object_accept"
        Me.btn_object_accept.Size = New System.Drawing.Size(91, 50)
        Me.btn_object_accept.TabIndex = 0
        Me.btn_object_accept.TabStop = False
        Me.btn_object_accept.Text = "Aceptar"
        Me.btn_object_accept.UseVisualStyleBackColor = False
        '
        'chk_keep_form
        '
        Me.chk_keep_form.Location = New System.Drawing.Point(48, 18)
        Me.chk_keep_form.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_keep_form.Name = "chk_keep_form"
        Me.chk_keep_form.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.chk_keep_form.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.chk_keep_form.Properties.Appearance.BorderColor = System.Drawing.Color.White
        Me.chk_keep_form.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_keep_form.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.chk_keep_form.Properties.Appearance.Options.UseBackColor = True
        Me.chk_keep_form.Properties.Appearance.Options.UseBorderColor = True
        Me.chk_keep_form.Properties.Appearance.Options.UseFont = True
        Me.chk_keep_form.Properties.Appearance.Options.UseForeColor = True
        Me.chk_keep_form.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.chk_keep_form.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.chk_keep_form.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.White
        Me.chk_keep_form.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_keep_form.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.chk_keep_form.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.chk_keep_form.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.chk_keep_form.Properties.AppearanceDisabled.Options.UseFont = True
        Me.chk_keep_form.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.chk_keep_form.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.chk_keep_form.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.chk_keep_form.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.White
        Me.chk_keep_form.Properties.AppearanceFocused.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_keep_form.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.DimGray
        Me.chk_keep_form.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.chk_keep_form.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.chk_keep_form.Properties.AppearanceFocused.Options.UseFont = True
        Me.chk_keep_form.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.chk_keep_form.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.chk_keep_form.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.chk_keep_form.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White
        Me.chk_keep_form.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_keep_form.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.chk_keep_form.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.chk_keep_form.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.chk_keep_form.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.chk_keep_form.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.chk_keep_form.Properties.Caption = "Desea conservar el formulario?"
        Me.chk_keep_form.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chk_keep_form.Properties.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.chk_keep_form.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.chk_keep_form.Size = New System.Drawing.Size(174, 20)
        Me.chk_keep_form.TabIndex = 0
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.chk_object_conserve)
        Me.pnl_object_container.Controls.Add(Me.lbl_permission_assigned)
        Me.pnl_object_container.Controls.Add(Me.lbl_permission_actions)
        Me.pnl_object_container.Controls.Add(Me.lbc_permission_assigned)
        Me.pnl_object_container.Controls.Add(Me.lbc_permission_actions)
        Me.pnl_object_container.Controls.Add(Me.cmb_permission_option)
        Me.pnl_object_container.Controls.Add(Me.lbl_permission_option)
        Me.pnl_object_container.Controls.Add(Me.cmb_permission_module)
        Me.pnl_object_container.Controls.Add(Me.lbl_permission_module)
        Me.pnl_object_container.Controls.Add(Me.cmb_permission_person)
        Me.pnl_object_container.Controls.Add(Me.cmb_permission_position)
        Me.pnl_object_container.Controls.Add(Me.lbl_permission_affected)
        Me.pnl_object_container.Controls.Add(Me.cmb_permission_type)
        Me.pnl_object_container.Controls.Add(Me.lbl_permission_type)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 76)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_container.Size = New System.Drawing.Size(1348, 421)
        Me.pnl_object_container.TabIndex = 0
        '
        'chk_object_conserve
        '
        Me.chk_object_conserve.Location = New System.Drawing.Point(917, 338)
        Me.chk_object_conserve.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_object_conserve.Name = "chk_object_conserve"
        Me.chk_object_conserve.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.chk_object_conserve.Properties.Appearance.Options.UseForeColor = True
        Me.chk_object_conserve.Properties.Caption = "Desea conservar la estructura del permiso?"
        Me.chk_object_conserve.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chk_object_conserve.Properties.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.chk_object_conserve.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.chk_object_conserve.Size = New System.Drawing.Size(231, 20)
        Me.chk_object_conserve.TabIndex = 7
        Me.chk_object_conserve.Tag = "Finalizar Gestión"
        '
        'lbl_permission_assigned
        '
        Me.lbl_permission_assigned.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_permission_assigned.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_permission_assigned.Appearance.Options.UseFont = True
        Me.lbl_permission_assigned.Appearance.Options.UseForeColor = True
        Me.lbl_permission_assigned.Location = New System.Drawing.Point(745, 216)
        Me.lbl_permission_assigned.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_permission_assigned.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_permission_assigned.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_permission_assigned.Name = "lbl_permission_assigned"
        Me.lbl_permission_assigned.Size = New System.Drawing.Size(98, 16)
        Me.lbl_permission_assigned.TabIndex = 7
        Me.lbl_permission_assigned.Text = "Permisos asignados*"
        '
        'lbl_permission_actions
        '
        Me.lbl_permission_actions.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_permission_actions.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_permission_actions.Appearance.Options.UseFont = True
        Me.lbl_permission_actions.Appearance.Options.UseForeColor = True
        Me.lbl_permission_actions.Location = New System.Drawing.Point(745, 77)
        Me.lbl_permission_actions.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_permission_actions.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_permission_actions.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_permission_actions.Name = "lbl_permission_actions"
        Me.lbl_permission_actions.Size = New System.Drawing.Size(163, 16)
        Me.lbl_permission_actions.TabIndex = 0
        Me.lbl_permission_actions.Text = "Seleccione los permisos a asignar*"
        '
        'lbc_permission_assigned
        '
        Me.lbc_permission_assigned.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbc_permission_assigned.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbc_permission_assigned.Appearance.Options.UseBorderColor = True
        Me.lbc_permission_assigned.Appearance.Options.UseForeColor = True
        Me.lbc_permission_assigned.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbc_permission_assigned.AppearanceDisabled.Options.UseBorderColor = True
        Me.lbc_permission_assigned.AppearanceHighlight.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbc_permission_assigned.AppearanceHighlight.Options.UseBorderColor = True
        Me.lbc_permission_assigned.AppearanceSelected.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbc_permission_assigned.AppearanceSelected.Options.UseBorderColor = True
        Me.lbc_permission_assigned.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lbc_permission_assigned.Location = New System.Drawing.Point(745, 236)
        Me.lbc_permission_assigned.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbc_permission_assigned.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbc_permission_assigned.Margin = New System.Windows.Forms.Padding(0)
        Me.lbc_permission_assigned.Name = "lbc_permission_assigned"
        Me.lbc_permission_assigned.Padding = New System.Windows.Forms.Padding(1)
        Me.lbc_permission_assigned.Size = New System.Drawing.Size(400, 99)
        Me.lbc_permission_assigned.TabIndex = 6
        '
        'lbc_permission_actions
        '
        Me.lbc_permission_actions.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbc_permission_actions.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbc_permission_actions.Appearance.Options.UseBorderColor = True
        Me.lbc_permission_actions.Appearance.Options.UseForeColor = True
        Me.lbc_permission_actions.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbc_permission_actions.AppearanceDisabled.Options.UseBorderColor = True
        Me.lbc_permission_actions.AppearanceHighlight.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbc_permission_actions.AppearanceHighlight.Options.UseBorderColor = True
        Me.lbc_permission_actions.AppearanceSelected.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbc_permission_actions.AppearanceSelected.Options.UseBorderColor = True
        Me.lbc_permission_actions.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lbc_permission_actions.Location = New System.Drawing.Point(745, 97)
        Me.lbc_permission_actions.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbc_permission_actions.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbc_permission_actions.Margin = New System.Windows.Forms.Padding(0)
        Me.lbc_permission_actions.Name = "lbc_permission_actions"
        Me.lbc_permission_actions.Padding = New System.Windows.Forms.Padding(1)
        Me.lbc_permission_actions.Size = New System.Drawing.Size(400, 99)
        Me.lbc_permission_actions.TabIndex = 5
        '
        'lbl_permission_option
        '
        Me.lbl_permission_option.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_permission_option.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_permission_option.Appearance.Options.UseFont = True
        Me.lbl_permission_option.Appearance.Options.UseForeColor = True
        Me.lbl_permission_option.Location = New System.Drawing.Point(210, 285)
        Me.lbl_permission_option.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_permission_option.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_permission_option.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_permission_option.Name = "lbl_permission_option"
        Me.lbl_permission_option.Size = New System.Drawing.Size(259, 16)
        Me.lbl_permission_option.TabIndex = 0
        Me.lbl_permission_option.Text = "Seleccione la opción del modulo relacionado a asignar*"
        '
        'lbl_permission_module
        '
        Me.lbl_permission_module.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_permission_module.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_permission_module.Appearance.Options.UseFont = True
        Me.lbl_permission_module.Appearance.Options.UseForeColor = True
        Me.lbl_permission_module.Location = New System.Drawing.Point(210, 216)
        Me.lbl_permission_module.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_permission_module.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_permission_module.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_permission_module.Name = "lbl_permission_module"
        Me.lbl_permission_module.Size = New System.Drawing.Size(206, 16)
        Me.lbl_permission_module.TabIndex = 0
        Me.lbl_permission_module.Text = "Seleccione el nombre del modulo a asignar*"
        '
        'lbl_permission_affected
        '
        Me.lbl_permission_affected.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_permission_affected.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_permission_affected.Appearance.Options.UseFont = True
        Me.lbl_permission_affected.Appearance.Options.UseForeColor = True
        Me.lbl_permission_affected.Location = New System.Drawing.Point(210, 146)
        Me.lbl_permission_affected.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_permission_affected.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_permission_affected.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_permission_affected.Name = "lbl_permission_affected"
        Me.lbl_permission_affected.Size = New System.Drawing.Size(207, 16)
        Me.lbl_permission_affected.TabIndex = 0
        Me.lbl_permission_affected.Text = "Seleccione el nombre del registro a asignar*"
        '
        'lbl_permission_type
        '
        Me.lbl_permission_type.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_permission_type.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_permission_type.Appearance.Options.UseFont = True
        Me.lbl_permission_type.Appearance.Options.UseForeColor = True
        Me.lbl_permission_type.Location = New System.Drawing.Point(210, 77)
        Me.lbl_permission_type.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_permission_type.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_permission_type.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_permission_type.Name = "lbl_permission_type"
        Me.lbl_permission_type.Size = New System.Drawing.Size(140, 16)
        Me.lbl_permission_type.TabIndex = 0
        Me.lbl_permission_type.Text = "Seleccione el tipo de permiso*"
        '
        'settings_permission_created
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnl_object_container)
        Me.Controls.Add(Me.pnl_object_bottom)
        Me.Controls.Add(Me.pnl_object_top)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "settings_permission_created"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(1350, 550)
        Me.Tag = "Crear Permiso"
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_top.ResumeLayout(False)
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_permission_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_permission_position.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_permission_person.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_sales_customers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_permission_module.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_permission_option.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_bottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_bottom.ResumeLayout(False)
        CType(Me.chk_keep_form.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        CType(Me.chk_object_conserve.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbc_permission_assigned, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbc_permission_actions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_object_top As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_object_info As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_refresh As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_cancel As Button
    Friend WithEvents xvp_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents pnl_object_bottom As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_object_accept As Button
    Protected WithEvents chk_keep_form As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmb_permission_type As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_permission_type As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_permission_position As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_permission_affected As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_permission_option As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_permission_option As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_permission_module As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_permission_module As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_permission_person As APDA.Object.Controls.ComboboxSearch
    Friend WithEvents dgv_sales_customers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbl_permission_assigned As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_permission_actions As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbc_permission_assigned As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents lbc_permission_actions As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents chk_object_conserve As APDA.Object.Controls.TextboxCheck
End Class
