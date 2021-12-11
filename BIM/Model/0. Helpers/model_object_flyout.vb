Imports DevExpress.XtraBars.Docking2010.Customization

Public Class model_object_flyout
    Inherits FlyoutDialog

    Public Sub New(owner As Form, control As Control)
        MyBase.New(owner, control, sessions.flyout_props)
        InitStyle()
    End Sub

    Protected Overrides Sub InitStyle()
        MyBase.ShowIcon = False
        MyBase.ShowInTaskbar = False
        MyBase.KeyPreview = True
        MyBase.FormBorderStyle = FormBorderStyle.None
        MyBase.StartPosition = FormStartPosition.Manual
        MyBase.SetStyle(ControlStyles.Selectable, False)
        MyBase.SetStyle(ControlStyles.UserPaint, True)
        MyBase.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        MyBase.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        MyBase.SetStyle(ControlStyles.ResizeRedraw, True)
        MyBase.SetStyle(ControlStyles.UserPaint, True)
    End Sub
End Class
