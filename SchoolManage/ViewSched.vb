Imports MySql.Data.MySqlClient

Public Class ViewSched
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ViewMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call Connect_to_Db()
        'on Courses
        Dim table As New DataTable()
        'Dim adapter As New MySqlDataAdapter("SELECT * FROM schoolms.students", conn)
        Dim command As New MySqlCommand

        command.Connection = conn
        command.CommandText = "SELECT * FROM schoolms.`[schedule view]`"

        Dim reader As MySqlDataReader = command.ExecuteReader()

        DataGridView1.Rows.Clear() 'clear existing rows before adding new rows

        While reader.Read()
            Dim schedID = reader.GetString(0)
            Dim courseName = reader.GetString(1)
            Dim profFirstName = reader.GetString(2)
            Dim profLastName = reader.GetString(3)
            Dim subCode = reader.GetString(4)
            Dim subName = reader.GetString(5)
            Dim studName = reader.GetString(6)
            Dim schedDay = reader.GetString(7)
            Dim timeStart = reader.GetString(8)
            Dim timeEnd = reader.GetString(9)
            DataGridView1.Rows.Add(schedID, courseName, profFirstName, profLastName,
                                   subCode, subName, studName, schedDay, timeStart, timeEnd)

        End While
        Call Disconnect_to_Db()
    End Sub
End Class