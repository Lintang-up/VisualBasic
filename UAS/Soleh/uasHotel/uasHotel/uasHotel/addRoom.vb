Imports System.Data.Odbc

Public Class addRoom
    Dim connect As OdbcConnection
    Dim dataReader As OdbcDataReader
    Dim dataAdapter As OdbcDataAdapter
    Dim dataSet As DataSet
    Dim dataTable As DataTable
    Dim cmd As OdbcCommand

    Dim urutanKode As Integer
    Dim statusRuangan As String

    Sub koneksi()
        connect = New OdbcConnection
        connect.ConnectionString = "dsn=visual_hotel"
        connect.Open()
    End Sub

    Sub tampil()
        dgvRoomListInAddRoom.Rows.Clear()
        Try
            koneksi()
            dataAdapter = New OdbcDataAdapter("select * from ruangan where status", connect)
            dataTable = New DataTable
            dataAdapter.Fill(dataTable)
            For Each row In dataTable.Rows
                dgvRoomListInAddRoom.Rows.Add(row(0), row(1), row(2), row(3), row(4))
            Next
            dataTable.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan Data Gagal")
        End Try
    End Sub

    Sub simpan()
        Dim jumlahHunian As Integer = tbJumlahHunian.Text
        koneksi()
        Dim sql As String = "insert into ruangan values(''," &
                                                        urutanKode & ",'" &
                                                        cbTipeRuangan.Text & "'," &
                                                        jumlahHunian &
                                                        ",'Kosong')"
        cmd = New OdbcCommand(sql, connect)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Ruangan BERHASIL Di Tambahkan", vbInformation, "Informasi")
        Catch ex As Exception
            MsgBox("Ruangan GAGAL Di Tambahkan", vbInformation, "Peringatan")
        End Try
    End Sub

    Sub nomorUrutTerakhir()
        cmd = New OdbcCommand("SELECT MAX(nomorRuangan) FROM ruangan", connect)
        Dim hitung As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        If hitung = 0 Then
            urutanKode = 101
        Else
            urutanKode = hitung + 1
        End If

        tbNoRuang.Text = urutanKode
    End Sub

    Sub clearData()
        'tbJumlahHunian.Text = ""
        cbTipeRuangan.Text = ""
        tbJumlahHunian.Text = ""
    End Sub

    Private Sub addRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
        nomorUrutTerakhir()
    End Sub

    Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSimpan.Click
        Dim sad As String = cbTipeRuangan.Text

        If tbNoRuang.Text = "" Then
            MessageBox.Show("Data Belum Di Isi Dengan Benar Semua!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If sad = "Single" Or sad = "Double" Or sad = "Deluxe" Or sad = "Kids" Then
                If tbJumlahHunian.Text = "" Then
                    MessageBox.Show("Data Belum Di Isi Dengan Benar Semua!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim result As DialogResult = MessageBox.Show("Apakah Sudah Yakin?", "Simpan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If result = DialogResult.OK Then
                        simpan()
                        tampil()
                        clearData()
                        nomorUrutTerakhir()
                    Else
                        Return
                    End If
                End If
            Else
                MessageBox.Show("Tipe Ruangan Tidak Valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

    End Sub

    Private Sub tbJumlahHunian_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbJumlahHunian.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub tbJumlahHunian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbJumlahHunian.TextChanged

    End Sub

    Private Sub cbTipeRuangan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipeRuangan.SelectedIndexChanged
        Dim sad As String = cbTipeRuangan.Text

        If sad = "Single" Then
            tbJumlahHunian.Text = 1
        ElseIf sad = "Double" Then
            tbJumlahHunian.Text = 2
        ElseIf sad = "Deluxe" Then
            tbJumlahHunian.Text = 4
        ElseIf sad = "Kids" Then
            tbJumlahHunian.Text = 2
        End If
    End Sub

    Private Sub btClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClear.Click
        clearData()
    End Sub

    Private Sub btHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHapus.Click
        Dim data As String = dgvRoomListInAddRoom.Item(1, dgvRoomListInAddRoom.CurrentRow.Index).Value
        If data = "" Then
            MsgBox("Data belum ada yang di pilih")
        Else
            If (MessageBox.Show("Anda yakin ingin menghapus data dengan ruangan bernomor " & data & "?", "Delete",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from ruangan where nomorRuangan='" & data & "'", connect)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus Data BERHASIL", vbInformation, "Informasi")
                tampil()
                nomorUrutTerakhir()
            End If
        End If
    End Sub
End Class