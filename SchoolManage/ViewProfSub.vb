Imports MySql.Data.MySqlClient

Public Class ViewProfSub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call Connect_to_Db()
        'on Courses
        Dim table As New DataTable()
        'Dim adapter As New MySqlDataAdapter("SELECT * FROM schoolms.students", conn)
        Dim command As New MySqlCommand

        command.Connection = conn
        command.CommandText = "SELECT * FROM schoolms.`[professor's subject]`"

        Dim reader As MySqlDataReader = command.ExecuteReader()

        DataGridView1.Rows.Clear() 'clear existing rows before adding new rows

        While reader.Read()
            Dim firstName = reader.GetString(0)
            Dim lastName = reader.GetString(1)
            Dim subCode = reader.GetString(2)
            Dim subName = reader.GetString(3)
            DataGridView1.Rows.Add(firstName, lastName, subCode, subName)

        End While
        Call Disconnect_to_Db()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ViewMenu.Show()
        Me.Hide()
    End Sub
End Class