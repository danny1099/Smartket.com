<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class commision_settleds_edited
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(commision_settleds_edited))
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.cmb_settled_period = New APDA.[Object].Controls.ComboboxEdit()
        Me.cmb_settled_segment = New APDA.[Object].Controls.ComboboxEdit()
        Me.txt_settled_payment = New APDA.[Object].Controls.TextboxEdit()
        Me.txt_settled_increase = New APDA.[Object].Controls.TextboxEdit()
        Me.txt_condition_desc = New APDA.[Object].Controls.TextboxMemo()
        Me.pnl_object_top = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_refresh = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.pnl_object_bottom = New DevExpress.XtraEditors.PanelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.chk_row_visible = New DevExpress.XtraEditors.CheckEdit()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_settled_increase = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_settled_criteria = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_settled_payment = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_settled_serial = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_settled_period = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_settled_segment = New DevExpress.XtraEditors.LabelControl()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_settled_period.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_settled_segment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_settled_payment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_settled_increase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_condition_desc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'cmb_settled_period
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_settled_period, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_settled_period.Location = New System.Drawing.Point(210, 173)
        Me.cmb_settled_period.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_settled_period.Name = "cmb_settled_period"
        Me.cmb_settled_period.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_settled_period.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_period.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_period.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_settled_period.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_settled_period.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_settled_period.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_settled_period.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_settled_period.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_period.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_period.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_settled_period.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_settled_period.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_settled_period.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_period.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_period.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_settled_period.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_settled_period.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_settled_period.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_period.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_period.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_settled_period.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_settled_period.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_settled_period.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_period.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_period.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_settled_period.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_settled_period.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_settled_period.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_period.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_period.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_settled_period.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_settled_period.Properties.AutoHeight = False
        Me.cmb_settled_period.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_settled_period.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_settled_period.Properties.DropDownItemHeight = 30
        Me.cmb_settled_period.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_settled_period.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_settled_period.Properties.NullText = ""
        Me.cmb_settled_period.Properties.ShowFooter = False
        Me.cmb_settled_period.Properties.ShowHeader = False
        Me.cmb_settled_period.Size = New System.Drawing.Size(400, 30)
        Me.cmb_settled_period.TabIndex = 2
        Me.cmb_settled_period.Tag = "Periodo"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_settled_period, ConditionValidationRule1)
        '
        'cmb_settled_segment
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_settled_segment, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_settled_segment.Location = New System.Drawing.Point(210, 103)
        Me.cmb_settled_segment.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_settled_segment.Name = "cmb_settled_segment"
        Me.cmb_settled_segment.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_settled_segment.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_segment.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_segment.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_settled_segment.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_settled_segment.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_settled_segment.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_settled_segment.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_settled_segment.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_segment.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_segment.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_settled_segment.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_settled_segment.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_settled_segment.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_segment.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_segment.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_settled_segment.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_settled_segment.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_settled_segment.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_segment.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_segment.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_settled_segment.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_settled_segment.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_settled_segment.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_segment.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_segment.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_settled_segment.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_settled_segment.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_settled_segment.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_segment.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_segment.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_settled_segment.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_settled_segment.Properties.AutoHeight = False
        Me.cmb_settled_segment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_settled_segment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_settled_segment.Properties.DropDownItemHeight = 30
        Me.cmb_settled_segment.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_settled_segment.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_settled_segment.Properties.NullText = ""
        Me.cmb_settled_segment.Properties.ShowFooter = False
        Me.cmb_settled_segment.Properties.ShowHeader = False
        Me.cmb_settled_segment.Size = New System.Drawing.Size(400, 30)
        Me.cmb_settled_segment.TabIndex = 1
        Me.cmb_settled_segment.Tag = "Segmento"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_settled_segment, ConditionValidationRule2)
        '
        'txt_settled_payment
        '
        Me.txt_settled_payment.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.xvp_validate.SetIconAlignment(Me.txt_settled_payment, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_settled_payment.Location = New System.Drawing.Point(210, 242)
        Me.txt_settled_payment.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_settled_payment.Name = "txt_settled_payment"
        Me.txt_settled_payment.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_settled_payment.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_settled_payment.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_settled_payment.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_settled_payment.Properties.Appearance.Options.UseBackColor = True
        Me.txt_settled_payment.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_settled_payment.Properties.Appearance.Options.UseForeColor = True
        Me.txt_settled_payment.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_settled_payment.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_settled_payment.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_settled_payment.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_settled_payment.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_settled_payment.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_settled_payment.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_settled_payment.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_settled_payment.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_settled_payment.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_settled_payment.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_settled_payment.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_settled_payment.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_settled_payment.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_settled_payment.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_settled_payment.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_settled_payment.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_settled_payment.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_settled_payment.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_settled_payment.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_settled_payment.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_settled_payment.Properties.AutoHeight = False
        Me.txt_settled_payment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_settled_payment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, True, False, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_settled_payment.Properties.DisplayFormat.FormatString = "c0"
        Me.txt_settled_payment.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_settled_payment.Properties.EditFormat.FormatString = "c0"
        Me.txt_settled_payment.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_settled_payment.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_settled_payment.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_settled_payment.Properties.Mask.EditMask = "c0"
        Me.txt_settled_payment.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_settled_payment.Size = New System.Drawing.Size(400, 30)
        Me.txt_settled_payment.TabIndex = 6
        Me.txt_settled_payment.Tag = "Valor de comisión"
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_settled_payment, ConditionValidationRule3)
        '
        'txt_settled_increase
        '
        Me.txt_settled_increase.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.xvp_validate.SetIconAlignment(Me.txt_settled_increase, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_settled_increase.Location = New System.Drawing.Point(210, 311)
        Me.txt_settled_increase.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_settled_increase.Name = "txt_settled_increase"
        Me.txt_settled_increase.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_settled_increase.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_settled_increase.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_settled_increase.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_settled_increase.Properties.Appearance.Options.UseBackColor = True
        Me.txt_settled_increase.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_settled_increase.Properties.Appearance.Options.UseForeColor = True
        Me.txt_settled_increase.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_settled_increase.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_settled_increase.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_settled_increase.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_settled_increase.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_settled_increase.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_settled_increase.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_settled_increase.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_settled_increase.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_settled_increase.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_settled_increase.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_settled_increase.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_settled_increase.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_settled_increase.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_settled_increase.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_settled_increase.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_settled_increase.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_settled_increase.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_settled_increase.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_settled_increase.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_settled_increase.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_settled_increase.Properties.AutoHeight = False
        Me.txt_settled_increase.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_settled_increase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, True, False, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_settled_increase.Properties.DisplayFormat.FormatString = "c0"
        Me.txt_settled_increase.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_settled_increase.Properties.EditFormat.FormatString = "c0"
        Me.txt_settled_increase.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_settled_increase.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_settled_increase.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_settled_increase.Properties.Mask.EditMask = "c0"
        Me.txt_settled_increase.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_settled_increase.Size = New System.Drawing.Size(400, 30)
        Me.txt_settled_increase.TabIndex = 7
        Me.txt_settled_increase.Tag = "Valor de incremento"
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_settled_increase, ConditionValidationRule4)
        '
        'txt_condition_desc
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_condition_desc, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_condition_desc.Location = New System.Drawing.Point(719, 103)
        Me.txt_condition_desc.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_condition_desc.Name = "txt_condition_desc"
        Me.txt_condition_desc.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_condition_desc.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_condition_desc.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_condition_desc.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_condition_desc.Properties.Appearance.Options.UseBackColor = True
        Me.txt_condition_desc.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_condition_desc.Properties.Appearance.Options.UseForeColor = True
        Me.txt_condition_desc.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_condition_desc.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_condition_desc.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_condition_desc.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_condition_desc.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_condition_desc.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_condition_desc.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_condition_desc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_condition_desc.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_condition_desc.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_condition_desc.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_condition_desc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_condition_desc.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_condition_desc.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_condition_desc.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_condition_desc.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_condition_desc.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_condition_desc.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_condition_desc.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_condition_desc.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_condition_desc.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_condition_desc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_condition_desc.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_condition_desc.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_condition_desc.Properties.MaxLength = 300
        Me.txt_condition_desc.Size = New System.Drawing.Size(400, 238)
        Me.txt_condition_desc.TabIndex = 8
        Me.txt_condition_desc.Tag = "Descripción"
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
        Me.lbl_object_title.Text = "Editar Pago"
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
        'chk_row_visible
        '
        Me.chk_row_visible.EditValue = True
        Me.chk_row_visible.Location = New System.Drawing.Point(913, 345)
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
        Me.chk_row_visible.Size = New System.Drawing.Size(209, 20)
        Me.chk_row_visible.TabIndex = 0
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.chk_row_visible)
        Me.pnl_object_container.Controls.Add(Me.lbl_settled_increase)
        Me.pnl_object_container.Controls.Add(Me.lbl_settled_criteria)
        Me.pnl_object_container.Controls.Add(Me.lbl_settled_payment)
        Me.pnl_object_container.Controls.Add(Me.cmb_settled_period)
        Me.pnl_object_container.Controls.Add(Me.lbl_settled_serial)
        Me.pnl_object_container.Controls.Add(Me.lbl_settled_period)
        Me.pnl_object_container.Controls.Add(Me.lbl_settled_segment)
        Me.pnl_object_container.Controls.Add(Me.cmb_settled_segment)
        Me.pnl_object_container.Controls.Add(Me.txt_condition_desc)
        Me.pnl_object_container.Controls.Add(Me.txt_settled_payment)
        Me.pnl_object_container.Controls.Add(Me.txt_settled_increase)
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
        'lbl_settled_increase
        '
        Me.lbl_settled_increase.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_settled_increase.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_settled_increase.Appearance.Options.UseFont = True
        Me.lbl_settled_increase.Appearance.Options.UseForeColor = True
        Me.lbl_settled_increase.Location = New System.Drawing.Point(210, 291)
        Me.lbl_settled_increase.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_settled_increase.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_settled_increase.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_settled_increase.Name = "lbl_settled_increase"
        Me.lbl_settled_increase.Size = New System.Drawing.Size(201, 16)
        Me.lbl_settled_increase.TabIndex = 0
        Me.lbl_settled_increase.Text = "Defina el valor del incremento de comisión*"
        '
        'lbl_settled_criteria
        '
        Me.lbl_settled_criteria.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_settled_criteria.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_settled_criteria.Appearance.Options.UseFont = True
        Me.lbl_settled_criteria.Appearance.Options.UseForeColor = True
        Me.lbl_settled_criteria.Location = New System.Drawing.Point(719, 83)
        Me.lbl_settled_criteria.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_settled_criteria.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_settled_criteria.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_settled_criteria.Name = "lbl_settled_criteria"
        Me.lbl_settled_criteria.Size = New System.Drawing.Size(216, 16)
        Me.lbl_settled_criteria.TabIndex = 0
        Me.lbl_settled_criteria.Text = "Comentatios y/o descripción de la modificación"
        '
        'lbl_settled_payment
        '
        Me.lbl_settled_payment.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_settled_payment.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_settled_payment.Appearance.Options.UseFont = True
        Me.lbl_settled_payment.Appearance.Options.UseForeColor = True
        Me.lbl_settled_payment.Location = New System.Drawing.Point(210, 222)
        Me.lbl_settled_payment.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_settled_payment.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_settled_payment.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_settled_payment.Name = "lbl_settled_payment"
        Me.lbl_settled_payment.Size = New System.Drawing.Size(141, 16)
        Me.lbl_settled_payment.TabIndex = 0
        Me.lbl_settled_payment.Text = "Defina el valor de la comisión*"
        '
        'lbl_settled_serial
        '
        Me.lbl_settled_serial.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_settled_serial.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_settled_serial.Appearance.Options.UseFont = True
        Me.lbl_settled_serial.Appearance.Options.UseForeColor = True
        Me.lbl_settled_serial.Location = New System.Drawing.Point(210, 291)
        Me.lbl_settled_serial.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_settled_serial.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_settled_serial.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_settled_serial.Name = "lbl_settled_serial"
        Me.lbl_settled_serial.Size = New System.Drawing.Size(86, 16)
        Me.lbl_settled_serial.TabIndex = 0
        Me.lbl_settled_serial.Text = "Numero de venta*"
        '
        'lbl_settled_period
        '
        Me.lbl_settled_period.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_settled_period.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_settled_period.Appearance.Options.UseFont = True
        Me.lbl_settled_period.Appearance.Options.UseForeColor = True
        Me.lbl_settled_period.Location = New System.Drawing.Point(210, 153)
        Me.lbl_settled_period.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_settled_period.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_settled_period.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_settled_period.Name = "lbl_settled_period"
        Me.lbl_settled_period.Size = New System.Drawing.Size(207, 16)
        Me.lbl_settled_period.TabIndex = 0
        Me.lbl_settled_period.Text = "Defina el nombre del periodo de liquidación*"
        '
        'lbl_settled_segment
        '
        Me.lbl_settled_segment.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_settled_segment.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_settled_segment.Appearance.Options.UseFont = True
        Me.lbl_settled_segment.Appearance.Options.UseForeColor = True
        Me.lbl_settled_segment.Location = New System.Drawing.Point(210, 83)
        Me.lbl_settled_segment.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_settled_segment.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_settled_segment.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_settled_segment.Name = "lbl_settled_segment"
        Me.lbl_settled_segment.Size = New System.Drawing.Size(225, 16)
        Me.lbl_settled_segment.TabIndex = 0
        Me.lbl_settled_segment.Text = "Seleccione el nombre del segmento de negocio*"
        '
        'commision_settleds_edited
        '
        Me.AccessibleName = "CSP004E"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnl_object_container)
        Me.Controls.Add(Me.pnl_object_bottom)
        Me.Controls.Add(Me.pnl_object_top)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "commision_settleds_edited"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(1350, 550)
        Me.Tag = "Editar Pago"
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_settled_period.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_settled_segment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_settled_payment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_settled_increase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_condition_desc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pnl_object_top As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_object_info As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_refresh As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_cancel As Button
    Friend WithEvents pnl_object_bottom As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_object_accept As Button
    Protected WithEvents chk_row_visible As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_settled_criteria As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_settled_payment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_settled_period As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_settled_serial As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_settled_period As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_settled_segment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_settled_segment As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents txt_settled_increase As APDA.Object.Controls.TextboxEdit
    Friend WithEvents txt_settled_payment As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_settled_increase As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_condition_desc As APDA.Object.Controls.TextboxMemo
End Class
