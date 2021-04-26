<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wholesales_deliverys_document
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
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim OptionsSpelling1 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
        Dim HunspellDictionary1 As DevExpress.XtraSpellChecker.HunspellDictionary = New DevExpress.XtraSpellChecker.HunspellDictionary()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wholesales_deliverys_document))
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.txt_number_document = New APDA.[Object].Controls.TextboxEdit()
        Me.txt_ticket_number = New APDA.[Object].Controls.TextboxEdit()
        Me.txt_ticket_destiny = New APDA.[Object].Controls.TextboxEdit()
        Me.txt_orders_description = New DevExpress.XtraEditors.MemoEdit()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_number_document = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_destiny_name = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_ticket_number = New DevExpress.XtraEditors.LabelControl()
        Me.chk_row_visible = New DevExpress.XtraEditors.CheckEdit()
        Me.lbl_object_caracters = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.lbl_orders_description = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        Me.xvp_spell = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_number_document.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ticket_number.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ticket_destiny.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_orders_description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'txt_number_document
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_number_document, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_number_document.Location = New System.Drawing.Point(40, 273)
        Me.txt_number_document.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_number_document.Name = "txt_number_document"
        Me.txt_number_document.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_number_document.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_number_document.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_number_document.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_number_document.Properties.Appearance.Options.UseBackColor = True
        Me.txt_number_document.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_number_document.Properties.Appearance.Options.UseForeColor = True
        Me.txt_number_document.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_number_document.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_number_document.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_number_document.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_number_document.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_number_document.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_number_document.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_number_document.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_number_document.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_number_document.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_number_document.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_number_document.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_number_document.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_number_document.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_number_document.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_number_document.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_number_document.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_number_document.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_number_document.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_number_document.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_number_document.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_number_document.Properties.AutoHeight = False
        Me.txt_number_document.Properties.BeepOnError = True
        Me.txt_number_document.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_number_document.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_number_document.Properties.DisplayFormat.FormatString = "\w\w\-\d\d\d\d\d\d"
        Me.txt_number_document.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txt_number_document.Properties.EditFormat.FormatString = "\w\w\-\d\d\d\d\d\d"
        Me.txt_number_document.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txt_number_document.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_number_document.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_number_document.Properties.Mask.BeepOnError = True
        Me.txt_number_document.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.RegularMaskManager))
        Me.txt_number_document.Properties.MaskSettings.Set("mask", "\w\w\-\d\d\d\d\d\d")
        Me.txt_number_document.Properties.UseMaskAsDisplayFormat = True
        Me.txt_number_document.Size = New System.Drawing.Size(351, 30)
        Me.txt_number_document.TabIndex = 1
        Me.txt_number_document.Tag = "Numero de documento"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_number_document, ConditionValidationRule1)
        '
        'txt_ticket_number
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_ticket_number, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_ticket_number.Location = New System.Drawing.Point(41, 146)
        Me.txt_ticket_number.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_ticket_number.Name = "txt_ticket_number"
        Me.txt_ticket_number.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_ticket_number.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_ticket_number.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ticket_number.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_ticket_number.Properties.Appearance.Options.UseBackColor = True
        Me.txt_ticket_number.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_ticket_number.Properties.Appearance.Options.UseForeColor = True
        Me.txt_ticket_number.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_ticket_number.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_ticket_number.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ticket_number.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_ticket_number.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_ticket_number.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_ticket_number.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_ticket_number.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_ticket_number.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_ticket_number.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ticket_number.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_ticket_number.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_ticket_number.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_ticket_number.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_ticket_number.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_ticket_number.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_ticket_number.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ticket_number.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_ticket_number.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_ticket_number.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_ticket_number.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_ticket_number.Properties.AutoHeight = False
        Me.txt_ticket_number.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ticket_number.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ticket_number.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_ticket_number.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_ticket_number.Properties.Mask.BeepOnError = True
        Me.txt_ticket_number.Properties.MaskSettings.Set("mask", "(\O\C\-)+(\w|[\-]){2,63}[a-zA-Z]{2,4}")
        Me.txt_ticket_number.Properties.MaskSettings.Set("showPlaceholders", False)
        Me.txt_ticket_number.Properties.ReadOnly = True
        Me.txt_ticket_number.Size = New System.Drawing.Size(350, 30)
        Me.txt_ticket_number.TabIndex = 0
        Me.txt_ticket_number.Tag = "Ticket"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_ticket_number, ConditionValidationRule2)
        '
        'txt_ticket_destiny
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_ticket_destiny, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_ticket_destiny.Location = New System.Drawing.Point(41, 210)
        Me.txt_ticket_destiny.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_ticket_destiny.Name = "txt_ticket_destiny"
        Me.txt_ticket_destiny.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_ticket_destiny.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_ticket_destiny.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ticket_destiny.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_ticket_destiny.Properties.Appearance.Options.UseBackColor = True
        Me.txt_ticket_destiny.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_ticket_destiny.Properties.Appearance.Options.UseForeColor = True
        Me.txt_ticket_destiny.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_ticket_destiny.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_ticket_destiny.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ticket_destiny.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_ticket_destiny.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_ticket_destiny.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_ticket_destiny.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_ticket_destiny.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_ticket_destiny.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_ticket_destiny.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ticket_destiny.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_ticket_destiny.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_ticket_destiny.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_ticket_destiny.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_ticket_destiny.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_ticket_destiny.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_ticket_destiny.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ticket_destiny.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_ticket_destiny.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_ticket_destiny.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_ticket_destiny.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_ticket_destiny.Properties.AutoHeight = False
        Me.txt_ticket_destiny.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ticket_destiny.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ticket_destiny.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_ticket_destiny.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_ticket_destiny.Properties.Mask.BeepOnError = True
        Me.txt_ticket_destiny.Properties.MaskSettings.Set("mask", "(\O\C\-)+(\w|[\-]){2,63}[a-zA-Z]{2,4}")
        Me.txt_ticket_destiny.Properties.MaskSettings.Set("showPlaceholders", False)
        Me.txt_ticket_destiny.Properties.ReadOnly = True
        Me.txt_ticket_destiny.Size = New System.Drawing.Size(350, 30)
        Me.txt_ticket_destiny.TabIndex = 0
        Me.txt_ticket_destiny.Tag = "Destino"
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_ticket_destiny, ConditionValidationRule3)
        '
        'txt_orders_description
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_orders_description, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_orders_description.Location = New System.Drawing.Point(461, 146)
        Me.txt_orders_description.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_orders_description.Name = "txt_orders_description"
        Me.txt_orders_description.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_orders_description.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_description.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_description.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orders_description.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_description.Properties.Appearance.Options.UseBackColor = True
        Me.txt_orders_description.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_orders_description.Properties.Appearance.Options.UseFont = True
        Me.txt_orders_description.Properties.Appearance.Options.UseForeColor = True
        Me.txt_orders_description.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_orders_description.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_orders_description.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.xvp_spell.SetShowSpellCheckMenu(Me.txt_orders_description, True)
        Me.txt_orders_description.Size = New System.Drawing.Size(350, 157)
        Me.xvp_spell.SetSpellCheckerOptions(Me.txt_orders_description, OptionsSpelling1)
        Me.txt_orders_description.TabIndex = 1
        Me.txt_orders_description.Tag = "Descripción"
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.lbl_number_document)
        Me.pnl_object_container.Controls.Add(Me.txt_number_document)
        Me.pnl_object_container.Controls.Add(Me.txt_ticket_number)
        Me.pnl_object_container.Controls.Add(Me.lbl_destiny_name)
        Me.pnl_object_container.Controls.Add(Me.txt_ticket_destiny)
        Me.pnl_object_container.Controls.Add(Me.lbl_ticket_number)
        Me.pnl_object_container.Controls.Add(Me.chk_row_visible)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_caracters)
        Me.pnl_object_container.Controls.Add(Me.btn_object_cancel)
        Me.pnl_object_container.Controls.Add(Me.lbl_orders_description)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_title)
        Me.pnl_object_container.Controls.Add(Me.btn_object_accept)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_info)
        Me.pnl_object_container.Controls.Add(Me.txt_orders_description)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 1)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_container.Size = New System.Drawing.Size(849, 426)
        Me.pnl_object_container.TabIndex = 0
        '
        'lbl_number_document
        '
        Me.lbl_number_document.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_number_document.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_number_document.Appearance.Options.UseFont = True
        Me.lbl_number_document.Appearance.Options.UseForeColor = True
        Me.lbl_number_document.Location = New System.Drawing.Point(40, 254)
        Me.lbl_number_document.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_number_document.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_number_document.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_number_document.Name = "lbl_number_document"
        Me.lbl_number_document.Size = New System.Drawing.Size(97, 16)
        Me.lbl_number_document.TabIndex = 0
        Me.lbl_number_document.Text = "Numero de traslado*"
        '
        'lbl_destiny_name
        '
        Me.lbl_destiny_name.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_destiny_name.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_destiny_name.Appearance.Options.UseFont = True
        Me.lbl_destiny_name.Appearance.Options.UseForeColor = True
        Me.lbl_destiny_name.Location = New System.Drawing.Point(41, 191)
        Me.lbl_destiny_name.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_destiny_name.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_destiny_name.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_destiny_name.Name = "lbl_destiny_name"
        Me.lbl_destiny_name.Size = New System.Drawing.Size(47, 16)
        Me.lbl_destiny_name.TabIndex = 0
        Me.lbl_destiny_name.Text = "Enviar a:*"
        '
        'lbl_ticket_number
        '
        Me.lbl_ticket_number.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ticket_number.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_ticket_number.Appearance.Options.UseFont = True
        Me.lbl_ticket_number.Appearance.Options.UseForeColor = True
        Me.lbl_ticket_number.Location = New System.Drawing.Point(41, 127)
        Me.lbl_ticket_number.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_ticket_number.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_ticket_number.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_ticket_number.Name = "lbl_ticket_number"
        Me.lbl_ticket_number.Size = New System.Drawing.Size(82, 16)
        Me.lbl_ticket_number.TabIndex = 0
        Me.lbl_ticket_number.Text = "Numero de ticket*"
        '
        'chk_row_visible
        '
        Me.chk_row_visible.EditValue = True
        Me.chk_row_visible.Location = New System.Drawing.Point(40, 393)
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
        'lbl_object_caracters
        '
        Me.lbl_object_caracters.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_caracters.Appearance.Options.UseForeColor = True
        Me.lbl_object_caracters.Location = New System.Drawing.Point(782, 307)
        Me.lbl_object_caracters.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_caracters.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_caracters.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_caracters.Name = "lbl_object_caracters"
        Me.lbl_object_caracters.Size = New System.Drawing.Size(27, 16)
        Me.lbl_object_caracters.TabIndex = 0
        Me.lbl_object_caracters.Text = "0/500"
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
        Me.btn_object_cancel.Location = New System.Drawing.Point(818, 4)
        Me.btn_object_cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_cancel.Name = "btn_object_cancel"
        Me.btn_object_cancel.Size = New System.Drawing.Size(28, 31)
        Me.btn_object_cancel.TabIndex = 0
        Me.btn_object_cancel.TabStop = False
        Me.btn_object_cancel.Text = "X"
        Me.btn_object_cancel.UseVisualStyleBackColor = False
        '
        'lbl_orders_description
        '
        Me.lbl_orders_description.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orders_description.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_orders_description.Appearance.Options.UseFont = True
        Me.lbl_orders_description.Appearance.Options.UseForeColor = True
        Me.lbl_orders_description.Location = New System.Drawing.Point(461, 127)
        Me.lbl_orders_description.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_orders_description.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_orders_description.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_orders_description.Name = "lbl_orders_description"
        Me.lbl_orders_description.Size = New System.Drawing.Size(111, 16)
        Me.lbl_orders_description.TabIndex = 0
        Me.lbl_orders_description.Text = "Notas y/o Comentarios*"
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
        Me.lbl_object_title.Size = New System.Drawing.Size(183, 38)
        Me.lbl_object_title.TabIndex = 0
        Me.lbl_object_title.Text = "Número de traslado"
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
        Me.btn_object_accept.Location = New System.Drawing.Point(747, 373)
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
        Me.xvp_spell.ParentContainer = Me.txt_orders_description
        Me.xvp_spell.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType
        Me.xvp_spell.SpellingFormType = DevExpress.XtraSpellChecker.SpellingFormType.Word
        '
        'wholesales_deliverys_document
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.BackColor2 = System.Drawing.Color.White
        Me.Appearance.BorderColor = System.Drawing.Color.White
        Me.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseBorderColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(851, 428)
        Me.Controls.Add(Me.pnl_object_container)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IconOptions.Image = CType(resources.GetObject("wholesales_deliverys_document.IconOptions.Image"), System.Drawing.Image)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Office 2019 White"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "wholesales_deliverys_document"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documento"
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_number_document.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ticket_number.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ticket_destiny.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_orders_description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        CType(Me.chk_row_visible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents xvp_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_number_document As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_number_document As APDA.Object.Controls.TextboxEdit
    Friend WithEvents txt_ticket_number As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_destiny_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ticket_destiny As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_ticket_number As DevExpress.XtraEditors.LabelControl
    Protected WithEvents chk_row_visible As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lbl_object_caracters As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_cancel As Button
    Friend WithEvents lbl_orders_description As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_accept As Button
    Friend WithEvents lbl_object_info As DevExpress.XtraEditors.LabelControl
    Friend WithEvents xvp_spell As DevExpress.XtraSpellChecker.SpellChecker
    Private WithEvents txt_orders_description As DevExpress.XtraEditors.MemoEdit
End Class
