<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class wholesales_request_create
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wholesales_request_create))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule5 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim OptionsSpelling1 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
        Dim HunspellDictionary1 As DevExpress.XtraSpellChecker.HunspellDictionary = New DevExpress.XtraSpellChecker.HunspellDictionary()
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.cmb_request_agency = New APDA.[Object].Controls.ComboboxEdit()
        Me.cmb_request_seller = New APDA.[Object].Controls.ComboboxSearch()
        Me.dgv_sales_sellers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txt_request_date = New APDA.[Object].Controls.TextboxDates()
        Me.txt_request_sales = New APDA.[Object].Controls.TextboxEdit()
        Me.cmb_request_causal = New APDA.[Object].Controls.ComboboxEdit()
        Me.txt_request_description = New DevExpress.XtraEditors.MemoEdit()
        Me.pnl_object_top = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_refresh = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.pnl_object_bottom = New DevExpress.XtraEditors.PanelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.chk_keep_form = New DevExpress.XtraEditors.CheckEdit()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_object_caracters = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_request_description = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_request_sales = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_request_date = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_request_seller = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_request_causal = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_request_agency = New DevExpress.XtraEditors.LabelControl()
        Me.xvp_spell = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_request_agency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_request_seller.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_sales_sellers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_request_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_request_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_request_sales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_request_causal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_request_description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_top.SuspendLayout()
        CType(Me.pnl_object_bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_bottom.SuspendLayout()
        CType(Me.chk_keep_form.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        Me.SuspendLayout()
        '
        'xvp_validate
        '
        Me.xvp_validate.ValidateHiddenControls = False
        Me.xvp_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'cmb_request_agency
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_request_agency, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_request_agency.Location = New System.Drawing.Point(233, 97)
        Me.cmb_request_agency.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_request_agency.Name = "cmb_request_agency"
        Me.cmb_request_agency.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_request_agency.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_request_agency.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_request_agency.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_request_agency.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_request_agency.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_request_agency.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_request_agency.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_request_agency.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_request_agency.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_request_agency.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_request_agency.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_request_agency.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_request_agency.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_request_agency.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_request_agency.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_request_agency.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_request_agency.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_request_agency.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_request_agency.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_request_agency.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_request_agency.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_request_agency.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_request_agency.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_request_agency.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_request_agency.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_request_agency.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_request_agency.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_request_agency.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_request_agency.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_request_agency.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_request_agency.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_request_agency.Properties.AutoHeight = False
        Me.cmb_request_agency.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_request_agency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_request_agency.Properties.DropDownItemHeight = 30
        Me.cmb_request_agency.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_request_agency.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_request_agency.Properties.NullText = ""
        Me.cmb_request_agency.Properties.ShowFooter = False
        Me.cmb_request_agency.Properties.ShowHeader = False
        Me.cmb_request_agency.Size = New System.Drawing.Size(400, 30)
        Me.cmb_request_agency.TabIndex = 1
        Me.cmb_request_agency.Tag = "Agencia"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_request_agency, ConditionValidationRule1)
        '
        'cmb_request_seller
        '
        Me.cmb_request_seller.EditValue = ""
        Me.xvp_validate.SetIconAlignment(Me.cmb_request_seller, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_request_seller.Location = New System.Drawing.Point(233, 165)
        Me.cmb_request_seller.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_request_seller.Name = "cmb_request_seller"
        Me.cmb_request_seller.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_request_seller.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_request_seller.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_request_seller.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_request_seller.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_request_seller.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_request_seller.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_request_seller.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_request_seller.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_request_seller.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_request_seller.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmb_request_seller.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_request_seller.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_request_seller.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmb_request_seller.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_request_seller.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_request_seller.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_request_seller.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.cmb_request_seller.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_request_seller.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_request_seller.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.cmb_request_seller.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_request_seller.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_request_seller.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_request_seller.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.cmb_request_seller.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_request_seller.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_request_seller.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmb_request_seller.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_request_seller.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_request_seller.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_request_seller.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.cmb_request_seller.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_request_seller.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_request_seller.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.cmb_request_seller.Properties.AutoHeight = False
        Me.cmb_request_seller.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_request_seller.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_request_seller.Properties.LookAndFeel.SkinName = "My Office 2019 White"
        Me.cmb_request_seller.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_request_seller.Properties.NullText = ""
        Me.cmb_request_seller.Properties.PopupView = Me.dgv_sales_sellers
        Me.cmb_request_seller.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth
        Me.cmb_request_seller.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.cmb_request_seller.Size = New System.Drawing.Size(400, 30)
        Me.cmb_request_seller.TabIndex = 2
        Me.cmb_request_seller.Tag = "Usuario"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_request_seller, ConditionValidationRule2)
        '
        'dgv_sales_sellers
        '
        Me.dgv_sales_sellers.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.dgv_sales_sellers.Name = "dgv_sales_sellers"
        Me.dgv_sales_sellers.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.dgv_sales_sellers.OptionsView.ShowGroupPanel = False
        Me.dgv_sales_sellers.OptionsView.ShowIndicator = False
        '
        'txt_request_date
        '
        Me.txt_request_date.EditValue = Nothing
        Me.xvp_validate.SetIconAlignment(Me.txt_request_date, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_request_date.Location = New System.Drawing.Point(438, 302)
        Me.txt_request_date.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_request_date.Name = "txt_request_date"
        Me.txt_request_date.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_request_date.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_request_date.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_request_date.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_request_date.Properties.Appearance.Options.UseBackColor = True
        Me.txt_request_date.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_request_date.Properties.Appearance.Options.UseForeColor = True
        Me.txt_request_date.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_request_date.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_request_date.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_request_date.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_request_date.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_request_date.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_request_date.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.txt_request_date.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.txt_request_date.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.txt_request_date.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_request_date.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_request_date.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_request_date.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_request_date.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_request_date.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_request_date.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_request_date.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_request_date.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_request_date.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_request_date.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_request_date.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_request_date.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_request_date.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_request_date.Properties.AutoHeight = False
        Me.txt_request_date.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txt_request_date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_request_date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_request_date.Properties.DisplayFormat.FormatString = "D"
        Me.txt_request_date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_request_date.Properties.EditFormat.FormatString = "D"
        Me.txt_request_date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_request_date.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_request_date.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_request_date.Properties.Mask.EditMask = "D"
        Me.txt_request_date.Properties.ReadOnly = True
        Me.txt_request_date.Properties.SelectionMode = DevExpress.XtraEditors.Repository.CalendarSelectionMode.Multiple
        Me.txt_request_date.Size = New System.Drawing.Size(195, 30)
        Me.txt_request_date.TabIndex = 5
        Me.txt_request_date.Tag = "Fecha de venta"
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_request_date, ConditionValidationRule3)
        '
        'txt_request_sales
        '
        Me.txt_request_sales.EditValue = ""
        Me.xvp_validate.SetIconAlignment(Me.txt_request_sales, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_request_sales.Location = New System.Drawing.Point(233, 302)
        Me.txt_request_sales.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_request_sales.Name = "txt_request_sales"
        Me.txt_request_sales.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_request_sales.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_request_sales.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_request_sales.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_request_sales.Properties.Appearance.Options.UseBackColor = True
        Me.txt_request_sales.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_request_sales.Properties.Appearance.Options.UseForeColor = True
        Me.txt_request_sales.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_request_sales.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_request_sales.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_request_sales.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_request_sales.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_request_sales.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_request_sales.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_request_sales.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_request_sales.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_request_sales.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_request_sales.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_request_sales.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_request_sales.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_request_sales.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_request_sales.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_request_sales.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_request_sales.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_request_sales.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_request_sales.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_request_sales.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_request_sales.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_request_sales.Properties.AutoHeight = False
        Me.txt_request_sales.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_request_sales.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_request_sales.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_request_sales.Properties.Mask.BeepOnError = True
        Me.txt_request_sales.Properties.Mask.EditMask = "\d+"
        Me.txt_request_sales.Properties.MaxLength = 50
        Me.txt_request_sales.Properties.ReadOnly = True
        Me.txt_request_sales.Size = New System.Drawing.Size(195, 30)
        Me.txt_request_sales.TabIndex = 4
        Me.txt_request_sales.Tag = "Venta"
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_request_sales, ConditionValidationRule4)
        '
        'cmb_request_causal
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_request_causal, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_request_causal.Location = New System.Drawing.Point(233, 233)
        Me.cmb_request_causal.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_request_causal.Name = "cmb_request_causal"
        Me.cmb_request_causal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_request_causal.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_request_causal.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_request_causal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_request_causal.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_request_causal.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_request_causal.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_request_causal.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_request_causal.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_request_causal.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_request_causal.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_request_causal.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_request_causal.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_request_causal.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_request_causal.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_request_causal.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_request_causal.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_request_causal.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_request_causal.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_request_causal.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_request_causal.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_request_causal.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_request_causal.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_request_causal.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_request_causal.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_request_causal.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_request_causal.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_request_causal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_request_causal.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_request_causal.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_request_causal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_request_causal.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_request_causal.Properties.AutoHeight = False
        Me.cmb_request_causal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_request_causal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_request_causal.Properties.DropDownItemHeight = 30
        Me.cmb_request_causal.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_request_causal.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_request_causal.Properties.NullText = ""
        Me.cmb_request_causal.Properties.ShowFooter = False
        Me.cmb_request_causal.Properties.ShowHeader = False
        Me.cmb_request_causal.Size = New System.Drawing.Size(400, 30)
        Me.cmb_request_causal.TabIndex = 3
        Me.cmb_request_causal.Tag = "Causales"
        ConditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule5.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_request_causal, ConditionValidationRule5)
        '
        'txt_request_description
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_request_description, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_request_description.Location = New System.Drawing.Point(745, 97)
        Me.txt_request_description.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_request_description.Name = "txt_request_description"
        Me.txt_request_description.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_request_description.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_request_description.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_request_description.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_request_description.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_request_description.Properties.Appearance.Options.UseBackColor = True
        Me.txt_request_description.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_request_description.Properties.Appearance.Options.UseFont = True
        Me.txt_request_description.Properties.Appearance.Options.UseForeColor = True
        Me.txt_request_description.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_request_description.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_request_description.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.xvp_spell.SetShowSpellCheckMenu(Me.txt_request_description, True)
        Me.txt_request_description.Size = New System.Drawing.Size(400, 235)
        Me.xvp_spell.SetSpellCheckerOptions(Me.txt_request_description, OptionsSpelling1)
        Me.txt_request_description.TabIndex = 6
        Me.txt_request_description.Tag = "Descripción"
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
        Me.lbl_object_title.Text = "Crear Solicitud"
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
        Me.chk_keep_form.EditValue = True
        Me.chk_keep_form.Location = New System.Drawing.Point(976, 335)
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
        Me.chk_keep_form.Size = New System.Drawing.Size(171, 20)
        Me.chk_keep_form.TabIndex = 0
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.lbl_object_caracters)
        Me.pnl_object_container.Controls.Add(Me.chk_keep_form)
        Me.pnl_object_container.Controls.Add(Me.lbl_request_description)
        Me.pnl_object_container.Controls.Add(Me.txt_request_sales)
        Me.pnl_object_container.Controls.Add(Me.lbl_request_sales)
        Me.pnl_object_container.Controls.Add(Me.txt_request_date)
        Me.pnl_object_container.Controls.Add(Me.lbl_request_date)
        Me.pnl_object_container.Controls.Add(Me.cmb_request_seller)
        Me.pnl_object_container.Controls.Add(Me.lbl_request_seller)
        Me.pnl_object_container.Controls.Add(Me.lbl_request_causal)
        Me.pnl_object_container.Controls.Add(Me.lbl_request_agency)
        Me.pnl_object_container.Controls.Add(Me.cmb_request_agency)
        Me.pnl_object_container.Controls.Add(Me.cmb_request_causal)
        Me.pnl_object_container.Controls.Add(Me.txt_request_description)
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
        'lbl_object_caracters
        '
        Me.lbl_object_caracters.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_caracters.Appearance.Options.UseForeColor = True
        Me.lbl_object_caracters.Location = New System.Drawing.Point(745, 336)
        Me.lbl_object_caracters.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_caracters.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_caracters.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_caracters.Name = "lbl_object_caracters"
        Me.lbl_object_caracters.Size = New System.Drawing.Size(27, 16)
        Me.lbl_object_caracters.TabIndex = 7
        Me.lbl_object_caracters.Text = "0/300"
        '
        'lbl_request_description
        '
        Me.lbl_request_description.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_request_description.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_request_description.Appearance.Options.UseFont = True
        Me.lbl_request_description.Appearance.Options.UseForeColor = True
        Me.lbl_request_description.Location = New System.Drawing.Point(745, 78)
        Me.lbl_request_description.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_request_description.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_request_description.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_request_description.Name = "lbl_request_description"
        Me.lbl_request_description.Size = New System.Drawing.Size(223, 16)
        Me.lbl_request_description.TabIndex = 0
        Me.lbl_request_description.Text = "Describa detalladamente los cambios a realizar*"
        '
        'lbl_request_sales
        '
        Me.lbl_request_sales.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_request_sales.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_request_sales.Appearance.Options.UseFont = True
        Me.lbl_request_sales.Appearance.Options.UseForeColor = True
        Me.lbl_request_sales.Location = New System.Drawing.Point(233, 283)
        Me.lbl_request_sales.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_request_sales.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_request_sales.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_request_sales.Name = "lbl_request_sales"
        Me.lbl_request_sales.Size = New System.Drawing.Size(86, 16)
        Me.lbl_request_sales.TabIndex = 0
        Me.lbl_request_sales.Text = "Numero de venta*"
        '
        'lbl_request_date
        '
        Me.lbl_request_date.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_request_date.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_request_date.Appearance.Options.UseFont = True
        Me.lbl_request_date.Appearance.Options.UseForeColor = True
        Me.lbl_request_date.Location = New System.Drawing.Point(438, 283)
        Me.lbl_request_date.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_request_date.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_request_date.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_request_date.Name = "lbl_request_date"
        Me.lbl_request_date.Size = New System.Drawing.Size(78, 16)
        Me.lbl_request_date.TabIndex = 0
        Me.lbl_request_date.Text = "Fecha de venta*"
        '
        'lbl_request_seller
        '
        Me.lbl_request_seller.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_request_seller.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_request_seller.Appearance.Options.UseFont = True
        Me.lbl_request_seller.Appearance.Options.UseForeColor = True
        Me.lbl_request_seller.Location = New System.Drawing.Point(233, 146)
        Me.lbl_request_seller.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_request_seller.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_request_seller.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_request_seller.Name = "lbl_request_seller"
        Me.lbl_request_seller.Size = New System.Drawing.Size(256, 16)
        Me.lbl_request_seller.TabIndex = 0
        Me.lbl_request_seller.Text = "Seleccione el nombre del usuario a asignar la petición*"
        '
        'lbl_request_causal
        '
        Me.lbl_request_causal.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_request_causal.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_request_causal.Appearance.Options.UseFont = True
        Me.lbl_request_causal.Appearance.Options.UseForeColor = True
        Me.lbl_request_causal.Location = New System.Drawing.Point(233, 214)
        Me.lbl_request_causal.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_request_causal.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_request_causal.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_request_causal.Name = "lbl_request_causal"
        Me.lbl_request_causal.Size = New System.Drawing.Size(228, 16)
        Me.lbl_request_causal.TabIndex = 0
        Me.lbl_request_causal.Text = "Seleccione la causal de modificación de la venta*"
        '
        'lbl_request_agency
        '
        Me.lbl_request_agency.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_request_agency.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_request_agency.Appearance.Options.UseFont = True
        Me.lbl_request_agency.Appearance.Options.UseForeColor = True
        Me.lbl_request_agency.Location = New System.Drawing.Point(233, 78)
        Me.lbl_request_agency.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_request_agency.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_request_agency.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_request_agency.Name = "lbl_request_agency"
        Me.lbl_request_agency.Size = New System.Drawing.Size(171, 16)
        Me.lbl_request_agency.TabIndex = 0
        Me.lbl_request_agency.Text = "Seleccione el nombre de la agencia*"
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
        Me.xvp_spell.ParentContainer = Me.txt_request_description
        Me.xvp_spell.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType
        Me.xvp_spell.SpellingFormType = DevExpress.XtraSpellChecker.SpellingFormType.Word
        '
        'wholesales_request_create
        '
        Me.AccessibleName = "WR002C"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnl_object_container)
        Me.Controls.Add(Me.pnl_object_bottom)
        Me.Controls.Add(Me.pnl_object_top)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "wholesales_request_create"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(1350, 550)
        Me.Tag = "Crear Solicitud"
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_request_agency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_request_seller.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_sales_sellers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_request_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_request_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_request_sales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_request_causal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_request_description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_top.ResumeLayout(False)
        CType(Me.pnl_object_bottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_bottom.ResumeLayout(False)
        CType(Me.chk_keep_form.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Protected WithEvents chk_keep_form As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_request_agency As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_request_agency As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_request_causal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_request_seller As APDA.Object.Controls.ComboboxSearch
    Friend WithEvents dgv_sales_sellers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbl_request_seller As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_request_date As APDA.Object.Controls.TextboxDates
    Friend WithEvents lbl_request_date As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_request_sales As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_request_sales As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_request_description As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_caracters As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_request_causal As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents xvp_spell As DevExpress.XtraSpellChecker.SpellChecker
    Private WithEvents txt_request_description As DevExpress.XtraEditors.MemoEdit
End Class
