<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class commision_rules_create
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
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule5 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule6 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(commision_rules_create))
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.txt_rules_name = New APDA.[Object].Controls.TextboxEdit()
        Me.cmb_rules_type = New APDA.[Object].Controls.ComboboxEdit()
        Me.cmb_rules_segment = New APDA.[Object].Controls.ComboboxEdit()
        Me.cmb_rules_operator = New APDA.[Object].Controls.ComboboxEdit()
        Me.cmb_rules_payment = New APDA.[Object].Controls.ComboboxEdit()
        Me.cmb_rules_function = New APDA.[Object].Controls.ComboboxEdit()
        Me.pnl_object_top = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_refresh = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.pnl_object_bottom = New DevExpress.XtraEditors.PanelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.chk_keep_form = New DevExpress.XtraEditors.CheckEdit()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_rules_function = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_rules_payment = New DevExpress.XtraEditors.LabelControl()
        Me.chk_object_conserve = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_rules_criteria = New APDA.[Object].Controls.TextboxFilter()
        Me.lbl_rules_condition = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_rules_name = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_rules_operator = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_rules_segment = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_rules_agency = New DevExpress.XtraEditors.LabelControl()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_rules_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_rules_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_rules_segment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_rules_operator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_rules_payment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_rules_function.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_top.SuspendLayout()
        CType(Me.pnl_object_bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_bottom.SuspendLayout()
        CType(Me.chk_keep_form.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        CType(Me.chk_object_conserve.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xvp_validate
        '
        Me.xvp_validate.ValidateHiddenControls = False
        Me.xvp_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'txt_rules_name
        '
        Me.txt_rules_name.EditValue = ""
        Me.xvp_validate.SetIconAlignment(Me.txt_rules_name, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_rules_name.Location = New System.Drawing.Point(233, 128)
        Me.txt_rules_name.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_rules_name.Name = "txt_rules_name"
        Me.txt_rules_name.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_rules_name.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_rules_name.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_rules_name.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_rules_name.Properties.Appearance.Options.UseBackColor = True
        Me.txt_rules_name.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_rules_name.Properties.Appearance.Options.UseForeColor = True
        Me.txt_rules_name.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_rules_name.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_rules_name.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_rules_name.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_rules_name.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_rules_name.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_rules_name.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_rules_name.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_rules_name.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_rules_name.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_rules_name.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_rules_name.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_rules_name.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_rules_name.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_rules_name.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_rules_name.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_rules_name.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_rules_name.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_rules_name.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_rules_name.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_rules_name.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_rules_name.Properties.AutoHeight = False
        Me.txt_rules_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_rules_name.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_rules_name.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_rules_name.Properties.Mask.BeepOnError = True
        Me.txt_rules_name.Properties.Mask.EditMask = "\d+"
        Me.txt_rules_name.Properties.MaxLength = 100
        Me.txt_rules_name.Size = New System.Drawing.Size(400, 30)
        Me.txt_rules_name.TabIndex = 2
        Me.txt_rules_name.Tag = "Nombre de regla"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_rules_name, ConditionValidationRule1)
        '
        'cmb_rules_type
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_rules_type, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_rules_type.Location = New System.Drawing.Point(233, 60)
        Me.cmb_rules_type.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_rules_type.Name = "cmb_rules_type"
        Me.cmb_rules_type.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_rules_type.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_type.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_type.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_rules_type.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_rules_type.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_rules_type.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_rules_type.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_rules_type.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_type.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_type.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_rules_type.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_rules_type.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_rules_type.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_type.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_type.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_rules_type.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_rules_type.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_rules_type.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_type.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_type.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_rules_type.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_rules_type.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_rules_type.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_type.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_type.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_rules_type.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_rules_type.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_rules_type.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_type.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_type.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_rules_type.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_rules_type.Properties.AutoHeight = False
        Me.cmb_rules_type.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_rules_type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_rules_type.Properties.DropDownItemHeight = 30
        Me.cmb_rules_type.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_rules_type.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_rules_type.Properties.NullText = ""
        Me.cmb_rules_type.Properties.ShowFooter = False
        Me.cmb_rules_type.Properties.ShowHeader = False
        Me.cmb_rules_type.Size = New System.Drawing.Size(400, 30)
        Me.cmb_rules_type.TabIndex = 1
        Me.cmb_rules_type.Tag = "Tipo de regla"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_rules_type, ConditionValidationRule2)
        '
        'cmb_rules_segment
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_rules_segment, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_rules_segment.Location = New System.Drawing.Point(233, 264)
        Me.cmb_rules_segment.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_rules_segment.Name = "cmb_rules_segment"
        Me.cmb_rules_segment.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_rules_segment.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_segment.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_segment.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_rules_segment.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_rules_segment.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_rules_segment.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_rules_segment.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_rules_segment.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_segment.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_segment.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_rules_segment.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_rules_segment.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_rules_segment.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_segment.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_segment.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_rules_segment.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_rules_segment.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_rules_segment.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_segment.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_segment.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_rules_segment.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_rules_segment.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_rules_segment.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_segment.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_segment.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_rules_segment.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_rules_segment.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_rules_segment.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_segment.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_segment.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_rules_segment.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_rules_segment.Properties.AutoHeight = False
        Me.cmb_rules_segment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_rules_segment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_rules_segment.Properties.DropDownItemHeight = 30
        Me.cmb_rules_segment.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_rules_segment.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_rules_segment.Properties.NullText = ""
        Me.cmb_rules_segment.Properties.ShowFooter = False
        Me.cmb_rules_segment.Properties.ShowHeader = False
        Me.cmb_rules_segment.Size = New System.Drawing.Size(400, 30)
        Me.cmb_rules_segment.TabIndex = 4
        Me.cmb_rules_segment.Tag = "Segmento"
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_rules_segment, ConditionValidationRule3)
        '
        'cmb_rules_operator
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_rules_operator, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_rules_operator.Location = New System.Drawing.Point(233, 196)
        Me.cmb_rules_operator.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_rules_operator.Name = "cmb_rules_operator"
        Me.cmb_rules_operator.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_rules_operator.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_operator.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_operator.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_rules_operator.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_rules_operator.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_rules_operator.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_rules_operator.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_rules_operator.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_operator.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_operator.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_rules_operator.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_rules_operator.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_rules_operator.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_operator.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_operator.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_rules_operator.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_rules_operator.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_rules_operator.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_operator.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_operator.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_rules_operator.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_rules_operator.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_rules_operator.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_operator.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_operator.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_rules_operator.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_rules_operator.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_rules_operator.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_operator.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_operator.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_rules_operator.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_rules_operator.Properties.AutoHeight = False
        Me.cmb_rules_operator.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_rules_operator.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_rules_operator.Properties.DropDownItemHeight = 30
        Me.cmb_rules_operator.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_rules_operator.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_rules_operator.Properties.NullText = ""
        Me.cmb_rules_operator.Properties.ShowFooter = False
        Me.cmb_rules_operator.Properties.ShowHeader = False
        Me.cmb_rules_operator.Size = New System.Drawing.Size(400, 30)
        Me.cmb_rules_operator.TabIndex = 3
        Me.cmb_rules_operator.Tag = "Operador"
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_rules_operator, ConditionValidationRule4)
        '
        'cmb_rules_payment
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_rules_payment, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_rules_payment.Location = New System.Drawing.Point(233, 332)
        Me.cmb_rules_payment.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_rules_payment.Name = "cmb_rules_payment"
        Me.cmb_rules_payment.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_rules_payment.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_payment.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_payment.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_rules_payment.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_rules_payment.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_rules_payment.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_rules_payment.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_rules_payment.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_payment.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_payment.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_rules_payment.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_rules_payment.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_rules_payment.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_payment.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_payment.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_rules_payment.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_rules_payment.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_rules_payment.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_payment.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_payment.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_rules_payment.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_rules_payment.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_rules_payment.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_payment.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_payment.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_rules_payment.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_rules_payment.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_rules_payment.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_payment.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_payment.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_rules_payment.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_rules_payment.Properties.AutoHeight = False
        Me.cmb_rules_payment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_rules_payment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_rules_payment.Properties.DropDownItemHeight = 30
        Me.cmb_rules_payment.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_rules_payment.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_rules_payment.Properties.NullText = ""
        Me.cmb_rules_payment.Properties.ShowFooter = False
        Me.cmb_rules_payment.Properties.ShowHeader = False
        Me.cmb_rules_payment.Size = New System.Drawing.Size(194, 30)
        Me.cmb_rules_payment.TabIndex = 5
        Me.cmb_rules_payment.Tag = "Tipo de liquidación"
        ConditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule5.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_rules_payment, ConditionValidationRule5)
        '
        'cmb_rules_function
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_rules_function, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_rules_function.Location = New System.Drawing.Point(439, 332)
        Me.cmb_rules_function.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_rules_function.Name = "cmb_rules_function"
        Me.cmb_rules_function.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_rules_function.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_function.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_function.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_rules_function.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_rules_function.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_rules_function.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_rules_function.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_rules_function.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_function.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_function.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_rules_function.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_rules_function.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_rules_function.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_function.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_function.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_rules_function.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_rules_function.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_rules_function.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_function.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_function.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_rules_function.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_rules_function.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_rules_function.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_function.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_function.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_rules_function.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_rules_function.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_rules_function.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_rules_function.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_rules_function.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_rules_function.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_rules_function.Properties.AutoHeight = False
        Me.cmb_rules_function.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_rules_function.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_rules_function.Properties.DropDownItemHeight = 30
        Me.cmb_rules_function.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_rules_function.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_rules_function.Properties.NullText = ""
        Me.cmb_rules_function.Properties.ShowFooter = False
        Me.cmb_rules_function.Properties.ShowHeader = False
        Me.cmb_rules_function.Size = New System.Drawing.Size(194, 30)
        Me.cmb_rules_function.TabIndex = 6
        Me.cmb_rules_function.Tag = "Metodo de ejecución"
        ConditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule6.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_rules_function, ConditionValidationRule6)
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
        Me.lbl_object_title.Text = "Crear Regla"
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
        'chk_keep_form
        '
        Me.chk_keep_form.Location = New System.Drawing.Point(1039, 386)
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
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.lbl_rules_function)
        Me.pnl_object_container.Controls.Add(Me.chk_keep_form)
        Me.pnl_object_container.Controls.Add(Me.cmb_rules_function)
        Me.pnl_object_container.Controls.Add(Me.cmb_rules_payment)
        Me.pnl_object_container.Controls.Add(Me.lbl_rules_payment)
        Me.pnl_object_container.Controls.Add(Me.chk_object_conserve)
        Me.pnl_object_container.Controls.Add(Me.txt_rules_criteria)
        Me.pnl_object_container.Controls.Add(Me.cmb_rules_operator)
        Me.pnl_object_container.Controls.Add(Me.cmb_rules_segment)
        Me.pnl_object_container.Controls.Add(Me.lbl_rules_condition)
        Me.pnl_object_container.Controls.Add(Me.txt_rules_name)
        Me.pnl_object_container.Controls.Add(Me.lbl_rules_name)
        Me.pnl_object_container.Controls.Add(Me.lbl_rules_operator)
        Me.pnl_object_container.Controls.Add(Me.lbl_rules_segment)
        Me.pnl_object_container.Controls.Add(Me.lbl_rules_agency)
        Me.pnl_object_container.Controls.Add(Me.cmb_rules_type)
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
        'lbl_rules_function
        '
        Me.lbl_rules_function.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rules_function.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_rules_function.Appearance.Options.UseFont = True
        Me.lbl_rules_function.Appearance.Options.UseForeColor = True
        Me.lbl_rules_function.Location = New System.Drawing.Point(439, 312)
        Me.lbl_rules_function.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_rules_function.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_rules_function.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_rules_function.Name = "lbl_rules_function"
        Me.lbl_rules_function.Size = New System.Drawing.Size(101, 16)
        Me.lbl_rules_function.TabIndex = 0
        Me.lbl_rules_function.Text = "Metodo de ejecución*"
        '
        'lbl_rules_payment
        '
        Me.lbl_rules_payment.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rules_payment.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_rules_payment.Appearance.Options.UseFont = True
        Me.lbl_rules_payment.Appearance.Options.UseForeColor = True
        Me.lbl_rules_payment.Location = New System.Drawing.Point(233, 312)
        Me.lbl_rules_payment.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_rules_payment.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_rules_payment.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_rules_payment.Name = "lbl_rules_payment"
        Me.lbl_rules_payment.Size = New System.Drawing.Size(92, 16)
        Me.lbl_rules_payment.TabIndex = 0
        Me.lbl_rules_payment.Text = "Tipo de liquidación*"
        '
        'chk_object_conserve
        '
        Me.chk_object_conserve.Location = New System.Drawing.Point(986, 365)
        Me.chk_object_conserve.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_object_conserve.Name = "chk_object_conserve"
        Me.chk_object_conserve.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.chk_object_conserve.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.chk_object_conserve.Properties.Appearance.BorderColor = System.Drawing.Color.White
        Me.chk_object_conserve.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_object_conserve.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.chk_object_conserve.Properties.Appearance.Options.UseBackColor = True
        Me.chk_object_conserve.Properties.Appearance.Options.UseBorderColor = True
        Me.chk_object_conserve.Properties.Appearance.Options.UseFont = True
        Me.chk_object_conserve.Properties.Appearance.Options.UseForeColor = True
        Me.chk_object_conserve.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.chk_object_conserve.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.chk_object_conserve.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.White
        Me.chk_object_conserve.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_object_conserve.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.chk_object_conserve.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.chk_object_conserve.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.chk_object_conserve.Properties.AppearanceDisabled.Options.UseFont = True
        Me.chk_object_conserve.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.chk_object_conserve.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.chk_object_conserve.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.chk_object_conserve.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.White
        Me.chk_object_conserve.Properties.AppearanceFocused.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_object_conserve.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.DimGray
        Me.chk_object_conserve.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.chk_object_conserve.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.chk_object_conserve.Properties.AppearanceFocused.Options.UseFont = True
        Me.chk_object_conserve.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.chk_object_conserve.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.chk_object_conserve.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.chk_object_conserve.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White
        Me.chk_object_conserve.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_object_conserve.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.chk_object_conserve.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.chk_object_conserve.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.chk_object_conserve.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.chk_object_conserve.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.chk_object_conserve.Properties.Caption = "Desea conservar la estructura de la regla?"
        Me.chk_object_conserve.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chk_object_conserve.Properties.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.chk_object_conserve.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.chk_object_conserve.Size = New System.Drawing.Size(223, 20)
        Me.chk_object_conserve.TabIndex = 8
        '
        'txt_rules_criteria
        '
        Me.txt_rules_criteria.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_rules_criteria.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_rules_criteria.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_rules_criteria.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.txt_rules_criteria.Appearance.Options.UseBackColor = True
        Me.txt_rules_criteria.Appearance.Options.UseBorderColor = True
        Me.txt_rules_criteria.Appearance.Options.UseForeColor = True
        Me.txt_rules_criteria.AppearanceTreeLine.BackColor = System.Drawing.Color.LightSeaGreen
        Me.txt_rules_criteria.AppearanceTreeLine.BackColor2 = System.Drawing.Color.LightSeaGreen
        Me.txt_rules_criteria.AppearanceTreeLine.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.txt_rules_criteria.AppearanceTreeLine.Options.UseBackColor = True
        Me.txt_rules_criteria.AppearanceTreeLine.Options.UseBorderColor = True
        Me.txt_rules_criteria.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_rules_criteria.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_rules_criteria.Location = New System.Drawing.Point(745, 60)
        Me.txt_rules_criteria.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_rules_criteria.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_rules_criteria.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_rules_criteria.Name = "txt_rules_criteria"
        Me.txt_rules_criteria.Padding = New System.Windows.Forms.Padding(1)
        Me.txt_rules_criteria.ShowOperandTypeIcon = True
        Me.txt_rules_criteria.Size = New System.Drawing.Size(460, 302)
        Me.txt_rules_criteria.TabIndex = 7
        Me.txt_rules_criteria.Tag = "Condición"
        '
        'lbl_rules_condition
        '
        Me.lbl_rules_condition.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rules_condition.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_rules_condition.Appearance.Options.UseFont = True
        Me.lbl_rules_condition.Appearance.Options.UseForeColor = True
        Me.lbl_rules_condition.Location = New System.Drawing.Point(745, 40)
        Me.lbl_rules_condition.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_rules_condition.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_rules_condition.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_rules_condition.Name = "lbl_rules_condition"
        Me.lbl_rules_condition.Size = New System.Drawing.Size(218, 16)
        Me.lbl_rules_condition.TabIndex = 0
        Me.lbl_rules_condition.Text = "Defina las condiciones y/o criterios de la regla*"
        '
        'lbl_rules_name
        '
        Me.lbl_rules_name.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rules_name.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_rules_name.Appearance.Options.UseFont = True
        Me.lbl_rules_name.Appearance.Options.UseForeColor = True
        Me.lbl_rules_name.Location = New System.Drawing.Point(233, 108)
        Me.lbl_rules_name.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_rules_name.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_rules_name.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_rules_name.Name = "lbl_rules_name"
        Me.lbl_rules_name.Size = New System.Drawing.Size(137, 16)
        Me.lbl_rules_name.TabIndex = 0
        Me.lbl_rules_name.Text = "Defina el nombre de la regla*"
        '
        'lbl_rules_operator
        '
        Me.lbl_rules_operator.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rules_operator.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_rules_operator.Appearance.Options.UseFont = True
        Me.lbl_rules_operator.Appearance.Options.UseForeColor = True
        Me.lbl_rules_operator.Location = New System.Drawing.Point(233, 176)
        Me.lbl_rules_operator.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_rules_operator.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_rules_operator.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_rules_operator.Name = "lbl_rules_operator"
        Me.lbl_rules_operator.Size = New System.Drawing.Size(169, 16)
        Me.lbl_rules_operator.TabIndex = 0
        Me.lbl_rules_operator.Text = "Seleccione el nombre del operador*"
        '
        'lbl_rules_segment
        '
        Me.lbl_rules_segment.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rules_segment.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_rules_segment.Appearance.Options.UseFont = True
        Me.lbl_rules_segment.Appearance.Options.UseForeColor = True
        Me.lbl_rules_segment.Location = New System.Drawing.Point(233, 244)
        Me.lbl_rules_segment.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_rules_segment.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_rules_segment.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_rules_segment.Name = "lbl_rules_segment"
        Me.lbl_rules_segment.Size = New System.Drawing.Size(225, 16)
        Me.lbl_rules_segment.TabIndex = 0
        Me.lbl_rules_segment.Text = "Seleccione el nombre del segmento de negocio*"
        '
        'lbl_rules_agency
        '
        Me.lbl_rules_agency.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rules_agency.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_rules_agency.Appearance.Options.UseFont = True
        Me.lbl_rules_agency.Appearance.Options.UseForeColor = True
        Me.lbl_rules_agency.Location = New System.Drawing.Point(233, 40)
        Me.lbl_rules_agency.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_rules_agency.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_rules_agency.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_rules_agency.Name = "lbl_rules_agency"
        Me.lbl_rules_agency.Size = New System.Drawing.Size(164, 16)
        Me.lbl_rules_agency.TabIndex = 0
        Me.lbl_rules_agency.Text = "Seleccione el tipo de regla a crear*"
        '
        'commision_rules_create
        '
        Me.AccessibleName = "CR002C"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnl_object_container)
        Me.Controls.Add(Me.pnl_object_bottom)
        Me.Controls.Add(Me.pnl_object_top)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "commision_rules_create"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(1350, 550)
        Me.Tag = "Crear Regla"
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_rules_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_rules_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_rules_segment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_rules_operator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_rules_payment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_rules_function.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_top.ResumeLayout(False)
        CType(Me.pnl_object_bottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_bottom.ResumeLayout(False)
        CType(Me.chk_keep_form.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        CType(Me.chk_object_conserve.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Protected WithEvents chk_keep_form As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_rules_condition As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_rules_name As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_rules_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_rules_operator As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_rules_segment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_rules_agency As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_rules_type As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents cmb_rules_operator As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents cmb_rules_segment As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents txt_rules_criteria As APDA.Object.Controls.TextboxFilter
    Protected WithEvents chk_object_conserve As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmb_rules_payment As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_rules_payment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_rules_function As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_rules_function As APDA.Object.Controls.ComboboxEdit
End Class
