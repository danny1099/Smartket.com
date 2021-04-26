<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class wholesales_orders_created
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wholesales_orders_created))
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule5 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule6 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule7 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule8 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule9 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule10 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule11 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim OptionsSpelling1 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim HunspellDictionary1 As DevExpress.XtraSpellChecker.HunspellDictionary = New DevExpress.XtraSpellChecker.HunspellDictionary()
        Me.pnl_object_top = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_refresh = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.cmb_orders_person = New APDA.[Object].Controls.ComboboxSearch()
        Me.dgv_sales_sellers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmb_orders_agency = New APDA.[Object].Controls.ComboboxEdit()
        Me.cmb_orders_customer = New APDA.[Object].Controls.ComboboxSearch()
        Me.dgv_sales_customers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmb_orders_cities = New APDA.[Object].Controls.ComboboxEdit()
        Me.cmb_orders_deptos = New APDA.[Object].Controls.ComboboxEdit()
        Me.txt_orders_neighborhood = New APDA.[Object].Controls.TextboxEdit()
        Me.txt_orders_address = New APDA.[Object].Controls.TextboxEdit()
        Me.txt_orders_purcharse = New APDA.[Object].Controls.TextboxEdit()
        Me.txt_orders_email = New APDA.[Object].Controls.TextboxEdit()
        Me.cmb_orders_payment = New APDA.[Object].Controls.ComboboxEdit()
        Me.cmb_orders_platform = New APDA.[Object].Controls.ComboboxEdit()
        Me.txt_orders_description = New DevExpress.XtraEditors.MemoEdit()
        Me.pnl_object_bottom = New DevExpress.XtraEditors.PanelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.pnl_object_resumen = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_orders_platform = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_caracters = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_orders_description = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_orders_email = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_orders_purchase = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_orders_payment = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_orders_neighborhood = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_orders_address = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_orders_cities = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_orders_person = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_orders_deptos = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_orders_agency = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_orders_newcustomer = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_orders_customer = New DevExpress.XtraEditors.LabelControl()
        Me.chk_keep_form = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_orders_type = New DevExpress.XtraEditors.CheckEdit()
        Me.pnl_object_container = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.pnl_object_products = New DevExpress.XtraEditors.PanelControl()
        Me.pnl_object_grid = New DevExpress.XtraEditors.PanelControl()
        Me.dgv_object_grid = New DevExpress.XtraGrid.GridControl()
        Me.dgv_object_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.pnl_object_search = New DevExpress.XtraEditors.PanelControl()
        Me.txt_object_search = New DevExpress.XtraEditors.SearchControl()
        Me.lbl_separator2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txt_object_navigate = New DevExpress.XtraEditors.ControlNavigator()
        Me.pnl_object_options = New DevExpress.XtraEditors.PanelControl()
        Me.btn_object_update = New System.Windows.Forms.Button()
        Me.lbl_separator1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.lbl_object_count = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_total = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_export = New System.Windows.Forms.Button()
        Me.btn_object_panel = New System.Windows.Forms.Button()
        Me.xvp_spell = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_top.SuspendLayout()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_orders_person.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_sales_sellers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_orders_agency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_orders_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_sales_customers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_orders_cities.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_orders_deptos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_orders_neighborhood.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_orders_address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_orders_purcharse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_orders_email.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_orders_payment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_orders_platform.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_orders_description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_bottom.SuspendLayout()
        CType(Me.pnl_object_resumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_resumen.SuspendLayout()
        CType(Me.chk_keep_form.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_orders_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        CType(Me.pnl_object_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_products.SuspendLayout()
        CType(Me.pnl_object_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_grid.SuspendLayout()
        CType(Me.dgv_object_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_object_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_search.SuspendLayout()
        CType(Me.txt_object_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_separator2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_options, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_options.SuspendLayout()
        CType(Me.lbl_separator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lbl_object_title.Text = "Crear Pedido"
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
        'xvp_validate
        '
        Me.xvp_validate.ValidateHiddenControls = False
        Me.xvp_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'cmb_orders_person
        '
        Me.cmb_orders_person.EditValue = ""
        Me.xvp_validate.SetIconAlignment(Me.cmb_orders_person, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_orders_person.Location = New System.Drawing.Point(727, 69)
        Me.cmb_orders_person.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_orders_person.Name = "cmb_orders_person"
        Me.cmb_orders_person.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_orders_person.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_person.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_person.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_orders_person.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_orders_person.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_orders_person.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_orders_person.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_orders_person.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_person.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_person.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmb_orders_person.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_orders_person.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_orders_person.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmb_orders_person.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_orders_person.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_person.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_person.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.cmb_orders_person.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_orders_person.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_orders_person.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.cmb_orders_person.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_orders_person.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_person.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_person.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.cmb_orders_person.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_orders_person.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_orders_person.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmb_orders_person.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_orders_person.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_person.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_person.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.cmb_orders_person.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_orders_person.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_orders_person.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.cmb_orders_person.Properties.AutoHeight = False
        Me.cmb_orders_person.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_orders_person.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_orders_person.Properties.LookAndFeel.SkinName = "My Office 2019 White"
        Me.cmb_orders_person.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_orders_person.Properties.NullText = ""
        Me.cmb_orders_person.Properties.PopupView = Me.dgv_sales_sellers
        Me.cmb_orders_person.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth
        Me.cmb_orders_person.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.cmb_orders_person.Size = New System.Drawing.Size(400, 30)
        Me.cmb_orders_person.TabIndex = 8
        Me.cmb_orders_person.Tag = "Responsable"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_orders_person, ConditionValidationRule1)
        '
        'dgv_sales_sellers
        '
        Me.dgv_sales_sellers.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.dgv_sales_sellers.Name = "dgv_sales_sellers"
        Me.dgv_sales_sellers.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.dgv_sales_sellers.OptionsView.ShowGroupPanel = False
        Me.dgv_sales_sellers.OptionsView.ShowIndicator = False
        '
        'cmb_orders_agency
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_orders_agency, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_orders_agency.Location = New System.Drawing.Point(206, 325)
        Me.cmb_orders_agency.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_orders_agency.Name = "cmb_orders_agency"
        Me.cmb_orders_agency.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_orders_agency.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_agency.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_agency.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_orders_agency.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_orders_agency.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_orders_agency.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_orders_agency.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_orders_agency.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_agency.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_agency.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_orders_agency.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_orders_agency.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_orders_agency.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_agency.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_agency.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_orders_agency.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_orders_agency.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_orders_agency.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_agency.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_agency.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_orders_agency.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_orders_agency.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_orders_agency.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_agency.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_agency.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_orders_agency.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_orders_agency.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_orders_agency.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_agency.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_agency.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_orders_agency.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_orders_agency.Properties.AutoHeight = False
        Me.cmb_orders_agency.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_orders_agency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_orders_agency.Properties.DropDownItemHeight = 30
        Me.cmb_orders_agency.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_orders_agency.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_orders_agency.Properties.NullText = ""
        Me.cmb_orders_agency.Properties.ShowFooter = False
        Me.cmb_orders_agency.Properties.ShowHeader = False
        Me.cmb_orders_agency.Size = New System.Drawing.Size(400, 30)
        Me.cmb_orders_agency.TabIndex = 7
        Me.cmb_orders_agency.Tag = "Agencia"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_orders_agency, ConditionValidationRule2)
        '
        'cmb_orders_customer
        '
        Me.cmb_orders_customer.EditValue = ""
        Me.xvp_validate.SetIconAlignment(Me.cmb_orders_customer, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_orders_customer.Location = New System.Drawing.Point(206, 69)
        Me.cmb_orders_customer.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_orders_customer.Name = "cmb_orders_customer"
        Me.cmb_orders_customer.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_orders_customer.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_customer.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_customer.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_orders_customer.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_orders_customer.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_orders_customer.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_orders_customer.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_orders_customer.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_customer.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_customer.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmb_orders_customer.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_orders_customer.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_orders_customer.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmb_orders_customer.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_orders_customer.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_customer.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_customer.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.cmb_orders_customer.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_orders_customer.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_orders_customer.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.cmb_orders_customer.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_orders_customer.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_customer.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_customer.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.cmb_orders_customer.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_orders_customer.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_orders_customer.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmb_orders_customer.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_orders_customer.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_customer.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_customer.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.cmb_orders_customer.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_orders_customer.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_orders_customer.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.cmb_orders_customer.Properties.AutoHeight = False
        Me.cmb_orders_customer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_orders_customer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_orders_customer.Properties.LookAndFeel.SkinName = "My Office 2019 White"
        Me.cmb_orders_customer.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_orders_customer.Properties.NullText = ""
        Me.cmb_orders_customer.Properties.PopupView = Me.dgv_sales_customers
        Me.cmb_orders_customer.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.cmb_orders_customer.Size = New System.Drawing.Size(400, 30)
        Me.cmb_orders_customer.TabIndex = 1
        Me.cmb_orders_customer.Tag = "Cliente"
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_orders_customer, ConditionValidationRule3)
        '
        'dgv_sales_customers
        '
        Me.dgv_sales_customers.Appearance.GroupPanel.BackColor = System.Drawing.Color.White
        Me.dgv_sales_customers.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.dgv_sales_customers.Appearance.GroupPanel.BorderColor = System.Drawing.Color.White
        Me.dgv_sales_customers.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.dgv_sales_customers.Appearance.GroupPanel.Options.UseBackColor = True
        Me.dgv_sales_customers.Appearance.GroupPanel.Options.UseBorderColor = True
        Me.dgv_sales_customers.Appearance.GroupPanel.Options.UseForeColor = True
        Me.dgv_sales_customers.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_sales_customers.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_sales_customers.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_sales_customers.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.dgv_sales_customers.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.dgv_sales_customers.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.dgv_sales_customers.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.dgv_sales_customers.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.dgv_sales_customers.Name = "dgv_sales_customers"
        Me.dgv_sales_customers.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.dgv_sales_customers.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.dgv_sales_customers.OptionsView.ShowGroupPanel = False
        Me.dgv_sales_customers.OptionsView.ShowIndicator = False
        '
        'cmb_orders_cities
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_orders_cities, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_orders_cities.Location = New System.Drawing.Point(385, 133)
        Me.cmb_orders_cities.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_orders_cities.Name = "cmb_orders_cities"
        Me.cmb_orders_cities.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_orders_cities.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_cities.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_cities.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_orders_cities.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_orders_cities.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_orders_cities.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_orders_cities.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_orders_cities.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_cities.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_cities.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_orders_cities.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_orders_cities.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_orders_cities.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_cities.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_cities.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_orders_cities.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_orders_cities.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_orders_cities.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_cities.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_cities.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_orders_cities.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_orders_cities.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_orders_cities.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_cities.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_cities.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_orders_cities.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_orders_cities.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_orders_cities.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_cities.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_cities.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_orders_cities.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_orders_cities.Properties.AutoHeight = False
        Me.cmb_orders_cities.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_orders_cities.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_orders_cities.Properties.DropDownItemHeight = 30
        Me.cmb_orders_cities.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_orders_cities.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_orders_cities.Properties.NullText = ""
        Me.cmb_orders_cities.Properties.ShowFooter = False
        Me.cmb_orders_cities.Properties.ShowHeader = False
        Me.cmb_orders_cities.Size = New System.Drawing.Size(221, 30)
        Me.cmb_orders_cities.TabIndex = 3
        Me.cmb_orders_cities.Tag = "Ciudad"
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_orders_cities, ConditionValidationRule4)
        '
        'cmb_orders_deptos
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_orders_deptos, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_orders_deptos.Location = New System.Drawing.Point(206, 133)
        Me.cmb_orders_deptos.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_orders_deptos.Name = "cmb_orders_deptos"
        Me.cmb_orders_deptos.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_orders_deptos.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_deptos.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_deptos.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_orders_deptos.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_orders_deptos.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_orders_deptos.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_orders_deptos.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_orders_deptos.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_deptos.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_deptos.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_orders_deptos.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_orders_deptos.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_orders_deptos.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_deptos.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_deptos.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_orders_deptos.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_orders_deptos.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_orders_deptos.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_deptos.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_deptos.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_orders_deptos.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_orders_deptos.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_orders_deptos.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_deptos.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_deptos.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_orders_deptos.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_orders_deptos.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_orders_deptos.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_deptos.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_deptos.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_orders_deptos.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_orders_deptos.Properties.AutoHeight = False
        Me.cmb_orders_deptos.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_orders_deptos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_orders_deptos.Properties.DropDownItemHeight = 30
        Me.cmb_orders_deptos.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_orders_deptos.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_orders_deptos.Properties.NullText = ""
        Me.cmb_orders_deptos.Properties.ShowFooter = False
        Me.cmb_orders_deptos.Properties.ShowHeader = False
        Me.cmb_orders_deptos.Size = New System.Drawing.Size(171, 30)
        Me.cmb_orders_deptos.TabIndex = 2
        Me.cmb_orders_deptos.Tag = "Departamento"
        ConditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule5.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_orders_deptos, ConditionValidationRule5)
        '
        'txt_orders_neighborhood
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_orders_neighborhood, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_orders_neighborhood.Location = New System.Drawing.Point(430, 197)
        Me.txt_orders_neighborhood.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_orders_neighborhood.Name = "txt_orders_neighborhood"
        Me.txt_orders_neighborhood.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_orders_neighborhood.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_neighborhood.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_neighborhood.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_neighborhood.Properties.Appearance.Options.UseBackColor = True
        Me.txt_orders_neighborhood.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_orders_neighborhood.Properties.Appearance.Options.UseForeColor = True
        Me.txt_orders_neighborhood.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_orders_neighborhood.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_neighborhood.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_neighborhood.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_neighborhood.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_orders_neighborhood.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_orders_neighborhood.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_orders_neighborhood.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_orders_neighborhood.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_neighborhood.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_neighborhood.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_neighborhood.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_orders_neighborhood.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_orders_neighborhood.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_orders_neighborhood.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_orders_neighborhood.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_neighborhood.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_neighborhood.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_neighborhood.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_orders_neighborhood.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_orders_neighborhood.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_orders_neighborhood.Properties.AutoHeight = False
        Me.txt_orders_neighborhood.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_orders_neighborhood.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_orders_neighborhood.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_orders_neighborhood.Size = New System.Drawing.Size(176, 30)
        Me.txt_orders_neighborhood.TabIndex = 5
        Me.txt_orders_neighborhood.Tag = "Barrio"
        ConditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule6.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_orders_neighborhood, ConditionValidationRule6)
        '
        'txt_orders_address
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_orders_address, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_orders_address.Location = New System.Drawing.Point(206, 197)
        Me.txt_orders_address.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_orders_address.Name = "txt_orders_address"
        Me.txt_orders_address.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_orders_address.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_address.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_address.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_address.Properties.Appearance.Options.UseBackColor = True
        Me.txt_orders_address.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_orders_address.Properties.Appearance.Options.UseForeColor = True
        Me.txt_orders_address.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_orders_address.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_address.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_address.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_address.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_orders_address.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_orders_address.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_orders_address.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_orders_address.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_address.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_address.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_address.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_orders_address.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_orders_address.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_orders_address.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_orders_address.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_address.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_address.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_address.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_orders_address.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_orders_address.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_orders_address.Properties.AutoHeight = False
        Me.txt_orders_address.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txt_orders_address.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_orders_address.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_orders_address.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_orders_address.Size = New System.Drawing.Size(217, 30)
        Me.txt_orders_address.TabIndex = 4
        Me.txt_orders_address.Tag = "Dirección"
        ConditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule7.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_orders_address, ConditionValidationRule7)
        '
        'txt_orders_purcharse
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_orders_purcharse, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_orders_purcharse.Location = New System.Drawing.Point(727, 197)
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
        Me.txt_orders_purcharse.Size = New System.Drawing.Size(171, 30)
        Me.txt_orders_purcharse.TabIndex = 10
        Me.txt_orders_purcharse.Tag = "Orden de compra"
        ConditionValidationRule8.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule8.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_orders_purcharse, ConditionValidationRule8)
        '
        'txt_orders_email
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_orders_email, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_orders_email.Location = New System.Drawing.Point(206, 261)
        Me.txt_orders_email.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_orders_email.Name = "txt_orders_email"
        Me.txt_orders_email.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_orders_email.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_email.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_email.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_email.Properties.Appearance.Options.UseBackColor = True
        Me.txt_orders_email.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_orders_email.Properties.Appearance.Options.UseForeColor = True
        Me.txt_orders_email.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_orders_email.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_email.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_email.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_email.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_orders_email.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_orders_email.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_orders_email.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_orders_email.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_email.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_email.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_email.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_orders_email.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_orders_email.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_orders_email.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_orders_email.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_orders_email.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_orders_email.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_orders_email.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_orders_email.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_orders_email.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_orders_email.Properties.AutoHeight = False
        Me.txt_orders_email.Properties.BeepOnError = True
        Me.txt_orders_email.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        Me.txt_orders_email.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, False, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_orders_email.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_orders_email.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_orders_email.Properties.Mask.BeepOnError = True
        Me.txt_orders_email.Size = New System.Drawing.Size(400, 30)
        Me.txt_orders_email.TabIndex = 6
        Me.txt_orders_email.Tag = "Email"
        ConditionValidationRule9.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule9.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_orders_email, ConditionValidationRule9)
        '
        'cmb_orders_payment
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_orders_payment, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_orders_payment.Location = New System.Drawing.Point(906, 197)
        Me.cmb_orders_payment.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_orders_payment.Name = "cmb_orders_payment"
        Me.cmb_orders_payment.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_orders_payment.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_payment.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_payment.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_orders_payment.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_orders_payment.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_orders_payment.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_orders_payment.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_orders_payment.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_payment.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_payment.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_orders_payment.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_orders_payment.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_orders_payment.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_payment.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_payment.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_orders_payment.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_orders_payment.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_orders_payment.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_payment.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_payment.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_orders_payment.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_orders_payment.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_orders_payment.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_payment.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_payment.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_orders_payment.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_orders_payment.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_orders_payment.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_payment.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_payment.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_orders_payment.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_orders_payment.Properties.AutoHeight = False
        Me.cmb_orders_payment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_orders_payment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_orders_payment.Properties.DropDownItemHeight = 30
        Me.cmb_orders_payment.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_orders_payment.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_orders_payment.Properties.NullText = ""
        Me.cmb_orders_payment.Properties.ShowFooter = False
        Me.cmb_orders_payment.Properties.ShowHeader = False
        Me.cmb_orders_payment.Size = New System.Drawing.Size(221, 30)
        Me.cmb_orders_payment.TabIndex = 11
        Me.cmb_orders_payment.Tag = "Forma de pago"
        ConditionValidationRule10.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule10.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_orders_payment, ConditionValidationRule10)
        '
        'cmb_orders_platform
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_orders_platform, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_orders_platform.Location = New System.Drawing.Point(727, 133)
        Me.cmb_orders_platform.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_orders_platform.Name = "cmb_orders_platform"
        Me.cmb_orders_platform.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_orders_platform.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_platform.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_platform.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_orders_platform.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_orders_platform.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_orders_platform.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_orders_platform.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_orders_platform.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_platform.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_platform.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_orders_platform.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_orders_platform.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_orders_platform.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_platform.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_platform.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_orders_platform.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_orders_platform.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_orders_platform.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_platform.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_platform.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_orders_platform.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_orders_platform.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_orders_platform.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_platform.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_platform.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_orders_platform.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_orders_platform.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_orders_platform.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_orders_platform.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_orders_platform.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_orders_platform.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_orders_platform.Properties.AutoHeight = False
        Me.cmb_orders_platform.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_orders_platform.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_orders_platform.Properties.DropDownItemHeight = 30
        Me.cmb_orders_platform.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_orders_platform.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_orders_platform.Properties.NullText = ""
        Me.cmb_orders_platform.Properties.ShowFooter = False
        Me.cmb_orders_platform.Properties.ShowHeader = False
        Me.cmb_orders_platform.Size = New System.Drawing.Size(401, 30)
        Me.cmb_orders_platform.TabIndex = 9
        Me.cmb_orders_platform.Tag = "Plataforma"
        ConditionValidationRule11.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule11.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_orders_platform, ConditionValidationRule11)
        '
        'txt_orders_description
        '
        Me.xvp_validate.SetIconAlignment(Me.txt_orders_description, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_orders_description.Location = New System.Drawing.Point(727, 261)
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
        Me.txt_orders_description.Size = New System.Drawing.Size(400, 94)
        Me.xvp_spell.SetSpellCheckerOptions(Me.txt_orders_description, OptionsSpelling1)
        Me.txt_orders_description.TabIndex = 12
        Me.txt_orders_description.Tag = "Descripción"
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
        'pnl_object_resumen
        '
        Me.pnl_object_resumen.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_resumen.Controls.Add(Me.lbl_orders_platform)
        Me.pnl_object_resumen.Controls.Add(Me.cmb_orders_platform)
        Me.pnl_object_resumen.Controls.Add(Me.lbl_object_caracters)
        Me.pnl_object_resumen.Controls.Add(Me.lbl_orders_description)
        Me.pnl_object_resumen.Controls.Add(Me.lbl_orders_email)
        Me.pnl_object_resumen.Controls.Add(Me.txt_orders_email)
        Me.pnl_object_resumen.Controls.Add(Me.lbl_orders_purchase)
        Me.pnl_object_resumen.Controls.Add(Me.txt_orders_purcharse)
        Me.pnl_object_resumen.Controls.Add(Me.lbl_orders_payment)
        Me.pnl_object_resumen.Controls.Add(Me.lbl_orders_neighborhood)
        Me.pnl_object_resumen.Controls.Add(Me.txt_orders_neighborhood)
        Me.pnl_object_resumen.Controls.Add(Me.txt_orders_address)
        Me.pnl_object_resumen.Controls.Add(Me.lbl_orders_address)
        Me.pnl_object_resumen.Controls.Add(Me.lbl_orders_cities)
        Me.pnl_object_resumen.Controls.Add(Me.cmb_orders_person)
        Me.pnl_object_resumen.Controls.Add(Me.cmb_orders_cities)
        Me.pnl_object_resumen.Controls.Add(Me.lbl_orders_person)
        Me.pnl_object_resumen.Controls.Add(Me.cmb_orders_deptos)
        Me.pnl_object_resumen.Controls.Add(Me.lbl_orders_deptos)
        Me.pnl_object_resumen.Controls.Add(Me.lbl_orders_agency)
        Me.pnl_object_resumen.Controls.Add(Me.cmb_orders_agency)
        Me.pnl_object_resumen.Controls.Add(Me.lbl_orders_newcustomer)
        Me.pnl_object_resumen.Controls.Add(Me.lbl_orders_customer)
        Me.pnl_object_resumen.Controls.Add(Me.cmb_orders_customer)
        Me.pnl_object_resumen.Controls.Add(Me.cmb_orders_payment)
        Me.pnl_object_resumen.Controls.Add(Me.txt_orders_description)
        Me.pnl_object_resumen.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_object_resumen.Location = New System.Drawing.Point(0, 0)
        Me.pnl_object_resumen.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_resumen.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_resumen.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_resumen.Name = "pnl_object_resumen"
        Me.pnl_object_resumen.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_resumen.Size = New System.Drawing.Size(1331, 390)
        Me.pnl_object_resumen.TabIndex = 0
        '
        'lbl_orders_platform
        '
        Me.lbl_orders_platform.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orders_platform.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_orders_platform.Appearance.Options.UseFont = True
        Me.lbl_orders_platform.Appearance.Options.UseForeColor = True
        Me.lbl_orders_platform.Location = New System.Drawing.Point(727, 113)
        Me.lbl_orders_platform.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_orders_platform.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_orders_platform.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_orders_platform.Name = "lbl_orders_platform"
        Me.lbl_orders_platform.Size = New System.Drawing.Size(108, 16)
        Me.lbl_orders_platform.TabIndex = 0
        Me.lbl_orders_platform.Text = "Nombre de plataforma*"
        '
        'lbl_object_caracters
        '
        Me.lbl_object_caracters.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_caracters.Appearance.Options.UseForeColor = True
        Me.lbl_object_caracters.Location = New System.Drawing.Point(1100, 358)
        Me.lbl_object_caracters.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_caracters.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_caracters.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_caracters.Name = "lbl_object_caracters"
        Me.lbl_object_caracters.Size = New System.Drawing.Size(27, 16)
        Me.lbl_object_caracters.TabIndex = 0
        Me.lbl_object_caracters.Text = "0/500"
        '
        'lbl_orders_description
        '
        Me.lbl_orders_description.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orders_description.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_orders_description.Appearance.Options.UseFont = True
        Me.lbl_orders_description.Appearance.Options.UseForeColor = True
        Me.lbl_orders_description.Location = New System.Drawing.Point(727, 241)
        Me.lbl_orders_description.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_orders_description.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_orders_description.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_orders_description.Name = "lbl_orders_description"
        Me.lbl_orders_description.Size = New System.Drawing.Size(118, 16)
        Me.lbl_orders_description.TabIndex = 0
        Me.lbl_orders_description.Text = "Detalles y/o comentarios*"
        '
        'lbl_orders_email
        '
        Me.lbl_orders_email.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orders_email.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_orders_email.Appearance.Options.UseFont = True
        Me.lbl_orders_email.Appearance.Options.UseForeColor = True
        Me.lbl_orders_email.Location = New System.Drawing.Point(206, 241)
        Me.lbl_orders_email.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_orders_email.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_orders_email.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_orders_email.Name = "lbl_orders_email"
        Me.lbl_orders_email.Size = New System.Drawing.Size(29, 16)
        Me.lbl_orders_email.TabIndex = 0
        Me.lbl_orders_email.Text = "Email*"
        '
        'lbl_orders_purchase
        '
        Me.lbl_orders_purchase.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orders_purchase.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_orders_purchase.Appearance.Options.UseFont = True
        Me.lbl_orders_purchase.Appearance.Options.UseForeColor = True
        Me.lbl_orders_purchase.Location = New System.Drawing.Point(727, 177)
        Me.lbl_orders_purchase.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_orders_purchase.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_orders_purchase.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_orders_purchase.Name = "lbl_orders_purchase"
        Me.lbl_orders_purchase.Size = New System.Drawing.Size(87, 16)
        Me.lbl_orders_purchase.TabIndex = 0
        Me.lbl_orders_purchase.Text = "Orden de compra*"
        '
        'lbl_orders_payment
        '
        Me.lbl_orders_payment.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orders_payment.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_orders_payment.Appearance.Options.UseFont = True
        Me.lbl_orders_payment.Appearance.Options.UseForeColor = True
        Me.lbl_orders_payment.Location = New System.Drawing.Point(906, 177)
        Me.lbl_orders_payment.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_orders_payment.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_orders_payment.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_orders_payment.Name = "lbl_orders_payment"
        Me.lbl_orders_payment.Size = New System.Drawing.Size(77, 16)
        Me.lbl_orders_payment.TabIndex = 0
        Me.lbl_orders_payment.Text = "Forma de pago*"
        '
        'lbl_orders_neighborhood
        '
        Me.lbl_orders_neighborhood.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orders_neighborhood.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_orders_neighborhood.Appearance.Options.UseFont = True
        Me.lbl_orders_neighborhood.Appearance.Options.UseForeColor = True
        Me.lbl_orders_neighborhood.Location = New System.Drawing.Point(430, 177)
        Me.lbl_orders_neighborhood.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_orders_neighborhood.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_orders_neighborhood.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_orders_neighborhood.Name = "lbl_orders_neighborhood"
        Me.lbl_orders_neighborhood.Size = New System.Drawing.Size(33, 16)
        Me.lbl_orders_neighborhood.TabIndex = 0
        Me.lbl_orders_neighborhood.Text = "Barrio*"
        '
        'lbl_orders_address
        '
        Me.lbl_orders_address.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orders_address.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_orders_address.Appearance.Options.UseFont = True
        Me.lbl_orders_address.Appearance.Options.UseForeColor = True
        Me.lbl_orders_address.Location = New System.Drawing.Point(206, 177)
        Me.lbl_orders_address.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_orders_address.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_orders_address.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_orders_address.Name = "lbl_orders_address"
        Me.lbl_orders_address.Size = New System.Drawing.Size(92, 16)
        Me.lbl_orders_address.TabIndex = 0
        Me.lbl_orders_address.Text = "Dirección de envío*"
        '
        'lbl_orders_cities
        '
        Me.lbl_orders_cities.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orders_cities.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_orders_cities.Appearance.Options.UseFont = True
        Me.lbl_orders_cities.Appearance.Options.UseForeColor = True
        Me.lbl_orders_cities.Location = New System.Drawing.Point(385, 113)
        Me.lbl_orders_cities.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_orders_cities.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_orders_cities.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_orders_cities.Name = "lbl_orders_cities"
        Me.lbl_orders_cities.Size = New System.Drawing.Size(38, 16)
        Me.lbl_orders_cities.TabIndex = 0
        Me.lbl_orders_cities.Text = "Ciudad*"
        '
        'lbl_orders_person
        '
        Me.lbl_orders_person.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orders_person.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_orders_person.Appearance.Options.UseFont = True
        Me.lbl_orders_person.Appearance.Options.UseForeColor = True
        Me.lbl_orders_person.Location = New System.Drawing.Point(727, 49)
        Me.lbl_orders_person.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_orders_person.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_orders_person.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_orders_person.Name = "lbl_orders_person"
        Me.lbl_orders_person.Size = New System.Drawing.Size(223, 16)
        Me.lbl_orders_person.TabIndex = 0
        Me.lbl_orders_person.Text = "Seleccione el nombre del funcionario a asignar*"
        '
        'lbl_orders_deptos
        '
        Me.lbl_orders_deptos.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orders_deptos.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_orders_deptos.Appearance.Options.UseFont = True
        Me.lbl_orders_deptos.Appearance.Options.UseForeColor = True
        Me.lbl_orders_deptos.Location = New System.Drawing.Point(206, 113)
        Me.lbl_orders_deptos.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_orders_deptos.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_orders_deptos.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_orders_deptos.Name = "lbl_orders_deptos"
        Me.lbl_orders_deptos.Size = New System.Drawing.Size(70, 16)
        Me.lbl_orders_deptos.TabIndex = 0
        Me.lbl_orders_deptos.Text = "Departamento*"
        '
        'lbl_orders_agency
        '
        Me.lbl_orders_agency.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orders_agency.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_orders_agency.Appearance.Options.UseFont = True
        Me.lbl_orders_agency.Appearance.Options.UseForeColor = True
        Me.lbl_orders_agency.Location = New System.Drawing.Point(206, 305)
        Me.lbl_orders_agency.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_orders_agency.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_orders_agency.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_orders_agency.Name = "lbl_orders_agency"
        Me.lbl_orders_agency.Size = New System.Drawing.Size(171, 16)
        Me.lbl_orders_agency.TabIndex = 0
        Me.lbl_orders_agency.Text = "Seleccione el nombre de la agencia*"
        '
        'lbl_orders_newcustomer
        '
        Me.lbl_orders_newcustomer.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orders_newcustomer.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lbl_orders_newcustomer.Appearance.Options.UseFont = True
        Me.lbl_orders_newcustomer.Appearance.Options.UseForeColor = True
        Me.lbl_orders_newcustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_orders_newcustomer.Location = New System.Drawing.Point(396, 49)
        Me.lbl_orders_newcustomer.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_orders_newcustomer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_orders_newcustomer.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_orders_newcustomer.Name = "lbl_orders_newcustomer"
        Me.lbl_orders_newcustomer.Size = New System.Drawing.Size(63, 16)
        Me.lbl_orders_newcustomer.TabIndex = 0
        Me.lbl_orders_newcustomer.Text = "Crear Cliente"
        '
        'lbl_orders_customer
        '
        Me.lbl_orders_customer.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orders_customer.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_orders_customer.Appearance.Options.UseFont = True
        Me.lbl_orders_customer.Appearance.Options.UseForeColor = True
        Me.lbl_orders_customer.Location = New System.Drawing.Point(206, 49)
        Me.lbl_orders_customer.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_orders_customer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_orders_customer.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_orders_customer.Name = "lbl_orders_customer"
        Me.lbl_orders_customer.Size = New System.Drawing.Size(154, 16)
        Me.lbl_orders_customer.TabIndex = 0
        Me.lbl_orders_customer.Text = "Seleccione el nombre del cliente*"
        '
        'chk_keep_form
        '
        Me.chk_keep_form.Location = New System.Drawing.Point(957, 243)
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
        Me.chk_keep_form.TabIndex = 13
        '
        'chk_orders_type
        '
        Me.chk_orders_type.Location = New System.Drawing.Point(924, 222)
        Me.chk_orders_type.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_orders_type.Name = "chk_orders_type"
        Me.chk_orders_type.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.chk_orders_type.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.chk_orders_type.Properties.Appearance.BorderColor = System.Drawing.Color.White
        Me.chk_orders_type.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_orders_type.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.chk_orders_type.Properties.Appearance.Options.UseBackColor = True
        Me.chk_orders_type.Properties.Appearance.Options.UseBorderColor = True
        Me.chk_orders_type.Properties.Appearance.Options.UseFont = True
        Me.chk_orders_type.Properties.Appearance.Options.UseForeColor = True
        Me.chk_orders_type.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.chk_orders_type.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.chk_orders_type.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.White
        Me.chk_orders_type.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_orders_type.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.chk_orders_type.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.chk_orders_type.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.chk_orders_type.Properties.AppearanceDisabled.Options.UseFont = True
        Me.chk_orders_type.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.chk_orders_type.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.chk_orders_type.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.chk_orders_type.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.White
        Me.chk_orders_type.Properties.AppearanceFocused.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_orders_type.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.DimGray
        Me.chk_orders_type.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.chk_orders_type.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.chk_orders_type.Properties.AppearanceFocused.Options.UseFont = True
        Me.chk_orders_type.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.chk_orders_type.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.chk_orders_type.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.chk_orders_type.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White
        Me.chk_orders_type.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_orders_type.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.chk_orders_type.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.chk_orders_type.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.chk_orders_type.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.chk_orders_type.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.chk_orders_type.Properties.Caption = "La solicitud de pedido es remisionado?"
        Me.chk_orders_type.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chk_orders_type.Properties.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.chk_orders_type.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.chk_orders_type.Size = New System.Drawing.Size(204, 20)
        Me.chk_orders_type.TabIndex = 12
        Me.chk_orders_type.Tag = "Pedido Remisionado"
        '
        'pnl_object_container
        '
        Me.pnl_object_container.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_container.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_container.Appearance.BorderColor = System.Drawing.Color.White
        Me.pnl_object_container.Appearance.Options.UseBackColor = True
        Me.pnl_object_container.Appearance.Options.UseBorderColor = True
        Me.pnl_object_container.Controls.Add(Me.pnl_object_products)
        Me.pnl_object_container.Controls.Add(Me.pnl_object_resumen)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 76)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Size = New System.Drawing.Size(1348, 421)
        Me.pnl_object_container.TabIndex = 0
        '
        'pnl_object_products
        '
        Me.pnl_object_products.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_products.Controls.Add(Me.chk_keep_form)
        Me.pnl_object_products.Controls.Add(Me.chk_orders_type)
        Me.pnl_object_products.Controls.Add(Me.pnl_object_grid)
        Me.pnl_object_products.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_object_products.Location = New System.Drawing.Point(0, 390)
        Me.pnl_object_products.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_products.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_products.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_products.Name = "pnl_object_products"
        Me.pnl_object_products.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_products.Size = New System.Drawing.Size(1331, 295)
        Me.pnl_object_products.TabIndex = 0
        '
        'pnl_object_grid
        '
        Me.pnl_object_grid.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_grid.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_grid.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnl_object_grid.Appearance.Options.UseBackColor = True
        Me.pnl_object_grid.Appearance.Options.UseBorderColor = True
        Me.pnl_object_grid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.pnl_object_grid.Controls.Add(Me.dgv_object_grid)
        Me.pnl_object_grid.Controls.Add(Me.pnl_object_search)
        Me.pnl_object_grid.Controls.Add(Me.pnl_object_options)
        Me.pnl_object_grid.Location = New System.Drawing.Point(205, 5)
        Me.pnl_object_grid.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.pnl_object_grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_grid.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_grid.Name = "pnl_object_grid"
        Me.pnl_object_grid.Size = New System.Drawing.Size(922, 215)
        Me.pnl_object_grid.TabIndex = 0
        '
        'dgv_object_grid
        '
        Me.dgv_object_grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_object_grid.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.dgv_object_grid.Location = New System.Drawing.Point(2, 37)
        Me.dgv_object_grid.LookAndFeel.SkinName = "My Office 2019 White"
        Me.dgv_object_grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.dgv_object_grid.MainView = Me.dgv_object_view
        Me.dgv_object_grid.Margin = New System.Windows.Forms.Padding(0)
        Me.dgv_object_grid.Name = "dgv_object_grid"
        Me.dgv_object_grid.Size = New System.Drawing.Size(918, 146)
        Me.dgv_object_grid.TabIndex = 0
        Me.dgv_object_grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgv_object_view})
        '
        'dgv_object_view
        '
        Me.dgv_object_view.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_object_view.Appearance.HorzLine.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_object_view.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_object_view.Appearance.HorzLine.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.HorzLine.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.Row.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_object_view.Appearance.Row.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.Row.Options.UseBorderColor = True
        Me.dgv_object_view.Appearance.VertLine.BackColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.VertLine.BackColor2 = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.VertLine.BorderColor = System.Drawing.Color.White
        Me.dgv_object_view.Appearance.VertLine.Options.UseBackColor = True
        Me.dgv_object_view.Appearance.VertLine.Options.UseBorderColor = True
        Me.dgv_object_view.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.dgv_object_view.ColumnPanelRowHeight = 45
        Me.dgv_object_view.GridControl = Me.dgv_object_grid
        Me.dgv_object_view.Name = "dgv_object_view"
        Me.dgv_object_view.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.dgv_object_view.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.dgv_object_view.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.dgv_object_view.OptionsView.ShowGroupPanel = False
        Me.dgv_object_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.dgv_object_view.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgv_object_view.PaintStyleName = "Skin"
        Me.dgv_object_view.RowHeight = 30
        '
        'pnl_object_search
        '
        Me.pnl_object_search.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_search.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_search.Appearance.BorderColor = System.Drawing.Color.White
        Me.pnl_object_search.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.pnl_object_search.Appearance.Options.UseBackColor = True
        Me.pnl_object_search.Appearance.Options.UseBorderColor = True
        Me.pnl_object_search.Appearance.Options.UseForeColor = True
        Me.pnl_object_search.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_search.Controls.Add(Me.txt_object_search)
        Me.pnl_object_search.Controls.Add(Me.lbl_separator2)
        Me.pnl_object_search.Controls.Add(Me.txt_object_navigate)
        Me.pnl_object_search.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_object_search.Location = New System.Drawing.Point(2, 2)
        Me.pnl_object_search.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_search.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_search.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_search.Name = "pnl_object_search"
        Me.pnl_object_search.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_search.Size = New System.Drawing.Size(918, 35)
        Me.pnl_object_search.TabIndex = 0
        '
        'txt_object_search
        '
        Me.txt_object_search.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_object_search.Location = New System.Drawing.Point(1, 1)
        Me.txt_object_search.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_object_search.Name = "txt_object_search"
        Me.txt_object_search.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_object_search.Properties.Appearance.BorderColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_object_search.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.txt_object_search.Properties.Appearance.Options.UseBackColor = True
        Me.txt_object_search.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_object_search.Properties.Appearance.Options.UseFont = True
        Me.txt_object_search.Properties.Appearance.Options.UseForeColor = True
        Me.txt_object_search.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_object_search.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_object_search.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.txt_object_search.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.txt_object_search.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_object_search.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_object_search.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White
        Me.txt_object_search.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_object_search.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_object_search.Properties.AutoHeight = False
        Me.txt_object_search.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txt_object_search.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, True, True, True, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txt_object_search.Properties.FilterCondition = DevExpress.Data.Filtering.FilterCondition.Contains
        Me.txt_object_search.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_object_search.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_object_search.Properties.ShowClearButton = False
        Me.txt_object_search.Properties.ShowSearchButton = False
        Me.txt_object_search.Size = New System.Drawing.Size(626, 33)
        Me.txt_object_search.TabIndex = 0
        '
        'lbl_separator2
        '
        Me.lbl_separator2.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_separator2.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.lbl_separator2.LineColor = System.Drawing.Color.Silver
        Me.lbl_separator2.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.lbl_separator2.Location = New System.Drawing.Point(627, 1)
        Me.lbl_separator2.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_separator2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_separator2.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_separator2.Name = "lbl_separator2"
        Me.lbl_separator2.Padding = New System.Windows.Forms.Padding(0, 8, 0, 8)
        Me.lbl_separator2.Size = New System.Drawing.Size(7, 33)
        Me.lbl_separator2.TabIndex = 0
        '
        'txt_object_navigate
        '
        Me.txt_object_navigate.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_object_navigate.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_object_navigate.Appearance.BorderColor = System.Drawing.Color.White
        Me.txt_object_navigate.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_object_navigate.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.txt_object_navigate.Appearance.Options.UseBackColor = True
        Me.txt_object_navigate.Appearance.Options.UseBorderColor = True
        Me.txt_object_navigate.Appearance.Options.UseFont = True
        Me.txt_object_navigate.Appearance.Options.UseForeColor = True
        Me.txt_object_navigate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txt_object_navigate.Buttons.Edit.Visible = False
        Me.txt_object_navigate.Buttons.First.Visible = False
        Me.txt_object_navigate.Buttons.Last.Enabled = False
        Me.txt_object_navigate.Buttons.Last.Visible = False
        Me.txt_object_navigate.Buttons.NextPage.Enabled = False
        Me.txt_object_navigate.Buttons.NextPage.Visible = False
        Me.txt_object_navigate.Buttons.PrevPage.Enabled = False
        Me.txt_object_navigate.Buttons.PrevPage.Visible = False
        Me.txt_object_navigate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txt_object_navigate.Dock = System.Windows.Forms.DockStyle.Right
        Me.txt_object_navigate.Location = New System.Drawing.Point(634, 1)
        Me.txt_object_navigate.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_object_navigate.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_object_navigate.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_object_navigate.MaximumSize = New System.Drawing.Size(300, 30)
        Me.txt_object_navigate.MinimumSize = New System.Drawing.Size(90, 33)
        Me.txt_object_navigate.Name = "txt_object_navigate"
        Me.txt_object_navigate.NavigatableControl = Me.dgv_object_grid
        Me.txt_object_navigate.Padding = New System.Windows.Forms.Padding(1)
        Me.txt_object_navigate.ShowToolTips = True
        Me.txt_object_navigate.Size = New System.Drawing.Size(283, 33)
        Me.txt_object_navigate.TabIndex = 0
        Me.txt_object_navigate.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin
        '
        'pnl_object_options
        '
        Me.pnl_object_options.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_options.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_options.Appearance.BorderColor = System.Drawing.Color.White
        Me.pnl_object_options.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_object_options.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.pnl_object_options.Appearance.Options.UseBackColor = True
        Me.pnl_object_options.Appearance.Options.UseBorderColor = True
        Me.pnl_object_options.Appearance.Options.UseFont = True
        Me.pnl_object_options.Appearance.Options.UseForeColor = True
        Me.pnl_object_options.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_options.Controls.Add(Me.btn_object_update)
        Me.pnl_object_options.Controls.Add(Me.lbl_separator1)
        Me.pnl_object_options.Controls.Add(Me.lbl_object_count)
        Me.pnl_object_options.Controls.Add(Me.lbl_object_total)
        Me.pnl_object_options.Controls.Add(Me.btn_object_export)
        Me.pnl_object_options.Controls.Add(Me.btn_object_panel)
        Me.pnl_object_options.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_object_options.Location = New System.Drawing.Point(2, 183)
        Me.pnl_object_options.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_options.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_options.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_options.Name = "pnl_object_options"
        Me.pnl_object_options.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_options.Size = New System.Drawing.Size(918, 30)
        Me.pnl_object_options.TabIndex = 0
        '
        'btn_object_update
        '
        Me.btn_object_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_update.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_object_update.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_update.FlatAppearance.BorderSize = 0
        Me.btn_object_update.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_object_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_update.Image = CType(resources.GetObject("btn_object_update.Image"), System.Drawing.Image)
        Me.btn_object_update.Location = New System.Drawing.Point(820, 1)
        Me.btn_object_update.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_update.MaximumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_update.MinimumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_update.Name = "btn_object_update"
        Me.btn_object_update.Size = New System.Drawing.Size(30, 28)
        Me.btn_object_update.TabIndex = 0
        Me.btn_object_update.TabStop = False
        Me.btn_object_update.Tag = "Actualizar"
        Me.btn_object_update.UseVisualStyleBackColor = True
        '
        'lbl_separator1
        '
        Me.lbl_separator1.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_separator1.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.lbl_separator1.LineColor = System.Drawing.Color.Silver
        Me.lbl_separator1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.lbl_separator1.Location = New System.Drawing.Point(850, 1)
        Me.lbl_separator1.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_separator1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_separator1.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_separator1.Name = "lbl_separator1"
        Me.lbl_separator1.Padding = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.lbl_separator1.Size = New System.Drawing.Size(7, 28)
        Me.lbl_separator1.TabIndex = 0
        '
        'lbl_object_count
        '
        Me.lbl_object_count.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.75!)
        Me.lbl_object_count.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lbl_object_count.Appearance.Options.UseFont = True
        Me.lbl_object_count.Appearance.Options.UseForeColor = True
        Me.lbl_object_count.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.lbl_object_count.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_object_count.Location = New System.Drawing.Point(69, 1)
        Me.lbl_object_count.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_count.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_count.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_count.Name = "lbl_object_count"
        Me.lbl_object_count.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.lbl_object_count.Size = New System.Drawing.Size(16, 26)
        Me.lbl_object_count.TabIndex = 0
        Me.lbl_object_count.Text = "$0"
        '
        'lbl_object_total
        '
        Me.lbl_object_total.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_object_total.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_total.Appearance.Options.UseFont = True
        Me.lbl_object_total.Appearance.Options.UseForeColor = True
        Me.lbl_object_total.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_object_total.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_object_total.Location = New System.Drawing.Point(1, 1)
        Me.lbl_object_total.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_total.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_total.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_total.Name = "lbl_object_total"
        Me.lbl_object_total.Size = New System.Drawing.Size(68, 28)
        Me.lbl_object_total.TabIndex = 0
        Me.lbl_object_total.Text = "Total Pedido: "
        '
        'btn_object_export
        '
        Me.btn_object_export.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_export.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_object_export.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_export.FlatAppearance.BorderSize = 0
        Me.btn_object_export.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_object_export.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_export.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btn_object_export.Image = CType(resources.GetObject("btn_object_export.Image"), System.Drawing.Image)
        Me.btn_object_export.Location = New System.Drawing.Point(857, 1)
        Me.btn_object_export.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_object_export.MaximumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_export.MinimumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_export.Name = "btn_object_export"
        Me.btn_object_export.Size = New System.Drawing.Size(30, 28)
        Me.btn_object_export.TabIndex = 0
        Me.btn_object_export.TabStop = False
        Me.btn_object_export.Tag = "Exportar"
        Me.btn_object_export.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_object_export.UseVisualStyleBackColor = True
        '
        'btn_object_panel
        '
        Me.btn_object_panel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_object_panel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_panel.FlatAppearance.BorderSize = 0
        Me.btn_object_panel.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_object_panel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_panel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_panel.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btn_object_panel.Image = CType(resources.GetObject("btn_object_panel.Image"), System.Drawing.Image)
        Me.btn_object_panel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_object_panel.Location = New System.Drawing.Point(887, 1)
        Me.btn_object_panel.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_object_panel.MaximumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_panel.MinimumSize = New System.Drawing.Size(30, 28)
        Me.btn_object_panel.Name = "btn_object_panel"
        Me.btn_object_panel.Size = New System.Drawing.Size(30, 28)
        Me.btn_object_panel.TabIndex = 0
        Me.btn_object_panel.TabStop = False
        Me.btn_object_panel.Tag = "Modo Flex"
        Me.btn_object_panel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_object_panel.UseVisualStyleBackColor = True
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
        'wholesales_orders_created
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
        Me.Name = "wholesales_orders_created"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(1350, 550)
        Me.Tag = "Crear Pedido"
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_top.ResumeLayout(False)
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_orders_person.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_sales_sellers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_orders_agency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_orders_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_sales_customers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_orders_cities.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_orders_deptos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_orders_neighborhood.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_orders_address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_orders_purcharse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_orders_email.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_orders_payment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_orders_platform.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_orders_description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_bottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_bottom.ResumeLayout(False)
        CType(Me.pnl_object_resumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_resumen.ResumeLayout(False)
        Me.pnl_object_resumen.PerformLayout()
        CType(Me.chk_keep_form.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_orders_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        CType(Me.pnl_object_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_products.ResumeLayout(False)
        CType(Me.pnl_object_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_grid.ResumeLayout(False)
        CType(Me.dgv_object_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_object_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_search.ResumeLayout(False)
        CType(Me.txt_object_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_separator2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_options, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_options.ResumeLayout(False)
        Me.pnl_object_options.PerformLayout()
        CType(Me.lbl_separator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_object_top As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_object_info As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_refresh As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_cancel As Button
    Friend WithEvents xvp_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents pnl_object_bottom As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_object_accept As Button
    Friend WithEvents pnl_object_resumen As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmb_orders_person As APDA.Object.Controls.ComboboxSearch
    Friend WithEvents dgv_sales_sellers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbl_orders_person As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_orders_agency As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_orders_agency As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_orders_newcustomer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_orders_customer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_orders_customer As APDA.Object.Controls.ComboboxSearch
    Friend WithEvents dgv_sales_customers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbl_orders_cities As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_orders_cities As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents cmb_orders_deptos As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_orders_deptos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_orders_neighborhood As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_orders_neighborhood As APDA.Object.Controls.TextboxEdit
    Friend WithEvents txt_orders_address As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_orders_address As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_orders_purchase As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_orders_purcharse As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_orders_payment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_orders_email As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_orders_email As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_object_caracters As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_orders_description As DevExpress.XtraEditors.LabelControl
    Protected WithEvents chk_keep_form As DevExpress.XtraEditors.CheckEdit
    Protected WithEvents chk_orders_type As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents pnl_object_products As DevExpress.XtraEditors.PanelControl
    Protected WithEvents pnl_object_grid As DevExpress.XtraEditors.PanelControl
    Protected WithEvents pnl_object_search As DevExpress.XtraEditors.PanelControl
    Protected WithEvents txt_object_search As DevExpress.XtraEditors.SearchControl
    Protected WithEvents pnl_object_options As DevExpress.XtraEditors.PanelControl
    Protected WithEvents btn_object_update As Button
    Friend WithEvents lbl_separator1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents lbl_object_count As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_total As DevExpress.XtraEditors.LabelControl
    Protected WithEvents txt_object_navigate As DevExpress.XtraEditors.ControlNavigator
    Protected WithEvents btn_object_export As Button
    Protected WithEvents btn_object_panel As Button
    Friend WithEvents cmb_orders_payment As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents dgv_object_grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgv_object_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbl_orders_platform As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_orders_platform As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_separator2 As DevExpress.XtraEditors.SeparatorControl
    Private WithEvents txt_orders_description As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents xvp_spell As DevExpress.XtraSpellChecker.SpellChecker
End Class
