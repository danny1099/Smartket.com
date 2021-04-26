Public Class services_products_create
    Private category As Categorys = Categorys.Instance
    Private parameter As Parameters = Parameters.Instance
    Private operators As Operators = Operators.Instance
    Private product As Products = Products.Instance
    Private brand As Brands = Brands.Instance

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_products_type.Datasources(product.services_products_type("row_visible=1"), "product_type")
        cmb_products_segment.Datasources(parameter.settings_search_segments("row_visible=1"), "segment_name")
        cmb_products_operator.Datasources(operators.settings_operators_search("row_visible in (1,0)"), "operator_name")
        cmb_products_category.Datasources(category.services_categorys_search("row_visible=1"), "category_name")
        cmb_products_brand.Datasources(brand.services_brands_search("row_visible>=0"), "brand_name")
        cmb_products_providers.Datasources(product.services_providers_search("row_visible=1"), "provider_name")
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub change_photo1(sender As Object, e As EventArgs) Handles pic_object_photo.Click, lbl_object_photo.Click
        If xfd_path.ShowDialog = DialogResult.OK Then
            pic_object_photo.Image = Image.FromFile(xfd_path.FileName)
        End If
    End Sub

    Private Sub change_photo2(sender As Object, e As DevExpress.XtraEditors.Events.PopupMenuShowingEventArgs) Handles pic_object_photo.PopupMenuShowing
        If xfd_path.ShowDialog = DialogResult.OK Then
            pic_object_photo.Image = Image.FromFile(xfd_path.FileName)
        End If
    End Sub

    Private Sub searching_code(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_products_sku.ButtonClick
        txt_products_sku.EditValue = fn_trace_number().Substring(1, 6)
    End Sub

    Private Sub validate_values(sender As Object, e As EventArgs) Handles txt_products_value.Leave
        If txt_products_value.EditValue Is Nothing Then txt_products_value.EditValue = CInt(0)
    End Sub

    Private Sub validate_type(sender As Object, e As EventArgs) Handles cmb_products_type.EditValueChanged
        If cmb_products_type.EditValue IsNot Nothing Then
            If cmb_products_type.EditValue = 2 Then cmb_products_operator.EditValue = cmb_products_operator.Properties.GetKeyValueByDisplayText("Non applicable") Else cmb_products_operator.EditValue = Nothing
            If cmb_products_type.EditValue = 3 Then cmb_products_brand.EditValue = cmb_products_brand.Properties.GetKeyValueByDisplayText("Non applicable") Else cmb_products_brand.EditValue = Nothing
            If cmb_products_type.EditValue = 4 Then cmb_products_brand.EditValue = cmb_products_brand.Properties.GetKeyValueByDisplayText("Non applicable") Else cmb_products_brand.EditValue = Nothing
        End If
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With product.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_products_services_create"

                .Parameters.Clear()
                .Parameters.Add("@product_name", SqlDbType.VarChar, 100).Value = txt_products_name.EditValue
                .Parameters.Add("@capture_name", SqlDbType.VarChar, 100).Value = txt_products_capture.EditValue
                .Parameters.Add("@sku_item", SqlDbType.VarChar, 50).Value = txt_products_sku.EditValue
                .Parameters.Add("@purchase_value", SqlDbType.Decimal, 18, 2).Value = CDbl(txt_products_value.EditValue)
                .Parameters.Add("@product_type", SqlDbType.TinyInt).Value = cmb_products_type.EditValue
                .Parameters.Add("@segment_code", SqlDbType.TinyInt).Value = cmb_products_segment.EditValue
                .Parameters.Add("@operator_code", SqlDbType.TinyInt).Value = cmb_products_operator.EditValue
                .Parameters.Add("@category_code", SqlDbType.TinyInt).Value = cmb_products_category.EditValue
                .Parameters.Add("@brand_code", SqlDbType.SmallInt).Value = cmb_products_brand.EditValue
                .Parameters.Add("@mark_main", SqlDbType.Bit).Value = chk_product_main.Checked
                .Parameters.Add("@mark_mixed", SqlDbType.Bit).Value = chk_product_mixed.Checked
                .Parameters.Add("@provider_code", SqlDbType.SmallInt).Value = cmb_products_providers.EditValue
                .Parameters.Add("@date_create", SqlDbType.Date).Value = Now
                .Parameters.Add("@description_text", SqlDbType.VarChar, 300).Value = If(txt_products_desc.EditValue, DBNull.Value)
                .Parameters.Add("@photo_avatar", SqlDbType.VarBinary).Value = If(pic_object_photo.EditValue Is Nothing, DBNull.Value, fn_transform_bytes(pic_object_photo.EditValue))
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If product.execute_procedure = True Then
                If chk_keep_form.Checked = True Then
                    defaults_objects(pnl_object_container)
                Else
                          start_home.removed_tabbed()
                End If
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
              start_home.removed_tabbed()
    End Sub
#End Region
End Class
