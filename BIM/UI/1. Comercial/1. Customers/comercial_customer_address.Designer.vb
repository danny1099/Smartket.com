<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comercial_customer_address
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(comercial_customer_address))
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.cmb_customer_address = New APDA.[Object].Controls.ComboboxEdit()
        Me.txt_customer_address = New APDA.[Object].Controls.TextboxEdit()
        Me.txt_customer_number = New APDA.[Object].Controls.TextboxEdit()
        Me.txt_customer_house = New APDA.[Object].Controls.TextboxEdit()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_address_separator = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_address_number = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.lbl_address_name = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_customer_address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_customer_address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_customer_number.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_customer_house.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        Me.SuspendLayout()
        '
        'xvp_validate
        '
        Me.xvp_validate.ValidateHiddenControls = False
        Me.xvp_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'cmb_customer_address
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_customer_address, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_customer_address.Location = New System.Drawing.Point(41, 145)
        Me.cmb_customer_address.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_customer_address.Name = "cmb_customer_address"
        Me.cmb_customer_address.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_customer_address.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_customer_address.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_customer_address.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_customer_address.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_customer_address.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_customer_address.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_customer_address.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_customer_address.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_customer_address.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_customer_address.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_customer_address.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_customer_address.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_customer_address.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_customer_address.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_customer_address.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_customer_address.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_customer_address.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_customer_address.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_customer_address.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_customer_address.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_customer_address.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_customer_address.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_customer_address.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_customer_address.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_customer_address.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_customer_address.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_customer_address.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_customer_address.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_customer_address.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_customer_address.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_customer_address.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_customer_address.Properties.AutoHeight = False
        Me.cmb_customer_address.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_customer_address.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_customer_address.Properties.DropDownItemHeight = 30
        Me.cmb_customer_address.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_customer_address.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_customer_address.Properties.NullText = ""
        Me.cmb_customer_address.Properties.ShowFooter = False
        Me.cmb_customer_address.Properties.ShowHeader = False
        Me.cmb_customer_address.Size = New System.Drawing.Size(124, 35)
        Me.cmb_customer_address.TabIndex = 1
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_customer_address, ConditionValidationRule1)
        '
        'txt_customer_address
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_customer_address, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_customer_address.Location = New System.Drawing.Point(179, 145)
        Me.txt_customer_address.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_customer_address.Name = "txt_customer_address"
        Me.txt_customer_address.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_customer_address.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_customer_address.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_customer_address.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_customer_address.Properties.Appearance.Options.UseBackColor = True
        Me.txt_customer_address.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_customer_address.Properties.Appearance.Options.UseForeColor = True
        Me.txt_customer_address.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_customer_address.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_customer_address.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_customer_address.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_customer_address.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_customer_address.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_customer_address.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_customer_address.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_customer_address.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_customer_address.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_customer_address.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_customer_address.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_customer_address.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_customer_address.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_customer_address.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_customer_address.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_customer_address.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_customer_address.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_customer_address.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_customer_address.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_customer_address.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_customer_address.Properties.AutoHeight = False
        Me.txt_customer_address.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_customer_address.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_customer_address.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_customer_address.Properties.Mask.BeepOnError = True
        Me.txt_customer_address.Size = New System.Drawing.Size(68, 35)
        Me.txt_customer_address.TabIndex = 2
        '
        'txt_customer_number
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_customer_number, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_customer_number.Location = New System.Drawing.Point(283, 145)
        Me.txt_customer_number.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_customer_number.Name = "txt_customer_number"
        Me.txt_customer_number.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_customer_number.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_customer_number.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_customer_number.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_customer_number.Properties.Appearance.Options.UseBackColor = True
        Me.txt_customer_number.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_customer_number.Properties.Appearance.Options.UseForeColor = True
        Me.txt_customer_number.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_customer_number.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_customer_number.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_customer_number.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_customer_number.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_customer_number.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_customer_number.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_customer_number.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_customer_number.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_customer_number.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_customer_number.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_customer_number.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_customer_number.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_customer_number.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_customer_number.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_customer_number.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_customer_number.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_customer_number.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_customer_number.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_customer_number.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_customer_number.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_customer_number.Properties.AutoHeight = False
        Me.txt_customer_number.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_customer_number.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_customer_number.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_customer_number.Properties.Mask.BeepOnError = True
        Me.txt_customer_number.Size = New System.Drawing.Size(80, 35)
        Me.txt_customer_number.TabIndex = 3
        '
        'txt_customer_house
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_customer_house, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_customer_house.Location = New System.Drawing.Point(383, 145)
        Me.txt_customer_house.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_customer_house.Name = "txt_customer_house"
        Me.txt_customer_house.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_customer_house.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_customer_house.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_customer_house.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_customer_house.Properties.Appearance.Options.UseBackColor = True
        Me.txt_customer_house.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_customer_house.Properties.Appearance.Options.UseForeColor = True
        Me.txt_customer_house.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_customer_house.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_customer_house.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_customer_house.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_customer_house.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_customer_house.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_customer_house.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_customer_house.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_customer_house.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_customer_house.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_customer_house.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_customer_house.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_customer_house.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_customer_house.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_customer_house.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_customer_house.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_customer_house.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_customer_house.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_customer_house.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_customer_house.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_customer_house.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_customer_house.Properties.AutoHeight = False
        Me.txt_customer_house.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_customer_house.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_customer_house.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_customer_house.Properties.Mask.BeepOnError = True
        Me.txt_customer_house.Size = New System.Drawing.Size(80, 35)
        Me.txt_customer_house.TabIndex = 4
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.txt_customer_house)
        Me.pnl_object_container.Controls.Add(Me.lbl_address_separator)
        Me.pnl_object_container.Controls.Add(Me.txt_customer_number)
        Me.pnl_object_container.Controls.Add(Me.lbl_address_number)
        Me.pnl_object_container.Controls.Add(Me.txt_customer_address)
        Me.pnl_object_container.Controls.Add(Me.btn_object_cancel)
        Me.pnl_object_container.Controls.Add(Me.lbl_address_name)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_title)
        Me.pnl_object_container.Controls.Add(Me.btn_object_accept)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_info)
        Me.pnl_object_container.Controls.Add(Me.cmb_customer_address)
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
        'lbl_address_separator
        '
        Me.lbl_address_separator.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address_separator.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_address_separator.Appearance.Options.UseFont = True
        Me.lbl_address_separator.Appearance.Options.UseForeColor = True
        Me.lbl_address_separator.Location = New System.Drawing.Point(371, 155)
        Me.lbl_address_separator.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_address_separator.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_address_separator.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_address_separator.Name = "lbl_address_separator"
        Me.lbl_address_separator.Size = New System.Drawing.Size(4, 16)
        Me.lbl_address_separator.TabIndex = 0
        Me.lbl_address_separator.Text = "-"
        '
        'lbl_address_number
        '
        Me.lbl_address_number.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address_number.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_address_number.Appearance.Options.UseFont = True
        Me.lbl_address_number.Appearance.Options.UseForeColor = True
        Me.lbl_address_number.Location = New System.Drawing.Point(260, 155)
        Me.lbl_address_number.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_address_number.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_address_number.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_address_number.Name = "lbl_address_number"
        Me.lbl_address_number.Size = New System.Drawing.Size(8, 16)
        Me.lbl_address_number.TabIndex = 0
        Me.lbl_address_number.Text = "#"
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
        'lbl_address_name
        '
        Me.lbl_address_name.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address_name.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_address_name.Appearance.Options.UseFont = True
        Me.lbl_address_name.Appearance.Options.UseForeColor = True
        Me.lbl_address_name.Location = New System.Drawing.Point(41, 125)
        Me.lbl_address_name.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_address_name.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_address_name.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_address_name.Name = "lbl_address_name"
        Me.lbl_address_name.Size = New System.Drawing.Size(227, 16)
        Me.lbl_address_name.TabIndex = 0
        Me.lbl_address_name.Text = "Defina la composición de la dirección a registrar*"
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
        Me.lbl_object_title.Size = New System.Drawing.Size(85, 38)
        Me.lbl_object_title.TabIndex = 0
        Me.lbl_object_title.Text = "Dirección"
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
        'comercial_customer_address
        '
        Me.AcceptButton = Me.btn_object_accept
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.btn_object_cancel
        Me.ClientSize = New System.Drawing.Size(515, 300)
        Me.Controls.Add(Me.pnl_object_container)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IconOptions.Icon = CType(resources.GetObject("comercial_customer_address.IconOptions.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Office 2019 White"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "comercial_customer_address"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_customer_address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_customer_address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_customer_number.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_customer_house.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents xvp_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_object_cancel As Button
    Friend WithEvents lbl_address_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_accept As Button
    Friend WithEvents lbl_object_info As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_customer_address As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents txt_customer_address As APDA.Object.Controls.TextboxEdit
    Friend WithEvents txt_customer_house As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_address_separator As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_customer_number As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_address_number As DevExpress.XtraEditors.LabelControl
End Class
