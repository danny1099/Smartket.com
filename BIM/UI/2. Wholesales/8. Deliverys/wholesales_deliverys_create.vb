Imports APDA.Object.Controls
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Public Class wholesales_deliverys_create
    Private agency As Agencys = Agencys.Instance
    Private product As Products = Products.Instance
    Private person As Persons = Persons.Instance
    Private delivery As Deliverys = Deliverys.Instance
    Private column_product As New RepositorySearch
    Private source_products As DataTable

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
        create_datagrid()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        'Limpia los datos existentes de las tablas
        If source_products IsNot Nothing Then If source_products.Rows.Count > 0 Then source_products.Rows.Clear()

        'Carga los datos de clientes y productos en tablas independientes
        source_products = product.services_products_listed("s.row_visible=1 and s.segment_code=3")

        'Carga los listados de datos
        cmb_delivery_agency.Datasources(agency.settings_agencys_search("Id in (" & sessions.agency_permit & ") and a.row_visible=1"), "agency_name")
        cmb_delivery_person.Datasources(person.settings_persons_listed("p.row_visible=1 and p.agency_code in (" & sessions.agency_permit & ")"), "Nombre del funcionario")
        column_product.Datasources(source_products, "Nombre del producto")
    End Sub

    Private Sub query_popup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmb_delivery_person.QueryPopUp
        If sender.Properties.View.Columns("Id") IsNot Nothing Then
            With sender.Properties
                .View.Columns("Id").Visible = False
                .View.Columns("IDR").Width = 40
                .View.RowHeight = 30
            End With
        End If
    End Sub

    Private Function products_added(data_source As DataTable) As String
        Return fn_transform_serialize(data_source)
    End Function

    Private Sub characters_count(sender As Object, e As EventArgs) Handles txt_delivery_description.EditValueChanged
        lbl_object_caracters.Text = Len(txt_delivery_description.EditValue) & "/500"
    End Sub

    Private Sub description_spelling(sender As Object, e As EventArgs) Handles txt_delivery_description.Leave
        xvp_spell.Check(sender)
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles object_button_accept.Click
        If xvp_validate.Validate = True And dgv_object_view.RowCount > 0 Then
            With delivery.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = "wholesales_master_deliverys_created"

                .Parameters.Clear()
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = cmb_delivery_person.EditValue
                .Parameters.Add("@product_added", SqlDbType.VarChar).Value = products_added(TryCast(dgv_object_grid.DataSource, DataTable))
                .Parameters.Add("@agency_source", SqlDbType.TinyInt).Value = sessions.agency_code
                .Parameters.Add("@agency_destiny", SqlDbType.TinyInt).Value = cmb_delivery_agency.EditValue
                .Parameters.Add("@description_text", SqlDbType.VarChar, 500).Value = If(txt_delivery_description.EditValue, sessions.person_name & " realizo una petición de traslado")
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_resumen)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If delivery.execute_procedure = True Then
                If chk_keep_form.Checked = True Then
                    defaults_objects(pnl_object_resumen)
                    clean_products()
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

#Region "helpers"
    Private Sub create_datagrid()
        'Define el origen de datos al grid control
        dgv_object_grid.DataSource = datagrid_columns()
        column_product.View.BestFitColumns(True)

        'parametriza las columnas de la vista
        With dgv_object_view
            .Columns("col_order_product").Caption = "Nombre del producto"
            .Columns("col_order_code").Caption = "SKU"
            .Columns("col_order_value").Caption = "Valor Unitario"
            .Columns("col_order_ammount").Caption = "Cantidad"
            .Columns("col_order_center").Visible = False
            .Columns("col_order_output").Visible = False
            .Columns("col_order_person").Visible = False

            'Define la columna de producto para seleccion con listado
            .Columns("col_order_product").ColumnEdit = column_product

            'Ajusta las columnas agregadas
            datagrid_ajusted()
        End With
    End Sub

    Private Function datagrid_columns() As DataTable
        Dim source_data As New DataTable

        With source_data
            .Columns.Add("col_order_product", GetType(String))
            .Columns.Add("col_order_code", GetType(String))
            .Columns.Add("col_order_value", GetType(Decimal))
            .Columns.Add("col_order_ammount", GetType(Integer))
            .Columns.Add("col_order_output", GetType(String))
            .Columns.Add("col_order_center", GetType(String))
            .Columns.Add("col_order_person", GetType(String))
        End With

        Return source_data
    End Function

    Private Sub datagrid_ajusted()
        With dgv_object_view
            .Columns("col_order_product").Width = 250
            .Columns("col_order_code").Width = 55
            .Columns("col_order_ammount").Width = 55
            .Columns("col_order_value").Width = 125

            'Centra los datos de las celdas
            .Columns("col_order_code").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_order_ammount").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_order_value").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            'Centra los encabezados de la columnas
            .Columns("col_order_code").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_order_ammount").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Columns("col_order_value").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            'Agrega el formato de valores para el total
            .Columns("col_order_value").UnboundType = DevExpress.Data.UnboundColumnType.Decimal
            .Columns("col_order_value").DisplayFormat.FormatType = FormatType.Numeric
            .Columns("col_order_value").DisplayFormat.FormatString = "c0"
        End With
    End Sub

    Private Sub row_updated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles dgv_object_view.RowUpdated
        lbl_object_count.Text = total_values()
    End Sub

    Private Sub count_rows(sender As Object, e As EventArgs) Handles dgv_object_view.ColumnFilterChanged
        lbl_object_count.Text = total_values()
    End Sub

    Private Function total_values() As String
        Dim value_ammount As Integer = 0
        Dim value_resmision As Double = 0
        Dim value_total As Double = 0

        Try
            For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                value_resmision = CDbl(Replace(Replace(Replace(dgv_object_view.GetRowCellValue(i, "col_order_value"), ".", ""), "$", ""), "- ", "-"))
                value_ammount = CInt(dgv_object_view.GetRowCellValue(i, "col_order_ammount"))
                value_total += value_resmision * value_ammount
            Next
        Catch ex As Exception
        End Try

        Return FormatCurrency(value_total, 0)
    End Function

    Private Sub selection_changed(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles dgv_object_view.CellValueChanged
        Dim grid_view As GridView = TryCast(sender, GridView)

        If grid_view IsNot Nothing Then
            With grid_view
                'Define el valor seleccionado
                If .GetRowCellValue(e.RowHandle, "col_order_product").ToString <> "" And .GetRowCellValue(e.RowHandle, "col_order_code").ToString = "" Then
                    Dim value_selected As String = .GetRowCellValue(e.RowHandle, "col_order_product").ToString
                    Dim row_search As DataRow() = TryCast(source_products.Select("Id='" & value_selected & "'"), DataRow())

                    .SetFocusedRowCellValue("col_order_code", row_search(0).Item("SKU").ToString)
                End If
            End With
        End If
    End Sub

    Private Sub clean_products()
        If dgv_object_view.RowCount > 0 Then
            For i As Integer = 0 To dgv_object_view.DataRowCount - 1
                dgv_object_view.DeleteRow(dgv_object_view.GetRowHandle(i))
            Next
        End If
    End Sub
#End Region
End Class