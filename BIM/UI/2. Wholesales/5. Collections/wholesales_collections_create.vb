Public Class wholesales_collections_create
    Private agency As Agencys = Agencys.Instance
    Private person As Persons = Persons.Instance
    Private parameter As Parameters = Parameters.Instance
    Private causal As Request = Request.Instance
    Private collection As Collection = Collection.Instance

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
        cmb_collections_segment.Datasources(parameter.settings_search_segments("row_visible=1"), "segment_name")
        cmb_collections_agency.Datasources(agency.settings_agencys_search("Id in (" & sessions.agency_permit & ") and a.row_visible=1"), "agency_name")
        cmb_collections_concept.Datasources(causal.request_causal_search("row_visible=1 and c.module_code=4 and c.causal_type='E'"), "causal_name")
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub agency_change(sender As Object, e As EventArgs) Handles cmb_collections_agency.EditValueChanged
        If cmb_collections_agency.EditValue IsNot Nothing Then
            cmb_collections_person.Datasources(person.settings_persons_listed("p.row_visible=1 and p.agency_code=" & cmb_collections_agency.EditValue), "Nombre del funcionario")
        End If
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_collections_person.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            With sender.Properties
                .View.Columns("Id").Visible = False
                .View.Columns("IDR").Width = 40
                .View.RowHeight = 30
            End With
        End If
    End Sub

    Private Sub values_leave(sender As Object, e As EventArgs) Handles txt_collections_value.Leave
        If txt_collections_value.EditValue Is Nothing Then
            txt_collections_value.EditValue = CDbl(0)
        Else
            txt_collections_value.EditValue = CDbl(txt_collections_value.EditValue)
        End If
    End Sub

    Private Sub ammount_leave(sender As Object, e As EventArgs) Handles txt_collections_ammount.Leave
        If txt_collections_ammount.EditValue Is Nothing Then
            txt_collections_ammount.EditValue = CInt(0)
        Else
            txt_collections_ammount.EditValue = CInt(txt_collections_ammount.EditValue)
        End If
    End Sub

    Private Sub conserve_collection(sender As Object, e As EventArgs) Handles chk_object_conserve.CheckedChanged
        conserve_objects(sender.Checked)
    End Sub

    Private Sub conserve_objects(value_ As Boolean)
        cmb_collections_agency.Properties.ReadOnly = value_
        cmb_collections_person.Properties.ReadOnly = value_
        txt_collections_date.Properties.ReadOnly = value_
        chk_keep_form.Checked = value_
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With collection.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "wholesales_master_collection_create"

                .Parameters.Clear()
                .Parameters.Add("@segment_code", SqlDbType.TinyInt).Value = cmb_collections_segment.EditValue
                .Parameters.Add("@concept_code", SqlDbType.TinyInt).Value = cmb_collections_concept.EditValue
                .Parameters.Add("@collection_ammount", SqlDbType.SmallInt).Value = txt_collections_ammount.EditValue
                .Parameters.Add("@collection_values", SqlDbType.Decimal, 18, 2).Value = CDbl(txt_collections_value.EditValue)
                .Parameters.Add("@date_collection", SqlDbType.Date).Value = txt_collections_date.EditValue
                .Parameters.Add("@agency_code", SqlDbType.TinyInt).Value = cmb_collections_agency.EditValue
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = cmb_collections_person.EditValue
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If collection.execute_procedure = True Then
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
