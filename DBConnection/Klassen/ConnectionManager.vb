Imports Npgsql

Public Class ConnectionManager
    Private Shared m_conn As NpgsqlConnection

    Public Shared Function GetDB() As NpgsqlConnection
        If m_conn Is Nothing Then
            Dim connString As String = "Host=10.18.32.15;Username=CADLayer;Password=Fwt$CAD!2o24;Database=Software"
            Dim m_conn As NpgsqlConnection = New NpgsqlConnection(connString)
            m_conn.Open()
        End If
        Return m_conn
    End Function
End Class
