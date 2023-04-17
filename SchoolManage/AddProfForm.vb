Imports MySql.Data.MySqlClient

Public Class AddProfForm
    Private Sub btnAddProf_Click(sender As Object, e As EventArgs) Handles btnAddProf.Click
        With Me
            Call Connect_to_Db()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into professors values('" _
                & .txtProfID.Text & "', '" _
                & .txtProfFirstName.Text & "', '" _
                & .txtProfLastName.Text & "', '" _
                & .txtProfGender.Text & "', '" _
                & .txtProfEmail.Text & "', '" _
                & .txtProfContact.Text & "')"
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
            .txtProfID.Text = ""
            .txtProfFirstName.Text = ""
            .txtProfLastName.Text = ""
            .txtProfGender.Text = ""
            .txtProfEmail.Text = ""
            .txtProfContact.Text = ""
        End With
    End Sub

End Class