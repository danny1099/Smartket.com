Public Class wholesales_returns_transfer
    Private person As Persons = Persons.Instance
    Private returns As Returns = Returns.Instance
    Private row_selected As Integer

#Region "contructors"
    Public Sub New(row_selected_ As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        row_selected = row_selected_
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_sales_seller.Datasources(person.settings_persons_listed("p.row_visible=1"), "Nombre del funcionario")
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_sales_seller.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            With sender.Properties
                .View.Columns("Id").Visible = False
                .View.Columns("IDR").Width = 40
                .View.RowHeight = 30
            End With
        End If
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With returns.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "wholesales_master_returns_transfer"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = row_selected
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = cmb_sales_seller.EditValue
                .Parameters.Add("@description_text", SqlDbType.VarChar, 500).Value = sessions.person_name & " transfirío la gestión por devolución a " & cmb_sales_seller.Text
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If returns.execute_procedure(True) = True Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class