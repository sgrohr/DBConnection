Public Class clsConnectionNames
    Public Shared Function SysCn() As String
        Return DB.clsConnection.SYS
    End Function

    Public Shared Function ErrCn() As String
        Return DB.clsConnection.ERR
    End Function

    Public Shared Function ExpCn() As String
        Return DB.clsConnection.EXPUSR
    End Function

    Public Shared Function ImpCn() As String
        Return DB.clsConnection.IMPUSR
    End Function

    Public Shared Function HaveSysCn() As Boolean
        Dim cn As DB.clsConnection = DB.clsConnection.Manager
        Return (cn.DBExists(DB.clsConnection.SYS))
    End Function
End Class
