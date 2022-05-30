<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wholesales_guarantee_support
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wholesales_guarantee_support))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim OptionsSpelling1 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
        Dim ConditionValidationRule5 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim HunspellDictionary1 As DevExpress.XtraSpellChecker.HunspellDictionary = New DevExpress.XtraSpellChecker.HunspellDictionary()
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.txt_guarantee_product = New APDA.[Object].Controls.TextboxEdit()
        Me.cmb_guarantee_causal = New APDA.[Object].Controls.ComboboxCheck()
        Me.txt_guarantee_serial = New APDA.[Object].Controls.TextboxEdit()
        Me.cmb_guarantee_revision = New APDA.[Object].Controls.ComboboxEdit()
        Me.txt_guarantee_description = New DevExpress.XtraEditors.MemoEdit()
        Me.object_panel_container = New DevExpress.XtraEditors.PanelControl()
        Me.object_label_info = New DevExpress.XtraEditors.LabelControl()
        Me.object_label_title = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_guarantee_revision = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_caracters = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_guarantee_description = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_guarantee_product = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_guarantee_causal = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_guarantee_serial = New DevExpress.XtraEditors.LabelControl()
        Me.xvp_spell = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
        Me.object_panel_actions = New System.Windows.Forms.FlowLayoutPanel()
        Me.object_button_saved = New System.Windows.Forms.Button()
        Me.object_separator_spliter1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.object_button_clean = New System.Windows.Forms.Button()
        Me.object_button_closed = New System.Windows.Forms.Button()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_guarantee_product.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_guarantee_causal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_guarantee_serial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_guarantee_revision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_guarantee_description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_panel_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.object_panel_container.SuspendLayout()
        Me.object_panel_actions.SuspendLayout()
        CType(Me.object_separator_spliter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xvp_validate
        '
        Me.xvp_validate.ValidateHiddenControls = False
        Me.xvp_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'txt_guarantee_product
        '
        Me.txt_guarantee_product.EditValue = ""
        Me.xvp_validate.SetIconAlignment(Me.txt_guarantee_product, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_guarantee_product.Location = New System.Drawing.Point(45, 219)
        Me.txt_guarantee_product.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_guarantee_product.Name = "txt_guarantee_product"
        Me.txt_guarantee_product.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_guarantee_product.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_guarantee_product.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_guarantee_product.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_guarantee_product.Properties.Appearance.Options.UseBackColor = True
        Me.txt_guarantee_product.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_guarantee_product.Properties.Appearance.Options.UseForeColor = True
        Me.txt_guarantee_product.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_guarantee_product.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_guarantee_product.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_guarantee_product.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_guarantee_product.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_guarantee_product.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_guarantee_product.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_guarantee_product.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_guarantee_product.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_guarantee_product.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_guarantee_product.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_guarantee_product.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_guarantee_product.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_guarantee_product.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_guarantee_product.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_guarantee_product.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_guarantee_product.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_guarantee_product.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_guarantee_product.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_guarantee_product.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_guarantee_product.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_guarantee_product.Properties.AutoHeight = False
        Me.txt_guarantee_product.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txt_guarantee_product.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, False, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_guarantee_product.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_guarantee_product.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_guarantee_product.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_guarantee_product.Properties.Mask.BeepOnError = True
        Me.txt_guarantee_product.Properties.MaxLength = 100
        Me.txt_guarantee_product.Properties.ReadOnly = True
        Me.txt_guarantee_product.Size = New System.Drawing.Size(352, 35)
        Me.txt_guarantee_product.TabIndex = 0
        Me.txt_guarantee_product.Tag = "Nombre de producto"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_guarantee_product, ConditionValidationRule1)
        '
        'cmb_guarantee_causal
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_guarantee_causal, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_guarantee_causal.Location = New System.Drawing.Point(45, 287)
        Me.cmb_guarantee_causal.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_guarantee_causal.Name = "cmb_guarantee_causal"
        Me.cmb_guarantee_causal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_guarantee_causal.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_guarantee_causal.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_guarantee_causal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_guarantee_causal.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_guarantee_causal.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_guarantee_causal.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_guarantee_causal.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_guarantee_causal.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_guarantee_causal.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_guarantee_causal.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmb_guarantee_causal.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_guarantee_causal.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_guarantee_causal.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmb_guarantee_causal.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_guarantee_causal.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_guarantee_causal.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_guarantee_causal.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.cmb_guarantee_causal.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_guarantee_causal.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_guarantee_causal.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.cmb_guarantee_causal.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_guarantee_causal.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_guarantee_causal.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_guarantee_causal.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.cmb_guarantee_causal.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_guarantee_causal.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_guarantee_causal.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmb_guarantee_causal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_guarantee_causal.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_guarantee_causal.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_guarantee_causal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.cmb_guarantee_causal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_guarantee_causal.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_guarantee_causal.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.cmb_guarantee_causal.Properties.AutoHeight = False
        Me.cmb_guarantee_causal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_guarantee_causal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_guarantee_causal.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_guarantee_causal.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_guarantee_causal.Size = New System.Drawing.Size(352, 35)
        Me.cmb_guarantee_causal.TabIndex = 0
        Me.cmb_guarantee_causal.Tag = "Cauales"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_guarantee_causal, ConditionValidationRule2)
        '
        'txt_guarantee_serial
        '
        Me.txt_guarantee_serial.EditValue = ""
        Me.xvp_validate.SetIconAlignment(Me.txt_guarantee_serial, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_guarantee_serial.Location = New System.Drawing.Point(45, 150)
        Me.txt_guarantee_serial.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_guarantee_serial.Name = "txt_guarantee_serial"
        Me.txt_guarantee_serial.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_guarantee_serial.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_guarantee_serial.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_guarantee_serial.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_guarantee_serial.Properties.Appearance.Options.UseBackColor = True
        Me.txt_guarantee_serial.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_guarantee_serial.Properties.Appearance.Options.UseForeColor = True
        Me.txt_guarantee_serial.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_guarantee_serial.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_guarantee_serial.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_guarantee_serial.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_guarantee_serial.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_guarantee_serial.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_guarantee_serial.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_guarantee_serial.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_guarantee_serial.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_guarantee_serial.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_guarantee_serial.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_guarantee_serial.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_guarantee_serial.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_guarantee_serial.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_guarantee_serial.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_guarantee_serial.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_guarantee_serial.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_guarantee_serial.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_guarantee_serial.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_guarantee_serial.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_guarantee_serial.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_guarantee_serial.Properties.AutoHeight = False
        Me.txt_guarantee_serial.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_guarantee_serial.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_guarantee_serial.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_guarantee_serial.Properties.Mask.BeepOnError = True
        Me.txt_guarantee_serial.Properties.MaskSettings.Set("mask", "\d+")
        Me.txt_guarantee_serial.Properties.MaxLength = 50
        Me.txt_guarantee_serial.Properties.ReadOnly = True
        Me.txt_guarantee_serial.Size = New System.Drawing.Size(352, 35)
        Me.txt_guarantee_serial.TabIndex = 0
        Me.txt_guarantee_serial.Tag = "Numero de serial"
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_guarantee_serial, ConditionValidationRule3)
        '
        'cmb_guarantee_revision
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_guarantee_revision, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_guarantee_revision.Location = New System.Drawing.Point(477, 150)
        Me.cmb_guarantee_revision.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_guarantee_revision.Name = "cmb_guarantee_revision"
        Me.cmb_guarantee_revision.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_guarantee_revision.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_guarantee_revision.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_guarantee_revision.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_guarantee_revision.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_guarantee_revision.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_guarantee_revision.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_guarantee_revision.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_guarantee_revision.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_guarantee_revision.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_guarantee_revision.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_guarantee_revision.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_guarantee_revision.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_guarantee_revision.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_guarantee_revision.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_guarantee_revision.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_guarantee_revision.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_guarantee_revision.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_guarantee_revision.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_guarantee_revision.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_guarantee_revision.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_guarantee_revision.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_guarantee_revision.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_guarantee_revision.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_guarantee_revision.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_guarantee_revision.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_guarantee_revision.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_guarantee_revision.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_guarantee_revision.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_guarantee_revision.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_guarantee_revision.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_guarantee_revision.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_guarantee_revision.Properties.AutoHeight = False
        Me.cmb_guarantee_revision.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_guarantee_revision.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_guarantee_revision.Properties.DropDownItemHeight = 30
        Me.cmb_guarantee_revision.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_guarantee_revision.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_guarantee_revision.Properties.NullText = ""
        Me.cmb_guarantee_revision.Properties.ShowFooter = False
        Me.cmb_guarantee_revision.Properties.ShowHeader = False
        Me.cmb_guarantee_revision.Size = New System.Drawing.Size(352, 30)
        Me.cmb_guarantee_revision.TabIndex = 1
        Me.cmb_guarantee_revision.Tag = "Tipo de revision"
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_guarantee_revision, ConditionValidationRule4)
        '
        'txt_guarantee_description
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_guarantee_description, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_guarantee_description.Location = New System.Drawing.Point(477, 219)
        Me.txt_guarantee_description.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_guarantee_description.Name = "txt_guarantee_description"
        Me.txt_guarantee_description.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_guarantee_description.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_guarantee_description.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_guarantee_description.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_guarantee_description.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_guarantee_description.Properties.Appearance.Options.UseBackColor = True
        Me.txt_guarantee_description.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_guarantee_description.Properties.Appearance.Options.UseFont = True
        Me.txt_guarantee_description.Properties.Appearance.Options.UseForeColor = True
        Me.txt_guarantee_description.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_guarantee_description.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_guarantee_description.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.xvp_spell.SetShowSpellCheckMenu(Me.txt_guarantee_description, True)
        Me.txt_guarantee_description.Size = New System.Drawing.Size(352, 117)
        Me.xvp_spell.SetSpellCheckerOptions(Me.txt_guarantee_description, OptionsSpelling1)
        Me.txt_guarantee_description.TabIndex = 2
        Me.txt_guarantee_description.Tag = "Descripción"
        ConditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule5.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_guarantee_description, ConditionValidationRule5)
        '
        'object_panel_container
        '
        Me.object_panel_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.object_panel_container.Controls.Add(Me.object_label_info)
        Me.object_panel_container.Controls.Add(Me.object_label_title)
        Me.object_panel_container.Controls.Add(Me.lbl_guarantee_revision)
        Me.object_panel_container.Controls.Add(Me.cmb_guarantee_revision)
        Me.object_panel_container.Controls.Add(Me.lbl_object_caracters)
        Me.object_panel_container.Controls.Add(Me.lbl_guarantee_description)
        Me.object_panel_container.Controls.Add(Me.txt_guarantee_product)
        Me.object_panel_container.Controls.Add(Me.lbl_guarantee_product)
        Me.object_panel_container.Controls.Add(Me.lbl_guarantee_causal)
        Me.object_panel_container.Controls.Add(Me.cmb_guarantee_causal)
        Me.object_panel_container.Controls.Add(Me.txt_guarantee_serial)
        Me.object_panel_container.Controls.Add(Me.lbl_guarantee_serial)
        Me.object_panel_container.Controls.Add(Me.txt_guarantee_description)
        Me.object_panel_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.object_panel_container.Location = New System.Drawing.Point(1, 1)
        Me.object_panel_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_panel_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_panel_container.Margin = New System.Windows.Forms.Padding(0)
        Me.object_panel_container.Name = "object_panel_container"
        Me.object_panel_container.Padding = New System.Windows.Forms.Padding(1)
        Me.object_panel_container.Size = New System.Drawing.Size(882, 394)
        Me.object_panel_container.TabIndex = 0
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
        Me.object_label_info.TabIndex = 25
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
        Me.object_label_title.Size = New System.Drawing.Size(125, 33)
        Me.object_label_title.TabIndex = 26
        Me.object_label_title.Text = "Revisión Técnica"
        '
        'lbl_guarantee_revision
        '
        Me.lbl_guarantee_revision.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guarantee_revision.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_guarantee_revision.Appearance.Options.UseFont = True
        Me.lbl_guarantee_revision.Appearance.Options.UseForeColor = True
        Me.lbl_guarantee_revision.Location = New System.Drawing.Point(477, 130)
        Me.lbl_guarantee_revision.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_guarantee_revision.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_guarantee_revision.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_guarantee_revision.Name = "lbl_guarantee_revision"
        Me.lbl_guarantee_revision.Size = New System.Drawing.Size(80, 16)
        Me.lbl_guarantee_revision.TabIndex = 0
        Me.lbl_guarantee_revision.Text = "Tipo de revisión*"
        '
        'lbl_object_caracters
        '
        Me.lbl_object_caracters.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_caracters.Appearance.Options.UseForeColor = True
        Me.lbl_object_caracters.Location = New System.Drawing.Point(802, 340)
        Me.lbl_object_caracters.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_caracters.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_caracters.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_caracters.Name = "lbl_object_caracters"
        Me.lbl_object_caracters.Size = New System.Drawing.Size(27, 16)
        Me.lbl_object_caracters.TabIndex = 24
        Me.lbl_object_caracters.Text = "0/500"
        '
        'lbl_guarantee_description
        '
        Me.lbl_guarantee_description.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guarantee_description.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_guarantee_description.Appearance.Options.UseFont = True
        Me.lbl_guarantee_description.Appearance.Options.UseForeColor = True
        Me.lbl_guarantee_description.Location = New System.Drawing.Point(477, 199)
        Me.lbl_guarantee_description.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_guarantee_description.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_guarantee_description.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_guarantee_description.Name = "lbl_guarantee_description"
        Me.lbl_guarantee_description.Size = New System.Drawing.Size(299, 16)
        Me.lbl_guarantee_description.TabIndex = 0
        Me.lbl_guarantee_description.Text = "Describa detalladamente los motivos y/o razones de la garantia*"
        '
        'lbl_guarantee_product
        '
        Me.lbl_guarantee_product.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guarantee_product.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_guarantee_product.Appearance.Options.UseFont = True
        Me.lbl_guarantee_product.Appearance.Options.UseForeColor = True
        Me.lbl_guarantee_product.Location = New System.Drawing.Point(45, 199)
        Me.lbl_guarantee_product.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_guarantee_product.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_guarantee_product.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_guarantee_product.Name = "lbl_guarantee_product"
        Me.lbl_guarantee_product.Size = New System.Drawing.Size(103, 16)
        Me.lbl_guarantee_product.TabIndex = 0
        Me.lbl_guarantee_product.Text = "Nombre del producto*"
        '
        'lbl_guarantee_causal
        '
        Me.lbl_guarantee_causal.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guarantee_causal.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_guarantee_causal.Appearance.Options.UseFont = True
        Me.lbl_guarantee_causal.Appearance.Options.UseForeColor = True
        Me.lbl_guarantee_causal.Location = New System.Drawing.Point(45, 267)
        Me.lbl_guarantee_causal.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_guarantee_causal.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_guarantee_causal.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_guarantee_causal.Name = "lbl_guarantee_causal"
        Me.lbl_guarantee_causal.Size = New System.Drawing.Size(48, 16)
        Me.lbl_guarantee_causal.TabIndex = 0
        Me.lbl_guarantee_causal.Text = "Causales*"
        '
        'lbl_guarantee_serial
        '
        Me.lbl_guarantee_serial.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guarantee_serial.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_guarantee_serial.Appearance.Options.UseFont = True
        Me.lbl_guarantee_serial.Appearance.Options.UseForeColor = True
        Me.lbl_guarantee_serial.Location = New System.Drawing.Point(45, 130)
        Me.lbl_guarantee_serial.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_guarantee_serial.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_guarantee_serial.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_guarantee_serial.Name = "lbl_guarantee_serial"
        Me.lbl_guarantee_serial.Size = New System.Drawing.Size(146, 16)
        Me.lbl_guarantee_serial.TabIndex = 0
        Me.lbl_guarantee_serial.Text = "Numero de serial del producto*"
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
        Me.xvp_spell.ParentContainer = Me.txt_guarantee_description
        Me.xvp_spell.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType
        Me.xvp_spell.SpellingFormType = DevExpress.XtraSpellChecker.SpellingFormType.Word
        '
        'object_panel_actions
        '
        Me.object_panel_actions.Controls.Add(Me.object_button_saved)
        Me.object_panel_actions.Controls.Add(Me.object_separator_spliter1)
        Me.object_panel_actions.Controls.Add(Me.object_button_clean)
        Me.object_panel_actions.Controls.Add(Me.object_button_closed)
        Me.object_panel_actions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.object_panel_actions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.object_panel_actions.Location = New System.Drawing.Point(1, 395)
        Me.object_panel_actions.Margin = New System.Windows.Forms.Padding(0)
        Me.object_panel_actions.Name = "object_panel_actions"
        Me.object_panel_actions.Padding = New System.Windows.Forms.Padding(5, 5, 30, 5)
        Me.object_panel_actions.Size = New System.Drawing.Size(882, 50)
        Me.object_panel_actions.TabIndex = 0
        '
        'object_button_saved
        '
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
        Me.object_button_saved.Location = New System.Drawing.Point(757, 5)
        Me.object_button_saved.Margin = New System.Windows.Forms.Padding(0)
        Me.object_button_saved.MaximumSize = New System.Drawing.Size(90, 38)
        Me.object_button_saved.MinimumSize = New System.Drawing.Size(90, 38)
        Me.object_button_saved.Name = "object_button_saved"
        Me.object_button_saved.Size = New System.Drawing.Size(90, 38)
        Me.object_button_saved.TabIndex = 3
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
        Me.object_separator_spliter1.Location = New System.Drawing.Point(750, 5)
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
        Me.object_button_clean.Location = New System.Drawing.Point(672, 5)
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
        Me.object_button_closed.Location = New System.Drawing.Point(596, 5)
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
        'wholesales_guarantee_support
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.object_panel_container)
        Me.Controls.Add(Me.object_panel_actions)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "wholesales_guarantee_support"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(884, 446)
        Me.Tag = "Revisión Tecnica"
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_guarantee_product.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_guarantee_causal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_guarantee_serial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_guarantee_revision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_guarantee_description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_panel_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.object_panel_container.ResumeLayout(False)
        Me.object_panel_container.PerformLayout()
        Me.object_panel_actions.ResumeLayout(False)
        CType(Me.object_separator_spliter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents xvp_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents object_panel_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_object_caracters As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_guarantee_description As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_guarantee_product As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_guarantee_product As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_guarantee_causal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_guarantee_causal As APDA.Object.Controls.ComboboxCheck
    Friend WithEvents txt_guarantee_serial As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_guarantee_serial As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_guarantee_revision As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_guarantee_revision As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents xvp_spell As DevExpress.XtraSpellChecker.SpellChecker
    Private WithEvents txt_guarantee_description As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents object_label_info As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_label_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_panel_actions As FlowLayoutPanel
    Protected WithEvents object_button_saved As Button
    Friend WithEvents object_separator_spliter1 As DevExpress.XtraEditors.SeparatorControl
    Protected WithEvents object_button_clean As Button
    Protected WithEvents object_button_closed As Button
End Class
