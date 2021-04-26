<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wholesales_orders_closed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wholesales_orders_closed))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim HunspellDictionary1 As DevExpress.XtraSpellChecker.HunspellDictionary = New DevExpress.XtraSpellChecker.HunspellDictionary()
        Dim OptionsSpelling1 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.txt_orders_customers = New APDA.[Object].Controls.TextboxEdit()
        Me.txt_orders_purcharse = New APDA.[Object].Controls.TextboxEdit()
        Me.txt_orders_invoice = New APDA.[Object].Controls.TextboxEdit()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_orders_invoice = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_orders_purchase = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_orders_customer = New DevExpress.XtraEditors.LabelControl()
        Me.chk_row_visible = New DevExpress.XtraEditors.CheckEdit()
        Me.lbl_object_caracters = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.lbl_orders_description = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        Me.xvp_spell = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
        Me.txt_orders_description = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_orders_customers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_orders_purcharse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_orders_invoice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        CType(Me.chk_row_visible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_orders_description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xvp_validate
        '
        Me.xvp_validate.ValidateHiddenControls = False
        Me.xvp_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'txt_orders_customers
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_orders_customers, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_orders_customers.Location = New System.Drawing.Point(41, 146)
        Me.txt_orders_customers.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_orders_customers.Name = "txt_orders_customers"
        Me.txt_orders_customers.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_orders_customers.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_customers.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_customers.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_customers.Properties.Appearance.Options.UseBackColor = True
        Me.txt_orders_customers.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_orders_customers.Properties.Appearance.Options.UseForeColor = True
        Me.txt_orders_customers.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_orders_customers.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_customers.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_customers.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_customers.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_orders_customers.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_orders_customers.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_orders_customers.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_orders_customers.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_customers.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_customers.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_customers.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_orders_customers.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_orders_customers.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_orders_customers.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_orders_customers.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_customers.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_customers.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_customers.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_orders_customers.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_orders_customers.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_orders_customers.Properties.AutoHeight = False
        Me.txt_orders_customers.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txt_orders_customers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, False, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_orders_customers.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_orders_customers.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_orders_customers.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_orders_customers.Properties.Mask.BeepOnError = True
        Me.txt_orders_customers.Properties.Mask.EditMask = "(\O\C\-)+(\w|[\-]){2,63}[a-zA-Z]{2,4}"
        Me.txt_orders_customers.Properties.Mask.ShowPlaceHolders = False
        Me.txt_orders_customers.Properties.ReadOnly = True
        Me.txt_orders_customers.Size = New System.Drawing.Size(350, 30)
        Me.txt_orders_customers.TabIndex = 0
        Me.txt_orders_customers.Tag = "Cliente"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_orders_customers, ConditionValidationRule1)
        '
        'txt_orders_purcharse
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_orders_purcharse, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_orders_purcharse.Location = New System.Drawing.Point(41, 210)
        Me.txt_orders_purcharse.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_orders_purcharse.Name = "txt_orders_purcharse"
        Me.txt_orders_purcharse.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_orders_purcharse.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_purcharse.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_purcharse.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_purcharse.Properties.Appearance.Options.UseBackColor = True
        Me.txt_orders_purcharse.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_orders_purcharse.Properties.Appearance.Options.UseForeColor = True
        Me.txt_orders_purcharse.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_orders_purcharse.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_purcharse.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_purcharse.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_purcharse.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_orders_purcharse.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_orders_purcharse.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_orders_purcharse.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_orders_purcharse.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_purcharse.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_purcharse.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_purcharse.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_orders_purcharse.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_orders_purcharse.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_orders_purcharse.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_orders_purcharse.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_purcharse.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_purcharse.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_purcharse.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_orders_purcharse.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_orders_purcharse.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_orders_purcharse.Properties.AutoHeight = False
        Me.txt_orders_purcharse.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_orders_purcharse.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_orders_purcharse.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_orders_purcharse.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_orders_purcharse.Properties.Mask.BeepOnError = True
        Me.txt_orders_purcharse.Properties.Mask.EditMask = "(\O\C\-)+(\w|[\-]){2,63}[a-zA-Z]{2,4}"
        Me.txt_orders_purcharse.Properties.Mask.ShowPlaceHolders = False
        Me.txt_orders_purcharse.Properties.ReadOnly = True
        Me.txt_orders_purcharse.Size = New System.Drawing.Size(350, 30)
        Me.txt_orders_purcharse.TabIndex = 0
        Me.txt_orders_purcharse.Tag = "Orden de compra"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_orders_purcharse, ConditionValidationRule2)
        '
        'txt_orders_invoice
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_orders_invoice, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_orders_invoice.Location = New System.Drawing.Point(40, 273)
        Me.txt_orders_invoice.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_orders_invoice.Name = "txt_orders_invoice"
        Me.txt_orders_invoice.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_orders_invoice.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_invoice.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_invoice.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_invoice.Properties.Appearance.Options.UseBackColor = True
        Me.txt_orders_invoice.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_orders_invoice.Properties.Appearance.Options.UseForeColor = True
        Me.txt_orders_invoice.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_orders_invoice.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_invoice.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_invoice.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_invoice.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_orders_invoice.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_orders_invoice.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_orders_invoice.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_orders_invoice.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_invoice.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_invoice.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_invoice.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_orders_invoice.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_orders_invoice.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_orders_invoice.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_orders_invoice.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_invoice.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_invoice.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_invoice.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_orders_invoice.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_orders_invoice.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_orders_invoice.Properties.AutoHeight = False
        Me.txt_orders_invoice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_orders_invoice.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_orders_invoice.Properties.DisplayFormat.FormatString = "\w\w\-\d\d\d\d\d\d"
        Me.txt_orders_invoice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txt_orders_invoice.Properties.EditFormat.FormatString = "\w\w\-\d\d\d\d\d\d"
        Me.txt_orders_invoice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txt_orders_invoice.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_orders_invoice.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_orders_invoice.Properties.Mask.BeepOnError = True
        Me.txt_orders_invoice.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.RegularMaskManager))
        Me.txt_orders_invoice.Properties.MaskSettings.Set("mask", "\F\E\-\d\d\d\d\d\d")
        Me.txt_orders_invoice.Size = New System.Drawing.Size(351, 30)
        Me.txt_orders_invoice.TabIndex = 1
        Me.txt_orders_invoice.Tag = "Numero de factura"
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_orders_invoice, ConditionValidationRule3)
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.lbl_orders_invoice)
        Me.pnl_object_container.Controls.Add(Me.txt_orders_invoice)
        Me.pnl_object_container.Controls.Add(Me.txt_orders_customers)
        Me.pnl_object_container.Controls.Add(Me.lbl_orders_purchase)
        Me.pnl_object_container.Controls.Add(Me.txt_orders_purcharse)
        Me.pnl_object_container.Controls.Add(Me.lbl_orders_customer)
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
        'lbl_orders_invoice
        '
        Me.lbl_orders_invoice.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orders_invoice.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_orders_invoice.Appearance.Options.UseFont = True
        Me.lbl_orders_invoice.Appearance.Options.UseForeColor = True
        Me.lbl_orders_invoice.Location = New System.Drawing.Point(40, 254)
        Me.lbl_orders_invoice.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_orders_invoice.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_orders_invoice.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_orders_invoice.Name = "lbl_orders_invoice"
        Me.lbl_orders_invoice.Size = New System.Drawing.Size(91, 16)
        Me.lbl_orders_invoice.TabIndex = 0
        Me.lbl_orders_invoice.Text = "Numero de factura*"
        '
        'lbl_orders_purchase
        '
        Me.lbl_orders_purchase.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orders_purchase.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_orders_purchase.Appearance.Options.UseFont = True
        Me.lbl_orders_purchase.Appearance.Options.UseForeColor = True
        Me.lbl_orders_purchase.Location = New System.Drawing.Point(41, 191)
        Me.lbl_orders_purchase.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_orders_purchase.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_orders_purchase.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_orders_purchase.Name = "lbl_orders_purchase"
        Me.lbl_orders_purchase.Size = New System.Drawing.Size(87, 16)
        Me.lbl_orders_purchase.TabIndex = 0
        Me.lbl_orders_purchase.Text = "Orden de compra*"
        '
        'lbl_orders_customer
        '
        Me.lbl_orders_customer.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orders_customer.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_orders_customer.Appearance.Options.UseFont = True
        Me.lbl_orders_customer.Appearance.Options.UseForeColor = True
        Me.lbl_orders_customer.Location = New System.Drawing.Point(41, 127)
        Me.lbl_orders_customer.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_orders_customer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_orders_customer.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_orders_customer.Name = "lbl_orders_customer"
        Me.lbl_orders_customer.Size = New System.Drawing.Size(91, 16)
        Me.lbl_orders_customer.TabIndex = 0
        Me.lbl_orders_customer.Text = "Nombre del cliente*"
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
        Me.lbl_orders_description.Size = New System.Drawing.Size(227, 16)
        Me.lbl_orders_description.TabIndex = 0
        Me.lbl_orders_description.Text = "Describa las observaciones finales de la solicitud"
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
        Me.lbl_object_title.Size = New System.Drawing.Size(142, 38)
        Me.lbl_object_title.TabIndex = 0
        Me.lbl_object_title.Text = "Finalizar Pedido"
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
        'wholesales_orders_closed
        '
        Me.AcceptButton = Me.btn_object_accept
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.BackColor2 = System.Drawing.Color.White
        Me.Appearance.BorderColor = System.Drawing.Color.White
        Me.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseBorderColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.btn_object_cancel
        Me.ClientSize = New System.Drawing.Size(851, 428)
        Me.Controls.Add(Me.pnl_object_container)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IconOptions.Image = CType(resources.GetObject("wholesales_orders_closed.IconOptions.Image"), System.Drawing.Image)
        Me.LookAndFeel.SkinName = "Office 2019 White"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "wholesales_orders_closed"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BIM"
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_orders_customers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_orders_purcharse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_orders_invoice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        CType(Me.chk_row_visible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_orders_description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents xvp_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Protected WithEvents chk_row_visible As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lbl_object_caracters As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_cancel As Button
    Friend WithEvents lbl_orders_description As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_accept As Button
    Friend WithEvents lbl_object_info As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_orders_customers As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_orders_purchase As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_orders_purcharse As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_orders_customer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_orders_invoice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_orders_invoice As APDA.Object.Controls.TextboxEdit
    Friend WithEvents xvp_spell As DevExpress.XtraSpellChecker.SpellChecker
    Private WithEvents txt_orders_description As DevExpress.XtraEditors.MemoEdit
End Class
