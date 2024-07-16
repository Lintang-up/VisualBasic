Public Class Form_Home

    Private Sub DataPasienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPasienToolStripMenuItem.Click
        Data_Pasien.Show()
    End Sub

    Private Sub DataObatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataObatToolStripMenuItem.Click
        data_obat.Show()
    End Sub

    Private Sub PembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembayaranToolStripMenuItem.Click
        Transaksi.Show()
    End Sub
End Class