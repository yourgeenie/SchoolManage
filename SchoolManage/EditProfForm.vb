Imports MySql.Data.MySqlClient

Public Class EditProfForm
    Private Sub btnEditProf_Click(sender As Object, e As EventArgs) Handles btnEditProf.Click
        With Me
            Call Connect_to_Db()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "UPDATE professors SET firstName = '" & .txtProfFirstName.Text & "', " _
                    & "lastName = '" & .txtProfLastName.Text & "', " _
                    & "gender = '" & .txtProfGender.Text & "', " _
                    & "email = '" & .txtProfEmail.Text & "', " _
                    & "contactNumber = '" & .txtProfContact.Text & "' " _
                    & "WHERE profID = '" & .txtProfID.Text & "'"

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
            .txtProfID.Text = ""
            .txtProfFirstName.Text = ""
            .txtProfLastName.Text = ""
            .txtProfGender.Text = ""
            .txtProfEmail.Text = ""
            .txtProfContact.Text = ""
        End With
    End Sub

End Class