Imports MySql.Data.MySqlClient

Public Class AddCourseForm
    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        With Me
            Call Connect_to_Db()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into courses values('" _
                & .txtCourseID.Text & "', '" _
                & .txtCategory.Text & "', '" _
                & .txtCourseName.Text & "')"
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
            .txtCourseID.Text = ""
            .txtCategory.Text = ""
            .txtCourseName.Text = ""
        End With
    End Sub

End Class