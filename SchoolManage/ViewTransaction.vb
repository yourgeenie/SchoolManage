Imports MySql.Data.MySqlClient

Public Class ViewTransaction
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call Connect_to_Db()
        'on Courses
        Dim table As New DataTable()
        'Dim adapter As New MySqlDataAdapter("SELECT * FROM schoolms.students", conn)
        Dim command As New MySqlCommand

        command.Connection = conn
        command.CommandText = "SELECT * FROM schoolms.`[transaction view]`"

        Dim reader As MySqlDataReader = command.ExecuteReader()

        DataGridView1.Rows.Clear() 'clear existing rows before adding new rows

        While reader.Read()
            Dim transID = reader.GetString(0)
            Dim transName = reader.GetString(1)
            Dim studID = reader.GetString(2)
            Dim firstName = reader.GetString(3)
            Dim lastName = reader.GetString(4)
            Dim amount = reader.GetString(5)
            Dim transDate = reader.GetString(6)
            Dim transMethod = reader.GetString(7)
            DataGridView1.Rows.Add(transID, transName, studID, firstName, lastName, amount, transDate, transMethod)

        End While
        Call Disconnect_to_Db()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ViewMenu.Show()
        Me.Hide()
    End Sub

End Class