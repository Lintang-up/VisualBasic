
Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbTipeKamar.Items.Add("Ekonomi")
        tbTipeKamar.Items.Add("Bisnis")
        tbTipeKamar.Items.Add("President")
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
            tbLamaInap.Text = ""
            tbDiskon.Text = ""

            tbNoKamar.Items.Add("1/EKO-A")
            tbNoKamar.Items.Add("2/EKO-B")
            tbNoKamar.Items.Add("3/EKO-C")
            lbDaftarFasilitaskamar.Items.Clear()
            lbDaftarFasilitaskamar.Items.Add("1 Tempat Tidur Besar")
            lbDaftarFasilitaskamar.Items.Add("Air Conditioner")
            lbDaftarFasilitaskamar.Items.Add("1 Kamar Mandi")
            lbDaftarFasilitaskamar.Items.Add("1 Televisi")
        ElseIf tbTipeKamar.Text = "Bisnis" Then
            tbNoKamar.Items.Clear()
            tbNoKamar.Text = ""
            tbNoKamar.SelectedIndex = -1
            tbNamaKamar.Text = ""
            tbKodeKunci.Text = ""
            tbSewa.Text = ""
            tbLamaInap.Text = ""
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
        ElseIf tbTipeKamar.Text = "President" Then
            tbNoKamar.Items.Clear()
            tbNoKamar.Text = ""
            tbNoKamar.SelectedIndex = -1
            tbNamaKamar.Text = ""
            tbKodeKunci.Text = ""
            tbSewa.Text = ""
            tbLamaInap.Text = ""
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

    Private Sub tbMakan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbMakan.TextChanged
        Dim hargaMakan As Double = 150000
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

    Private Sub tbTourGuide_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTourGuide.TextChanged
        Dim hargaTourGuide As Double = 300000
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

    Private Sub tbSpa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSpa.TextChanged
        Dim hargaSpa As Double = 200000
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

    Private Sub tbLamaInap_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbLamaInap.TextChanged
        If IsNumeric(tbLamaInap.Text) Then
            If tbLamaInap.Text >= 7 Then
                tbDiskon.Text = FormatCurrency(tbSewa.Text * 0.1, 0)
            Else
                tbDiskon.Text = FormatCurrency(0, 0)
            End If
        End If
    End Sub

    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click

        Dim biayaInap As Double
        Dim biayaMakan As Double
        Dim biayaTourGuide As Double
        Dim biayaSpa As Double

        If tbLamaInap.Text <> "" Then
            biayaInap = (CDbl(tbSewa.Text) * CDbl(tbLamaInap.Text)) - CDbl(tbDiskon.Text)
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
        If tbLamaInap.Text <> "" Then
            lbdata.Items.Add("Lama Inap" & vbTab & ": " & tbLamaInap.Text & " hari")
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
    End Sub

    Private Sub bayar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bayar.Click
        If tbBayar.Text <> "" Then
            tbKembali.Text = FormatCurrency(tbBayar.Text - tbTotalBayar.Text, 0)
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
        tbLamaInap.Text = ""
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

    Private Sub btExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExit.Click
        End
    End Sub

    Private Sub tbSewa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSewa.TextChanged
        If tbSewa.Text <> "" Then
            tbLamaInap.ReadOnly = False
            tbLamaInap.Enabled = True
        Else
            tbLamaInap.ReadOnly = True
            tbLamaInap.Enabled = False
        End If
    End Sub

    Private Sub lbdata_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbdata.SelectedIndexChanged

    End Sub
End Class
