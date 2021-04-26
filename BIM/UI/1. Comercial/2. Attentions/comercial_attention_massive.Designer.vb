<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comercial_attention_massive
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
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(comercial_attention_massive))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule5 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim OptionsSpelling1 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
        Dim HunspellDictionary1 As DevExpress.XtraSpellChecker.HunspellDictionary = New DevExpress.XtraSpellChecker.HunspellDictionary()
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.txt_attention_count = New APDA.[Object].Controls.TextboxEdit()
        Me.cmb_attention_theme = New APDA.[Object].Controls.ComboboxEdit()
        Me.txt_attention_date = New APDA.[Object].Controls.TextboxDates()
        Me.cmb_attention_topic = New APDA.[Object].Controls.ComboboxEdit()
        Me.cmb_attention_person = New APDA.[Object].Controls.ComboboxSearch()
        Me.dgv_sales_customers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txt_attention_desc = New DevExpress.XtraEditors.MemoEdit()
        Me.xvp_spell = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
        Me.pnl_object_top = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_refresh = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.pnl_object_bottom = New DevExpress.XtraEditors.PanelControl()
        Me.chk_row_visible = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_object_caracters = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_attention_ticket = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_attention_desc = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_attention_created = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_attention_theme = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_attention_topic = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_attention_person = New DevExpress.XtraEditors.LabelControl()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_attention_count.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_attention_theme.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_attention_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_attention_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_attention_topic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_attention_person.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_sales_customers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_attention_desc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_top.SuspendLayout()
        CType(Me.pnl_object_bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_bottom.SuspendLayout()
        CType(Me.chk_row_visible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        Me.SuspendLayout()
        '
        'xvp_validate
        '
        Me.xvp_validate.ValidateHiddenControls = False
        Me.xvp_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'txt_attention_count
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_attention_count, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_attention_count.Location = New System.Drawing.Point(473, 311)
        Me.txt_attention_count.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_attention_count.Name = "txt_attention_count"
        Me.txt_attention_count.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_attention_count.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_attention_count.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_attention_count.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_attention_count.Properties.Appearance.Options.UseBackColor = True
        Me.txt_attention_count.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_attention_count.Properties.Appearance.Options.UseForeColor = True
        Me.txt_attention_count.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_attention_count.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_attention_count.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_attention_count.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_attention_count.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_attention_count.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_attention_count.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_attention_count.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_attention_count.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_attention_count.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_attention_count.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_attention_count.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_attention_count.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_attention_count.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_attention_count.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_attention_count.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_attention_count.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_attention_count.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_attention_count.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_attention_count.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_attention_count.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_attention_count.Properties.AutoHeight = False
        Me.txt_attention_count.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_attention_count.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_attention_count.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_attention_count.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_attention_count.Properties.Mask.BeepOnError = True
        Me.txt_attention_count.Properties.MaskSettings.Set("mask", "(2) \d\d\d-\d\d\d\d")
        Me.txt_attention_count.Properties.ReadOnly = True
        Me.txt_attention_count.Size = New System.Drawing.Size(137, 30)
        Me.txt_attention_count.TabIndex = 5
        Me.txt_attention_count.Tag = "Total de registros"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_attention_count, ConditionValidationRule1)
        '
        'cmb_attention_theme
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_attention_theme, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_attention_theme.Location = New System.Drawing.Point(210, 242)
        Me.cmb_attention_theme.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_attention_theme.Name = "cmb_attention_theme"
        Me.cmb_attention_theme.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_attention_theme.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_theme.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_theme.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_attention_theme.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_attention_theme.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_attention_theme.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_attention_theme.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_attention_theme.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_theme.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_theme.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_attention_theme.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_attention_theme.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_attention_theme.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_theme.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_theme.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_attention_theme.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_attention_theme.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_attention_theme.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_theme.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_theme.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_attention_theme.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_attention_theme.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_attention_theme.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_theme.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_theme.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_attention_theme.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_attention_theme.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_attention_theme.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_theme.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_theme.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_attention_theme.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_attention_theme.Properties.AutoHeight = False
        Me.cmb_attention_theme.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_attention_theme.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_attention_theme.Properties.DropDownItemHeight = 30
        Me.cmb_attention_theme.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_attention_theme.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_attention_theme.Properties.NullText = ""
        Me.cmb_attention_theme.Properties.ShowFooter = False
        Me.cmb_attention_theme.Properties.ShowHeader = False
        Me.cmb_attention_theme.Size = New System.Drawing.Size(400, 30)
        Me.cmb_attention_theme.TabIndex = 3
        Me.cmb_attention_theme.Tag = "Tema de gestión"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_attention_theme, ConditionValidationRule2)
        '
        'txt_attention_date
        '
        Me.txt_attention_date.EditValue = Nothing
        Me.xvp_validate.SetIconAlignment(Me.txt_attention_date, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_attention_date.Location = New System.Drawing.Point(210, 311)
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
        Me.txt_attention_date.Properties.BeepOnError = False
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
        Me.txt_attention_date.Size = New System.Drawing.Size(255, 30)
        Me.txt_attention_date.TabIndex = 4
        Me.txt_attention_date.Tag = "Fecha de vigencia"
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_attention_date, ConditionValidationRule3)
        '
        'cmb_attention_topic
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_attention_topic, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_attention_topic.Location = New System.Drawing.Point(210, 173)
        Me.cmb_attention_topic.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_attention_topic.Name = "cmb_attention_topic"
        Me.cmb_attention_topic.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_attention_topic.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_topic.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_topic.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_attention_topic.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_attention_topic.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_attention_topic.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_attention_topic.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_attention_topic.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_topic.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_topic.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_attention_topic.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_attention_topic.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_attention_topic.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_topic.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_topic.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_attention_topic.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_attention_topic.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_attention_topic.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_topic.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_topic.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_attention_topic.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_attention_topic.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_attention_topic.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_topic.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_topic.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_attention_topic.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_attention_topic.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_attention_topic.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_topic.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_topic.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_attention_topic.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_attention_topic.Properties.AutoHeight = False
        Me.cmb_attention_topic.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_attention_topic.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_attention_topic.Properties.DropDownItemHeight = 30
        Me.cmb_attention_topic.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_attention_topic.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_attention_topic.Properties.NullText = ""
        Me.cmb_attention_topic.Properties.ShowFooter = False
        Me.cmb_attention_topic.Properties.ShowHeader = False
        Me.cmb_attention_topic.Size = New System.Drawing.Size(400, 30)
        Me.cmb_attention_topic.TabIndex = 2
        Me.cmb_attention_topic.Tag = "Tipo de atención"
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_attention_topic, ConditionValidationRule4)
        '
        'cmb_attention_person
        '
        Me.cmb_attention_person.EditValue = ""
        Me.xvp_validate.SetIconAlignment(Me.cmb_attention_person, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_attention_person.Location = New System.Drawing.Point(210, 103)
        Me.cmb_attention_person.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_attention_person.Name = "cmb_attention_person"
        Me.cmb_attention_person.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_attention_person.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_person.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_person.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_attention_person.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_attention_person.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_attention_person.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_attention_person.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_attention_person.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_person.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_person.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmb_attention_person.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_attention_person.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_attention_person.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmb_attention_person.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_attention_person.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_person.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_person.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.cmb_attention_person.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_attention_person.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_attention_person.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.cmb_attention_person.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_attention_person.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_person.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_person.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.cmb_attention_person.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_attention_person.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_attention_person.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmb_attention_person.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_attention_person.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_attention_person.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_attention_person.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.cmb_attention_person.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_attention_person.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_attention_person.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.cmb_attention_person.Properties.AutoHeight = False
        Me.cmb_attention_person.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_attention_person.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_attention_person.Properties.LookAndFeel.SkinName = "My Office 2019 White"
        Me.cmb_attention_person.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_attention_person.Properties.NullText = ""
        Me.cmb_attention_person.Properties.PopupView = Me.dgv_sales_customers
        Me.cmb_attention_person.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.cmb_attention_person.Size = New System.Drawing.Size(400, 30)
        Me.cmb_attention_person.TabIndex = 1
        Me.cmb_attention_person.Tag = "Responsable"
        ConditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule5.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_attention_person, ConditionValidationRule5)
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
        'txt_attention_desc
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_attention_desc, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_attention_desc.Location = New System.Drawing.Point(719, 103)
        Me.txt_attention_desc.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_attention_desc.Name = "txt_attention_desc"
        Me.txt_attention_desc.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_attention_desc.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_attention_desc.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_attention_desc.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_attention_desc.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_attention_desc.Properties.Appearance.Options.UseBackColor = True
        Me.txt_attention_desc.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_attention_desc.Properties.Appearance.Options.UseFont = True
        Me.txt_attention_desc.Properties.Appearance.Options.UseForeColor = True
        Me.txt_attention_desc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_attention_desc.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_attention_desc.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.xvp_spell.SetShowSpellCheckMenu(Me.txt_attention_desc, True)
        Me.txt_attention_desc.Size = New System.Drawing.Size(430, 238)
        Me.xvp_spell.SetSpellCheckerOptions(Me.txt_attention_desc, OptionsSpelling1)
        Me.txt_attention_desc.TabIndex = 6
        Me.txt_attention_desc.Tag = "Descripción"
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
        Me.xvp_spell.ParentContainer = Nothing
        Me.xvp_spell.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType
        Me.xvp_spell.SpellingFormType = DevExpress.XtraSpellChecker.SpellingFormType.Word
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
        Me.lbl_object_title.Text = "Crear Atención"
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
        'pnl_object_bottom
        '
        Me.pnl_object_bottom.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_bottom.Controls.Add(Me.chk_row_visible)
        Me.pnl_object_bottom.Controls.Add(Me.btn_object_accept)
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
        'chk_row_visible
        '
        Me.chk_row_visible.EditValue = True
        Me.chk_row_visible.Location = New System.Drawing.Point(48, 18)
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
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.lbl_object_caracters)
        Me.pnl_object_container.Controls.Add(Me.lbl_attention_ticket)
        Me.pnl_object_container.Controls.Add(Me.txt_attention_count)
        Me.pnl_object_container.Controls.Add(Me.cmb_attention_theme)
        Me.pnl_object_container.Controls.Add(Me.lbl_attention_desc)
        Me.pnl_object_container.Controls.Add(Me.lbl_attention_created)
        Me.pnl_object_container.Controls.Add(Me.txt_attention_date)
        Me.pnl_object_container.Controls.Add(Me.cmb_attention_topic)
        Me.pnl_object_container.Controls.Add(Me.lbl_attention_theme)
        Me.pnl_object_container.Controls.Add(Me.lbl_attention_topic)
        Me.pnl_object_container.Controls.Add(Me.cmb_attention_person)
        Me.pnl_object_container.Controls.Add(Me.lbl_attention_person)
        Me.pnl_object_container.Controls.Add(Me.txt_attention_desc)
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
        'lbl_object_caracters
        '
        Me.lbl_object_caracters.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_caracters.Appearance.Options.UseForeColor = True
        Me.lbl_object_caracters.Location = New System.Drawing.Point(1122, 345)
        Me.lbl_object_caracters.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_caracters.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_caracters.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_caracters.Name = "lbl_object_caracters"
        Me.lbl_object_caracters.Size = New System.Drawing.Size(27, 16)
        Me.lbl_object_caracters.TabIndex = 0
        Me.lbl_object_caracters.Text = "0/500"
        '
        'lbl_attention_ticket
        '
        Me.lbl_attention_ticket.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_attention_ticket.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_attention_ticket.Appearance.Options.UseFont = True
        Me.lbl_attention_ticket.Appearance.Options.UseForeColor = True
        Me.lbl_attention_ticket.Location = New System.Drawing.Point(473, 291)
        Me.lbl_attention_ticket.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_attention_ticket.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_attention_ticket.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_attention_ticket.Name = "lbl_attention_ticket"
        Me.lbl_attention_ticket.Size = New System.Drawing.Size(85, 16)
        Me.lbl_attention_ticket.TabIndex = 0
        Me.lbl_attention_ticket.Text = "Total de registros*"
        '
        'lbl_attention_desc
        '
        Me.lbl_attention_desc.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_attention_desc.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_attention_desc.Appearance.Options.UseFont = True
        Me.lbl_attention_desc.Appearance.Options.UseForeColor = True
        Me.lbl_attention_desc.Location = New System.Drawing.Point(719, 83)
        Me.lbl_attention_desc.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_attention_desc.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_attention_desc.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_attention_desc.Name = "lbl_attention_desc"
        Me.lbl_attention_desc.Size = New System.Drawing.Size(214, 16)
        Me.lbl_attention_desc.TabIndex = 0
        Me.lbl_attention_desc.Text = "Descripción de la gestión comercial realizada*"
        '
        'lbl_attention_created
        '
        Me.lbl_attention_created.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_attention_created.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_attention_created.Appearance.Options.UseFont = True
        Me.lbl_attention_created.Appearance.Options.UseForeColor = True
        Me.lbl_attention_created.Location = New System.Drawing.Point(210, 291)
        Me.lbl_attention_created.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_attention_created.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_attention_created.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_attention_created.Name = "lbl_attention_created"
        Me.lbl_attention_created.Size = New System.Drawing.Size(91, 16)
        Me.lbl_attention_created.TabIndex = 0
        Me.lbl_attention_created.Text = "Fecha de vigencia*"
        '
        'lbl_attention_theme
        '
        Me.lbl_attention_theme.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_attention_theme.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_attention_theme.Appearance.Options.UseFont = True
        Me.lbl_attention_theme.Appearance.Options.UseForeColor = True
        Me.lbl_attention_theme.Location = New System.Drawing.Point(210, 222)
        Me.lbl_attention_theme.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_attention_theme.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_attention_theme.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_attention_theme.Name = "lbl_attention_theme"
        Me.lbl_attention_theme.Size = New System.Drawing.Size(162, 16)
        Me.lbl_attention_theme.TabIndex = 0
        Me.lbl_attention_theme.Text = "Defina el tipo de gestión a realizar*"
        '
        'lbl_attention_topic
        '
        Me.lbl_attention_topic.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_attention_topic.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_attention_topic.Appearance.Options.UseFont = True
        Me.lbl_attention_topic.Appearance.Options.UseForeColor = True
        Me.lbl_attention_topic.Location = New System.Drawing.Point(210, 153)
        Me.lbl_attention_topic.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_attention_topic.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_attention_topic.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_attention_topic.Name = "lbl_attention_topic"
        Me.lbl_attention_topic.Size = New System.Drawing.Size(193, 16)
        Me.lbl_attention_topic.TabIndex = 0
        Me.lbl_attention_topic.Text = "Seleccione el tipo de atención a registrar*"
        '
        'lbl_attention_person
        '
        Me.lbl_attention_person.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_attention_person.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_attention_person.Appearance.Options.UseFont = True
        Me.lbl_attention_person.Appearance.Options.UseForeColor = True
        Me.lbl_attention_person.Location = New System.Drawing.Point(210, 83)
        Me.lbl_attention_person.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_attention_person.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_attention_person.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_attention_person.Name = "lbl_attention_person"
        Me.lbl_attention_person.Size = New System.Drawing.Size(167, 16)
        Me.lbl_attention_person.TabIndex = 0
        Me.lbl_attention_person.Text = "Seleccione el nombre del consultor*"
        '
        'comercial_attention_massive
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
        Me.Name = "comercial_attention_massive"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(1350, 550)
        Me.Tag = "Crear Gestión"
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_attention_count.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_attention_theme.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_attention_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_attention_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_attention_topic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_attention_person.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_sales_customers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_attention_desc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_top.ResumeLayout(False)
        CType(Me.pnl_object_bottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_bottom.ResumeLayout(False)
        CType(Me.chk_row_visible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents xvp_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents xvp_spell As DevExpress.XtraSpellChecker.SpellChecker
    Friend WithEvents pnl_object_top As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_object_info As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_refresh As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_cancel As Button
    Friend WithEvents pnl_object_bottom As DevExpress.XtraEditors.PanelControl
    Protected WithEvents chk_row_visible As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btn_object_accept As Button
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_object_caracters As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_attention_ticket As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_attention_count As APDA.Object.Controls.TextboxEdit
    Friend WithEvents cmb_attention_theme As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_attention_desc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_attention_created As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_attention_date As APDA.Object.Controls.TextboxDates
    Friend WithEvents cmb_attention_topic As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_attention_theme As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_attention_topic As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_attention_person As APDA.Object.Controls.ComboboxSearch
    Friend WithEvents dgv_sales_customers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbl_attention_person As DevExpress.XtraEditors.LabelControl
    Private WithEvents txt_attention_desc As DevExpress.XtraEditors.MemoEdit
End Class
