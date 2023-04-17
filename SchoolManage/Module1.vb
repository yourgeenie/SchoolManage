Imports MySql.Data.MySqlClient

Module Module1
    Public conn As New MySqlConnection
    Public myConnectionString As String
    Public strSQL As String

    Public Sub Connect_to_Db()
        myConnectionString = "server=localhost;" _
               & "uid=root;" _
               & "pwd=admin;" _
               & "database=schoolms"

        Try
            conn.ConnectionString = myConnectionString
            conn.Open()

        Catch ex As MySql.Data.MySqlClient.MySqlException
            Select Case ex.Number
                Case 0
                    MsgBox("Cannot Connect to Server")
                Case 1045
                    MsgBox("Invalid Username or password")
            End Select

        End Try
    End Sub

    Public Sub Disconnect_to_Db()
        conn.Close()
        conn.Dispose()
    End Sub

End Module