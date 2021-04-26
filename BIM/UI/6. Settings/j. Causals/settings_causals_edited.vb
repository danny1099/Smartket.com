Public Class settings_causals_edited
    Private causal As Request = Request.Instance
    Private parameter_ As Parameters = Parameters.Instance
    Private source_current As DataTable
    Private record_affected As Integer

#Region "contructors"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'setea el valor de parametro en la variable
        record_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
        object_search()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_search()
        Dim table As DataTable = causal.request_causal_search("Id=" & record_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                txt_causal_name.EditValue = .Item("causal_name").ToString
                txt_causal_acronym.EditValue = .Item("acronym").ToString
                cmb_causal_type.EditValue = .Item("causal_type").ToString
                cmb_causal_module.EditValue = cmb_causal_module.Properties.GetKeyValueByDisplayText(.Item("module_name").ToString)
                txt_datacredit_description.EditValue = .Item("description_text").ToString
                chk_row_visible.Checked = CBool(.Item("row_visible"))

                'guarda el estado del registro seleccionado
                source_current = trace_to_current(pnl_object_container)
            End With
        End If
    End Sub

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
                .CommandText = "settings_general_causal_edited"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.TinyInt).Value = record_affected
                .Parameters.Add("@causal_name", SqlDbType.VarChar, 50).Value = txt_causal_name.EditValue
                .Parameters.Add("@acronym", SqlDbType.VarChar, 5).Value = txt_causal_acronym.EditValue
                .Parameters.Add("@module_code", SqlDbType.TinyInt).Value = cmb_causal_module.EditValue
                .Parameters.Add("@causal_type", SqlDbType.Char, 1).Value = cmb_causal_type.EditValue
                .Parameters.Add("@description_text", SqlDbType.VarChar, 300).Value = DBNull.Value
                .Parameters.Add("@row_visible", SqlDbType.Bit).Value = chk_row_visible.Checked
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_edited(pnl_object_container, source_current)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If causal.execute_procedure = True Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class