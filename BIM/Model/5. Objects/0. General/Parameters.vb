Public Class Parameters
    Inherits Execute

    Private Shared current_instance As Parameters = Nothing
    Private Shared ReadOnly sync As New Object

#Region "constructors"
    Public Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As Parameters
        Get
            If current_instance Is Nothing Then
                SyncLock sync
                    If current_instance Is Nothing Then
                        current_instance = New Parameters()
                    End If
                End SyncLock
            End If

            Return current_instance
        End Get
    End Property
#End Region

#Region "methods"
    Public Function settings_search_deptos(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "settings_general_search_deptos"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function settings_search_cities(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "settings_general_search_cities"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function settings_search_countrys(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "settings_general_search_country"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function settings_search_genres(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "settings_general_search_genre"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function settings_search_dispatch(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "settings_general_search_dispatch"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function settings_search_documents(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "settings_general_search_docs"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function settings_search_thirds(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "settings_general_search_thirds"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function settings_search_segments(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "settings_general_search_segment"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function settings_search_quotas(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "settings_general_search_quotas"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function settings_search_stratum(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "settings_general_search_stratum"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function settings_search_status(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "settings_general_search_status"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function settings_search_searchable() As DataTable
        Dim table As New DataTable

        With table
            .Columns.Add("Id")
            .Columns.Add("type_search")

            .Rows.Add("s.segment_code=1 and s.number_serial1='", "MIN")
            .Rows.Add("s.segment_code=1 and s.number_serial2='", "ICCID")
            .Rows.Add("s.segment_code=1 and s.number_serial3='", "IMEI")
            .Rows.Add("s.segment_code=2 and s.number_serial1='", "Cuenta")
            .Rows.Add("s.segment_code=3 and s.number_serial1='", "Serial")
            .Rows.Add("s.number_contract='", "Contrato")
            .Rows.Add("s.number_invoice='", "Numero de factura")
            .Rows.Add("c.number_document='", "Documento")
            .Rows.Add("e.code_search='", "WWID")
        End With

        Return table
    End Function

    Public Function settings_search_searchable(guarantee As Object) As DataTable
        Dim table As New DataTable

        With table
            .Columns.Add("Id")
            .Columns.Add("type_search")

            .Rows.Add("g.number_serial='", "Serial")
            .Rows.Add("g.number_invoice='", "Numero de factura")
            .Rows.Add("g.tracing_number='", "Numero de radicado")
            .Rows.Add("c.number_document='", "Cliente (CC)")
        End With

        Return table
    End Function

    Public Function settings_search_searchable(account_module As Boolean) As DataTable
        Dim table As New DataTable

        With table
            .Columns.Add("Id")
            .Columns.Add("type_search")

            .Rows.Add("s.number_account='", "Cuenta")
            .Rows.Add("s.number_contract='", "Contrato")
            .Rows.Add("s.number_invoice='", "Numero de factura")
            .Rows.Add("c.number_document='", "Documento")
            .Rows.Add("p.code_search='", "WWID")
        End With

        Return table
    End Function

    Public Function settings_search_imports(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "settings_general_search_imports"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function settings_search_versions(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "settings_general_search_version"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function

    Public Function settings_search_payments(Optional criteria_search As String = "") As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = "settings_general_search_payments"

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar, 8000).Value = criteria_search

            Return execute_table()
        End With
    End Function


    Public Function settings_search_formats() As DataTable
        Dim table As New DataTable

        With table
            .Columns.Add("Id")
            .Columns.Add("format_name")

            .Rows.Add("WS001IH.xlsx", "WS001IH - Archivo de ventas (Hogar)")
            .Rows.Add("WS003IM.xlsx", "WS003IM - Archivo de ventas (Movil)")
            .Rows.Add("WS004IF.xlsx", "WS004IF - Archivo de ventas (Libres)")
            .Rows.Add("WS002IL.xlsx", "WS002IL - Archivo de legalización (Hogar)")
            .Rows.Add("WS005IP.xlsx", "WS005IP - Archivo de pagos al distribuidor")
            .Rows.Add("WS006SM.xlsx", "WS006SM - Archivo de seriales (Movil)")
            .Rows.Add("WS007SF.xlsx", "WS006SM - Archivo de seriales (Libres)")
        End With

        Return table
    End Function

    Public Function settings_search_yesno() As DataTable
        Dim table As New DataTable

        With table
            .Columns.Add("Id")
            .Columns.Add("yes_no")

            .Rows.Add(1, "Si")
            .Rows.Add(0, "No")
        End With

        Return table
    End Function

    Public Function settings_search_yesno2() As DataTable
        Dim table As New DataTable

        With table
            .Columns.Add("Id")
            .Columns.Add("yes_no")

            .Rows.Add(1, "Si")
            .Rows.Add(2, "No")
        End With

        Return table
    End Function

    Public Function settings_search_clasification() As DataTable
        Dim table As New DataTable

        With table
            .Columns.Add("Id")
            .Columns.Add("class_type")

            .Rows.Add(1, "Mixto")
            .Rows.Add(0, "Abierto")
        End With

        Return table
    End Function

    Public Function settings_search_months() As DataTable
        Dim table As New DataTable

        With table
            .Columns.Add("Id")
            .Columns.Add("month_name")

            .Rows.Add(1, "Enero")
            .Rows.Add(2, "Febrero")
            .Rows.Add(3, "Marzo")
            .Rows.Add(4, "Abril")
            .Rows.Add(5, "Mayo")
            .Rows.Add(6, "Junio")
            .Rows.Add(7, "Julio")
            .Rows.Add(8, "Agosto")
            .Rows.Add(9, "Septiembre")
            .Rows.Add(10, "Obtubre")
            .Rows.Add(11, "Noviembre")
            .Rows.Add(12, "Diciembre")
        End With

        Return table
    End Function

    Public Function settings_search_address() As DataTable
        Dim table As New DataTable

        With table
            .Columns.Add("Id")
            .Columns.Add("address_name")

            .Rows.Add(1, "Calle")
            .Rows.Add(2, "Carrera")
            .Rows.Add(3, "Avenida")
            .Rows.Add(4, "Transversal")
            .Rows.Add(5, "Autopista")
            .Rows.Add(6, "Manzana")
            .Rows.Add(7, "Kilometro")
            .Rows.Add(8, "Urbanización")
            .Rows.Add(9, "Vereda")
            .Rows.Add(10, "Parcelación")
            .Rows.Add(11, "Diagonal")
            .Rows.Add(12, "Lote")
        End With

        Return table
    End Function

    Public Function settings_search_money() As DataTable
        Dim table As New DataTable

        With table
            .Columns.Add("Id")
            .Columns.Add("money_type")
            .Columns.Add("format_type")

            ' .Rows.Add(1, "Moneda", "c2")
            .Rows.Add(2, "Porcentaje", "P2")
        End With

        Return table
    End Function

    Public Function settings_search_modules() As DataTable
        Dim table As New DataTable

        With table
            .Columns.Add("Id")
            .Columns.Add("module_name")

            .Rows.Add(1, "Ventas")
            .Rows.Add(2, "Garantías")
            .Rows.Add(3, "Datacréditos")
            .Rows.Add(4, "Recaudos")
            .Rows.Add(5, "Gestiones")
            .Rows.Add(6, "Devoluciones")
            .Rows.Add(7, "Financiera")
            .Rows.Add(8, "Cotizaciones")
        End With

        Return table
    End Function

    Public Function settings_search_economic() As DataTable
        Dim table As New DataTable

        With table
            .Columns.Add("Id")
            .Columns.Add("economic_name")

            .Rows.Add("E", "Empleado")
            .Rows.Add("I", "Independiente")
            .Rows.Add("J", "Jubilado")
            .Rows.Add("O", "Otros")
        End With

        Return table
    End Function

    Public Function settings_search_antiquity() As DataTable
        Dim table As New DataTable

        With table
            .Columns.Add("Id")
            .Columns.Add("antiquity_name")

            .Rows.Add("M", "Meses")
            .Rows.Add("Y", "Años")
        End With

        Return table
    End Function
#End Region
End Class
