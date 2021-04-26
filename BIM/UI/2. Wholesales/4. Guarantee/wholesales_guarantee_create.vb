Public Class wholesales_guarantee_create
    Private customer As Customer = Customer.Instance
    Private agency As Agencys = Agencys.Instance
    Private brand As Brands = Brands.Instance
    Private product As Products = Products.Instance
    Private person As Persons = Persons.Instance
    Private causal As Request = Request.Instance
    Private guarantee As Guarantee = Guarantee.Instance

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
        cmb_guarantee_customer.Datasources(customer.comercial_customer_listed("c.row_visible=1"), "Nombre del cliente")
        cmb_guarantee_agency.Datasources(agency.settings_agencys_search("row_visible=1"), "agency_name")
        cmb_guarantee_brand.Datasources(brand.services_brands_search("row_visible=1 and b.Id not in (0)"), "brand_name")
        cmb_guarantee_causal.Datasources(causal.request_causal_search("row_visible=1 and c.module_code=2 and c.causal_type='E'"), "causal_name")
        cmb_guarantee_type.Datasources(causal.request_causal_search("row_visible=1 and c.module_code=2 and c.causal_type='R'"), "causal_name")
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub agency_change(sender As Object, e As EventArgs) Handles cmb_guarantee_agency.EditValueChanged
        If cmb_guarantee_agency.EditValue IsNot Nothing Then
            cmb_guarantee_seller.Datasources(person.settings_persons_listed("p.row_visible=1 and p.agency_code=" & cmb_guarantee_agency.EditValue), "Nombre del funcionario")
        End If
    End Sub

    Private Sub brand_change(sender As Object, e As EventArgs) Handles cmb_guarantee_brand.EditValueChanged
        If cmb_guarantee_brand.EditValue IsNot Nothing Then
            cmb_guarantee_product.Datasources(product.services_products_listed("s.row_visible=1 and s.segment_code=3 and s.brand_code=" & cmb_guarantee_brand.EditValue), "Nombre del producto")
        End If
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_guarantee_customer.QueryPopUp, cmb_guarantee_seller.QueryPopUp, cmb_guarantee_product.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            sender.Properties.View.Columns("Id").Visible = False
        End If
    End Sub

    Private Sub customer_create(sender As Object, e As EventArgs) Handles lbl_guarantee_newcustomer.Click
        show_option(New comercial_customer_create(Me))
    End Sub

    Private Sub customer_changed(sender As Object, e As EventArgs) Handles cmb_guarantee_customer.EditValueChanged
        If cmb_guarantee_customer.EditValue IsNot Nothing Then
            If cmb_guarantee_customer.EditValue.ToString <> "" And cmb_guarantee_customer.EditValue.ToString <> "0" Then
                If message_text("Desea actualizar la información del cliente seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    show_option(New comercial_customer_edited(cmb_guarantee_customer.EditValue, Me))
                End If
            End If
        End If
    End Sub

    Private Sub characters_count(sender As Object, e As EventArgs) Handles txt_guarantee_description.EditValueChanged
        lbl_object_caracters.Text = Len(txt_guarantee_description.EditValue) & "/500"
    End Sub

    Private Sub description_spelling(sender As Object, e As EventArgs) Handles txt_guarantee_description.Leave
        xvp_spell.Check(sender)
    End Sub

    Private Sub serial_generate(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_guarantee_serial.ButtonClick
        txt_guarantee_serial.EditValue = fn_trace_number()
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With guarantee.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "wholesales_master_guarantee_created"

                .Parameters.Clear()
                .Parameters.Add("@customer_code", SqlDbType.Int).Value = cmb_guarantee_customer.EditValue
                .Parameters.Add("@number_serial", SqlDbType.VarChar, 50).Value = txt_guarantee_serial.EditValue
                .Parameters.Add("@number_invoice", SqlDbType.VarChar, 50).Value = txt_guarantee_invoice.EditValue
                .Parameters.Add("@date_sale", SqlDbType.Date).Value = txt_guarantee_date.EditValue
                .Parameters.Add("@product_code", SqlDbType.Int).Value = cmb_guarantee_product.EditValue
                .Parameters.Add("@product_name", SqlDbType.VarChar, 100).Value = cmb_guarantee_product.Text
                .Parameters.Add("@sku_item", SqlDbType.VarChar, 50).Value = "000000"
                .Parameters.Add("@brand_code", SqlDbType.SmallInt).Value = cmb_guarantee_brand.EditValue
                .Parameters.Add("@causal_split", SqlDbType.VarChar, 50).Value = cmb_guarantee_causal.EditValue
                .Parameters.Add("@agency_code", SqlDbType.TinyInt).Value = cmb_guarantee_agency.EditValue
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = cmb_guarantee_seller.EditValue
                .Parameters.Add("@causal_type", SqlDbType.SmallInt).Value = cmb_guarantee_type.EditValue
                .Parameters.Add("@description_text", SqlDbType.VarChar, 500).Value = txt_guarantee_description.EditValue
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If guarantee.execute_procedure = True Then
                If chk_keep_form.Checked = True Then
                    defaults_objects(pnl_object_container)
                Else
                    start_home.removed_tabbed()
                End If
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
