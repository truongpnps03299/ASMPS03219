Imports System.Data.SqlClient
Module Module_PS03219

    Public connectionstring As String = "workstation id=PS03219.mssql.somee.com;packet size=4096;user id=PS03219_SQLLogin_1;pwd=ecedtlonlt;data source=PS03219.mssql.somee.com;persist security info=False;initial catalog=PS03219"
    '"Data Source=localhost;Initial Catalog=PS03219;Integrated Security=True"
    Public Sub Excutenonquery(sql As String)
        Dim connection As New SqlConnection(connectionstring)
        Dim command As New SqlCommand(sql, connection)
        connection.Open()
        Command.ExecuteNonQuery()
        connection.Close()

    End Sub
    'workstation id=PS03219.mssql.somee.com;packet size=4096;user id=PS03219_SQLLogin_1;pwd=ecedtlonlt;data source=PS03219.mssql.somee.com;persist security info=False;initial catalog=PS03219
End Module
