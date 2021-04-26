Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class wholesales_masters_details
    Private sales As Sales = Sales.Instance
    Private request As Request = Request.Instance
    Private general As Parameters = Parameters.Instance
    Private audited As Audited = Audited.Instance
    Private notes As Notes = Notes.Instance
    Private commision As Commision = Commision.Instance
    Private source As DataTable
    Private criteria_condition As String
    Private process_name As String
    Private module_name As String
    Private record_affected As Integer

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
        'load report to show data in grid
        listed_sources()

        'check if record affected parameter is not equal 0
        If record_affected <> 0 Then search_sale("s.Id=" & record_affected)
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
        cmb_search_field.Datasources(general.settings_search_searchable, "type_search")
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

        'change properties some fields dinamic
        pnl_search_equipment.Size = pnl_search_equipment.MinimumSize

        'change text from dinamic fields
        lbl_search_services.Text = "Nombre del plan:"
        lbl_search_serial1.Text = "MIN"
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

    Private Sub count_rows(sender As Object, e As EventArgs) Handles dgv_view_results.ColumnFilterChanged
        lbl_count_results.Text = dgv_view_results.RowCount.ToString
    End Sub

    Private Sub selected_changed(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles dgv_view_results.SelectionChanged
        values_sale(dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id"))
    End Sub

    Private Sub changes_columns()
        If dgv_view_results.RowCount > 0 Then
            With dgv_view_results
                'hide columns innecesary
                .Columns("date_reception").Visible = False
                .Columns("services_array").Visible = False
                .Columns("product_code1").Visible = False
                .Columns("product_code2").Visible = False
                .Columns("services_info").Visible = False
                .Columns("type_sale").Visible = False
                .Columns("number_serial2").Visible = False
                .Columns("number_serial3").Visible = False
                .Columns("value_sales1").Visible = False
                .Columns("value_sales2").Visible = False
                .Columns("mark_ported").Visible = False
                .Columns("mark_migration").Visible = False
                .Columns("mark_convergent").Visible = False
                .Columns("customer_code").Visible = False
                .Columns("person_code").Visible = False
                .Columns("leader_name").Visible = False
                .Columns("leader_code").Visible = False
                .Columns("stratum_name").Visible = False
                .Columns("quotas_name").Visible = False
                .Columns("status_code").Visible = False
                .Columns("status_name").Visible = False
                .Columns("capture_code").Visible = False
                .Columns("row_visible").Visible = False
                .Columns("number_document").Visible = False
                .Columns("birth_date").Visible = False
                .Columns("email").Visible = False
                .Columns("creation_date").Visible = False
                .Columns("opt_in").Visible = False
                .Columns("source_name").Visible = False
                .Columns("number_phone").Visible = False
                .Columns("number_cellphone").Visible = False
                .Columns("place_address").Visible = False
                .Columns("neighborhood").Visible = False
                .Columns("city_name").Visible = False
                .Columns("department_name").Visible = False
                .Columns("pc_name").Visible = False
                .Columns("ethernet_address").Visible = False
                .Columns("physical_address").Visible = False
                .Columns("work_session").Visible = False
                .Columns("writed_name").Visible = False
                .Columns("timespan_date").Visible = False
                .Columns("user_access").Visible = False
                .Columns("json_products").Visible = False

                'Change caption of columns visibles
                .Columns("segment_name").Caption = "Segmento"
                .Columns("date_sale").Caption = "Fecha de venta"
                .Columns("number_serial1").Caption = "Numero de venta"
                .Columns("dealer_name").Caption = "Distribuidor"
                .Columns("operator_name").Caption = "Operador"
                .Columns("number_contract").Caption = "Numero de contrato"
                .Columns("number_invoice").Caption = "Factura"
                .Columns("person_name").Caption = "Nombre de consultor"
                .Columns("code_search").Caption = "WWID"
                .Columns("agency_name").Caption = "Agencia"
                .Columns("channel_name").Caption = "Canal de ventas"
                .Columns("customer_name").Caption = "Nombre del cliente"
                .Columns("user_create").Caption = "Usuario Creador"
                .Columns("event_date").Caption = "Fecha de registro"
                .Columns("status_validate").Caption = "Estado"
                .Columns("value_import").Caption = "Valor de importe"
                .Columns("mark_migration").Caption = "CFM Anticipado"
            End With
        End If
    End Sub


    'methods to search sales and others objects results
    Private Sub search_text(sender As Object, e As KeyEventArgs) Handles txt_search_criteria.KeyDown
        If (e.KeyData = Keys.Enter) = True Then
            If cmb_search_field.Text = "All Contents" Then search_sale("s.number_serial1='" & txt_search_criteria.Text & "' or s.number_serial2='" & txt_search_criteria.Text & "' or s.number_serial3='" & txt_search_criteria.Text & "' or s.number_contract='" & txt_search_criteria.Text & "'  or c.number_document='" & txt_search_criteria.Text & "' or e.code_search='" & txt_search_criteria.Text & "'") Else search_sale(cmb_search_field.EditValue & txt_search_criteria.Text & "'")
        End If
    End Sub

    Private Sub find_text(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_search_criteria.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Search Then
            If cmb_search_field.Text = "All Contents" Then search_sale("s.number_serial1='" & txt_search_criteria.Text & "' or s.number_serial2='" & txt_search_criteria.Text & "' or s.number_serial3='" & txt_search_criteria.Text & "' or s.number_contract='" & txt_search_criteria.Text & "'  or c.number_document='" & txt_search_criteria.Text & "' or e.code_search='" & txt_search_criteria.Text & "'") Else search_sale(cmb_search_field.EditValue & txt_search_criteria.Text & "'")
        End If
    End Sub

    Private Sub search_sale(criteria_search As String)
        'clean all fields to set new data
        clean_fields()

        'get sale with condition criteria
        source = sales.wholesale_sales_search(criteria_search)
        criteria_condition = criteria_search

        'check if table has rows in table sources
        If source.Rows.Count > 0 Then
            'check if parameter is not 0 to set serial1 en condition search
            If record_affected <> 0 Then txt_search_criteria.EditValue = source.Rows(0).Item("number_serial1").ToString

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
            message_text("No se encontró datos coincidentes", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub values_sale(row_selected As Integer)
        'clean all fields to set new data
        txt_search_services.EditValue = Nothing

        'filter data row with condition criteria
        Dim row_view() As DataRow = source.Select("Id=" & row_selected)
        Dim token_array As String = String.Empty

        'check if datarow has item
        If row_view IsNot Nothing Then
            With row_view(0)
                'info data customer
                record_affected = .Item("Id").ToString()
                txt_search_customer.EditValue = .Item("customer_name").ToString()
                txt_search_document.EditValue = .Item("number_document").ToString()
                txt_search_birthdate.EditValue = If(.Item("birth_date").ToString() = "", "This field is not defined", CDate(.Item("birth_date").ToString()).ToLongDateString)
                txt_search_phone.EditValue = .Item("number_phone")
                txt_search_cellphone.EditValue = .Item("number_cellphone")
                txt_search_email.EditValue = .Item("email").ToString()
                txt_search_address.EditValue = .Item("place_address").ToString() & ", " & .Item("neighborhood").ToString()
                txt_search_city.EditValue = .Item("city_name").ToString() & ", " & .Item("department_name").ToString()
                txt_search_source.EditValue = .Item("source_name").ToString()
                txt_search_created.EditValue = If(.Item("creation_date").ToString() = "", "This field is not defined", CDate(.Item("creation_date").ToString()).ToLongDateString)

                'info data of sales
                txt_search_seller.EditValue = .Item("person_name").ToString()
                txt_search_agency.EditValue = .Item("agency_name").ToString()
                txt_search_wwid.EditValue = "WID" & .Item("code_search").ToString()
                txt_search_dealer.EditValue = .Item("dealer_name").ToString() & ", " & .Item("operator_name").ToString()
                txt_search_segment.EditValue = .Item("segment_name").ToString()
                txt_search_channel.EditValue = .Item("channel_name").ToString()
                txt_search_leader.EditValue = .Item("leader_name").ToString()

                txt_search_serial1.EditValue = .Item("number_serial1").ToString()
                txt_search_date.EditValue = CDate(.Item("date_sale"))
                txt_search_value1.EditValue = FormatCurrency(.Item("value_sales1"), 0)
                txt_search_type.EditValue = .Item("type_sale").ToString()
                txt_search_serial2.EditValue = .Item("number_serial2").ToString()
                txt_search_legalized.EditValue = If(.Item("date_reception").ToString = "", "This field is not defined", CDate(.Item("date_reception").ToString))
                txt_search_contract.EditValue = .Item("number_contract").ToString()
                txt_search_numbill.EditValue = .Item("number_invoice").ToString()
                txt_search_status.EditValue = .Item("status_name").ToString()
                txt_search_serial3.EditValue = .Item("number_serial3").ToString()
                txt_search_value2.EditValue = FormatCurrency(.Item("value_sales2"), 0)

                'info data of tracing
                txt_search_username.EditValue = .Item("user_create").ToString()
                txt_search_datestamp.EditValue = .Item("event_date").ToString()
                txt_search_timestamp.EditValue = .Item("timespan_date").ToString() & "(" & .Item("user_access").ToString() & ")"
                txt_search_ipaddress.EditValue = If(.Item("ethernet_address").ToString() = "", "No data found in trace", .Item("ethernet_address").ToString() & " [" & .Item("physical_address").ToString() & "]")
                txt_search_terminal.EditValue = If(.Item("pc_name").ToString() = "", "No data found in trace", .Item("pc_name").ToString())
                txt_search_session.EditValue = If(.Item("work_session").ToString() = "", "WSID00000", "WSID" & CInt(.Item("work_session")).ToString("D5"))

                'check if field special with condition
                If .Item("opt_in").ToString() = "True" Then chk_search_optin.Checked = True Else chk_search_optin.Checked = False
                If .Item("date_reception").ToString() = "" Then txt_search_legalized.EditValue = "This field is not defined"
                If .Item("segment_name").ToString() = "Hogar" Then txt_search_serial2.EditValue = "This field is not required"
                If .Item("segment_name").ToString() = "Libres" Then txt_search_serial2.EditValue = "This field is not required"
                If .Item("segment_name").ToString() = "Libres" Then txt_search_serial3.EditValue = .Item("number_serial1").ToString()
                If .Item("segment_name").ToString() = "Libres" Then txt_search_type.EditValue = "This field is not required"

                If .Item("mark_migration").ToString() = "1" Then token_array += If(token_array = "", "mark_migration", ",mark_migration")
                If .Item("mark_ported").ToString() = "1" Then token_array += If(token_array = "", "mark_ported", ",mark_ported")
                If .Item("mark_convergent").ToString() = "1" Then token_array += If(token_array = "", "mark_convergent", ",mark_convergent")
                If .Item("stratum_name").ToString() <> "Undefined" Then token_array += If(token_array = "", .Item("stratum_name").ToString(), "," & .Item("stratum_name").ToString())
                If token_array <> "" Then txt_search_properties.EditValue = token_array

                'check services array and put on plan and equipment
                With fn_transform_deserialize(.Item("services_info").ToString)
                    If .Rows.Count > 0 Then
                        For i As Integer = 0 To .Rows.Count - 1
                            If .Rows(i).Item("product_type").ToString = "Planes y Servicios" Then txt_search_services.EditValue += .Rows(i).Item("product_name").ToString & vbCrLf
                            If .Rows(i).Item("product_type").ToString = "Planes y Servicios" Then txt_search_type.EditValue = .Rows(i).Item("category_name").ToString
                            If .Rows(i).Item("product_type").ToString = "Accesorios y Otros" Then txt_search_services.EditValue += .Rows(i).Item("product_name").ToString & vbCrLf
                            If .Rows(i).Item("product_type").ToString = "Accesorios y Otros" Then txt_search_type.EditValue = .Rows(i).Item("category_name").ToString
                            If .Rows(i).Item("product_type").ToString = "Television y Audio" Then txt_search_services.EditValue += .Rows(i).Item("product_name").ToString & vbCrLf
                            If .Rows(i).Item("product_type").ToString = "Television y Audio" Then txt_search_type.EditValue = .Rows(i).Item("category_name").ToString

                            If .Rows(i).Item("product_type").ToString = "Equipos de telefonía" Then txt_search_services.EditValue += .Rows(i).Item("product_name").ToString & vbCrLf
                            If .Rows(i).Item("product_type").ToString = "Equipos de telefonía" Then txt_search_equipment.EditValue = .Rows(i).Item("product_name").ToString
                            If .Rows(i).Item("product_type").ToString = "Equipos de telefonía" Then txt_search_brand.EditValue = .Rows(i).Item("brand_name").ToString
                            If .Rows(i).Item("product_type").ToString = "Equipos de telefonía" Then pnl_search_equipment.Size = pnl_search_equipment.MaximumSize Else pnl_search_equipment.Size = pnl_search_equipment.MinimumSize
                        Next
                    End If
                End With

                'set text of special fields
                If .Item("segment_name").ToString() = "Movil" Then lbl_search_services.Text = "Nombre del plan:"
                If .Item("segment_name").ToString() = "Hogar" Then lbl_search_services.Text = "Servicios Instalados:"
                If .Item("segment_name").ToString() = "Libres" Then lbl_search_services.Text = "Nombre del producto:"
                If .Item("segment_name").ToString() = "Movil" Then lbl_search_serial1.Text = "MIN"
                If .Item("segment_name").ToString() = "Hogar" Then lbl_search_serial1.Text = "Cuenta"
                If .Item("segment_name").ToString() = "Libres" Then lbl_search_serial1.Text = "Numero de serial"
                If .Item("segment_name").ToString() = "Hogar" Then txt_search_type.EditValue = .Item("type_sale").ToString()
                If .Item("segment_name").ToString() = "Libres" And txt_search_services.EditValue Is Nothing Then txt_search_services.EditValue = "Equipos y Accesorios"
            End With
        End If
    End Sub
#End Region

#Region "options"
    Private Sub edited_option(sender As Object, e As EventArgs) Handles btn_object_edit.Click
        If dgv_view_results.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea modificar el registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Select Case (dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "segment_name"))
                    Case "Movil" : show_option(New wholesales_movil_edited(dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id"), Me))
                    Case "Hogar" : show_option(New wholesales_hogar_edited(dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id"), Me))
                    Case "Libres" : show_option(New wholesales_frees_edited(dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id"), Me))
                End Select
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub erased_option(sender As Object, e As EventArgs) Handles btn_object_erase.Click
        If dgv_view_results.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea anular el registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If sales.wholesale_sales_erase(dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id"), CInt(sender.Tag.ToString)) Then
                    search_sale(criteria_condition)
                End If
            End If
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
                    Using new_ As New wholesales_masters_transfer(rows_selected)
                        new_.ShowDialog(start_home)
                    End Using

                    'update listed with changes applied
                    search_sale(criteria_condition)
                Else
                    message_text("No se detectó filas seleccionadas", MessageBoxButtons.OK)
                End If
            End If
        End If
    End Sub

    Private Sub completed_option(sender As Object, e As EventArgs) Handles btn_object_complete.Click
        If dgv_view_results.RowCount > 0 Then
            If message_text("Está seguro que desea transferir el registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim rows_selected As New List(Of Integer)

                For i As Integer = 0 To dgv_view_results.DataRowCount - 1
                    If dgv_view_results.IsRowSelected(i) = True Then
                        rows_selected.Add(CInt(dgv_view_results.GetRowCellValue(i, "Id")))
                    End If
                Next

                If rows_selected.Count > 0 Then
                    Using new_ As New wholesales_masters_complete(rows_selected)
                        new_.ShowDialog(start_home)
                    End Using

                    'update listed with changes applied
                    search_sale(criteria_condition)
                Else
                    message_text("No se detectó filas seleccionadas", MessageBoxButtons.OK)
                End If
            End If
        End If
    End Sub

    Private Sub status_option(sender As Object, e As EventArgs) Handles btn_object_include.Click, btn_object_exclude.Click
        If dgv_view_results.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea cambiar el estado al registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If sales.wholesale_sales_status(dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id"), CInt(sender.tag.ToString)) Then
                    search_sale(criteria_condition)
                End If
            End If
        End If
    End Sub

    Private Sub validate_option(sender As Object, e As EventArgs) Handles btn_object_validate.Click
        If dgv_view_results.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea validar el registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If sales.wholesale_sales_erase(dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id"), 1) Then
                    search_sale(criteria_condition)
                End If
            End If
        End If
    End Sub

    Private Sub requested_option(sender As Object, e As EventArgs) Handles btn_object_request.Click
        If dgv_view_results.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea registrar una solicitud de modificación al registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                show_option(New wholesales_request_create(dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id")))
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub noted_option(sender As Object, e As EventArgs) Handles btn_object_notes.Click
        If dgv_view_results.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea crear una nota al registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using new_ As New model_object_notes("Wholesales.Masters.Sales", dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id"), Me.Tag.ToString)
                    new_.ShowDialog(start_home)
                End Using
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub synchronize_option(sender As Object, e As EventArgs) Handles btn_update_results.Click
        search_sale(criteria_condition)
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
    Private Sub helper_column()
        If dgv_view_objects.RowCount > 0 Then
            Dim column_option As GridColumn = dgv_view_objects.Columns.AddVisible("column_option")

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

    Private Sub helper_field(sender As Object, e As RowClickEventArgs) Handles dgv_view_objects.RowClick
        If dgv_view_objects.IsRowSelected(e.RowHandle) = True Then
            Dim hi As GridHitInfo = dgv_view_objects.CalcHitInfo(e.Location)
            If hi.InRowCell Then
                Dim column As GridColumn = hi.Column
                If column.FieldName = "Opciones" Then
                    Using trace_ As New model_object_tracing(dgv_view_objects.GetRowCellValue(dgv_view_objects.FocusedRowHandle, "field_affected"))
                        trace_.ShowDialog(start_home)
                    End Using
                End If
            End If
        End If
    End Sub

    Public Sub reports_show(source As DataTable, Optional show_option As Boolean = False)
        dgv_grid_objects.DataSource = Nothing
        dgv_view_objects.Columns.Clear()
        lbl_count_objects.Text = 0

        'check if data source paratemeter has rows
        If source IsNot Nothing And source.Rows.Count > 0 Then
            dgv_grid_objects.DataSource = source
            dgv_view_objects.Columns("Id").Visible = False
            dgv_view_objects.BestFitColumns(True)
            dgv_view_objects.SelectRow(0)

            'check if column exists
            If dgv_view_objects.Columns("wholesale_code") IsNot Nothing Then dgv_view_objects.Columns("wholesale_code").Visible = False
            If dgv_view_objects.Columns("field_affected") IsNot Nothing Then dgv_view_objects.Columns("field_affected").Visible = False

            'check if columng comentario exists to change columnd and row size
            With dgv_view_objects
                If .Columns("Comentario") IsNot Nothing Then .Columns("Comentario").ColumnEdit = txt_memo_edit
                If .Columns("Comentario") IsNot Nothing Then .Columns("Comentario").Width = 400
                If .Columns("Comentario") IsNot Nothing Then .RowHeight = 50
                If .Columns("Comentario") IsNot Nothing Then .Columns("Comentario").AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            End With

            'set total of registre in label lbl_count
            lbl_count_objects.Text = CInt(dgv_view_objects.RowCount.ToString)

            'set parameters of columns and hiden columns
            If show_option = True Then helper_column()
        End If
    End Sub
#End Region

#Region "objects"
    Private Sub options_selected(sender As Object, e As EventArgs) Handles lbl_options_notes.Click, lbl_options_tracing.Click, lbl_options_payments.Click, lbl_options_request.Click, lbl_options_discounts.Click
        reports_show(options_changed(sender.Name), options_helpers(sender.Name))
    End Sub

    Private Function options_changed(process_name_ As String) As DataTable
        'set name of process execute
        process_name = process_name_

        'compare name to decide process execute table
        Select Case process_name_
            Case "lbl_options_request" : Return request.wholesale_request_show("r.wholesale_code=" & dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id") & " and r.row_visible in (1,3,4)")
            Case "lbl_options_payments" : Return commision.commision_payments_resume("s.wholesales_code=" & dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id") & " and s.row_visible=1")
            Case "lbl_options_tracing" : Return audited.audits_search_tracing("Wholesales.Masters.Sales", dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id"))
            Case "lbl_options_notes" : Return notes.notes_master_show("Wholesales.Masters.Sales", dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id"))
            Case "lbl_options_discounts" : Return commision.commision_discount_search("d.wholesales_code=" & dgv_view_results.GetRowCellValue(dgv_view_results.FocusedRowHandle, "Id"))
        End Select

        Throw New ArgumentOutOfRangeException(process_name_)
    End Function

    Private Function options_helpers(process_name_ As String) As Boolean
        Select Case process_name_
            Case "lbl_options_request" : module_name = "Peticiones"
            Case "lbl_options_payments" : module_name = "Comisiones"
            Case "lbl_options_tracing" : module_name = "Seguimiento"
            Case "lbl_options_notes" : module_name = "Notas de venta"
            Case "lbl_options_discounts" : module_name = "Descuentos"
        End Select

        'compare name of process to return value and name of process
        Select Case process_name_
            Case "lbl_options_request" : Return False
            Case "lbl_options_payments" : Return False
            Case "lbl_options_tracing" : Return True
            Case "lbl_options_notes" : Return False
            Case "lbl_options_discounts" : Return False
        End Select

        Throw New ArgumentOutOfRangeException(process_name_)
    End Function

    Private Sub options_update(sender As Object, e As EventArgs) Handles btn_update_objects.Click
        If process_name <> "" Then reports_show(options_changed(process_name), options_helpers(process_name))
    End Sub

    Private Sub options_erase(sender As Object, e As EventArgs) Handles btn_erase_objects.Click
        If process_name <> "" Then
            If dgv_view_objects.SelectedRowsCount.ToString = 1 Then
                If message_text("Está seguro que desea anular el registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Select Case process_name
                        Case "lbl_options_notes" : notes.notes_master_erased_option(dgv_view_objects.GetRowCellValue(dgv_view_objects.FocusedRowHandle, "Id"))
                        Case "lbl_options_discounts" : commision.commision_discount_erased_option(dgv_view_objects.GetRowCellValue(dgv_view_objects.FocusedRowHandle, "Id"))
                    End Select
                End If
            End If
        End If
    End Sub

    Private Sub options_export(sender As Object, e As EventArgs) Handles btn_export_objects.Click
        If dgv_view_objects.RowCount > 0 Then
            Using export As New model_object_export(dgv_view_objects)
                export.ShowDialog(start_home)
            End Using
        End If
    End Sub

    Private Sub options_printer(sender As Object, e As EventArgs) Handles btn_print_objects.Click
        If dgv_view_objects.RowCount > 0 Then
            dgv_view_objects.ShowPrintPreview()
        End If
    End Sub
#End Region
End Class
