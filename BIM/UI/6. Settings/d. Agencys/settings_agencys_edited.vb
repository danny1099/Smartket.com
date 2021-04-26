Public Class settings_agencys_edited
    Private agency As Agencys = Agencys.Instance
    Private parameter As Parameters = Parameters.Instance
    Private person As Persons = Persons.Instance
    Private source_current As DataTable
    Private row_affected As Integer

#Region "constructor"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'Define el parametro enviado
        row_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
        object_search()
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

    Private Sub object_search()
        Dim table_source As DataTable = agency.settings_agencys_search("Id=" & row_affected)

        If table_source.Rows.Count = 1 Then
            With table_source.Rows(0)
                txt_agency_name.EditValue = .Item("agency_name").ToString
                txt_agency_address.EditValue = .Item("place_address").ToString
                txt_agency_neighborhood.EditValue = .Item("neighborhood").ToString
                cmb_agency_deptos.EditValue = cmb_agency_deptos.Properties.GetKeyValueByDisplayText(.Item("department_name").ToString)
                cmb_agency_cities.EditValue = cmb_agency_cities.Properties.GetKeyValueByDisplayText(.Item("city_name").ToString)
                txt_agency_email.EditValue = .Item("email").ToString
                txt_agency_phone.EditValue = .Item("number_phone").ToString
                txt_agency_celphone.EditValue = .Item("number_cellphone").ToString
                cmb_agency_type.EditValue = .Item("agency_type").ToString
                txt_agency_center.EditValue = .Item("center_operation").ToString
                txt_agency_latitude.EditValue = .Item("point_latitude").ToString
                txt_agency_longitude.EditValue = .Item("point_longitude").ToString
                If .Item("person_code").ToString <> "" Then cmb_agency_person.EditValue = CInt(.Item("person_code"))
                chk_row_visible.Checked = CBool(.Item("row_visible"))

                'save data of current record
                source_current = trace_to_current(pnl_object_container)
            End With
        End If
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
                .CommandText = "entities_bussines_agency_edited"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.TinyInt).Value = row_affected
                .Parameters.Add("@agency_name", SqlDbType.VarChar, 50).Value = txt_agency_name.EditValue
                .Parameters.Add("@number_phone", SqlDbType.VarChar, 12).Value = If(txt_agency_phone.EditValue.ToString = "", DBNull.Value, txt_agency_phone.EditValue)
                .Parameters.Add("@number_cellphone", SqlDbType.VarChar, 12).Value = If(txt_agency_celphone.EditValue.ToString = "", DBNull.Value, txt_agency_celphone.EditValue)
                .Parameters.Add("@place_address", SqlDbType.VarChar, 100).Value = If(txt_agency_address.EditValue.ToString = "", DBNull.Value, txt_agency_address.EditValue)
                .Parameters.Add("@neighborhood", SqlDbType.VarChar, 50).Value = If(txt_agency_neighborhood.EditValue.ToString = "", DBNull.Value, txt_agency_neighborhood.EditValue)
                .Parameters.Add("@email", SqlDbType.VarChar, 100).Value = If(txt_agency_email.EditValue.ToString = "", DBNull.Value, txt_agency_email.EditValue)
                .Parameters.Add("@city_code", SqlDbType.SmallInt).Value = cmb_agency_cities.EditValue
                .Parameters.Add("@agency_type", SqlDbType.Char, 1).Value = cmb_agency_type.EditValue
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = If(cmb_agency_person.EditValue.ToString = "", DBNull.Value, cmb_agency_person.EditValue)
                .Parameters.Add("@point_latitude", SqlDbType.Decimal, 18, 6).Value = txt_agency_latitude.EditValue
                .Parameters.Add("@point_longitude", SqlDbType.Decimal, 18, 6).Value = txt_agency_longitude.EditValue
                .Parameters.Add("@center_operation", SqlDbType.VarChar, 10).Value = txt_agency_center.EditValue
                .Parameters.Add("@row_visible", SqlDbType.Bit).Value = chk_row_visible.Checked
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_edited(pnl_object_container, source_current)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If agency.execute_procedure = True Then
                start_home.removed_tabbed()
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
