Imports System.Globalization
Imports System.Threading
Imports System.IO
Imports Ionic.Zip

Public Class start_initial_logined
    Private object_look As SkinRegistration = SkinRegistration.Instance
    Private person As Persons = Persons.Instance
    Private general As Parameters = Parameters.Instance

#Region "contructors"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()

        'Cambia el tamaño del formulario que abarque la pantalla del usuario
        Me.Size = My.Computer.Screen.WorkingArea.Size
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        search_geolocation()
        search_remember(True)
    End Sub

    Private Sub module_frame(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub search_geolocation()
        Dim culture = CultureInfo.CreateSpecificCulture("es-CO")
        Thread.CurrentThread.CurrentUICulture = culture
        Thread.CurrentThread.CurrentCulture = culture
        CultureInfo.DefaultThreadCurrentCulture = culture
        CultureInfo.DefaultThreadCurrentUICulture = culture
    End Sub

    Private Sub restore_password(sender As Object, e As EventArgs) Handles object_label_restore.Click
        If message_text("¿Está seguro que desea gestionar un cambio de contraseña", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using restore As New start_initial_restore
                restore.ShowDialog(start_home)
            End Using
        End If
    End Sub

    Private Sub search_remember(Optional singup_called As Boolean = False)
        With My.Settings
            'Determina el tipo de accion a realizar

            If singup_called = False Then .remember_username = txt_object_account.EditValue
            If singup_called = True Then txt_object_account.EditValue = .remember_username
            If singup_called = True Then object_image_photo.Image = If(.remember_photo.ToString = "", My.Resources.photo_default, If(local_photo() = True, Image.FromFile(.remember_photo.ToString), My.Resources.photo_default))
            If singup_called = True Then object_check_remember.Checked = If(.remember_username.ToString <> "", True, False)

            'Guarda los cambios en el archivo settings
            .Save()
        End With
    End Sub

    Private Function local_photo() As Boolean
        Return File.Exists(My.Settings.remember_photo)
    End Function

    Private Sub search_update()
        Dim table_search As DataTable = general.settings_search_versions("row_visible=1 and v.file_version<>'" & fn_version_number() & "'")

        With table_search
            If .Rows.Count = 1 Then
                If message_text("La nueva versión " & .Rows(0).Item("Version").ToString & " de BIM está disponible para descargar, Desea realizar la instalación de la versión?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Dim file_name As String = .Rows(0).Item("file_name") & ".zip"
                    Dim array_bytes As Byte() = TryCast(.Rows(0).Item("object_data"), Byte())

                    'Crear el archivo tipo zip para descomprimir y actualizar
                    File.WriteAllBytes("C:\APDA\BIM\updates\" & file_name, array_bytes)

                    'Descomprime el archivo descargado
                    If decompress_file("C:\APDA\BIM\updates\" & file_name) = True Then
                        Application.ExitThread()
                    End If
                End If
            End If
        End With
    End Sub

    Private Function decompress_file(file_name As String) As Boolean
        If My.Computer.FileSystem.FileExists("C:\APDA\BIM\updates\" + file_name) = True Then
            Using zipFile As ZipFile = ZipFile.Read("C:\APDA\BIM\updates\" + file_name)
                zipFile.ExtractAll("C:\APDA\BIM\", 1)
                Return True
            End Using
        End If

        Return False
    End Function
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles object_button_accept.Click
        If xvp_validate.Validate = True Then
            With person.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "tracing_control_sessions_login"

                .Parameters.Clear()
                .Parameters.Add("@user_access", SqlDbType.VarChar, 50).Value = txt_object_account.EditValue
                .Parameters.Add("@password_text", SqlDbType.VarChar, 50).Value = txt_object_password.EditValue
                .Parameters.Add("@pc_name", SqlDbType.VarChar, 50).Value = fn_pc_name() & " |" & fn_version_number()
                .Parameters.Add("@ethernet_address", SqlDbType.VarChar, 100).Value = fn_ip_address()
                .Parameters.Add("@physical_address", SqlDbType.VarChar, 100).Value = fn_pc_mac()
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = fn_trace_number()
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(object_panel_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            'execute procedure to get all data
            Dim table As DataTable = person.execute_table

            If table.Rows.Count = 1 Then
                With table.Rows(0)
                    sessions.session_code = .Item("session_code")
                    sessions.person_code = .Item("Id")
                    sessions.person_name = .Item("person_name")
                    sessions.agency_code = .Item("agency_code")
                    sessions.city_code = .Item("city_code")
                    sessions.query_permit = .Item("query_search")
                    sessions.agency_permit = .Item("permit_agency")
                    sessions.user_access = .Item("user_access")
                    sessions.position_name = .Item("position_name")
                    sessions.query_level = .Item("query_level")

                    'check if query level are equal to A
                    If .Item("permits_array").ToString <> "" Then sessions.permits_options = .Item("permits_array")
                    If .Item("query_level") = "A" Then sessions.admin_user = 1 Else sessions.admin_user = 2
                    If .Item("photo_avatar").ToString <> "" Then sessions.person_photo = fn_transform_image(.Item("photo_avatar")) Else sessions.person_photo = My.Resources.photo_default
                    If .Item("current_version").ToString <> fn_version_number(False) Then message_text("La versión que está ejecutando está desactualizada, se requiere la versión: " & .Item("current_version").ToString, MessageBoxButtons.OK)

                    'save data of user and password
                    If object_check_remember.Checked = True Then
                        My.Settings.remember_username = txt_object_account.EditValue
                        My.Settings.remember_password = txt_object_password.EditValue
                        My.Settings.Save()
                    End If

                    'Crea la instancia del home segun el parametro de tipo de session enviado
                    Dim home As New start_initial_home
                    home.Show()

                    'Cierra el formulario activo
                    Me.Hide()
                End With
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles object_button_closed.Click
        Close()
    End Sub
#End Region
End Class