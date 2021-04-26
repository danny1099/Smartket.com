Public Class comercial_customer_edited
    Private parameter As Parameters = Parameters.Instance
    Private person As Persons = Persons.Instance
    Private agency As Agencys = Agencys.Instance
    Private customer As Customer = Customer.Instance
    Private source_current As DataTable
    Private last_control As Control
    Private record_affected As Integer

#Region "constructor"
    Public Sub New(row_selected As Integer, lasted_control As Control)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        record_affected = row_selected
        last_control = lasted_control
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
        search_person()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_customer_document.Datasources(parameter.settings_search_documents("row_visible=1"), "alias_document")
        cmb_customer_genre.Datasources(parameter.settings_search_genres("row_visible=1"), "genre_name")
        cmb_customer_deptos.Datasources(parameter.settings_search_deptos("row_visible=1"), "department_name")
        cmb_customer_source.Datasources(customer.comercial_customer_source("row_visible=1"), "source_name")
        cmb_customer_knowledge.Datasources(customer.comercial_customer_knowledge("row_visible=1"), "knowledge_name")
        cmb_customer_refered.Datasources(customer.comercial_customer_listed("c.row_visible=1"), "Nombre del cliente")
        cmb_customer_person.Datasources(person.settings_persons_listed("p.row_visible=1 and p.agency_code in (" & sessions.agency_permit & ")"), "Nombre del funcionario")
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub change_photo(sender As Object, e As EventArgs) Handles pic_object_photo.DoubleClick, lbl_object_photo.Click
        If xfd_path.ShowDialog = DialogResult.OK Then pic_object_photo.Image = Image.FromFile(xfd_path.FileName)
    End Sub

    Private Sub deptos_changed(sender As Object, e As EventArgs) Handles cmb_customer_deptos.EditValueChanged
        If cmb_customer_deptos.EditValue IsNot Nothing Then
            cmb_customer_cities.Datasources(parameter.settings_search_cities("depto_code=" & cmb_customer_deptos.EditValue), "city_name")
        End If
    End Sub

    Private Sub search_person(Optional criteria_search As String = "")
        Dim table As DataTable = customer.comercial_customer_search("c.Id=" & record_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                cmb_customer_document.EditValue = cmb_customer_document.Properties.GetKeyValueByDisplayText(.Item("alias_document").ToString)
                txt_customer_document.EditValue = .Item("number_document").ToString
                txt_customer_name.EditValue = .Item("person_name").ToString
                txt_customer_birthdate.EditValue = CDate(.Item("birth_date"))
                cmb_customer_genre.EditValue = cmb_customer_genre.Properties.GetKeyValueByDisplayText(.Item("genre_name").ToString)
                If .Item("number_phone").ToString <> "" Then txt_customer_phone.EditValue = .Item("number_phone").ToString
                If .Item("number_cellphone").ToString <> "" Then txt_customer_celphone.EditValue = .Item("number_cellphone").ToString
                If .Item("place_address").ToString <> "" Then txt_customer_address.EditValue = .Item("place_address").ToString
                If .Item("neighborhood").ToString <> "" Then txt_customer_neighborhood.EditValue = .Item("neighborhood").ToString
                cmb_customer_deptos.EditValue = cmb_customer_deptos.Properties.GetKeyValueByDisplayText(.Item("department_name").ToString)
                If .Item("email").ToString <> "" Then txt_customer_email.EditValue = .Item("email").ToString
                cmb_customer_cities.EditValue = cmb_customer_cities.Properties.GetKeyValueByDisplayText(.Item("city_name").ToString)
                cmb_customer_source.EditValue = cmb_customer_source.Properties.GetKeyValueByDisplayText(.Item("source_name").ToString)
                cmb_customer_knowledge.EditValue = cmb_customer_knowledge.Properties.GetKeyValueByDisplayText(.Item("knowledge_name"))
                cmb_customer_person.EditValue = CInt(.Item("person_code"))
                If .Item("refered_code").ToString <> "" Then cmb_customer_refered.EditValue = CInt(.Item("refered_code").ToString)
                If .Item("photo_avatar").ToString <> "" Then pic_object_photo.Image = fn_transform_image(.Item("photo_avatar"))
                chk_customer_optin.Checked = CBool(.Item("opt_in"))
                chk_row_visible.Checked = CBool(.Item("row_visible"))
            End With

            'save data of current record
            source_current = trace_to_current(pnl_object_container)
        End If
    End Sub

    Private Sub habeas_changed(sender As Object, e As EventArgs) Handles chk_customer_optin.CheckedChanged
        If chk_customer_optin.CheckState = CheckState.Checked Then chk_customer_optin.Text = "Aceptación politica de tratamiento de datos (Opt-In)" Else If chk_customer_optin.CheckState = CheckState.Unchecked Then chk_customer_optin.Text = "Aceptación politica de tratamiento de datos (Opt-Out)"
    End Sub

    Private Sub customer_newaddres(sender As Object, e As EventArgs) Handles lbl_customer_newaddress.Click
        Using new_ As New comercial_customer_address
            new_.ShowDialog(start_home)

            If new_.address_name <> "" Then
                txt_customer_address.EditValue = new_.address_name.ToString
            End If
        End Using
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_customer_person.QueryPopUp, cmb_customer_refered.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            sender.Properties.View.Columns("Id").Visible = False
        End If
    End Sub

    Private Sub source_changed(sender As Object, e As EventArgs) Handles cmb_customer_source.EditValueChanged
        cmb_customer_refered.Properties.ReadOnly = If(cmb_customer_source.Text.Contains("Referido"), False, True)
    End Sub

    Private Sub camera_taked(sender As Object, e As EventArgs) Handles btn_photo_camera.Click
        pic_object_photo.ShowTakePictureDialog()
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With customer.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "relationship_customer_person_edited"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
                .Parameters.Add("@document_code", SqlDbType.TinyInt).Value = cmb_customer_document.EditValue
                .Parameters.Add("@number_document", SqlDbType.VarChar, 50).Value = Trim(txt_customer_document.EditValue)
                .Parameters.Add("@person_name", SqlDbType.VarChar, 100).Value = StrConv(txt_customer_name.EditValue, VbStrConv.ProperCase)
                .Parameters.Add("@birth_date", SqlDbType.Date).Value = txt_customer_birthdate.EditValue
                .Parameters.Add("@genre_code", SqlDbType.TinyInt).Value = cmb_customer_genre.EditValue
                .Parameters.Add("@number_phone", SqlDbType.VarChar, 12).Value = If(txt_customer_phone.EditValue, DBNull.Value)
                .Parameters.Add("@number_cellphone", SqlDbType.VarChar, 18).Value = If(txt_customer_celphone.EditValue, DBNull.Value)
                .Parameters.Add("@place_address", SqlDbType.VarChar, 100).Value = If(txt_customer_address.EditValue, DBNull.Value)
                .Parameters.Add("@neighborhood", SqlDbType.VarChar, 50).Value = If(txt_customer_neighborhood.EditValue, DBNull.Value)
                .Parameters.Add("@city_code", SqlDbType.SmallInt).Value = cmb_customer_cities.EditValue
                .Parameters.Add("@email", SqlDbType.VarChar, 100).Value = If(txt_customer_email.EditValue, DBNull.Value)
                .Parameters.Add("@source_code", SqlDbType.TinyInt).Value = cmb_customer_source.EditValue
                .Parameters.Add("@knowledge_code", SqlDbType.TinyInt).Value = cmb_customer_knowledge.EditValue
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = cmb_customer_person.EditValue
                .Parameters.Add("@code_search", SqlDbType.VarChar, 8).Value = fn_trace_number().Substring(1, 6)
                .Parameters.Add("@creation_date", SqlDbType.Date).Value = Now
                .Parameters.Add("@opt_in", SqlDbType.Bit).Value = chk_customer_optin.Checked
                .Parameters.Add("@refered_code", SqlDbType.Int).Value = If(cmb_customer_refered.EditValue.ToString = "", DBNull.Value, cmb_customer_refered.EditValue)
                .Parameters.Add("@photo_avatar", SqlDbType.VarBinary).Value = If(pic_object_photo.EditValue Is Nothing, DBNull.Value, fn_transform_bytes(pic_object_photo.EditValue))
                .Parameters.Add("@row_visible", SqlDbType.Bit).Value = 1
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_edited(pnl_object_container, source_current)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If customer.execute_procedure = True Then
                start_home.removed_tabbed()
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
