<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comercial_chances_edited
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(comercial_chances_edited))
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.cmb_chance_operator = New APDA.[Object].Controls.ComboboxEdit()
        Me.txt_chance_name = New APDA.[Object].Controls.TextboxEdit()
        Me.cmb_chance_segment = New APDA.[Object].Controls.ComboboxEdit()
        Me.pnl_object_top = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_refresh = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.pnl_object_bottom = New DevExpress.XtraEditors.PanelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.chk_row_visible = New DevExpress.XtraEditors.CheckEdit()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.chk_object_global = New DevExpress.XtraEditors.CheckEdit()
        Me.lbl_rules_condition = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_chance_segment = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_chance_operator = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_chance_name = New DevExpress.XtraEditors.LabelControl()
        Me.txt_chance_criteria = New APDA.[Object].Controls.TextboxFilter()
        Me.lbl_chance_agency = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_chance_agency = New APDA.[Object].Controls.ComboboxCheck()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_chance_operator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_chance_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_chance_segment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_top.SuspendLayout()
        CType(Me.pnl_object_bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_bottom.SuspendLayout()
        CType(Me.chk_row_visible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        CType(Me.chk_object_global.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_chance_agency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xvp_validate
        '
        Me.xvp_validate.ValidateHiddenControls = False
        Me.xvp_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'cmb_chance_operator
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_chance_operator, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_chance_operator.Location = New System.Drawing.Point(233, 230)
        Me.cmb_chance_operator.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_chance_operator.Name = "cmb_chance_operator"
        Me.cmb_chance_operator.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_chance_operator.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_chance_operator.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_chance_operator.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_chance_operator.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_chance_operator.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_chance_operator.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_chance_operator.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_chance_operator.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_chance_operator.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_chance_operator.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_chance_operator.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_chance_operator.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_chance_operator.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_chance_operator.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_chance_operator.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_chance_operator.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_chance_operator.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_chance_operator.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_chance_operator.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_chance_operator.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_chance_operator.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_chance_operator.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_chance_operator.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_chance_operator.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_chance_operator.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_chance_operator.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_chance_operator.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_chance_operator.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_chance_operator.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_chance_operator.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_chance_operator.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_chance_operator.Properties.AutoHeight = False
        Me.cmb_chance_operator.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_chance_operator.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_chance_operator.Properties.DropDownItemHeight = 30
        Me.cmb_chance_operator.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_chance_operator.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_chance_operator.Properties.NullText = ""
        Me.cmb_chance_operator.Properties.ShowFooter = False
        Me.cmb_chance_operator.Properties.ShowHeader = False
        Me.cmb_chance_operator.Size = New System.Drawing.Size(400, 30)
        Me.cmb_chance_operator.TabIndex = 3
        Me.cmb_chance_operator.Tag = "Operador"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_chance_operator, ConditionValidationRule1)
        '
        'txt_chance_name
        '
        Me.txt_chance_name.EditValue = ""
        Me.xvp_validate.SetIconAlignment(Me.txt_chance_name, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_chance_name.Location = New System.Drawing.Point(233, 92)
        Me.txt_chance_name.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_chance_name.Name = "txt_chance_name"
        Me.txt_chance_name.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_chance_name.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_chance_name.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_chance_name.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_chance_name.Properties.Appearance.Options.UseBackColor = True
        Me.txt_chance_name.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_chance_name.Properties.Appearance.Options.UseForeColor = True
        Me.txt_chance_name.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_chance_name.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_chance_name.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_chance_name.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_chance_name.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_chance_name.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_chance_name.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_chance_name.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_chance_name.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_chance_name.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_chance_name.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_chance_name.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_chance_name.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_chance_name.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_chance_name.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_chance_name.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_chance_name.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_chance_name.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_chance_name.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_chance_name.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_chance_name.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_chance_name.Properties.AutoHeight = False
        Me.txt_chance_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_chance_name.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_chance_name.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_chance_name.Properties.Mask.BeepOnError = True
        Me.txt_chance_name.Properties.Mask.EditMask = "\d+"
        Me.txt_chance_name.Properties.MaxLength = 100
        Me.txt_chance_name.Size = New System.Drawing.Size(400, 30)
        Me.txt_chance_name.TabIndex = 1
        Me.txt_chance_name.Tag = "Nombre de oportunidad"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.txt_chance_name, ConditionValidationRule2)
        '
        'cmb_chance_segment
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_chance_segment, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_chance_segment.Location = New System.Drawing.Point(233, 160)
        Me.cmb_chance_segment.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_chance_segment.Name = "cmb_chance_segment"
        Me.cmb_chance_segment.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_chance_segment.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_chance_segment.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_chance_segment.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_chance_segment.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_chance_segment.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_chance_segment.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_chance_segment.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_chance_segment.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_chance_segment.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_chance_segment.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_chance_segment.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_chance_segment.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_chance_segment.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_chance_segment.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_chance_segment.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_chance_segment.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_chance_segment.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_chance_segment.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_chance_segment.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_chance_segment.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_chance_segment.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_chance_segment.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_chance_segment.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_chance_segment.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_chance_segment.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_chance_segment.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_chance_segment.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_chance_segment.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_chance_segment.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_chance_segment.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_chance_segment.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_chance_segment.Properties.AutoHeight = False
        Me.cmb_chance_segment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_chance_segment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_chance_segment.Properties.DropDownItemHeight = 30
        Me.cmb_chance_segment.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_chance_segment.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_chance_segment.Properties.NullText = ""
        Me.cmb_chance_segment.Properties.ShowFooter = False
        Me.cmb_chance_segment.Properties.ShowHeader = False
        Me.cmb_chance_segment.Size = New System.Drawing.Size(400, 30)
        Me.cmb_chance_segment.TabIndex = 2
        Me.cmb_chance_segment.Tag = "Segmento"
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_chance_segment, ConditionValidationRule3)
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
        Me.lbl_object_title.Text = "Editar Oportunidad"
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
        Me.chk_row_visible.Location = New System.Drawing.Point(999, 353)
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
        Me.chk_row_visible.Size = New System.Drawing.Size(209, 20)
        Me.chk_row_visible.TabIndex = 0
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.lbl_chance_agency)
        Me.pnl_object_container.Controls.Add(Me.cmb_chance_agency)
        Me.pnl_object_container.Controls.Add(Me.chk_object_global)
        Me.pnl_object_container.Controls.Add(Me.chk_row_visible)
        Me.pnl_object_container.Controls.Add(Me.cmb_chance_operator)
        Me.pnl_object_container.Controls.Add(Me.lbl_rules_condition)
        Me.pnl_object_container.Controls.Add(Me.txt_chance_name)
        Me.pnl_object_container.Controls.Add(Me.lbl_chance_segment)
        Me.pnl_object_container.Controls.Add(Me.lbl_chance_operator)
        Me.pnl_object_container.Controls.Add(Me.lbl_chance_name)
        Me.pnl_object_container.Controls.Add(Me.cmb_chance_segment)
        Me.pnl_object_container.Controls.Add(Me.txt_chance_criteria)
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
        'chk_object_global
        '
        Me.chk_object_global.Location = New System.Drawing.Point(967, 332)
        Me.chk_object_global.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_object_global.Name = "chk_object_global"
        Me.chk_object_global.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.chk_object_global.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.chk_object_global.Properties.Appearance.BorderColor = System.Drawing.Color.White
        Me.chk_object_global.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_object_global.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.chk_object_global.Properties.Appearance.Options.UseBackColor = True
        Me.chk_object_global.Properties.Appearance.Options.UseBorderColor = True
        Me.chk_object_global.Properties.Appearance.Options.UseFont = True
        Me.chk_object_global.Properties.Appearance.Options.UseForeColor = True
        Me.chk_object_global.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.chk_object_global.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.chk_object_global.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.White
        Me.chk_object_global.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_object_global.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.chk_object_global.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.chk_object_global.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.chk_object_global.Properties.AppearanceDisabled.Options.UseFont = True
        Me.chk_object_global.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.chk_object_global.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.chk_object_global.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.chk_object_global.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.White
        Me.chk_object_global.Properties.AppearanceFocused.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_object_global.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.DimGray
        Me.chk_object_global.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.chk_object_global.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.chk_object_global.Properties.AppearanceFocused.Options.UseFont = True
        Me.chk_object_global.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.chk_object_global.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.chk_object_global.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.chk_object_global.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White
        Me.chk_object_global.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_object_global.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.chk_object_global.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.chk_object_global.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.chk_object_global.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.chk_object_global.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.chk_object_global.Properties.Caption = "Desea marcar la condición como regla global?"
        Me.chk_object_global.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chk_object_global.Properties.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.chk_object_global.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.chk_object_global.Size = New System.Drawing.Size(241, 20)
        Me.chk_object_global.TabIndex = 6
        '
        'lbl_rules_condition
        '
        Me.lbl_rules_condition.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rules_condition.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_rules_condition.Appearance.Options.UseFont = True
        Me.lbl_rules_condition.Appearance.Options.UseForeColor = True
        Me.lbl_rules_condition.Location = New System.Drawing.Point(745, 72)
        Me.lbl_rules_condition.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_rules_condition.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_rules_condition.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_rules_condition.Name = "lbl_rules_condition"
        Me.lbl_rules_condition.Size = New System.Drawing.Size(250, 16)
        Me.lbl_rules_condition.TabIndex = 0
        Me.lbl_rules_condition.Text = "Defina las condiciones y/o criterios de la oportunidad*"
        '
        'lbl_chance_segment
        '
        Me.lbl_chance_segment.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_chance_segment.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_chance_segment.Appearance.Options.UseFont = True
        Me.lbl_chance_segment.Appearance.Options.UseForeColor = True
        Me.lbl_chance_segment.Location = New System.Drawing.Point(233, 140)
        Me.lbl_chance_segment.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_chance_segment.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_chance_segment.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_chance_segment.Name = "lbl_chance_segment"
        Me.lbl_chance_segment.Size = New System.Drawing.Size(51, 16)
        Me.lbl_chance_segment.TabIndex = 0
        Me.lbl_chance_segment.Text = "Segmento*"
        '
        'lbl_chance_operator
        '
        Me.lbl_chance_operator.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_chance_operator.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_chance_operator.Appearance.Options.UseFont = True
        Me.lbl_chance_operator.Appearance.Options.UseForeColor = True
        Me.lbl_chance_operator.Location = New System.Drawing.Point(233, 210)
        Me.lbl_chance_operator.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_chance_operator.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_chance_operator.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_chance_operator.Name = "lbl_chance_operator"
        Me.lbl_chance_operator.Size = New System.Drawing.Size(50, 16)
        Me.lbl_chance_operator.TabIndex = 0
        Me.lbl_chance_operator.Text = "Operador*"
        '
        'lbl_chance_name
        '
        Me.lbl_chance_name.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_chance_name.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_chance_name.Appearance.Options.UseFont = True
        Me.lbl_chance_name.Appearance.Options.UseForeColor = True
        Me.lbl_chance_name.Location = New System.Drawing.Point(233, 72)
        Me.lbl_chance_name.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_chance_name.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_chance_name.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_chance_name.Name = "lbl_chance_name"
        Me.lbl_chance_name.Size = New System.Drawing.Size(157, 16)
        Me.lbl_chance_name.TabIndex = 0
        Me.lbl_chance_name.Text = "Defina el nombre de la condición*"
        '
        'txt_chance_criteria
        '
        Me.txt_chance_criteria.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_chance_criteria.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_chance_criteria.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_chance_criteria.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.txt_chance_criteria.Appearance.Options.UseBackColor = True
        Me.txt_chance_criteria.Appearance.Options.UseBorderColor = True
        Me.txt_chance_criteria.Appearance.Options.UseForeColor = True
        Me.txt_chance_criteria.AppearanceTreeLine.BackColor = System.Drawing.Color.LightSeaGreen
        Me.txt_chance_criteria.AppearanceTreeLine.BackColor2 = System.Drawing.Color.LightSeaGreen
        Me.txt_chance_criteria.AppearanceTreeLine.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.txt_chance_criteria.AppearanceTreeLine.Options.UseBackColor = True
        Me.txt_chance_criteria.AppearanceTreeLine.Options.UseBorderColor = True
        Me.txt_chance_criteria.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_chance_criteria.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_chance_criteria.Location = New System.Drawing.Point(745, 92)
        Me.txt_chance_criteria.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_chance_criteria.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_chance_criteria.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_chance_criteria.Name = "txt_chance_criteria"
        Me.txt_chance_criteria.Padding = New System.Windows.Forms.Padding(1)
        Me.txt_chance_criteria.ShowOperandTypeIcon = True
        Me.txt_chance_criteria.Size = New System.Drawing.Size(460, 237)
        Me.txt_chance_criteria.TabIndex = 5
        Me.txt_chance_criteria.Tag = "Condición"
        '
        'lbl_chance_agency
        '
        Me.lbl_chance_agency.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_chance_agency.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_chance_agency.Appearance.Options.UseFont = True
        Me.lbl_chance_agency.Appearance.Options.UseForeColor = True
        Me.lbl_chance_agency.Location = New System.Drawing.Point(233, 279)
        Me.lbl_chance_agency.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_chance_agency.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_chance_agency.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_chance_agency.Name = "lbl_chance_agency"
        Me.lbl_chance_agency.Size = New System.Drawing.Size(171, 16)
        Me.lbl_chance_agency.TabIndex = 8
        Me.lbl_chance_agency.Text = "Seleccione el nombre de la agencia*"
        '
        'cmb_chance_agency
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_chance_agency, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_chance_agency.Location = New System.Drawing.Point(233, 299)
        Me.cmb_chance_agency.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_chance_agency.Name = "cmb_chance_agency"
        Me.cmb_chance_agency.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_chance_agency.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_chance_agency.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_chance_agency.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_chance_agency.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_chance_agency.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_chance_agency.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_chance_agency.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_chance_agency.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_chance_agency.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_chance_agency.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmb_chance_agency.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_chance_agency.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_chance_agency.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmb_chance_agency.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_chance_agency.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_chance_agency.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_chance_agency.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.cmb_chance_agency.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_chance_agency.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_chance_agency.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.cmb_chance_agency.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_chance_agency.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_chance_agency.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_chance_agency.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.cmb_chance_agency.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_chance_agency.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_chance_agency.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmb_chance_agency.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_chance_agency.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_chance_agency.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_chance_agency.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.cmb_chance_agency.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_chance_agency.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_chance_agency.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.cmb_chance_agency.Properties.AutoHeight = False
        Me.cmb_chance_agency.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_chance_agency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_chance_agency.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_chance_agency.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_chance_agency.Size = New System.Drawing.Size(400, 30)
        Me.cmb_chance_agency.TabIndex = 4
        Me.cmb_chance_agency.Tag = "Agencia"
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_chance_agency, ConditionValidationRule4)
        '
        'comercial_chances_edited
        '
        Me.AccessibleName = "RCH003E"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnl_object_container)
        Me.Controls.Add(Me.pnl_object_bottom)
        Me.Controls.Add(Me.pnl_object_top)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "comercial_chances_edited"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(1350, 550)
        Me.Tag = "Editar Oportunidad"
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_chance_operator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_chance_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_chance_segment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_top, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_top.ResumeLayout(False)
        CType(Me.pnl_object_bottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_bottom.ResumeLayout(False)
        CType(Me.chk_row_visible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        CType(Me.chk_object_global.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_chance_agency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Protected WithEvents chk_row_visible As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmb_chance_operator As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_rules_condition As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_chance_name As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_chance_segment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_chance_operator As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_chance_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_chance_segment As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents txt_chance_criteria As APDA.Object.Controls.TextboxFilter
    Protected WithEvents chk_object_global As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lbl_chance_agency As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_chance_agency As APDA.Object.Controls.ComboboxCheck
End Class
