Public Class chances_taked_massive
    Private chance As Chances = Chances.Instance
    Private person As Persons = Persons.Instance
    Private rows_taked As List(Of TakedChance)

#Region "contructors"
    Public Sub New(rows_selected As List(Of TakedChance))
        InitializeComponent()
        PerformAutoScale()

        'setea el parametro entrante en la variable rows_split
        rows_taked = rows_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_person_name.Datasources(person.settings_persons_listed("p.row_visible=1 and p.agency_code in (" & sessions.agency_permit & ")"), "Nombre del funcionario")
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_person_name.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            With sender.Properties
                .View.Columns("Id").Visible = False
                .View.Columns("IDR").Width = 40
                .View.RowHeight = 30
            End With
        End If
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
                    .Parameters.Add("@theme_code", SqlDbType.TinyInt).Value = 14
                    .Parameters.Add("@created_date", SqlDbType.DateTime).Value = Now
                    .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = cmb_person_name.EditValue
                    .Parameters.Add("@agency_code", SqlDbType.TinyInt).Value = 0
                    .Parameters.Add("@description_text", SqlDbType.VarChar, 500).Value = "Creación de gestión comercial de oportunidad de venta para el vendedor " & cmb_person_name.Text & " por el usuario " & sessions.person_name
                    .Parameters.Add("@chance_code", SqlDbType.Int).Value = otaked.chance_code
                    .Parameters.Add("@wholesale_code", SqlDbType.Int).Value = otaked.wholesales_code
                    .Parameters.Add("@service_code", SqlDbType.Int).Value = otaked.services_code
                    .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                    .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                    .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
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

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class