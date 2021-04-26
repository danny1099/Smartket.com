Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop
Imports System.IO

Public Class financial_masters_pagare
    Private financial As Financial = Financial.Instance
    Private source_table As System.Data.DataTable
    Private row_affected As Integer

    Property IsGeneratePagare As Boolean
    Property IsGenerateCarta As Boolean

#Region "constructor"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        row_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        search_formats(row_affected)
    End Sub
#End Region

#Region "behaviors"
    Private Sub search_formats(row_selected As Integer)
        source_table = financial.financial_request_formats("r.Id=" & row_selected)

        'Limpia los origenes de datos anteriores
        txt_object_file.Text = Nothing
    End Sub

    Private Function create_pagare(file_name As String, source_table As System.Data.DataTable) As String
        Dim object_support As Byte() = My.Resources.formato_pagare()
        Dim document_word As Word.Document
        Dim app_word As New Word.Application With {.Visible = False}

        If object_support IsNot Nothing Then
            'Crea el formato en el escritorio del usuario
            File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Pagare_" & file_name & ".docx", object_support)

            'Con la apertura del archivo de word buscamos los campos
            document_word = app_word.Documents.Open(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Pagare_" & file_name & ".docx")

            'Busca los campos requeridos para diligenciar el pagaré
            Dim table_search As System.Data.DataTable = fn_structure_pagare(source_table)

            'Recorre los items de la tabla creada por cada dato a cambiar en el formato
            For i As Integer = 0 To table_search.Rows.Count - 1
                With document_word
                    .ActiveWindow.Selection.Find.Text = table_search.Rows(i).Item("field_name")
                    .ActiveWindow.Selection.Find.Forward = True
                    .ActiveWindow.Selection.Find.MatchCase = False

                    'Comprueba si encontró datos con el texto a buscar
                    If .ActiveWindow.Selection.Find.Execute() Then
                        .ActiveWindow.Selection.MoveRight(Unit:=WdUnits.wdCharacter, Count:=1)
                        .ActiveWindow.Selection.TypeText(Text:=table_search.Rows(i).Item("field_value").ToString)
                    End If
                End With
            Next

            'Cierra los objectos usados
            document_word.Save()
            document_word.Close()
            app_word.Quit()
            app_word = Nothing

            'Regresa la ruta del archivo
            Return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Pagare_" & file_name & ".docx"
        End If

        Return Nothing
    End Function

    Private Function create_carta(file_name As String, source_table As System.Data.DataTable) As String
        Dim object_support As Byte() = My.Resources.formato_instrucciones()
        Dim document_word As Word.Document
        Dim app_word As New Word.Application With {.Visible = False}

        If object_support IsNot Nothing Then
            'Crea el formato en el escritorio del usuario
            File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Carta_" & file_name & ".docx", object_support)

            'Con la apertura del archivo de word buscamos los campos
            document_word = app_word.Documents.Open(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Carta_" & file_name & ".docx")

            'Busca los campos requeridos para diligenciar el pagaré
            Dim table_search As System.Data.DataTable = fn_structure_carta(source_table)

            'Recorre los items de la tabla creada por cada dato a cambiar en el formato
            For i As Integer = 0 To table_search.Rows.Count - 1
                With document_word
                    .ActiveWindow.Selection.Find.Text = table_search.Rows(i).Item("field_name")
                    .ActiveWindow.Selection.Find.Forward = True
                    .ActiveWindow.Selection.Find.MatchCase = False

                    'Comprueba si encontró datos con el texto a buscar
                    If .ActiveWindow.Selection.Find.Execute() Then
                        .ActiveWindow.Selection.MoveRight(Unit:=WdUnits.wdCharacter, Count:=1)
                        .ActiveWindow.Selection.TypeText(Text:=table_search.Rows(i).Item("field_value").ToString)
                    End If
                End With
            Next

            'Cierra los objectos usados
            document_word.Save()
            document_word.Close()
            app_word.Quit()
            app_word = Nothing

            'Regresa la ruta del archivo
            Return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Carta_" & file_name & ".docx"
        End If

        Return Nothing
    End Function

    Private Function fn_structure_pagare(source_table As System.Data.DataTable) As System.Data.DataTable
        Dim table_structure As New System.Data.DataTable

        With table_structure
            .Columns.Add("field_name")
            .Columns.Add("field_value")

            'Agrega como filas los campos para buscar
            .Rows.Add("PAGARÉ No:", " " & source_table.Rows(0).Item("Id").ToString)
            .Rows.Add("PLAZO DE PAGO:", " " & source_table.Rows(0).Item("deadlines").ToString & " Cuotas")
            .Rows.Add("FECHA DE PAGO DE LA PRIMERA CUOTA:", " " & CDate(source_table.Rows(0).Item("payment_date").ToString).ToShortDateString)
            .Rows.Add("LUGAR PARA EL PAGO DEL CRÉDITO:", " " & StrConv(source_table.Rows(0).Item("city_name").ToString, VbStrConv.Uppercase))
            .Rows.Add("El abajo firmante", " " & source_table.Rows(0).Item("person_name").ToString)
            .Rows.Add("Cedula de Ciudadanía", " " & source_table.Rows(0).Item("number_document").ToString)
            .Rows.Add("firmo(amos) en la ciudad de", " " & source_table.Rows(0).Item("city_name").ToString)
            .Rows.Add("DIA (", Format(Now, "dd"))
            .Rows.Add("MES (", Format(Now, "MM"))
        End With

        Return table_structure
    End Function

    Private Function fn_structure_carta(source_table As System.Data.DataTable) As System.Data.DataTable
        Dim table_structure As New System.Data.DataTable

        With table_structure
            .Columns.Add("field_name")
            .Columns.Add("field_value")

            'Agrega como filas los campos para buscar
            .Rows.Add("El abajo firmante", " " & source_table.Rows(0).Item("person_name").ToString)
            .Rows.Add("Cedula de Ciudadanía", " " & source_table.Rows(0).Item("number_document").ToString)
            .Rows.Add("firmo(amos) en la ciudad de", " " & source_table.Rows(0).Item("city_name").ToString)
            .Rows.Add("DIA (", Format(Now, "dd"))
            .Rows.Add("MES (", Format(Now, "MM"))
        End With

        Return table_structure
    End Function

    Private Sub closed_formats(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Equals(IsGeneratePagare, IsGenerateCarta) = True Then
            e.Cancel = False
        Else
            If message_text("Falta generar el formato: " & If(IsGeneratePagare = False, "Pagaré", If(IsGenerateCarta = False, "Carta de instrucciones", "Pagaré y Carta de instrucciones")), MessageBoxButtons.OK) = DialogResult.OK Then e.Cancel = True
        End If
    End Sub
#End Region

#Region "options"
    Private Sub generate_pagare(sender As Object, e As EventArgs) Handles btn_object_pagare.Click
        With txt_object_file
            .Text = Nothing
            .LoadDocument(create_pagare(source_table.Rows(0).Item("number_document").ToString, source_table))

            If .Document IsNot Nothing Then
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Pagare_" & source_table.Rows(0).Item("number_document").ToString & ".docx")
                IsGeneratePagare = True
            End If
        End With
    End Sub

    Private Sub generate_carta(sender As Object, e As EventArgs) Handles btn_object_instruccion.Click
        With txt_object_file
            .Text = Nothing
            .LoadDocument(create_carta(source_table.Rows(0).Item("number_document").ToString, source_table))

            If .Document IsNot Nothing Then
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Carta_" & source_table.Rows(0).Item("number_document").ToString & ".docx")
                IsGenerateCarta = True
            End If
        End With
    End Sub

    Private Sub printer_option(sender As Object, e As EventArgs) Handles btn_object_printer.Click
        With txt_object_file
            If .Document IsNot Nothing Then
                .ShowPrintPreview()
            End If
        End With
    End Sub
#End Region
End Class