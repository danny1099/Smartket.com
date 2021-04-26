Imports APDA.Object.Controls
Imports DevExpress.Data.Filtering
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class commision_settleds_slopes
    Private commision_ As Commision = Commision.Instance
    Private parameters As Parameters = Parameters.Instance
    Private operators As Operators = Operators.Instance
    Private dealer As Dealers = Dealers.Instance
    Private agency As Agencys = Agencys.Instance
    Private person As Persons = Persons.Instance
    Private channel As Channels = Channels.Instance
    Private sales As Sales = Sales.Instance
    Private criteria_search As String = ""

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()

        'apply all permits assigned per current module
        search_permits()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        objects_condition()
    End Sub
#End Region

#Region "behaviors"
    Private Sub search_permits()
        If sessions.admin_user <> 1 Then
            Dim table As DataTable = sessions.search_permission

            If table.Rows.Count > 0 Then
                With table
                    'check if options new is enabled
                    If .Select("action_object='btn_object_new' and option_showed='" & Me.Name & "'").Count = 0 Then
                        btn_object_new.Size = btn_object_new.MinimumSize
                        lbl_separator2.Visible = False
                    End If

                    'run all options in panel actions
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

    Public Sub reports_show(Optional criteria_search As String = "")
        Dim source As DataTable = commision_.commision_payments_slopes(criteria_search)

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
                .Columns("Id").Visible = False
                .Columns("person_code").Visible = False
                .BestFitColumns(True)
                .SelectRow(0)

                'comprueba el total de columnas para realizar el ajuste
                .OptionsView.ColumnAutoWidth = If(.Columns.Count <= 10, True, False)

                'define el total de filas en la etiqueta de totales
                lbl_object_count.Text = .RowCount.ToString
            End With

            'define la columna de opciones
            option_column()
            custom_layout()
        End If
    End Sub

    Private Sub options_show(sender As Object, e As RowClickEventArgs) Handles dgv_object_view.RowClick
        If dgv_object_view.IsRowSelected(e.RowHandle) = True Then
            Dim hi As GridHitInfo = dgv_object_view.CalcHitInfo(e.Location)
            If hi.InRowCell Then
                Dim column As GridColumn = hi.Column
                If column.FieldName = "Opciones" Then
                    pnl_object_flyout.HidePopup()
                    pnl_object_flyout.Options.Location = If(If(hi.HitPoint.Y >= 100, New Point(hi.HitPoint.X, 1), hi.HitPoint).Y >= 100, New Point(If(hi.HitPoint.Y >= 100, New Point(hi.HitPoint.X, 1), hi.HitPoint).X, 1), If(hi.HitPoint.Y >= 100, New Point(hi.HitPoint.X, 1), hi.HitPoint))
                    pnl_object_flyout.ShowPopup(True)
                End If
            End If
        End If
    End Sub

    Private Sub count_rows(sender As Object, e As EventArgs) Handles dgv_object_view.ColumnFilterChanged
        lbl_object_count.Text = dgv_object_view.RowCount.ToString
    End Sub

    Private Sub separator_changed(sender As Object, e As EventArgs) Handles lbl_object_separator1.Click
        If pnl_object_filter.Width = 350 Then
            pnl_object_filter.Width = 0
            With lbl_object_separator1
                .ImageOptions.Image = My.Resources.options_right
                .Appearance.BackColor = Color.FromArgb(230, 242, 250)
                .Appearance.BackColor2 = Color.FromArgb(230, 242, 250)
            End With

        ElseIf pnl_object_filter.Width = 0 Then
            pnl_object_filter.Width = 350
            With lbl_object_separator1
                .ImageOptions.Image = My.Resources.options_left
                .Appearance.BackColor = Color.White
                .Appearance.BackColor2 = Color.White
            End With
        End If
    End Sub

    Private Sub customization_viewer(sender As Object, e As EventArgs) Handles dgv_object_view.HideCustomizationForm
        If message_text("Desea guardar la configuración de campos seleccionada?", MessageBoxButtons.YesNo) = DialogResult.Yes Then dgv_object_view.SaveLayoutToXml("C:\APDA\BIM\bin\" & Me.Name & ".xml")
    End Sub

    Private Sub selected_copy(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv_object_view.KeyDown
        Dim view As GridView = CType(sender, GridView)
        If e.Control AndAlso e.KeyCode = Keys.C Then
            If view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn) IsNot Nothing AndAlso view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString() <> [String].Empty Then
                Clipboard.SetText(view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString())
            End If
            e.Handled = True
        End If
    End Sub

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

    Private Sub custom_layout()
        If My.Computer.FileSystem.FileExists("C:\APDA\BIM\bin\" & Me.Name & ".xml") Then dgv_object_view.RestoreLayoutFromXml("C:\APDA\BIM\bin\" & Me.Name & ".xml")
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_close.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub
#End Region

#Region "helpers"
    Private Sub objects_condition()
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Fecha de venta", "s.date_sale", GetType(Date), New RepositoryDate, FilterColumnClauseClass.DateTime))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Nombre de consultor", "s.person_code", GetType(Integer), New RepositoryChecked(person.settings_persons_listed("p.row_visible=1"), "Nombre del funcionario"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Agencia", "s.agency_code", GetType(Integer), New RepositoryChecked(agency.settings_agencys_search("row_visible=1"), "agency_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Distribuidor", "s.dealer_code", GetType(Integer), New RepositoryChecked(dealer.settings_dealers_search("row_visible=1"), "dealer_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Canal de ventas", "s.channel_code", GetType(Integer), New RepositoryChecked(channel.settings_channels_search("row_visible=1"), "channel_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Convergente", "s.mark_convergent", GetType(Integer), New RepositoryListed(parameters.settings_search_yesno2, "yes_no"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Lider de venta", "s.leader_code", GetType(Integer), New RepositoryChecked(person.settings_persons_leaders("d.director_code=3"), "person_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Portabilidad", "s.mark_ported", GetType(Integer), New RepositoryListed(parameters.settings_search_yesno2, "yes_no"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Migración", "s.mark_migration", GetType(Integer), New RepositoryListed(parameters.settings_search_yesno2, "yes_no"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Anticipo CFM", "s.mark_advance", GetType(Integer), New RepositoryListed(parameters.settings_search_yesno2, "yes_no"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Cargo Fijo", "s.value_sales1", GetType(Integer), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Valor de equipo", "s.value_sales2", GetType(Integer), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("MIN", "s.number_serial1", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("ICCID", "s.number_serial2", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("IMEI", "s.number_serial3", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Numero de cuenta", "s.segment_code=2 and s.number_serial1", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Serial y/o Referencia", "s.segment_code=3 and s.number_serial1", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Numero de contrato", "s.number_contract", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Numero de factura", "s.number_invoice", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Segmento de negocio", "s.segment_code", GetType(Integer), New RepositoryChecked(parameters.settings_search_segments("row_visible=1"), "segment_name"), FilterColumnClauseClass.Lookup))
    End Sub

    Private Function criteria_condition() As String
        Dim type_group As GroupOperator = TryCast(txt_rules_criteria.FilterCriteria, GroupOperator)

        If type_group IsNot Nothing Then Return type_conditions(type_group) Else Return type_conditions(txt_rules_criteria.FilterCriteria)
    End Function

    Private Function type_conditions(group_condition As GroupOperator) As String
        Dim condition_string As String = Nothing
        Dim condition_criteria As Object = Nothing

        If group_condition IsNot Nothing Then
            For Each condition As CriteriaOperator In group_condition.Operands
                If TypeOf condition Is BinaryOperator Then condition_criteria = TryCast(condition, BinaryOperator)
                If TypeOf condition Is InOperator Then condition_criteria = TryCast(condition, InOperator)
                If TypeOf condition Is BetweenOperator Then condition_criteria = TryCast(condition, BetweenOperator)
                If TypeOf condition Is UnaryOperator Then condition_criteria = TryCast(condition, UnaryOperator)

                If condition_string Is Nothing Then condition_string = operand_condition(condition_criteria) Else condition_string += condition_group(group_condition.OperatorType) & operand_condition(condition_criteria)
            Next
        End If

        Return condition_string
    End Function

    Private Function type_conditions(condition As CriteriaOperator) As String
        Dim condition_criteria As Object = Nothing

        If TypeOf condition Is BinaryOperator Then condition_criteria = TryCast(condition, BinaryOperator)
        If TypeOf condition Is InOperator Then condition_criteria = TryCast(condition, InOperator)
        If TypeOf condition Is BetweenOperator Then condition_criteria = TryCast(condition, BetweenOperator)
        If TypeOf condition Is UnaryOperator Then condition_criteria = TryCast(condition, UnaryOperator)

        Return operand_condition(condition_criteria)
    End Function

    Public Function operand_condition(operand As BinaryOperator) As String
        Dim value_property As OperandProperty
        Dim value_operand1 As OperandValue

        value_property = TryCast(operand.LeftOperand, OperandProperty)
        value_operand1 = TryCast(operand.RightOperand, OperandValue)

        Return CStr(value_property.PropertyName & operator_type(operand.OperatorType) & Replace(value_type(value_operand1), " ", ""))
    End Function

    Public Function operand_condition(operand As InOperator) As String
        Dim value_property As OperandProperty
        Dim value_operand1 As OperandValue

        value_property = TryCast(operand.LeftOperand, OperandProperty)
        value_operand1 = TryCast(operand.Operands(0), OperandValue)

        Return CStr(value_property.PropertyName & " in (" & Replace(value_operand1.Value, " ", "") & ")")
    End Function

    Public Function operand_condition(operand As UnaryOperator) As String
        Dim operand_object As InOperator = TryCast(operand.Operand, InOperator)
        Dim value_property As OperandProperty
        Dim value_operand1 As OperandValue

        value_property = TryCast(operand_object.LeftOperand, OperandProperty)
        value_operand1 = TryCast(operand_object.Operands(0), OperandValue)

        Return CStr(value_property.PropertyName & " not in (" & Replace(value_operand1.Value, " ", "") & ")")
    End Function

    Public Function operand_condition(operand As BetweenOperator) As String
        Dim value_property As OperandProperty
        Dim value_operand1 As OperandValue
        Dim value_operand2 As OperandValue

        value_property = TryCast(operand.TestExpression, OperandProperty)
        value_operand1 = TryCast(operand.BeginExpression, OperandValue)
        value_operand2 = TryCast(operand.EndExpression, OperandValue)

        Return CStr(value_property.PropertyName & " between " & value_type(value_operand1) & " and " & value_type(value_operand2))
    End Function

    Private Function operator_type(typeoperator As BinaryOperatorType) As String
        Dim operator_string As String = ""

        If typeoperator = BinaryOperatorType.Equal Then operator_string = "="
        If typeoperator = BinaryOperatorType.Less Then operator_string = "<"
        If typeoperator = BinaryOperatorType.LessOrEqual Then operator_string = "<="
        If typeoperator = BinaryOperatorType.Greater Then operator_string = ">"
        If typeoperator = BinaryOperatorType.GreaterOrEqual Then operator_string = ">="
        If typeoperator = BinaryOperatorType.NotEqual Then operator_string = " <> "

        Return operator_string
    End Function

    Private Function value_type(value_operator As OperandValue) As String
        Dim value_string As String = ""

        If TypeOf value_operator.Value Is Date Then
            value_string = "'" & CDate(value_operator.Value).ToString("yyyy-MM-dd") & "'"
        End If

        If TypeOf value_operator.Value Is Integer Then
            value_string = CInt(value_operator.Value)
        End If

        If TypeOf value_operator.Value Is String Then
            value_string = "'" & CStr(value_operator.Value).ToString & "'"
        End If

        Return value_string
    End Function

    Private Function condition_group(typeofoperator As GroupOperatorType) As String
        Dim condition_string As String = ""

        If typeofoperator = GroupOperatorType.And Then condition_string = " and "
        If typeofoperator = GroupOperatorType.Or Then condition_string = " or "

        Return condition_string
    End Function
#End Region

#Region "options"
    Private Sub find_option(sender As Object, e As EventArgs) Handles btn_object_find.Click
        If txt_rules_criteria.FilterString = "" Then
            reports_show("s.status_code=3")
        Else
            'define parameter with condition rules
            reports_show(criteria_condition() & " and s.status_code=3")
        End If
    End Sub

    Private Sub create_option(sender As Object, e As EventArgs) Handles btn_object_new.Click
        show_option(New commision_settleds_create)
    End Sub

    Private Sub edited_option(sender As Object, e As EventArgs) Handles btn_object_edit.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea modificar el registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Select Case (dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Segmento"))
                    Case "Movil" : show_option(New wholesales_movil_edited(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id"), Me))
                    Case "Hogar" : show_option(New wholesales_hogar_edited(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id"), Me))
                    Case "Libres" : show_option(New wholesales_frees_edited(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id"), Me))
                End Select
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub erased_option(sender As Object, e As EventArgs) Handles btn_object_erase.Click
        If dgv_object_view.RowCount > 0 Then
            If message_text("Está seguro que desea anular los registros seleccionados?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                    If dgv_object_view.IsRowSelected(i) = True Then
                        sales.wholesale_sales_erase(dgv_object_view.GetRowCellValue(i, "Id"), 2, False)
                    End If
                Next

                'return message to end process
                If message_text("Los registros seleccionados fueron actualizados exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then reports_show(criteria_search)
            End If
        End If
    End Sub

    Private Sub search_option(sender As Object, e As EventArgs) Handles btn_object_search.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea ver el registro seleccionado en busqueda rapida?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                show_option(New wholesales_masters_details(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id")))
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub status_option(sender As Object, e As EventArgs) Handles btn_object_exclude.Click
        If dgv_object_view.SelectedRowsCount.ToString >= 1 Then
            If message_text("Está seguro que desea excluir de la liquidación los registros seleccionados?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                    If dgv_object_view.IsRowSelected(i) = True Then
                        sales.wholesale_sales_status(dgv_object_view.GetRowCellValue(i, "Id"), 5, False)
                    End If
                Next

                'return message to end process
                If message_text("Los registros seleccionados fueron actualizados exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then reports_show(criteria_search)
            End If
        End If
    End Sub

    Private Sub settled_option(sender As Object, e As EventArgs) Handles btn_object_settled.Click
        If dgv_object_view.RowCount > 0 Then
            If message_text("Está seguro que desea liquidar manualmente los registros seleccionados?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                'crea la lista de objetos de liq. manual
                Dim rows_selected As New List(Of PaymentManual)

                'recorre las filas seleccionadas y las agrega a la lista
                For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                    If dgv_object_view.IsRowSelected(i) Then
                        rows_selected.Add(New PaymentManual With {.wholesale = dgv_object_view.GetRowCellValue(i, "Id"),
                                                                                                                 .person_code = dgv_object_view.GetRowCellValue(i, "person_code")})
                    End If
                Next

                'valida que exista objectos agregados a la lista
                If rows_selected.Count > 0 Then show_option(New commision_settleds_manual(rows_selected, Me))
            Else
                message_text("No se detectó filas seleccionadas", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub discount_option(sender As Object, e As EventArgs) Handles btn_object_discount.Click
        If dgv_object_view.RowCount > 0 Then
            If message_text("Está seguro que desea crear un descuento de comisión  al registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                'crea la lista de objetos de liq. manual
                Dim rows_selected As New List(Of Integer)

                'recorre las filas seleccionadas y las agrega a la lista
                For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                    If dgv_object_view.IsRowSelected(i) Then
                        rows_selected.Add(CInt(dgv_object_view.GetRowCellValue(i, "Id")))
                    End If
                Next

                'comprueba que se agregado las filas seleccionadas
                If rows_selected.Count > 0 Then
                    Using new_ As New wholesales_masters_discount(rows_selected)
                        new_.ShowDialog(start_home)
                    End Using
                Else
                    message_text("No se encontró filas seleccionadas", MessageBoxButtons.OK)
                End If
            End If
        End If
    End Sub

    Private Sub synchronize_option(sender As Object, e As EventArgs) Handles btn_object_update.Click
        If txt_rules_criteria.FilterString = "" Then
            reports_show("s.status_code=3")
        Else
            'define parameter with condition rules
            reports_show(criteria_condition() & " and s.status_code=3")
        End If
    End Sub

    Private Sub exported_option(sender As Object, e As EventArgs) Handles btn_object_export.Click
        If dgv_object_view.RowCount > 0 Then
            Using export As New model_object_export(dgv_object_view)
                export.ShowDialog(start_home)
            End Using
        End If
    End Sub

    Private Sub fields_selector(sender As Object, e As EventArgs) Handles object_button_fields.Click
        If dgv_object_view.RowCount > 0 Then dgv_object_view.ShowCustomization()
    End Sub

    Private Sub group_option(sender As Object, e As EventArgs) Handles btn_object_panel.Click
        With dgv_object_view.OptionsView
            .ShowGroupPanel = If(.ShowGroupPanel = False, True, False)
        End With
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_close.Click
       Dispose()
    End Sub
#End Region
End Class
