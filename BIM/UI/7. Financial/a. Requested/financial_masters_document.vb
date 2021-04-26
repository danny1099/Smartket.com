Imports System.IO
Imports DevExpress.XtraEditors.Controls

Public Class financial_masters_document
    Private document As Documents = Documents.Instance
    Private source_images As New List(Of String)
    Private row_affected As Integer

#Region "constructor"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        row_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        reports_show(row_affected)
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub load_images(file_name As String, object_support As Byte())
        If object_support IsNot Nothing Then
            With view_object_images
                .Image = fn_transform_image(object_support)
            End With
        End If
    End Sub

    Private Sub zoom_changed(sender As Object, e As EventArgs) Handles txt_object_zoom.EditValueChanged
        Select Case txt_object_zoom.EditValue
            Case 1 : view_object_images.Properties.ZoomPercent = 100
            Case 2 : view_object_images.Properties.ZoomPercent = 150
            Case 3 : view_object_images.Properties.ZoomPercent = 200
            Case 4 : view_object_images.Properties.ZoomPercent = 500
        End Select
    End Sub

    Public Sub reports_show(row_selected As Integer)
        Dim source As DataTable = document.documents_master_search(row_selected, "Entities.Financial.Request")

        'Limpia los origenes de datos anteriores
        pnl_object_nodes.DataSource = Nothing
        pnl_object_nodes.Items.Clear()

        'comprueba si la consulta tiene filas para mostrar
        If source.Rows.Count > 0 Then
            With pnl_object_nodes
                .DataSource = source
                .ValueMember = "Id"
                .DisplayMember = "document_name"
            End With
        End If
    End Sub

    Private Sub document_selected(sender As Object, e As EventArgs) Handles pnl_object_nodes.SelectedValueChanged
        With pnl_object_nodes
            For Each row As DataRowView In .SelectedItems
                Dim file_name As String = row.Row.Item("document_name").ToString
                Dim object_array As Byte() = TryCast(row.Row.Item("document_support"), Byte())
                Dim file_format As String = row.Row.Item("document_format").ToString

                If file_format = ".pdf" Then
                    define_viewer(True)
                    load_document(file_name, object_array)
                Else
                    define_viewer(False)
                    load_images(file_name, object_array)
                End If
                Exit For
            Next
        End With
    End Sub

    Private Sub load_document(file_name As String, object_support As Byte())
        If object_support IsNot Nothing Then
            With view_object_pdf
                .LoadDocument(create_document(file_name, object_support))
            End With
        End If
    End Sub

    Private Function create_document(file_name As String, object_support As Byte()) As String
        'Valida si esta creado para retornar 
        If Not File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & file_name & ".pdf") = True Then
            File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & file_name & ".pdf", object_support)
        End If

        Return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & file_name & ".pdf"
    End Function

    Private Sub define_viewer(use_pdf As Boolean)
        If use_pdf = True Then
            With view_object_images
                .Dock = DockStyle.Left
                .Width = 0
                txt_object_zoom.Height = 0
            End With
            With view_object_pdf
                .Dock = DockStyle.Fill
                .Width = 700
            End With
        Else
            With view_object_pdf
                .Dock = DockStyle.Left
                .Width = 0
            End With
            With view_object_images
                .Dock = DockStyle.Fill
                .Width = 700
                txt_object_zoom.Height = 45
            End With
        End If
    End Sub
#End Region

#Region "options"
    Private Sub adding_document(sender As Object, e As EventArgs) Handles btn_object_new.Click
        If xfd_path.ShowDialog = DialogResult.OK Then
            If message_text("Está seguro que desea agregar la(s) imagen(es) seleccionada(s)?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                For Each item_name As String In xfd_path.FileNames
                    With source_images
                        .Add(item_name)
                    End With
                Next

                'Comprueba que el listado de bytes este cargado para mostrar el mensaje de finalizado
                If source_images.Count >= 1 Then
                    If document.documents_master_create(row_affected, "Entities.Financial.Request", source_images) = True Then
                        If message_text("Los documentos fueron cargados exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then
                            reports_show(row_affected)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub remove_document(sender As Object, e As EventArgs) Handles btn_object_erase.Click
        If message_text("Está seguro que desea eliminar el registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            With pnl_object_nodes
                If .SelectedValue IsNot Nothing Then
                    If document.documents_master_remove(.SelectedValue) = True Then
                        reports_show(row_affected)
                    End If
                End If
            End With
        End If
    End Sub
#End Region
End Class