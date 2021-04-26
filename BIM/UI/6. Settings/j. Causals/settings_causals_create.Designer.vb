<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class settings_causals_create
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
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings_causals_create))
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.txt_causal_name = New APDA.[Object].Controls.TextboxEdit()
        Me.cmb_causal_module = New APDA.[Object].Controls.ComboboxEdit()
        Me.txt_causal_acronym = New APDA.[Object].Controls.TextboxEdit()
        Me.txt_datacredit_description = New APDA.[Object].Controls.TextboxMemo()
        Me.cmb_causal_type = New APDA.[Object].Controls.ComboboxEdit()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_datacredit__description = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_causal_acronym = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_causal_type = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_causal_module = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.chk_keep_form = New DevExpress.XtraEditors.CheckEdit()
        Me.lbl_causal_name = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_causal_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_causal_module.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_causal_acronym.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_datacredit_description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_causal_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        CType(Me.chk_keep_form.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xvp_validate
        '
        Me.xvp_validate.ValidateHiddenControls = False
        Me.xvp_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'txt_causal_name
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_causal_name, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_causal_name.Location = New System.Drawing.Point(41, 164)
        Me.txt_causal_name.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_causal_name.Name = "txt_causal_name"
        Me.txt_causal_name.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_causal_name.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_causal_name.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_causal_name.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_causal_name.Properties.Appearance.Options.UseBackColor = True
        Me.txt_causal_name.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_causal_name.Properties.Appearance.Options.UseForeColor = True
        Me.txt_causal_name.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_causal_name.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_causal_name.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_causal_name.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_causal_name.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_causal_name.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_causal_name.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_causal_name.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_causal_name.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_causal_name.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_causal_name.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_causal_name.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_causal_name.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_causal_name.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_causal_name.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_causal_name.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_causal_name.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_causal_name.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_causal_name.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_causal_name.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_causal_name.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_causal_name.Properties.AutoHeight = False
        Me.txt_causal_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_causal_name.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_causal_name.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_causal_name.Size = New System.Drawing.Size(360, 30)
        Me.txt_causal_name.TabIndex = 1
        Me.txt_causal_name.Tag = "Nombre de causal"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_causal_name, ConditionValidationRule1)
        '
        'cmb_causal_module
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_causal_module, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_causal_module.Location = New System.Drawing.Point(41, 228)
        Me.cmb_causal_module.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_causal_module.Name = "cmb_causal_module"
        Me.cmb_causal_module.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_causal_module.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_causal_module.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_causal_module.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_causal_module.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_causal_module.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_causal_module.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_causal_module.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_causal_module.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_causal_module.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_causal_module.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_causal_module.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_causal_module.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_causal_module.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_causal_module.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_causal_module.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_causal_module.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_causal_module.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_causal_module.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_causal_module.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_causal_module.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_causal_module.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_causal_module.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_causal_module.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_causal_module.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_causal_module.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_causal_module.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_causal_module.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_causal_module.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_causal_module.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_causal_module.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_causal_module.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_causal_module.Properties.AutoHeight = False
        Me.cmb_causal_module.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_causal_module.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_causal_module.Properties.DropDownItemHeight = 30
        Me.cmb_causal_module.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_causal_module.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_causal_module.Properties.NullText = ""
        Me.cmb_causal_module.Properties.ShowFooter = False
        Me.cmb_causal_module.Properties.ShowHeader = False
        Me.cmb_causal_module.Size = New System.Drawing.Size(360, 30)
        Me.cmb_causal_module.TabIndex = 3
        Me.cmb_causal_module.Tag = "Modulo"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_causal_module, ConditionValidationRule2)
        '
        'txt_causal_acronym
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_causal_acronym, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_causal_acronym.Location = New System.Drawing.Point(230, 292)
        Me.txt_causal_acronym.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_causal_acronym.Name = "txt_causal_acronym"
        Me.txt_causal_acronym.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_causal_acronym.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_causal_acronym.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_causal_acronym.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_causal_acronym.Properties.Appearance.Options.UseBackColor = True
        Me.txt_causal_acronym.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_causal_acronym.Properties.Appearance.Options.UseForeColor = True
        Me.txt_causal_acronym.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_causal_acronym.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_causal_acronym.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_causal_acronym.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_causal_acronym.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_causal_acronym.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_causal_acronym.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_causal_acronym.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_causal_acronym.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_causal_acronym.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_causal_acronym.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_causal_acronym.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_causal_acronym.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_causal_acronym.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_causal_acronym.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_causal_acronym.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_causal_acronym.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_causal_acronym.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_causal_acronym.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_causal_acronym.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_causal_acronym.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_causal_acronym.Properties.AutoHeight = False
        Me.txt_causal_acronym.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_causal_acronym.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_causal_acronym.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_causal_acronym.Size = New System.Drawing.Size(171, 30)
        Me.txt_causal_acronym.TabIndex = 5
        Me.txt_causal_acronym.Tag = "Acrónimo"
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_causal_acronym, ConditionValidationRule3)
        '
        'txt_datacredit_description
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_datacredit_description, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_datacredit_description.Location = New System.Drawing.Point(455, 164)
        Me.txt_datacredit_description.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_datacredit_description.Name = "txt_datacredit_description"
        Me.txt_datacredit_description.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_datacredit_description.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_datacredit_description.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_datacredit_description.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_datacredit_description.Properties.Appearance.Options.UseBackColor = True
        Me.txt_datacredit_description.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_datacredit_description.Properties.Appearance.Options.UseForeColor = True
        Me.txt_datacredit_description.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_datacredit_description.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_datacredit_description.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_datacredit_description.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_datacredit_description.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_datacredit_description.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_datacredit_description.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_datacredit_description.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_datacredit_description.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_datacredit_description.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_datacredit_description.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_datacredit_description.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_datacredit_description.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_datacredit_description.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_datacredit_description.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_datacredit_description.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_datacredit_description.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_datacredit_description.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_datacredit_description.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_datacredit_description.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_datacredit_description.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_datacredit_description.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_datacredit_description.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_datacredit_description.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_datacredit_description.Properties.MaxLength = 300
        Me.txt_datacredit_description.Size = New System.Drawing.Size(368, 167)
        Me.txt_datacredit_description.TabIndex = 6
        Me.txt_datacredit_description.Tag = "Descripción"
        '
        'cmb_causal_type
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_causal_type, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_causal_type.Location = New System.Drawing.Point(40, 292)
        Me.cmb_causal_type.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_causal_type.Name = "cmb_causal_type"
        Me.cmb_causal_type.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_causal_type.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_causal_type.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_causal_type.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_causal_type.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_causal_type.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_causal_type.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_causal_type.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_causal_type.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_causal_type.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_causal_type.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_causal_type.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_causal_type.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_causal_type.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_causal_type.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_causal_type.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_causal_type.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_causal_type.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_causal_type.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_causal_type.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_causal_type.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_causal_type.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_causal_type.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_causal_type.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_causal_type.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_causal_type.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_causal_type.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_causal_type.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_causal_type.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_causal_type.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_causal_type.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_causal_type.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_causal_type.Properties.AutoHeight = False
        Me.cmb_causal_type.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_causal_type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_causal_type.Properties.DropDownItemHeight = 30
        Me.cmb_causal_type.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_causal_type.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_causal_type.Properties.NullText = ""
        Me.cmb_causal_type.Properties.ShowFooter = False
        Me.cmb_causal_type.Properties.ShowHeader = False
        Me.cmb_causal_type.Size = New System.Drawing.Size(181, 30)
        Me.cmb_causal_type.TabIndex = 4
        Me.cmb_causal_type.Tag = "Modulo"
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_causal_type, ConditionValidationRule4)
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.cmb_causal_type)
        Me.pnl_object_container.Controls.Add(Me.txt_datacredit_description)
        Me.pnl_object_container.Controls.Add(Me.lbl_datacredit__description)
        Me.pnl_object_container.Controls.Add(Me.lbl_causal_acronym)
        Me.pnl_object_container.Controls.Add(Me.txt_causal_acronym)
        Me.pnl_object_container.Controls.Add(Me.lbl_causal_type)
        Me.pnl_object_container.Controls.Add(Me.lbl_causal_module)
        Me.pnl_object_container.Controls.Add(Me.cmb_causal_module)
        Me.pnl_object_container.Controls.Add(Me.btn_object_cancel)
        Me.pnl_object_container.Controls.Add(Me.chk_keep_form)
        Me.pnl_object_container.Controls.Add(Me.lbl_causal_name)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_title)
        Me.pnl_object_container.Controls.Add(Me.btn_object_accept)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_info)
        Me.pnl_object_container.Controls.Add(Me.txt_causal_name)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 1)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_container.Size = New System.Drawing.Size(860, 475)
        Me.pnl_object_container.TabIndex = 0
        '
        'lbl_datacredit__description
        '
        Me.lbl_datacredit__description.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datacredit__description.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_datacredit__description.Appearance.Options.UseFont = True
        Me.lbl_datacredit__description.Appearance.Options.UseForeColor = True
        Me.lbl_datacredit__description.Location = New System.Drawing.Point(455, 144)
        Me.lbl_datacredit__description.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_datacredit__description.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_datacredit__description.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_datacredit__description.Name = "lbl_datacredit__description"
        Me.lbl_datacredit__description.Size = New System.Drawing.Size(148, 16)
        Me.lbl_datacredit__description.TabIndex = 9
        Me.lbl_datacredit__description.Text = "Observaciones y/o comentarios"
        '
        'lbl_causal_acronym
        '
        Me.lbl_causal_acronym.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_causal_acronym.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_causal_acronym.Appearance.Options.UseFont = True
        Me.lbl_causal_acronym.Appearance.Options.UseForeColor = True
        Me.lbl_causal_acronym.Location = New System.Drawing.Point(230, 272)
        Me.lbl_causal_acronym.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_causal_acronym.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_causal_acronym.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_causal_acronym.Name = "lbl_causal_acronym"
        Me.lbl_causal_acronym.Size = New System.Drawing.Size(48, 16)
        Me.lbl_causal_acronym.TabIndex = 0
        Me.lbl_causal_acronym.Text = "Acrónimo*"
        '
        'lbl_causal_type
        '
        Me.lbl_causal_type.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_causal_type.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_causal_type.Appearance.Options.UseFont = True
        Me.lbl_causal_type.Appearance.Options.UseForeColor = True
        Me.lbl_causal_type.Location = New System.Drawing.Point(40, 272)
        Me.lbl_causal_type.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_causal_type.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_causal_type.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_causal_type.Name = "lbl_causal_type"
        Me.lbl_causal_type.Size = New System.Drawing.Size(73, 16)
        Me.lbl_causal_type.TabIndex = 0
        Me.lbl_causal_type.Text = "Tipo de causal*"
        '
        'lbl_causal_module
        '
        Me.lbl_causal_module.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_causal_module.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_causal_module.Appearance.Options.UseFont = True
        Me.lbl_causal_module.Appearance.Options.UseForeColor = True
        Me.lbl_causal_module.Location = New System.Drawing.Point(41, 208)
        Me.lbl_causal_module.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_causal_module.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_causal_module.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_causal_module.Name = "lbl_causal_module"
        Me.lbl_causal_module.Size = New System.Drawing.Size(39, 16)
        Me.lbl_causal_module.TabIndex = 0
        Me.lbl_causal_module.Text = "Modulo*"
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
        Me.btn_object_cancel.Location = New System.Drawing.Point(828, 3)
        Me.btn_object_cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_cancel.Name = "btn_object_cancel"
        Me.btn_object_cancel.Size = New System.Drawing.Size(28, 31)
        Me.btn_object_cancel.TabIndex = 0
        Me.btn_object_cancel.TabStop = False
        Me.btn_object_cancel.Text = "X"
        Me.btn_object_cancel.UseVisualStyleBackColor = False
        '
        'chk_keep_form
        '
        Me.chk_keep_form.EditValue = True
        Me.chk_keep_form.Location = New System.Drawing.Point(651, 334)
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
        Me.chk_keep_form.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chk_keep_form.Properties.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.chk_keep_form.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.chk_keep_form.Size = New System.Drawing.Size(170, 20)
        Me.chk_keep_form.TabIndex = 0
        '
        'lbl_causal_name
        '
        Me.lbl_causal_name.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_causal_name.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_causal_name.Appearance.Options.UseFont = True
        Me.lbl_causal_name.Appearance.Options.UseForeColor = True
        Me.lbl_causal_name.Location = New System.Drawing.Point(41, 144)
        Me.lbl_causal_name.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_causal_name.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_causal_name.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_causal_name.Name = "lbl_causal_name"
        Me.lbl_causal_name.Size = New System.Drawing.Size(143, 16)
        Me.lbl_causal_name.TabIndex = 0
        Me.lbl_causal_name.Text = "Defina el nombre de la causal*"
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
        Me.lbl_object_title.Size = New System.Drawing.Size(115, 38)
        Me.lbl_object_title.TabIndex = 0
        Me.lbl_object_title.Text = "Crear Causal"
        '
        'btn_object_accept
        '
        Me.btn_object_accept.BackColor = System.Drawing.Color.White
        Me.btn_object_accept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_accept.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_accept.FlatAppearance.BorderSize = 0
        Me.btn_object_accept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_accept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_accept.Font = New System.Drawing.Font("Open Sans Condensed Light", 20.0!)
        Me.btn_object_accept.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btn_object_accept.Location = New System.Drawing.Point(758, 421)
        Me.btn_object_accept.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_accept.Name = "btn_object_accept"
        Me.btn_object_accept.Size = New System.Drawing.Size(98, 49)
        Me.btn_object_accept.TabIndex = 0
        Me.btn_object_accept.TabStop = False
        Me.btn_object_accept.Text = "Aceptar"
        Me.btn_object_accept.UseVisualStyleBackColor = False
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
        'settings_causals_create
        '
        Me.AcceptButton = Me.btn_object_accept
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.BackColor2 = System.Drawing.Color.White
        Me.Appearance.BorderColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseBorderColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.btn_object_cancel
        Me.ClientSize = New System.Drawing.Size(862, 477)
        Me.Controls.Add(Me.pnl_object_container)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IconOptions.Icon = CType(resources.GetObject("settings_causals_create.IconOptions.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Office 2019 White"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "settings_causals_create"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Crear Causal"
        Me.TopMost = True
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_causal_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_causal_module.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_causal_acronym.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_datacredit_description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_causal_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        CType(Me.chk_keep_form.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents xvp_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_object_cancel As Button
    Protected WithEvents chk_keep_form As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lbl_causal_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_accept As Button
    Friend WithEvents lbl_object_info As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_causal_name As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_causal_module As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_causal_module As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_causal_type As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_causal_acronym As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_causal_acronym As APDA.Object.Controls.TextboxEdit
    Friend WithEvents txt_datacredit_description As APDA.Object.Controls.TextboxMemo
    Friend WithEvents lbl_datacredit__description As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_causal_type As APDA.Object.Controls.ComboboxEdit
End Class
