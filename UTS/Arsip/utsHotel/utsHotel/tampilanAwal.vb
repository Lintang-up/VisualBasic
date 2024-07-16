Public Class tampilanAwal

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        End
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Form1.tbNamaPengunjung.Text = ""
        Form1.tbTipeKamar.SelectedIndex = -1
        Form1.tbNoKamar.SelectedIndex = -1
        Form1.tbNamaKamar.Text = ""
        Form1.tbKodeKunci.Text = ""
        Form1.tbSewa.Text = ""
        Form1.nudLamaInap.Value = 0
        Form1.DateTimePicker1.Value = DateTime.Now
        Form1.DateTimePicker2.Value = DateTime.Now
        Form1.tbDiskon.Text = ""
        Form1.cbMakan.Checked = False
        Form1.cbTourGuide.Checked = False
        Form1.cbSpa.Checked = False
        Form1.tbMakan.Text = ""
        Form1.tbTourGuide.Text = ""
        Form1.tbSpa.Text = ""
        Form1.lbDaftarFasilitaskamar.Items.Clear()
        Form1.lbdata.Items.Clear()
        Form1.tbTotalBayar.Text = ""
        Form1.tbBayar.Text = ""
        Form1.tbKembali.Text = ""
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnDaftar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDaftar.Click
        Me.Hide()
        daftarPengunjung.Show()
    End Sub
End Class