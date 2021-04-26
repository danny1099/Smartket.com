<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comercial_customer_quotas
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
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim OptionsSpelling1 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(comercial_customer_quotas))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim HunspellDictionary1 As DevExpress.XtraSpellChecker.HunspellDictionary = New DevExpress.XtraSpellChecker.HunspellDictionary()
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.txt_customer_name = New APDA.[Object].Controls.TextboxEdit()
        Me.txt_quotas_document = New APDA.[Object].Controls.TextboxEdit()
        Me.txt_customer_description = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_quotas_value = New APDA.[Object].Controls.TextboxEdit()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_quotas_value = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_quotas_type = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_customer_name = New DevExpress.XtraEditors.LabelControl()
        Me.chk_row_visible = New DevExpress.XtraEditors.CheckEdit()
        Me.lbl_object_caracters = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.lbl_orders_description = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        Me.xvp_spell = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_customer_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_quotas_document.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_customer_description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_quotas_value.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'txt_customer_name
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_customer_name, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_customer_name.Location = New System.Drawing.Point(41, 154)
        Me.txt_customer_name.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_customer_name.Name = "txt_customer_name"
        Me.txt_customer_name.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_customer_name.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_customer_name.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_customer_name.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_customer_name.Properties.Appearance.Options.UseBackColor = True
        Me.txt_customer_name.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_customer_name.Properties.Appearance.Options.UseForeColor = True
        Me.txt_customer_name.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_customer_name.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_customer_name.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_customer_name.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_customer_name.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_customer_name.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_customer_name.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_customer_name.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_customer_name.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_customer_name.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_customer_name.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_customer_name.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_customer_name.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_customer_name.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_customer_name.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_customer_name.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_customer_name.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_customer_name.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_customer_name.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_customer_name.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_customer_name.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_customer_name.Properties.AutoHeight = False
        Me.txt_customer_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_customer_name.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_customer_name.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_customer_name.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_customer_name.Properties.Mask.BeepOnError = True
        Me.txt_customer_name.Properties.MaskSettings.Set("mask", "(\O\C\-)+(\w|[\-]){2,63}[a-zA-Z]{2,4}")
        Me.txt_customer_name.Properties.MaskSettings.Set("showPlaceholders", False)
        Me.txt_customer_name.Properties.ReadOnly = True
        Me.txt_customer_name.Size = New System.Drawing.Size(350, 30)
        Me.txt_customer_name.TabIndex = 0
        Me.txt_customer_name.Tag = "Cliente"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_customer_name, ConditionValidationRule1)
        '
        'txt_quotas_document
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_quotas_document, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_quotas_document.Location = New System.Drawing.Point(41, 218)
        Me.txt_quotas_document.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_quotas_document.Name = "txt_quotas_document"
        Me.txt_quotas_document.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_quotas_document.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_quotas_document.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_quotas_document.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_quotas_document.Properties.Appearance.Options.UseBackColor = True
        Me.txt_quotas_document.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_quotas_document.Properties.Appearance.Options.UseForeColor = True
        Me.txt_quotas_document.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_quotas_document.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_quotas_document.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_quotas_document.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_quotas_document.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_quotas_document.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_quotas_document.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_quotas_document.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_quotas_document.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_quotas_document.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_quotas_document.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_quotas_document.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_quotas_document.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_quotas_document.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_quotas_document.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_quotas_document.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_quotas_document.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_quotas_document.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_quotas_document.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_quotas_document.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_quotas_document.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_quotas_document.Properties.AutoHeight = False
        Me.txt_quotas_document.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_quotas_document.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_quotas_document.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_quotas_document.Properties.Mask.BeepOnError = True
        Me.txt_quotas_document.Properties.MaskSettings.Set("mask", "(\O\C\-)+(\w|[\-]){2,63}[a-zA-Z]{2,4}")
        Me.txt_quotas_document.Properties.MaskSettings.Set("showPlaceholders", False)
        Me.txt_quotas_document.Properties.ReadOnly = True
        Me.txt_quotas_document.Size = New System.Drawing.Size(350, 30)
        Me.txt_quotas_document.TabIndex = 0
        Me.txt_quotas_document.Tag = "Documento"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_quotas_document, ConditionValidationRule2)
        '
        'txt_customer_description
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_customer_description, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_customer_description.Location = New System.Drawing.Point(461, 154)
        Me.txt_customer_description.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_customer_description.Name = "txt_customer_description"
        Me.txt_customer_description.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_customer_description.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_customer_description.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_customer_description.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customer_description.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_customer_description.Properties.Appearance.Options.UseBackColor = True
        Me.txt_customer_description.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_customer_description.Properties.Appearance.Options.UseFont = True
        Me.txt_customer_description.Properties.Appearance.Options.UseForeColor = True
        Me.txt_customer_description.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_customer_description.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_customer_description.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.xvp_spell.SetShowSpellCheckMenu(Me.txt_customer_description, True)
        Me.txt_customer_description.Size = New System.Drawing.Size(350, 157)
        Me.xvp_spell.SetSpellCheckerOptions(Me.txt_customer_description, OptionsSpelling1)
        Me.txt_customer_description.TabIndex = 1
        Me.txt_customer_description.Tag = "Descripción"
        '
        'txt_quotas_value
        '
        Me.txt_quotas_value.EditValue = ""
        Me.xvp_validate.SetIconAlignment(Me.txt_quotas_value, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_quotas_value.Location = New System.Drawing.Point(41, 281)
        Me.txt_quotas_value.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_quotas_value.Name = "txt_quotas_value"
        Me.txt_quotas_value.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_quotas_value.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_quotas_value.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_quotas_value.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_quotas_value.Properties.Appearance.Options.UseBackColor = True
        Me.txt_quotas_value.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_quotas_value.Properties.Appearance.Options.UseForeColor = True
        Me.txt_quotas_value.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_quotas_value.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_quotas_value.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_quotas_value.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_quotas_value.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_quotas_value.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_quotas_value.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_quotas_value.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_quotas_value.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_quotas_value.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_quotas_value.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_quotas_value.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_quotas_value.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_quotas_value.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_quotas_value.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_quotas_value.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_quotas_value.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_quotas_value.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_quotas_value.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_quotas_value.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_quotas_value.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_quotas_value.Properties.AutoHeight = False
        Me.txt_quotas_value.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txt_quotas_value.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_quotas_value.Properties.DisplayFormat.FormatString = "c"
        Me.txt_quotas_value.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_quotas_value.Properties.EditFormat.FormatString = "c"
        Me.txt_quotas_value.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_quotas_value.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_quotas_value.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_quotas_value.Properties.Mask.BeepOnError = True
        Me.txt_quotas_value.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txt_quotas_value.Properties.MaskSettings.Set("mask", "c")
        Me.txt_quotas_value.Size = New System.Drawing.Size(350, 30)
        Me.txt_quotas_value.TabIndex = 20
        Me.txt_quotas_value.Tag = "Cupo"
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_quotas_value, ConditionValidationRule3)
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.txt_quotas_value)
        Me.pnl_object_container.Controls.Add(Me.lbl_quotas_value)
        Me.pnl_object_container.Controls.Add(Me.txt_customer_name)
        Me.pnl_object_container.Controls.Add(Me.lbl_quotas_type)
        Me.pnl_object_container.Controls.Add(Me.txt_quotas_document)
        Me.pnl_object_container.Controls.Add(Me.lbl_customer_name)
        Me.pnl_object_container.Controls.Add(Me.chk_row_visible)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_caracters)
        Me.pnl_object_container.Controls.Add(Me.btn_object_cancel)
        Me.pnl_object_container.Controls.Add(Me.lbl_orders_description)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_title)
        Me.pnl_object_container.Controls.Add(Me.btn_object_accept)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_info)
        Me.pnl_object_container.Controls.Add(Me.txt_customer_description)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 1)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_container.Size = New System.Drawing.Size(870, 474)
        Me.pnl_object_container.TabIndex = 0
        '
        'lbl_quotas_value
        '
        Me.lbl_quotas_value.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quotas_value.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_quotas_value.Appearance.Options.UseFont = True
        Me.lbl_quotas_value.Appearance.Options.UseForeColor = True
        Me.lbl_quotas_value.Location = New System.Drawing.Point(40, 261)
        Me.lbl_quotas_value.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_quotas_value.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_quotas_value.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_quotas_value.Name = "lbl_quotas_value"
        Me.lbl_quotas_value.Size = New System.Drawing.Size(117, 16)
        Me.lbl_quotas_value.TabIndex = 0
        Me.lbl_quotas_value.Text = "Valor de cupo a asignar*"
        '
        'lbl_quotas_type
        '
        Me.lbl_quotas_type.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quotas_type.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_quotas_type.Appearance.Options.UseFont = True
        Me.lbl_quotas_type.Appearance.Options.UseForeColor = True
        Me.lbl_quotas_type.Location = New System.Drawing.Point(41, 198)
        Me.lbl_quotas_type.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_quotas_type.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_quotas_type.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_quotas_type.Name = "lbl_quotas_type"
        Me.lbl_quotas_type.Size = New System.Drawing.Size(111, 16)
        Me.lbl_quotas_type.TabIndex = 0
        Me.lbl_quotas_type.Text = "Número de documento*"
        '
        'lbl_customer_name
        '
        Me.lbl_customer_name.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_name.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_customer_name.Appearance.Options.UseFont = True
        Me.lbl_customer_name.Appearance.Options.UseForeColor = True
        Me.lbl_customer_name.Location = New System.Drawing.Point(41, 134)
        Me.lbl_customer_name.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_customer_name.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_customer_name.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_customer_name.Name = "lbl_customer_name"
        Me.lbl_customer_name.Size = New System.Drawing.Size(91, 16)
        Me.lbl_customer_name.TabIndex = 0
        Me.lbl_customer_name.Text = "Nombre del cliente*"
        '
        'chk_row_visible
        '
        Me.chk_row_visible.EditValue = True
        Me.chk_row_visible.Location = New System.Drawing.Point(41, 442)
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
        Me.chk_row_visible.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chk_row_visible.Properties.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.chk_row_visible.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.chk_row_visible.Size = New System.Drawing.Size(210, 20)
        Me.chk_row_visible.TabIndex = 0
        '
        'lbl_object_caracters
        '
        Me.lbl_object_caracters.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_caracters.Appearance.Options.UseForeColor = True
        Me.lbl_object_caracters.Location = New System.Drawing.Point(782, 315)
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
        Me.btn_object_cancel.Location = New System.Drawing.Point(839, 1)
        Me.btn_object_cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_cancel.Name = "btn_object_cancel"
        Me.btn_object_cancel.Size = New System.Drawing.Size(28, 31)
        Me.btn_object_cancel.TabIndex = 0
        Me.btn_object_cancel.TabStop = False
        Me.btn_object_cancel.Text = "X"
        Me.btn_object_cancel.UseVisualStyleBackColor = False
        '
        'lbl_orders_description
        '
        Me.lbl_orders_description.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orders_description.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_orders_description.Appearance.Options.UseFont = True
        Me.lbl_orders_description.Appearance.Options.UseForeColor = True
        Me.lbl_orders_description.Location = New System.Drawing.Point(461, 134)
        Me.lbl_orders_description.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_orders_description.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_orders_description.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_orders_description.Name = "lbl_orders_description"
        Me.lbl_orders_description.Size = New System.Drawing.Size(227, 16)
        Me.lbl_orders_description.TabIndex = 0
        Me.lbl_orders_description.Text = "Describa las observaciones finales de la solicitud"
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
        Me.lbl_object_title.Size = New System.Drawing.Size(144, 38)
        Me.lbl_object_title.TabIndex = 0
        Me.lbl_object_title.Text = "Cupo de crédito"
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
        Me.btn_object_accept.Location = New System.Drawing.Point(769, 422)
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
        Me.xvp_spell.ParentContainer = Me.txt_customer_description
        Me.xvp_spell.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType
        Me.xvp_spell.SpellingFormType = DevExpress.XtraSpellChecker.SpellingFormType.Word
        '
        'comercial_customer_quotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(872, 476)
        Me.Controls.Add(Me.pnl_object_container)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IconOptions.Image = Global.BIM.My.Resources.Resources.bim
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Office 2019 White"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "comercial_customer_quotas"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cupo de crédito"
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_customer_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_quotas_document.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_customer_description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_quotas_value.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        CType(Me.chk_row_visible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents xvp_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_quotas_value As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_customer_name As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_quotas_type As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_quotas_document As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_customer_name As DevExpress.XtraEditors.LabelControl
    Protected WithEvents chk_row_visible As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lbl_object_caracters As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_cancel As Button
    Friend WithEvents lbl_orders_description As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_accept As Button
    Friend WithEvents lbl_object_info As DevExpress.XtraEditors.LabelControl
    Private WithEvents txt_customer_description As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_quotas_value As APDA.Object.Controls.TextboxEdit
    Friend WithEvents xvp_spell As DevExpress.XtraSpellChecker.SpellChecker
End Class
