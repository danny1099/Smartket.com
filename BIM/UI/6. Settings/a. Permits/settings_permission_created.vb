Public Class settings_permission_created
    Private person As Persons = Persons.Instance
    Private position As Positions = Positions.Instance
    Private permission As Permission = Permission.Instance

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
        cmb_permission_type.Datasources(permission.settings_permission_types, "type_permit")
        cmb_permission_position.Datasources(position.settings_position_search("row_visible=1"), "position_name")
        cmb_permission_person.Datasources(person.settings_persons_listed("p.row_visible=1"), "Nombre del funcionario")
        cmb_permission_module.Datasources(permission.settings_permission_module("m.row_visible=1"), "module_name")
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub type_changed(sender As Object, e As EventArgs) Handles cmb_permission_type.EditValueChanged
        If cmb_permission_type.EditValue IsNot Nothing Then
            cmb_permission_person.Visible = If(cmb_permission_type.EditValue = "P", True, False)
            cmb_permission_position.Visible = If(cmb_permission_type.EditValue = "R", True, False)
        End If
    End Sub

    Private Sub object_changed(sender As Object, e As EventArgs) Handles cmb_permission_person.EditValueChanged, cmb_permission_position.EditValueChanged
        If sender.EditValue IsNot Nothing Then
            cmb_permission_module.EditValue = Nothing
            cmb_permission_option.EditValue = Nothing
            lbc_permission_actions.DataSource = Nothing
            lbc_permission_assigned.DataSource = Nothing
        End If
    End Sub

    Private Sub module_change(sender As Object, e As EventArgs) Handles cmb_permission_module.EditValueChanged
        If cmb_permission_module.EditValue IsNot Nothing Then
            cmb_permission_option.Datasources(permission.settings_permission_options("o.row_visible=1 and o.module_code=" & cmb_permission_module.EditValue), "option_name")
        End If
    End Sub

    Private Sub option_changed(sender As Object, e As EventArgs) Handles cmb_permission_option.EditValueChanged
        If cmb_permission_option.EditValue IsNot Nothing Then
            load_actions()
            load_assigned()
        End If
    End Sub

    Private Sub load_actions()
        If cmb_permission_option.EditValue IsNot Nothing Then
            Dim source1 As DataTable = permission.settings_permission_actions("a.Id in (" & cmb_permission_option.GetColumnValue("actions_split") & ") and a.row_visible=1 and a.Id not in (select actions_code from [Settings.Permissions.Controller]  where option_code=" & cmb_permission_option.EditValue & " and permit_type='" & cmb_permission_type.EditValue & "' and row_affected=" & If(cmb_permission_type.EditValue = "P", cmb_permission_person.EditValue, cmb_permission_position.EditValue) & " and row_visible=1)")

            'carga las acciones disponibles del modulo
            With lbc_permission_actions
                .DataSource = Nothing
                .Items.Clear()
                .DataSource = source1
                .ValueMember = "Id"
                .DisplayMember = "action_name"
            End With
        End If
    End Sub

    Private Sub load_assigned()
        If cmb_permission_option.EditValue IsNot Nothing Then
            Dim source2 As DataTable = permission.settings_permission_assigned("c.option_code=" & cmb_permission_option.EditValue & " and c.permit_type='" & cmb_permission_type.EditValue & "' and c.row_affected=" & If(cmb_permission_type.EditValue = "P", cmb_permission_person.EditValue, cmb_permission_position.EditValue) & " and c.row_visible=1")

            'carga las acciones asignadas al modulo
            With lbc_permission_assigned
                .DataSource = Nothing
                .Items.Clear()
                .DataSource = source2
                .ValueMember = "Id"
                .DisplayMember = "action_name"
            End With
        End If
    End Sub

    Private Sub conserve_options(sender As Object, e As EventArgs) Handles chk_object_conserve.CheckedChanged
        conserve_structure(chk_object_conserve.Checked)
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_permission_person.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            sender.Properties.View.Columns("Id").Visible = False
        End If
    End Sub

    Private Sub conserve_structure(state As Boolean)
        cmb_permission_type.Properties.ReadOnly = state
        cmb_permission_position.Properties.ReadOnly = state
        cmb_permission_person.Properties.ReadOnly = state
        chk_keep_form.Checked = state
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True And lbc_permission_actions.SelectedValue IsNot Nothing Then
            With person.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "settings_permissions_controller_create"

                .Parameters.Clear()
                .Parameters.Add("@permit_type", SqlDbType.Char, 1).Value = cmb_permission_type.EditValue
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = If(cmb_permission_type.EditValue = "P", cmb_permission_person.EditValue, cmb_permission_position.EditValue)
                .Parameters.Add("@module_code", SqlDbType.TinyInt).Value = cmb_permission_module.EditValue
                .Parameters.Add("@option_code", SqlDbType.SmallInt).Value = cmb_permission_option.EditValue
                .Parameters.Add("@action_code", SqlDbType.TinyInt).Value = lbc_permission_actions.SelectedValue
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If person.execute_procedure = True Then
                If chk_keep_form.Checked = True Then
                    'load all permits newed
                    If chk_object_conserve.Checked = True Then
                        load_actions()
                        load_assigned()
                    End If
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
