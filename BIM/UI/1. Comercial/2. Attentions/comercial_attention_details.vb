Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class comercial_attention_details
    Private attention As Attentions = Attentions.Instance
    Private searched As Resumen = Resumen.Instance
    Private row_affected As Integer
    Private row_customer As Integer

#Region "constructors"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'Define el parametro de la gestion seleccionada
        row_affected = row_selected
    End Sub

    Public Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        search_attention()
    End Sub
#End Region

#Region "behaviors"
    Public Sub interface_search()
        With My.Settings
            btn_object_close.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub close_module()
        start_home.removed_tabbed()
    End Sub

    Private Sub search_attention()
        Dim table_source As DataTable = attention.commercial_attention_search("t.Id=" & row_affected)

        If table_source.Rows.Count = 1 Then
            With table_source.Rows(0)
                lbl_object_customer.Text = .Item("customer_name").ToString
                lbl_object_document.Text = .Item("number_document").ToString

                'Define el codigo de cliente asociado a la gestion
                row_customer = .Item("customer_code").ToString

                'Define los datos del cliente en los campos de resumen
                txt_resumen_customer.EditValue = .Item("customer_name").ToString
                txt_resumen_document.EditValue = .Item("number_document").ToString
                txt_resumen_birthdate.EditValue = .Item("birth_date").ToString
                txt_resumen_cellphone.EditValue = .Item("number_cellphone").ToString
                txt_resumen_phone.EditValue = .Item("number_phone").ToString
                txt_resumen_email.EditValue = .Item("email").ToString
                txt_resumen_depto.EditValue = .Item("department_name").ToString
                txt_resumen_city.EditValue = .Item("city_name").ToString
                txt_resumen_address.EditValue = .Item("place_address").ToString
                txt_resumen_neighborhood.EditValue = .Item("neighborhood").ToString
                txt_resumen_source.EditValue = .Item("source_name").ToString
                txt_resumen_knowledge.EditValue = .Item("knowledge_name").ToString
                txt_resumen_optin.Checked = CBool(.Item("opt_in").ToString)
                txt_resumen_quota.EditValue = FormatCurrency(.Item("credit_limit"), 0)

                'Define los datos de la gestión en los campos correspondientes
                txt_attention_ticket.EditValue = .Item("ticket_number").ToString
                txt_attention_theme.EditValue = .Item("topic_name").ToString & " | " & .Item("theme_name").ToString
                txt_attention_created.EditValue = CDate(.Item("created_date").ToString)
                txt_attention_oportunity.EditValue = .Item("chances_rule").ToString
                txt_attention_status.EditValue = .Item("status_name").ToString
                txt_attention_closed.EditValue = If(.Item("closed_date").ToString <> "", .Item("closed_date").ToString, "")
                txt_attention_quotation.Text = .Item("quotation_total").ToString & If(.Item("quotation_total").ToString = "1", " (Cotización)", " (Cotizaciones)")
                txt_attention_wholesales.Text = .Item("wholesales_total").ToString & If(.Item("wholesales_total").ToString = "1", " (Venta)", " (Ventas)")
                lbl_attention_person.Text = .Item("person_name").ToString
                lbl_attention_agency.Text = .Item("agency_name").ToString

                'Define la foto asociada al cliente seleccionado
                If .Item("photo_avatar").ToString <> "" Then pic_object_photo.Image = fn_transform_image(.Item("photo_avatar"))
                If .Item("user_photo").ToString <> "" Then pic_object_avatar.Image = fn_transform_image(.Item("user_photo"))

                'Carga las notas asociadas y las cotizaciones de la gestion de la gestión seleccionada 
                search_resumen()
            End With
        End If
    End Sub

    Private Sub option_column()
        If dgv_resumen_quotation.RowCount > 0 Then
            Dim column_option As GridColumn = dgv_resumen_quotation.Columns.AddVisible("column_option")

            With column_option
                .UnboundType = DevExpress.Data.UnboundColumnType.Object
                .ColumnEdit = pic_object_quotation
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

    Private Sub reports_show(source_table As DataTable, object_grid As GridControl, object_view As GridView, object_count As LabelControl, Optional use_nodes As Boolean = False, Optional object_node As GridView = Nothing, Optional process_node As String = "", Optional condition_node As String = "c.row_affected in (")
        'Limpia los origenes de datos anteriores
        object_grid.DataSource = Nothing
        object_grid.LevelTree.Nodes.Clear()
        object_view.Columns.Clear()
        object_count.Text = 0

        'Comprueba si el origen de datos es vacio
        If source_table Is Nothing Then Exit Sub

        'Comprueba si la consulta arrojo datos de consulta
        If source_table.Rows.Count > 0 Then
            'define el origen de datos al grid control
            object_grid.DataSource = source_table

            'Parametriza las columnas de la vista
            With object_view
                object_view.Columns("Id").Visible = False
                object_view.BestFitColumns(True)
                object_view.SelectRow(0)

                'Ajusta las columnas no visibles de cada consulta
                columns_ajusted(object_view)

                'Define el total de filas en la etiqueta de totales
                If object_view.Columns("Valor a financiar") IsNot Nothing Then object_count.Text = total_values() Else object_count.Text = .RowCount.ToString
                If object_view.Columns.Count < 10 Then object_view.OptionsView.ColumnAutoWidth = True
            End With

            'Activa el nodo asociado a la consulta base
            If use_nodes = True Then object_grid.LevelTree.Nodes.Add("node_table", custom_nodes(object_grid, object_node, process_node, condition_node))
        End If
    End Sub

    Private Function custom_nodes(object_grid As GridControl, object_node As GridView, node_process As String, condition_node As String) As GridView
        Try
            If TryCast(object_grid.DataSource, DataTable).Rows.Count > 0 Then
                Dim tables_sources As New DataSet
                Dim row_affected As Integer() = TryCast(object_grid.DataSource, DataTable).AsEnumerable().Select(Function(x) x.Field(Of Integer)(0)).ToArray()
                Dim node_source As DataTable = If(node_process = "commercial_attention_suggested", table_search(node_process, condition_node & String.Join(","c, row_affected) & ")"), searched.notes_master_searched(condition_node & String.Join(","c, row_affected) & ")", object_node.Tag.ToString))


                'Carga las tablas en el dataset
                With tables_sources
                    .Tables.Add(TryCast(object_grid.DataSource, DataTable)) ' Tabla de grid control enviado
                    .Tables.Add(node_source) 'Tabla de nodo asociado

                    'Crea las columnas de relacion para el dataset
                    Dim columnkey_column As DataColumn = .Tables(0).Columns("Id")
                    Dim foreignkey_column As DataColumn = .Tables(1).Columns("row_affected")

                    'Crear la relacion entre las tablas
                    .Relations.Add("node_table", columnkey_column, foreignkey_column)
                End With

                'Ajusta las caracteristicas de la vista de notas para el nodo
                With object_node
                    .OptionsView.RowAutoHeight = True
                    .PopulateColumns(tables_sources.Tables(1))
                    .BestFitColumns(True)
                    .RefreshData()

                    'Ajusta las columnas a mostrar en el nodo anidado
                    columns_ajusted(object_node)
                End With

                'Retorna la vista para crear el nodo
                Return object_node
            End If

        Catch ex As Exception
        End Try

        Return Nothing
    End Function
#End Region

#Region "helpers"
    Private Sub selected_page(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles pnl_object_tabbed.SelectedPageChanged
        If e.Page.Name = "xtp_object_resumen" Then search_resumen()
        If e.Page.Name = "xtp_object_attentions" Then search_attentions()
        If e.Page.Name = "xtp_object_wholesales" Then search_wholesales()
        If e.Page.Name = "xtp_object_features" Then search_features()
        If e.Page.Name = "xtp_object_datacredit" Then search_datacredits()
        If e.Page.Name = "xtp_object_financial" Then search_financial()
    End Sub

    Private Function table_search(process_name As String, first_search As String) As DataTable
        Try
            Return CallByName(searched, process_name, CallType.Method, first_search)
        Catch ex As Exception
        End Try

        Return Nothing
    End Function

    Private Function table_search(process_name As String, first_search As String, second_criteria As String) As DataTable
        Try
            Return CallByName(searched, process_name, CallType.Method, first_search, second_criteria)
        Catch ex As Exception
        End Try

        Return Nothing
    End Function

    Private Sub columns_ajusted(object_view As GridView)
        With object_view
            'Oculta las columnas no necesarias para la vista seleccionada
            If .Columns("Id") IsNot Nothing Then .Columns("Id").VisibleIndex = -1
            If .Columns("row_affected") IsNot Nothing Then .Columns("row_affected").VisibleIndex = -1
            If .Columns("attention_code") IsNot Nothing Then .Columns("attention_code").VisibleIndex = -1
            If .Columns("Descripcion") IsNot Nothing Then .Columns("Descripcion").ColumnEdit = col_object_notes
            If .Columns("Descripcion") IsNot Nothing Then .Columns("Descripcion").Width = 410

            'Ajusta la posicion de la celta para los valores numericos
            If .Columns("Sugerencias") IsNot Nothing Then .Columns("Sugerencias").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            If .Columns("Sugerencias") IsNot Nothing Then .Columns("Sugerencias").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            If .Columns("Ventas") IsNot Nothing Then .Columns("Ventas").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            If .Columns("Ventas") IsNot Nothing Then .Columns("Ventas").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            If .Columns("Cotizaciones") IsNot Nothing Then .Columns("Cotizaciones").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            If .Columns("Cotizaciones") IsNot Nothing Then .Columns("Cotizaciones").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            If .Columns("Servicios") IsNot Nothing Then .Columns("Servicios").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            If .Columns("Servicios") IsNot Nothing Then .Columns("Servicios").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            If .Columns("Estrato") IsNot Nothing Then .Columns("Estrato").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            If .Columns("Estrato") IsNot Nothing Then .Columns("Estrato").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            If .Columns("Cuotas Pendientes") IsNot Nothing Then .Columns("Cuotas Pendientes").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            If .Columns("Cuotas Pendientes") IsNot Nothing Then .Columns("Cuotas Pendientes").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        End With
    End Sub

    Private Function total_values() As String
        Dim value_total As Double = 0

        For i As Integer = 0 To dgv_financial_search.DataRowCount
            value_total += CDbl(Replace(Replace(Replace(dgv_financial_search.GetRowCellValue(i, "Valor a financiar"), ".", ""), "$", ""), "- ", "-"))
        Next

        Return FormatCurrency(value_total, 0)
    End Function
#End Region

#Region "methods"
    Private Sub search_resumen(Optional execute_type As String = "all")
        If execute_type = "notes" Then
            reports_show(table_search("notes_master_search", "c.row_affected in (" & row_affected & ")"), dgc_resumen_notes, dgv_resumen_notes, lbl_resumen_count1)

        ElseIf execute_type = "quota" Then
            reports_show(table_search("attention_quotation_show", "c.attention_code in (" & row_affected & ") and c.row_visible=1"), dgc_resumen_quotation, dgv_resumen_quotation, lbl_resumen_count2)

        ElseIf execute_type = "all" Then
            reports_show(table_search("notes_master_search", "c.row_affected in (" & row_affected & ")"), dgc_resumen_notes, dgv_resumen_notes, lbl_resumen_count1)
            reports_show(table_search("attention_quotation_show", "c.attention_code in (" & row_affected & ")"), dgc_resumen_quotation, dgv_resumen_quotation, lbl_resumen_count2)
        End If

        'Ejecuta el agregado de columna a las cotizaciones
        option_column()
    End Sub

    Private Sub search_attentions()
        reports_show(table_search("commercial_attention_show", "t.customer_code=" & row_customer & " and t.Id not in (" & row_affected & ") and t.row_visible=1"), dgc_attention_search, dgv_attention_search, lbl_attention_count, True, dgn_attention_search, "notes_master_search")
    End Sub

    Private Sub search_wholesales()
        reports_show(table_search("wholesale_sales_show", "s.row_visible in (1,3) and s.customer_code=" & row_customer), dgc_wholesales_search, dgv_wholesales_search, lbl_wholesales_count)
    End Sub

    Private Sub search_features()
        reports_show(table_search("comercial_customer_hobbies", CStr(row_customer)), dgc_features_search, dgv_features_search, lbl_features_count, True, dgn_features_search, "commercial_attention_suggested", "p.Id in (")
    End Sub

    Private Sub search_datacredits()
        reports_show(table_search("wholesale_datacredits_show", "c.row_visible=1 and c.customer_code=" & row_customer), dgc_datacredits_search, dgv_datacredits_search, lbl_datacredits_count)
    End Sub

    Private Sub search_financial()
        reports_show(table_search("financial_request_showed", "r.row_visible=1 and r.customer_code=" & row_customer), dgc_financial_search, dgv_financial_search, lbl_financial_count, True, dgn_financial_search, "notes_master_searched")
    End Sub
#End Region

#Region "features"
    Private Sub create_features(sender As Object, e As EventArgs) Handles btn_create_features.Click
        Using new_ As New comercial_customer_hobbies(row_customer)
            new_.ShowDialog(start_home)
        End Using
    End Sub

    Private Sub update_features(sender As Object, e As EventArgs) Handles btn_update_features.Click
        reports_show(table_search("comercial_customer_hobbies", CStr(row_customer)), dgc_features_search, dgv_features_search, lbl_features_count, True, dgn_features_search, "commercial_attention_suggested", "p.Id in (")
    End Sub

    Private Sub exported_features(sender As Object, e As EventArgs) Handles btn_export_features.Click
        If dgv_features_search.RowCount > 0 Then
            Using export As New model_object_export(dgv_features_search)
                export.ShowDialog(start_home)
            End Using
        End If
    End Sub

    Private Sub group_features(sender As Object, e As EventArgs) Handles btn_panel_features.Click
        With dgv_features_search.OptionsView
            .ShowGroupPanel = If(.ShowGroupPanel = False, True, False)
        End With
    End Sub
#End Region

#Region "quotation"
    Private Sub quotation_clicked(sender As Object, e As EventArgs) Handles dgc_resumen_quotation.DoubleClick
        If dgv_resumen_quotation.IsRowSelected(dgv_resumen_quotation.FocusedRowHandle) = True Then
            Using wholesales As New attention_quotation_wholesales(dgv_resumen_quotation.GetRowCellValue(dgv_resumen_quotation.FocusedRowHandle, "Id"))
                wholesales.ShowDialog(start_home)
            End Using

            'Actualiza las cotizaciones de la gestión seleccionada
            search_resumen("quota")
        End If
    End Sub

    Private Sub quotation_option(sender As Object, e As EventArgs) Handles btn_object_quotation.Click
        If message_text("Está seguro que desea crear una cotización de producto a la gestión seleccionada?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using new_ As New comercial_attention_quotation(row_affected)
                new_.ShowDialog(start_home)
            End Using

            'Actualiza las cotizaciones de la gestión seleccionada
            search_resumen("quota")
        End If
    End Sub

    Private Sub quotation_format(sender As Object, e As EventArgs) Handles btn_quotas_format.Click
        If dgv_resumen_quotation.RowCount > 0 Then
            If message_text("Está seguro que desea generar el formato de cotización del seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using formats_ As New attention_quotation_viewers(row_affected)
                    formats_.ShowDialog(start_home)
                End Using
            End If
        End If
    End Sub

    Private Sub quotation_image(sender As Object, e As Views.Base.CustomColumnDataEventArgs) Handles dgv_resumen_quotation.CustomUnboundColumnData
        If e.Column.FieldName = "Opciones" Then e.Value = My.Resources.erase_green
    End Sub

    Private Sub quotation_selected(ByVal sender As Object, ByVal e As Views.Base.RowCellCustomDrawEventArgs) Handles dgv_resumen_quotation.CustomDrawCell
        Dim cellInfo As GridCellInfo = TryCast(e.Cell, GridCellInfo)
        Dim info As PictureEditViewInfo = TryCast(cellInfo.ViewInfo, PictureEditViewInfo)
        If info IsNot Nothing Then
            info.Image = If(dgv_resumen_quotation.IsRowSelected(e.RowHandle) = True, My.Resources.erase_white, My.Resources.erase_green)
            info.CalcViewInfo()
        End If
    End Sub

    Private Sub quotation_show(sender As Object, e As RowClickEventArgs) Handles dgv_resumen_quotation.RowClick
        If dgv_resumen_quotation.IsRowSelected(e.RowHandle) = True Then
            Dim hi As GridHitInfo = dgv_resumen_quotation.CalcHitInfo(e.Location)
            If hi.InRowCell Then
                Dim column As GridColumn = hi.Column
                If column.FieldName = "Opciones" Then
                    quotation_erased(dgv_resumen_quotation.GetRowCellValue(dgv_resumen_quotation.FocusedRowHandle, "Id"))
                End If
            End If
        End If
    End Sub

    Private Sub quotation_erased(quotation_row As Integer)
        If dgv_resumen_quotation.RowCount > 0 Then
            If message_text("Está seguro que desea eliminar la cotización seleccionada?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If attention.attention_quotation_erase(quotation_row, True) = True Then
                    search_resumen("quota")
                End If
            End If
        End If
    End Sub
#End Region

#Region "options"
    Private Sub finalize_option(sender As Object, e As EventArgs) Handles btn_object_finally.Click
        If message_text("Está seguro que desea finalizar la gestión comercial seleccionada?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using edit_ As New comercial_attention_closed(row_affected)
                edit_.ShowDialog(start_home)
            End Using
        End If
    End Sub

    Private Sub noted_option(sender As Object, e As EventArgs) Handles btn_object_notes.Click
        If message_text("Está seguro que registrar una nota asociada a la gestión seleccionada?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using new_ As New model_object_notes("Relationship.Customers.Tickets", row_affected, Me.Tag.ToString)
                new_.ShowDialog(start_home)
            End Using

            'Ejecuta el proceso para consultar las notas de la gestión seleccionada
            search_resumen("notes")
        End If
    End Sub

    Private Sub proof_financial(sender As Object, e As EventArgs) Handles btn_financial_format.EditValueChanged
        With dgv_financial_search
            If .RowCount > 0 Then
                If (.GetRowCellValue(.FocusedRowHandle, "Estado")) = "Aprobado" Then
                    Select Case btn_financial_format.SelectedIndex
                        Case 0
                            Using new_ As New financial_masters_payment(.GetRowCellValue(.FocusedRowHandle, "Id"))
                                new_.ShowDialog(start_home)
                            End Using
                        Case 1
                            Using new_ As New financial_masters_pagare(.GetRowCellValue(.FocusedRowHandle, "Id"))
                                new_.ShowDialog(start_home)
                            End Using
                    End Select
                Else
                    message_text("La solicitud debe estar aprobada para generar los formatos", MessageBoxButtons.OK)
                End If
            End If
        End With
    End Sub

    Private Sub edited_option(sender As Object, e As EventArgs) Handles btn_object_edit.Click
        If message_text("Está seguro que desea editar la información del cliente?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            show_option(New comercial_customer_edited(row_customer, Me))
        End If
    End Sub

    Private Sub financial_option(sender As Object, e As EventArgs) Handles btn_object_financial.Click
        If message_text("Está seguro que desea crear una solicitud de financiamiento?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            show_option(New comercial_attention_financial(row_affected, row_customer))
        End If
    End Sub

    Private Sub selector_node(sender As Object, e As EventArgs) Handles dgs_attention_node.EditValueChanged
        If dgv_attention_search.RowCount > 0 Then reports_show(table_search("commercial_attention_show", "t.customer_code=" & row_customer & " and t.Id not in (" & row_affected & ") and t.row_visible=1"), dgc_attention_search, dgv_attention_search, lbl_attention_count, True, dgn_attention_search, If(dgs_attention_node.EditValue = 1, "notes_master_search", "attention_quotation_show"), If(dgs_attention_node.EditValue = 1, "c.row_affected in (", "c.attention_code in ("))
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_close.Click
        close_module()
    End Sub
#End Region
End Class
