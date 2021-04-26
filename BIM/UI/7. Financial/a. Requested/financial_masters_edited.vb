Public Class financial_masters_edited
    Private document As Documents = Documents.Instance
    Private attention As Attentions = Attentions.Instance
    Private agency As Agencys = Agencys.Instance
    Private person As Persons = Persons.Instance
    Private customer As Customer = Customer.Instance
    Private parameter As Parameters = Parameters.Instance
    Private causal As Request = Request.Instance
    Private financials As Financial = Financial.Instance
    Private source_images As New List(Of String)
    Private customer_code As Integer
    Private row_affected As Integer

#Region "constructors"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'Define el parametro de la gestion seleccionada
        row_affected = row_selected
    End Sub

    Public Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
        search_financial()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_financial_type.Datasources(parameter.settings_search_documents("row_visible=1"), "alias_document")
        cmb_financial_genre.Datasources(parameter.settings_search_genres("row_visible=1"), "genre_name")
        cmb_financial_deptos.Datasources(parameter.settings_search_deptos("row_visible=1"), "department_name")
        cmb_financial_source.Datasources(customer.comercial_customer_source("row_visible=1"), "source_name")
        cmb_financial_plan.Datasources(financials.financial_plans_search("f.row_visible=1 and f.mark_global=1 or f.row_visible=1 and f.agency_array in (" & sessions.agency_permit & ")"), "financial_plan")
        cmb_financial_person.Datasources(person.settings_persons_listed("p.row_visible=1"), "Nombre del funcionario")
        cmb_financial_status.Datasources(parameter.settings_search_status("row_visible=1 and  s.Id not in (25) and s.module_type='F'"), "status_name")
        cmb_financial_refuse.Datasources(causal.request_causal_search("row_visible=1 and c.module_code=7 and c.causal_type='S'"), "causal_name")
    End Sub

    Private Sub search_financial()
        Dim table_source As DataTable = financials.financial_request_search("r.Id=" & row_affected)
        Dim attachments As DataTable = document.documents_master_search(row_affected, "Entities.Financial.Request")


        If table_source.Rows.Count >= 1 Then
            With table_source.Rows(0)
                customer_code = CInt(.Item("customer_code").ToString)
                txt_financial_customer.EditValue = .Item("person_name").ToString
                txt_financial_birthdate.EditValue = CDate(.Item("birth_date"))
                cmb_financial_genre.EditValue = cmb_financial_genre.Properties.GetKeyValueByDisplayText(.Item("genre_name").ToString)
                cmb_financial_type.EditValue = cmb_financial_type.Properties.GetKeyValueByDisplayText(.Item("alias_document").ToString)
                txt_financial_document.EditValue = .Item("number_document").ToString
                If .Item("number_phone").ToString <> "" Then txt_financial_phone.EditValue = .Item("number_phone").ToString
                If .Item("number_cellphone").ToString <> "" Then txt_financial_cellphone.EditValue = .Item("number_cellphone").ToString
                If .Item("place_address").ToString <> "" Then txt_financial_address.EditValue = .Item("place_address").ToString & " | " & .Item("neighborhood").ToString
                cmb_financial_deptos.EditValue = cmb_financial_deptos.Properties.GetKeyValueByDisplayText(.Item("department_name").ToString)
                If .Item("email").ToString <> "" Then txt_financial_email.EditValue = .Item("email").ToString
                cmb_financial_cities.EditValue = cmb_financial_cities.Properties.GetKeyValueByDisplayText(.Item("city_name").ToString)
                cmb_financial_source.EditValue = cmb_financial_source.Properties.GetKeyValueByDisplayText(.Item("source_name").ToString)
                txt_refered_name1.EditValue = .Item("refered_name1").ToString
                txt_refered_name2.EditValue = .Item("refered_name2").ToString
                If .Item("refered_phone1").ToString <> "" Then txt_refered_phone1.EditValue = .Item("refered_phone1").ToString
                If .Item("refered_phone2").ToString <> "" Then txt_refered_phone2.EditValue = .Item("refered_phone2").ToString
                If .Item("refered_cellphone1").ToString <> "" Then txt_refered_cellphone1.EditValue = .Item("refered_cellphone1").ToString
                If .Item("refered_cellphone2").ToString <> "" Then txt_refered_cellphone2.EditValue = .Item("refered_cellphone2").ToString
                cmb_financial_plan.EditValue = cmb_financial_plan.Properties.GetKeyValueByDisplayText(.Item("financial_plan").ToString)
                txt_financial_interest.EditValue = Format(.Item("bank_interest"), "p1")
                txt_financial_quotas.EditValue = CInt(.Item("deadlines"))
                txt_financial_totally.EditValue = CDec(.Item("financial_value"))
                txt_financial_values.EditValue = CDec(.Item("quota_value"))
                txt_object_current.EditValue = CDec(.Item("credit_limit"))
                cmb_financial_person.EditValue = cmb_financial_person.Properties.GetKeyValueByDisplayText(.Item("user_name").ToString)
                If .Item("description_text").ToString <> "" Then txt_financial_description.EditValue = .Item("description_text").ToString
            End With

            'Carga las imagenes adjuntas  los controles de imagen
            With attachments
                For i As Integer = 0 To .Rows.Count - 1
                    If .Rows(i).Item("document_name").ToString = "Huella Indice" Then img_object_finger.Image = fn_transform_image(.Rows(i).Item("document_support"))
                    If .Rows(i).Item("document_name").ToString = "Cedula Anverso" Then img_object_obverse.Image = fn_transform_image(.Rows(i).Item("document_support"))
                    If .Rows(i).Item("document_name").ToString = "Cedula Reverso" Then img_object_backside.Image = fn_transform_image(.Rows(i).Item("document_support"))
                Next
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

    Private Sub status_changed(sender As Object, e As EventArgs) Handles cmb_financial_status.EditValueChanged
        If message_text("Está seguro que desea cambiar el estado a la solicitud seleccionada?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Select Case cmb_financial_status.EditValue
                Case 27
                    txt_financial_account.Properties.ReadOnly = False
                    txt_financial_account.EditValue = "CA" & Format(row_affected, "D6")
                    chk_financial_payment.ReadOnly = False
                    chk_financial_payment.Checked = True
                    cmb_financial_refuse.EditValue = Nothing
                    cmb_financial_refuse.Properties.ReadOnly = True
                    txt_financial_date.EditValue = Now.AddMonths(1)

                Case 28
                    txt_financial_account.EditValue = Nothing
                    txt_financial_account.Properties.ReadOnly = True
                    cmb_financial_refuse.Properties.ReadOnly = False
                    chk_financial_payment.Checked = False
                    chk_financial_payment.ReadOnly = True
                    txt_financial_date.EditValue = Nothing

                Case 26
                    txt_financial_account.EditValue = Nothing
                    txt_financial_account.Properties.ReadOnly = True
                    cmb_financial_refuse.EditValue = Nothing
                    cmb_financial_refuse.Properties.ReadOnly = False
                    chk_financial_payment.Checked = False
                    chk_financial_payment.ReadOnly = True
                    txt_financial_date.EditValue = Nothing
            End Select
        End If
    End Sub

    Private Sub images_adding(sender As Object, e As EventArgs) Handles lbl_financial_attachment.Click
        If xfd_path.ShowDialog = DialogResult.OK Then
            If message_text("Está seguro que desea agregar la(s) imagen(es) seleccionada(s)?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                For Each item_name As String In xfd_path.FileNames
                    With source_images
                        .Add(item_name)
                    End With
                Next

                'Comprueba que el listado de bytes este cargado para mostrar el mensaje de finalizado
                If source_images.Count >= 1 Then
                    message_text("Las imagenes fueron adjuntadas exitosamente", MessageBoxButtons.OK)
                    lbl_financial_attachment.Text = String.Format("Adjuntar imagenes de soporte ({0})", source_images.Count.ToString)
                End If
            End If
        End If
    End Sub
#End Region

#Region "options"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles object_button_saved.Click
        If xvp_validate.Validate = True And CDec(txt_financial_totally.EditValue) <= CDec(txt_object_current.EditValue) Then
            With financials.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_financial_request_edited"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = row_affected
                .Parameters.Add("@status_code", SqlDbType.TinyInt).Value = cmb_financial_status.EditValue
                .Parameters.Add("@account_number", SqlDbType.VarChar, 15).Value = If(txt_financial_account.EditValue IsNot Nothing, txt_financial_account.EditValue, DBNull.Value)
                .Parameters.Add("@causal_code", SqlDbType.SmallInt).Value = If(cmb_financial_refuse.EditValue IsNot Nothing, cmb_financial_refuse.EditValue, DBNull.Value)
                .Parameters.Add("@deadlines", SqlDbType.TinyInt).Value = CInt(txt_financial_quotas.EditValue)
                .Parameters.Add("@bank_interest", SqlDbType.Decimal, 18, 4).Value = CDec(Replace(txt_financial_interest.EditValue, "%", "")) / 100
                .Parameters.Add("@quota_value", SqlDbType.Decimal, 18, 2).Value = CDec(txt_financial_values.EditValue)
                .Parameters.Add("@first_payment", SqlDbType.Date).Value = If(txt_financial_date.EditValue IsNot Nothing, txt_financial_date.EditValue, DBNull.Value)
                .Parameters.Add("@description_text", SqlDbType.VarChar, 300).Value = If(txt_financial_notes.EditValue IsNot Nothing, txt_financial_notes.EditValue, "La solicitud de crédito fué " & cmb_financial_status.Text & " por el usuario " & sessions.person_name)
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output

                'Ejecuta la actualizacion de los datos
                If financials.execute_procedure = True Then
                    'Comprueba si se han adjuntado documentos para llamar el proceso
                    If source_images.Count > 0 Then
                        If document.documents_master_create(row_affected, "Entities.Financial.Request", source_images) = True Then
                        End If
                    End If

                    'Comprueba si el estado seleccionado es diferente a 'En Verificacion' para cerrar el modulo
                    Select Case cmb_financial_status.EditValue
                        Case 27 : If (financials.financial_credits_quotas(customer_code, CDec(txt_financial_totally.EditValue) * -1)) = True Then start_home.removed_tabbed()
                        Case 28 : start_home.removed_tabbed()
                    End Select
                End If
            End With
        ElseIf CDec(txt_financial_totally.EditValue) > CDec(txt_object_current.EditValue) Then
            message_text("El cupo solicitado/autorizado no puede ser mayor al cupo asignado al cliente", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
