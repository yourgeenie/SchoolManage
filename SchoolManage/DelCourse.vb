Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient
Public Class DeleteCourse
    Private courseID As Object

    Private Sub btnDelCourse_Click(sender As Object, e As EventArgs) Handles btnDelCourse.Click
        With Me
            Call Connect_to_Db()
            Dim mycmd As New MySqlCommand
            Try
                Dim answer As MsgBoxResult
                answer = MsgBox("Are you sure you want to delete this record", MsgBoxStyle.YesNo)
                If answer = MsgBoxResult.Yes Then
                    strSQL = "Delete from courses" _
                                    & " where courseID = '" _
                                    & .txtCourseID.Text & "'"
                    'MsgBox(strSQL)
                    mycmd.CommandText = strSQL
                    mycmd.Connection = conn
                    mycmd.ExecuteNonQuery()
                    MsgBox("Record Successfully Deleted")
                    Call Clear_Boxes()
                End If

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
        End With
    End Sub
End Class