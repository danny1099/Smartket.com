Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class comercial_customer_resume
    Private customer As Customer = Customer.Instance
    Private datacredit As Datacredits = Datacredits.Instance
    Private attention As Attentions = Attentions.Instance
    Private financial As Financial = Financial.Instance
    Private sales As Sales = Sales.Instance
    Private last_control As Control
    Private curren_object As String
    Private record_affected As Integer

#Region "constructors"
    Public Sub New(row_selected As Integer, lasted_control As Control)
        InitializeComponent()
        PerformAutoScale()

        'set parameter value in variable record_affected
        record_affected = row_selected
        last_control = lasted_control
    End Sub

    Public Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        search_person()
    End Sub

    Private Sub search_person()
        Dim table As DataTable = customer.comercial_customer_search("c.Id=" & record_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                txt_name_person.Text = .Item("person_name").ToString
                txt_seller_name.Text = .Item("person_seller").ToString
                txt_agency_name.Text = .Item("agency_name").ToString
                txt_birth_date.Text = StrConv(CDate(.Item("birth_date")).ToString("MMMM dd, yyyy") & " (" & DateDiff(DateInterval.Year, CDate(.Item("birth_date")), Now) & " Años)", vbProperCase)

                'check if current user have photo
                If .Item("photo_avatar").ToString <> "" Then pic_object_photo.Image = fn_transform_image(.Item("photo_avatar")) Else pic_object_photo.Image = My.Resources.photo_default
            End With
        End If
    End Sub
#End Region

#Region "behaviors"
    Public Sub interface_search()
        With My.Settings
            btn_object_close.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Public Sub reports_show(source As DataTable)
        'limpia los origenes de datos anteriores
        dgv_object_grid.DataSource = Nothing
        dgv_object_view.Columns.Clear()
        lbl_object_count.Text = 0

        'comprueba si la consulta tiene filas para mostrar
        If source.Rows.Count > 0 Then
            'define el origen de datos al grid control
            dgv_object_grid.DataSource = source

            'parametriza las columnas de la vista
            With dgv_object_view
                dgv_object_view.Columns("Id").Visible = False
                dgv_object_view.BestFitColumns(True)
                dgv_object_view.SelectRow(0)

                'check if total column are less to change view column
                .OptionsView.ColumnAutoWidth = False

                'check if column cotizaciones exist to alignment to center
                If curren_object = "lbl_object_attention" Then option_column()
                If curren_object = "lbl_object_hobbies" Then option_column()
                If .Columns("suggestion_items") IsNot Nothing Then .Columns("suggestion_items").Visible = False
                If .Columns("Cotizaciones") IsNot Nothing Then .Columns("Cotizaciones").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                If .Columns("Edad") IsNot Nothing Then .Columns("Edad").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                If .Columns("Sugerencias") IsNot Nothing Then .Columns("Sugerencias").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                If .Columns("Total Cartera") IsNot Nothing Then .Columns("Total Cartera").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                If .Columns("Pago Total") IsNot Nothing Then .Columns("Pago Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                If .Columns("Total Cartera") IsNot Nothing Then .Columns("Total Cartera").DisplayFormat.FormatString = "c0"
                If .Columns("Pago Total") IsNot Nothing Then .Columns("Pago Total").DisplayFormat.FormatString = "c0"

                'define el total de filas en la etiqueta de totales
                lbl_object_count.Text = If(.Columns("Pago Total") IsNot Nothing, total_sales(), .RowCount.ToString)
            End With
        End If
    End Sub

    Private Sub count_rows(sender As Object, e As EventArgs) Handles dgv_object_view.ColumnFilterChanged
        lbl_object_count.Text = dgv_object_view.RowCount.ToString
    End Sub

    Private Function total_sales() As String
        Dim value_total As Double = 0

        For i As Integer = 0 To dgv_object_view.DataRowCount
            If dgv_object_view.GetRowCellValue(i, "Pago Total") >= 0 Then
                value_total += CDbl(Replace(Replace(Replace(dgv_object_view.GetRowCellValue(i, "Pago Total"), ".", ""), "$", ""), "- ", "-"))
            End If
        Next

        Return FormatCurrency((value_total), 0)
    End Function

    Private Sub option_column()
        If dgv_object_view.RowCount > 0 Then
            Dim column_option As GridColumn = dgv_object_view.Columns.AddVisible("column_option")

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

    Private Sub options_show(sender As Object, e As RowClickEventArgs) Handles dgv_object_view.RowClick
        If dgv_object_view.IsRowSelected(e.RowHandle) = True Then
            Dim hi As GridHitInfo = dgv_object_view.CalcHitInfo(e.Location)
            If hi.InRowCell Then
                Dim column As GridColumn = hi.Column
                If column.FieldName = "Opciones" Then
                    'Cambia el tipo de opciones a mostrar
                    actions_option(curren_object)

                    'Muestra el panel de opciones
                    pnl_object_flyout.HidePopup()
                    pnl_object_flyout.Options.Location = If(hi.HitPoint.Y >= 100, New Point(hi.HitPoint.X, 1), hi.HitPoint)
                    pnl_object_flyout.ShowPopup(True)
                End If
            End If
        End If
    End Sub

    Private Sub actions_option(curren_object_ As String)
        If curren_object_ = "lbl_object_attention" Then
            pnl_object_suggets.Dock = DockStyle.Top
            pnl_object_suggets.Size = pnl_object_suggets.MinimumSize
            pnl_object_actions.Dock = DockStyle.Fill
            pnl_object_flyout.Size = New Size(260, 220)

        ElseIf curren_object_ = "lbl_object_hobbies" Then
            pnl_object_actions.Dock = DockStyle.Top
            pnl_object_actions.Size = pnl_object_suggets.MinimumSize
            pnl_object_suggets.Dock = DockStyle.Fill
            pnl_object_flyout.Size = New Size(260, 51)
        End If
    End Sub

    Private Sub selected_process(sender As Object, e As EventArgs) Handles lbl_object_sales.Click, lbl_object_datacredit.Click, lbl_object_attention.Click, lbl_object_balances.Click, lbl_object_refered.Click, lbl_object_hobbies.Click, lbl_object_credits.Click
        'set current process with selected object clicked
        curren_object = sender.name.ToString

        If curren_object IsNot Nothing Then
            reports_show(search_data(curren_object))
        End If
    End Sub

    Private Function search_data(process_name As String) As DataTable
        Select Case process_name
            Case "lbl_object_sales" : Return sales.wholesale_sales_show("s.customer_code=" & record_affected & "and s.row_visible in (1,3)")
            Case "lbl_object_datacredit" : Return datacredit.wholesale_datacredits_show("c.customer_code=" & record_affected & "and c.row_visible=1")
            Case "lbl_object_attention" : Return attention.commercial_attention_show("t.customer_code=" & record_affected & " and t.row_visible=1")
            Case "lbl_object_balances" : Return customer.comercial_customer_credits("c.Id=" & record_affected & " and b.row_visible=1")
            Case "lbl_object_refered" : Return customer.comercial_customer_show("c.source_code=11 and c.refered_code=" & record_affected & " and c.row_visible=1")
            Case "lbl_object_hobbies" : Return customer.comercial_customer_hobbies(record_affected)
            Case "lbl_object_credits" : Return financial.financial_request_showed("r.customer_code=" & record_affected)
        End Select

        Throw New ArgumentException
    End Function
#End Region

#Region "options"
    Private Sub create_option(sender As Object, e As EventArgs) Handles btn_object_new.Click
        Select Case curren_object
            Case "lbl_object_datacredit" : show_option(New wholesales_datacredits_create(record_affected))
            Case "lbl_object_attention" : show_option(New comercial_attention_create(record_affected))
            Case "lbl_object_refered" : search_form("comercial_customer_refered", record_affected)
            Case "lbl_object_hobbies" : search_form("comercial_customer_hobbies", record_affected)
        End Select
    End Sub

    Private Function listed_customer(row_selected As Integer) As List(Of Integer)
        Dim row_send As New List(Of Integer)
        row_send.Add(row_selected)

        Return row_send
    End Function

    Private Sub edited_option(sender As Object, e As EventArgs) Handles btn_object_edited.Click
        show_option(New comercial_customer_edited(record_affected, Me))
    End Sub

    Private Sub modify_option(sender As Object, e As EventArgs) Handles btn_object_edit.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea finalizar el registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using edit_ As New comercial_attention_closed(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id"))
                    edit_.ShowDialog(start_home)
                End Using

                'update listed of attention with changes
                reports_show(search_data(curren_object))
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub erased_option(sender As Object, e As EventArgs) Handles btn_object_erase.Click
        If dgv_object_view.RowCount > 0 Then
            If message_text("Está seguro que desea eliminar los registros seleccionados?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                    If dgv_object_view.IsRowSelected(i) = True Then
                        attention.commercial_attention_erase(dgv_object_view.GetRowCellValue(i, "Id"), False)
                    End If
                Next

                'return message to end process
                If message_text("Los registros seleccionados fueron anulados exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then reports_show(search_data(curren_object))
            End If
        End If
    End Sub

    Private Sub transfer_option(sender As Object, e As EventArgs) Handles btn_object_transfer.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea transferir el registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using new_ As New comercial_attention_transfer(CInt(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id")))
                    new_.ShowDialog(start_home)
                End Using

                'update listed with changes applied
                reports_show(search_data(curren_object))
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub searched_option(sender As Object, e As EventArgs) Handles btn_object_resume.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea ver el detalle del registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                show_option(New comercial_customer_resume(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id"), Me))
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub noted_option(sender As Object, e As EventArgs) Handles btn_object_notes.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea ver el resumen del registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using new_ As New model_object_comments(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id"), "Relationship.Customers.Tickets")
                    new_.ShowDialog(start_home)
                End Using
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub suggest_option(sender As Object, e As EventArgs) Handles btn_object_suggets.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "suggestion_items").ToString <> "No product suggestions found on selected data" Then
                If message_text("Está seguro que desea ver las sugerencias de producto del registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Using new_ As New comercial_customer_products(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "suggestion_items"))
                        new_.ShowDialog(start_home)
                    End Using
                End If
            Else
                message_text("No tiene productos sugeridos la caracteristica seleccionada", MessageBoxButtons.OK)
            End If
        Else
                message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub synchronize_option(sender As Object, e As EventArgs) Handles btn_object_update.Click
        reports_show(search_data(curren_object))
    End Sub

    Private Sub exported_option(sender As Object, e As EventArgs) Handles btn_object_export.Click
        If dgv_object_view.RowCount > 0 Then
            Using export As New model_object_export(dgv_object_view)
                export.ShowDialog(start_home)
            End Using
        End If
    End Sub

    Private Sub printer_option(sender As Object, e As EventArgs) Handles btn_object_print.Click
        If dgv_object_view.RowCount > 0 Then dgv_object_view.ShowPrintPreview()
    End Sub

    Private Sub group_option(sender As Object, e As EventArgs) Handles btn_object_panel.Click
        With dgv_object_view.OptionsView
            .ShowGroupPanel = If(.ShowGroupPanel = False, True, False)
        End With
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_close.Click, btn_object_back.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
