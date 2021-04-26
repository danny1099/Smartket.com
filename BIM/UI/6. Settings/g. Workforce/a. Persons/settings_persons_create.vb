Public Class settings_persons_create
    Private parameter As Parameters = Parameters.Instance
    Private position As Positions = Positions.Instance
    Private agency As Agencys = Agencys.Instance
    Private person As Persons = Persons.Instance

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load report to show data in lookup
        object_listed()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_employee_document.Datasources(parameter.settings_search_documents("row_visible=1"), "alias_document")
        cmb_employee_genre.Datasources(parameter.settings_search_genres("row_visible=1"), "genre_name")
        cmb_employee_deptos.Datasources(parameter.settings_search_deptos("row_visible=1"), "department_name")
        cmb_employee_position.Datasources(position.settings_position_search("row_visible=1"), "position_name")
        cmb_employee_agency.Datasources(agency.settings_agencys_search("Id in (" & sessions.agency_permit & ") and a.row_visible=1"), "agency_name")
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub search_document(sender As Object, e As EventArgs) Handles txt_employee_document.Leave
        If txt_employee_document.Text <> "" Then search_person()
    End Sub

    Private Sub validate_options(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_employee_document.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Search And txt_employee_document.Text <> "" Then search_person()
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

    Private Sub deptos_changed(sender As Object, e As EventArgs) Handles cmb_employee_deptos.EditValueChanged
        If cmb_employee_deptos.EditValue IsNot Nothing Then
            cmb_employee_cities.Datasources(parameter.settings_search_cities("depto_code=" & cmb_employee_deptos.EditValue), "city_name")
        End If
    End Sub

    Private Sub searching_code(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_employee_code.ButtonClick
        txt_employee_code.EditValue = fn_trace_number().Substring(1, 6)
    End Sub

    Private Sub person_newaddres(sender As Object, e As EventArgs) Handles lbl_customer_newaddress.Click
        Using new_ As New comercial_customer_address
            new_.ShowDialog(start_home)

            If new_.address_name <> "" Then
                txt_employee_address.EditValue = new_.address_name.ToString
            End If
        End Using
    End Sub

    Private Sub search_person()
        Dim table As DataTable = person.settings_persons_search("p.number_document='" & txt_employee_document.Text & "'")

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                txt_employee_name.EditValue = .Item("person_name").ToString
                txt_employee_birthdate.EditValue = CDate(.Item("birth_date"))
                cmb_employee_genre.EditValue = cmb_employee_genre.Properties.GetKeyValueByDisplayText(.Item("genre_name").ToString)
                If .Item("number_phone").ToString <> "" Then txt_employee_phone.EditValue = .Item("number_phone").ToString
                If .Item("number_cellphone").ToString <> "" Then txt_employee_celphone.EditValue = .Item("number_cellphone").ToString
                If .Item("place_address").ToString <> "" Then txt_employee_address.EditValue = .Item("place_address").ToString
                If .Item("neighborhood").ToString <> "" Then txt_employee_neighborhood.EditValue = .Item("neighborhood").ToString
                cmb_employee_deptos.EditValue = cmb_employee_deptos.Properties.GetKeyValueByDisplayText(.Item("department_name").ToString)
                If .Item("email").ToString <> "" Then txt_employee_email.EditValue = .Item("email").ToString
                cmb_employee_cities.EditValue = cmb_employee_cities.Properties.GetKeyValueByDisplayText(.Item("city_name").ToString)
                cmb_employee_position.EditValue = cmb_employee_position.Properties.GetKeyValueByDisplayText(.Item("position_name").ToString)
                cmb_employee_agency.EditValue = cmb_employee_agency.Properties.GetKeyValueByDisplayText(.Item("agency_name").ToString)
                If .Item("code_search").ToString <> "" Then txt_employee_code.EditValue = .Item("code_search").ToString
                txt_employee_admite.EditValue = CDate(.Item("creation_date"))
                chk_employee_optin.Checked = CBool(.Item("opt_in"))
            End With
        End If
    End Sub

    Private Sub habeas_changed(sender As Object, e As EventArgs) Handles chk_employee_optin.CheckedChanged
        If chk_employee_optin.CheckState = CheckState.Checked Then chk_employee_optin.Text = "Aceptación politica de tratamiento de datos (Opt-In)" Else If chk_employee_optin.CheckState = CheckState.Unchecked Then chk_employee_optin.Text = "Aceptación politica de tratamiento de datos (Opt-Out)"
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With person.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_workforce_persons_create"

                .Parameters.Clear()
                .Parameters.Add("@document_code", SqlDbType.TinyInt).Value = cmb_employee_document.EditValue
                .Parameters.Add("@number_document", SqlDbType.VarChar, 50).Value = Trim(txt_employee_document.EditValue)
                .Parameters.Add("@person_name", SqlDbType.VarChar, 100).Value = StrConv(txt_employee_name.EditValue, VbStrConv.ProperCase)
                .Parameters.Add("@birth_date", SqlDbType.Date).Value = txt_employee_birthdate.EditValue
                .Parameters.Add("@genre_code", SqlDbType.TinyInt).Value = cmb_employee_genre.EditValue
                .Parameters.Add("@number_phone", SqlDbType.VarChar, 12).Value = If(txt_employee_phone.EditValue, DBNull.Value)
                .Parameters.Add("@number_cellphone", SqlDbType.VarChar, 18).Value = If(txt_employee_celphone.EditValue, DBNull.Value)
                .Parameters.Add("@place_address", SqlDbType.VarChar, 100).Value = If(txt_employee_address.EditValue, DBNull.Value)
                .Parameters.Add("@neighborhood", SqlDbType.VarChar, 50).Value = If(txt_employee_neighborhood.EditValue, DBNull.Value)
                .Parameters.Add("@city_code", SqlDbType.SmallInt).Value = cmb_employee_cities.EditValue
                .Parameters.Add("@email", SqlDbType.VarChar, 100).Value = If(txt_employee_email.EditValue, DBNull.Value)
                .Parameters.Add("@agency_code", SqlDbType.TinyInt).Value = cmb_employee_agency.EditValue
                .Parameters.Add("@position_code", SqlDbType.TinyInt).Value = cmb_employee_position.EditValue
                .Parameters.Add("@code_search", SqlDbType.VarChar, 6).Value = txt_employee_code.EditValue
                .Parameters.Add("@creation_date", SqlDbType.Date).Value = txt_employee_admite.EditValue
                .Parameters.Add("@opt_in", SqlDbType.Bit).Value = chk_employee_optin.Checked
                .Parameters.Add("@user_access", SqlDbType.VarChar, 50).Value = DBNull.Value
                .Parameters.Add("@photo_avatar", SqlDbType.VarBinary).Value = If(pic_object_photo.EditValue Is Nothing, DBNull.Value, fn_transform_bytes(pic_object_photo.EditValue))
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If person.execute_procedure = True Then
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
