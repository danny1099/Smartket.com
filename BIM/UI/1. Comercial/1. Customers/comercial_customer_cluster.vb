Public Class comercial_customer_cluster
    Private group As Grouped = Grouped.Instance
    Private rows_selected As New List(Of Integer)

#Region "contructors"
    Public Sub New(row_selected_ As List(Of Integer))
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        rows_selected = row_selected_
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
        cmb_customer_group.Datasources(group.commercial_groups_listed("row_visible=1 and g.person_code=" & sessions.person_code), "Nombre del grupo")
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            For Each row_affected As Integer In rows_selected
                With group.sql_command
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "relationship_customer_cluster_create"

                    .Parameters.Clear()
                    .Parameters.Add("@customer_code", SqlDbType.Int).Value = row_affected
                    .Parameters.Add("@group_code", SqlDbType.SmallInt).Value = cmb_customer_group.EditValue
                    .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                    .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                    .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                    .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                    .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
                End With

                If group.execute_procedure(False) = True Then
                End If
            Next

            'mensaje de confirmacion de proceso finalizado
            If message_text("Los grupos de clientes fueron asociados exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then
                If chk_keep_form.Checked = True Then
                    defaults_objects(pnl_object_container)
                Else
                    Close()
                End If
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class