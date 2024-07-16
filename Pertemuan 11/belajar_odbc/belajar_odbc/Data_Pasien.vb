Imports System.Data.Odbc

Public Class Data_Pasien
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
        Dim sql As String = "insert into data_pasien values('" & no_rm.Text & "','" & nama_pasien.Text & "','" &
        Alamat.Text & "','" & JK.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Sub tampil()
        dgv1.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select * from data_pasien order by ID_Pasien asc",
            con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                dgv1.Rows.Add(row(0), row(1), row(2), row(3))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub

    Sub nomor()
        Try
            koneksi()
            cmd = New OdbcCommand("SELECT * FROM `data_pasien` ORDER BY ID_Pasien DESC", con)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Dim lastTransNo As Integer = Integer.Parse(dr("ID_Pasien").ToString())
                no_rm.Text = (lastTransNo + 1).ToString()
            Else
                no_rm.Text = Date.Now.ToString("MMyyyy") & "001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        nomor()
        nama_pasien.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()
        tampil()
        no_rm.Text = ""
        nama_pasien.Text = ""
        Alamat.Text = ""
        JK.Text = ""
        no_rm.Focus()
        nomor()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim a As String = dgv1.Item(0, dgv1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Pasien yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan daftar=" & a &
            "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) =
            Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from data_pasien where ID_Pasien='" & a &
                "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data BERHASIL", vbInformation, "INFORMASI")
                con.Close()
                tampil()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Cetak.Click
        Dim query As String = "SELECT * FROM data_pasien ORDER BY ID_Pasien ASC"
        Try
            LAPORAN.DataSet1.Clear()
            LAPORAN.DataSet1.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, con)
            da.Fill(LAPORAN.DataSet1.data_pasien)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        LAPORAN.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        LAPORAN.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        LAPORAN.ReportViewer1.ZoomPercent = 25
        LAPORAN.ReportViewer1.RefreshReport()
        LAPORAN.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form_Home.Show()
    End Sub

    Private Sub no_rm_TextChanged(sender As Object, e As EventArgs) Handles no_rm.TextChanged

    End Sub
End Class
