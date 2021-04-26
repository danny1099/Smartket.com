Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Public Class settings_persons_resume
    Private person As Persons = Persons.Instance
    Private curren_object As String
    Private record_affected As Integer

#Region "constructors"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set parameter value in variable record_affected
        record_affected = row_selected
    End Sub

    Public Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load report to show data in lookup
        search_person()
    End Sub

    Private Sub search_person()
        Dim table As DataTable = person.settings_persons_search("p.Id=" & record_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                txt_name_person.Text = .Item("person_name").ToString
                txt_access_name.Text = "@" & .Item("user_access").ToString & If(.Item("user_blocked") = "True", " (Bloqueado)", "")
                txt_agency_name.Text = .Item("agency_name").ToString
                txt_position_name.Text = .Item("position_name").ToString

                'check if current user dont have useraccess
                If .Item("user_access").ToString = "" Then txt_access_name.Text = "@Undefined"

                'check if current user have photo
                If .Item("photo_avatar").ToString <> "" Then pic_object_photo.Image = fn_transform_image(.Item("photo_avatar")) Else pic_object_photo.Image = My.Resources.photo_default
            End With
        End If
    End Sub
#End Region

#Region "behaviors"
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
                .Columns("Id").Visible = False
                .Columns("person_code").Visible = False
                .BestFitColumns(True)
                .SelectRow(0)

                'check if exists column "Meses" to center cell
                If .Columns("Meses") IsNot Nothing Then .Columns("Meses").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center

                'comprueba el total de columnas para realizar el ajuste
                .OptionsView.ColumnAutoWidth = If(.Columns.Count <= 10, True, False)

                'define el total de filas en la etiqueta de totales
                lbl_object_count.Text = .RowCount.ToString
            End With
        End If
    End Sub

    Public Sub interface_search()
        With My.Settings
            btn_object_close.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub count_rows(sender As Object, e As EventArgs) Handles dgv_object_view.ColumnFilterChanged
        lbl_object_count.Text = dgv_object_view.RowCount.ToString
    End Sub

    Private Sub selected_process(sender As Object, e As EventArgs) Handles lbl_object_password.Click, lbl_object_leader.Click, lbl_object_directors.Click, lbl_object_channel.Click, lbl_object_agency.Click, lbl_object_permittions.Click, lbl_object_budgets.Click
        'set current process with selected object clicked
        curren_object = sender.Tag.ToString
        lbl_object_current.Text = sender.Text

        If curren_object IsNot Nothing Then
            reports_show(search_data(curren_object))
        End If
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

    Private Function search_data(process_name As String) As DataTable
        Try
            Return CallByName(person, process_name, CallType.Method, "p.Id=" & record_affected)
        Catch ex As Exception
        End Try

        Throw New ArgumentException
    End Function
#End Region

#Region "options"
    Private Sub create_option(sender As Object, e As EventArgs) Handles btn_object_new.Click
        Select Case curren_object
            Case "helpers_agency_show" : search_form("persons_agencys_create", record_affected)
            Case "helpers_channel_show" : search_form("persons_channels_create", record_affected)
            Case "helpers_director_show" : search_form("persons_directors_create", record_affected)
            Case "helpers_leaders_show" : search_form("persons_leaders_create", record_affected)
            Case "helpers_permittion_show" : search_form("persons_permits_create", record_affected)
            Case "helpers_budgets_show" : search_form("settings_budgets_create", record_affected)
            Case "helpers_password_show" : search_form("persons_password_create", record_affected)
        End Select
    End Sub

    Private Sub erased_option(sender As Object, e As EventArgs) Handles btn_object_erase.Click
        If dgv_object_view.RowCount > 0 Then
            If message_text("Está seguro que desea eliminar los registros seleccionados?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                    If dgv_object_view.IsRowSelected(i) = True Then
                        Select Case curren_object
                            Case "helpers_agency_show" : person.helpers_agency_erase(dgv_object_view.GetRowCellValue(i, "Id"), False)
                            Case "helpers_channel_show" : person.helpers_channel_erase(dgv_object_view.GetRowCellValue(i, "Id"), False)
                            Case "helpers_director_show" : person.helpers_director_erase(dgv_object_view.GetRowCellValue(i, "Id"), False)
                            Case "helpers_leaders_show" : person.helpers_leaders_erase(dgv_object_view.GetRowCellValue(i, "Id"), False)
                            Case "helpers_permittion_show" : person.helpers_permittion_erase(dgv_object_view.GetRowCellValue(i, "Id"), False)
                            Case "helpers_budgets_show" : person.helpers_budgets_erase(dgv_object_view.GetRowCellValue(i, "Id"), False)
                        End Select
                    End If
                Next

                'return message to end process
                message_text("Los registros seleccionados fueron anulados exitosamente", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub edited_option(sender As Object, e As EventArgs) Handles btn_object_edit.Click
        If dgv_object_view.SelectedRowsCount.ToString = 1 Then
            If curren_object = "lbl_object_budgets" Then
                If message_text("Está seguro que desea modificar el registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Using edit_ As New settings_budgets_edited(dgv_object_view.GetRowCellValue(dgv_object_view.FocusedRowHandle, "Id"))
                        edit_.ShowDialog(start_home)
                    End Using
                End If
            Else
                message_text("La acción no se puede realizar con la consulta actual", MessageBoxButtons.OK)
            End If
        Else
            message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub users_option(sender As Object, e As EventArgs) Handles txt_access_name.Click
        If txt_access_name.Text.Contains("(Bloqueado)") Then
            If person.helpers_password_unlock(record_affected) = True Then
                search_person()
            End If
        ElseIf txt_access_name.Text.Contains("Undefined") Then
            If message_text("Está seguro que desea asignar un usuario de acceso al funcionario seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using new_ As New persons_users_create(record_affected)
                    new_.ShowDialog(start_home)

                    'set new user acces
                    txt_access_name.Text = "@" & new_.txt_useraccess_name.EditValue
                End Using
            End If
        End If
    End Sub

    Private Sub synchronize_option(sender As Object, e As EventArgs) Handles btn_object_update.Click
        reports_show(search_data(curren_object))
    End Sub

    Private Sub Exported(sender As Object, e As EventArgs) Handles btn_object_export.Click
        If dgv_object_view.RowCount > 0 Then
            Using export As New model_object_export(dgv_object_view)
                export.ShowDialog(start_home)
            End Using
        End If
    End Sub

    Private Sub Printer(sender As Object, e As EventArgs)
        If dgv_object_view.RowCount > 0 Then dgv_object_view.ShowPrintPreview()
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_close.Click, btn_object_back.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
