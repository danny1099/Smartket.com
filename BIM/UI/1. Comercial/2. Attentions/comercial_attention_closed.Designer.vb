<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comercial_attention_closed
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
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(comercial_attention_closed))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim OptionsSpelling1 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
        Dim ConditionValidationRule5 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim HunspellDictionary1 As DevExpress.XtraSpellChecker.HunspellDictionary = New DevExpress.XtraSpellChecker.HunspellDictionary()
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.txt_attention_ticket = New APDA.[Object].Controls.TextboxEdit()
        Me.txt_attention_date = New APDA.[Object].Controls.TextboxDates()
        Me.cmb_attention_causal = New APDA.[Object].Controls.ComboboxEdit()
        Me.txt_attention_quotation = New APDA.[Object].Controls.TextboxEdit()
        Me.txt_attention_description = New DevExpress.XtraEditors.MemoEdit()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_attention_quotation = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_attention_theme = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_attention_created = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_attention_ticket = New DevExpress.XtraEditors.LabelControl()
        Me.chk_row_visible = New DevExpress.XtraEditors.CheckEdit()
        Me.lbl_object_caracters = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.lbl_reject_description = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        Me.xvp_spell = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_attention_ticket.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_attention_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_attention_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_attention_causal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_attention_quotation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_attention_description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        CType(Me.chk_row_visible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xvp_validate
        '
        Me.xvp_validate.ValidateHiddenControls = False
        Me.xvp_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'txt_attention_ticket
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_attention_ticket, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_attention_ticket.Location = New System.Drawing.Point(40, 169)
        Me.txt_attention_ticket.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_attention_ticket.Name = "txt_attention_ticket"
        Me.txt_attention_ticket.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_attention_ticket.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_attention_ticket.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_attention_ticket.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_attention_ticket.Properties.Appearance.Options.UseBackColor = True
        Me.txt_attention_ticket.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_attention_ticket.Properties.Appearance.Options.UseForeColor = True
        Me.txt_attention_ticket.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_attention_ticket.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_attention_ticket.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_attention_ticket.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_attention_ticket.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_attention_ticket.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_attention_ticket.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_attention_ticket.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_attention_ticket.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_attention_ticket.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_attention_ticket.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_attention_ticket.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_attention_ticket.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_attention_ticket.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_attention_ticket.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_attention_ticket.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_attention_ticket.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_attention_ticket.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_attention_ticket.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_attention_ticket.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_attention_ticket.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_attention_ticket.Properties.AutoHeight = False
        Me.txt_attention_ticket.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_attention_ticket.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_attention_ticket.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_attention_ticket.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_attention_ticket.Properties.Mask.BeepOnError = True
        Me.txt_attention_ticket.Properties.MaskSettings.Set("mask", "(2) \d\d\d-\d\d\d\d")
        Me.txt_attention_ticket.Properties.ReadOnly = True
        Me.txt_attention_ticket.Size = New System.Drawing.Size(350, 30)
        Me.txt_attention_ticket.TabIndex = 0
        Me.txt_attention_ticket.Tag = "Tipo de ticket"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_attention_ticket, ConditionValidationRule1)
        '
        'txt_attention_date
        '
        Me.txt_attention_date.EditValue = New Date(2021, 1, 3, 15, 2, 10, 311)
        Me.xvp_validate.SetIconAlignment(Me.txt_attention_date, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_attention_date.Location = New System.Drawing.Point(41, 233)
        Me.txt_attention_date.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_attention_date.Name = "txt_attention_date"
        Me.txt_attention_date.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_attention_date.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_attention_date.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_attention_date.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_attention_date.Properties.Appearance.Options.UseBackColor = True
        Me.txt_attention_date.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_attention_date.Properties.Appearance.Options.UseForeColor = True
        Me.txt_attention_date.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_attention_date.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_attention_date.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_attention_date.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_attention_date.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_attention_date.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_attention_date.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_attention_date.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.txt_attention_date.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.txt_attention_date.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txt_attention_date.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.txt_attention_date.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.txt_attention_date.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.txt_attention_date.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.txt_attention_date.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_attention_date.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_attention_date.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_attention_date.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_attention_date.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_attention_date.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_attention_date.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_attention_date.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_attention_date.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_attention_date.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_attention_date.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_attention_date.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_attention_date.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_attention_date.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_attention_date.Properties.AutoHeight = False
        Me.txt_attention_date.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txt_attention_date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_attention_date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_attention_date.Properties.DisplayFormat.FormatString = "G"
        Me.txt_attention_date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_attention_date.Properties.EditFormat.FormatString = "G"
        Me.txt_attention_date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_attention_date.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_attention_date.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_attention_date.Properties.MaskSettings.Set("mask", "G")
        Me.txt_attention_date.Properties.ReadOnly = True
        Me.txt_attention_date.Size = New System.Drawing.Size(166, 30)
        Me.txt_attention_date.TabIndex = 0
        Me.txt_attention_date.Tag = "Fecha de creación"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_attention_date, ConditionValidationRule2)
        '
        'cmb_attention_causal
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_attention_causal, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_attention_causal.Location = New System.Drawing.Point(40, 297)
        Me.cmb_attention_causal.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_attention_causal.Name = "cmb_attention_causal"
        Me.cmb_attention_causal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_attention_causal.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_causal.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_causal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_attention_causal.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_attention_causal.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_attention_causal.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_attention_causal.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_attention_causal.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_causal.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_causal.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_attention_causal.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_attention_causal.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_attention_causal.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_causal.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_causal.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_attention_causal.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_attention_causal.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_attention_causal.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_causal.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_causal.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_attention_causal.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_attention_causal.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_attention_causal.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_causal.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_causal.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_attention_causal.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_attention_causal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_attention_causal.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_causal.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_causal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_attention_causal.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_attention_causal.Properties.AutoHeight = False
        Me.cmb_attention_causal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_attention_causal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_attention_causal.Properties.DropDownItemHeight = 30
        Me.cmb_attention_causal.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_attention_causal.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_attention_causal.Properties.NullText = ""
        Me.cmb_attention_causal.Properties.ShowFooter = False
        Me.cmb_attention_causal.Properties.ShowHeader = False
        Me.cmb_attention_causal.Size = New System.Drawing.Size(350, 30)
        Me.cmb_attention_causal.TabIndex = 1
        Me.cmb_attention_causal.Tag = "Causal de cierre"
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_attention_causal, ConditionValidationRule3)
        '
        'txt_attention_quotation
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_attention_quotation, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_attention_quotation.Location = New System.Drawing.Point(214, 233)
        Me.txt_attention_quotation.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_attention_quotation.Name = "txt_attention_quotation"
        Me.txt_attention_quotation.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_attention_quotation.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_attention_quotation.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_attention_quotation.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_attention_quotation.Properties.Appearance.Options.UseBackColor = True
        Me.txt_attention_quotation.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_attention_quotation.Properties.Appearance.Options.UseForeColor = True
        Me.txt_attention_quotation.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_attention_quotation.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_attention_quotation.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_attention_quotation.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_attention_quotation.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_attention_quotation.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_attention_quotation.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_attention_quotation.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_attention_quotation.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_attention_quotation.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_attention_quotation.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_attention_quotation.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_attention_quotation.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_attention_quotation.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_attention_quotation.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_attention_quotation.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_attention_quotation.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_attention_quotation.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_attention_quotation.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_attention_quotation.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_attention_quotation.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_attention_quotation.Properties.AutoHeight = False
        Me.txt_attention_quotation.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_attention_quotation.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_attention_quotation.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_attention_quotation.Properties.Mask.BeepOnError = True
        Me.txt_attention_quotation.Properties.MaskSettings.Set("mask", "(2) \d\d\d-\d\d\d\d")
        Me.txt_attention_quotation.Properties.ReadOnly = True
        Me.txt_attention_quotation.Size = New System.Drawing.Size(176, 30)
        Me.txt_attention_quotation.TabIndex = 0
        Me.txt_attention_quotation.Tag = "Cotizaciones"
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_attention_quotation, ConditionValidationRule4)
        '
        'txt_attention_description
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_attention_description, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_attention_description.Location = New System.Drawing.Point(455, 169)
        Me.txt_attention_description.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_attention_description.Name = "txt_attention_description"
        Me.txt_attention_description.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_attention_description.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_attention_description.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_attention_description.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_attention_description.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_attention_description.Properties.Appearance.Options.UseBackColor = True
        Me.txt_attention_description.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_attention_description.Properties.Appearance.Options.UseFont = True
        Me.txt_attention_description.Properties.Appearance.Options.UseForeColor = True
        Me.txt_attention_description.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_attention_description.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_attention_description.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.xvp_spell.SetShowSpellCheckMenu(Me.txt_attention_description, True)
        Me.txt_attention_description.Size = New System.Drawing.Size(380, 166)
        Me.xvp_spell.SetSpellCheckerOptions(Me.txt_attention_description, OptionsSpelling1)
        Me.txt_attention_description.TabIndex = 2
        Me.txt_attention_description.Tag = "Motivo de finalización"
        ConditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule5.ErrorText = "This value is not valid"
        Me.xvp_validate.SetValidationRule(Me.txt_attention_description, ConditionValidationRule5)
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.lbl_attention_quotation)
        Me.pnl_object_container.Controls.Add(Me.txt_attention_quotation)
        Me.pnl_object_container.Controls.Add(Me.cmb_attention_causal)
        Me.pnl_object_container.Controls.Add(Me.lbl_attention_theme)
        Me.pnl_object_container.Controls.Add(Me.lbl_attention_created)
        Me.pnl_object_container.Controls.Add(Me.txt_attention_date)
        Me.pnl_object_container.Controls.Add(Me.lbl_attention_ticket)
        Me.pnl_object_container.Controls.Add(Me.txt_attention_ticket)
        Me.pnl_object_container.Controls.Add(Me.chk_row_visible)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_caracters)
        Me.pnl_object_container.Controls.Add(Me.btn_object_cancel)
        Me.pnl_object_container.Controls.Add(Me.lbl_reject_description)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_title)
        Me.pnl_object_container.Controls.Add(Me.btn_object_accept)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_info)
        Me.pnl_object_container.Controls.Add(Me.txt_attention_description)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 1)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_container.Size = New System.Drawing.Size(880, 476)
        Me.pnl_object_container.TabIndex = 0
        '
        'lbl_attention_quotation
        '
        Me.lbl_attention_quotation.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_attention_quotation.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_attention_quotation.Appearance.Options.UseFont = True
        Me.lbl_attention_quotation.Appearance.Options.UseForeColor = True
        Me.lbl_attention_quotation.Location = New System.Drawing.Point(214, 213)
        Me.lbl_attention_quotation.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_attention_quotation.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_attention_quotation.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_attention_quotation.Name = "lbl_attention_quotation"
        Me.lbl_attention_quotation.Size = New System.Drawing.Size(63, 16)
        Me.lbl_attention_quotation.TabIndex = 0
        Me.lbl_attention_quotation.Text = "Cotizaciones*"
        '
        'lbl_attention_theme
        '
        Me.lbl_attention_theme.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_attention_theme.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_attention_theme.Appearance.Options.UseFont = True
        Me.lbl_attention_theme.Appearance.Options.UseForeColor = True
        Me.lbl_attention_theme.Location = New System.Drawing.Point(40, 277)
        Me.lbl_attention_theme.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_attention_theme.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_attention_theme.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_attention_theme.Name = "lbl_attention_theme"
        Me.lbl_attention_theme.Size = New System.Drawing.Size(155, 16)
        Me.lbl_attention_theme.TabIndex = 0
        Me.lbl_attention_theme.Text = "Defina el tipo de gestión relizada*"
        '
        'lbl_attention_created
        '
        Me.lbl_attention_created.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_attention_created.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_attention_created.Appearance.Options.UseFont = True
        Me.lbl_attention_created.Appearance.Options.UseForeColor = True
        Me.lbl_attention_created.Location = New System.Drawing.Point(41, 213)
        Me.lbl_attention_created.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_attention_created.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_attention_created.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_attention_created.Name = "lbl_attention_created"
        Me.lbl_attention_created.Size = New System.Drawing.Size(92, 16)
        Me.lbl_attention_created.TabIndex = 0
        Me.lbl_attention_created.Text = "Fecha de creación*"
        '
        'lbl_attention_ticket
        '
        Me.lbl_attention_ticket.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_attention_ticket.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_attention_ticket.Appearance.Options.UseFont = True
        Me.lbl_attention_ticket.Appearance.Options.UseForeColor = True
        Me.lbl_attention_ticket.Location = New System.Drawing.Point(40, 149)
        Me.lbl_attention_ticket.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_attention_ticket.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_attention_ticket.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_attention_ticket.Name = "lbl_attention_ticket"
        Me.lbl_attention_ticket.Size = New System.Drawing.Size(140, 16)
        Me.lbl_attention_ticket.TabIndex = 0
        Me.lbl_attention_ticket.Text = "Número de gestión comercial*"
        '
        'chk_row_visible
        '
        Me.chk_row_visible.EditValue = True
        Me.chk_row_visible.Location = New System.Drawing.Point(625, 338)
        Me.chk_row_visible.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_row_visible.Name = "chk_row_visible"
        Me.chk_row_visible.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.chk_row_visible.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.chk_row_visible.Properties.Appearance.BorderColor = System.Drawing.Color.White
        Me.chk_row_visible.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_row_visible.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.chk_row_visible.Properties.Appearance.Options.UseBackColor = True
        Me.chk_row_visible.Properties.Appearance.Options.UseBorderColor = True
        Me.chk_row_visible.Properties.Appearance.Options.UseFont = True
        Me.chk_row_visible.Properties.Appearance.Options.UseForeColor = True
        Me.chk_row_visible.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.chk_row_visible.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.chk_row_visible.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.White
        Me.chk_row_visible.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_row_visible.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.chk_row_visible.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.chk_row_visible.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.chk_row_visible.Properties.AppearanceDisabled.Options.UseFont = True
        Me.chk_row_visible.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.chk_row_visible.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.chk_row_visible.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.chk_row_visible.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.White
        Me.chk_row_visible.Properties.AppearanceFocused.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_row_visible.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.DimGray
        Me.chk_row_visible.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.chk_row_visible.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.chk_row_visible.Properties.AppearanceFocused.Options.UseFont = True
        Me.chk_row_visible.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.chk_row_visible.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.chk_row_visible.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.chk_row_visible.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White
        Me.chk_row_visible.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_row_visible.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.chk_row_visible.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.chk_row_visible.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.chk_row_visible.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.chk_row_visible.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.chk_row_visible.Properties.Caption = "El estado actual del registro es vigente?"
        Me.chk_row_visible.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chk_row_visible.Properties.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.chk_row_visible.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.chk_row_visible.Size = New System.Drawing.Size(210, 20)
        Me.chk_row_visible.TabIndex = 0
        '
        'lbl_object_caracters
        '
        Me.lbl_object_caracters.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_caracters.Appearance.Options.UseForeColor = True
        Me.lbl_object_caracters.Location = New System.Drawing.Point(455, 340)
        Me.lbl_object_caracters.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_caracters.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_caracters.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_caracters.Name = "lbl_object_caracters"
        Me.lbl_object_caracters.Size = New System.Drawing.Size(27, 16)
        Me.lbl_object_caracters.TabIndex = 0
        Me.lbl_object_caracters.Text = "0/500"
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
        Me.btn_object_cancel.Location = New System.Drawing.Point(849, 1)
        Me.btn_object_cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_cancel.Name = "btn_object_cancel"
        Me.btn_object_cancel.Size = New System.Drawing.Size(28, 31)
        Me.btn_object_cancel.TabIndex = 0
        Me.btn_object_cancel.TabStop = False
        Me.btn_object_cancel.Text = "X"
        Me.btn_object_cancel.UseVisualStyleBackColor = False
        '
        'lbl_reject_description
        '
        Me.lbl_reject_description.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reject_description.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_reject_description.Appearance.Options.UseFont = True
        Me.lbl_reject_description.Appearance.Options.UseForeColor = True
        Me.lbl_reject_description.Location = New System.Drawing.Point(455, 149)
        Me.lbl_reject_description.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_reject_description.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_reject_description.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_reject_description.Name = "lbl_reject_description"
        Me.lbl_reject_description.Size = New System.Drawing.Size(231, 16)
        Me.lbl_reject_description.TabIndex = 0
        Me.lbl_reject_description.Text = "Describa el motivo de la finalización de la gestión*"
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
        Me.lbl_object_title.Size = New System.Drawing.Size(149, 38)
        Me.lbl_object_title.TabIndex = 0
        Me.lbl_object_title.Text = "Finalizar Gestión"
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
        Me.btn_object_accept.Location = New System.Drawing.Point(779, 423)
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
        'xvp_spell
        '
        Me.xvp_spell.CheckAsYouTypeOptions.Color = System.Drawing.Color.LightSeaGreen
        Me.xvp_spell.Culture = New System.Globalization.CultureInfo("es-CO")
        HunspellDictionary1.Culture = New System.Globalization.CultureInfo("es-CO")
        HunspellDictionary1.DictionaryPath = "C:\Users\Danny\Documents\Visual Studio 2015\APDA\BIM\BIM\Model\6. Database\Dictio" &
    "naries\es_CO.dic"
        HunspellDictionary1.GrammarPath = "C:\Users\Danny\Documents\Visual Studio 2015\APDA\BIM\BIM\Model\6. Database\Dictio" &
    "naries\es_CO.aff"
        Me.xvp_spell.Dictionaries.Add(HunspellDictionary1)
        Me.xvp_spell.LoadOnDemand = True
        Me.xvp_spell.LookAndFeel.SkinName = "Office 2019 White"
        Me.xvp_spell.LookAndFeel.UseDefaultLookAndFeel = False
        Me.xvp_spell.OptionsSpelling.CheckFromCursorPos = DevExpress.Utils.DefaultBoolean.[True]
        Me.xvp_spell.OptionsSpelling.CheckSelectedTextFirst = DevExpress.Utils.DefaultBoolean.[True]
        Me.xvp_spell.ParentContainer = Me.txt_attention_description
        Me.xvp_spell.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType
        Me.xvp_spell.SpellingFormType = DevExpress.XtraSpellChecker.SpellingFormType.Word
        '
        'comercial_attention_closed
        '
        Me.AcceptButton = Me.btn_object_accept
        Me.AccessibleName = "CA004E"
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
        Me.ClientSize = New System.Drawing.Size(882, 478)
        Me.Controls.Add(Me.pnl_object_container)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IconOptions.Icon = CType(resources.GetObject("comercial_attention_closed.IconOptions.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Office 2019 White"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "comercial_attention_closed"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Finalizar Gestión"
        Me.TopMost = True
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_attention_ticket.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_attention_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_attention_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_attention_causal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_attention_quotation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_attention_description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        CType(Me.chk_row_visible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents xvp_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_object_caracters As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_cancel As Button
    Friend WithEvents lbl_reject_description As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_accept As Button
    Friend WithEvents lbl_object_info As DevExpress.XtraEditors.LabelControl
    Protected WithEvents chk_row_visible As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lbl_attention_ticket As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_attention_ticket As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_attention_created As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_attention_date As APDA.Object.Controls.TextboxDates
    Friend WithEvents cmb_attention_causal As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_attention_theme As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_attention_quotation As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_attention_quotation As APDA.Object.Controls.TextboxEdit
    Friend WithEvents xvp_spell As DevExpress.XtraSpellChecker.SpellChecker
    Private WithEvents txt_attention_description As DevExpress.XtraEditors.MemoEdit
End Class
