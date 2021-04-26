<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class comercial_attention_quotation
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim OptionsSpelling1 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
        Dim HunspellDictionary1 As DevExpress.XtraSpellChecker.HunspellDictionary = New DevExpress.XtraSpellChecker.HunspellDictionary()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(comercial_attention_quotation))
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.cmb_quotation_type = New APDA.[Object].Controls.ComboboxEdit()
        Me.cmb_quotation_services = New APDA.[Object].Controls.ComboboxSearch()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txt_quotation_value = New APDA.[Object].Controls.TextboxEdit()
        Me.cmb_quotation_dealers = New APDA.[Object].Controls.ComboboxEdit()
        Me.txt_quotation_desc = New DevExpress.XtraEditors.MemoEdit()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.chk_keep_form = New DevExpress.XtraEditors.CheckEdit()
        Me.lbl_object_caracters = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_quotation_desc = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_quotation_dealer = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_quotation_value = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_quotation_services = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_quotation_operator = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        Me.xvp_spell = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_quotation_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_quotation_services.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_quotation_value.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_quotation_dealers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_quotation_desc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'cmb_quotation_type
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_quotation_type, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_quotation_type.Location = New System.Drawing.Point(41, 167)
        Me.cmb_quotation_type.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_quotation_type.Name = "cmb_quotation_type"
        Me.cmb_quotation_type.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_quotation_type.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_quotation_type.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_quotation_type.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_quotation_type.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_quotation_type.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_quotation_type.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_quotation_type.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_quotation_type.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_quotation_type.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_quotation_type.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_quotation_type.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_quotation_type.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_quotation_type.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_quotation_type.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_quotation_type.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_quotation_type.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_quotation_type.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_quotation_type.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_quotation_type.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_quotation_type.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_quotation_type.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_quotation_type.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_quotation_type.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_quotation_type.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_quotation_type.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_quotation_type.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_quotation_type.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_quotation_type.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_quotation_type.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_quotation_type.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_quotation_type.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_quotation_type.Properties.AutoHeight = False
        Me.cmb_quotation_type.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_quotation_type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_quotation_type.Properties.DropDownItemHeight = 30
        Me.cmb_quotation_type.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_quotation_type.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_quotation_type.Properties.NullText = ""
        Me.cmb_quotation_type.Properties.ShowFooter = False
        Me.cmb_quotation_type.Properties.ShowHeader = False
        Me.cmb_quotation_type.Size = New System.Drawing.Size(350, 30)
        Me.cmb_quotation_type.TabIndex = 1
        Me.cmb_quotation_type.Tag = "Tipo de servicio"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_quotation_type, ConditionValidationRule1)
        '
        'cmb_quotation_services
        '
        Me.cmb_quotation_services.EditValue = ""
        Me.xvp_validate.SetIconAlignment(Me.cmb_quotation_services, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_quotation_services.Location = New System.Drawing.Point(41, 236)
        Me.cmb_quotation_services.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_quotation_services.Name = "cmb_quotation_services"
        Me.cmb_quotation_services.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_quotation_services.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_quotation_services.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_quotation_services.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_quotation_services.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_quotation_services.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_quotation_services.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_quotation_services.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_quotation_services.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_quotation_services.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_quotation_services.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmb_quotation_services.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_quotation_services.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_quotation_services.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmb_quotation_services.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_quotation_services.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_quotation_services.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_quotation_services.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.cmb_quotation_services.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_quotation_services.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_quotation_services.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.cmb_quotation_services.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_quotation_services.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_quotation_services.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_quotation_services.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.cmb_quotation_services.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_quotation_services.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_quotation_services.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmb_quotation_services.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_quotation_services.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_quotation_services.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_quotation_services.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.cmb_quotation_services.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_quotation_services.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_quotation_services.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.cmb_quotation_services.Properties.AutoHeight = False
        Me.cmb_quotation_services.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_quotation_services.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_quotation_services.Properties.LookAndFeel.SkinName = "My Office 2019 White"
        Me.cmb_quotation_services.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_quotation_services.Properties.NullText = ""
        Me.cmb_quotation_services.Properties.PopupView = Me.GridView1
        Me.cmb_quotation_services.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth
        Me.cmb_quotation_services.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.cmb_quotation_services.Size = New System.Drawing.Size(350, 30)
        Me.cmb_quotation_services.TabIndex = 2
        Me.cmb_quotation_services.Tag = "Servicio y/o producto"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_quotation_services, ConditionValidationRule2)
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'txt_quotation_value
        '
        Me.txt_quotation_value.EditValue = 0
        Me.xvp_validate.SetIconAlignment(Me.txt_quotation_value, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_quotation_value.Location = New System.Drawing.Point(233, 300)
        Me.txt_quotation_value.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_quotation_value.Name = "txt_quotation_value"
        Me.txt_quotation_value.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_quotation_value.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_quotation_value.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_quotation_value.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_quotation_value.Properties.Appearance.Options.UseBackColor = True
        Me.txt_quotation_value.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_quotation_value.Properties.Appearance.Options.UseForeColor = True
        Me.txt_quotation_value.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_quotation_value.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_quotation_value.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_quotation_value.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_quotation_value.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_quotation_value.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_quotation_value.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_quotation_value.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_quotation_value.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_quotation_value.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_quotation_value.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_quotation_value.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_quotation_value.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_quotation_value.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_quotation_value.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_quotation_value.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_quotation_value.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_quotation_value.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_quotation_value.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_quotation_value.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_quotation_value.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_quotation_value.Properties.AutoHeight = False
        Me.txt_quotation_value.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_quotation_value.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, True, False, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_quotation_value.Properties.DisplayFormat.FormatString = "c0"
        Me.txt_quotation_value.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_quotation_value.Properties.EditFormat.FormatString = "c0"
        Me.txt_quotation_value.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_quotation_value.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_quotation_value.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_quotation_value.Properties.Mask.BeepOnError = True
        Me.txt_quotation_value.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txt_quotation_value.Properties.MaskSettings.Set("mask", "c0")
        Me.txt_quotation_value.Size = New System.Drawing.Size(158, 30)
        Me.txt_quotation_value.TabIndex = 4
        Me.txt_quotation_value.Tag = "Valor de cotizacion"
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_quotation_value, ConditionValidationRule3)
        '
        'cmb_quotation_dealers
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_quotation_dealers, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_quotation_dealers.Location = New System.Drawing.Point(40, 300)
        Me.cmb_quotation_dealers.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_quotation_dealers.Name = "cmb_quotation_dealers"
        Me.cmb_quotation_dealers.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_quotation_dealers.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_quotation_dealers.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_quotation_dealers.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_quotation_dealers.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_quotation_dealers.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_quotation_dealers.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_quotation_dealers.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_quotation_dealers.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_quotation_dealers.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_quotation_dealers.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_quotation_dealers.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_quotation_dealers.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_quotation_dealers.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_quotation_dealers.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_quotation_dealers.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_quotation_dealers.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_quotation_dealers.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_quotation_dealers.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_quotation_dealers.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_quotation_dealers.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_quotation_dealers.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_quotation_dealers.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_quotation_dealers.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_quotation_dealers.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_quotation_dealers.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_quotation_dealers.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_quotation_dealers.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_quotation_dealers.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_quotation_dealers.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_quotation_dealers.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_quotation_dealers.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_quotation_dealers.Properties.AutoHeight = False
        Me.cmb_quotation_dealers.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_quotation_dealers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_quotation_dealers.Properties.DropDownItemHeight = 30
        Me.cmb_quotation_dealers.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_quotation_dealers.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_quotation_dealers.Properties.NullText = ""
        Me.cmb_quotation_dealers.Properties.ShowFooter = False
        Me.cmb_quotation_dealers.Properties.ShowHeader = False
        Me.cmb_quotation_dealers.Size = New System.Drawing.Size(184, 30)
        Me.cmb_quotation_dealers.TabIndex = 3
        Me.cmb_quotation_dealers.Tag = "Distribuidor"
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_quotation_dealers, ConditionValidationRule4)
        '
        'txt_quotation_desc
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_quotation_desc, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_quotation_desc.Location = New System.Drawing.Point(432, 167)
        Me.txt_quotation_desc.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_quotation_desc.Name = "txt_quotation_desc"
        Me.txt_quotation_desc.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_quotation_desc.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_quotation_desc.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_quotation_desc.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quotation_desc.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_quotation_desc.Properties.Appearance.Options.UseBackColor = True
        Me.txt_quotation_desc.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_quotation_desc.Properties.Appearance.Options.UseFont = True
        Me.txt_quotation_desc.Properties.Appearance.Options.UseForeColor = True
        Me.txt_quotation_desc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_quotation_desc.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_quotation_desc.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.xvp_spell.SetShowSpellCheckMenu(Me.txt_quotation_desc, True)
        Me.txt_quotation_desc.Size = New System.Drawing.Size(369, 163)
        Me.xvp_spell.SetSpellCheckerOptions(Me.txt_quotation_desc, OptionsSpelling1)
        Me.txt_quotation_desc.TabIndex = 5
        Me.txt_quotation_desc.Tag = "Descripción"
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.chk_keep_form)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_caracters)
        Me.pnl_object_container.Controls.Add(Me.lbl_quotation_desc)
        Me.pnl_object_container.Controls.Add(Me.lbl_quotation_dealer)
        Me.pnl_object_container.Controls.Add(Me.txt_quotation_value)
        Me.pnl_object_container.Controls.Add(Me.lbl_quotation_value)
        Me.pnl_object_container.Controls.Add(Me.cmb_quotation_dealers)
        Me.pnl_object_container.Controls.Add(Me.cmb_quotation_type)
        Me.pnl_object_container.Controls.Add(Me.lbl_quotation_services)
        Me.pnl_object_container.Controls.Add(Me.lbl_quotation_operator)
        Me.pnl_object_container.Controls.Add(Me.cmb_quotation_services)
        Me.pnl_object_container.Controls.Add(Me.btn_object_cancel)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_title)
        Me.pnl_object_container.Controls.Add(Me.btn_object_accept)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_info)
        Me.pnl_object_container.Controls.Add(Me.txt_quotation_desc)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 1)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_container.Size = New System.Drawing.Size(839, 473)
        Me.pnl_object_container.TabIndex = 0
        '
        'chk_keep_form
        '
        Me.chk_keep_form.Location = New System.Drawing.Point(633, 332)
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
        Me.chk_keep_form.Size = New System.Drawing.Size(171, 20)
        Me.chk_keep_form.TabIndex = 0
        '
        'lbl_object_caracters
        '
        Me.lbl_object_caracters.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_caracters.Appearance.Options.UseForeColor = True
        Me.lbl_object_caracters.Location = New System.Drawing.Point(432, 334)
        Me.lbl_object_caracters.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_caracters.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_caracters.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_caracters.Name = "lbl_object_caracters"
        Me.lbl_object_caracters.Size = New System.Drawing.Size(27, 16)
        Me.lbl_object_caracters.TabIndex = 0
        Me.lbl_object_caracters.Text = "0/500"
        '
        'lbl_quotation_desc
        '
        Me.lbl_quotation_desc.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quotation_desc.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_quotation_desc.Appearance.Options.UseFont = True
        Me.lbl_quotation_desc.Appearance.Options.UseForeColor = True
        Me.lbl_quotation_desc.Location = New System.Drawing.Point(432, 147)
        Me.lbl_quotation_desc.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_quotation_desc.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_quotation_desc.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_quotation_desc.Name = "lbl_quotation_desc"
        Me.lbl_quotation_desc.Size = New System.Drawing.Size(175, 16)
        Me.lbl_quotation_desc.TabIndex = 0
        Me.lbl_quotation_desc.Text = "Descripción de la cotización realizada"
        '
        'lbl_quotation_dealer
        '
        Me.lbl_quotation_dealer.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quotation_dealer.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_quotation_dealer.Appearance.Options.UseFont = True
        Me.lbl_quotation_dealer.Appearance.Options.UseForeColor = True
        Me.lbl_quotation_dealer.Location = New System.Drawing.Point(41, 280)
        Me.lbl_quotation_dealer.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_quotation_dealer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_quotation_dealer.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_quotation_dealer.Name = "lbl_quotation_dealer"
        Me.lbl_quotation_dealer.Size = New System.Drawing.Size(57, 16)
        Me.lbl_quotation_dealer.TabIndex = 6
        Me.lbl_quotation_dealer.Text = "Distribuidor*"
        '
        'lbl_quotation_value
        '
        Me.lbl_quotation_value.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quotation_value.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_quotation_value.Appearance.Options.UseFont = True
        Me.lbl_quotation_value.Appearance.Options.UseForeColor = True
        Me.lbl_quotation_value.Location = New System.Drawing.Point(233, 280)
        Me.lbl_quotation_value.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_quotation_value.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_quotation_value.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_quotation_value.Name = "lbl_quotation_value"
        Me.lbl_quotation_value.Size = New System.Drawing.Size(92, 16)
        Me.lbl_quotation_value.TabIndex = 7
        Me.lbl_quotation_value.Text = "Valor de cotización*"
        '
        'lbl_quotation_services
        '
        Me.lbl_quotation_services.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quotation_services.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_quotation_services.Appearance.Options.UseFont = True
        Me.lbl_quotation_services.Appearance.Options.UseForeColor = True
        Me.lbl_quotation_services.Location = New System.Drawing.Point(41, 216)
        Me.lbl_quotation_services.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_quotation_services.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_quotation_services.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_quotation_services.Name = "lbl_quotation_services"
        Me.lbl_quotation_services.Size = New System.Drawing.Size(195, 16)
        Me.lbl_quotation_services.TabIndex = 0
        Me.lbl_quotation_services.Text = "Defina el servicio y/o producto requerido*"
        '
        'lbl_quotation_operator
        '
        Me.lbl_quotation_operator.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quotation_operator.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_quotation_operator.Appearance.Options.UseFont = True
        Me.lbl_quotation_operator.Appearance.Options.UseForeColor = True
        Me.lbl_quotation_operator.Location = New System.Drawing.Point(41, 147)
        Me.lbl_quotation_operator.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_quotation_operator.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_quotation_operator.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_quotation_operator.Name = "lbl_quotation_operator"
        Me.lbl_quotation_operator.Size = New System.Drawing.Size(144, 16)
        Me.lbl_quotation_operator.TabIndex = 0
        Me.lbl_quotation_operator.Text = "Seleccione el tipo de producto*"
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
        Me.btn_object_cancel.Location = New System.Drawing.Point(810, 1)
        Me.btn_object_cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_cancel.Name = "btn_object_cancel"
        Me.btn_object_cancel.Size = New System.Drawing.Size(28, 31)
        Me.btn_object_cancel.TabIndex = 0
        Me.btn_object_cancel.TabStop = False
        Me.btn_object_cancel.Text = "X"
        Me.btn_object_cancel.UseVisualStyleBackColor = False
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
        Me.lbl_object_title.Size = New System.Drawing.Size(91, 38)
        Me.lbl_object_title.TabIndex = 0
        Me.lbl_object_title.Text = "Cotización"
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
        Me.btn_object_accept.Location = New System.Drawing.Point(737, 419)
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
        Me.xvp_spell.ParentContainer = Me.txt_quotation_desc
        Me.xvp_spell.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType
        Me.xvp_spell.SpellingFormType = DevExpress.XtraSpellChecker.SpellingFormType.Word
        '
        'comercial_attention_quotation
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
        Me.ClientSize = New System.Drawing.Size(841, 475)
        Me.Controls.Add(Me.pnl_object_container)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IconOptions.Image = CType(resources.GetObject("comercial_attention_quotation.IconOptions.Image"), System.Drawing.Image)
        Me.LookAndFeel.SkinName = "Office 2019 White"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "comercial_attention_quotation"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotización"
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_quotation_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_quotation_services.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_quotation_value.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_quotation_dealers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_quotation_desc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        CType(Me.chk_keep_form.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents xvp_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_object_cancel As Button
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_accept As Button
    Friend WithEvents lbl_object_info As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_quotation_type As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_quotation_services As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_quotation_operator As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_quotation_services As APDA.Object.Controls.ComboboxSearch
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbl_quotation_dealer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_quotation_value As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_quotation_value As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_quotation_dealers As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_object_caracters As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_quotation_desc As DevExpress.XtraEditors.LabelControl
    Protected WithEvents chk_keep_form As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents xvp_spell As DevExpress.XtraSpellChecker.SpellChecker
    Private WithEvents txt_quotation_desc As DevExpress.XtraEditors.MemoEdit
End Class
