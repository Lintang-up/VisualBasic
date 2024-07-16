Imports System.Data.Odbc
Public Class data_obat
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
        Dim sql As String = "insert into data_obat values('" & kobat.Text &
       "','" & nambat.Text & "','" & apoteker.Text & "')"
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
            da = New OdbcDataAdapter("select * from data_obat order by kodeobat asc ", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                dgv2.Rows.Add(row(0), row(1), row(2))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        kobat.Text = ""
        nambat.Text = ""
        apoteker.Text = ""
        kobat.Focus()
    End Sub

    Private Sub data_obat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kobat.Select()
        tampil()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tampil()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim a As String = dgv2.Item(0, dgv2.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Obat yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan daftar=" & a &
            "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) =
            Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from data_obat where kodeobat='" & a &
                "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data BERHASIL", vbInformation, "INFORMASI")
                con.Close()
                tampil()
            End If
        End If
    End Sub
End Class