Public Class MainMenu

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        Students.Show()
        Me.Hide()
    End Sub

    Private Sub btnProfs_Click(sender As Object, e As EventArgs) Handles btnProfs.Click
        Professors.Show()
        Me.Hide()
    End Sub

    Private Sub btnCourses_Click(sender As Object, e As EventArgs) Handles btnCourses.Click
        Courses.Show()
        Me.Hide()
    End Sub

    Private Sub btnSubjects_Click(sender As Object, e As EventArgs) Handles btnSubjects.Click
        Subjects.Show()
        Me.Hide()
    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        Transactions.Show()
        Me.Hide()
    End Sub

    Private Sub btnView_Click_1(sender As Object, e As EventArgs) Handles btnView.Click
        ViewMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnSched_Click(sender As Object, e As EventArgs) Handles btnSched.Click
        Schedules.Show()
        Me.Hide()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Find.Show()
        Me.Hide()
    End Sub
End Class