Public Class pembayaran
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles in_jo.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tx_harga.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles in_harga.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tx_jo.TextChanged

    End Sub

    Private Sub bt_apply_Click(sender As Object, e As EventArgs) Handles bt_hitung.Click
        Dim job As Integer
        Dim ob As Single
        Dim total As Single
        job = CInt(tx_jo.Text)
        ob = CSng(tx_harga.Text)
        total = (job * ob)

        kes_total.Text = "Total Pembayaran: Rp." & total
        kes_messeage.Text = "TRIMAKASIH SEMOGA CEPAT SEMBUH"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tx_nama.Text = " "
        tx_nopen.Text = " "
        tx_alamat.Text = " "
        tx_jo.Text = " "
        tx_harga.Text = " "
        tx_nama.Focus()
    End Sub
End Class