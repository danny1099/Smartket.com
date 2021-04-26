Public Class settings_dealers_edited
    Private dealer As Dealers = Dealers.Instance
    Private operators As Operators = Operators.Instance
    Private source_current As DataTable
    Private record_affected As Integer

#Region "contructors"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        record_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'execute procedure to load sources and search current object
        object_listed()
        object_search()
    End Sub
    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_search()
        Dim table As DataTable = dealer.settings_dealers_search("Id=" & record_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                txt_dealer_name.EditValue = .Item("dealer_name").ToString
                cmb_dealer_operator.EditValue = cmb_dealer_operator.Properties.GetKeyValueByDisplayText(.Item("operator_name"))
                txt_dealer_external.EditValue = .Item("siesa_code").ToString
                chk_row_visible.Checked = CBool(.Item("row_visible"))

                'save data of current record
                source_current = trace_to_current(pnl_object_container)
            End With
        End If
    End Sub

    Private Sub object_listed()
        cmb_dealer_operator.Datasources(operators.settings_operators_search("row_visible=1"), "operator_name")
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With dealer.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_bussines_dealers_edited"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.TinyInt).Value = record_affected
                .Parameters.Add("@dealer_name", SqlDbType.VarChar, 50).Value = txt_dealer_name.EditValue
                .Parameters.Add("@operator_code", SqlDbType.TinyInt).Value = cmb_dealer_operator.EditValue
                .Parameters.Add("@siesa_code", SqlDbType.Char, 10).Value = If(txt_dealer_external.EditValue Is Nothing, DBNull.Value, txt_dealer_external.EditValue)
                .Parameters.Add("@row_visible", SqlDbType.Bit).Value = chk_row_visible.Checked
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_edited(pnl_object_container, source_current)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If dealer.execute_procedure = True Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class