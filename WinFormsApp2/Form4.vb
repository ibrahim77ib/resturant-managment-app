Public Class Form4
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label7.Text = Val(Label7.Text) + 1
        up(15)
        up1(15)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label8.Text = Val(Label8.Text) + 1
        up(16)
        up1(16)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label9.Text = Val(Label9.Text) + 1
        up(17)
        up1(17)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label10.Text = Val(Label10.Text) + 1
        up(18)
        up1(18)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label11.Text = Val(Label11.Text) + 1
        up(19)
        up1(19)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label12.Text = Val(Label12.Text) + 1
        up(20)
        up1(20)
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        If (Val(Label7.Text) > 0) Then
            Label7.Text = Val(Label7.Text) - 1
            de(15)
            de1(15)
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        If (Val(Label8.Text) > 0) Then
            Label8.Text = Val(Label8.Text) - 1
            de(16)
            de1(16)
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        If (Val(Label9.Text) > 0) Then
            Label9.Text = Val(Label9.Text) - 1
            de(17)
            de1(17)
        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        If (Val(Label10.Text) > 0) Then
            Label10.Text = Val(Label10.Text) - 1
            de(18)
            de1(18)
        End If
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        If (Val(Label11.Text) > 0) Then
            Label11.Text = Val(Label11.Text) - 1
            de(19)
            de1(19)
        End If
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        If (Val(Label12.Text) > 0) Then
            Label12.Text = Val(Label12.Text) - 1
            de(20)
            de1(20)
        End If
    End Sub
End Class