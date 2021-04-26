Public Class settings_positions_edited
    Private position As Positions = Positions.Instance
    Private source_current As DataTable
    Private record_affected As Integer

#Region "contructors"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'define el valor del parametro en la variable
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
    Private Sub object_listed()
        cmb_position_query.Datasources(position.settings_positions_query, "query_level")
    End Sub

    Private Sub object_search()
        Dim table As DataTable = position.settings_position_search("Id=" & record_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                txt_position_name.EditValue = .Item("position_name").ToString
                cmb_position_query.EditValue = .Item("query_level").ToString
                chk_row_visible.Checked = CBool(.Item("row_visible"))

                'save data of current record
                source_current = trace_to_current(pnl_object_container)
            End With
        End If
    End Sub

    Private Sub validate_name(sender As Object, e As EventArgs) Handles txt_position_name.EditValueChanged
        With txt_position_name.Properties
            .Buttons(0).Visible = If(Len(txt_position_name.EditValue) > 0, True, False)
        End With
    End Sub

    Private Sub validate_listed(sender As Object, e As EventArgs) Handles cmb_position_query.EditValueChanged
        With cmb_position_query.Properties
            .Buttons(1).Visible = If(cmb_position_query.EditValue IsNot Nothing, True, False)
        End With
    End Sub

    Private Sub validate_options(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_position_name.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.OK Then
            objects_result("Seleccione el nivel de consulta del cargo*", False, True)

        ElseIf e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Left Then
            objects_result("Defina el nombre del nuevo cargo de funcionario*", True, False)
        End If
    End Sub

    Private Sub objects_result(description_text As String, text_control As Boolean, listed_control As Boolean)
        lbl_position_name.Text = description_text
        txt_position_name.Visible = text_control
        cmb_position_query.Visible = listed_control
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With position.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_bussines_positions_edited"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.TinyInt).Value = record_affected
                .Parameters.Add("@position_name", SqlDbType.VarChar, 50).Value = StrConv(txt_position_name.EditValue, VbStrConv.ProperCase)
                .Parameters.Add("@query_level", SqlDbType.Char, 1).Value = cmb_position_query.EditValue
                .Parameters.Add("@row_visible", SqlDbType.Bit).Value = chk_row_visible.Checked
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_edited(pnl_object_container, source_current)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If position.execute_procedure = True Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class