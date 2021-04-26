Public Class comercial_customer_refered
    Private parameter As Parameters = Parameters.Instance
    Private person As Persons = Persons.Instance
    Private agency As Agencys = Agencys.Instance
    Private customer As Customer = Customer.Instance
    Private record_affected As Integer

#Region "constructor"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        record_affected = row_selected
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
        cmb_customer_genre.Datasources(parameter.settings_search_genres("row_visible=1"), "genre_name")
        cmb_refered_deptos.Datasources(parameter.settings_search_deptos("row_visible=1"), "department_name")
    End Sub

    Private Sub deptos_changed(sender As Object, e As EventArgs) Handles cmb_refered_deptos.EditValueChanged
        If cmb_refered_deptos.EditValue IsNot Nothing Then
            cmb_refered_cities.Datasources(parameter.settings_search_cities("depto_code=" & cmb_refered_deptos.EditValue), "city_name")
        End If
    End Sub

    Private Sub habeas_changed(sender As Object, e As EventArgs) Handles chk_customer_optin.CheckedChanged
        If chk_customer_optin.CheckState = CheckState.Checked Then chk_customer_optin.Text = "Aceptación politica de tratamiento de datos (Opt-In)" Else If chk_customer_optin.CheckState = CheckState.Unchecked Then chk_customer_optin.Text = "Aceptación politica de tratamiento de datos (Opt-Out)"
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With customer.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "relationship_customer_person_refered"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = record_affected
                .Parameters.Add("@document_code", SqlDbType.TinyInt).Value = 1
                .Parameters.Add("@number_document", SqlDbType.VarChar, 50).Value = DBNull.Value
                .Parameters.Add("@person_name", SqlDbType.VarChar, 100).Value = StrConv(txt_refered_name.EditValue, VbStrConv.ProperCase)
                .Parameters.Add("@birth_date", SqlDbType.Date).Value = Now.AddYears(-18)
                .Parameters.Add("@genre_code", SqlDbType.TinyInt).Value = cmb_customer_genre.EditValue
                .Parameters.Add("@number_phone", SqlDbType.VarChar, 12).Value = If(txt_refered_phone.EditValue, DBNull.Value)
                .Parameters.Add("@number_cellphone", SqlDbType.VarChar, 18).Value = If(txt_refered_celphone.EditValue, DBNull.Value)
                .Parameters.Add("@place_address", SqlDbType.VarChar, 100).Value = DBNull.Value
                .Parameters.Add("@neighborhood", SqlDbType.VarChar, 50).Value = DBNull.Value
                .Parameters.Add("@city_code", SqlDbType.SmallInt).Value = cmb_refered_cities.EditValue
                .Parameters.Add("@email", SqlDbType.VarChar, 100).Value = DBNull.Value
                .Parameters.Add("@agency_code", SqlDbType.TinyInt).Value = sessions.agency_code
                .Parameters.Add("@source_code", SqlDbType.TinyInt).Value = 11
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@code_search", SqlDbType.VarChar, 8).Value = fn_trace_number().Substring(1, 6)
                .Parameters.Add("@creation_date", SqlDbType.Date).Value = Now
                .Parameters.Add("@opt_in", SqlDbType.Bit).Value = chk_customer_optin.Checked
                .Parameters.Add("@photo_avatar", SqlDbType.VarBinary).Value = DBNull.Value
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If customer.execute_procedure = True Then
                If chk_keep_form.Checked = True Then
                    defaults_objects(pnl_object_container)
                Else
                    Close()
                End If
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class