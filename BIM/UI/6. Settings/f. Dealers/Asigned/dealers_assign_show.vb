Public Class dealers_assign_show
    Private dealer As Dealers = Dealers.Instance
    Private record_affected As Integer

#Region "constructor"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        record_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'execute procedure to load sources and search current object
        reports_show("dr.dealer_code=" & record_affected & " and dr.row_visible=1")
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Public Sub reports_show(Optional criteria_search As String = "")
        Dim source As DataTable = dealer.dealers_distributary_search(criteria_search)

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
                .Columns("dealer_name").Caption = "Distribuidor"
                .Columns("agency_name").Caption = "Agencia"
                .Columns("segment_name").Caption = "Segmento"
                .Columns("row_visible").Visible = False
                .BestFitColumns(True)
                .SelectRow(0)

                'comprueba el total de columnas para realizar el ajuste
                .OptionsView.ColumnAutoWidth = If(.Columns.Count <= 10, True, False)

                'define el total de filas en la etiqueta de totales
                lbl_object_count.Text = .RowCount.ToString
            End With
        End If
    End Sub

    Private Sub count_rows(sender As Object, e As EventArgs) Handles dgv_object_view.ColumnFilterChanged
        lbl_object_count.Text = dgv_object_view.RowCount.ToString
    End Sub
#End Region

#Region "options"
    Private Sub create_option(sender As Object, e As EventArgs) Handles btn_object_new.Click
        Using new_ As New dealers_assign_create(record_affected)
            new_.ShowDialog(start_home)
        End Using

        'update report to listed
        reports_show("dr.dealer_code=" & record_affected & " and dr.row_visible=1")
    End Sub

    Private Sub erased_option(sender As Object, e As EventArgs) Handles btn_object_erase.Click
        If dgv_object_view.RowCount > 0 Then
            If message_text("Está seguro que desea eliminar los registros seleccionados?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                    If dgv_object_view.IsRowSelected(i) = True Then
                        dealer.dealers_distributary_erase(dgv_object_view.GetRowCellValue(i, "Id"), False)
                    End If
                Next

                'return message to end process
                If message_text("Los registros seleccionados fueron anulados exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then reports_show("dr.dealer_code=" & record_affected & " and dr.row_visible=1")
            End If
        End If
    End Sub

    Private Sub synchronize_option(sender As Object, e As EventArgs) Handles btn_object_update.Click
        reports_show("dr.dealer_code=" & record_affected & " and dr.row_visible=1")
    End Sub

    Private Sub exported_option(sender As Object, e As EventArgs) Handles btn_object_export.Click
        If dgv_object_view.RowCount > 0 Then
            Using export As New model_object_export(dgv_object_view)
                export.ShowDialog(start_home)
            End Using
        End If
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