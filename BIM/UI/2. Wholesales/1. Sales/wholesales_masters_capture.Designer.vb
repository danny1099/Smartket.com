<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wholesales_masters_capture
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wholesales_masters_capture))
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.btn_object_capture = New System.Windows.Forms.Label()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.btn_object_capture)
        Me.pnl_object_container.Controls.Add(Me.btn_object_cancel)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 1)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_container.Size = New System.Drawing.Size(311, 67)
        Me.pnl_object_container.TabIndex = 0
        '
        'btn_object_capture
        '
        Me.btn_object_capture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_capture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_object_capture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_capture.Font = New System.Drawing.Font("Open Sans Condensed Light", 15.75!)
        Me.btn_object_capture.Image = CType(resources.GetObject("btn_object_capture.Image"), System.Drawing.Image)
        Me.btn_object_capture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_object_capture.Location = New System.Drawing.Point(1, 1)
        Me.btn_object_capture.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_capture.Name = "btn_object_capture"
        Me.btn_object_capture.Size = New System.Drawing.Size(279, 65)
        Me.btn_object_capture.TabIndex = 0
        Me.btn_object_capture.Text = "           Captura de venta"
        Me.btn_object_capture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btn_object_cancel.Location = New System.Drawing.Point(280, 1)
        Me.btn_object_cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_cancel.Name = "btn_object_cancel"
        Me.btn_object_cancel.Size = New System.Drawing.Size(30, 65)
        Me.btn_object_cancel.TabIndex = 0
        Me.btn_object_cancel.TabStop = False
        Me.btn_object_cancel.Text = "X"
        Me.btn_object_cancel.UseVisualStyleBackColor = False
        '
        'wholesales_masters_capture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(313, 69)
        Me.Controls.Add(Me.pnl_object_container)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(5, 5)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "wholesales_masters_capture"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Tag = "Captura"
        Me.Text = "Captura"
        Me.TopMost = True
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_object_cancel As Button
    Friend WithEvents btn_object_capture As Label
End Class
