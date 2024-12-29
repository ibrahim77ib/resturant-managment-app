Imports System.Reflection.Emit

Public Class Form3
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label6.Text = Val(Label6.Text) + 1
        up(10)
        up1(10)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label7.Text = Val(Label7.Text) + 1
        up(11)
        up1(11)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label8.Text = Val(Label8.Text) + 1
        up(12)
        up1(12)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label9.Text = Val(Label9.Text) + 1
        up(13)
        up1(13)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label10.Text = Val(Label10.Text) + 1
        up(14)
        up1(14)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        If (Val(Label6.Text) > 0) Then
            Label6.Text = Val(Label6.Text) - 1
            de(10)
            de1(10)
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        If (Val(Label7.Text) > 0) Then
            Label7.Text = Val(Label7.Text) - 1
            de(11)
            de1(11)
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        If (Val(Label8.Text) > 0) Then
            Label8.Text = Val(Label8.Text) - 1
            de(12)
            de1(12)
        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        If (Val(Label9.Text) > 0) Then
            Label9.Text = Val(Label9.Text) - 1
            de(13)
            de1(13)
        End If
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        If (Val(Label10.Text) > 0) Then
            Label10.Text = Val(Label10.Text) - 1
            de(14)
            de1(14)
        End If
    End Sub
End Class