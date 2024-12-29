Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Windows.Win32.System

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Button7.Visible = False
        RichTextBox1.Visible = False
        RichTextBox1.Text = ""
        Label1.Visible = False
        Label1.Text = 0
        Button8.Visible = False
        TextBox1.Visible = False
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button7.Text = "السعر"
        Form3.MdiParent = Me
        Form3.Show()
        Form3.WindowState = FormWindowState.Maximized
        Form2.Hide()
        Form4.Hide()
        Form5.Hide()
        Form6.Hide()
        RichTextBox1.Visible = False
        Button7.Visible = True
        Button8.Visible = False
        TextBox1.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        LoginForm1.Show()
        Me.Hide()
        LoginForm1.U.Text = ""
        LoginForm1.P.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button7.Text = "السعر"
        Form2.MdiParent = Me
        Form2.Show()
        Form2.WindowState = FormWindowState.Maximized
        Form3.Hide()
        Form4.Hide()
        Form5.Hide()
        Form6.Hide()
        RichTextBox1.Visible = False
        Button7.Visible = True
        Label1.Visible = True
        Button8.Visible = False
        TextBox1.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button7.Text = "السعر"
        Form4.MdiParent = Me
        Form4.Show()
        Form4.WindowState = FormWindowState.Maximized
        Form2.Hide()
        Form3.Hide()
        Form5.Hide()
        Form6.Hide()
        RichTextBox1.Visible = False
        Button7.Visible = True
        Label1.Visible = True
        Button8.Visible = False
        TextBox1.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button7.Text = "السعر"
        Form5.MdiParent = Me
        Form5.Show()
        Form5.WindowState = FormWindowState.Maximized
        Form2.Hide()
        Form3.Hide()
        Form4.Hide()
        Form6.Hide()
        RichTextBox1.Visible = False
        Button7.Visible = True
        Label1.Visible = True
        Button8.Visible = False
        TextBox1.Visible = False
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form6.MdiParent = Me
        Form6.Show()
        Form6.WindowState = FormWindowState.Maximized
        Form2.Hide()
        Form3.Hide()
        Form4.Hide()
        Form5.Hide()
        RichTextBox1.Visible = False
        Button7.Visible = False
        Label1.Visible = False
        Button8.Visible = False
        TextBox1.Visible = False
        conn.Open()
        Try
            Dim da As New SqlDataAdapter("select name,num_sales,profit from restorant", conn)
            Dim ds As New DataSet
            da.Fill(ds)
            Form6.DataGridView1.DataSource = ds
            Form6.DataGridView1.DataMember = ds.Tables(0).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub
    Public i As Integer = 0
    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click

        RichTextBox1.Clear()
        conn.Open()
        Dim sum As Double = 0
        Try
            Dim da As New SqlDataAdapter("select name, num_sales, profit from restorant2 where num_sales >= 1", conn)
            Dim ds As New DataSet
            da.Fill(ds)

            Dim bill = "فاتورة البيع" & Environment.NewLine
            bill &= "رقم الفاتورة: " & i & Environment.NewLine & "-------------------------" & Environment.NewLine
            For Each row As DataRow In ds.Tables(0).Rows
                bill &= "الاسم: " & row("name").ToString & Environment.NewLine
                bill &= "الكمية: " & row("num_sales").ToString & Environment.NewLine
                bill &= "JD" & "السعر: " & row("profit").ToString & Environment.NewLine
                bill &= "-------------------------" & Environment.NewLine
                sum += Convert.ToDouble(row("profit"))
            Next
            bill &= "JD" & "السعر الكلي: " & sum.ToString & Environment.NewLine

            RichTextBox1.Text = bill
            If sum > 0 Then
                i = i + 1
                Form2.Hide()
                Form3.Hide()
                Form4.Hide()
                Form5.Hide()
                Form6.Hide()
                Label1.Visible = False
                RichTextBox1.Visible = True
                Button8.Visible = True
                TextBox1.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try


        conn.Open()

        Try
            Dim com As New SqlCommand("update restorant2 set num_sales=0,profit=0 ", conn)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Label1.Text = 0
        sum = 0
        Form2.Label10.Text = 0
        Form2.Label11.Text = 0
        Form2.Label12.Text = 0
        Form2.Label13.Text = 0
        Form2.Label14.Text = 0
        Form2.Label15.Text = 0
        Form2.Label16.Text = 0
        Form2.Label17.Text = 0
        Form2.Label18.Text = 0

        Form3.Label6.Text = 0
        Form3.Label7.Text = 0
        Form3.Label8.Text = 0
        Form3.Label9.Text = 0
        Form3.Label10.Text = 0

        Form4.Label7.Text = 0
        Form4.Label8.Text = 0
        Form4.Label9.Text = 0
        Form4.Label10.Text = 0
        Form4.Label11.Text = 0
        Form4.Label12.Text = 0


        Form5.Label6.Text = 0
        Form5.Label7.Text = 0
        Form5.Label8.Text = 0
        Form5.Label9.Text = 0
        Form5.Label10.Text = 0
        Button7.Text = "طباعة"
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If DateAndTime.Now.Hour = 0 AndAlso DateAndTime.Now.Minute = 0 AndAlso DateAndTime.Now.Second = 0 Then
            conn.Open()
            Try
                Dim com As New SqlCommand("UPDATE restorant3 SET num_sales = 0, profit = 0 ", conn)
                com.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try

            TextBox1.Text = 0
        End If

        conn.Open()
        Try
            Dim com As New SqlCommand("select sum(profit) from restorant2", conn)
            Label1.Text = com.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        conn.Open()
        Try
            Dim com As New SqlCommand("select sum(profit) from restorant3", conn)
            TextBox1.Text = com.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class

