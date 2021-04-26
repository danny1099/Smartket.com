Public Class chances_taked_create
    Private chance As Chances = Chances.Instance
    Private attention As Attentions = Attentions.Instance
    Private agency As Agencys = Agencys.Instance
    Private person As Persons = Persons.Instance
    Private rows_taked As List(Of TakedChance)

#Region "constructor"
    Public Sub New(rows_selected As List(Of TakedChance))
        InitializeComponent()
        PerformAutoScale()

        'setea el parametro entrante en la variable rows_split
        rows_taked = rows_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_taked_agency.Datasources(agency.settings_agencys_search("row_visible=1 and a.Id in (" & sessions.agency_permit & ")"), "agency_name")
        cmb_taked_theme.Datasources(attention.commercial_attention_themes("row_visible=1 and t.topic_code=6"), "theme_name")

        'set date of created and check if paramter row affected is not null
        txt_taked_created.EditValue = Now
        cmb_taked_theme.EditValue = cmb_taked_theme.Properties.GetKeyValueByDisplayText("Oportunidad Venta")
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_cancel.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub agency_changed(sender As Object, e As EventArgs) Handles cmb_taked_agency.EditValueChanged
        If cmb_taked_agency.EditValue IsNot Nothing Then
            cmb_taked_seller.Datasources(person.settings_persons_listed("p.row_visible=1 and p.agency_code=" & cmb_taked_agency.EditValue), "Nombre del funcionario")
        End If
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_taked_seller.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            With sender.Properties
                .View.Columns("Id").Visible = False
                .View.Columns("IDR").Width = 40
                .View.RowHeight = 30
            End With
        End If
    End Sub

    Private Sub refresh_listed(sender As Object, e As EventArgs) Handles btn_object_refresh.Click
        object_listed()
    End Sub

    Private Sub characters_count(sender As Object, e As EventArgs) Handles txt_taked_desc.EditValueChanged
        lbl_object_caracters.Text = Len(txt_taked_desc.EditValue) & "/500"
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            For Each otaked As TakedChance In rows_taked
                With chance.sql_command
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "relationship_customer_taked_ticket"

                    .Parameters.Clear()
                    .Parameters.Add("@customer_code", SqlDbType.Int).Value = otaked.customer_code
                    .Parameters.Add("@topic_code", SqlDbType.TinyInt).Value = 6
                    .Parameters.Add("@theme_code", SqlDbType.TinyInt).Value = cmb_taked_theme.EditValue
                    .Parameters.Add("@created_date", SqlDbType.DateTime).Value = Now
                    .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = cmb_taked_seller.EditValue
                    .Parameters.Add("@agency_code", SqlDbType.TinyInt).Value = cmb_taked_agency.EditValue
                    .Parameters.Add("@description_text", SqlDbType.VarChar, 500).Value = If(txt_taked_desc.EditValue, "Creación de gestión comercial de oportunidad de venta para el vendedor " & cmb_taked_seller.Text & " por el usuario " & sessions.person_name)
                    .Parameters.Add("@chance_code", SqlDbType.Int).Value = otaked.chance_code
                    .Parameters.Add("@wholesale_code", SqlDbType.Int).Value = otaked.wholesales_code
                    .Parameters.Add("@service_code", SqlDbType.Int).Value = otaked.services_code
                    .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                    .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                    .Parameters.Add("@event_date", SqlDbType.DateTime).Value = txt_taked_created.EditValue
                    .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                    .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output

                    'ejecuta el procedimiento de la clase
                    If chance.execute_procedure(False) = True Then
                    End If
                End With
            Next

            'mensaje de confirmacion de proceso finalizado
            If message_text("Las oportunidades de venta fueron tomadas exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then
                start_home.removed_tabbed()
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
