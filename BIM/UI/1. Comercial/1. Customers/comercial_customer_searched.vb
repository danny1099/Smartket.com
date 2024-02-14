Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class comercial_customer_searched
    Private customers As Customer = Customer.Instance
    Private attention As Attentions = Attentions.Instance
    Private wholesales As Sales = Sales.Instance
    Private financial As Financial = Financial.Instance
    Private source As DataTable
    Private criteria_condition As String
    Private process_name As String
    Private module_name As String
    Private record_affected As Integer

    'Campo de reconsulta
    Property curren_object As String

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()

        'apply all permits assigned per current module
        search_permits()
    End Sub

    Public Sub New(Optional row_selected As Integer = 0)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        record_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        listed_sources()
    End Sub
#End Region

#Region "behaviors"
    Private Sub search_permits()
        If sessions.admin_user <> 1 Then
            Dim table As DataTable = sessions.search_permission

            If table.Rows.Count > 0 Then
                With table
                    For Each options As Control In pnl_object_actions.Controls
                        If TypeOf options Is Button Then
                            If .Select("action_object='" & options.Name & "' and option_showed='" & Me.Name & "'").Count = 0 Then
                                options.Visible = False
                                pnl_object_flyout.Height = pnl_object_flyout.Height - 40
                            End If
                        End If
                    Next
                End With
            End If
        End If
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_close.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub listed_sources()
        cmb_search_field.Datasources(customers.comercial_customer_fieldsearchs, "type_search")
    End Sub

    Private Sub clean_fields()
        'limpia todos los campos recorriendo los paneles
        For Each panel As Object In pnl_search_left.Controls
            If TypeOf panel Is PanelControl Then
                For Each text_object As Object In panel.Controls
                    If TypeOf text_object Is APDA.Object.Controls.TextboxEdit Or TypeOf text_object Is DevExpress.XtraEditors.MemoExEdit Or TypeOf text_object Is DevExpress.XtraEditors.TokenEdit Then
                        text_object.EditValue = Nothing
                    ElseIf TypeOf text_object Is APDA.Object.Controls.TextboxCheck Then
                        text_object.Checked = False
                    End If
                Next
            End If
        Next

        'clean data of grids and total values
        dgv_grid_result.DataSource = Nothing
        dgv_grid_objects.DataSource = Nothing
        dgv_view_results.Columns.Clear()
        dgv_view_objects.Columns.Clear()

        'clean datatables to next use
        If source IsNot Nothing Then source.Rows.Clear()
        If source IsNot Nothing Then source.DefaultView.RowFilter = Nothing
    End Sub


    'methods to show options in selected row
    Private Sub option_column()
        If dgv_view_results.RowCount > 0 Then
            Dim column_option As GridColumn = dgv_view_results.Columns.AddVisible("column_option")

            With column_option
                .UnboundType = DevExpress.Data.UnboundColumnType.Object
                .ColumnEdit = rpt_picture_option
                .ImageOptions.Image = My.Resources.options_settings
                .ImageOptions.Alignment = StringAlignment.Center
                .FieldName = "Opciones"
                .AppearanceHeader.ForeColor = Color.DarkGray
                .Width = 40
                .MaxWidth = 40
                .MinWidth = 40
                .VisibleIndex = 0
            End With
        End If
    End Sub

    Private Sub options_show(sender As Object, e As RowClickEventArgs) Handles dgv_view_results.RowClick
        If dgv_view_results.IsRowSelected(e.RowHandle) = True Then
            Dim hi As GridHitInfo = dgv_view_results.CalcHitInfo(e.Location)
            If hi.InRowCell Then
                Dim column As GridColumn = hi.Column
                If column.FieldName = "Opciones" Then
                    pnl_object_flyout.HidePopup()
                    pnl_object_flyout.Options.Location = If(hi.HitPoint.Y >= 100, New Point(hi.HitPoint.X, 1), hi.HitPoint)
                    pnl_object_flyout.ShowPopup(True)
                End If
            End If
        End If
    End Sub

    Private Sub selected_resumen(sender As Object, e As EventArgs) Handles dgv_view_results.DoubleClick
        If dgv_view_results.IsRowSelected(dgv_view_results.FocusedRowHandle) = True Then
            show_option(New comercial_customer_resume(dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id"), Me))
        End If
    End Sub

    Private Sub count_rows(sender As Object, e As EventArgs) Handles dgv_view_results.ColumnFilterChanged
        lbl_count_results.Text = dgv_view_results.RowCount.ToString
    End Sub

    Private Sub selected_changed(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles dgv_view_results.SelectionChanged
        selected_customer(dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id"))
    End Sub

    Private Sub changes_columns()
        If dgv_view_results.RowCount > 0 Then
            With dgv_view_results
                'hide columns innecesary
                .Columns("row_visible").Visible = False
                .Columns("alias_document").Visible = False
                .Columns("genre_name").Visible = False
                .Columns("birth_date").Visible = False
                .Columns("email").Visible = False
                .Columns("creation_date").Visible = False
                .Columns("opt_in").Visible = False
                .Columns("photo_avatar").Visible = False
                .Columns("opt_favorite").Visible = False
                .Columns("source_name").Visible = False
                .Columns("knowledge_name").Visible = False
                .Columns("number_phone").Visible = False
                .Columns("number_cellphone").Visible = False
                .Columns("place_address").Visible = False
                .Columns("neighborhood").Visible = False
                .Columns("city_name").Visible = False
                .Columns("department_name").Visible = False
                .Columns("refered_code").Visible = False
                .Columns("refered_name").Visible = False
                .Columns("person_seller").Visible = False
                .Columns("person_code").Visible = False
                .Columns("pc_name").Visible = False
                .Columns("wwid_user").Visible = False
                .Columns("ethernet_address").Visible = False
                .Columns("physical_address").Visible = False
                .Columns("work_session").Visible = False
                .Columns("trace_number").Visible = False
                .Columns("edit_person").Visible = False
                .Columns("user_access").Visible = False
                .Columns("timespan_date").Visible = False
                .Columns("credit_limit").Visible = False

                'Change caption of columns visibles
                .Columns("person_name").Caption = "Nombre de cliente"
                .Columns("number_document").Caption = "Documento"
                .Columns("code_search").Caption = "WWID"
                .Columns("status_current").Caption = "Estado"
                .Columns("agency_name").Caption = "Agencia"
                .Columns("user_create").Caption = "Usuario Creador"
                .Columns("event_date").Caption = "Fecha de registro"
                .Columns("status_current").Caption = "Estado"
                .Columns("credit_score").Caption = "Puntaje"
            End With
        End If
    End Sub


    'methods to search sales and others objects results
    Private Sub search_text(sender As Object, e As KeyEventArgs) Handles txt_search_criteria.KeyDown
        If (e.KeyData = Keys.Enter) = True Then
            If cmb_search_field.Text = "All Contents" Then search_customer("c.number_document='" & txt_search_criteria.Text & "' or c.number_cellphone='" & txt_search_criteria.Text & "' or c.code_search='" & txt_search_criteria.Text & "'") Else search_customer(cmb_search_field.EditValue & txt_search_criteria.Text & "'")
        End If
    End Sub

    Private Sub find_text(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_search_criteria.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Search Then
            If cmb_search_field.Text = "All Contents" Then search_customer("c.number_document='" & txt_search_criteria.Text & "' or c.number_cellphone='" & txt_search_criteria.Text & "' or c.code_search='" & txt_search_criteria.Text & "'") Else search_customer(cmb_search_field.EditValue & txt_search_criteria.Text & "'")
        End If
    End Sub

    Private Sub search_customer(criteria_search As String)
        'clean all fields to set new data
        clean_fields()

        'get sale with condition criteria
        source = customers.comercial_customer_search(criteria_search)
        criteria_condition = criteria_search

        'check if table has rows in table sources
        If source.Rows.Count > 0 Then
            'define el origen de datos al grid control
            dgv_grid_result.DataSource = source

            'parametriza las columnas de la vista
            With dgv_view_results
                .Columns("Id").Visible = False
                .SelectRow(0)

                'set parameters of columns and hiden columns
                option_column()
                changes_columns()

                'set total of registre in label lbl_count
                .BestFitColumns(True)
                lbl_count_results.Text = .RowCount.ToString
            End With
        Else
            If message_text("No se encontró datos coincidentes, Desea crear el cliente?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                show_option(New comercial_customer_create(Me))
            End If
        End If
    End Sub

    Private Sub selected_customer(row_selected As Integer)
        'filter data row with condition criteria
        Dim row_view() As DataRow = source.Select("Id=" & row_selected)
        Dim token_array As String = String.Empty

        'check if datarow has item
        If row_view IsNot Nothing Then
            With row_view(0)
                record_affected = .Item("Id").ToString()
                txt_search_customer.EditValue = .Item("person_name").ToString()
                txt_search_document.EditValue = .Item("number_document").ToString()
                txt_search_birthdate.EditValue = If(.Item("birth_date").ToString() = "", "This field is not defined", CDate(.Item("birth_date").ToString()).ToLongDateString)
                txt_search_phone.EditValue = .Item("number_phone")
                txt_search_cellphone.EditValue = .Item("number_cellphone")
                txt_search_email.EditValue = .Item("email").ToString()
                txt_search_address.EditValue = .Item("place_address").ToString()
                txt_search_neighborhood.EditValue = .Item("neighborhood").ToString()
                txt_search_city.EditValue = .Item("city_name").ToString()
                txt_search_depto.EditValue = .Item("department_name").ToString()
                txt_search_source.EditValue = .Item("source_name").ToString()
                txt_search_knowledge.EditValue = .Item("knowledge_name").ToString()
                txt_search_person.EditValue = .Item("person_seller").ToString()
                txt_search_refered.EditValue = If(.Item("refered_name").ToString() = "", "This field is not defined", .Item("refered_name").ToString())
                txt_search_created.EditValue = If(.Item("creation_date").ToString() = "", "This field is not defined", CDate(.Item("creation_date").ToString()).ToLongDateString)
                txt_search_quotas.EditValue = Format(.Item("credit_limit"), "c0")

                'info data of tracing
                txt_search_username.EditValue = .Item("user_create").ToString()
                txt_search_widuser.EditValue = If(.Item("wwid_user").ToString() = "", "WID00000", "WID" & CInt(.Item("wwid_user")).ToString("D5"))
                txt_search_datestamp.EditValue = .Item("event_date").ToString()
                txt_search_timestamp.EditValue = .Item("timespan_date").ToString() & " | " & .Item("user_access").ToString()
                txt_search_trancing.EditValue = If(.Item("trace_number").ToString() = "No data found in trace", .Item("trace_number").ToString(), "TN" & .Item("trace_number").ToString())
                txt_search_ipaddress.EditValue = If(.Item("ethernet_address").ToString() = "", "No data found in trace", .Item("ethernet_address").ToString() & " [" & .Item("physical_address").ToString() & "]")
                txt_search_terminal.EditValue = If(.Item("pc_name").ToString() = "", "No data found in trace", .Item("pc_name").ToString())
                txt_search_session.EditValue = If(.Item("work_session").ToString() = "", "WSID00000", "WSID" & CInt(.Item("work_session")).ToString("D5"))

                'check if field special with condition
                If .Item("opt_in").ToString() = "True" Then chk_search_optin.Checked = True Else chk_search_optin.Checked = False
            End With
        End If
    End Sub
#End Region

#Region "options"
    Private Sub edited_option(sender As Object, e As EventArgs) Handles btn_object_edit.Click
        If dgv_view_results.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea modificar el registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                show_option(New comercial_customer_edited(dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id"), Me))
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub transfer_option(sender As Object, e As EventArgs) Handles btn_object_transfer.Click
        If dgv_view_results.RowCount > 0 Then
            If message_text("Está seguro que desea transferir el registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim rows_selected As New List(Of Integer)

                For i As Integer = 0 To dgv_view_results.DataRowCount - 1
                    If dgv_view_results.IsRowSelected(i) = True Then
                        rows_selected.Add(CInt(dgv_view_results.GetRowCellValue(i, "Id")))
                    End If
                Next

                If rows_selected.Count > 0 Then
                    Using new_ As New comercial_customer_transfer(rows_selected)
                        new_.ShowDialog(start_home)
                    End Using

                    'update listed with changes applied
                    search_customer(criteria_condition)
                Else
                    message_text("No se detectó filas seleccionadas", MessageBoxButtons.OK)
                End If
            End If
        End If
    End Sub

    Private Sub quotas_option(sender As Object, e As EventArgs) Handles btn_object_quotas.Click
        If dgv_view_results.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea asignar un cupo de crédito al cliente seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using new_ As New comercial_customer_quotas(dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id"))
                    new_.ShowDialog(start_home)
                End Using
            End If
        End If
    End Sub

    Private Sub resumed_option(sender As Object, e As EventArgs) Handles btn_object_resume.Click
        If dgv_view_results.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea ver el resumen del registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                show_option(New comercial_customer_resume(dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id"), Me))
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub attention_option(sender As Object, e As EventArgs) Handles btn_object_attention.Click
        If dgv_view_results.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea ver crear una gestión comercial al registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                show_option(New comercial_attention_created(dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id")))
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub follow_option(sender As Object, e As EventArgs) 
        If dgv_view_results.RowCount > 0 Then
            If message_text("Está seguro que desea crear un seguimiento a los registros seleccionados?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                For i As Integer = 0 To dgv_view_results.DataRowCount - 1
                    If dgv_view_results.IsRowSelected(i) = True Then
                        customers.comercial_customer_follow(dgv_view_results.GetRowCellValue(i, "Id"), False)
                    End If
                Next

                'return message to end process
                If message_text("Los registros seleccionados fueron anulados exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then search_customer(criteria_condition)
            End If
        End If
    End Sub

    Private Sub synchronize_option(sender As Object, e As EventArgs) Handles btn_update_results.Click
        search_customer(criteria_condition)
    End Sub

    Private Sub exported_option(sender As Object, e As EventArgs) Handles btn_export_results.Click
        If dgv_view_results.RowCount > 0 Then
            Using export As New model_object_export(dgv_view_results)
                export.ShowDialog(start_home)
            End Using
        End If
    End Sub

    Private Sub printer_option(sender As Object, e As EventArgs) Handles btn_print_results.Click
        If dgv_view_results.RowCount > 0 Then
            dgv_view_results.ShowPrintPreview()
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_close.Click
        start_home.removed_tabbed()
    End Sub
#End Region

#Region "helpers"
    Private Sub selected_process(sender As Object, e As EventArgs) Handles lbl_options_wholesales.Click, lbl_options_quotas.Click, lbl_options_balances.Click, lbl_object_attention.Click
        reports_show(search_data(sender.name))
    End Sub

    Private Function search_data(process_name As String) As DataTable
        Select Case process_name
            Case "lbl_options_wholesales" : Return wholesales.wholesale_sales_show("s.customer_code=" & record_affected & "and s.row_visible in (1,3)")
            Case "lbl_object_attention" : Return attention.commercial_attention_show("t.customer_code=" & record_affected & " and t.row_visible=1")
            Case "lbl_options_quotas" : Return financial.financial_credits_search("c.customer_code=" & record_affected & " and c.row_visible=1")
            Case "lbl_options_balances" : Return customers.comercial_customer_credits("c.Id=" & record_affected & " and b.row_visible=1")
        End Select

        Throw New ArgumentException
    End Function

    Private Sub reports_show(source As DataTable)
        'limpia los origenes de datos anteriores
        dgv_grid_objects.DataSource = Nothing
        dgv_view_objects.Columns.Clear()
        lbl_count_objects.Text = 0

        'comprueba si la consulta tiene filas para mostrar
        If source.Rows.Count > 0 Then
            'define el origen de datos al grid control
            dgv_grid_objects.DataSource = source

            'parametriza las columnas de la vista
            With dgv_view_objects
                .Columns("Id").Visible = False
                .BestFitColumns(True)
                .SelectRow(0)

                'check if total column are less to change view column
                lbl_count_objects.Text = If(.Columns("Pago Total") IsNot Nothing, total_sales(), .RowCount.ToString)

                'check if column cotizaciones exist to alignment to center
                If .Columns("Cotizaciones") IsNot Nothing Then .Columns("Cotizaciones").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                'check if columng comentario exists to change columnd and row size
                With dgv_view_objects
                    If .Columns("Comentario") IsNot Nothing Then .Columns("Comentario").ColumnEdit = txt_memo_edit
                    If .Columns("Comentario") IsNot Nothing Then .Columns("Comentario").Width = 400
                    If .Columns("Comentario") IsNot Nothing Then .RowHeight = 50
                    If .Columns("Comentario") IsNot Nothing Then .Columns("Comentario").AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
                End With
            End With
        End If
    End Sub

    Private Function total_sales() As String
        Dim value_total As Double = 0

        For i As Integer = 0 To dgv_view_results.DataRowCount
            If dgv_view_results.GetRowCellValue(i, "Pago Total") >= 0 Then
                value_total += CDbl(Replace(Replace(Replace(dgv_view_results.GetRowCellValue(i, "Pago Total"), ".", ""), "$", ""), "- ", "-"))
            End If
        Next

        Return FormatCurrency((value_total), 0)
    End Function
#End Region
End Class
