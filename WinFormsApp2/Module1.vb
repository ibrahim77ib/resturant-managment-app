Imports System.Data.SqlClient
Module Module1
    Public conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell_i5_th12\source\repos\WinFormsApp2\WinFormsApp2\VBprojDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True")

    Function up(id As Integer)
        conn.Open()
        Try
            Dim com As New SqlCommand("update restorant set num_sales =num_sales + 1 where id=" & id, conn)
            com.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        conn.Open()
        Try
            Dim com As New SqlCommand("update restorant set profit=num_sales*price where id =" & id, conn)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Function

    Function up1(id As Integer)
        up2(id)
        conn.Open()
        Try
            Dim com1 As New SqlCommand("update restorant2 set num_sales =num_sales+1 where id=" & id, conn)
            com1.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        conn.Open()
        Try
            Dim com1 As New SqlCommand("update restorant2 set profit=num_sales*price where id =" & id, conn)
            com1.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Function
    Function up2(id As Integer)
        conn.Open()
        Try
            Dim com1 As New SqlCommand("update restorant3 set num_sales =num_sales+1 where id=" & id, conn)
            com1.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        conn.Open()
        Try
            Dim com1 As New SqlCommand("update restorant3 set profit=num_sales*price where id =" & id, conn)
            com1.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Function
    Function de(id As Integer)
        de2(id)
        conn.Open()
        Try
            Dim com As New SqlCommand("update restorant set num_sales =num_sales- 1 where id=" & id, conn)
            com.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        conn.Open()
        Try
            Dim com As New SqlCommand("update restorant set profit=num_sales*price where id =" & id, conn)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Function
    Function de2(id As Integer)
        conn.Open()
        Try
            Dim com As New SqlCommand("update restorant3 set num_sales =num_sales- 1 where id=" & id, conn)
            com.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        conn.Open()
        Try
            Dim com As New SqlCommand("update restorant3 set profit=num_sales*price where id =" & id, conn)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Function
    Function de1(id As Integer)
        conn.Open()
        Try
            Dim com1 As New SqlCommand("update restorant2 set num_sales =num_sales-1 where id=" & id, conn)
            com1.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        conn.Open()
        Try
            Dim com1 As New SqlCommand("update restorant2 set profit=num_sales*price where id =" & id, conn)
            com1.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Function
End Module
