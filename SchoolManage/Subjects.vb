Imports MySql.Data.MySqlClient

Public Class Subjects
    Public DBConnection As New MySqlConnection 'NEED TO ADD "MYSQL.DATA.DLL" AS PROJECT REFERENCE'

    Private Sub Subjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call Connect_to_Db()
        'on Courses
        Dim table As New DataTable()
        'Dim adapter As New MySqlDataAdapter("SELECT * FROM schoolms.subjects", conn)
        Dim command As New MySqlCommand

        command.Connection = conn
        command.CommandText = "SELECT * FROM schoolms.subjects"

        Dim reader As MySqlDataReader = command.ExecuteReader()

        DataGridView1.Rows.Clear() 'clear existing rows before adding new rows

        While reader.Read()
            Dim subID = reader.GetString(0)
            Dim subCode = reader.GetString(1)
            Dim subName = reader.GetString(2)
            Dim courseID = reader.GetString(3)
            DataGridView1.Rows.Add(subID, subCode, subName, courseID)

        End While

        Call Disconnect_to_Db()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainMenu.Show()
        Me.Hide()

    End Sub

    Private Sub btnAddSub_Click(sender As Object, e As EventArgs) Handles btnAddSub.Click
        AddSubForm.ShowDialog()
    End Sub

    Private Sub btnEditSub_Click(sender As Object, e As EventArgs) Handles btnEditSub.Click
        EditSubForm.ShowDialog()
    End Sub

    Private Sub btnDeleteSub_Click(sender As Object, e As EventArgs) Handles btnDeleteSub.Click
        DelSubForm.ShowDialog()
    End Sub
End Class