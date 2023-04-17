Imports MySql.Data.MySqlClient

Public Class EditCourseForm
    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        With Me
            Call Connect_to_Db()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "UPDATE courses SET courseCategory = '" & .txtCategory.Text & "', " _
                    & "courseName = '" & .txtCourseName.Text & "' " _
                    & "WHERE courseID = '" & .txtCourseID.Text & "'"

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
            .txtCourseID.Text = ""
            .txtCategory.Text = ""
            .txtCourseName.Text = ""
        End With
    End Sub

End Class