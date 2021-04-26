Public Class tools_imports_create
    Private parameters As Parameters = Parameters.Instance
    Private source As DataTable
    Public result_process As DataTable

#Region "contructors"
    Public Sub New(source_ As DataTable)
        InitializeComponent()
        PerformAutoScale()

        'copy data in variable private table
        source = source_.Copy
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'execute procedure to load sources and search current object
        object_listed()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        cmb_import_name.Datasources(parameters.settings_search_imports("row_visible=1"), "type_import")
    End Sub

    Private Function fn_file_xml(source_ As DataTable) As String
        Dim dataset As New DataSet

        dataset.Tables.Add(source_)
        Dim string_ As String = fn_transform_serialize(source_)
        Return dataset.GetXml
    End Function
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            With parameters.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 120
                .CommandText = cmb_import_name.GetColumnValue("process_name")

                .Parameters.Clear()
                .Parameters.Add("@files_imported", SqlDbType.VarChar).Value = fn_file_xml(source)
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(pnl_object_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            'execute procedure to table to return file
            result_process = parameters.execute_table

            If result_process IsNot Nothing Then
                Close()
            End If
        End If
    End Sub

    Private Sub cancel_option(sender As Object, e As EventArgs) Handles btn_object_cancel.Click
        Close()
    End Sub
#End Region
End Class