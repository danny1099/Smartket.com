Public Class tasks_items_edited
    Private project As Projects = Projects.Instance
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
        'busca el registro seleccionado
        search_object()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_type_category.Datasources(project.task_category_search("row_visible=1"), "category_name")
    End Sub

    Private Sub search_object()
        Dim table As DataTable = project.task_items_search("Id=" & record_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                txt_type_name.EditValue = .Item("type_name").ToString
                txt_type_days.EditValue = .Item("term_days").ToString
                cmb_type_category.EditValue = cmb_type_category.Properties.GetKeyValueByDisplayText(.Item("category_name").ToString)
                chk_row_visible.Checked = CBool(.Item("row_visible"))

                'guarda el dato actual del registro seleccionado
                source_current = trace_to_current(pnl_object_container)
            End With
        End If
    End Sub

    Private Sub validate_name(sender As Object, e As EventArgs) Handles txt_type_name.EditValueChanged
        With txt_type_name.Properties
            .Buttons(0).Visible = If(Len(txt_type_name.EditValue) > 0, True, False)
        End With
    End Sub

    Private Sub validate_listed(sender As Object, e As EventArgs) Handles cmb_type_category.EditValueChanged
        With cmb_type_category.Properties
            .Buttons(1).Visible = If(cmb_type_category.EditValue IsNot Nothing, True, False)
        End With
    End Sub

    Private Sub validate_options(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_type_name.ButtonClick, cmb_type_category.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.OK Then
            objects_result("Seleccione el nombre de la categoria asociada y días de plazo*", False, True, True)

        ElseIf e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Left Then
            objects_result("Defina el nombre del tipo de tarea*", True, False, False)
        End If
    End Sub

    Private Sub objects_result(description_text As String, text_control As Boolean, listed_control As Boolean, other_control As Boolean)
        lbl_type_name.Text = description_text
        txt_type_name.Visible = text_control
        cmb_type_category.Visible = listed_control
        txt_type_days.Visible = other_control
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With project.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_projects_types_edited"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.TinyInt).Value = record_affected
                .Parameters.Add("@type_name", SqlDbType.VarChar, 50).Value = txt_type_name.EditValue
                .Parameters.Add("@category_code", SqlDbType.TinyInt).Value = cmb_type_category.EditValue
                .Parameters.Add("@term_days", SqlDbType.TinyInt).Value = txt_type_days.EditValue
                .Parameters.Add("@row_visible", SqlDbType.Bit).Value = chk_row_visible.EditValue
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_edited(pnl_object_container, source_current)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If project.execute_procedure = True Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class