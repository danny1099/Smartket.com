<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class commision_subsettleds_create
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(commision_subsettleds_create))
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
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule5 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.txt_settled_until = New APDA.[Object].Controls.TextboxDates()
        Me.txt_settled_since = New APDA.[Object].Controls.TextboxDates()
        Me.cmb_settled_period = New APDA.[Object].Controls.ComboboxEdit()
        Me.cmb_settled_segment = New APDA.[Object].Controls.ComboboxEdit()
        Me.cmb_settled_person = New APDA.[Object].Controls.ComboboxSearch()
        Me.dgv_sales_sellers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txt_settled_payment = New APDA.[Object].Controls.TextboxEdit()
        Me.cmb_settled_type = New APDA.[Object].Controls.ComboboxEdit()
        Me.pnl_object_top = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_refresh = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.pnl_object_bottom = New DevExpress.XtraEditors.PanelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.chk_keep_form = New DevExpress.XtraEditors.CheckEdit()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.txt_settled_criteria = New APDA.[Object].Controls.TextboxFilter()
        Me.lbl_settled_type = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_settled_commision = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_settles_comision = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_settled_person = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_settled_newperiod = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_settled_criteria = New DevExpress.XtraEditors.LabelControl()
        Me.chk_object_conserve = New DevExpress.XtraEditors.CheckEdit()
        Me.lbl_settled_since = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_settled_period = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_settled_segment = New DevExpress.XtraEditors.LabelControl()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_settled_until.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_settled_until.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_settled_since.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_settled_since.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_settled_period.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_settled_segment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_settled_person.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_sales_sellers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_settled_payment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_settled_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'txt_settled_until
        '
        Me.txt_settled_until.EditValue = Nothing
        Me.xvp_validate.SetIconAlignment(Me.txt_settled_until, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_settled_until.Location = New System.Drawing.Point(415, 311)
        Me.txt_settled_until.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_settled_until.Name = "txt_settled_until"
        Me.txt_settled_until.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_settled_until.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_settled_until.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_settled_until.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_settled_until.Properties.Appearance.Options.UseBackColor = True
        Me.txt_settled_until.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_settled_until.Properties.Appearance.Options.UseForeColor = True
        Me.txt_settled_until.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_settled_until.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_settled_until.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_settled_until.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_settled_until.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_settled_until.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_settled_until.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_settled_until.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.txt_settled_until.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.txt_settled_until.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txt_settled_until.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.txt_settled_until.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.txt_settled_until.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.txt_settled_until.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.txt_settled_until.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_settled_until.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_settled_until.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_settled_until.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_settled_until.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_settled_until.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_settled_until.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_settled_until.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_settled_until.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_settled_until.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_settled_until.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_settled_until.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_settled_until.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_settled_until.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_settled_until.Properties.AutoHeight = False
        Me.txt_settled_until.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txt_settled_until.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_settled_until.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_settled_until.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_settled_until.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_settled_until.Properties.ReadOnly = True
        Me.txt_settled_until.Size = New System.Drawing.Size(195, 30)
        Me.txt_settled_until.TabIndex = 5
        Me.txt_settled_until.Tag = "Fecha de finalización"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_settled_until, ConditionValidationRule1)
        '
        'txt_settled_since
        '
        Me.txt_settled_since.EditValue = Nothing
        Me.xvp_validate.SetIconAlignment(Me.txt_settled_since, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_settled_since.Location = New System.Drawing.Point(210, 311)
        Me.txt_settled_since.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_settled_since.Name = "txt_settled_since"
        Me.txt_settled_since.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_settled_since.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_settled_since.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_settled_since.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_settled_since.Properties.Appearance.Options.UseBackColor = True
        Me.txt_settled_since.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_settled_since.Properties.Appearance.Options.UseForeColor = True
        Me.txt_settled_since.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_settled_since.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_settled_since.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_settled_since.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_settled_since.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_settled_since.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_settled_since.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_settled_since.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.txt_settled_since.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.txt_settled_since.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txt_settled_since.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.txt_settled_since.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.txt_settled_since.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.txt_settled_since.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.txt_settled_since.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_settled_since.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_settled_since.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_settled_since.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_settled_since.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_settled_since.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_settled_since.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_settled_since.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_settled_since.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_settled_since.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_settled_since.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_settled_since.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_settled_since.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_settled_since.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_settled_since.Properties.AutoHeight = False
        Me.txt_settled_since.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        Me.txt_settled_since.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_settled_since.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_settled_since.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_settled_since.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_settled_since.Properties.ReadOnly = True
        Me.txt_settled_since.Size = New System.Drawing.Size(195, 30)
        Me.txt_settled_since.TabIndex = 4
        Me.txt_settled_since.Tag = "Fecha de inicio"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_settled_since, ConditionValidationRule2)
        '
        'cmb_settled_period
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_settled_period, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_settled_period.Location = New System.Drawing.Point(210, 242)
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
        Me.cmb_settled_period.TabIndex = 3
        Me.cmb_settled_period.Tag = "Periodo"
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_settled_period, ConditionValidationRule3)
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
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_settled_segment, ConditionValidationRule4)
        '
        'cmb_settled_person
        '
        Me.cmb_settled_person.EditValue = ""
        Me.xvp_validate.SetIconAlignment(Me.cmb_settled_person, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_settled_person.Location = New System.Drawing.Point(210, 172)
        Me.cmb_settled_person.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_settled_person.Name = "cmb_settled_person"
        Me.cmb_settled_person.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_settled_person.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_person.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_person.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_settled_person.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_settled_person.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_settled_person.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_settled_person.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_settled_person.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_person.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_person.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmb_settled_person.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_settled_person.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_settled_person.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmb_settled_person.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_settled_person.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_person.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_person.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.cmb_settled_person.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_settled_person.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_settled_person.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.cmb_settled_person.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_settled_person.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_person.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_person.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.cmb_settled_person.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_settled_person.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_settled_person.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmb_settled_person.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_settled_person.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_person.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_person.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.cmb_settled_person.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_settled_person.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_settled_person.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.cmb_settled_person.Properties.AutoHeight = False
        Me.cmb_settled_person.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_settled_person.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_settled_person.Properties.LookAndFeel.SkinName = "My Office 2019 White"
        Me.cmb_settled_person.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_settled_person.Properties.NullText = ""
        Me.cmb_settled_person.Properties.PopupView = Me.dgv_sales_sellers
        Me.cmb_settled_person.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth
        Me.cmb_settled_person.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.cmb_settled_person.Size = New System.Drawing.Size(400, 30)
        Me.cmb_settled_person.TabIndex = 2
        Me.cmb_settled_person.Tag = "Vendedor"
        ConditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule5.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_settled_person, ConditionValidationRule5)
        '
        'dgv_sales_sellers
        '
        Me.dgv_sales_sellers.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.dgv_sales_sellers.Name = "dgv_sales_sellers"
        Me.dgv_sales_sellers.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.dgv_sales_sellers.OptionsView.ShowGroupPanel = False
        Me.dgv_sales_sellers.OptionsView.ShowIndicator = False
        '
        'txt_settled_payment
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_settled_payment, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_settled_payment.Location = New System.Drawing.Point(958, 311)
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
        Me.txt_settled_payment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, True, False, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_settled_payment.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_settled_payment.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_settled_payment.Properties.Mask.EditMask = "P2"
        Me.txt_settled_payment.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_settled_payment.Properties.ReadOnly = True
        Me.txt_settled_payment.Size = New System.Drawing.Size(191, 30)
        Me.txt_settled_payment.TabIndex = 8
        Me.txt_settled_payment.Tag = "Valor de comisión"
        '
        'cmb_settled_type
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_settled_type, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_settled_type.Location = New System.Drawing.Point(719, 311)
        Me.cmb_settled_type.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_settled_type.Name = "cmb_settled_type"
        Me.cmb_settled_type.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_settled_type.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_type.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_type.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_settled_type.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_settled_type.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_settled_type.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_settled_type.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_settled_type.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_type.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_type.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_settled_type.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_settled_type.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_settled_type.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_type.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_type.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_settled_type.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_settled_type.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_settled_type.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_type.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_type.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_settled_type.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_settled_type.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_settled_type.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_type.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_type.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_settled_type.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_settled_type.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_settled_type.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_settled_type.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_settled_type.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_settled_type.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_settled_type.Properties.AutoHeight = False
        Me.cmb_settled_type.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_settled_type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_settled_type.Properties.DropDownItemHeight = 30
        Me.cmb_settled_type.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_settled_type.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_settled_type.Properties.NullText = ""
        Me.cmb_settled_type.Properties.ShowFooter = False
        Me.cmb_settled_type.Properties.ShowHeader = False
        Me.cmb_settled_type.Size = New System.Drawing.Size(230, 30)
        Me.cmb_settled_type.TabIndex = 7
        Me.cmb_settled_type.Tag = "Tipo de moneda"
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
        Me.lbl_object_title.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lbl_object_title.Text = "Liquidar Extrapago"
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
        Me.chk_keep_form.Location = New System.Drawing.Point(979, 368)
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
        Me.chk_keep_form.Size = New System.Drawing.Size(172, 20)
        Me.chk_keep_form.TabIndex = 0
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.txt_settled_criteria)
        Me.pnl_object_container.Controls.Add(Me.cmb_settled_type)
        Me.pnl_object_container.Controls.Add(Me.lbl_settled_type)
        Me.pnl_object_container.Controls.Add(Me.txt_settled_payment)
        Me.pnl_object_container.Controls.Add(Me.lbl_settled_commision)
        Me.pnl_object_container.Controls.Add(Me.lbl_settles_comision)
        Me.pnl_object_container.Controls.Add(Me.lbl_settled_person)
        Me.pnl_object_container.Controls.Add(Me.cmb_settled_person)
        Me.pnl_object_container.Controls.Add(Me.chk_keep_form)
        Me.pnl_object_container.Controls.Add(Me.lbl_settled_newperiod)
        Me.pnl_object_container.Controls.Add(Me.lbl_settled_criteria)
        Me.pnl_object_container.Controls.Add(Me.txt_settled_until)
        Me.pnl_object_container.Controls.Add(Me.txt_settled_since)
        Me.pnl_object_container.Controls.Add(Me.chk_object_conserve)
        Me.pnl_object_container.Controls.Add(Me.cmb_settled_period)
        Me.pnl_object_container.Controls.Add(Me.lbl_settled_since)
        Me.pnl_object_container.Controls.Add(Me.lbl_settled_period)
        Me.pnl_object_container.Controls.Add(Me.lbl_settled_segment)
        Me.pnl_object_container.Controls.Add(Me.cmb_settled_segment)
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
        'txt_settled_criteria
        '
        Me.txt_settled_criteria.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_settled_criteria.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_settled_criteria.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_settled_criteria.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.txt_settled_criteria.Appearance.Options.UseBackColor = True
        Me.txt_settled_criteria.Appearance.Options.UseBorderColor = True
        Me.txt_settled_criteria.Appearance.Options.UseForeColor = True
        Me.txt_settled_criteria.AppearanceTreeLine.BackColor = System.Drawing.Color.LightSeaGreen
        Me.txt_settled_criteria.AppearanceTreeLine.BackColor2 = System.Drawing.Color.LightSeaGreen
        Me.txt_settled_criteria.AppearanceTreeLine.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.txt_settled_criteria.AppearanceTreeLine.Options.UseBackColor = True
        Me.txt_settled_criteria.AppearanceTreeLine.Options.UseBorderColor = True
        Me.txt_settled_criteria.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_settled_criteria.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_settled_criteria.Location = New System.Drawing.Point(719, 103)
        Me.txt_settled_criteria.LookAndFeel.SkinName = "The Bezier"
        Me.txt_settled_criteria.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_settled_criteria.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_settled_criteria.MaximumSize = New System.Drawing.Size(430, 238)
        Me.txt_settled_criteria.MaxOperandsCount = 4
        Me.txt_settled_criteria.MinimumSize = New System.Drawing.Size(430, 169)
        Me.txt_settled_criteria.Name = "txt_settled_criteria"
        Me.txt_settled_criteria.Padding = New System.Windows.Forms.Padding(1)
        Me.txt_settled_criteria.ShowOperandTypeIcon = True
        Me.txt_settled_criteria.Size = New System.Drawing.Size(430, 238)
        Me.txt_settled_criteria.TabIndex = 6
        Me.txt_settled_criteria.Tag = "Condición"
        '
        'lbl_settled_type
        '
        Me.lbl_settled_type.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_settled_type.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_settled_type.Appearance.Options.UseFont = True
        Me.lbl_settled_type.Appearance.Options.UseForeColor = True
        Me.lbl_settled_type.Location = New System.Drawing.Point(719, 291)
        Me.lbl_settled_type.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_settled_type.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_settled_type.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_settled_type.Name = "lbl_settled_type"
        Me.lbl_settled_type.Size = New System.Drawing.Size(152, 16)
        Me.lbl_settled_type.TabIndex = 0
        Me.lbl_settled_type.Text = "Defina el tipo de valor a liquidar*"
        '
        'lbl_settled_commision
        '
        Me.lbl_settled_commision.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_settled_commision.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_settled_commision.Appearance.Options.UseFont = True
        Me.lbl_settled_commision.Appearance.Options.UseForeColor = True
        Me.lbl_settled_commision.Location = New System.Drawing.Point(958, 291)
        Me.lbl_settled_commision.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_settled_commision.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_settled_commision.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_settled_commision.Name = "lbl_settled_commision"
        Me.lbl_settled_commision.Size = New System.Drawing.Size(139, 16)
        Me.lbl_settled_commision.TabIndex = 0
        Me.lbl_settled_commision.Text = "Defina el valor de liquidación*"
        '
        'lbl_settles_comision
        '
        Me.lbl_settles_comision.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_settles_comision.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lbl_settles_comision.Appearance.Options.UseFont = True
        Me.lbl_settles_comision.Appearance.Options.UseForeColor = True
        Me.lbl_settles_comision.Appearance.Options.UseTextOptions = True
        Me.lbl_settles_comision.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_settles_comision.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_settles_comision.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_settles_comision.Location = New System.Drawing.Point(719, 344)
        Me.lbl_settles_comision.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_settles_comision.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_settles_comision.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_settles_comision.Name = "lbl_settles_comision"
        Me.lbl_settles_comision.Size = New System.Drawing.Size(130, 16)
        Me.lbl_settles_comision.TabIndex = 0
        Me.lbl_settles_comision.Text = "Agregar valor de comisión"
        '
        'lbl_settled_person
        '
        Me.lbl_settled_person.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_settled_person.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_settled_person.Appearance.Options.UseFont = True
        Me.lbl_settled_person.Appearance.Options.UseForeColor = True
        Me.lbl_settled_person.Location = New System.Drawing.Point(210, 152)
        Me.lbl_settled_person.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_settled_person.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_settled_person.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_settled_person.Name = "lbl_settled_person"
        Me.lbl_settled_person.Size = New System.Drawing.Size(243, 16)
        Me.lbl_settled_person.TabIndex = 0
        Me.lbl_settled_person.Text = "Defina el nombre del vendedor a transferir la venta*"
        '
        'lbl_settled_newperiod
        '
        Me.lbl_settled_newperiod.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_settled_newperiod.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lbl_settled_newperiod.Appearance.Options.UseFont = True
        Me.lbl_settled_newperiod.Appearance.Options.UseForeColor = True
        Me.lbl_settled_newperiod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_settled_newperiod.Location = New System.Drawing.Point(448, 222)
        Me.lbl_settled_newperiod.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_settled_newperiod.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_settled_newperiod.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_settled_newperiod.Name = "lbl_settled_newperiod"
        Me.lbl_settled_newperiod.Size = New System.Drawing.Size(68, 16)
        Me.lbl_settled_newperiod.TabIndex = 0
        Me.lbl_settled_newperiod.Text = "Crear Periodo"
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
        Me.lbl_settled_criteria.Size = New System.Drawing.Size(218, 16)
        Me.lbl_settled_criteria.TabIndex = 0
        Me.lbl_settled_criteria.Text = "Defina las condiciones y/o criterios de la regla*"
        '
        'chk_object_conserve
        '
        Me.chk_object_conserve.Location = New System.Drawing.Point(907, 344)
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
        Me.chk_object_conserve.Properties.Caption = "Desea conservar la estructura de la condición?"
        Me.chk_object_conserve.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chk_object_conserve.Properties.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.chk_object_conserve.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.chk_object_conserve.Size = New System.Drawing.Size(244, 20)
        Me.chk_object_conserve.TabIndex = 11
        '
        'lbl_settled_since
        '
        Me.lbl_settled_since.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_settled_since.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_settled_since.Appearance.Options.UseFont = True
        Me.lbl_settled_since.Appearance.Options.UseForeColor = True
        Me.lbl_settled_since.Location = New System.Drawing.Point(210, 291)
        Me.lbl_settled_since.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_settled_since.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_settled_since.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_settled_since.Name = "lbl_settled_since"
        Me.lbl_settled_since.Size = New System.Drawing.Size(235, 16)
        Me.lbl_settled_since.TabIndex = 0
        Me.lbl_settled_since.Text = "Defina el rango de fechas de las ventas a liquidar*"
        '
        'lbl_settled_period
        '
        Me.lbl_settled_period.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_settled_period.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_settled_period.Appearance.Options.UseFont = True
        Me.lbl_settled_period.Appearance.Options.UseForeColor = True
        Me.lbl_settled_period.Location = New System.Drawing.Point(210, 222)
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
        'commision_subsettleds_create
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
        Me.Name = "commision_subsettleds_create"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(1350, 550)
        Me.Tag = "Liquidar Extrapago"
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_settled_until.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_settled_until.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_settled_since.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_settled_since.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_settled_period.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_settled_segment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_settled_person.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_sales_sellers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_settled_payment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_settled_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lbl_settled_newperiod As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_settled_criteria As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_settled_criteria As APDA.Object.Controls.TextboxFilter
    Friend WithEvents txt_settled_until As APDA.Object.Controls.TextboxDates
    Friend WithEvents txt_settled_since As APDA.Object.Controls.TextboxDates
    Protected WithEvents chk_object_conserve As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmb_settled_period As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_settled_since As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_settled_period As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_settled_segment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_settled_segment As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_settled_person As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_settled_person As APDA.Object.Controls.ComboboxSearch
    Friend WithEvents dgv_sales_sellers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbl_settles_comision As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_settled_type As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_settled_payment As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_settled_commision As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_settled_type As APDA.Object.Controls.ComboboxEdit
End Class
