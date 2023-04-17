Public Class ViewMenu
    Private Sub btnTransView_Click(sender As Object, e As EventArgs) Handles btnTransView.Click
        ViewTransaction.Show()
        Me.Hide()
    End Sub

    Private Sub btnProfSub_Click(sender As Object, e As EventArgs) Handles btnProfSub.Click
        ViewProfSub.Show()
        Me.Hide()
    End Sub

    Private Sub btnSchedView_Click(sender As Object, e As EventArgs) Handles btnSchedView.Click
        ViewSched.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, btnBack.Click
        MainMenu.Show()
        Me.Hide()

    End Sub
End Class