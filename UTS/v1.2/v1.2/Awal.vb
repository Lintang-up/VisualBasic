Public Class Awal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Judul_Film.Text = ""
        Form1.Studio.Text = ""
        Form1.Hari.Text = ""
        Form1.Jam_Tayang.Text = ""
        Form1.NO_Kursi_1.Text = ""
        Form1.No_Kursi_2.Text = ""
        Form1.Harga.Text = ""
        Form1.Jumlah_Tiket.Text = ""

        Form1.D_JudulFilm.Text = "Judul Film"
        Form1.D_Studio.Text = "Studio"
        Form1.D_hari.Text = "______"
        Form1.D_JumlahTiket.Text = "______"
        Form1.D_JamTayang.Text = "______"
        Form1.D_NoKursi.Text = "______"
        Form1.D_TotalPesan.Text = ""
        Form1.D_Discount.Text = ""
        Form1.D_TotalBayar.Text = ""

        Form1.B_TotalBayar.Text = ""
        Form1.B_Pembayaran.Text = ""
        Form1.B_Kembalian.Text = ""

        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Riwayat.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class