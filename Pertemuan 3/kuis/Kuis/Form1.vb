Public Class Form1
    Private Sub bt_keluar_Click(sender As Object, e As EventArgs) Handles bt_keluar.Click
        kes_namapenyewa.Text = tx_namapenyewa.Text
        kes_notelp.Text = tx_notlp.Text
        kes_alamat.Text = tx_alamat.Text
        kes_namamobil.Text = tx_namamobil.Text
        kes_hargasewa.Text = tx_hargasewa.Text
        kes_jumlahhari.Text = tx_jumlahhari.Text
        kes_totalbayar.Text = tx_totalbayar.Text
    End Sub

    Private Sub nama_Click(sender As Object, e As EventArgs) Handles kes_namapenyewa.Click

    End Sub

    Private Sub bt_hitung_Click(sender As Object, e As EventArgs) Handles bt_hitung.Click
        Dim hs As Integer
        Dim jh As Single
        Dim total As Single
        hs = CInt(tx_hargasewa.Text)
        jh = CSng(tx_jumlahhari.Text)
        total = (hs * jh)

        tx_totalbayar.Text = "Total Pembayaran: Rp." & total
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tx_namapenyewa.Text = " "
        tx_notlp.Text = " "
        tx_alamat.Text = " "
        tx_namamobil.Text = " "
        tx_hargasewa.Text = " "
        tx_jumlahhari.Text = " "
        tx_totalbayar.Text = " "
        tx_namapenyewa.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
