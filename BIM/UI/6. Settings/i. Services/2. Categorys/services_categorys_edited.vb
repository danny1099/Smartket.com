Public Class services_categorys_edited
    Private category As Categorys = Categorys.Instance
    Private parameter As Parameters = Parameters.Instance
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
        search_object()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_category_segment.Datasources(parameter.settings_search_segments("row_visible=1"), "segment_name")
    End Sub

    Private Sub validate_name(sender As Object, e As EventArgs) Handles txt_category_name.EditValueChanged
        With txt_category_name.Properties
            .Buttons(0).Visible = If(Len(txt_category_name.EditValue) > 0, True, False)
        End With
    End Sub

    Private Sub validate_listed(sender As Object, e As EventArgs) Handles cmb_category_segment.EditValueChanged
        With cmb_category_segment.Properties
            .Buttons(1).Visible = If(cmb_category_segment.EditValue IsNot Nothing, True, False)
        End With
    End Sub

    Private Sub validate_options(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_category_name.ButtonClick, cmb_category_segment.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.OK Then
            objects_result("Seleccione el segmento de negocio de la categoria*", False, True)

        ElseIf e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Left Then
            objects_result("Defina el nombre de la categoria de producto*", True, False)
        End If
    End Sub

    Private Sub objects_result(description_text As String, text_control As Boolean, listed_control As Boolean)
        lbl_category_name.Text = description_text
        txt_category_name.Visible = text_control
        cmb_category_segment.Visible = listed_control
    End Sub

    Private Sub search_object()
        Dim table As DataTable = category.services_categorys_search("Id=" & record_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                txt_category_name.EditValue = .Item("category_name").ToString
                cmb_category_segment.EditValue = cmb_category_segment.Properties.GetKeyValueByDisplayText(.Item("segment_name").ToString)
                chk_row_visible.Checked = CBool(.Item("row_visible"))

                'save data of current record
                source_current = trace_to_current(pnl_object_container)
            End With
        End If
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With category.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_products_categorys_edited"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.TinyInt).Value = record_affected
                .Parameters.Add("@category_name", SqlDbType.VarChar, 50).Value = txt_category_name.EditValue
                .Parameters.Add("@segment_code", SqlDbType.TinyInt).Value = cmb_category_segment.EditValue
                .Parameters.Add("@row_visible", SqlDbType.Bit).Value = chk_row_visible.EditValue
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_edited(pnl_object_container, source_current)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If category.execute_procedure = True Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class