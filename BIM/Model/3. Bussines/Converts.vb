Imports System.ComponentModel
Imports System.IO
Imports System.Reflection

Public Module Converts
    Public Function fn_transform_bytes(imagen As Image) As Byte()
        Dim arreglo As Byte() = Nothing
        Try
            If Not imagen Is Nothing Then
                Dim Bin As New MemoryStream
                imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
                arreglo = Bin.ToArray()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("No convirtio a bytes por: " + ex.ToString)
        End Try
        Return arreglo
    End Function

    Public Function fn_transform_bytes(document_object As String) As Byte()
        Try
            If document_object IsNot Nothing Then
                Dim file_selected As New FileStream(document_object, FileMode.Open, FileAccess.Read)
                Dim file_bytes() As Byte
                ReDim file_bytes(file_selected.Length)
                file_selected.Read(file_bytes, 0, file_selected.Length)

                Return file_bytes
            End If
        Catch ex As Exception
        End Try

        Return Nothing
    End Function

    Public Sub fn_transform_object(file_object As Byte(), file_name As String, file_extension As String)
        Try
            If file_object IsNot Nothing Then
                File.WriteAllBytes(Replace(file_name, " ", "_") & file_extension, file_object)

                'Crea el proceso para mostrar el archivo
                Dim object_process As New Process
                object_process.StartInfo.FileName = Replace(file_name, " ", "_") & file_extension
                object_process.StartInfo.UseShellExecute = True
                object_process.StartInfo.CreateNoWindow = True
                object_process.Start()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function fn_transform_image(imagen As Byte()) As Image
        Try
            If Not imagen Is Nothing Then
                Dim Bin As New MemoryStream(imagen)
                Dim Resultado As Image = Image.FromStream(Bin)
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function fn_transform_serialize(value_serialize As Object) As String
        Return Newtonsoft.Json.JsonConvert.SerializeObject(value_serialize)
    End Function

    Public Function fn_transform_deserialize(value_deserialize As String) As DataTable
        Try
            Return TryCast(Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(value_deserialize), DataTable)
        Catch ex As Exception
        Finally
        End Try

        Return Nothing
    End Function

    Public Function Num2Text(ByVal value As Double) As String
        Select Case value
            Case 0 : Num2Text = "CERO"
            Case 1 : Num2Text = "UN"
            Case 2 : Num2Text = "DOS"
            Case 3 : Num2Text = "TRES"
            Case 4 : Num2Text = "CUATRO"
            Case 5 : Num2Text = "CINCO"
            Case 6 : Num2Text = "SEIS"
            Case 7 : Num2Text = "SIETE"
            Case 8 : Num2Text = "OCHO"
            Case 9 : Num2Text = "NUEVE"
            Case 10 : Num2Text = "DIEZ"
            Case 11 : Num2Text = "ONCE"
            Case 12 : Num2Text = "DOCE"
            Case 13 : Num2Text = "TRECE"
            Case 14 : Num2Text = "CATORCE"
            Case 15 : Num2Text = "QUINCE"
            Case Is < 20 : Num2Text = "DIECI" & Num2Text(value - 10)
            Case 20 : Num2Text = "VEINTE"
            Case Is < 30 : Num2Text = "VEINTI" & Num2Text(value - 20)
            Case 30 : Num2Text = "TREINTA"
            Case 40 : Num2Text = "CUARENTA"
            Case 50 : Num2Text = "CINCUENTA"
            Case 60 : Num2Text = "SESENTA"
            Case 70 : Num2Text = "SETENTA"
            Case 80 : Num2Text = "OCHENTA"
            Case 90 : Num2Text = "NOVENTA"
            Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & " Y " & Num2Text(value Mod 10)
            Case 100 : Num2Text = "CIEN"
            Case Is < 200 : Num2Text = "CIENTO " & Num2Text(value - 100)
            Case 200, 300, 400, 600, 800 : Num2Text = Num2Text(Int(value \ 100)) & "CIENTOS"
            Case 500 : Num2Text = "QUINIENTOS"
            Case 700 : Num2Text = "SETECIENTOS"
            Case 900 : Num2Text = "NOVECIENTOS"
            Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
            Case 1000 : Num2Text = "MIL"
            Case Is < 2000 : Num2Text = "MIL " & Num2Text(value Mod 1000)
            Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " MIL"
                If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
            Case 1000000 : Num2Text = "UN MILLON"
            Case Is < 2000000 : Num2Text = "UN MILLON " & Num2Text(value Mod 1000000)
            Case Is < 1000000000000.0# : Num2Text = Num2Text(Int(value / 1000000)) & " MILLONES "
                If (value - Int(value / 1000000) * 1000000) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000) * 1000000)
            Case 1000000000000.0# : Num2Text = "UN BILLON"
            Case Is < 2000000000000.0# : Num2Text = "UN BILLON " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            Case Else : Num2Text = Num2Text(Int(value / 1000000000000.0#)) & " BILLONES"
                If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
        End Select
    End Function
End Module
