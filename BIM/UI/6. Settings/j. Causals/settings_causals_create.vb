Public Class settings_causals_create
    Private causal As Request = Request.Instance
    Private parameter_ As Parameters = Parameters.Instance

#Region "contructors"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
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
        cmb_causal_module.Datasources(parameter_.settings_search_modules, "module_name")
        cmb_causal_type.Datasources(causal_types, "causal_type")
    End Sub

    Private Function causal_types() As DataTable
        Dim source_table As New DataTable

        With source_table
            .Columns.Add("Id")
            .Columns.Add("causal_type")

            .Rows.Add("E", "Entrada")
            .Rows.Add("S", "Solución")
            .Rows.Add("R", "Reporte")
        End With

        Return source_table
    End Function
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With causal.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "settings_general_causal_create"

                .Parameters.Clear()
                .Parameters.Add("@causal_name", SqlDbType.VarChar, 50).Value = txt_causal_name.EditValue
                .Parameters.Add("@acronym", SqlDbType.VarChar, 5).Value = txt_causal_acronym.EditValue
                .Parameters.Add("@module_code", SqlDbType.TinyInt).Value = cmb_causal_module.EditValue
                .Parameters.Add("@causal_type", SqlDbType.Char, 1).Value = cmb_causal_type.EditValue
                .Parameters.Add("@description_text", SqlDbType.VarChar, 300).Value = DBNull.Value
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If causal.execute_procedure = True Then
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