Imports System.Data.Odbc

Public Class checkIn
    Dim connect As OdbcConnection
    Dim dataReader As OdbcDataReader
    Dim dataAdapter As OdbcDataAdapter
    Dim dataSet As DataSet
    Dim dataTable As DataTable
    Dim cmd As OdbcCommand

    'variabel bantu
    Dim guestListInTheCheckIn As New GuestListInTheCheckIn()
    Dim idTamu As Integer

    Dim roomListInTheCheckIn As New RoomListInTheCheckIn()
    Dim idRuangan As Integer
    Dim tarifKamar As Integer

    Dim urutanKode As String
    Dim jumlahHari As Integer
    Dim jumlahDewasa As Integer
    Dim jumlahAnak As Integer
    Dim diskonInap As Double
    Dim totalDiskonInap As Integer
    Dim diskonMember As Double
    Dim totalDiskonMember As Integer
    Dim subTotal As Integer
    Dim uangMuka As Integer
    Dim totalKurang As Integer
    
    Sub koneksi()
        connect = New OdbcConnection
        connect.ConnectionString = "dsn=visual_hotel"
        connect.Open()
    End Sub

    Sub clearData()
        tbNamaTamu.Text = ""
        tbNoRuangan.Text = ""
        tbTipeRuangan.Text = ""
        tbTarifKamar.Text = ""
        tbJumlahHari.Text = "0"
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
        tbJumlahDewasa.Text = "0"
        tbJumlahAnak.Text = "0"
        tbDiskonInap.Text = ""
        cbTipeMember.Text = ""
        tbDiskonMember.Text = ""
        tbSubTotal.Text = ""
        tbUangMuka.Text = ""
        tbTotalKurang.Text = ""
        teksUangMuka.Visible = False
    End Sub

    Sub simpan()
        idTamu = guestListInTheCheckIn.dataIdTamu
        Dim idRuangan As Integer = roomListInTheCheckIn.dataIdRuangan
        Dim noRuangan As Integer = roomListInTheCheckIn.dataNomorRuangan


        Int32.TryParse(tbJumlahDewasa.Text, jumlahDewasa)
        Int32.TryParse(tbJumlahAnak.Text, jumlahAnak)

        koneksi()
        Dim tglCheckIn As String
        tglCheckIn = Format(DateTimePicker1.Value, "yyyy-MM-dd")
        Dim tglCheckOut As String
        tglCheckOut = Format(DateTimePicker2.Value, "yyyy-MM-dd")
        Dim sql As String = "insert into transaksi values('" & urutanKode & "','" &
                                                            tbNamaTamu.Text & "'," &
                                                            noRuangan & ",'" &
                                                            tbTipeRuangan.Text & "'," &
                                                            tarifKamar & ",'" &
                                                            tglCheckIn & "','" &
                                                            tglCheckOut & "'," &
                                                            jumlahHari & "," &
                                                            jumlahDewasa & "," &
                                                            jumlahAnak & "," &
                                                            totalDiskonInap & ",'" &
                                                            cbTipeMember.Text & "'," &
                                                            totalDiskonMember & "," &
                                                            subTotal & "," &
                                                            uangMuka & "," &
                                                            totalKurang & ", 0, 0," &
                                                            idTamu & "," &
                                                            idRuangan &
                                                            ",'Belum Lunas')"
        cmd = New OdbcCommand(sql, connect)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Tamu BERHASIL Di Check In", vbInformation, "Informasi")
        Catch ex As Exception
            MsgBox("Tamu GAGAL Di Check In", vbInformation, "Peringatan")
        End Try
    End Sub

    Sub ubahStatusTamu()
        idTamu = guestListInTheCheckIn.dataIdTamu
        koneksi()
        Dim sql As String = "update tamu set status = 'menghuni' where idTamu=" & idTamu
        cmd = New OdbcCommand(sql, connect)
        cmd.ExecuteNonQuery()
    End Sub

    Sub ubahStatusRuangan()
        idRuangan = roomListInTheCheckIn.dataIdRuangan
        koneksi()
        Dim sql As String = "update ruangan set status = 'Di Huni' where idRuangan=" & idRuangan
        cmd = New OdbcCommand(sql, connect)
        cmd.ExecuteNonQuery()
    End Sub

    Sub tampil()
        dgvCheckIn.Rows.Clear()
        Try
            koneksi()
            dataAdapter = New OdbcDataAdapter("select * from transaksi where status='Belum Lunas'", connect)
            dataTable = New DataTable
            dataAdapter.Fill(dataTable)
            For Each row In dataTable.Rows
                dgvCheckIn.Rows.Add(row(0), row(1), row(2), row(3), FormatCurrency(row(4), 0),
                                    Format(row(5), "dd-MM-yyyy"), Format(row(6), "dd-MM-yyyy"), row(7), row(8), row(9),
                                    FormatCurrency(row(10), 0), row(11), FormatCurrency(row(12), 0), FormatCurrency(row(13), 0), FormatCurrency(row(14), 0),
                                    FormatCurrency(row(15), 0))
            Next
            dataTable.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan Data Gagal")
        End Try
    End Sub

    Sub reportViewerStruk()
        Dim idtransaksi As String = textIdTransaksi.Text
        Dim sql As String = "SELECT t.idTransaksi, t.namaTamu, t.nomorRuangan, t.tipeRuangan, t.tarifKamar, t.tanggalCheckIn, t.tanggalCheckOut, t.jumlahHari, t.jumlahDewasa, t.jumlahAnak, t.diskonInap, t.tipeMember, t.diskonMember, t.subTotal, t.uangMuka, t.totalKurang, t.bayar, t.kembalian, r.idRuangan, r.jumlahHunian, tamu.idTamu, tamu.alamat, tamu.ktp, tamu.noHp, tamu.jenisKelamin FROM ruangan AS r, transaksi AS t, tamu WHERE r.idRuangan = t.idRuangan AND t.idTamu = tamu.idTamu AND t.idTransaksi = '" & idtransaksi & "';"
        Try
            FCetakCheckIn.DataSetStruk.Clear()
            FCetakCheckIn.DataSetStruk.EnforceConstraints = False
            koneksi()
            dataAdapter = New OdbcDataAdapter(sql, connect)
            dataAdapter.Fill(FCetakCheckIn.DataSetStruk.DataTable1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        FCetakCheckIn.rvCetakCheckIn.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        FCetakCheckIn.rvCetakCheckIn.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        FCetakCheckIn.rvCetakCheckIn.ZoomPercent = 25
        FCetakCheckIn.rvCetakCheckIn.RefreshReport()
        FCetakCheckIn.Show()
    End Sub

    Sub transId()
        cmd = New OdbcCommand("select * from transaksi where idTransaksi in (select max(idTransaksi) from transaksi)", connect)
        Dim hitung As Long
        dataReader = cmd.ExecuteReader
        dataReader.Read()
        If Not dataReader.HasRows Then
            urutanKode = "TransID-" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(dataReader.GetString(0), 4) + 1
            urutanKode = "TransID-" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        textIdTransaksi.Text = urutanKode
    End Sub

    Private Sub btLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLogin.Click
        GuestListInTheCheckIn.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tbNoRuangan.Text = ""
        tbTipeRuangan.Text = ""
        tbTarifKamar.Text = ""
        tbJumlahHari.Text = "0"
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
        tbJumlahDewasa.Text = "0"
        tbJumlahAnak.Text = "0"
        tbDiskonInap.Text = ""
        cbTipeMember.Text = ""
        tbDiskonMember.Text = ""
        tbSubTotal.Text = ""
        tbUangMuka.Text = ""
        tbTotalKurang.Text = ""
        teksUangMuka.Visible = False

        roomListInTheCheckIn.ShowDialog()
    End Sub

    Private Sub checkIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        tampil()
        transId()
    End Sub

    Private Sub btBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBatal.Click
        clearData()
        Me.Hide()
    End Sub

    Private Sub btClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClear.Click
        clearData()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        tbDiskonInap.Text = ""
        cbTipeMember.Text = ""
        tbDiskonMember.Text = ""
        tbSubTotal.Text = ""
        tbUangMuka.Text = ""
        tbTotalKurang.Text = ""
        teksUangMuka.Visible = False

        DateTimePicker2.Value = DateTimePicker1.Value
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        tbDiskonInap.Text = ""
        cbTipeMember.Text = ""
        tbDiskonMember.Text = ""
        tbSubTotal.Text = ""
        tbUangMuka.Text = ""
        tbTotalKurang.Text = ""
        teksUangMuka.Visible = False

        If DateTimePicker2.Value < DateTimePicker1.Value Then
            DateTimePicker2.Value = DateTimePicker1.Value
        Else
            tbJumlahHari.Text = DateDiff(DateInterval.Day, CDate(DateTimePicker1.Text), CDate(DateTimePicker2.Text))
        End If
    End Sub

    Private Sub tbJumlahHari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbJumlahHari.TextChanged
        tbDiskonInap.Text = ""
        cbTipeMember.Text = ""
        tbDiskonMember.Text = ""
        tbSubTotal.Text = ""
        tbUangMuka.Text = ""
        tbTotalKurang.Text = ""
        teksUangMuka.Visible = False

        DateTimePicker2.Value = DateAdd(DateInterval.Day, Val(tbJumlahHari.Text), DateTimePicker1.Value.Date)

        jumlahHari = tbJumlahHari.Text

        If tbJumlahHari.Text <> "" Then
            Dim i As Integer = tbJumlahHari.Text
            If i > 7 And i <= 14 Then
                diskonInap = 0.15
            ElseIf i > 14 Then
                diskonInap = 0.2
            ElseIf i <= 7 Then
                diskonInap = 0
            End If
        End If

        tarifKamar = roomListInTheCheckIn.dataHarga

        totalDiskonInap = tarifKamar * diskonInap
        tbDiskonInap.Text = FormatCurrency(totalDiskonInap, 0)
        'MsgBox(roomListInTheCheckIn.dataHarga & " ; " & diskonInap)
    End Sub

    Private Sub tbJumlahDewasa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbJumlahDewasa.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""

    End Sub

    Private Sub btMin1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMin1.Click
        Dim currentValue As Integer = 0
        If Integer.TryParse(tbJumlahDewasa.Text, currentValue) Then
            If currentValue > 0 Then
                currentValue -= 1
                tbJumlahDewasa.Text = currentValue.ToString()
            End If
        End If
    End Sub

    Private Sub btPlus1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPlus1.Click
        Dim currentValue As Integer = 0
        If Integer.TryParse(tbJumlahDewasa.Text, currentValue) Then
            currentValue += 1
            tbJumlahDewasa.Text = currentValue.ToString()
        End If
    End Sub

    Private Sub tbJumlahAnak_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbJumlahAnak.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub btMin2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMin2.Click
        Dim currentValue As Integer = 0
        If Integer.TryParse(tbJumlahAnak.Text, currentValue) Then
            If currentValue > 0 Then
                currentValue -= 1
                tbJumlahAnak.Text = currentValue.ToString()
            End If
        End If
    End Sub

    Private Sub btPlus2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPlus2.Click
        Dim currentValue As Integer = 0
        If Integer.TryParse(tbJumlahAnak.Text, currentValue) Then
            currentValue += 1
            tbJumlahAnak.Text = currentValue.ToString()
        End If
    End Sub

    Private Sub tbDiskonInap_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDiskonInap.TextChanged
        If tbNamaTamu.Text <> "" And tbNoRuangan.Text <> "" And tbJumlahHari.Text <> "0" Then
            cbTipeMember.Enabled = True
        End If
        
    End Sub

    Private Sub cbTipeMember_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipeMember.SelectedIndexChanged
        tbSubTotal.Text = ""
        tbUangMuka.Text = ""
        tbTotalKurang.Text = ""
        teksUangMuka.Visible = False

        If cbTipeMember.Text <> "" Then
            If cbTipeMember.Text = "Tidak Ada" Then
                diskonMember = 0
            ElseIf cbTipeMember.Text = "Premium" Then
                diskonMember = 0.1
            ElseIf cbTipeMember.Text = "VIP" Then
                diskonMember = 0.25
            End If

            tarifKamar = roomListInTheCheckIn.dataHarga
            totalDiskonMember = tarifKamar * diskonMember
            tbDiskonMember.Text = FormatCurrency(totalDiskonMember, 0)
        End If
    End Sub

    Private Sub tbDiskonMember_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDiskonMember.TextChanged
        tarifKamar = roomListInTheCheckIn.dataHarga
        subTotal = (tarifKamar * jumlahHari) - (totalDiskonInap + totalDiskonMember)
        tbSubTotal.Text = FormatCurrency(subTotal, 0)
    End Sub

    Private Sub tbSubTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSubTotal.TextChanged
        If tbSubTotal.Text <> "" Then
            tbUangMuka.ReadOnly = False
        End If
    End Sub

    Private Sub tbUangMuka_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbUangMuka.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""

        If tbUangMuka.Text <> "" Then
            teksUangMuka.Visible = True
        End If
    End Sub

    Private Sub tbUangMuka_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbUangMuka.TextChanged
        Int32.TryParse(tbUangMuka.Text, uangMuka)
        totalKurang = subTotal - uangMuka
        tbTotalKurang.Text = FormatCurrency(totalKurang, 0)
    End Sub

    Private Sub btCheckIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCheckIn.Click
        If tbNamaTamu.Text = "" Or
            tbNoRuangan.Text = "" Or
            tbJumlahHari.Text = "0" Or
            (tbJumlahDewasa.Text = "0" AndAlso tbJumlahAnak.Text = "0") Or
            cbTipeMember.Text = "" Or
            tbUangMuka.Text = "" Then
            MessageBox.Show("Semua data harus diisi sebelum Check In.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            If uangMuka < 50000 Then
                MessageBox.Show("Uang Muka Minimal Rp 50.000.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim result As DialogResult = MessageBox.Show("Apakah Sudah Yakin?", "Simpan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If result = DialogResult.OK Then
                    simpan()
                    ubahStatusTamu()
                    ubahStatusRuangan()
                    clearData()
                    tampil()
                    transId()
                    Dim cetakStruk As DialogResult = MessageBox.Show("Apakah Anda Ingin Cetak Struk?", "Cetak", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If cetakStruk = DialogResult.OK Then
                        reportViewerStruk()
                    Else
                        Me.Close()
                    End If
                Else
                    Return
                End If
            End If
        End If
    End Sub

End Class