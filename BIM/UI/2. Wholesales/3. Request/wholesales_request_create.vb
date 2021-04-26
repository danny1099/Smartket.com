Public Class wholesales_request_create
    Private agency As Agencys = Agencys.Instance
    Private person As Persons = Persons.Instance
    Private request As Request = Request.Instance
    Private sales As Sales = Sales.Instance
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
        search_object()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_request_agency.Datasources(agency.settings_agencys_search("Id in (" & sessions.agency_permit & ") and a.row_visible=1"), "agency_name")
        cmb_request_causal.Datasources(request.request_causal_search("row_visible=1 and c.module_code=1 and c.causal_type='E'"), "causal_name")
    End Sub

    Private Sub search_object()
        Dim table As DataTable = sales.wholesale_sales_search("s.Id=" & record_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                txt_request_date.EditValue = CDate(.Item("date_sale"))
                txt_request_sales.EditValue = .Item("number_serial1")
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

    Private Sub agency_change(sender As Object, e As EventArgs) Handles cmb_request_agency.EditValueChanged
        If cmb_request_agency.EditValue IsNot Nothing Then
            cmb_request_seller.Datasources(person.settings_persons_listed("p.row_visible=1 and p.agency_code=" & cmb_request_agency.EditValue), "Nombre del funcionario")
        End If
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_request_seller.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            With sender.Properties
                .View.Columns("Id").Visible = False
                .View.Columns("IDR").Width = 40
                .View.RowHeight = 30
            End With
        End If
    End Sub

    Private Sub characters_count(sender As Object, e As EventArgs) Handles txt_request_description.EditValueChanged
        lbl_object_caracters.Text = Len(txt_request_description.EditValue) & "/300"
    End Sub

    Private Sub description_spelling(sender As Object, e As EventArgs) Handles txt_request_description.Leave
        xvp_spell.Check(sender)
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With request.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "wholesales_master_request_create"

                .Parameters.Clear()
                .Parameters.Add("@wholesale_code", SqlDbType.Int).Value = record_affected
                .Parameters.Add("@request_title", SqlDbType.VarChar, 100).Value = "Solicitud de " & cmb_request_causal.Text & " de la venta " & txt_request_sales.EditValue
                .Parameters.Add("@request_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@causal_split", SqlDbType.VarChar, 100).Value = Replace(cmb_request_causal.EditValue, " ", "")
                .Parameters.Add("@description_text", SqlDbType.VarChar, 300).Value = txt_request_description.EditValue
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = cmb_request_seller.EditValue
                .Parameters.Add("@agency_code", SqlDbType.TinyInt).Value = cmb_request_agency.EditValue
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If request.execute_procedure = True Then
                If chk_keep_form.Checked = True Then
                    cmb_request_causal.EditValue = Nothing
                    txt_request_description.EditValue = Nothing
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
