Imports mshtml
Imports SHDocVw
Imports APDA.Object.Controls

Public Class wholesales_movil_capture
    Private parameter As Parameters = Parameters.Instance
    Private person As Persons = Persons.Instance
    Private agency As Agencys = Agencys.Instance
    Private customer As Customer = Customer.Instance
    Private dealer As Dealers = Dealers.Instance
    Private product As Products = Products.Instance
    Private sales As Sales = Sales.Instance
    Private poliedro As Captures = Captures.Instance


#Region "constructor"
    Public Sub New(poliedro_ As Object)
        InitializeComponent()
        PerformAutoScale()

        'set value parameter in variable
        poliedro = poliedro_
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
        search_fields()

        'change state of equipment
        chk_sales_equipment.Checked = False
        txt_sales_date.EditValue = Now
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_sales_document.Datasources(parameter.settings_search_documents("row_visible=1"), "alias_document")
        cmb_sales_genre.Datasources(parameter.settings_search_genres("row_visible=1"), "genre_name")
        cmb_sales_cities.Datasources(parameter.settings_search_cities("row_visible=1"), "city_name")
        cmb_sales_agency.Datasources(agency.settings_agencys_search("Id in (" & sessions.agency_permit & ") and a.row_visible=1"), "agency_name")
        cmb_sales_equipment.Datasources(product.services_products_listed("s.row_visible=1 and s.product_type=2 and s.segment_code=1"), "Nombre del producto")
        cmb_sales_plan.Datasources(product.services_products_listed("s.row_visible=1 and s.product_type=1 and s.segment_code=1"), "Nombre de captura")
        cmb_sales_quotas.Datasources(parameter.settings_search_quotas("row_visible=1"), "quotas_name")
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub agency_change(sender As Object, e As EventArgs) Handles cmb_sales_agency.EditValueChanged
        cmb_sales_dealer.Datasources(dealer.settings_dealers_search("row_visible=1 and d.Id in (select dealer_code from [Entities.Bussines.Distributary] where agency_code=" & cmb_sales_agency.EditValue & " and segment_code=1 and row_visible=1)"), "dealer_name")
        cmb_sales_seller.Datasources(person.settings_persons_listed("p.row_visible=1 and p.agency_code=" & cmb_sales_agency.EditValue), "Nombre del funcionario")
    End Sub

    Private Sub check_equipment(sender As Object, e As EventArgs) Handles chk_sales_equipment.CheckedChanged
        If chk_sales_equipment.Checked = True Then
            cmb_sales_equipment.Properties.ReadOnly = False
            cmb_sales_equipment.EditValue = Nothing
            txt_sales_serial3.EditValue = Nothing
            txt_sales_serial3.Properties.ReadOnly = False
        Else
            cmb_sales_equipment.Properties.ReadOnly = True
            cmb_sales_equipment.EditValue = Nothing
            txt_sales_serial3.EditValue = StrDup(15, "0")
            txt_sales_serial3.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_sales_seller.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            sender.Properties.View.Columns("Id").Visible = False
        End If
    End Sub

    Private Sub values_enter(sender As Object, e As EventArgs) Handles txt_sales_value.Enter
        txt_sales_value.EditValue = Nothing
    End Sub

    Private Sub values_leave(sender As Object, e As EventArgs) Handles txt_sales_value.Leave
        If txt_sales_value.EditValue Is Nothing Then txt_sales_value.EditValue = CInt(0) Else txt_sales_value.EditValue = CDbl(txt_sales_value.EditValue)
    End Sub
#End Region

#Region "capture"
    Private Sub search_fields()
        With poliedro
            Dim source As DataTable = .settings_search_poliedro("o.url_object='" & .url_page & "' and p.row_visible=1")

            If source.Rows.Count > 0 Then
                For Each item As Object In pnl_object_container.Controls
                    'comprueba el tipo de objecto a buscar
                    If TypeOf item Is TextboxEdit And item.Tag IsNot Nothing Then item.EditValue = CStr(fields_objects(item.Tag.ToString, source))
                    If TypeOf item Is ComboboxEdit And item.Tag IsNot Nothing Then item.EditValue = item.Properties.GetKeyValueByDisplayText(CStr(fields_objects(item.Tag.ToString, source)))
                Next
            End If
        End With
    End Sub

    Private Function fields_objects(item_name As String, source As DataTable) As Object
        Dim row() As DataRow = source.Select("reference='" & item_name & "'")
        Dim result_field As String = String.Empty

        If row.Length > 0 Then
            With row(0)
                If .Item(("type_object")).ToString = "T" Then Return object_text(.Item(("field_object")).ToString)
                If .Item(("type_object")).ToString = "S" Then Return object_select(.Item(("field_object")).ToString)
            End With
        End If

        Return result_field
    End Function

    Private Function object_text(element_search As String) As String
        With poliedro.html_document
            Dim element_object As HTMLInputTextElement = TryCast(.getElementsByName(element_search).item(Nothing, 0), HTMLInputTextElement)

            If element_object IsNot Nothing Then
                Return element_object.value
            End If
        End With

        Return String.Empty
    End Function

    Private Function object_select(element_search As String) As String
        With poliedro.html_document
            Dim select_element As HTMLSelectElement = TryCast(.getElementsByName(element_search).item(Nothing, 0), HTMLSelectElement)

            If select_element IsNot Nothing Then
                For i As Integer = 0 To select_element.length - 1
                    Dim obj_helper As Object = select_element.item(i, 0)
                    If TypeOf obj_helper Is HTMLOptionElementClass AndAlso (CType(obj_helper, HTMLOptionElementClass)).value = select_element.value Then
                        Return (CType(obj_helper, HTMLOptionElementClass)).text
                    End If
                Next
            End If
        End With

        Return String.Empty
    End Function
#End Region

#Region "methods"
    Private Sub saved_option_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With customer.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "wholesales_master_movil_capture"

                .Parameters.Clear()
                .Parameters.Add("@document_code", SqlDbType.TinyInt).Value = cmb_sales_document.EditValue
                .Parameters.Add("@number_document", SqlDbType.VarChar, 50).Value = txt_sales_document.EditValue
                .Parameters.Add("@person_name", SqlDbType.VarChar, 100).Value = StrConv(txt_sales_name.EditValue, VbStrConv.ProperCase) & " " & StrConv(txt_sales_lastname.EditValue, VbStrConv.ProperCase)
                .Parameters.Add("@birth_date", SqlDbType.Date).Value = txt_sales_birthdate.EditValue
                .Parameters.Add("@genre_code", SqlDbType.TinyInt).Value = cmb_sales_genre.EditValue
                .Parameters.Add("@number_phone", SqlDbType.VarChar, 12).Value = If(txt_sales_phone.EditValue, DBNull.Value)
                .Parameters.Add("@number_cellphone", SqlDbType.VarChar, 18).Value = If(txt_sales_celphone.EditValue, DBNull.Value)
                .Parameters.Add("@place_address", SqlDbType.VarChar, 100).Value = If(txt_sales_address.EditValue, DBNull.Value)
                .Parameters.Add("@neighborhood", SqlDbType.VarChar, 50).Value = If(txt_sales_neighborhood.EditValue, DBNull.Value)
                .Parameters.Add("@city_code", SqlDbType.SmallInt).Value = cmb_sales_cities.EditValue
                .Parameters.Add("@email", SqlDbType.VarChar, 100).Value = If(txt_sales_email.EditValue, DBNull.Value)
                .Parameters.Add("@source_code", SqlDbType.TinyInt).Value = 1
                .Parameters.Add("@code_search", SqlDbType.VarChar, 8).Value = "00000000".Substring(1, 6)
                .Parameters.Add("@creation_date", SqlDbType.Date).Value = Now
                .Parameters.Add("@opt_in", SqlDbType.Bit).Value = 1
                .Parameters.Add("@photo_avatar", SqlDbType.VarBinary).Value = DBNull.Value
                .Parameters.Add("@date_sale", SqlDbType.Date).Value = CDate(txt_sales_date.EditValue)
                .Parameters.Add("@number_serial1", SqlDbType.VarChar, 10).Value = txt_sales_serial1.EditValue
                .Parameters.Add("@number_serial2", SqlDbType.VarChar, 17).Value = txt_sales_serial2.EditValue
                .Parameters.Add("@number_serial3", SqlDbType.VarChar, 15).Value = txt_sales_serial3.EditValue
                .Parameters.Add("@dealer_code", SqlDbType.TinyInt).Value = cmb_sales_dealer.EditValue
                .Parameters.Add("@operator_code", SqlDbType.TinyInt).Value = cmb_sales_dealer.GetColumnValue("operator_code")
                .Parameters.Add("@number_contract", SqlDbType.VarChar, 50).Value = If(txt_sales_contract.EditValue IsNot Nothing, txt_sales_contract.EditValue, "CN-00000")
                .Parameters.Add("@number_invoice", SqlDbType.VarChar, 50).Value = If(txt_sales_invoice.EditValue IsNot Nothing, txt_sales_invoice.EditValue, "FV-00000")
                .Parameters.Add("@product_code1", SqlDbType.Int).Value = cmb_sales_plan.EditValue
                .Parameters.Add("@product_code2", SqlDbType.Int).Value = If(cmb_sales_equipment.EditValue, 0)
                .Parameters.Add("@value_sales1", SqlDbType.Decimal, 18, 2).Value = Replace(CDbl(cmb_sales_plan.GetColumnValue("Valor de producto")), ",", ".")
                .Parameters.Add("@value_sales2", SqlDbType.Decimal, 18, 2).Value = Replace(CDbl(txt_sales_value.EditValue), ",", ".")
                .Parameters.Add("@quotas_code", SqlDbType.TinyInt).Value = cmb_sales_quotas.EditValue
                .Parameters.Add("@mark_ported", SqlDbType.TinyInt).Value = If(chk_sales_ported.Checked = True, 1, 2)
                .Parameters.Add("@mark_migration", SqlDbType.TinyInt).Value = If(chk_sales_migration.Checked = True, 1, 2)
                .Parameters.Add("@mark_convergent", SqlDbType.TinyInt).Value = If(chk_sales_convergent.Checked = True, 1, 2)
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = cmb_sales_seller.EditValue
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If customer.execute_procedure = True Then
                Close()
            End If
        End If
    End Sub

    Private Sub canceled_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        If message_text("Está seguro que desea cancelar la capura de venta?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Close()
        End If
    End Sub
#End Region
End Class