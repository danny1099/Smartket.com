<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class persons_agencys_create
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(persons_agencys_create))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.txt_agency_date = New APDA.[Object].Controls.TextboxDates()
        Me.cmb_agency_name = New APDA.[Object].Controls.ComboboxEdit()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.chk_row_visible = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.lbl_agency_name = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_agency_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_agency_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_agency_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'txt_agency_date
        '
        Me.txt_agency_date.EditValue = Nothing
        Me.txt_agency_date.Tag = "Fecha de inicio"
        Me.xvp_validate.SetIconAlignment(Me.txt_agency_date, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_agency_date.Location = New System.Drawing.Point(41, 145)
        Me.txt_agency_date.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_agency_date.Name = "txt_agency_date"
        Me.txt_agency_date.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_agency_date.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_agency_date.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_agency_date.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_agency_date.Properties.Appearance.Options.UseBackColor = True
        Me.txt_agency_date.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_agency_date.Properties.Appearance.Options.UseForeColor = True
        Me.txt_agency_date.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_agency_date.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_agency_date.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_agency_date.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_agency_date.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_agency_date.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_agency_date.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_agency_date.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.txt_agency_date.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.txt_agency_date.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txt_agency_date.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.txt_agency_date.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.txt_agency_date.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.txt_agency_date.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.txt_agency_date.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_agency_date.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_agency_date.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_agency_date.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_agency_date.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_agency_date.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_agency_date.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_agency_date.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_agency_date.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_agency_date.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_agency_date.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_agency_date.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_agency_date.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_agency_date.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_agency_date.Properties.AutoHeight = False
        Me.txt_agency_date.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txt_agency_date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Left, "", -1, True, False, True, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_agency_date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_agency_date.Properties.DisplayFormat.FormatString = "D"
        Me.txt_agency_date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_agency_date.Properties.EditFormat.FormatString = "D"
        Me.txt_agency_date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_agency_date.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_agency_date.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_agency_date.Properties.Mask.EditMask = "D"
        Me.txt_agency_date.Size = New System.Drawing.Size(430, 35)
        Me.txt_agency_date.TabIndex = 2
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_agency_date, ConditionValidationRule1)
        '
        'cmb_agency_name
        '
        Me.cmb_agency_name.Tag = "Agencia"
        Me.xvp_validate.SetIconAlignment(Me.cmb_agency_name, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_agency_name.Location = New System.Drawing.Point(41, 145)
        Me.cmb_agency_name.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_agency_name.Name = "cmb_agency_name"
        Me.cmb_agency_name.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_agency_name.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_agency_name.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_agency_name.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_agency_name.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_agency_name.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_agency_name.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_agency_name.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_agency_name.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_agency_name.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_agency_name.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_agency_name.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_agency_name.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_agency_name.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_agency_name.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_agency_name.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_agency_name.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_agency_name.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_agency_name.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_agency_name.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_agency_name.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_agency_name.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_agency_name.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_agency_name.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_agency_name.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_agency_name.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_agency_name.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_agency_name.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_agency_name.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_agency_name.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_agency_name.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_agency_name.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_agency_name.Properties.AutoHeight = False
        Me.cmb_agency_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_agency_name.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, True, False, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.cmb_agency_name.Properties.DropDownItemHeight = 30
        Me.cmb_agency_name.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_agency_name.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_agency_name.Properties.NullText = ""
        Me.cmb_agency_name.Properties.ShowFooter = False
        Me.cmb_agency_name.Properties.ShowHeader = False
        Me.cmb_agency_name.Properties.ShowLines = False
        Me.cmb_agency_name.Size = New System.Drawing.Size(430, 35)
        Me.cmb_agency_name.TabIndex = 1
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_agency_name, ConditionValidationRule2)
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.chk_row_visible)
        Me.pnl_object_container.Controls.Add(Me.btn_object_cancel)
        Me.pnl_object_container.Controls.Add(Me.lbl_agency_name)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_title)
        Me.pnl_object_container.Controls.Add(Me.btn_object_accept)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_info)
        Me.pnl_object_container.Controls.Add(Me.cmb_agency_name)
        Me.pnl_object_container.Controls.Add(Me.txt_agency_date)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 1)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_container.Size = New System.Drawing.Size(513, 298)
        Me.pnl_object_container.TabIndex = 0
        '
        'chk_row_visible
        '
        Me.chk_row_visible.EditValue = True
        Me.chk_row_visible.Location = New System.Drawing.Point(37, 265)
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
        'lbl_agency_name
        '
        Me.lbl_agency_name.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_agency_name.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_agency_name.Appearance.Options.UseFont = True
        Me.lbl_agency_name.Appearance.Options.UseForeColor = True
        Me.lbl_agency_name.Location = New System.Drawing.Point(41, 125)
        Me.lbl_agency_name.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_agency_name.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_agency_name.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_agency_name.Name = "lbl_agency_name"
        Me.lbl_agency_name.Size = New System.Drawing.Size(262, 16)
        Me.lbl_agency_name.TabIndex = 0
        Me.lbl_agency_name.Text = "Seleccione el nombre de la agencia que desea asignar*"
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
        Me.lbl_object_title.Size = New System.Drawing.Size(140, 38)
        Me.lbl_object_title.TabIndex = 0
        Me.lbl_object_title.Text = "Asignar Agencia"
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
        Me.btn_object_accept.Location = New System.Drawing.Point(411, 245)
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
        'persons_agencys_create
        '
        Me.AcceptButton = Me.btn_object_accept
        Me.AccessibleName = "PPA001C"
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.btn_object_cancel
        Me.ClientSize = New System.Drawing.Size(515, 300)
        Me.Controls.Add(Me.pnl_object_container)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IconOptions.Icon = CType(resources.GetObject("persons_agencys_create.IconOptions.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Office 2019 White"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "persons_agencys_create"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Asignar Agencia"
        Me.TopMost = True
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_agency_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_agency_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_agency_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        CType(Me.chk_row_visible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents xvp_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_object_cancel As Button
    Friend WithEvents lbl_agency_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_accept As Button
    Friend WithEvents lbl_object_info As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_agency_date As APDA.Object.Controls.TextboxDates
    Protected WithEvents chk_row_visible As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmb_agency_name As APDA.Object.Controls.ComboboxEdit
End Class
