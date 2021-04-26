Imports APDA.Object.Controls
Imports DevExpress.Data.Filtering
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class commision_subsettleds_search
    Private operators As Operators = Operators.Instance
    Private dealer As Dealers = Dealers.Instance
    Private parameter As Parameters = Parameters.Instance
    Private agency As Agencys = Agencys.Instance
    Private person As Persons = Persons.Instance
    Private channel As Channels = Channels.Instance
    Private period As Periods = Periods.Instance
    Private commision As Commision = Commision.Instance
    Private criteria_search As String = String.Empty

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()

        'apply all permits assigned per current module
        search_permits()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load conditions object to filter
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
                    If .Select("action_object='btn_object_find' and option_showed='" & Me.Name & "'").Count = 0 Then
                        btn_object_find.Size = btn_object_find.MinimumSize
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
        Dim source As DataTable = commision.commision_subpayments_show(criteria_search)

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
                .Columns("wholesales_code").Visible = False
                .Columns("total_payment").Visible = False
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
                    pnl_object_flyout.Options.Location = hi.HitPoint
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
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Fecha de liquidación", "convert(date,p.event_date)", GetType(Date), New RepositoryDate, FilterColumnClauseClass.DateTime))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Nombre de pagador", "p.person_code", GetType(Integer), New RepositoryChecked(person.settings_persons_listed("p.row_visible=1"), "Nombre del funcionario"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Nombre de consultor", "s.person_code", GetType(Integer), New RepositoryChecked(person.settings_persons_listed("p.row_visible=1"), "Nombre del funcionario"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Agencia", "s.agency_code", GetType(Integer), New RepositoryChecked(agency.settings_agencys_search("row_visible=1"), "agency_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Distribuidor", "s.dealer_code", GetType(Integer), New RepositoryChecked(dealer.settings_dealers_search("row_visible=1"), "dealer_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Canal de ventas", "s.channel_code", GetType(Integer), New RepositoryChecked(channel.settings_channels_search("row_visible=1"), "channel_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Lider de venta", "s.leader_code", GetType(Integer), New RepositoryChecked(person.settings_persons_leaders("d.director_code=3"), "person_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("MIN", "s.number_serial1", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("ICCID", "s.number_serial2", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("IMEI", "s.number_serial3", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Numero de cuenta", "s.segment_code=2 and s.number_serial1", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Serial y/o Referencia", "s.segment_code=3 and s.number_serial1", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Contrato", "s.number_contract", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Factura", "s.number_invoice", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Comprobante", "p.proof_payment", GetType(String), New RepositoryItemTextEdit, FilterColumnClauseClass.String))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Periodo de liquidación", "p.period_code", GetType(Integer), New RepositoryChecked(period.commision_periods_search("p.row_visible in (1,3) and p.can_subsettled=1"), "period_name"), FilterColumnClauseClass.Lookup))
        txt_rules_criteria.FilterColumns.Add(New UnboundFilterColumn("Segmento", "s.segment_code", GetType(Integer), New RepositoryChecked(parameter.settings_search_segments("row_visible=1"), "segment_name"), FilterColumnClauseClass.Lookup))
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
    Private Sub create_option(sender As Object, e As EventArgs) Handles btn_object_new.Click
        show_option(New commision_subsettleds_create)
    End Sub

    Private Sub finder_option(sender As Object, e As EventArgs) Handles btn_object_find.Click
        If criteria_condition() <> "" Then
            criteria_search = criteria_condition()

            If criteria_search <> "" Then reports_show(criteria_search)
        End If
    End Sub

    Private Sub edited_option(sender As Object, e As EventArgs) Handles btn_object_edit.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea modificar el registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                show_option(New commision_settleds_edited(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id")))
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub proof_option(sender As Object, e As EventArgs) Handles btn_object_proof.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea generar el comprobante de pago al registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim new_ As New commision_proofs_viewer(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "wholesales_code"))
                new_.Show()
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
                        commision.commision_subpayments_erase(dgv_object_view.GetRowCellValue(i, "Id"), dgv_object_view.GetRowCellValue(i, "wholesales_code"), False)
                    End If
                Next

                'return message to end process
                If message_text("Los registros seleccionados fueron anulados exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then reports_show(criteria_search)
            End If
        End If
    End Sub

    Private Sub search_option(sender As Object, e As EventArgs) Handles btn_object_search.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If message_text("Está seguro que desea ver el registro seleccionado en busqueda rapida?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                show_option(New wholesales_masters_details(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "wholesales_code")))
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub cleaned_option(sender As Object, e As EventArgs) Handles btn_object_clean.Click
        dgv_object_grid.DataSource = Nothing
        dgv_object_view.Columns.Clear()
        lbl_object_count.Text = 0
    End Sub

    Private Sub synchronize_option(sender As Object, e As EventArgs) Handles btn_object_update.Click
        If criteria_search <> "" Then reports_show(criteria_search)
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
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
