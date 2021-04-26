Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql

Public Class reporting_dashboard_leader
    Private reporting As Reporting = Reporting.Instance

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_sales_date.EditValue = Now
    End Sub
#End Region

#Region "behaviors"
    Public Sub interface_search()
        With My.Settings
            btn_object_close.Visible = If(.window_tabs = True, False, True)
        End With
    End Sub

    Private Sub reports_show(search_condition As String, criteria_budget As String)
        'ejecuta el proceso para actualizar los datos
        With dbs_connections
            'cambia los datos de conexion
            Dim cnn_connection As String = "XpoProvider=MSSqlServer;Data Source=" & fn_text_settings("C0DB", "DSO", "C:\APDA\BIM\settings.ini") & ";User ID=sa;Password=" & fn_text_settings("C0DB", "IDT", "C:\APDA\BIM\settings.ini") & ";Initial Catalog=" & fn_text_settings("C0DB", "DBO", "C:\APDA\BIM\settings.ini") & ";Persist Security Info=true;"
            Dim cnn_parameters As New CustomStringConnectionParameters(cnn_connection)

            'carga la conexion y la apertura para la carga de datos
            .ConnectionParameters = cnn_parameters
            .Connection.Open()

            'Carga los parametros de consulta
            .Queries(0).Parameters.Clear()
            .Queries(0).Parameters.Add(New QueryParameter With {.Name = "@criteria_search", .Value = search_condition})
            .Fill()

            'Comprueba que hayan cargado los graficos para consultar los presupuestos
            If .Result IsNot Nothing Then
                'Define el valor total de las ventas
                lbl_object_count.Text = total_values()

                'Consultas para traer el presupuesto equivalente
                Dim source_budgets As DataTable = reporting.reporting_dashboard_leaders(search_condition, criteria_budget)
                Dim percen_value As Decimal = 0

                With source_budgets.Rows(0)
                    lbl_object_wholesales.Text = If(.Item("values_wholesales").ToString <> "", FormatNumber(.Item("values_wholesales"), 0), "0")
                    lbl_object_budget.Text = If(.Item("values_budagency").ToString <> "", FormatNumber(.Item("values_budagency"), 0), "0")
                    percen_value = If(.Item("values_budagency").ToString <> "", (.Item("values_wholesales") / .Item("values_budagency")), 0)
                    ArcScaleRangeBarComponent2.Value = If(CInt(percen_value * 100) >= 100, 100, CInt(percen_value * 100))
                    lbl_object_gauge.Text = FormatPercent(percen_value, 1)
                End With
            End If
        End With


    End Sub

    Private Sub calendar_changed(sender As Object, e As EventArgs) Handles txt_sales_date.EditValueChanged
        If txt_sales_date.EditValue IsNot Nothing Then
            Dim criteria_search As String = "month(s.date_sale)=" & Month(txt_sales_date.EditValue) & " and year(s.date_sale)=" & Year(txt_sales_date.EditValue) & " and s.agency_code in (" & sessions.agency_permit & ") and s.row_visible=1" & " and s." & sessions.query_permit & " and s.segment_code=" & rgo_object_segment.EditValue
            Dim criteria_budget As String = "b.validity_month=" & Month(txt_sales_date.EditValue) & " and b.validity_year=" & Year(txt_sales_date.EditValue) & " and p.agency_code in (" & sessions.agency_permit & ") and b.row_visible=1" & " and b." & sessions.query_permit

            'ejecuta el proceso de carga de datos
            If criteria_search <> "" Then reports_show(criteria_search, criteria_budget)
        End If
    End Sub

    Private Sub count_rows(sender As Object, e As EventArgs) Handles dgv_object_view.ColumnFilterChanged
        lbl_object_count.Text = total_values()
    End Sub

    Private Function total_values() As String
        Dim value_total As Double = 0

        For i As Integer = 0 To dgv_object_view.DataRowCount
            value_total += CDbl(Replace(Replace(Replace(dgv_object_view.GetRowCellValue(i, "total_sales"), ".", ""), "$", ""), "- ", "-"))
        Next

        Return If(rgo_object_segment.EditValue = 3, FormatCurrency(value_total, 0), FormatNumber(value_total, 0))
    End Function
#End Region

#Region "methods"
    Private Sub exported_option(sender As Object, e As EventArgs) Handles btn_object_export.Click
        If dgv_object_view.RowCount > 0 Then
            Using export As New model_object_export(dgv_object_view)
                export.ShowDialog(start_home)
            End Using
        End If
    End Sub

    Private Sub printer_option(sender As Object, e As EventArgs) Handles btn_object_print.Click
        If dgv_object_view.RowCount > 0 Then dgv_object_view.ShowPrintPreview()
    End Sub

    Private Sub group_option(sender As Object, e As EventArgs) Handles btn_object_panel.Click
        With dgv_object_view.OptionsView
            .ShowGroupPanel = If(.ShowGroupPanel = False, True, False)
        End With
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles btn_object_close.Click
        start_home.removed_tabbed()
    End Sub
#End Region
End Class
