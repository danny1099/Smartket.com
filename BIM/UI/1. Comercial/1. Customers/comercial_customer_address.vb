Public Class comercial_customer_address
    Private setting As Parameters = Parameters.Instance
    Property address_name As String

#Region "contructors"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_customer_address.Datasources(setting.settings_search_address, "address_name")
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            address_name = cmb_customer_address.Text & " " & txt_customer_address.EditValue & " # " & If(IsNumeric(Replace(txt_customer_number.EditValue, "-", "")) = True, txt_customer_number.EditValue & "-" & txt_customer_house.EditValue, txt_customer_number.EditValue & " " & txt_customer_house.EditValue)

            If address_name <> "" Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class