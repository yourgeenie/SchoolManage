Imports MySql.Data.MySqlClient

Public Class Schedules
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnRefreshSched_Click(sender As Object, e As EventArgs) Handles btnRefreshSched.Click
        Call Connect_to_Db()
        'on Schedules
        Dim table As New DataTable()
        'Dim adapter As New MySqlDataAdapter("SELECT * FROM schoolms.transactions", conn)
        Dim command As New MySqlCommand
        Dim dt As New DataTable()

        command.Connection = conn
        command.CommandText = "SELECT * FROM schoolms.schedules"

        Dim reader As MySqlDataReader = command.ExecuteReader()

        DataGridView1.Rows.Clear() 'clear existing rows before adding new rows

        While reader.Read()
            Dim schedID = reader.GetString(0)
            Dim courseID = reader.GetString(1)
            Dim profID = reader.GetString(2)
            Dim subID = reader.GetString(3)
            Dim studID = reader.GetString(4)
            Dim schedDay = reader.GetString(5)
            Dim timeStart = reader.GetString(6)
            Dim timeEnd = reader.GetString(7)
            DataGridView1.Rows.Add(schedID, courseID, profID, subID, studID, schedDay, timeStart, timeEnd)

        End While

        Call Disconnect_to_Db()
    End Sub
End Class