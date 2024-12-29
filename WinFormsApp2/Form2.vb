Public Class Form2
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label10.Text = Val(Label10.Text) + 1
        up(1)
        up1(1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label11.Text = Val(Label11.Text) + 1
        up(2)
        up1(2)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label12.Text = Val(Label12.Text) + 1
        up(3)
        up1(3)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label13.Text = Val(Label13.Text) + 1
        up(4)
        up1(4)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label14.Text = Val(Label14.Text) + 1
        up(5)
        up1(5)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label15.Text = Val(Label15.Text) + 1
        up(6)
        up1(6)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label16.Text = Val(Label16.Text) + 1
        up(7)
        up1(7)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Label17.Text = Val(Label17.Text) + 1
        up(8)
        up1(8)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label18.Text = Val(Label18.Text) + 1
        up(9)
        up1(9)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        If (Val(Label10.Text) > 0) Then
            Label10.Text = Val(Label10.Text) - 1
            de(1)
            de1(1)

        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        If (Val(Label11.Text) > 0) Then
            Label11.Text = Val(Label11.Text) - 1
            de(2)
            de1(2)

        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        If (Val(Label12.Text) > 0) Then
            Label12.Text = Val(Label12.Text) - 1
            de(3)
            de1(3)

        End If

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        If (Val(Label13.Text) > 0) Then
            Label13.Text = Val(Label13.Text) - 1
            de(4)
            de1(4)

        End If
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        If (Val(Label14.Text) > 0) Then
            Label14.Text = Val(Label14.Text) - 1
            de(5)
            de1(5)

        End If
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        If (Val(Label15.Text) > 0) Then
            Label15.Text = Val(Label15.Text) - 1
            de(6)
            de1(6)

        End If
    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub Panel9_Click(sender As Object, e As EventArgs) Handles Panel9.Click
        If (Val(Label16.Text) > 0) Then
            Label16.Text = Val(Label16.Text) - 1
            de(7)
            de1(7)

        End If
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub Panel8_Click(sender As Object, e As EventArgs) Handles Panel8.Click
        If (Val(Label17.Text) > 0) Then
            Label17.Text = Val(Label17.Text) - 1
            de(8)
            de1(8)

        End If
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Panel7_Click(sender As Object, e As EventArgs) Handles Panel7.Click
        If (Val(Label18.Text) > 0) Then
            Label18.Text = Val(Label18.Text) - 1
            de(9)
            de1(9)

        End If
    End Sub



End Class