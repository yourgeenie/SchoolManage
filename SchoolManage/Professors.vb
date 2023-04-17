Imports MySql.Data.MySqlClient
Public Class Professors
    Public DBConnection As New MySqlConnection 'NEED TO ADD "MYSQL.DATA.DLL" AS PROJECT REFERENCE'

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call Connect_to_Db()
        'on Professors
        Dim table As New DataTable()
        'Dim adapter As New MySqlDataAdapter("SELECT * FROM schoolms.professors", conn)
        Dim command As New MySqlCommand

        command.Connection = conn
        command.CommandText = "SELECT * FROM schoolms.professors"

        Dim reader As MySqlDataReader = command.ExecuteReader()

        DataGridView1.Rows.Clear() 'clear existing rows before adding new rows

        While reader.Read()
            Dim profID = reader.GetString(0)
            Dim firstName = reader.GetString(1)
            Dim lastName = reader.GetString(2)
            Dim gender = reader.GetString(3)
            Dim email = reader.GetString(4)
            Dim contactNo = reader.GetString(5)
            DataGridView1.Rows.Add(profID, firstName, lastName, gender, email, contactNo)

        End While

        Call Disconnect_to_Db()
    End Sub

    Private Sub btnEditProf_Click(sender As Object, e As EventArgs) Handles btnEditProf.Click
        EditProfForm.ShowDialog()
    End Sub

    Private Sub btnAddProf_Click(sender As Object, e As EventArgs) Handles btnAddProf.Click
        AddProfForm.ShowDialog()
    End Sub

    Private Sub btnDeleteProf_Click(sender As Object, e As EventArgs) Handles btnDeleteProf.Click
        DelProfForm.ShowDialog()
    End Sub
End Class