Imports MySql.Data.MySqlClient
Public Class EditStudentForm
    Private Sub btnEditStud_Click(sender As Object, e As EventArgs) Handles btnEditStud.Click
        With Me
            Call Connect_to_Db()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "UPDATE students SET firstName = '" & .txtStudFirstName.Text & "', " _
                    & "lastName = '" & .txtStudLastName.Text & "', " _
                    & "gender = '" & .txtStudGender.Text & "', " _
                    & "email = '" & .txtStudAge.Text & "', " _
                    & "contactAdd = '" & .txtStudContact.Text & "' " _
                    & "WHERE studID = '" & .txtStudID.Text & "'"

                mycmd.CommandText = strSQL
                mycmd.Connection = conn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Updated")

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