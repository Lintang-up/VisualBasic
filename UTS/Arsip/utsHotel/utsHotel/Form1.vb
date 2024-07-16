
Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbTipeKamar.Items.Add("Ekonomi")
        tbTipeKamar.Items.Add("Bisnis")
        tbTipeKamar.Items.Add("President")
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker1.MinDate = DateTime.Now
    End Sub

    Private Sub tbTipeKamar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTipeKamar.SelectedIndexChanged
        lbDaftarFasilitaskamar.FormattingEnabled = True
        lbDaftarFasilitaskamar.IntegralHeight = False
        If tbTipeKamar.Text = "Ekonomi" Then
            tbNoKamar.Items.Clear()
            tbNoKamar.Text = ""
            tbNoKamar.SelectedIndex = -1
            tbNamaKamar.Text = ""
            tbKodeKunci.Text = ""
            tbSewa.Text = ""
            nudLamaInap.Value = 0
            DateTimePicker1.MinDate = DateTime.Now
            DateTimePicker2.MinDate = DateTime.Now
            tbDiskon.Text = ""
           
            tbNoKamar.Items.Add("1/EKO-A")
            tbNoKamar.Items.Add("2/EKO-B")
            tbNoKamar.Items.Add("3/EKO-C")

            lbDaftarFasilitaskamar.Items.Clear()
            lbDaftarFasilitaskamar.Items.Add("1 Tempat Tidur Besar")
            lbDaftarFasilitaskamar.Items.Add("Air Conditioner")
            lbDaftarFasilitaskamar.Items.Add("1 Kamar Mandi")
            lbDaftarFasilitaskamar.Items.Add("1 Televisi")
            cbMakan.Checked = False
            cbTourGuide.Checked = False
            cbSpa.Checked = False
            lbdata.Items.Clear()
        ElseIf tbTipeKamar.Text = "Bisnis" Then
            tbNoKamar.Items.Clear()
            tbNoKamar.Text = ""
            tbNoKamar.SelectedIndex = -1
            tbNamaKamar.Text = ""
            tbKodeKunci.Text = ""
            tbSewa.Text = ""
            nudLamaInap.Value = 0
            DateTimePicker1.MinDate = DateTime.Now
            DateTimePicker2.MinDate = DateTime.Now
            tbDiskon.Text = ""

            tbNoKamar.Items.Add("1/BIS-A")
            tbNoKamar.Items.Add("2/BIS-B")
            tbNoKamar.Items.Add("3/BIS-C")
            lbDaftarFasilitaskamar.Items.Clear()
            lbDaftarFasilitaskamar.Items.Add("1 Tempat Tidur Besar")
            lbDaftarFasilitaskamar.Items.Add("Air Conditioner")
            lbDaftarFasilitaskamar.Items.Add("1 Kamar Mandi")
            lbDaftarFasilitaskamar.Items.Add("1 Televisi")
            lbDaftarFasilitaskamar.Items.Add("1 Kulkas")
            cbMakan.Checked = False
            cbTourGuide.Checked = False
            cbSpa.Checked = False
            lbdata.Items.Clear()
        ElseIf tbTipeKamar.Text = "President" Then
            tbNoKamar.Items.Clear()
            tbNoKamar.Text = ""
            tbNoKamar.SelectedIndex = -1
            tbNamaKamar.Text = ""
            tbKodeKunci.Text = ""
            tbSewa.Text = ""
            nudLamaInap.Value = 0
            DateTimePicker1.MinDate = DateTime.Now
            DateTimePicker2.MinDate = DateTime.Now
            tbDiskon.Text = ""

            tbNoKamar.Items.Add("1/PRES-A")
            tbNoKamar.Items.Add("2/PRES-B")
            tbNoKamar.Items.Add("3/PRES-C")
            lbDaftarFasilitaskamar.Items.Clear()
            lbDaftarFasilitaskamar.Items.Add("2 Tempat Tidur Besar")
            lbDaftarFasilitaskamar.Items.Add("Air Conditioner")
            lbDaftarFasilitaskamar.Items.Add("2 Kamar Mandi")
            lbDaftarFasilitaskamar.Items.Add("1 Televisi Besar")
            lbDaftarFasilitaskamar.Items.Add("1 Kulkas Besar")
            cbMakan.Checked = False
            cbTourGuide.Checked = False
            cbSpa.Checked = False
            lbdata.Items.Clear()
        End If
    End Sub

    Private Sub tbNoKamar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNoKamar.SelectedIndexChanged
        Dim x, y, z As String

        x = Microsoft.VisualBasic.Right(tbNoKamar.Text, 1)
        If x = "A" Then
            tbNamaKamar.Text = "Ruang Pertama"
        ElseIf x = "B" Then
            tbNamaKamar.Text = "Ruang Kedua"
        ElseIf x = "C" Then
            tbNamaKamar.Text = "Ruang Ketiga"
        End If

        y = Microsoft.VisualBasic.Left(tbNoKamar.Text, 1)
        z = Microsoft.VisualBasic.Mid(tbNoKamar.Text, 3, 3)
        tbKodeKunci.Text = "Kunci/" & y & "-" & z & "/" & x

        If tbTipeKamar.Text = "Ekonomi" Then
            tbSewa.Text = FormatCurrency(300000, 0)
        ElseIf tbTipeKamar.Text = "Bisnis" Then
            tbSewa.Text = FormatCurrency(500000, 0)
        ElseIf tbTipeKamar.Text = "President" Then
            tbSewa.Text = FormatCurrency(1000000, 0)
        End If
    End Sub


    Private Sub cbMakan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMakan.CheckedChanged
        If cbMakan.Checked = True Then
            tbMakan.ReadOnly = False
            tbMakan.Enabled = True
            tbMakan.Focus()
        Else
            tbMakan.Text = ""
            tbDiskonMakan.Text = ""
            tbMakan.ReadOnly = True
            tbMakan.Enabled = False
        End If
    End Sub

    Private Sub cbTourGuide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTourGuide.CheckedChanged
        If cbTourGuide.Checked = True Then
            tbTourGuide.ReadOnly = False
            tbTourGuide.Enabled = True
            tbTourGuide.Focus()
        Else
            tbTourGuide.Text = ""
            tbDiskonTourGuide.Text = ""
            tbTourGuide.ReadOnly = True
            tbTourGuide.Enabled = False
        End If
    End Sub

    Private Sub cbSpa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSpa.CheckedChanged
        If cbSpa.Checked = True Then
            tbSpa.ReadOnly = False
            tbSpa.Enabled = True
            tbSpa.Focus()
        Else
            tbSpa.Text = ""
            tbDiskonSpa.Text = ""
            tbSpa.ReadOnly = True
            tbSpa.Enabled = False
        End If
    End Sub
    Public hargaMakan As Double = 150000
    Private Sub tbMakan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbMakan.TextChanged
        Dim diskonMakan As Double
        If IsNumeric(tbMakan.Text) Then
            If tbMakan.Text > 5 Then
                diskonMakan = 0.1
            Else
                diskonMakan = 0
            End If
        End If

        Dim total As Double
        If tbMakan.Text <> "" Then
            total = diskonMakan * hargaMakan
            tbDiskonMakan.Text = FormatCurrency(total, 0)
        End If
    End Sub
    Dim hargaTourGuide As Double = 300000
    Private Sub tbTourGuide_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTourGuide.TextChanged
        Dim diskonTourGuide As Double
        If IsNumeric(tbTourGuide.Text) Then
            If tbTourGuide.Text > 5 Then
                diskonTourGuide = 0.1
            Else
                diskonTourGuide = 0
            End If
        End If

        Dim total As Double
        If tbTourGuide.Text <> "" Then
            total = diskonTourGuide * hargaTourGuide
            tbDiskonTourGuide.Text = FormatCurrency(total, 0)
        End If
    End Sub
    Dim hargaSpa As Double = 200000
    Private Sub tbSpa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSpa.TextChanged
        Dim diskonSpa As Double
        If IsNumeric(tbSpa.Text) Then
            If tbSpa.Text > 10 Then
                diskonSpa = 0.2
            Else
                diskonSpa = 0
            End If
        End If

        Dim total As Double
        If tbSpa.Text <> "" Then
            total = diskonSpa * hargaSpa
            tbDiskonSpa.Text = FormatCurrency(total, 0)
        End If
    End Sub
    Dim biayaInap As Double
    Dim biayaMakan As Double
    Dim biayaTourGuide As Double
    Dim biayaSpa As Double
    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click

        If nudLamaInap.Value <= 0 Then
            MessageBox.Show("Harap lengkapi dahulu data dari atas!", "Peringatan")
            tbNamaPengunjung.Focus()
        ElseIf nudLamaInap.Value > 0 Then
            If nudLamaInap.Value <> 0 Then
                biayaInap = (CDbl(tbSewa.Text) * CDbl(nudLamaInap.Value)) - CDbl(tbDiskon.Text)
            End If

            If tbMakan.Text <> "" And tbDiskonMakan.Text <> "" Then
                biayaMakan = (150000 * CDbl(tbMakan.Text)) - CDbl(tbDiskonMakan.Text)
            End If

            If tbTourGuide.Text <> "" And tbDiskonTourGuide.Text <> "" Then
                biayaTourGuide = (300000 * CDbl(tbTourGuide.Text)) - CDbl(tbDiskonTourGuide.Text)
            End If

            If tbSpa.Text <> "" And tbDiskonSpa.Text <> "" Then
                biayaSpa = (200000 * CDbl(tbSpa.Text)) - CDbl(tbDiskonSpa.Text)
            End If

            lbdata.Items.Clear()
            If tbNamaPengunjung.Text <> "" Then
                lbdata.Items.Add("Nama" & vbTab & vbTab & ": " & tbNamaPengunjung.Text)
            End If
            If tbTipeKamar.Text <> "" Then
                lbdata.Items.Add("Tipe Kamar" & vbTab & ": " & tbTipeKamar.Text)
            End If
            If tbNoKamar.Text <> "" Then
                lbdata.Items.Add("No. Kamar" & vbTab & ": " & tbNoKamar.Text)
            End If
            If tbNamaKamar.Text <> "" And tbKodeKunci.Text <> "" And tbSewa.Text <> "" Then
                lbdata.Items.Add("Nama Kamar" & vbTab & ": " & tbNamaKamar.Text)
                lbdata.Items.Add("Kode Kunci" & vbTab & ": " & tbKodeKunci.Text)
                lbdata.Items.Add("Harga Sewa" & vbTab & ": " & tbSewa.Text)
            End If
            If nudLamaInap.Value <> 0 Then
                lbdata.Items.Add("Lama Inap" & vbTab & ": " & nudLamaInap.Value & " hari")
            End If

            If DateTimePicker2.Value <> DateTimePicker1.Value Then
                lbdata.Items.Add("Tanggal Check-In" & vbTab & ": " & DateTimePicker1.Value)
                lbdata.Items.Add("Tanggal Check-Out" & vbTab & ": " & DateTimePicker2.Value)
            Else
                MessageBox.Show("Tanggal Check-in sama dengan tanggal Check-out", "Peringatan")
                DateTimePicker1.Focus()
            End If

            If tbDiskon.Text <> "" Then
                lbdata.Items.Add("Diskon" & vbTab & vbTab & ": " & tbDiskon.Text)
                lbdata.Items.Add("Biaya Inap" & vbTab & ": " & FormatCurrency(biayaInap, 0))
                lbdata.Items.Add("")
            End If
            If tbMakan.Text <> "" Then
                lbdata.Items.Add("Harga Makan" & vbTab & ": Rp 150.000")
                lbdata.Items.Add("Jumlah Makan" & vbTab & ": " & tbMakan.Text & " orang")
            End If
            If tbDiskonMakan.Text <> "" Then
                lbdata.Items.Add("Diskon Makan" & vbTab & ": " & tbDiskonMakan.Text)
                lbdata.Items.Add("Biaya Makan" & vbTab & ": " & FormatCurrency(biayaMakan, 0))
                lbdata.Items.Add("")
            End If
            If tbTourGuide.Text <> "" Then
                lbdata.Items.Add("Harga TourGuide" & vbTab & ": Rp 300.000")
                lbdata.Items.Add("Tour Guide" & vbTab & ": " & tbTourGuide.Text & " hari")
            End If
            If tbDiskonTourGuide.Text <> "" Then
                lbdata.Items.Add("Diskon TourGuide" & vbTab & ": " & tbDiskonTourGuide.Text)
                lbdata.Items.Add("Biaya TourGuide" & vbTab & ": " & FormatCurrency(biayaTourGuide, 0))
                lbdata.Items.Add("")
            End If
            If tbSpa.Text <> "" Then
                lbdata.Items.Add("Harga Spa" & vbTab & ": Rp 200.000")
                lbdata.Items.Add("Spa" & vbTab & vbTab & ": " & tbSpa.Text & " orang")
            End If
            If tbDiskonSpa.Text <> "" Then
                lbdata.Items.Add("Diskon Spa" & vbTab & ": " & tbDiskonSpa.Text)
                lbdata.Items.Add("Biaya Spa" & vbTab & ": " & FormatCurrency(biayaSpa, 0))
            End If

            tbTotalBayar.Text = FormatCurrency(biayaInap + biayaMakan + biayaTourGuide + biayaSpa, 0)
            tbBayar.Focus()
        End If
    End Sub

    Private Sub bayar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bayar.Click
        If tbBayar.Text <> "" Then
            If CInt(tbBayar.Text) < CInt(tbTotalBayar.Text) Then
                MessageBox.Show("Uang yang anda masukkan kurang dari total bayar", "Peringatan")
                tbBayar.Focus()
            ElseIf CInt(tbBayar.Text) >= CInt(tbTotalBayar.Text) Then
                tbKembali.Text = FormatCurrency(tbBayar.Text - tbTotalBayar.Text, 0)
            End If
        End If
    End Sub

    Private Sub tbTotalBayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTotalBayar.TextChanged
        If tbTotalBayar.Text <> "" Then
            tbBayar.Enabled = True
            tbBayar.ReadOnly = False
        Else
            tbBayar.Enabled = False
            tbBayar.ReadOnly = True
        End If
    End Sub

    Private Sub btClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClear.Click
        tbNamaPengunjung.Text = ""
        tbTipeKamar.SelectedIndex = -1
        tbNoKamar.SelectedIndex = -1
        tbNamaKamar.Text = ""
        tbKodeKunci.Text = ""
        tbSewa.Text = ""
        nudLamaInap.Value = 0
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
        tbDiskon.Text = ""
        cbMakan.Checked = False
        cbTourGuide.Checked = False
        cbSpa.Checked = False
        tbMakan.Text = ""
        tbTourGuide.Text = ""
        tbSpa.Text = ""
        lbDaftarFasilitaskamar.Items.Clear()
        lbdata.Items.Clear()
        tbTotalBayar.Text = ""
        tbBayar.Text = ""
        tbKembali.Text = ""
    End Sub

    Private Sub btExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btKembali.Click
        Me.Hide()
        tampilanAwal.Show()
    End Sub

    Private Sub tbSewa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSewa.TextChanged
        If tbSewa.Text <> "" Then
            nudLamaInap.ReadOnly = False
            nudLamaInap.Enabled = True
        Else
            nudLamaInap.ReadOnly = True
            nudLamaInap.Enabled = False
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker2.Value = DateTimePicker1.Value.AddDays(nudLamaInap.Value)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudLamaInap.ValueChanged
        If Not nudLamaInap.Value <= 0 Then
            DateTimePicker1.Enabled = True
            cbMakan.Enabled = True
            cbTourGuide.Enabled = True
            cbSpa.Enabled = True
        Else
            DateTimePicker1.Enabled = False
            cbMakan.Enabled = False
            cbTourGuide.Enabled = False
            cbSpa.Enabled = False
        End If

        If nudLamaInap.Value >= 7 Then
            tbDiskon.Text = FormatCurrency(tbSewa.Text * 0.1, 0)
        Else
            tbDiskon.Text = FormatCurrency(0, 0)
        End If
    End Sub

    Private Sub tbSpa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbSpa.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub tbTourGuide_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbTourGuide.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub
    Private Sub tbMakan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbMakan.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub
    Private Sub tbBayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbBayar.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Public _namaPengunjung, _tipeKamar, _nomorKamar, _namaKamar, _kodeKunci, _hargaSewa, _lamaInap, _diskonInap, _biayaInap,
        _hargaMakan, _jumlahOrangMakan, _diskonMakan, _biayaMakan,
        _hargaTourGuide, _jumlahHariTourGuide, _diskonTourGuide, _biayaTourGuide,
        _hargaSpa, _jumlahOrangSpa, _diskonSpa, _biayaSpa,
        _semuaDiskon, _totalPembayaran, _totalBayar, _kembalian As String
    Public _tanggalCheckIn As String = "dd MMM YYYYY"
    Public _tanggalCheckOut As String = "dd MMM YYYY"

    Private Sub btCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCetak.Click
        _namaPengunjung = tbNamaPengunjung.Text
        _tipeKamar = tbTipeKamar.Text
        _nomorKamar = tbNoKamar.Text
        _namaKamar = tbNamaKamar.Text
        _kodeKunci = tbKodeKunci.Text
        _hargaSewa = tbSewa.Text
        _lamaInap = nudLamaInap.Value
        _tanggalCheckIn = DateTimePicker1.Text
        _tanggalCheckOut = DateTimePicker2.Text
        _diskonInap = tbDiskon.Text
        _biayaInap = FormatCurrency(biayaInap, 0)

        If cbMakan.Checked = True Then
            _hargaMakan = FormatCurrency(hargaMakan, 0)
            _jumlahOrangMakan = tbMakan.Text
            _diskonMakan = tbDiskonMakan.Text
            _biayaMakan = FormatCurrency(biayaMakan, 0)
        Else
            _hargaMakan = "-"
            _jumlahOrangMakan = "-"
            _diskonMakan = "-"
            _biayaMakan = "-"
        End If
        
        If cbTourGuide.Checked = True Then
            _hargaTourGuide = FormatCurrency(hargaTourGuide, 0)
            _jumlahHariTourGuide = tbTourGuide.Text
            _diskonTourGuide = tbDiskonTourGuide.Text
            _biayaTourGuide = FormatCurrency(biayaTourGuide, 0)
        Else
            _hargaTourGuide = "-"
            _jumlahHariTourGuide = "-"
            _diskonTourGuide = "-"
            _biayaTourGuide = "-"
        End If
        
        If cbSpa.Checked = True Then
            _hargaSpa = FormatCurrency(hargaSpa, 0)
            _jumlahOrangSpa = tbSpa.Text
            _diskonSpa = tbDiskonSpa.Text
            _biayaSpa = FormatCurrency(biayaSpa, 0)
        Else
            _hargaSpa = "-"
            _jumlahOrangSpa = "-"
            _diskonSpa = "-"
            _biayaSpa = "-"
        End If

        _totalPembayaran = tbTotalBayar.Text
        _totalBayar = FormatCurrency(tbBayar.Text, 0)
        _kembalian = tbKembali.Text

        Dim cetak As New cetak
        cetak.ShowDialog()
    End Sub

    Private Sub tbKembali_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbKembali.TextChanged
        If tbKembali.Text <> "" Then
            btCetak.Enabled = True
            btnSimpan.Enabled = True
        Else
            btCetak.Enabled = False
            btnSimpan.Enabled = False
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        _namaPengunjung = tbNamaPengunjung.Text
        _tipeKamar = tbTipeKamar.Text
        _nomorKamar = tbNoKamar.Text
        _namaKamar = tbNamaKamar.Text
        _kodeKunci = tbKodeKunci.Text
        _hargaSewa = tbSewa.Text
        _lamaInap = nudLamaInap.Value
        _tanggalCheckIn = DateTimePicker1.Text
        _tanggalCheckOut = DateTimePicker2.Text
        _diskonInap = tbDiskon.Text
        _biayaInap = FormatCurrency(biayaInap, 0)

        If cbMakan.Checked = True Then
            _jumlahOrangMakan = tbMakan.Text
            _diskonMakan = tbDiskonMakan.Text
            _biayaMakan = FormatCurrency(biayaMakan, 0)
        Else
            _jumlahOrangMakan = "-"
            _diskonMakan = 0
            _biayaMakan = "-"
        End If

        If cbTourGuide.Checked = True Then
            _jumlahHariTourGuide = tbTourGuide.Text
            _diskonTourGuide = tbDiskonTourGuide.Text
            _biayaTourGuide = FormatCurrency(biayaTourGuide, 0)
        Else
            _jumlahHariTourGuide = "-"
            _diskonTourGuide = 0
            _biayaTourGuide = "-"
        End If

        If cbSpa.Checked = True Then
            _jumlahOrangSpa = tbSpa.Text
            _diskonSpa = tbDiskonSpa.Text
            _biayaSpa = FormatCurrency(biayaSpa, 0)
        Else
            _jumlahOrangSpa = "-"
            _diskonSpa = 0
            _biayaSpa = "-"
        End If

        _totalPembayaran = tbTotalBayar.Text

        dataPengunjung.Add({_namaPengunjung, _tipeKamar, _nomorKamar, _namaKamar, _kodeKunci, _hargaSewa, _lamaInap, _tanggalCheckIn,
                            _tanggalCheckOut, _biayaInap, _jumlahOrangMakan, _biayaMakan, _jumlahHariTourGuide, _biayaTourGuide,
                            _jumlahOrangSpa, _biayaSpa, _totalPembayaran})

        daftarPengunjung.ListView1.Items.Add(New ListViewItem({_namaPengunjung, _tipeKamar, _nomorKamar, _namaKamar, _kodeKunci, _hargaSewa, _lamaInap, _tanggalCheckIn, _tanggalCheckOut, _biayaInap, _jumlahOrangMakan, _biayaMakan, _jumlahHariTourGuide, _biayaTourGuide, _jumlahOrangSpa, _biayaSpa, _totalPembayaran}))

        'Dim daftarPengunjung1 As New daftarPengunjung
        daftarPengunjung.tampilkanData()
        daftarPengunjung.Show()
        Me.Hide()


    End Sub

    Private dataPengunjung As New List(Of String())
    Public Function getData() As List(Of String())
        Return dataPengunjung
    End Function

    Private Sub tbNamaPengunjung_TextChanged(sender As Object, e As EventArgs) Handles tbNamaPengunjung.TextChanged

    End Sub
End Class
