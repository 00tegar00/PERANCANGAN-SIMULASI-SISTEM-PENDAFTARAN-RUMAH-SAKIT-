Imports System.Data.Odbc

Public Class data
    Sub simpandata()
        Call Koneksi()
        If Guna2TextBox1.Text = "" Or Guna2TextBox2.Text = "" Or Guna2TextBox3.Text = "" Then
            MsgBox("Silahkan Isi Semua Data")
        Else
            Call Koneksi()
            Dim simpan As String = "insert into pasien values ('" & Guna2TextBox1.Text & "','" & Guna2TextBox2.Text & "','" & Guna2TextBox3.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Guna2TextBox4.Text & "')"
            cmd = New OdbcCommand(simpan, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Registrasi Berhasil")
            Call clear()
        End If
    End Sub
    Sub clear()
        Guna2TextBox1.Text = ""
        Guna2TextBox2.Text = ""
        Guna2TextBox3.Text = ""
        Guna2TextBox4.Text = ""
        DateTimePicker1.Text = ""
    End Sub

    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles Simpan.Click
        Call Koneksi()
        Call simpandata()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class
