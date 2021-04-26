Public Class wholesales_datacredits_create
    Private customer As Customer = Customer.Instance
    Private agency As Agencys = Agencys.Instance
    Private causal As Request = Request.Instance
    Private person As Persons = Persons.Instance
    Private datacredit As Datacredits = Datacredits.Instance
    Private customer_code As Integer

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Public Sub New(customer_select As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set value parameter in variable
        customer_code = customer_select
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()

        'select customer with variable code
        cmb_datacredit_customer.EditValue = CInt(customer_code)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_datacredit_customer.Datasources(customer.comercial_customer_listed("c.row_visible=1"), "Nombre del cliente")
        cmb_datacredit_types.Datasources(causal.request_causal_search("row_visible=1 and c.module_code=3 and c.causal_type='E'"), "causal_name")
        cmb_datacredit_seller.Datasources(person.settings_persons_listed("p.row_visible=1 and p.agency_code in (" & sessions.agency_permit & ")"), "Nombre del funcionario")
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub customer_changed(sender As Object, e As EventArgs) Handles cmb_datacredit_customer.EditValueChanged
        'Valida si el cliente seleccionado no es vacio o igual a cero (0)
        If cmb_datacredit_customer.EditValue IsNot Nothing Then
            If cmb_datacredit_customer.EditValue.ToString <> "" And cmb_datacredit_customer.EditValue.ToString <> "0" Then
                If message_text("Desea actualizar la información del cliente seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    show_option(New comercial_customer_edited(cmb_datacredit_customer.EditValue, Me))
                End If
            End If
        End If
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_datacredit_seller.QueryPopUp, cmb_datacredit_customer.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            With sender.Properties
                .View.Columns("Id").Visible = False
                .View.Columns("IDR").Width = 40
                .View.RowHeight = 30
            End With
        End If
    End Sub

    Private Sub values_leave(sender As Object, e As EventArgs) Handles txt_datacredit_value.Leave
        If txt_datacredit_value.EditValue Is Nothing Then
            txt_datacredit_value.EditValue = CInt(0)
        Else
            txt_datacredit_value.EditValue = CDbl(txt_datacredit_value.EditValue)
        End If
    End Sub

    Private Sub customer_create(sender As Object, e As EventArgs) Handles lbl_datacredit_newcustomer.Click
        show_option(New comercial_customer_create(Me))
    End Sub

    Private Sub characters_count(sender As Object, e As EventArgs) Handles txt_datacredit_description.EditValueChanged
        lbl_object_caracters.Text = Len(txt_datacredit_description.EditValue) & "/300"
    End Sub

    Private Sub description_spelling(sender As Object, e As EventArgs) Handles txt_datacredit_description.Leave
        xvp_spell.Check(sender)
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With datacredit.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "wholesales_master_datacredit_create"

                .Parameters.Clear()
                .Parameters.Add("@customer_code", SqlDbType.Int).Value = cmb_datacredit_customer.EditValue
                .Parameters.Add("@number_invoice", SqlDbType.VarChar, 50).Value = If(txt_datacredit_invoice.EditValue IsNot Nothing, txt_datacredit_invoice.EditValue, "FE-000000")
                .Parameters.Add("@value_consultation", SqlDbType.Decimal, 18, 2).Value = Replace(CDbl(txt_datacredit_value.EditValue), ",", ".")
                .Parameters.Add("@datacredit_type", SqlDbType.SmallInt).Value = cmb_datacredit_types.EditValue
                .Parameters.Add("@datacredit_score", SqlDbType.SmallInt).Value = txt_datacredit_score.EditValue
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = cmb_datacredit_seller.EditValue
                .Parameters.Add("@capture_code", SqlDbType.Char, 1).Value = "M"
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If datacredit.execute_procedure = True Then
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
