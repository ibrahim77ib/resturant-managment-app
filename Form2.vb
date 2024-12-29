Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub gotoform2_Click(sender As Object, e As EventArgs) Handles gotoform2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles endapp.Click
        Application.Exit()

    End Sub
End Class