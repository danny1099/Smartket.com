<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class financial_masters_pagare
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(financial_masters_pagare))
        Me.btn_object_pagare = New System.Windows.Forms.Button()
        Me.txt_object_file = New DevExpress.XtraRichEdit.RichEditControl()
        Me.btn_object_instruccion = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_object_printer = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_object_pagare
        '
        Me.btn_object_pagare.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_pagare.FlatAppearance.BorderSize = 0
        Me.btn_object_pagare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_pagare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_pagare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_pagare.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_object_pagare.ForeColor = System.Drawing.Color.DimGray
        Me.btn_object_pagare.Image = CType(resources.GetObject("btn_object_pagare.Image"), System.Drawing.Image)
        Me.btn_object_pagare.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_object_pagare.Location = New System.Drawing.Point(1, 140)
        Me.btn_object_pagare.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_pagare.MaximumSize = New System.Drawing.Size(50, 50)
        Me.btn_object_pagare.MinimumSize = New System.Drawing.Size(50, 50)
        Me.btn_object_pagare.Name = "btn_object_pagare"
        Me.btn_object_pagare.Size = New System.Drawing.Size(50, 50)
        Me.btn_object_pagare.TabIndex = 0
        Me.btn_object_pagare.Text = "Pagaré"
        Me.btn_object_pagare.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_object_pagare.UseVisualStyleBackColor = True
        '
        'txt_object_file
        '
        Me.txt_object_file.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txt_object_file.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_object_file.Location = New System.Drawing.Point(0, 0)
        Me.txt_object_file.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_object_file.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_object_file.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_object_file.Name = "txt_object_file"
        Me.txt_object_file.ReadOnly = True
        Me.txt_object_file.Size = New System.Drawing.Size(814, 535)
        Me.txt_object_file.TabIndex = 0
        '
        'btn_object_instruccion
        '
        Me.btn_object_instruccion.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_instruccion.FlatAppearance.BorderSize = 0
        Me.btn_object_instruccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_instruccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_instruccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_instruccion.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_object_instruccion.ForeColor = System.Drawing.Color.DimGray
        Me.btn_object_instruccion.Image = CType(resources.GetObject("btn_object_instruccion.Image"), System.Drawing.Image)
        Me.btn_object_instruccion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_object_instruccion.Location = New System.Drawing.Point(1, 200)
        Me.btn_object_instruccion.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.btn_object_instruccion.MaximumSize = New System.Drawing.Size(50, 50)
        Me.btn_object_instruccion.MinimumSize = New System.Drawing.Size(50, 50)
        Me.btn_object_instruccion.Name = "btn_object_instruccion"
        Me.btn_object_instruccion.Size = New System.Drawing.Size(50, 50)
        Me.btn_object_instruccion.TabIndex = 0
        Me.btn_object_instruccion.Text = "Carta"
        Me.btn_object_instruccion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_object_instruccion.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_object_pagare)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_object_instruccion)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_object_printer)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(814, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(1, 140, 1, 1)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(55, 535)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btn_object_printer
        '
        Me.btn_object_printer.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_printer.FlatAppearance.BorderSize = 0
        Me.btn_object_printer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_printer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_printer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_printer.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_object_printer.ForeColor = System.Drawing.Color.DimGray
        Me.btn_object_printer.Image = CType(resources.GetObject("btn_object_printer.Image"), System.Drawing.Image)
        Me.btn_object_printer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_object_printer.Location = New System.Drawing.Point(1, 260)
        Me.btn_object_printer.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.btn_object_printer.MaximumSize = New System.Drawing.Size(50, 50)
        Me.btn_object_printer.MinimumSize = New System.Drawing.Size(50, 50)
        Me.btn_object_printer.Name = "btn_object_printer"
        Me.btn_object_printer.Size = New System.Drawing.Size(50, 50)
        Me.btn_object_printer.TabIndex = 0
        Me.btn_object_printer.Text = "Imprimir"
        Me.btn_object_printer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_object_printer.UseVisualStyleBackColor = True
        '
        'financial_masters_pagare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 535)
        Me.Controls.Add(Me.txt_object_file)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.IconOptions.Image = Global.BIM.My.Resources.Resources.bim
        Me.LookAndFeel.SkinName = "Office 2019 White"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "financial_masters_pagare"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Firma de documentos"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_object_file As DevExpress.XtraRichEdit.RichEditControl
    Friend WithEvents btn_object_pagare As Button
    Friend WithEvents btn_object_instruccion As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btn_object_printer As Button
End Class
