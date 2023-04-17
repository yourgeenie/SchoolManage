Imports MySql.Data.MySqlClient
Public Class Transactions
    Public DBConnection As New MySqlConnection 'NEED TO ADD "MYSQL.DATA.DLL" AS PROJECT REFERENCE'
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call Connect_to_Db()
        'on Transactions
        Dim table As New DataTable()
        'Dim adapter As New MySqlDataAdapter("SELECT * FROM schoolms.transactions", conn)
        Dim command As New MySqlCommand
        Dim dt As New DataTable()

        command.Connection = conn
        command.CommandText = "SELECT * FROM schoolms.transactions"

        Dim reader As MySqlDataReader = command.ExecuteReader()

        DataGridView1.Rows.Clear() 'clear existing rows before adding new rows

        While reader.Read()
            Dim transID = reader.GetString(0)
            Dim transName = reader.GetString(1)
            Dim studID = reader.GetString(2)
            Dim amount = reader.GetString(3)
            Dim transDate = reader.GetString(4)
            Dim transMethod = reader.GetString(5)
            DataGridView1.Rows.Add(transID, transName, studID, amount, transDate, transMethod)

        End While

        Call Disconnect_to_Db()
    End Sub

    Private Sub btnAddTrans_Click(sender As Object, e As EventArgs) Handles btnAddTrans.Click
        With Me
            Call Connect_to_Db()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into students values('" _
                & .txtTransID.Text & "', '" _
                & .txtTransName.Text & "', '" _
                & .txtStudID.Text & "', '" _
                & .txtAmount.Text & "', '" _
                & .txtTransDate.Text & "', '" _
                & .txtTransMethod.Text & "')"
                mycmd.CommandText = strSQL
                mycmd.Connection = conn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Added")

                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_Db()

            Me.Hide()
        End With
    End Sub

    Private Sub Clear_Boxes()
        With Me
            .txtTransID.Text = ""
            .txtTransName.Text = ""
            .txtStudID.Text = ""
            .txtAmount.Text = ""
            .txtTransDate.Text = ""
            .txtTransMethod.Text = ""
        End With
    End Sub

    Private Sub Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class