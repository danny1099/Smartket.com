Public Class commision_tables_edited
    Private scheme As Schemes = Schemes.Instance
    Private channel As Channels = Channels.Instance
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
    Private Sub object_listed()
        cmb_table_channel.Datasources(channel.settings_channels_search("row_visible=1"), "channel_name")
    End Sub

    Private Sub object_search()
        Dim table As DataTable = scheme.commision_tables_search("Id=" & record_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                txt_table_name.EditValue = .Item("table_commision").ToString
                cmb_table_channel.EditValue = cmb_table_channel.Properties.GetKeyValueByDisplayText(.Item("channel_name").ToString)
                chk_row_visible.Checked = CBool(.Item("row_visible"))

                'save data of current record
                source_current = trace_to_current(pnl_object_container)
            End With
        End If
    End Sub

    Private Sub validate_name(sender As Object, e As EventArgs) Handles txt_table_name.EditValueChanged
        With txt_table_name.Properties
            .Buttons(0).Visible = If(Len(txt_table_name.EditValue) > 0, True, False)
        End With
    End Sub

    Private Sub validate_listed(sender As Object, e As EventArgs) Handles cmb_table_channel.EditValueChanged
        With cmb_table_channel.Properties
            .Buttons(1).Visible = If(cmb_table_channel.EditValue IsNot Nothing, True, False)
        End With
    End Sub

    Private Sub validate_options(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_table_name.ButtonClick, cmb_table_channel.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.OK Then
            objects_result("Seleccione el nombre del canal de ventas*", False, True)

        ElseIf e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Left Then
            objects_result("Defina el nombre de la tabla de comisión*", True, False)
        End If
    End Sub

    Private Sub objects_result(description_text As String, text_control As Boolean, listed_control As Boolean)
        lbl_table_name.Text = description_text
        txt_table_name.Visible = text_control
        cmb_table_channel.Visible = listed_control
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With scheme.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "commision_scheme_table_edited"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.SmallInt).Value = record_affected
                .Parameters.Add("@table_name", SqlDbType.VarChar, 50).Value = txt_table_name.EditValue
                .Parameters.Add("@channel_code", SqlDbType.TinyInt).Value = cmb_table_channel.EditValue
                .Parameters.Add("@row_visible", SqlDbType.Bit).Value = chk_row_visible.Checked
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_edited(pnl_object_container, source_current)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If scheme.execute_procedure = True Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class