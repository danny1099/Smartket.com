Public Class tasks_masters_created
    Private agency As Agencys = Agencys.Instance
    Private person As Persons = Persons.Instance
    Private project As Projects = Projects.Instance

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
        cmb_tasks_agency.Datasources(agency.settings_agencys_search("Id in (" & sessions.agency_permit & ") and a.row_visible=1"), "agency_name")
        cmb_tasks_category.Datasources(project.task_category_search("row_visible=1"), "category_name")

        'define la fecha inicial de la solicitud
        txt_tasks_date.EditValue = Now
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub agency_change(sender As Object, e As EventArgs) Handles cmb_tasks_agency.EditValueChanged
        If cmb_tasks_agency.EditValue IsNot Nothing Then
            cmb_tasks_seller.Datasources(person.settings_persons_listed("p.row_visible=1 and p.agency_code=" & cmb_tasks_agency.EditValue), "Nombre del funcionario")
        End If
    End Sub

    Private Sub category_change(sender As Object, e As EventArgs) Handles cmb_tasks_category.EditValueChanged
        If cmb_tasks_category.EditValue IsNot Nothing Then
            cmb_tasks_type.Datasources(project.task_items_search("t.row_visible=1 and t.category_code=" & cmb_tasks_category.EditValue), "type_name")
        End If
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_tasks_seller.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            With sender.Properties
                .View.Columns("Id").Visible = False
                .View.Columns("IDR").Width = 40
                .View.RowHeight = 30
            End With
        End If
    End Sub

    Private Sub characters_count(sender As Object, e As EventArgs) Handles txt_tasks_description.EditValueChanged
        lbl_object_caracters.Text = Len(txt_tasks_description.EditValue) & "/500"
    End Sub

    Private Sub description_spelling(sender As Object, e As EventArgs) Handles txt_tasks_description.Leave
        xvp_spell.Check(sender)
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With project.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_projects_tasks_create"

                .Parameters.Clear()
                .Parameters.Add("@tasked_name", SqlDbType.VarChar, 100).Value = StrConv(txt_tasks_title.EditValue, VbStrConv.ProperCase)
                .Parameters.Add("@since_date", SqlDbType.SmallDateTime).Value = Now
                .Parameters.Add("@until_date", SqlDbType.SmallDateTime).Value = DateAdd(DateInterval.Day, cmb_tasks_type.GetColumnValue("term_days"), Now)
                .Parameters.Add("@category_code", SqlDbType.TinyInt).Value = cmb_tasks_category.EditValue
                .Parameters.Add("@task_type", SqlDbType.TinyInt).Value = cmb_tasks_type.EditValue
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = cmb_tasks_seller.EditValue
                .Parameters.Add("@agency_code", SqlDbType.TinyInt).Value = cmb_tasks_agency.EditValue
                .Parameters.Add("@description_text", SqlDbType.VarChar, 500).Value = txt_tasks_description.EditValue
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If project.execute_procedure = True Then
                start_home.removed_tabbed()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
