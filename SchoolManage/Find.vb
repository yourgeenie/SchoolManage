Public Class Find

    Private Sub btnStudTrans_Click(sender As Object, e As EventArgs) Handles btnStudTrans.Click
        FindStudTransaction.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        MainMenu.Show()
        Me.Hide()
    End Sub
End Class