Imports MySql.Data.MySqlClient

Public Class EditSubForm
    Private Sub btnEditSub_Click(sender As Object, e As EventArgs) Handles btnEditSub.Click
        With Me
            Call Connect_to_Db()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "UPDATE subjects SET courseID = '" & .txtCourseID.Text & "', " _
                    & "subCode = '" & .txtSubCode.Text & "', " _
                    & "subName = '" & .txtSubName.Text & "', " _
                    & "WHERE subID = '" & .txtSubID.Text & "'"

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
            .txtSubID.Text = ""
            .txtCourseID.Text = ""
            .txtSubCode.Text = ""
            .txtSubName.Text = ""
        End With
    End Sub
End Class