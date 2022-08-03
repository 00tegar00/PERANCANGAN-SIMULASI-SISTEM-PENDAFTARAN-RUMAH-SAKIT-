Imports System.Data.Odbc
Public Class login

    Sub Login()
        Koneksi()
        If Guna2TextBox1.Text = "" And Guna2TextBox2.Text = "" Then
            MessageBox.Show("Silahkan isi semua data...")
        Else
            cmd = New OdbcCommand("SELECT * FROM user WHERE username='" & Guna2TextBox1.Text & "' and password='" & Guna2TextBox2.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                    MsgBox("Login Berhasil")
                    'data.Label3.Text = (rd.Item("username"))
                    mainmenu.Show()
                    mainmenu.Guna2Button1.Focus()
                    mainmenu.Guna2Panel2.Controls.Clear()
                    data.TopLevel = False
                    mainmenu.Guna2Panel2.Controls.Add(data)
                    data.Show()
                    Me.Hide()
            Else
                MsgBox("Username atau Password salah")
                Guna2TextBox1.Text = ""
                Guna2TextBox2.Text = ""
                Guna2TextBox1.Focus()
            End If
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Call Koneksi()
        Call Login()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Koneksi()
        Guna2TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If Guna2CheckBox1.CheckState = CheckState.Checked Then
            Guna2TextBox2.UseSystemPasswordChar = False
        Else
            Guna2TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        register.Show()
        Me.Hide()
    End Sub
End Class