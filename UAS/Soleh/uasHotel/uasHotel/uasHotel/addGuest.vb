'menghubungkan aplikasi ke database lewat odbc
Imports System.Data.Odbc

Public Class addGuest

    'variabel-variabel 
    Dim connect As OdbcConnection
    Dim dataReader As OdbcDataReader
    Dim dataAdapter As OdbcDataAdapter
    Dim dataSet As DataSet
    Dim dataTable As DataTable
    Dim cmd As OdbcCommand

    'membuat fungsi untuk mengoneksikan ke database
    Sub koneksi()
        connect = New OdbcConnection
        connect.ConnectionString = "dsn=visual_hotel"
        connect.Open()
    End Sub

    'fungsi untuk menyimpan data ke tabel tamu
    Sub simpan()
        koneksi()
        Dim sql As String = "insert into tamu values('','" & tbNama.Text & "','" &
                                                            rtbAlamat.Text & "','" &
                                                            tbKtp.Text & "','" &
                                                            tbNoHp.Text & "','" &
                                                            cbJenisKelamin.Text & "','menunggu')"
        cmd = New OdbcCommand(sql, connect)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Tamu BERHASIL Di Tambahkan", vbInformation, "Informasi")
        Catch ex As Exception
            MsgBox("Tamu GAGAL Di Tambahkan", vbInformation, "Peringatan")
        End Try
    End Sub

    'fungsi untuk menampilkan tabel tamu
    Sub tampil()
        dgvAddGuest.Rows.Clear()
        Try
            koneksi()
            dataAdapter = New OdbcDataAdapter("select * from tamu where status='menunggu'", connect)
            dataTable = New DataTable
            dataAdapter.Fill(dataTable)
            For Each row In dataTable.Rows
                dgvAddGuest.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5))
            Next
            dataTable.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan Data Gagal")
        End Try
    End Sub

    Sub clearData()
        tbNama.Text = ""
        rtbAlamat.Text = ""
        tbKtp.Text = ""
        tbNoHp.Text = ""
        cbJenisKelamin.Text = ""
    End Sub

    Private Sub addGuest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSimpan.Click
        ' Memeriksa apakah semua TextBox telah diisi
        If String.IsNullOrEmpty(tbNama.Text) OrElse
            String.IsNullOrEmpty(rtbAlamat.Text) OrElse
            String.IsNullOrEmpty(tbKtp.Text) OrElse
            String.IsNullOrEmpty(tbNoHp.Text) OrElse
            String.IsNullOrEmpty(cbJenisKelamin.Text) OrElse
            (cbJenisKelamin.Text <> "Laki-laki" And cbJenisKelamin.Text <> "Perempuan") Then
            MessageBox.Show("Semua data harus diisi dengan baik sebelum disimpan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Keluar dari prosedur penanganan klik tombol jika ada TextBox yang kosong
        End If

        ' Jika semua TextBox telah diisi, lakukan tindakan yang diinginkan di sini
        simpan()
        tampil()
        clearData()
    End Sub

    Private Sub btUlang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUlang.Click
        clearData()
    End Sub

    Private Sub btHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHapus.Click
        Dim data As String = dgvAddGuest.Item(1, dgvAddGuest.CurrentRow.Index).Value
        If data = "" Then
            MsgBox("Data belum ada yang di pilih")
        Else
            If (MessageBox.Show("Anda yakin ingin menghapus data dengan nama " & data & "?", "Delete",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from tamu where nama='" & data & "'", connect)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus Data BERHASIL", vbInformation, "Informasi")
                tampil()
                connect.Close()
            End If
        End If
    End Sub





  
End Class