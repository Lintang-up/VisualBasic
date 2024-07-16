Public Class cetak

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub cetak_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        namaPengunjung.Text = ": " & Form1._namaPengunjung
        tipeKamar.Text = ": " & Form1._tipeKamar
        noKamar.Text = ": " & Form1._nomorKamar
        namaKamar.Text = ": " & Form1._namaKamar
        kodeKunci.Text = ": " & Form1._kodeKunci
        hargaSewa.Text = ": " & Form1._hargaSewa
        lamaInap.Text = ": " & Form1._lamaInap
        checkIn.Text = ": " & Form1._tanggalCheckIn
        checkOut.Text = ": " & Form1._tanggalCheckOut
        diskon.Text = ": " & Form1._diskonInap
        biayaInap.Text = ": " & Form1._biayaInap

        hargaMakan.Text = ": " & Form1._hargaMakan
        jumlahOrangMakan.Text = ": " & Form1._jumlahOrangMakan
        diskonMakan.Text = ": " & Form1._diskonMakan
        biayaMakan.Text = ": " & Form1._biayaMakan

        biayaTourGuide.Text = ": " & Form1._biayaTourGuide
        hargaTourGuide.Text = ": " & Form1._hargaTourGuide
        jumlahHariTour.Text = ": " & Form1._jumlahHariTourGuide
        diskonTourGuide.Text = ": " & Form1._diskonTourGuide

        hargaSpa.Text = ": " & Form1._hargaSpa
        jumlahOrangSpa.Text = ": " & Form1._jumlahOrangSpa
        diskonSpa.Text = ": " & Form1._diskonSpa
        biayaSpa.Text = ": " & Form1._biayaSpa

        totalPembayaran.Text = ": " & Form1._totalPembayaran
        pembayaran.Text = ": " & Form1._totalBayar
        totalKembalian.Text = ": " & Form1._kembalian

    End Sub
End Class