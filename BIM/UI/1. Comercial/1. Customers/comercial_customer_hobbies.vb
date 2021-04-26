Imports DevExpress.XtraEditors.Controls

Public Class comercial_customer_hobbies
    Private product As Products = Products.Instance
    Private record_affected As Integer

#Region "constructor"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'setea el valor del parametro
        record_affected = row_selected
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
        cmb_features_type.Datasources(product.services_properties_type(), "properties_type")
    End Sub

    Private Sub type_changed(sender As Object, e As EventArgs) Handles cmb_features_type.EditValueChanged
        With cmb_features_type
            If .EditValue IsNot Nothing Then
                Dim source_items As DataTable = product.services_properties_listed(.GetColumnValue("procedure_name"))
                Dim source_field As String = .GetColumnValue("field_name")

                'carga las acciones asignadas al modulo
                With lbc_properties_features
                    .DataSource = Nothing
                    .Items.Clear()
                    .DataSource = source_items
                    .ValueMember = "Id"
                    .DisplayMember = source_field
                    .UnSelectAll()
                End With
            End If
        End With
    End Sub

    Private Sub clean_selected()
        With lbc_properties_features
            .DataSource = Nothing
            .Items.Clear()
        End With
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With product.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "relationship_customer_properties_create"

                'Recorre todos los items seleccionados
                For Each item As Object In lbc_properties_features.SelectedItems
                    .Parameters.Clear()
                    .Parameters.Add("@customer_code", SqlDbType.Int).Value = record_affected
                    .Parameters.Add("@row_value", SqlDbType.SmallInt).Value = item.row(0).ToString
                    .Parameters.Add("@properties_type", SqlDbType.Char, 1).Value = cmb_features_type.EditValue
                    .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                    .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                    .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                    .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                    .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output

                    If product.execute_procedure(False) = True Then
                    End If
                Next
            End With

            If message_text("Las caracteristicas de producto fueron registradas exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then
                If chk_keep_form.Checked = True Then
                    cmb_features_type.EditValue = Nothing
                    clean_selected()
                Else
                    Close()
                End If
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class