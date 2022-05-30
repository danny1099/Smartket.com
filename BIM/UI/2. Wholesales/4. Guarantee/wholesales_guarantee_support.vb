Public Class wholesales_guarantee_support
    Private causal As Request = Request.Instance
    Private guarantee As Guarantee = Guarantee.Instance
    Private row_affected As Integer

#Region "constructor"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        row_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load report to show data in lookupeditt
        object_listed()
        search_object()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_guarantee_causal.Datasources(causal.request_causal_search("row_visible=1 and c.module_code=2 and c.causal_type='E'"), "causal_name")
        cmb_guarantee_revision.Datasources(causal.request_causal_search("row_visible=1 and c.module_code=2 and c.causal_type='S'"), "causal_name")
    End Sub

    Private Sub characters_count(sender As Object, e As EventArgs) Handles txt_guarantee_description.EditValueChanged
        lbl_object_caracters.Text = Len(txt_guarantee_description.EditValue) & "/500"
    End Sub

    Private Sub description_spelling(sender As Object, e As EventArgs) Handles txt_guarantee_description.Leave
        xvp_spell.Check(sender)
    End Sub

    Private Sub search_object()
        Dim table As DataTable = guarantee.wholesale_guarantee_search("g.Id=" & row_affected)

        If table.Rows.Count = 1 Then
            With table.Rows(0)
                txt_guarantee_serial.EditValue = .Item("number_serial")
                txt_guarantee_product.EditValue = .Item("product_name")
                cmb_guarantee_causal.SetEditValue(.Item("causals_split"))
            End With

            'save data of current record
            trace_to_current(object_panel_container)
        End If
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles object_button_saved.Click
        If xvp_validate.Validate = True Then
            With guarantee.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "wholesales_master_guarantee_support"

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.Int).Value = row_affected
                .Parameters.Add("@revision_code", SqlDbType.TinyInt).Value = cmb_guarantee_revision.EditValue
                .Parameters.Add("@description_text", SqlDbType.VarChar, 500).Value = txt_guarantee_description.EditValue
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(object_panel_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If guarantee.execute_procedure = True Then
                cmb_guarantee_revision.EditValue = Nothing
                txt_guarantee_description.EditValue = Nothing
            End If
        End If
    End Sub

    Private Sub cleaned_option(sender As Object, e As EventArgs) Handles object_button_clean.Click
        defaults_objects(object_panel_container)
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles object_button_closed.Click
        Dispose()
    End Sub
#End Region
End Class
