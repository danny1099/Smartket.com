Public Class settings_dealers_create
    Private dealer As Dealers = Dealers.Instance
    Private operators As Operators = Operators.Instance

#Region "contructors"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'carga el origen de datos al listado
        object_listed()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_dealer_operator.Datasources(operators.settings_operators_search("row_visible=1"), "operator_name")
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With dealer.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_bussines_dealers_create"

                .Parameters.Clear()
                .Parameters.Add("@dealer_name", SqlDbType.VarChar, 50).Value = txt_dealer_name.EditValue
                .Parameters.Add("@operator_code", SqlDbType.TinyInt).Value = cmb_dealer_operator.EditValue
                .Parameters.Add("@siesa_code", SqlDbType.Char, 10).Value = If(txt_dealer_external.EditValue Is Nothing, DBNull.Value, txt_dealer_external.EditValue)
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If dealer.execute_procedure = True Then
                If chk_keep_form.Checked = True Then
                    defaults_objects(pnl_object_container)
                Else
                    Close()
                End If
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class