Public Class comercial_attention_financial
    Private document As Documents = Documents.Instance
    Private attention As Attentions = Attentions.Instance
    Private agency As Agencys = Agencys.Instance
    Private person As Persons = Persons.Instance
    Private customer As Customer = Customer.Instance
    Private parameter As Parameters = Parameters.Instance
    Private financials As Financial = Financial.Instance
    Private customer_code As Integer
    Private row_affected As Integer

#Region "constructors"
    Public Sub New(row_selected As Integer, customer_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'Define el parametro de la gestion seleccionada
        row_affected = row_selected
        customer_code = customer_selected
    End Sub

    Public Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
        search_person()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_financial_type.Datasources(parameter.settings_search_documents("row_visible=1"), "alias_document")
        cmb_financial_genre.Datasources(parameter.settings_search_genres("row_visible=1"), "genre_name")
        cmb_financial_deptos.Datasources(parameter.settings_search_deptos("row_visible=1"), "department_name")
        cmb_financial_source.Datasources(customer.comercial_customer_source("row_visible=1"), "source_name")
        cmb_financial_plan.Datasources(financials.financial_plans_search("f.row_visible=1 and f.mark_global=1 or f.row_visible=1 and f.agency_array in (" & sessions.agency_permit & ")"), "financial_plan")
        cmb_financial_agency.Datasources(agency.settings_agencys_search("Id in (1," & sessions.agency_permit & ") and a.row_visible=1"), "agency_name")
    End Sub

    Private Sub search_person()
        Dim table As DataTable = customer.comercial_customer_search("c.Id=" & customer_code)

        If table.Rows.Count >= 1 Then
            With table.Rows(0)
                txt_financial_customer.EditValue = .Item("person_name").ToString
                txt_financial_birthdate.EditValue = CDate(.Item("birth_date"))
                cmb_financial_genre.EditValue = cmb_financial_genre.Properties.GetKeyValueByDisplayText(.Item("genre_name").ToString)
                cmb_financial_type.EditValue = cmb_financial_type.Properties.GetKeyValueByDisplayText(.Item("alias_document").ToString)
                txt_financial_document.EditValue = .Item("number_document").ToString
                If .Item("number_phone").ToString <> "" Then txt_financial_phone.EditValue = .Item("number_phone").ToString
                If .Item("number_cellphone").ToString <> "" Then txt_financial_cellphone.EditValue = .Item("number_cellphone").ToString
                If .Item("place_address").ToString <> "" Then txt_financial_address.EditValue = .Item("place_address").ToString
                cmb_financial_deptos.EditValue = cmb_financial_deptos.Properties.GetKeyValueByDisplayText(.Item("department_name").ToString)
                If .Item("email").ToString <> "" Then txt_financial_email.EditValue = .Item("email").ToString
                cmb_financial_cities.EditValue = cmb_financial_cities.Properties.GetKeyValueByDisplayText(.Item("city_name").ToString)
                cmb_financial_source.EditValue = cmb_financial_source.Properties.GetKeyValueByDisplayText(.Item("source_name").ToString)
                txt_financial_totally.EditValue = CDec(.Item("credit_limit"))
            End With
        End If
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub deptos_changed(sender As Object, e As EventArgs) Handles cmb_financial_deptos.EditValueChanged
        If cmb_financial_deptos.EditValue IsNot Nothing Then
            cmb_financial_cities.Datasources(parameter.settings_search_cities("depto_code=" & cmb_financial_deptos.EditValue), "city_name")
        End If
    End Sub

    Private Sub agency_change(sender As Object, e As EventArgs) Handles cmb_financial_agency.EditValueChanged
        If cmb_financial_agency.EditValue IsNot Nothing Then
            cmb_financial_person.Datasources(person.settings_persons_listed("p.row_visible=1 and p.agency_code=" & cmb_financial_agency.EditValue), "Nombre del funcionario")
        End If
    End Sub

    Private Sub plans_changed(sender As Object, e As EventArgs) Handles cmb_financial_plan.EditValueChanged
        If cmb_financial_plan.EditValue IsNot Nothing Then
            With cmb_financial_plan
                'Valores asociados al plan seleccionado
                Dim bank_interest As Decimal = .GetColumnValue("bank_interest")
                Dim deadlines As Integer = .GetColumnValue("deadlines")
                Dim credit_limit As Decimal = CDec(txt_financial_totally.EditValue)
                Dim financial_value As Decimal = credit_limit / deadlines
                Dim value_interest As Decimal = (bank_interest * credit_limit)
                Dim financial_interest As Decimal = value_interest + (credit_limit / deadlines)

                'Setea los valores en los campos
                txt_financial_interest.EditValue = Format(bank_interest, "p1")
                txt_financial_quotas.EditValue = deadlines

                If .GetColumnValue("fixed_quota").ToString = "True" Then txt_financial_values.EditValue = financial_value
                If .GetColumnValue("fixed_quota").ToString = "False" Then txt_financial_values.EditValue = financial_interest
            End With
        End If
    End Sub

    Private Sub quotas_changed(sender As Object, e As EventArgs) Handles txt_financial_totally.Leave
        If txt_financial_totally.EditValue IsNot Nothing Then
            plans_changed(cmb_financial_plan, Nothing)
        End If
    End Sub

    Private Sub capture_fingerprint(sender As Object, e As EventArgs) Handles lbl_capture_finger.Click
        img_object_finger.started_capture()
        img_object_finger.load_capture()
    End Sub

    Private Sub capture_obverse(sender As Object, e As EventArgs) Handles lbl_capture_docanver.Click
        img_object_obverse.ShowTakePictureDialog()
    End Sub

    Private Sub capture_reverse(sender As Object, e As EventArgs) Handles lbl_capture_docrever.Click
        img_object_backside.ShowTakePictureDialog()
    End Sub

    Private Function attachment_images() As List(Of Image)
        Dim listed_image As New List(Of Image)
        Dim finger_printer As Image = img_object_finger.EditValue
        Dim doc_obverse As Image = img_object_obverse.EditValue
        Dim doc_reverse As Image = img_object_backside.EditValue

        'Define el nombre de las imagenes en la propiedad TAG
        finger_printer.Tag = "Huella Indice"
        doc_obverse.Tag = "Cedula Anverso"
        doc_reverse.Tag = "Cedula Reverso"

        With listed_image
            .Add(finger_printer)
            .Add(doc_obverse)
            .Add(doc_reverse)
        End With

        Return listed_image
    End Function
#End Region

#Region "options"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles object_button_saved.Click
        If xvp_validate.Validate = True Then
            With customer.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_financial_request_created"

                .Parameters.Clear()
                .Parameters.Add("@attention_code", SqlDbType.Int).Value = row_affected
                .Parameters.Add("@customer_code", SqlDbType.Int).Value = customer_code
                .Parameters.Add("@financial_plan", SqlDbType.TinyInt).Value = cmb_financial_plan.EditValue
                .Parameters.Add("@deadlines", SqlDbType.TinyInt).Value = CInt(cmb_financial_plan.GetColumnValue("deadlines"))
                .Parameters.Add("@bank_interest", SqlDbType.Decimal, 18, 4).Value = CDec(cmb_financial_plan.GetColumnValue("bank_interest"))
                .Parameters.Add("@financial_value", SqlDbType.Decimal, 18, 2).Value = CDec(txt_financial_totally.EditValue)
                .Parameters.Add("@quota_value", SqlDbType.Decimal, 18, 2).Value = CDec(txt_financial_values.EditValue)
                .Parameters.Add("@refered_name1", SqlDbType.VarChar, 100).Value = txt_refered_name1.EditValue
                .Parameters.Add("@refered_phone1", SqlDbType.VarChar, 13).Value = If(txt_refered_phone1.EditValue Is Nothing, DBNull.Value, txt_refered_phone1.EditValue)
                .Parameters.Add("@refered_cellphone1", SqlDbType.VarChar, 19).Value = txt_refered_cellphone1.EditValue
                .Parameters.Add("@refered_name2", SqlDbType.VarChar, 100).Value = txt_refered_name2.EditValue
                .Parameters.Add("@refered_phone2", SqlDbType.VarChar, 13).Value = If(txt_refered_phone2.EditValue Is Nothing, DBNull.Value, txt_refered_phone2.EditValue)
                .Parameters.Add("@refered_cellphone2", SqlDbType.VarChar, 19).Value = txt_refered_cellphone2.EditValue
                .Parameters.Add("@person_code", SqlDbType.Int).Value = cmb_financial_person.EditValue
                .Parameters.Add("@agency_code", SqlDbType.TinyInt).Value = cmb_financial_agency.EditValue
                .Parameters.Add("@description_text", SqlDbType.VarChar, 300).Value = If(txt_financial_description.EditValue IsNot Nothing, txt_financial_description.EditValue, "El usuario " & sessions.person_name & " realizo una solicitud de crédito")
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
                .Parameters.Add("@record_affected", SqlDbType.Int).Direction = ParameterDirection.Output

                'Ejecuta el proceso para registrar la solicitud
                If customer.execute_procedure = True Then
                    'Obtiene el codigo de registro de la peticion para asociar a las fotos
                    Dim row_affected As Integer = CInt(.Parameters("@record_affected").Value.ToString)

                    'Guarda las imagenes adjuntas
                    If document.documents_master_create(row_affected, "Entities.Financial.Request", attachment_images()) = True Then
                        start_home.removed_tabbed()
                    End If
                End If
            End With
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
