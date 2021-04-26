<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class persons_leaders_create
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(persons_leaders_create))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.cmb_leader_name = New APDA.[Object].Controls.ComboboxEdit()
        Me.txt_leader_date = New APDA.[Object].Controls.TextboxDates()
        Me.cmb_leader_director = New APDA.[Object].Controls.ComboboxEdit()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_leader_since = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_leader_name = New DevExpress.XtraEditors.LabelControl()
        Me.chk_row_visible = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.lbl_assigned_name = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_leader_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_leader_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_leader_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_leader_director.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        CType(Me.chk_row_visible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xvp_validate
        '
        Me.xvp_validate.ValidateHiddenControls = False
        Me.xvp_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'cmb_leader_name
        '
        Me.cmb_leader_name.Tag = "Supervisor"
        Me.xvp_validate.SetIconAlignment(Me.cmb_leader_name, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_leader_name.Location = New System.Drawing.Point(41, 226)
        Me.cmb_leader_name.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_leader_name.Name = "cmb_leader_name"
        Me.cmb_leader_name.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_leader_name.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_leader_name.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_leader_name.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_leader_name.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_leader_name.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_leader_name.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_leader_name.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_leader_name.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_leader_name.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_leader_name.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_leader_name.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_leader_name.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_leader_name.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_leader_name.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_leader_name.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_leader_name.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_leader_name.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_leader_name.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_leader_name.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_leader_name.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_leader_name.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_leader_name.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_leader_name.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_leader_name.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_leader_name.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_leader_name.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_leader_name.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_leader_name.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_leader_name.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_leader_name.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_leader_name.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_leader_name.Properties.AutoHeight = False
        Me.cmb_leader_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_leader_name.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_leader_name.Properties.DropDownItemHeight = 30
        Me.cmb_leader_name.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_leader_name.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_leader_name.Properties.NullText = ""
        Me.cmb_leader_name.Properties.ShowFooter = False
        Me.cmb_leader_name.Properties.ShowHeader = False
        Me.cmb_leader_name.Properties.ShowLines = False
        Me.cmb_leader_name.Size = New System.Drawing.Size(430, 35)
        Me.cmb_leader_name.TabIndex = 2
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_leader_name, ConditionValidationRule1)
        '
        'txt_leader_date
        '
        Me.txt_leader_date.EditValue = Nothing
        Me.txt_leader_date.Tag = "Fecha de inicio"
        Me.xvp_validate.SetIconAlignment(Me.txt_leader_date, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_leader_date.Location = New System.Drawing.Point(41, 300)
        Me.txt_leader_date.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_leader_date.Name = "txt_leader_date"
        Me.txt_leader_date.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_leader_date.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_leader_date.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_leader_date.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_leader_date.Properties.Appearance.Options.UseBackColor = True
        Me.txt_leader_date.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_leader_date.Properties.Appearance.Options.UseForeColor = True
        Me.txt_leader_date.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_leader_date.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_leader_date.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_leader_date.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_leader_date.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_leader_date.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_leader_date.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_leader_date.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.txt_leader_date.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.txt_leader_date.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_leader_date.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.txt_leader_date.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.txt_leader_date.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.txt_leader_date.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.txt_leader_date.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_leader_date.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_leader_date.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_leader_date.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_leader_date.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_leader_date.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_leader_date.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_leader_date.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_leader_date.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.txt_leader_date.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_leader_date.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_leader_date.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_leader_date.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_leader_date.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_leader_date.Properties.AutoHeight = False
        Me.txt_leader_date.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txt_leader_date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_leader_date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_leader_date.Properties.DisplayFormat.FormatString = "D"
        Me.txt_leader_date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_leader_date.Properties.EditFormat.FormatString = "D"
        Me.txt_leader_date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_leader_date.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_leader_date.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_leader_date.Properties.Mask.EditMask = "D"
        Me.txt_leader_date.Size = New System.Drawing.Size(430, 35)
        Me.txt_leader_date.TabIndex = 3
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_leader_date, ConditionValidationRule2)
        '
        'cmb_leader_director
        '
        Me.cmb_leader_director.Tag = "Tipo de supervisor"
        Me.xvp_validate.SetIconAlignment(Me.cmb_leader_director, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_leader_director.Location = New System.Drawing.Point(41, 152)
        Me.cmb_leader_director.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_leader_director.Name = "cmb_leader_director"
        Me.cmb_leader_director.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_leader_director.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_leader_director.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_leader_director.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_leader_director.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_leader_director.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_leader_director.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_leader_director.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_leader_director.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_leader_director.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_leader_director.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_leader_director.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_leader_director.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_leader_director.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_leader_director.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_leader_director.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_leader_director.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_leader_director.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_leader_director.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_leader_director.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_leader_director.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_leader_director.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_leader_director.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_leader_director.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_leader_director.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_leader_director.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_leader_director.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_leader_director.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_leader_director.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_leader_director.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_leader_director.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_leader_director.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_leader_director.Properties.AutoHeight = False
        Me.cmb_leader_director.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_leader_director.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_leader_director.Properties.DropDownItemHeight = 30
        Me.cmb_leader_director.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_leader_director.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_leader_director.Properties.NullText = ""
        Me.cmb_leader_director.Properties.ShowFooter = False
        Me.cmb_leader_director.Properties.ShowHeader = False
        Me.cmb_leader_director.Properties.ShowLines = False
        Me.cmb_leader_director.Size = New System.Drawing.Size(430, 35)
        Me.cmb_leader_director.TabIndex = 1
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_leader_director, ConditionValidationRule3)
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.lbl_leader_since)
        Me.pnl_object_container.Controls.Add(Me.lbl_leader_name)
        Me.pnl_object_container.Controls.Add(Me.chk_row_visible)
        Me.pnl_object_container.Controls.Add(Me.btn_object_cancel)
        Me.pnl_object_container.Controls.Add(Me.lbl_assigned_name)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_title)
        Me.pnl_object_container.Controls.Add(Me.btn_object_accept)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_info)
        Me.pnl_object_container.Controls.Add(Me.cmb_leader_director)
        Me.pnl_object_container.Controls.Add(Me.cmb_leader_name)
        Me.pnl_object_container.Controls.Add(Me.txt_leader_date)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 1)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_container.Size = New System.Drawing.Size(513, 473)
        Me.pnl_object_container.TabIndex = 0
        '
        'lbl_leader_since
        '
        Me.lbl_leader_since.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_leader_since.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_leader_since.Appearance.Options.UseFont = True
        Me.lbl_leader_since.Appearance.Options.UseForeColor = True
        Me.lbl_leader_since.Location = New System.Drawing.Point(41, 280)
        Me.lbl_leader_since.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_leader_since.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_leader_since.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_leader_since.Name = "lbl_leader_since"
        Me.lbl_leader_since.Size = New System.Drawing.Size(189, 16)
        Me.lbl_leader_since.TabIndex = 0
        Me.lbl_leader_since.Text = "Seleccione el tipo de director asignados*"
        '
        'lbl_leader_name
        '
        Me.lbl_leader_name.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_leader_name.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_leader_name.Appearance.Options.UseFont = True
        Me.lbl_leader_name.Appearance.Options.UseForeColor = True
        Me.lbl_leader_name.Location = New System.Drawing.Point(41, 206)
        Me.lbl_leader_name.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_leader_name.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_leader_name.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_leader_name.Name = "lbl_leader_name"
        Me.lbl_leader_name.Size = New System.Drawing.Size(245, 16)
        Me.lbl_leader_name.TabIndex = 0
        Me.lbl_leader_name.Text = "Defina el nombre del supervisor que desea asignar*"
        '
        'chk_row_visible
        '
        Me.chk_row_visible.EditValue = True
        Me.chk_row_visible.Location = New System.Drawing.Point(41, 440)
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
        'lbl_assigned_name
        '
        Me.lbl_assigned_name.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_assigned_name.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_assigned_name.Appearance.Options.UseFont = True
        Me.lbl_assigned_name.Appearance.Options.UseForeColor = True
        Me.lbl_assigned_name.Location = New System.Drawing.Point(41, 132)
        Me.lbl_assigned_name.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_assigned_name.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_assigned_name.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_assigned_name.Name = "lbl_assigned_name"
        Me.lbl_assigned_name.Size = New System.Drawing.Size(189, 16)
        Me.lbl_assigned_name.TabIndex = 0
        Me.lbl_assigned_name.Text = "Seleccione el tipo de director asignados*"
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
        Me.lbl_object_title.Size = New System.Drawing.Size(168, 38)
        Me.lbl_object_title.TabIndex = 0
        Me.lbl_object_title.Text = "Asignar Supervisor"
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
        Me.btn_object_accept.Location = New System.Drawing.Point(411, 420)
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
        'persons_leaders_create
        '
        Me.AcceptButton = Me.btn_object_accept
        Me.AccessibleName = "PPL001C"
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.btn_object_cancel
        Me.ClientSize = New System.Drawing.Size(515, 475)
        Me.Controls.Add(Me.pnl_object_container)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IconOptions.Icon = CType(resources.GetObject("persons_leaders_create.IconOptions.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Office 2019 White"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "persons_leaders_create"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Asignar Supervisor"
        Me.TopMost = True
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_leader_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_leader_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_leader_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_leader_director.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        CType(Me.chk_row_visible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents xvp_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmb_leader_name As APDA.Object.Controls.ComboboxEdit
    Protected WithEvents chk_row_visible As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btn_object_cancel As Button
    Friend WithEvents lbl_assigned_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_accept As Button
    Friend WithEvents lbl_object_info As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_leader_date As APDA.Object.Controls.TextboxDates
    Friend WithEvents cmb_leader_director As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_leader_since As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_leader_name As DevExpress.XtraEditors.LabelControl
End Class
