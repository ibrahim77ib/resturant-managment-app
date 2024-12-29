Imports System.Data.SqlClient
Imports Windows.Win32.System

Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Public i As Integer
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        conn.Open()
        Try

            Dim com As New SqlCommand("select lvl from Login where user_name = @x and password = @y", conn)
            com.Parameters.Add("@x", SqlDbType.NChar, 30).Value = Trim(U.Text)
            com.Parameters.Add("@y", SqlDbType.NChar, 30).Value = Trim(P.Text)

            i = com.ExecuteScalar
            If (i = 2) Then
                Form1.Show()
                Form1.Button6.Visible = False
                Me.Hide()
            ElseIf i = 1 Then
                Form1.Show()
                Form1.Button6.Visible = True
                Me.Hide()
            Else
                MsgBox("your username or password is incorrect , try again ")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles U.TextChanged

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles P.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs) Handles PasswordLabel.Click

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        U.Text = ""
        P.Text = ""
    End Sub
End Class
