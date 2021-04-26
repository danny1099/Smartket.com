<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chances_taked_create
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(chances_taked_create))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule5 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.cmb_taked_theme = New APDA.[Object].Controls.ComboboxEdit()
        Me.txt_taked_created = New APDA.[Object].Controls.TextboxDates()
        Me.txt_taked_desc = New APDA.[Object].Controls.TextboxMemo()
        Me.cmb_taked_agency = New APDA.[Object].Controls.ComboboxEdit()
        Me.cmb_taked_seller = New APDA.[Object].Controls.ComboboxSearch()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txt_taked_ticket = New APDA.[Object].Controls.TextboxEdit()
        Me.pnl_object_top = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_refresh = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.pnl_object_bottom = New DevExpress.XtraEditors.PanelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.chk_row_visible = New DevExpress.XtraEditors.CheckEdit()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_taked_ticket = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_caracters = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_taked_desc = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_taked_created = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_taked_theme = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_taked_seller = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_taked_agency = New DevExpress.XtraEditors.LabelControl()
        Me.chk_object_closed = New APDA.[Object].Controls.TextboxCheck()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_taked_theme.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_taked_created.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_taked_created.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_taked_desc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_taked_agency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_taked_seller.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_taked_ticket.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_top.SuspendLayout()
        CType(Me.pnl_object_bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_bottom.SuspendLayout()
        CType(Me.chk_row_visible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        CType(Me.chk_object_closed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xvp_validate
        '
        Me.xvp_validate.ValidateHiddenControls = False
        Me.xvp_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'cmb_taked_theme
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_taked_theme, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_taked_theme.Location = New System.Drawing.Point(210, 242)
        Me.cmb_taked_theme.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_taked_theme.Name = "cmb_taked_theme"
        Me.cmb_taked_theme.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_taked_theme.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_taked_theme.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_taked_theme.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_taked_theme.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_taked_theme.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_taked_theme.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_taked_theme.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_taked_theme.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_taked_theme.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_taked_theme.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_taked_theme.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_taked_theme.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_taked_theme.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_taked_theme.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_taked_theme.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_taked_theme.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_taked_theme.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_taked_theme.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_taked_theme.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_taked_theme.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_taked_theme.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_taked_theme.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_taked_theme.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_taked_theme.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_taked_theme.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_taked_theme.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_taked_theme.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_taked_theme.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_taked_theme.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_taked_theme.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_taked_theme.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_taked_theme.Properties.AutoHeight = False
        Me.cmb_taked_theme.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_taked_theme.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_taked_theme.Properties.DropDownItemHeight = 30
        Me.cmb_taked_theme.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_taked_theme.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_taked_theme.Properties.NullText = ""
        Me.cmb_taked_theme.Properties.ReadOnly = True
        Me.cmb_taked_theme.Properties.ShowFooter = False
        Me.cmb_taked_theme.Properties.ShowHeader = False
        Me.cmb_taked_theme.Size = New System.Drawing.Size(400, 30)
        Me.cmb_taked_theme.TabIndex = 3
        Me.cmb_taked_theme.Tag = "Tema de gestión"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_taked_theme, ConditionValidationRule1)
        '
        'txt_taked_created
        '
        Me.txt_taked_created.EditValue = Nothing
        Me.xvp_validate.SetIconAlignment(Me.txt_taked_created, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_taked_created.Location = New System.Drawing.Point(210, 311)
        Me.txt_taked_created.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_taked_created.Name = "txt_taked_created"
        Me.txt_taked_created.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_taked_created.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_taked_created.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_taked_created.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_taked_created.Properties.Appearance.Options.UseBackColor = True
        Me.txt_taked_created.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_taked_created.Properties.Appearance.Options.UseForeColor = True
        Me.txt_taked_created.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_taked_created.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_taked_created.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_taked_created.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_taked_created.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_taked_created.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_taked_created.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_taked_created.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.txt_taked_created.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.txt_taked_created.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txt_taked_created.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.txt_taked_created.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.txt_taked_created.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.txt_taked_created.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.txt_taked_created.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_taked_created.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_taked_created.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_taked_created.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_taked_created.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_taked_created.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_taked_created.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_taked_created.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_taked_created.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_taked_created.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_taked_created.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_taked_created.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_taked_created.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_taked_created.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_taked_created.Properties.AutoHeight = False
        Me.txt_taked_created.Properties.BeepOnError = False
        Me.txt_taked_created.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txt_taked_created.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_taked_created.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_taked_created.Properties.DisplayFormat.FormatString = "G"
        Me.txt_taked_created.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_taked_created.Properties.EditFormat.FormatString = "G"
        Me.txt_taked_created.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_taked_created.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_taked_created.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_taked_created.Properties.MaskSettings.Set("mask", "G")
        Me.txt_taked_created.Size = New System.Drawing.Size(255, 30)
        Me.txt_taked_created.TabIndex = 4
        Me.txt_taked_created.Tag = "Fecha de creación"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_taked_created, ConditionValidationRule2)
        '
        'txt_taked_desc
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_taked_desc, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_taked_desc.Location = New System.Drawing.Point(719, 103)
        Me.txt_taked_desc.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_taked_desc.Name = "txt_taked_desc"
        Me.txt_taked_desc.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_taked_desc.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_taked_desc.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_taked_desc.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_taked_desc.Properties.Appearance.Options.UseBackColor = True
        Me.txt_taked_desc.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_taked_desc.Properties.Appearance.Options.UseForeColor = True
        Me.txt_taked_desc.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_taked_desc.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_taked_desc.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_taked_desc.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_taked_desc.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_taked_desc.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_taked_desc.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_taked_desc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_taked_desc.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_taked_desc.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_taked_desc.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_taked_desc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_taked_desc.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_taked_desc.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_taked_desc.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_taked_desc.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_taked_desc.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_taked_desc.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_taked_desc.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_taked_desc.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_taked_desc.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_taked_desc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_taked_desc.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_taked_desc.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_taked_desc.Properties.MaxLength = 500
        Me.txt_taked_desc.Size = New System.Drawing.Size(430, 238)
        Me.txt_taked_desc.TabIndex = 6
        Me.txt_taked_desc.Tag = "Descripción"
        '
        'cmb_taked_agency
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_taked_agency, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_taked_agency.Location = New System.Drawing.Point(210, 103)
        Me.cmb_taked_agency.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_taked_agency.Name = "cmb_taked_agency"
        Me.cmb_taked_agency.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_taked_agency.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_taked_agency.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_taked_agency.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_taked_agency.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_taked_agency.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_taked_agency.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_taked_agency.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_taked_agency.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_taked_agency.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_taked_agency.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_taked_agency.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_taked_agency.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_taked_agency.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_taked_agency.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_taked_agency.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_taked_agency.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_taked_agency.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_taked_agency.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_taked_agency.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_taked_agency.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_taked_agency.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_taked_agency.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_taked_agency.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_taked_agency.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_taked_agency.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_taked_agency.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_taked_agency.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_taked_agency.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_taked_agency.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_taked_agency.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_taked_agency.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_taked_agency.Properties.AutoHeight = False
        Me.cmb_taked_agency.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_taked_agency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_taked_agency.Properties.DropDownItemHeight = 30
        Me.cmb_taked_agency.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_taked_agency.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_taked_agency.Properties.NullText = ""
        Me.cmb_taked_agency.Properties.ShowFooter = False
        Me.cmb_taked_agency.Properties.ShowHeader = False
        Me.cmb_taked_agency.Size = New System.Drawing.Size(400, 30)
        Me.cmb_taked_agency.TabIndex = 1
        Me.cmb_taked_agency.Tag = "Tipo de atención"
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_taked_agency, ConditionValidationRule3)
        '
        'cmb_taked_seller
        '
        Me.cmb_taked_seller.EditValue = ""
        Me.xvp_validate.SetIconAlignment(Me.cmb_taked_seller, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_taked_seller.Location = New System.Drawing.Point(210, 173)
        Me.cmb_taked_seller.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_taked_seller.Name = "cmb_taked_seller"
        Me.cmb_taked_seller.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_taked_seller.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_taked_seller.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_taked_seller.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_taked_seller.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_taked_seller.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_taked_seller.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_taked_seller.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_taked_seller.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_taked_seller.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_taked_seller.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmb_taked_seller.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_taked_seller.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_taked_seller.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmb_taked_seller.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_taked_seller.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_taked_seller.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_taked_seller.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.cmb_taked_seller.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_taked_seller.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_taked_seller.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.cmb_taked_seller.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_taked_seller.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_taked_seller.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_taked_seller.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.cmb_taked_seller.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_taked_seller.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_taked_seller.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmb_taked_seller.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_taked_seller.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_taked_seller.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_taked_seller.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.cmb_taked_seller.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_taked_seller.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_taked_seller.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.cmb_taked_seller.Properties.AutoHeight = False
        Me.cmb_taked_seller.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_taked_seller.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_taked_seller.Properties.LookAndFeel.SkinName = "My Office 2019 White"
        Me.cmb_taked_seller.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_taked_seller.Properties.NullText = ""
        Me.cmb_taked_seller.Properties.PopupView = Me.GridView1
        Me.cmb_taked_seller.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.cmb_taked_seller.Size = New System.Drawing.Size(400, 30)
        Me.cmb_taked_seller.TabIndex = 2
        Me.cmb_taked_seller.Tag = "Vendedor"
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_taked_seller, ConditionValidationRule4)
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.GroupPanel.BorderColor = System.Drawing.Color.White
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'txt_taked_ticket
        '
        Me.txt_taked_ticket.EditValue = "SP0000-A"
        Me.xvp_validate.SetIconAlignment(Me.txt_taked_ticket, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_taked_ticket.Location = New System.Drawing.Point(473, 311)
        Me.txt_taked_ticket.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_taked_ticket.Name = "txt_taked_ticket"
        Me.txt_taked_ticket.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_taked_ticket.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_taked_ticket.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_taked_ticket.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_taked_ticket.Properties.Appearance.Options.UseBackColor = True
        Me.txt_taked_ticket.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_taked_ticket.Properties.Appearance.Options.UseForeColor = True
        Me.txt_taked_ticket.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_taked_ticket.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_taked_ticket.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_taked_ticket.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_taked_ticket.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_taked_ticket.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_taked_ticket.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_taked_ticket.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_taked_ticket.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_taked_ticket.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_taked_ticket.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_taked_ticket.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_taked_ticket.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_taked_ticket.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_taked_ticket.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_taked_ticket.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_taked_ticket.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_taked_ticket.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_taked_ticket.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_taked_ticket.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_taked_ticket.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_taked_ticket.Properties.AutoHeight = False
        Me.txt_taked_ticket.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_taked_ticket.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_taked_ticket.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_taked_ticket.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_taked_ticket.Properties.Mask.BeepOnError = True
        Me.txt_taked_ticket.Properties.Mask.EditMask = "(2) \d\d\d-\d\d\d\d"
        Me.txt_taked_ticket.Properties.ReadOnly = True
        Me.txt_taked_ticket.Size = New System.Drawing.Size(137, 30)
        Me.txt_taked_ticket.TabIndex = 5
        Me.txt_taked_ticket.Tag = "Tipo de ticket"
        ConditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule5.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_taked_ticket, ConditionValidationRule5)
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
        Me.lbl_object_title.Text = "Tomar Oportunidad"
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
        Me.chk_row_visible.Location = New System.Drawing.Point(942, 344)
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
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.chk_row_visible)
        Me.pnl_object_container.Controls.Add(Me.lbl_taked_ticket)
        Me.pnl_object_container.Controls.Add(Me.txt_taked_ticket)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_caracters)
        Me.pnl_object_container.Controls.Add(Me.cmb_taked_theme)
        Me.pnl_object_container.Controls.Add(Me.lbl_taked_desc)
        Me.pnl_object_container.Controls.Add(Me.lbl_taked_created)
        Me.pnl_object_container.Controls.Add(Me.txt_taked_created)
        Me.pnl_object_container.Controls.Add(Me.lbl_taked_theme)
        Me.pnl_object_container.Controls.Add(Me.lbl_taked_seller)
        Me.pnl_object_container.Controls.Add(Me.lbl_taked_agency)
        Me.pnl_object_container.Controls.Add(Me.txt_taked_desc)
        Me.pnl_object_container.Controls.Add(Me.chk_object_closed)
        Me.pnl_object_container.Controls.Add(Me.cmb_taked_agency)
        Me.pnl_object_container.Controls.Add(Me.cmb_taked_seller)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 76)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_container.Size = New System.Drawing.Size(1348, 421)
        Me.pnl_object_container.TabIndex = 1
        '
        'lbl_taked_ticket
        '
        Me.lbl_taked_ticket.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_taked_ticket.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_taked_ticket.Appearance.Options.UseFont = True
        Me.lbl_taked_ticket.Appearance.Options.UseForeColor = True
        Me.lbl_taked_ticket.Location = New System.Drawing.Point(473, 291)
        Me.lbl_taked_ticket.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_taked_ticket.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_taked_ticket.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_taked_ticket.Name = "lbl_taked_ticket"
        Me.lbl_taked_ticket.Size = New System.Drawing.Size(65, 16)
        Me.lbl_taked_ticket.TabIndex = 0
        Me.lbl_taked_ticket.Text = "Tipo de ticket*"
        '
        'lbl_object_caracters
        '
        Me.lbl_object_caracters.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_caracters.Appearance.Options.UseForeColor = True
        Me.lbl_object_caracters.Location = New System.Drawing.Point(719, 344)
        Me.lbl_object_caracters.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_caracters.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_caracters.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_caracters.Name = "lbl_object_caracters"
        Me.lbl_object_caracters.Size = New System.Drawing.Size(27, 16)
        Me.lbl_object_caracters.TabIndex = 0
        Me.lbl_object_caracters.Text = "0/500"
        '
        'lbl_taked_desc
        '
        Me.lbl_taked_desc.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_taked_desc.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_taked_desc.Appearance.Options.UseFont = True
        Me.lbl_taked_desc.Appearance.Options.UseForeColor = True
        Me.lbl_taked_desc.Location = New System.Drawing.Point(719, 83)
        Me.lbl_taked_desc.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_taked_desc.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_taked_desc.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_taked_desc.Name = "lbl_taked_desc"
        Me.lbl_taked_desc.Size = New System.Drawing.Size(210, 16)
        Me.lbl_taked_desc.TabIndex = 0
        Me.lbl_taked_desc.Text = "Descripción de la gestión comercial realizada"
        '
        'lbl_taked_created
        '
        Me.lbl_taked_created.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_taked_created.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_taked_created.Appearance.Options.UseFont = True
        Me.lbl_taked_created.Appearance.Options.UseForeColor = True
        Me.lbl_taked_created.Location = New System.Drawing.Point(210, 291)
        Me.lbl_taked_created.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_taked_created.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_taked_created.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_taked_created.Name = "lbl_taked_created"
        Me.lbl_taked_created.Size = New System.Drawing.Size(92, 16)
        Me.lbl_taked_created.TabIndex = 0
        Me.lbl_taked_created.Text = "Fecha de apertura*"
        '
        'lbl_taked_theme
        '
        Me.lbl_taked_theme.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_taked_theme.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_taked_theme.Appearance.Options.UseFont = True
        Me.lbl_taked_theme.Appearance.Options.UseForeColor = True
        Me.lbl_taked_theme.Location = New System.Drawing.Point(210, 222)
        Me.lbl_taked_theme.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_taked_theme.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_taked_theme.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_taked_theme.Name = "lbl_taked_theme"
        Me.lbl_taked_theme.Size = New System.Drawing.Size(155, 16)
        Me.lbl_taked_theme.TabIndex = 0
        Me.lbl_taked_theme.Text = "Defina el tipo de gestión relizada*"
        '
        'lbl_taked_seller
        '
        Me.lbl_taked_seller.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_taked_seller.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_taked_seller.Appearance.Options.UseFont = True
        Me.lbl_taked_seller.Appearance.Options.UseForeColor = True
        Me.lbl_taked_seller.Location = New System.Drawing.Point(210, 153)
        Me.lbl_taked_seller.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_taked_seller.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_taked_seller.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_taked_seller.Name = "lbl_taked_seller"
        Me.lbl_taked_seller.Size = New System.Drawing.Size(218, 16)
        Me.lbl_taked_seller.TabIndex = 0
        Me.lbl_taked_seller.Text = "Seleccione el nombre del vendedor a asignar*"
        '
        'lbl_taked_agency
        '
        Me.lbl_taked_agency.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_taked_agency.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_taked_agency.Appearance.Options.UseFont = True
        Me.lbl_taked_agency.Appearance.Options.UseForeColor = True
        Me.lbl_taked_agency.Location = New System.Drawing.Point(210, 83)
        Me.lbl_taked_agency.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_taked_agency.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_taked_agency.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_taked_agency.Name = "lbl_taked_agency"
        Me.lbl_taked_agency.Size = New System.Drawing.Size(171, 16)
        Me.lbl_taked_agency.TabIndex = 0
        Me.lbl_taked_agency.Text = "Seleccione el nombre de la agencia*"
        '
        'chk_object_closed
        '
        Me.chk_object_closed.Location = New System.Drawing.Point(346, 344)
        Me.chk_object_closed.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_object_closed.Name = "chk_object_closed"
        Me.chk_object_closed.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.chk_object_closed.Properties.Appearance.Options.UseForeColor = True
        Me.chk_object_closed.Properties.Caption = "Desea finalizar la gestión comercial inmediatamente?"
        Me.chk_object_closed.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chk_object_closed.Properties.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.chk_object_closed.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.chk_object_closed.Size = New System.Drawing.Size(267, 20)
        Me.chk_object_closed.TabIndex = 7
        Me.chk_object_closed.Tag = "Finalizar Gestión"
        '
        'chances_taked_create
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
        Me.Name = "chances_taked_create"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(1350, 550)
        Me.Tag = "Tomar Oportunidad"
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_taked_theme.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_taked_created.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_taked_created.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_taked_desc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_taked_agency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_taked_seller.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_taked_ticket.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_top.ResumeLayout(False)
        CType(Me.pnl_object_bottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_bottom.ResumeLayout(False)
        CType(Me.chk_row_visible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        CType(Me.chk_object_closed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents xvp_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
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
    Friend WithEvents cmb_taked_theme As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_taked_desc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_taked_created As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_taked_created As APDA.Object.Controls.TextboxDates
    Friend WithEvents lbl_taked_theme As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_taked_seller As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_taked_agency As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_taked_desc As APDA.Object.Controls.TextboxMemo
    Friend WithEvents chk_object_closed As APDA.Object.Controls.TextboxCheck
    Friend WithEvents cmb_taked_agency As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents cmb_taked_seller As APDA.Object.Controls.ComboboxSearch
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbl_taked_ticket As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_taked_ticket As APDA.Object.Controls.TextboxEdit
End Class
