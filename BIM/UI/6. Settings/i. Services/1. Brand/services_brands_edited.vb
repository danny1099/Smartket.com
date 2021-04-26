Public Class services_brands_edited
    Private brand As Brands = Brands.Instance
    Private source_current As DataTable
    Private record_affected As Integer

#Region "contructors"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        record_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'execute procedure to load sources and search current object
        search_object()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub search_object()
        Dim table As DataTable = brand.services_brands_search("Id=" & record_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                txt_brand_name.EditValue = .Item("brand_name").ToString
                chk_row_visible.Checked = CBool(.Item("row_visible"))

                'save data of current record
                source_current = trace_to_current(pnl_object_container)
            End With
        End If
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With brand.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "entities_products_brands_edited"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.SmallInt).Value = record_affected
                .Parameters.Add("@operator_name", SqlDbType.VarChar, 50).Value = txt_brand_name.EditValue
                .Parameters.Add("@row_visible", SqlDbType.Bit).Value = chk_row_visible.EditValue
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_edited(pnl_object_container, source_current)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If brand.execute_procedure = True Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class