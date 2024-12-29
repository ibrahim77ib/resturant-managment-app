Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim abc As Integer
        Dim h As String = "10"
        Dim d As Date = Now()
        abc = Val(h)
        If abc > 5 Then
            MsgBox("abc big 5")
        Else
            MsgBox("abc small 5")
        End If
        For i = 0 To 10 Step 2
            abc = abc + i
        Next
        MsgBox(abc)
        MsgBox(d)

        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Try
            Dim com As New SqlCommand("SELECT name FROM table", con)
            Dim dr1 = com.ExecuteReader()
            While dr1.Read()
                ComboBox2.Items.Add(dr1("name"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        con.Open()
        Try
            Dim com As New SqlCommand("select mark from Table where name'" & ComboBox2.Text & "' ", con)
            TextBox1.Text = com.ExecuteScalar

        Catch ex As Exception
        Finally
            con.Close()

        End Try
    End Sub
End Class
