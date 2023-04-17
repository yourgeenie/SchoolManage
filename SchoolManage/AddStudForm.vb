Imports MySql.Data.MySqlClient
Imports System.Diagnostics.Eventing
Public Class AddStudForm
    Private Sub btnAddStud_Click(sender As Object, e As EventArgs) Handles btnAddStud.Click
        With Me
            Call Connect_to_Db()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into students values('" _
                & .txtStudID.Text & "', '" _
                & .txtStudFirstName.Text & "', '" _
                & .txtStudLastName.Text & "', '" _
                & .txtStudGender.Text & "', '" _
                & .txtStudAge.Text & "', '" _
                & .txtStudContact.Text & "')"
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
            .txtStudID.Text = ""
            .txtStudFirstName.Text = ""
            .txtStudLastName.Text = ""
            .txtStudGender.Text = ""
            .txtStudAge.Text = ""
            .txtStudContact.Text = ""
        End With
    End Sub
End Class