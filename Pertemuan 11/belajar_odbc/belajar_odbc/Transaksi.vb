Imports System.Data.Odbc

Public Class Transaksi
    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand

    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=vb_datapasien"
        con.Open()
    End Sub

    Sub simpan()
        koneksi()
        Dim sql As String = "insert into transaksi values('" & ID_Transaksi.Text & "','" & Cb1.Text & "','" & Nama.Text & "', '" & Cb2.Text & "','" & Nama_Obat.Text & "','" & Harga_Obat.Text & "','" & Jumlah_Obat.Text & "','" &
       Jumlah_Harga.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Sub tampil()
        dgv2.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select *from transaksi order by KodeTransaksi asc", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                dgv2.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub

    Sub nomor()
        Try
            koneksi()
            cmd = New OdbcCommand("SELECT * FROM `transaksi` ORDER BY KodeTransaksi DESC", con)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Dim lastTransNo As Integer = Integer.Parse(dr("KodeTransaksi").ToString())
                ID_Transaksi.Text = (lastTransNo + 1).ToString()
            Else
                ID_Transaksi.Text = "10001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Sub tampilpasien()
        cmd = New OdbcCommand("select ID_Pasien from data_pasien", con)
        dr = cmd.ExecuteReader
        Cb1.Items.Clear()
        Do While dr.Read
            Cb1.Items.Add(dr.Item("ID_Pasien"))
        Loop
    End Sub

    Sub tampilobat()
        cmd = New OdbcCommand("select kodeobat from data_obat", con)
        dr = cmd.ExecuteReader
        Cb2.Items.Clear()
        Do While dr.Read
            Cb2.Items.Add(dr.Item("kodeobat"))
        Loop
    End Sub

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        tampilpasien()
        tampilobat()
        ID_Transaksi.Select()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ID_Transaksi.Text = "" Then
            MsgBox("silahkan Generate ID transaksi")
        ElseIf Jumlah_Obat.Text = "" Then
            MsgBox("silahkan Masukkan Jumlah Obat")
        Else
            simpan()
            tampil()
            Cb1.Text = "-Pilih-"
            Nama.Text = ""
            Alamat.Text = ""
            Jenis_Kelamin.Text = ""
            Cb2.Text = "-Pilih"
            Nama_Obat.Text = ""
            Apoteker.Text = ""
            ID_Transaksi.Text = ""
            Harga_Obat.Text = ""
            Jumlah_Obat.Text = ""
            Jumlah_Harga.Text = ""
            Cb1.Focus()
        End If
    End Sub

    Private Sub Cb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb1.SelectedIndexChanged
        cmd = New OdbcCommand("select * from data_pasien where ID_Pasien='" & Cb1.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Nama.Text = dr.Item("Nama_pasien")
            Alamat.Text = dr.Item("alamat_pasien")
            Jenis_Kelamin.Text = dr.Item("jenis_kelamin")
        Else
            MsgBox("No.RM Pasien tidak ada")
        End If
    End Sub

    Private Sub Cb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb2.SelectedIndexChanged
        cmd = New OdbcCommand("select * from data_obat where kodeobat='" & Cb2.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Nama_Obat.Text = dr.Item("namaobat")
            Apoteker.Text = dr.Item("apoteker")
            Harga_Obat.Text = dr.Item("hargaobat")
            Jumlah_Obat.Enabled = True
        Else
            MsgBox("Kode obat tidak ada")
        End If

    End Sub

    Private Sub Jumlah_Obat_TextChanged(sender As Object, e As EventArgs) Handles Jumlah_Obat.TextChanged
        If Jumlah_Obat.Text = "" Or Jumlah_Obat.Text = " " Then
            Jumlah_Harga.Text = ""
        Else
            Dim harga As Double
            Dim jumlahobat As Double
            Dim bayar As Double
            jumlahobat = Jumlah_Obat.Text
            harga = Harga_Obat.Text
            bayar = harga * jumlahobat
            Jumlah_Harga.Text = bayar
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String = dgv2.Item(0, dgv2.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Nilai yang dihapus belum DIPILIH")
        ElseIf (MessageBox.Show("Anda yakin menghapus data transaksi=" & a &
           "...?", "Delete", MessageBoxButtons.OKCancel,
           MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
            koneksi()
            cmd = New OdbcCommand("delete from transaksi where KodeTransaksi='" & a & "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Menghapus data nilai BERHASIL", vbInformation,
            "INFORMASI")
            con.Close()
            tampil()
        End If
    End Sub

    Private Sub Harga_Obat_TextChanged(sender As Object, e As EventArgs) Handles Harga_Obat.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Nama.Text = "" Or Nama_Obat.Text = "" Then
            MsgBox("Silahkan Isi Data NoRM serta KodeObat dulu")
        Else
            nomor()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form_Home.Show()
    End Sub
End Class