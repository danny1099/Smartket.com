<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wholesales_masters_discount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wholesales_masters_discount))
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.cmb_discount_type = New APDA.[Object].Controls.ComboboxEdit()
        Me.txt_discount_value = New APDA.[Object].Controls.TextboxEdit()
        Me.txt_discount_comment = New APDA.[Object].Controls.TextboxMemo()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_discount_comment = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_discount_value = New DevExpress.XtraEditors.LabelControl()
        Me.chk_keep_form = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.lbl_discount_type = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_discount_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_discount_value.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_discount_comment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        CType(Me.chk_keep_form.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xvp_validate
        '
        Me.xvp_validate.ValidateHiddenControls = False
        Me.xvp_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.[Auto]
        '
        'cmb_discount_type
        '
        Me.cmb_discount_type.Tag = "Tipo de descuento"
        Me.xvp_validate.SetIconAlignment(Me.cmb_discount_type, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_discount_type.Location = New System.Drawing.Point(41, 142)
        Me.cmb_discount_type.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_discount_type.Name = "cmb_discount_type"
        Me.cmb_discount_type.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_discount_type.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_discount_type.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_discount_type.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_discount_type.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_discount_type.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_discount_type.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_discount_type.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_discount_type.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_discount_type.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_discount_type.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_discount_type.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_discount_type.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_discount_type.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_discount_type.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_discount_type.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_discount_type.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_discount_type.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_discount_type.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_discount_type.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_discount_type.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_discount_type.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_discount_type.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_discount_type.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_discount_type.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_discount_type.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_discount_type.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_discount_type.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_discount_type.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_discount_type.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_discount_type.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_discount_type.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_discount_type.Properties.AutoHeight = False
        Me.cmb_discount_type.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_discount_type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Left, "", -1, True, False, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.cmb_discount_type.Properties.DropDownItemHeight = 30
        Me.cmb_discount_type.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_discount_type.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_discount_type.Properties.NullText = ""
        Me.cmb_discount_type.Properties.ShowFooter = False
        Me.cmb_discount_type.Properties.ShowHeader = False
        Me.cmb_discount_type.Properties.ShowLines = False
        Me.cmb_discount_type.Size = New System.Drawing.Size(430, 35)
        Me.cmb_discount_type.TabIndex = 1
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_discount_type, ConditionValidationRule1)
        '
        'txt_discount_value
        '
        Me.txt_discount_value.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_discount_value.Tag = "Valor de descuento"
        Me.xvp_validate.SetIconAlignment(Me.txt_discount_value, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_discount_value.Location = New System.Drawing.Point(41, 217)
        Me.txt_discount_value.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_discount_value.Name = "txt_discount_value"
        Me.txt_discount_value.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_discount_value.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_discount_value.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_discount_value.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_discount_value.Properties.Appearance.Options.UseBackColor = True
        Me.txt_discount_value.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_discount_value.Properties.Appearance.Options.UseForeColor = True
        Me.txt_discount_value.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_discount_value.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_discount_value.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_discount_value.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_discount_value.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_discount_value.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_discount_value.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_discount_value.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_discount_value.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_discount_value.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_discount_value.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_discount_value.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_discount_value.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_discount_value.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_discount_value.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_discount_value.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_discount_value.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_discount_value.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_discount_value.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_discount_value.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_discount_value.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_discount_value.Properties.AutoHeight = False
        Me.txt_discount_value.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_discount_value.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, True, False, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_discount_value.Properties.DisplayFormat.FormatString = "c0"
        Me.txt_discount_value.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_discount_value.Properties.EditFormat.FormatString = "c0"
        Me.txt_discount_value.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_discount_value.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_discount_value.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_discount_value.Properties.Mask.EditMask = "c0"
        Me.txt_discount_value.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_discount_value.Size = New System.Drawing.Size(430, 35)
        Me.txt_discount_value.TabIndex = 8
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_discount_value, ConditionValidationRule2)
        '
        'txt_discount_comment
        '
        Me.txt_discount_comment.Tag = "Descripción"
        Me.xvp_validate.SetIconAlignment(Me.txt_discount_comment, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_discount_comment.Location = New System.Drawing.Point(41, 291)
        Me.txt_discount_comment.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_discount_comment.Name = "txt_discount_comment"
        Me.txt_discount_comment.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_discount_comment.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_discount_comment.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_discount_comment.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_discount_comment.Properties.Appearance.Options.UseBackColor = True
        Me.txt_discount_comment.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_discount_comment.Properties.Appearance.Options.UseForeColor = True
        Me.txt_discount_comment.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_discount_comment.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_discount_comment.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_discount_comment.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_discount_comment.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_discount_comment.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_discount_comment.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_discount_comment.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_discount_comment.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_discount_comment.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_discount_comment.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_discount_comment.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_discount_comment.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_discount_comment.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_discount_comment.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_discount_comment.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_discount_comment.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_discount_comment.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_discount_comment.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_discount_comment.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_discount_comment.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_discount_comment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_discount_comment.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_discount_comment.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_discount_comment.Properties.MaxLength = 300
        Me.txt_discount_comment.Size = New System.Drawing.Size(430, 72)
        Me.txt_discount_comment.TabIndex = 10
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.lbl_discount_comment)
        Me.pnl_object_container.Controls.Add(Me.txt_discount_comment)
        Me.pnl_object_container.Controls.Add(Me.lbl_discount_value)
        Me.pnl_object_container.Controls.Add(Me.txt_discount_value)
        Me.pnl_object_container.Controls.Add(Me.chk_keep_form)
        Me.pnl_object_container.Controls.Add(Me.btn_object_cancel)
        Me.pnl_object_container.Controls.Add(Me.lbl_discount_type)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_title)
        Me.pnl_object_container.Controls.Add(Me.btn_object_accept)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_info)
        Me.pnl_object_container.Controls.Add(Me.cmb_discount_type)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 1)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_container.Size = New System.Drawing.Size(513, 458)
        Me.pnl_object_container.TabIndex = 0
        '
        'lbl_discount_comment
        '
        Me.lbl_discount_comment.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_discount_comment.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_discount_comment.Appearance.Options.UseFont = True
        Me.lbl_discount_comment.Appearance.Options.UseForeColor = True
        Me.lbl_discount_comment.Location = New System.Drawing.Point(41, 271)
        Me.lbl_discount_comment.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_discount_comment.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_discount_comment.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_discount_comment.Name = "lbl_discount_comment"
        Me.lbl_discount_comment.Size = New System.Drawing.Size(127, 16)
        Me.lbl_discount_comment.TabIndex = 0
        Me.lbl_discount_comment.Text = "Descripción y/o comentario"
        '
        'lbl_discount_value
        '
        Me.lbl_discount_value.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_discount_value.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_discount_value.Appearance.Options.UseFont = True
        Me.lbl_discount_value.Appearance.Options.UseForeColor = True
        Me.lbl_discount_value.Location = New System.Drawing.Point(41, 197)
        Me.lbl_discount_value.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_discount_value.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_discount_value.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_discount_value.Name = "lbl_discount_value"
        Me.lbl_discount_value.Size = New System.Drawing.Size(198, 16)
        Me.lbl_discount_value.TabIndex = 0
        Me.lbl_discount_value.Text = "Defina el valor del descuento de comisión*"
        '
        'chk_keep_form
        '
        Me.chk_keep_form.Location = New System.Drawing.Point(41, 425)
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
        'lbl_discount_type
        '
        Me.lbl_discount_type.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_discount_type.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_discount_type.Appearance.Options.UseFont = True
        Me.lbl_discount_type.Appearance.Options.UseForeColor = True
        Me.lbl_discount_type.Location = New System.Drawing.Point(41, 121)
        Me.lbl_discount_type.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_discount_type.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_discount_type.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_discount_type.Name = "lbl_discount_type"
        Me.lbl_discount_type.Size = New System.Drawing.Size(173, 16)
        Me.lbl_discount_type.TabIndex = 0
        Me.lbl_discount_type.Text = "Defina el tipo de descuento a aplicar*"
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
        Me.lbl_object_title.Size = New System.Drawing.Size(151, 38)
        Me.lbl_object_title.TabIndex = 0
        Me.lbl_object_title.Text = "Crear Descuento"
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
        Me.btn_object_accept.Location = New System.Drawing.Point(411, 405)
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
        'wholesales_masters_discount
        '
        Me.AccessibleName = "WS004D"
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(515, 460)
        Me.Controls.Add(Me.pnl_object_container)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IconOptions.Icon = CType(resources.GetObject("wholesales_masters_discount.IconOptions.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Office 2019 White"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "wholesales_masters_discount"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Crear Descuento"
        Me.TopMost = True
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_discount_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_discount_value.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_discount_comment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        CType(Me.chk_keep_form.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents xvp_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_object_cancel As Button
    Friend WithEvents lbl_discount_type As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_accept As Button
    Friend WithEvents lbl_object_info As DevExpress.XtraEditors.LabelControl
    Protected WithEvents chk_keep_form As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmb_discount_type As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_discount_value As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_discount_value As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_discount_comment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_discount_comment As APDA.Object.Controls.TextboxMemo
End Class
