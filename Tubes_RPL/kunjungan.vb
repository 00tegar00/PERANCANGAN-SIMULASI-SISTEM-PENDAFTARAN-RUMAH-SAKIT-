Imports System.Data.Odbc
Public Class kunjungan
    Sub comboinstalasi()
        Guna2ComboBox1.Items.Add("Instalasi Gawat Darurat")
        Guna2ComboBox1.Items.Add("Instalasi Rawat Jalan")
        Guna2ComboBox1.Items.Add("Instalasi Rawat Inap")
    End Sub
    Sub combopoliklinik()
        Guna2ComboBox2.Items.Add("THT")
        Guna2ComboBox2.Items.Add("Spesialis Anak")
        Guna2ComboBox2.Items.Add("Poliumum")
    End Sub
    Sub combosub()
        Guna2ComboBox3.Items.Add("THT")
        Guna2ComboBox3.Items.Add("Spesialis Anak")
        Guna2ComboBox3.Items.Add("Poliumum")
    End Sub
    Sub simpankunjungan()
        Call Koneksi()
        If Guna2ComboBox1.Text = "" Or Guna2ComboBox2.Text = "" Or Guna2ComboBox3.Text = "" Then
            MsgBox("Silahkan Isi Semua Data")
        Else
            Call Koneksi()
            Dim simpan As String = "insert into kunjungan values ('" & Guna2ComboBox1.Text & "','" & Guna2ComboBox2.Text & "','" & Guna2ComboBox3.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')"
            cmd = New OdbcCommand(simpan, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Registrasi Berhasil")
            Call clear()
        End If
    End Sub
    Sub clear()
        Guna2ComboBox1.Text = ""
        Guna2ComboBox2.Text = ""
        Guna2ComboBox3.Text = ""
        DateTimePicker1.Text = ""
    End Sub

    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles Simpan.Click
        Call Koneksi()
        Call simpankunjungan()
    End Sub

    Private Sub kunjungan_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Koneksi()
        Call comboinstalasi()
        Call combopoliklinik()
        Call combosub()
    End Sub
End Class