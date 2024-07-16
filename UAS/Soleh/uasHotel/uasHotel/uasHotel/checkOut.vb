Imports System.Text.RegularExpressions
Imports System.Data.Odbc

Public Class checkOut

    Dim connect As OdbcConnection
    Dim dataReader As OdbcDataReader
    Dim dataAdapter As OdbcDataAdapter
    Dim dataSet As DataSet
    Dim dataTable As DataTable
    Dim cmd As OdbcCommand

    Dim totalKurang As Integer
    Dim bayar As Integer
    Dim kembalian As Integer
    Dim TransactionInTheCheckOut As New transactionInTheCheckOut()
    Dim idTamu As Integer
    Dim idRuangan As Integer


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
        tbJumlahHari.Text = ""
        tbTglCheckIn.Text = ""
        tbTglCheckOut.Text = ""
        tbJumlahDewasa.Text = ""
        tbJumlahAnak.Text = ""
        tbDiskonInap.Text = ""
        tbTipeMember.Text = ""
        tbDiskonMember.Text = ""
        tbSubTotal.Text = ""
        tbUangMuka.Text = ""
        tbTotalKurang.Text = ""
        tbBayar.Text = ""
        tbKembalian.Text = ""
        textIdTransaksi.Text = ""
        tbBayar.ReadOnly = True
    End Sub

    Sub simpan()
        idTamu = TransactionInTheCheckOut.idTamu
        koneksi()
        Dim sql As String = "update transaksi set bayar = " & bayar & ",kembalian = " & kembalian & ", status = 'Lunas' where idTamu =" & idTamu & ";"
        cmd = New OdbcCommand(sql, connect)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Tamu BERHASIL Di Check Out", vbInformation, "Informasi")
        Catch ex As Exception
            MsgBox("Tamu GAGAL Di Check Out", vbInformation, "Peringatan")
        End Try
    End Sub

    Sub statusTamu()
        idTamu = TransactionInTheCheckOut.idTamu
        koneksi()
        Dim sql As String = "update tamu set status ='pulang' where idTamu =" & idTamu & ";"
        cmd = New OdbcCommand(sql, connect)
        cmd.ExecuteNonQuery()
    End Sub

    Sub statusRuangan()
        idRuangan = TransactionInTheCheckOut.idRuangan
        koneksi()
        Dim sql As String = "update ruangan set status='Kosong' where idRuangan = " & idRuangan
        cmd = New OdbcCommand(sql, connect)
        cmd.ExecuteNonQuery()
    End Sub

    Sub reportViewerStruk()
        Dim idtransaksi As String = textIdTransaksi.Text
        Dim sql As String = "SELECT t.idTransaksi, t.namaTamu, t.nomorRuangan, t.tipeRuangan, t.tarifKamar, t.tanggalCheckIn, t.tanggalCheckOut, t.jumlahHari, t.jumlahDewasa, t.jumlahAnak, t.diskonInap, t.tipeMember, t.diskonMember, t.subTotal, t.uangMuka, t.totalKurang, t.bayar, t.kembalian, r.idRuangan, r.jumlahHunian, tamu.idTamu, tamu.alamat, tamu.ktp, tamu.noHp, tamu.jenisKelamin FROM ruangan AS r, transaksi AS t, tamu WHERE r.idRuangan = t.idRuangan AND t.idTamu = tamu.idTamu AND t.idTransaksi = '" & idtransaksi & "';"
        Try
            FCetakCheckOut.DataSetStruk.Clear()
            FCetakCheckOut.DataSetStruk.EnforceConstraints = False
            koneksi()
            dataAdapter = New OdbcDataAdapter(sql, connect)
            dataAdapter.Fill(FCetakCheckOut.DataSetStruk.DataTable1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        FCetakCheckOut.rvCetakCheckOut.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        FCetakCheckOut.rvCetakCheckOut.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        FCetakCheckOut.rvCetakCheckOut.ZoomPercent = 25
        FCetakCheckOut.rvCetakCheckOut.RefreshReport()
        FCetakCheckOut.Show()
    End Sub

    Private Sub btCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCari.Click
        transactionInTheCheckOut.ShowDialog()
    End Sub

    Private Sub btBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBatal.Click
        clearData()
        Me.Hide()
    End Sub

    Private Sub tbTotalKurang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTotalKurang.TextChanged
        If tbNamaTamu.Text <> "" Then
            tbBayar.ReadOnly = False
        End If
    End Sub

    Private Sub tbBayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbBayar.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub tbBayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBayar.TextChanged
        If Integer.TryParse(tbBayar.Text, bayar) Then
            ' Konversi berhasil, Anda dapat menggunakan nilai 'bayar' di sini
            ' Misalnya: Console.WriteLine("Nilai bayar: " & bayar)
            totalKurang = Integer.Parse(Regex.Replace(tbTotalKurang.Text, "[^\d]", ""))
            bayar = Integer.Parse(tbBayar.Text)
            kembalian = bayar - totalKurang
            If kembalian >= 0 Then
                tbKembalian.Text = kembalian
                tbKembalian.ForeColor = Color.Green
            ElseIf kembalian < 0 Then
                tbKembalian.Text = kembalian
                tbKembalian.ForeColor = Color.Red
            End If
        Else
            ' Konversi gagal karena textbox kosong atau bukan angka
            ' Lakukan penanganan kesalahan di sini
            tbBayar.Text = ""
        End If


    End Sub

    Private Sub btCheckOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCheckOut.Click
        If tbNamaTamu.Text <> "" And tbKembalian.Text <> "" Then

            If kembalian < 0 Then
                MessageBox.Show("Uang Kurang!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim result As DialogResult = MessageBox.Show("Apakah Sudah Yakin?", "Check Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If result = DialogResult.OK Then
                    simpan()
                    clearData()
                    statusTamu()
                    statusRuangan()
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

        Else
            If tbNamaTamu.Text = "" Then
                MessageBox.Show("Data Belum Di Pilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

End Class