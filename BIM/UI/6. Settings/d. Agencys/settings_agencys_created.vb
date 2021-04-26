
Public Class settings_agencys_created
    Private agency As Agencys = Agencys.Instance
    Private parameter As Parameters = Parameters.Instance
    Private person As Persons = Persons.Instance

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
        'Carga los listados de datos
        cmb_agency_deptos.Datasources(parameter.settings_search_deptos("row_visible=1"), "department_name")
        cmb_agency_type.Datasources(agencys_type, "agency_type")
        cmb_agency_person.Datasources(person.settings_persons_listed("p.row_visible=1"), "Nombre del funcionario")
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub deptos_changed(sender As Object, e As EventArgs) Handles cmb_agency_deptos.EditValueChanged
        If cmb_agency_deptos.EditValue IsNot Nothing Then
            cmb_agency_cities.Datasources(parameter.settings_search_cities("depto_code=" & cmb_agency_deptos.EditValue), "city_name")
        End If
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_agency_person.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            With sender.Properties
                .View.Columns("Id").Visible = False
                .View.Columns("IDR").Width = 40
                .View.RowHeight = 30
            End With
        End If
    End Sub

    Private Sub customer_newaddres(sender As Object, e As EventArgs) Handles lbl_agency_newaddress.Click
        Using new_ As New comercial_customer_address
            new_.ShowDialog(start_home)

            If new_.address_name <> "" Then
                txt_agency_address.EditValue = new_.address_name.ToString
            End If
        End Using
    End Sub

    Private Function agencys_type() As DataTable
        Dim source_table As New DataTable

        With source_table
            .Columns.Add("Id")
            .Columns.Add("agency_type")

            'Crea los tipos de agencia
            .Rows.Add("A", "Administrativa")
            .Rows.Add("S", "Sala de ventas")
            .Rows.Add("R", "Centro de pago")
            .Rows.Add("B", "Almacen y/o Bodega")
        End With

        Return source_table
    End Function
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With agency.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_bussines_agency_create"

                .Parameters.Clear()
                .Parameters.Add("@agency_name", SqlDbType.VarChar, 50).Value = txt_agency_name.EditValue
                .Parameters.Add("@number_phone", SqlDbType.VarChar, 12).Value = If(txt_agency_phone.EditValue, DBNull.Value)
                .Parameters.Add("@number_cellphone", SqlDbType.VarChar, 12).Value = If(txt_agency_celphone.EditValue, DBNull.Value)
                .Parameters.Add("@place_address", SqlDbType.VarChar, 100).Value = txt_agency_address.EditValue
                .Parameters.Add("@neighborhood", SqlDbType.VarChar, 50).Value = txt_agency_neighborhood.EditValue
                .Parameters.Add("@email", SqlDbType.VarChar, 100).Value = txt_agency_email.EditValue
                .Parameters.Add("@city_code", SqlDbType.SmallInt).Value = cmb_agency_cities.EditValue
                .Parameters.Add("@agency_type", SqlDbType.Char, 1).Value = cmb_agency_type.EditValue
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = cmb_agency_person.EditValue
                .Parameters.Add("@point_latitude", SqlDbType.Decimal, 18, 6).Value = txt_agency_latitude.EditValue
                .Parameters.Add("@point_longitude", SqlDbType.Decimal, 18, 6).Value = txt_agency_longitude.EditValue
                .Parameters.Add("@center_operation", SqlDbType.VarChar, 10).Value = txt_agency_center.EditValue
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If agency.execute_procedure = True Then
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
