Imports BIM
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraTab

Public Class start_initial_home
    Private person As Persons = Persons.Instance
    Private tracing As Audited = Audited.Instance

    'Funcion para minimizar la aplicacion desde la barra de tareas
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As System.Windows.Forms.CreateParams = MyBase.CreateParams
            cp.Style = cp.Style Or &H20000
            cp.Style = cp.Style Or &H40
            Return cp
        End Get
    End Property


#Region "contructors"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()

        'Cambia el tamaño del formulario que abarque la pantalla del usuario
        Me.Size = My.Computer.Screen.WorkingArea.Size
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        current_session()
    End Sub

    Private Sub module_frame(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub current_session()
        lbl_user_name.Text = "Hola, " & fn_text_spaces(sessions.person_name)
        lbl_info_version.Text = fn_version_number()
        pic_photo.Image = sessions.person_photo

        'Aplica los permisos a los que tenga acceso el usuario
        search_permits()
        search_notification()
    End Sub

    Private Sub closed_home(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If message_text("Está seguro que desea salir de la aplicación?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.ExitThread()
            objects_released(Me)
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub element_click(sender As Object, e As ElementClickEventArgs) Handles nam_object_menu.ElementClick
        Try
            If e.Element.Name = "nam_object_dashboard" Then
                show_option(fn_dashboard_module)
            Else
                If Not e.Element.Tag Is Nothing Then show_option(e.Element.Tag.ToString)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Function fn_dashboard_module() As Control
        Select Case sessions.query_level
            Case "P" : Return (New reporting_dashboard_leader)
            Case "O" : Return (New reporting_dashboard_personal)
            Case "A" : Return (New reporting_dashboard_showed)
            Case "G" : Return (New reporting_dashboard_showed)
        End Select

        Return Nothing
    End Function
#End Region

#Region "view"
    Private Sub closed_tabbed(sender As Object, e As EventArgs) Handles pnl_object_tabbed.CloseButtonClick
        With pnl_object_tabbed
            .TabPages.Remove(.SelectedTabPage)
        End With
    End Sub

    Public Sub removed_tabbed()
        Try
            With pnl_object_tabbed
                .TabPages.Remove(.SelectedTabPage)
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tabbed_added(sender As Object, e As ControlEventArgs) Handles pnl_object_tabbed.ControlAdded
        If TypeOf (sender) Is XtraTabControl Then
            Try
                'Ejecuta el proceso para ocultar el boton de cerrado
                CallByName(e.Control.Controls(0), "interface_search", CallType.Method)

                'Define la pestaña agregada como activa
                pnl_object_tabbed.SelectedTabPage = TryCast(sender, XtraTabPage)
            Catch ex As Exception
                message_text("Error en el proceso 'tabbed_added' al intentar ejecutarse: " & ex.Message.ToString, MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub search_permits()
        'Carga los permisos asociados al usuario
        Dim source As DataTable = sessions.search_permission

        'Recorre todas las opciones del menu
        With source
            For Each item As AccordionControlElement In nam_object_menu.Elements
                If item.Style = ElementStyle.Group Then
                    For Each options As AccordionControlElement In item.Elements
                        If options.Name.Contains("group") Then
                            For Each rows As AccordionControlElement In options.Elements
                                rows.Visible = If(sessions.admin_user = 1, True, If(.Select("option_object='" & rows.Name & "'").Count = 0, False, True))
                            Next
                        End If
                    Next

                    'Oculta la opcion base del menu
                    item.Visible = If(sessions.admin_user = 1, True, If(.Select("module_object='" & item.Name & "'").Count = 0, False, True))

                ElseIf item.Style = ElementStyle.Item Then
                    item.Visible = If(sessions.admin_user = 1, True, If(.Select("module_object='" & item.Name & "'").Count = 0, False, True))
                End If
            Next
        End With
    End Sub

    Private Sub search_notification()
        Dim table_source As DataTable = tracing.tracing_notification_search(sessions.person_code)

        'comprueba que la tabla tenga filas para recorrer
        If table_source.Rows.Count > 0 Then
            Try
                With table_source.Rows
                    'variables para leer los campos de cada fila
                    Dim notification_text As String, photo_avatar As Image, event_date As String, row_selected As Integer, module_object As String

                    'coloca el total de notificaciones existentes
                    bum_notification.Visible = True
                    bum_notification.Properties.Text = .Count.ToString
                    pnl_object_notify.Controls.Clear()

                    For i As Integer = 0 To .Count - 1
                        notification_text = .Item(i).Item("notification_text").ToString
                        photo_avatar = If(.Item(i).Item("photo_avatar").ToString = "", My.Resources.photo_default, fn_transform_image(.Item(i).Item("photo_avatar")))
                        event_date = .Item(i).Item("event_date").ToString
                        row_selected = .Item(i).Item("Id")
                        module_object = .Item(i).Item("module_object").ToString

                        'agrega la tarjeta con los datos recorridos
                        pnl_object_notify.Controls.Add(New model_object_notify(photo_avatar, notification_text, event_date, row_selected, module_object))

                        'comprueba el tipo de sistema para lanzar las alertas
                        alert_notification(fn_system_version(), notification_text)
                    Next
                End With
            Catch ex As Exception
                message_text("Error en el proceso 'search_notification' al intentar ejecutarse: " & ex.Message.ToString, MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub alert_notification(system_operative As String, description_text As String)
        With system_operative
            If .Contains("8") Or .Contains("10") Then
                With anm_manager
                    .Notifications(0).Body = description_text
                    .ShowNotification(.Notifications(0))
                End With
            Else
                With anm_alerts
                    .Show(Me, "BIM", description_text)
                End With
            End If
        End With
    End Sub
#End Region

#Region "options"
    Private Sub minimize_option(sender As Object, e As EventArgs) Handles btn_object_minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub closed_session(sender As Object, e As EventArgs) Handles btn_object_close.Click
        Close()
    End Sub

    Private Sub download_option(sender As Object, e As EventArgs) Handles btn_object_download.Click
        Using downloaded As New start_initial_update
            downloaded.ShowDialog(start_home)
        End Using
    End Sub

    Private Sub update_option(sender As Object, e As EventArgs) Handles btn_object_update.Click
        Using person As New Persons
            sessions.permits_options = If(person.settings_persons_permissions(sessions.person_code), "")

            If sessions.permits_options IsNot Nothing And sessions.permits_options <> "Nothing" Then
                search_permits()
            End If
        End Using
    End Sub

    Private Sub notification_option(sender As Object, e As EventArgs) Handles btn_object_notification.Click
        If bum_notification.Properties.Text <> "" Then
            With pnl_object_notification
                .Width = If(.Width = 0, 300, 0)
            End With
        Else
            'busca la notificaciones manualmente
            search_notification()

            'comprueba si existe notificaciones para mostrar el panel nuevamente
            If bum_notification.Properties.Text <> "" Then
                With pnl_object_notification
                    .Width = If(.Width = 0, 300, 0)
                End With
            End If
        End If
    End Sub

    Private Sub alerted_search(sender As Object, e As EventArgs) Handles anm_timer.Tick
        search_notification()
    End Sub

    Private Sub clear_option(sender As Object, e As EventArgs) Handles lbl_notification_dismiss.Click
        With tracing
            If .tracing_notification_dismiss(sessions.person_code) = True Then
            End If

            'Limpia todos los objectos creados en la notificacion
            bum_notification.Properties.Text = String.Empty
            bum_notification.Visible = False
            pnl_object_notify.Controls.Clear()
            pnl_object_notification.Width = 0
        End With
    End Sub
#End Region
End Class