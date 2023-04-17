Imports MySql.Data.MySqlClient

Public Class LogInForm
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        With Me
            Call Connect_to_Db()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader


            strSQL = "Select * from users where username = '" _
                & .txtUsername.Text & "' and password = sha2('" _
                & .txtPassword.Text & "', 224)"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = conn

            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                .Hide()
                MainMenu.Show()
            Else
                MessageBox.Show("Invalid username or password")
            End If
            Call Disconnect_to_Db()
        End With
    End Sub

End Class