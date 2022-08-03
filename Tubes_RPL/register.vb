Imports System.Data.Odbc

Public Class register
    Sub register()
        Call Koneksi()
        If Guna2TextBox1.Text = "" Or Guna2TextBox2.Text = "" Then
            MsgBox("Silahkan Isi Semua Data")
        Else
            Call Koneksi()
            Dim simpan As String = "insert into user values ('" & Guna2TextBox1.Text & "','" & Guna2TextBox2.Text & "')"
            cmd = New OdbcCommand(simpan, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Registrasi Berhasil")
            Guna2TextBox1.Text = ""
            Guna2TextBox2.Text = ""
        End If
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        register()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        login.Show()
        Me.Hide()
    End Sub
End Class