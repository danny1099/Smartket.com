<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class conditions_counts_create
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(conditions_counts_create))
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.cmb_condition_payment = New APDA.[Object].Controls.ComboboxEdit()
        Me.cmb_condition_rule = New APDA.[Object].Controls.ComboboxEdit()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.chk_object_counters = New DevExpress.XtraEditors.CheckEdit()
        Me.lbl_condition_rule = New DevExpress.XtraEditors.LabelControl()
        Me.chk_object_compare = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.chk_keep_form = New DevExpress.XtraEditors.CheckEdit()
        Me.lbl_condition_payment = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_condition_payment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_condition_rule.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        CType(Me.chk_object_counters.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_object_compare.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_keep_form.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xvp_validate
        '
        Me.xvp_validate.ValidateHiddenControls = False
        Me.xvp_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'cmb_condition_payment
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_condition_payment, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_condition_payment.Location = New System.Drawing.Point(41, 153)
        Me.cmb_condition_payment.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_condition_payment.Name = "cmb_condition_payment"
        Me.cmb_condition_payment.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_condition_payment.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_condition_payment.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_condition_payment.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_condition_payment.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_condition_payment.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_condition_payment.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_condition_payment.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_condition_payment.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_condition_payment.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_condition_payment.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_condition_payment.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_condition_payment.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_condition_payment.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_condition_payment.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_condition_payment.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_condition_payment.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_condition_payment.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_condition_payment.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_condition_payment.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_condition_payment.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_condition_payment.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_condition_payment.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_condition_payment.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_condition_payment.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_condition_payment.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_condition_payment.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_condition_payment.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_condition_payment.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_condition_payment.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_condition_payment.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_condition_payment.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_condition_payment.Properties.AutoHeight = False
        Me.cmb_condition_payment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_condition_payment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Left, "", -1, True, False, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.cmb_condition_payment.Properties.DropDownItemHeight = 30
        Me.cmb_condition_payment.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_condition_payment.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_condition_payment.Properties.NullText = ""
        Me.cmb_condition_payment.Properties.ShowFooter = False
        Me.cmb_condition_payment.Properties.ShowHeader = False
        Me.cmb_condition_payment.Properties.ShowLines = False
        Me.cmb_condition_payment.Size = New System.Drawing.Size(430, 35)
        Me.cmb_condition_payment.TabIndex = 1
        Me.cmb_condition_payment.Tag = "Tipo de liquidación"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_condition_payment, ConditionValidationRule1)
        '
        'cmb_condition_rule
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_condition_rule, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_condition_rule.Location = New System.Drawing.Point(41, 228)
        Me.cmb_condition_rule.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_condition_rule.Name = "cmb_condition_rule"
        Me.cmb_condition_rule.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_condition_rule.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_condition_rule.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_condition_rule.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_condition_rule.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_condition_rule.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_condition_rule.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_condition_rule.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_condition_rule.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_condition_rule.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_condition_rule.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_condition_rule.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_condition_rule.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_condition_rule.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_condition_rule.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_condition_rule.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_condition_rule.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_condition_rule.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_condition_rule.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_condition_rule.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_condition_rule.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_condition_rule.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_condition_rule.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_condition_rule.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_condition_rule.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_condition_rule.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_condition_rule.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_condition_rule.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_condition_rule.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_condition_rule.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_condition_rule.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_condition_rule.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_condition_rule.Properties.AutoHeight = False
        Me.cmb_condition_rule.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_condition_rule.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Left, "", -1, True, False, True, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.cmb_condition_rule.Properties.DropDownItemHeight = 30
        Me.cmb_condition_rule.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_condition_rule.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_condition_rule.Properties.NullText = ""
        Me.cmb_condition_rule.Properties.ShowFooter = False
        Me.cmb_condition_rule.Properties.ShowHeader = False
        Me.cmb_condition_rule.Properties.ShowLines = False
        Me.cmb_condition_rule.Size = New System.Drawing.Size(430, 35)
        Me.cmb_condition_rule.TabIndex = 2
        Me.cmb_condition_rule.Tag = "Regla de conteo"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_condition_rule, ConditionValidationRule2)
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.chk_object_counters)
        Me.pnl_object_container.Controls.Add(Me.lbl_condition_rule)
        Me.pnl_object_container.Controls.Add(Me.cmb_condition_rule)
        Me.pnl_object_container.Controls.Add(Me.chk_object_compare)
        Me.pnl_object_container.Controls.Add(Me.btn_object_cancel)
        Me.pnl_object_container.Controls.Add(Me.chk_keep_form)
        Me.pnl_object_container.Controls.Add(Me.lbl_condition_payment)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_title)
        Me.pnl_object_container.Controls.Add(Me.btn_object_accept)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_info)
        Me.pnl_object_container.Controls.Add(Me.cmb_condition_payment)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 1)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_container.Size = New System.Drawing.Size(513, 395)
        Me.pnl_object_container.TabIndex = 0
        '
        'chk_object_counters
        '
        Me.chk_object_counters.Location = New System.Drawing.Point(232, 289)
        Me.chk_object_counters.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_object_counters.Name = "chk_object_counters"
        Me.chk_object_counters.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.chk_object_counters.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.chk_object_counters.Properties.Appearance.BorderColor = System.Drawing.Color.White
        Me.chk_object_counters.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_object_counters.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.chk_object_counters.Properties.Appearance.Options.UseBackColor = True
        Me.chk_object_counters.Properties.Appearance.Options.UseBorderColor = True
        Me.chk_object_counters.Properties.Appearance.Options.UseFont = True
        Me.chk_object_counters.Properties.Appearance.Options.UseForeColor = True
        Me.chk_object_counters.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.chk_object_counters.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.chk_object_counters.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.White
        Me.chk_object_counters.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_object_counters.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.chk_object_counters.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.chk_object_counters.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.chk_object_counters.Properties.AppearanceDisabled.Options.UseFont = True
        Me.chk_object_counters.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.chk_object_counters.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.chk_object_counters.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.chk_object_counters.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.White
        Me.chk_object_counters.Properties.AppearanceFocused.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_object_counters.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.DimGray
        Me.chk_object_counters.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.chk_object_counters.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.chk_object_counters.Properties.AppearanceFocused.Options.UseFont = True
        Me.chk_object_counters.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.chk_object_counters.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.chk_object_counters.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.chk_object_counters.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White
        Me.chk_object_counters.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_object_counters.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.chk_object_counters.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.chk_object_counters.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.chk_object_counters.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.chk_object_counters.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.chk_object_counters.Properties.Caption = "Consolidar el conteo sobre ventas pendientes?"
        Me.chk_object_counters.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chk_object_counters.Properties.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.chk_object_counters.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.chk_object_counters.Size = New System.Drawing.Size(242, 20)
        Me.chk_object_counters.TabIndex = 4
        Me.chk_object_counters.Tag = "Consolida Pendientes"
        '
        'lbl_condition_rule
        '
        Me.lbl_condition_rule.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_condition_rule.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_condition_rule.Appearance.Options.UseFont = True
        Me.lbl_condition_rule.Appearance.Options.UseForeColor = True
        Me.lbl_condition_rule.Location = New System.Drawing.Point(41, 208)
        Me.lbl_condition_rule.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_condition_rule.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_condition_rule.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_condition_rule.Name = "lbl_condition_rule"
        Me.lbl_condition_rule.Size = New System.Drawing.Size(186, 16)
        Me.lbl_condition_rule.TabIndex = 0
        Me.lbl_condition_rule.Text = "Defina el nombre de la regla de conteo*"
        '
        'chk_object_compare
        '
        Me.chk_object_compare.Location = New System.Drawing.Point(217, 266)
        Me.chk_object_compare.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_object_compare.Name = "chk_object_compare"
        Me.chk_object_compare.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.chk_object_compare.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.chk_object_compare.Properties.Appearance.BorderColor = System.Drawing.Color.White
        Me.chk_object_compare.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_object_compare.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.chk_object_compare.Properties.Appearance.Options.UseBackColor = True
        Me.chk_object_compare.Properties.Appearance.Options.UseBorderColor = True
        Me.chk_object_compare.Properties.Appearance.Options.UseFont = True
        Me.chk_object_compare.Properties.Appearance.Options.UseForeColor = True
        Me.chk_object_compare.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.chk_object_compare.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.chk_object_compare.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.White
        Me.chk_object_compare.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_object_compare.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.chk_object_compare.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.chk_object_compare.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.chk_object_compare.Properties.AppearanceDisabled.Options.UseFont = True
        Me.chk_object_compare.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.chk_object_compare.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.chk_object_compare.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.chk_object_compare.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.White
        Me.chk_object_compare.Properties.AppearanceFocused.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_object_compare.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.DimGray
        Me.chk_object_compare.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.chk_object_compare.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.chk_object_compare.Properties.AppearanceFocused.Options.UseFont = True
        Me.chk_object_compare.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.chk_object_compare.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.chk_object_compare.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.chk_object_compare.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White
        Me.chk_object_compare.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_object_compare.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.chk_object_compare.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.chk_object_compare.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.chk_object_compare.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.chk_object_compare.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.chk_object_compare.Properties.Caption = "La regla de conteo debe comparar presupuestos?"
        Me.chk_object_compare.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chk_object_compare.Properties.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.chk_object_compare.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.chk_object_compare.Size = New System.Drawing.Size(257, 20)
        Me.chk_object_compare.TabIndex = 3
        Me.chk_object_compare.Tag = "Compara Presupuesto"
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
        Me.btn_object_cancel.Location = New System.Drawing.Point(481, 4)
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
        Me.chk_keep_form.Location = New System.Drawing.Point(40, 362)
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
        Me.chk_keep_form.Size = New System.Drawing.Size(176, 20)
        Me.chk_keep_form.TabIndex = 0
        '
        'lbl_condition_payment
        '
        Me.lbl_condition_payment.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_condition_payment.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_condition_payment.Appearance.Options.UseFont = True
        Me.lbl_condition_payment.Appearance.Options.UseForeColor = True
        Me.lbl_condition_payment.Location = New System.Drawing.Point(41, 133)
        Me.lbl_condition_payment.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_condition_payment.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_condition_payment.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_condition_payment.Name = "lbl_condition_payment"
        Me.lbl_condition_payment.Size = New System.Drawing.Size(233, 16)
        Me.lbl_condition_payment.TabIndex = 0
        Me.lbl_condition_payment.Text = "Defina el tipo de liquidación de la regla de conteo*"
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
        Me.lbl_object_title.Text = "Regla de conteo"
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
        Me.btn_object_accept.Location = New System.Drawing.Point(411, 342)
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
        Me.lbl_object_info.Location = New System.Drawing.Point(40, 59)
        Me.lbl_object_info.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_info.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_info.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_info.Name = "lbl_object_info"
        Me.lbl_object_info.Size = New System.Drawing.Size(232, 18)
        Me.lbl_object_info.TabIndex = 0
        Me.lbl_object_info.Text = "Los campos marcados con asterico (*) son requeridos..."
        '
        'conditions_counts_create
        '
        Me.AcceptButton = Me.btn_object_accept
        Me.AccessibleName = "CCT002C"
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.btn_object_cancel
        Me.ClientSize = New System.Drawing.Size(515, 397)
        Me.Controls.Add(Me.pnl_object_container)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IconOptions.Icon = CType(resources.GetObject("conditions_counts_create.IconOptions.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Office 2019 White"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "conditions_counts_create"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Asociar Regla"
        Me.TopMost = True
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_condition_payment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_condition_rule.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        CType(Me.chk_object_counters.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_object_compare.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_keep_form.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents xvp_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_object_cancel As Button
    Protected WithEvents chk_keep_form As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lbl_condition_payment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_accept As Button
    Friend WithEvents lbl_object_info As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_condition_payment As APDA.Object.Controls.ComboboxEdit
    Protected WithEvents chk_object_compare As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lbl_condition_rule As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_condition_rule As APDA.Object.Controls.ComboboxEdit
    Protected WithEvents chk_object_counters As DevExpress.XtraEditors.CheckEdit
End Class
