<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wholesales_guarantee_solution
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wholesales_guarantee_solution))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim HunspellDictionary1 As DevExpress.XtraSpellChecker.HunspellDictionary = New DevExpress.XtraSpellChecker.HunspellDictionary()
        Dim OptionsSpelling1 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.cmb_guarantee_revision = New APDA.[Object].Controls.ComboboxEdit()
        Me.txt_guarantee_support = New APDA.[Object].Controls.TextboxDates()
        Me.txt_guarantee_count = New APDA.[Object].Controls.TextboxEdit()
        Me.cmb_guarantee_person = New APDA.[Object].Controls.ComboboxSearch()
        Me.dgv_sales_sellers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_guarantee_description = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_guarantee_person = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_guarantee_count = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_caracters = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_guarantee_support = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_guarantee_revision = New DevExpress.XtraEditors.LabelControl()
        Me.chk_row_visible = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        Me.xvp_spell = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
        Me.txt_guarantee_description = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_guarantee_revision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_guarantee_support.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_guarantee_support.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_guarantee_count.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_guarantee_person.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_sales_sellers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        CType(Me.chk_row_visible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_guarantee_description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xvp_validate
        '
        Me.xvp_validate.ValidateHiddenControls = False
        Me.xvp_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'cmb_guarantee_revision
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_guarantee_revision, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_guarantee_revision.Location = New System.Drawing.Point(40, 226)
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
        Me.cmb_guarantee_revision.Size = New System.Drawing.Size(350, 30)
        Me.cmb_guarantee_revision.TabIndex = 1
        Me.cmb_guarantee_revision.Tag = "Tipo de revision"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_guarantee_revision, ConditionValidationRule1)
        '
        'txt_guarantee_support
        '
        Me.txt_guarantee_support.EditValue = New Date(2020, 12, 29, 19, 42, 2, 305)
        Me.xvp_validate.SetIconAlignment(Me.txt_guarantee_support, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_guarantee_support.Location = New System.Drawing.Point(40, 290)
        Me.txt_guarantee_support.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_guarantee_support.Name = "txt_guarantee_support"
        Me.txt_guarantee_support.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_guarantee_support.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_guarantee_support.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_guarantee_support.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_guarantee_support.Properties.Appearance.Options.UseBackColor = True
        Me.txt_guarantee_support.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_guarantee_support.Properties.Appearance.Options.UseForeColor = True
        Me.txt_guarantee_support.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_guarantee_support.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_guarantee_support.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_guarantee_support.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_guarantee_support.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_guarantee_support.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_guarantee_support.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.txt_guarantee_support.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.txt_guarantee_support.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.txt_guarantee_support.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_guarantee_support.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_guarantee_support.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_guarantee_support.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_guarantee_support.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_guarantee_support.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_guarantee_support.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_guarantee_support.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_guarantee_support.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_guarantee_support.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_guarantee_support.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_guarantee_support.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_guarantee_support.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_guarantee_support.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_guarantee_support.Properties.AutoHeight = False
        Me.txt_guarantee_support.Properties.BeepOnError = False
        Me.txt_guarantee_support.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txt_guarantee_support.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_guarantee_support.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_guarantee_support.Properties.DisplayFormat.FormatString = "G"
        Me.txt_guarantee_support.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_guarantee_support.Properties.EditFormat.FormatString = "G"
        Me.txt_guarantee_support.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_guarantee_support.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_guarantee_support.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_guarantee_support.Properties.MaskSettings.Set("mask", "G")
        Me.txt_guarantee_support.Properties.SelectionMode = DevExpress.XtraEditors.Repository.CalendarSelectionMode.Multiple
        Me.txt_guarantee_support.Size = New System.Drawing.Size(195, 30)
        Me.txt_guarantee_support.TabIndex = 2
        Me.txt_guarantee_support.Tag = "Fecha de revision"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_guarantee_support, ConditionValidationRule2)
        '
        'txt_guarantee_count
        '
        Me.txt_guarantee_count.EditValue = 0
        Me.xvp_validate.SetIconAlignment(Me.txt_guarantee_count, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_guarantee_count.Location = New System.Drawing.Point(245, 290)
        Me.txt_guarantee_count.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_guarantee_count.Name = "txt_guarantee_count"
        Me.txt_guarantee_count.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_guarantee_count.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_guarantee_count.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_guarantee_count.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_guarantee_count.Properties.Appearance.Options.UseBackColor = True
        Me.txt_guarantee_count.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_guarantee_count.Properties.Appearance.Options.UseForeColor = True
        Me.txt_guarantee_count.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_guarantee_count.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_guarantee_count.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_guarantee_count.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_guarantee_count.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_guarantee_count.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_guarantee_count.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_guarantee_count.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_guarantee_count.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_guarantee_count.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_guarantee_count.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_guarantee_count.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_guarantee_count.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_guarantee_count.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_guarantee_count.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_guarantee_count.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_guarantee_count.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_guarantee_count.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_guarantee_count.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_guarantee_count.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_guarantee_count.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_guarantee_count.Properties.AutoHeight = False
        Me.txt_guarantee_count.Properties.BeepOnError = True
        Me.txt_guarantee_count.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_guarantee_count.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, True, False, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_guarantee_count.Properties.DisplayFormat.FormatString = "n0"
        Me.txt_guarantee_count.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_guarantee_count.Properties.EditFormat.FormatString = "n0"
        Me.txt_guarantee_count.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_guarantee_count.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_guarantee_count.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_guarantee_count.Properties.Mask.BeepOnError = True
        Me.txt_guarantee_count.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txt_guarantee_count.Properties.MaskSettings.Set("mask", "n0")
        Me.txt_guarantee_count.Size = New System.Drawing.Size(145, 30)
        Me.txt_guarantee_count.TabIndex = 3
        Me.txt_guarantee_count.Tag = "Registros"
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_guarantee_count, ConditionValidationRule3)
        '
        'cmb_guarantee_person
        '
        Me.cmb_guarantee_person.EditValue = ""
        Me.xvp_validate.SetIconAlignment(Me.cmb_guarantee_person, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_guarantee_person.Location = New System.Drawing.Point(40, 162)
        Me.cmb_guarantee_person.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_guarantee_person.Name = "cmb_guarantee_person"
        Me.cmb_guarantee_person.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_guarantee_person.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_guarantee_person.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_guarantee_person.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_guarantee_person.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_guarantee_person.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_guarantee_person.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_guarantee_person.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_guarantee_person.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_guarantee_person.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_guarantee_person.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmb_guarantee_person.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_guarantee_person.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_guarantee_person.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmb_guarantee_person.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_guarantee_person.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_guarantee_person.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_guarantee_person.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.cmb_guarantee_person.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_guarantee_person.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_guarantee_person.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.cmb_guarantee_person.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_guarantee_person.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_guarantee_person.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_guarantee_person.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.cmb_guarantee_person.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_guarantee_person.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_guarantee_person.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmb_guarantee_person.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_guarantee_person.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_guarantee_person.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_guarantee_person.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.cmb_guarantee_person.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_guarantee_person.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_guarantee_person.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.cmb_guarantee_person.Properties.AutoHeight = False
        Me.cmb_guarantee_person.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_guarantee_person.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_guarantee_person.Properties.LookAndFeel.SkinName = "My Office 2019 White"
        Me.cmb_guarantee_person.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_guarantee_person.Properties.NullText = ""
        Me.cmb_guarantee_person.Properties.PopupView = Me.dgv_sales_sellers
        Me.cmb_guarantee_person.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth
        Me.cmb_guarantee_person.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.cmb_guarantee_person.Size = New System.Drawing.Size(350, 30)
        Me.cmb_guarantee_person.TabIndex = 0
        Me.cmb_guarantee_person.Tag = "Responsable"
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_guarantee_person, ConditionValidationRule4)
        '
        'dgv_sales_sellers
        '
        Me.dgv_sales_sellers.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.dgv_sales_sellers.Name = "dgv_sales_sellers"
        Me.dgv_sales_sellers.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.dgv_sales_sellers.OptionsView.ShowGroupPanel = False
        Me.dgv_sales_sellers.OptionsView.ShowIndicator = False
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.lbl_guarantee_description)
        Me.pnl_object_container.Controls.Add(Me.lbl_guarantee_person)
        Me.pnl_object_container.Controls.Add(Me.cmb_guarantee_person)
        Me.pnl_object_container.Controls.Add(Me.txt_guarantee_count)
        Me.pnl_object_container.Controls.Add(Me.lbl_guarantee_count)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_caracters)
        Me.pnl_object_container.Controls.Add(Me.txt_guarantee_support)
        Me.pnl_object_container.Controls.Add(Me.lbl_guarantee_support)
        Me.pnl_object_container.Controls.Add(Me.lbl_guarantee_revision)
        Me.pnl_object_container.Controls.Add(Me.cmb_guarantee_revision)
        Me.pnl_object_container.Controls.Add(Me.chk_row_visible)
        Me.pnl_object_container.Controls.Add(Me.btn_object_cancel)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_title)
        Me.pnl_object_container.Controls.Add(Me.btn_object_accept)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_info)
        Me.pnl_object_container.Controls.Add(Me.txt_guarantee_description)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 1)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_container.Size = New System.Drawing.Size(880, 463)
        Me.pnl_object_container.TabIndex = 0
        '
        'lbl_guarantee_description
        '
        Me.lbl_guarantee_description.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guarantee_description.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_guarantee_description.Appearance.Options.UseFont = True
        Me.lbl_guarantee_description.Appearance.Options.UseForeColor = True
        Me.lbl_guarantee_description.Location = New System.Drawing.Point(473, 142)
        Me.lbl_guarantee_description.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_guarantee_description.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_guarantee_description.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_guarantee_description.Name = "lbl_guarantee_description"
        Me.lbl_guarantee_description.Size = New System.Drawing.Size(64, 16)
        Me.lbl_guarantee_description.TabIndex = 5
        Me.lbl_guarantee_description.Text = "Observacion*"
        '
        'lbl_guarantee_person
        '
        Me.lbl_guarantee_person.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guarantee_person.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_guarantee_person.Appearance.Options.UseFont = True
        Me.lbl_guarantee_person.Appearance.Options.UseForeColor = True
        Me.lbl_guarantee_person.Location = New System.Drawing.Point(40, 142)
        Me.lbl_guarantee_person.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_guarantee_person.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_guarantee_person.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_guarantee_person.Name = "lbl_guarantee_person"
        Me.lbl_guarantee_person.Size = New System.Drawing.Size(302, 16)
        Me.lbl_guarantee_person.TabIndex = 0
        Me.lbl_guarantee_person.Text = "Defina el nombre del usuario que realiza la solución de garantía*"
        '
        'lbl_guarantee_count
        '
        Me.lbl_guarantee_count.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guarantee_count.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_guarantee_count.Appearance.Options.UseFont = True
        Me.lbl_guarantee_count.Appearance.Options.UseForeColor = True
        Me.lbl_guarantee_count.Location = New System.Drawing.Point(245, 270)
        Me.lbl_guarantee_count.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_guarantee_count.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_guarantee_count.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_guarantee_count.Name = "lbl_guarantee_count"
        Me.lbl_guarantee_count.Size = New System.Drawing.Size(48, 16)
        Me.lbl_guarantee_count.TabIndex = 0
        Me.lbl_guarantee_count.Text = "Registros*"
        '
        'lbl_object_caracters
        '
        Me.lbl_object_caracters.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_caracters.Appearance.Options.UseForeColor = True
        Me.lbl_object_caracters.Location = New System.Drawing.Point(473, 324)
        Me.lbl_object_caracters.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_caracters.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_caracters.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_caracters.Name = "lbl_object_caracters"
        Me.lbl_object_caracters.Size = New System.Drawing.Size(27, 16)
        Me.lbl_object_caracters.TabIndex = 0
        Me.lbl_object_caracters.Text = "0/500"
        '
        'lbl_guarantee_support
        '
        Me.lbl_guarantee_support.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guarantee_support.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_guarantee_support.Appearance.Options.UseFont = True
        Me.lbl_guarantee_support.Appearance.Options.UseForeColor = True
        Me.lbl_guarantee_support.Location = New System.Drawing.Point(40, 270)
        Me.lbl_guarantee_support.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_guarantee_support.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_guarantee_support.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_guarantee_support.Name = "lbl_guarantee_support"
        Me.lbl_guarantee_support.Size = New System.Drawing.Size(89, 16)
        Me.lbl_guarantee_support.TabIndex = 0
        Me.lbl_guarantee_support.Text = "Fecha de revisión*"
        '
        'lbl_guarantee_revision
        '
        Me.lbl_guarantee_revision.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guarantee_revision.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_guarantee_revision.Appearance.Options.UseFont = True
        Me.lbl_guarantee_revision.Appearance.Options.UseForeColor = True
        Me.lbl_guarantee_revision.Location = New System.Drawing.Point(40, 206)
        Me.lbl_guarantee_revision.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_guarantee_revision.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_guarantee_revision.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_guarantee_revision.Name = "lbl_guarantee_revision"
        Me.lbl_guarantee_revision.Size = New System.Drawing.Size(140, 16)
        Me.lbl_guarantee_revision.TabIndex = 0
        Me.lbl_guarantee_revision.Text = "Seleccione el tipo de revisión*"
        '
        'chk_row_visible
        '
        Me.chk_row_visible.EditValue = True
        Me.chk_row_visible.Location = New System.Drawing.Point(625, 322)
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
        Me.btn_object_cancel.Location = New System.Drawing.Point(849, 3)
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
        Me.lbl_object_title.Size = New System.Drawing.Size(194, 38)
        Me.lbl_object_title.TabIndex = 0
        Me.lbl_object_title.Text = "Solución de garantías"
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
        Me.btn_object_accept.Location = New System.Drawing.Point(778, 410)
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
        Me.xvp_spell.ParentContainer = Me.txt_guarantee_description
        Me.xvp_spell.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType
        Me.xvp_spell.SpellingFormType = DevExpress.XtraSpellChecker.SpellingFormType.Word
        '
        'txt_guarantee_description
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_guarantee_description, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_guarantee_description.Location = New System.Drawing.Point(473, 162)
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
        Me.txt_guarantee_description.Size = New System.Drawing.Size(362, 158)
        Me.xvp_spell.SetSpellCheckerOptions(Me.txt_guarantee_description, OptionsSpelling1)
        Me.txt_guarantee_description.TabIndex = 4
        Me.txt_guarantee_description.Tag = "Descripción"
        '
        'wholesales_guarantee_solution
        '
        Me.AcceptButton = Me.btn_object_accept
        Me.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.btn_object_cancel
        Me.ClientSize = New System.Drawing.Size(882, 465)
        Me.Controls.Add(Me.pnl_object_container)
        Me.EnableAcrylicAccent = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IconOptions.Image = CType(resources.GetObject("wholesales_guarantee_solution.IconOptions.Image"), System.Drawing.Image)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Office 2019 White"
        Me.LookAndFeel.TouchScaleFactor = 1.0!
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "wholesales_guarantee_solution"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solución de garantías"
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_guarantee_revision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_guarantee_support.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_guarantee_support.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_guarantee_count.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_guarantee_person.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_sales_sellers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        CType(Me.chk_row_visible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_guarantee_description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents xvp_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Protected WithEvents chk_row_visible As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btn_object_cancel As Button
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_accept As Button
    Friend WithEvents lbl_object_info As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_guarantee_revision As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_guarantee_revision As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents txt_guarantee_support As APDA.Object.Controls.TextboxDates
    Friend WithEvents lbl_guarantee_support As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_caracters As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_guarantee_count As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_guarantee_count As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_guarantee_person As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_guarantee_person As APDA.Object.Controls.ComboboxSearch
    Friend WithEvents dgv_sales_sellers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbl_guarantee_description As DevExpress.XtraEditors.LabelControl
    Friend WithEvents xvp_spell As DevExpress.XtraSpellChecker.SpellChecker
    Private WithEvents txt_guarantee_description As DevExpress.XtraEditors.MemoEdit
End Class
