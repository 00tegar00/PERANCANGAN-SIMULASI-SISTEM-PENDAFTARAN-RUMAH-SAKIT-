Imports System.Data.Odbc
Public Class pembayaran
    Sub combopembayaran()
        Guna2ComboBox1.Items.Add("Cash")
        Guna2ComboBox1.Items.Add("BPJS")
        Guna2ComboBox1.Items.Add("Transfer")
    End Sub
    Sub simpanpembayaran()
        Call Koneksi()
        If Guna2ComboBox1.Text = "" Or Guna2TextBox1.Text = "" Then
            MsgBox("Silahkan Isi Semua Data")
        Else
            Call Koneksi()
            Dim simpan As String = "insert into pembayaran values ('" & Guna2ComboBox1.Text & "','" & Guna2TextBox1.Text & "')"
            cmd = New OdbcCommand(simpan, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Registrasi Berhasil")
            Call clear()
        End If
    End Sub
    Sub clear()
        Guna2ComboBox1.Text = ""
        Guna2TextBox1.Text = ""
    End Sub
    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles Simpan.Click
        Call Koneksi()
        Call simpanpembayaran()
    End Sub
    Private Sub kunjungan_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Koneksi()
        Call combopembayaran()
    End Sub
End Class