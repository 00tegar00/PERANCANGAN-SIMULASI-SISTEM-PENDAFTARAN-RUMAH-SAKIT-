Public Class mainmenu

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Guna2Panel2.Controls.Clear()
        data.TopLevel = False
        Guna2Panel2.Controls.Add(data)
        data.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Guna2Panel2.Controls.Clear()
        kunjungan.TopLevel = False
        Guna2Panel2.Controls.Add(kunjungan)
        kunjungan.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Guna2Panel2.Controls.Clear()
        pembayaran.TopLevel = False
        Guna2Panel2.Controls.Add(pembayaran)
        pembayaran.Show()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        cryrpt.Load("C:\Users\tegar\Documents\MyData\Lecture\4'th\REKAYASA PERANGKAT LUNAK\Soal\RPL_HASBIE\Tubes_RPL\Tubes_RPL\CrystalReport2.rpt")
        report.CrystalReportViewer1.ReportSource = cryrpt
        report.CrystalReportViewer1.RefreshReport()
        report.Show()
    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub
End Class