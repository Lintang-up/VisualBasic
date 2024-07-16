Imports System.Data.Odbc

Public Class guestList
    'variabel-variabel 
    Dim connect As OdbcConnection
    Dim dataReader As OdbcDataReader
    Dim dataAdapter As OdbcDataAdapter
    Dim dataSet As DataSet
    Dim dataTable As DataTable
    Dim cmd As OdbcCommand

    Sub koneksi()
        connect = New OdbcConnection
        connect.ConnectionString = "dsn=visual_hotel"
        connect.Open()
    End Sub

    Sub tampil()
        dgvGuestList.Rows.Clear()
        Try
            koneksi()
            dataAdapter = New OdbcDataAdapter("select * from tamu where status='menghuni'", connect)
            dataTable = New DataTable
            dataAdapter.Fill(dataTable)
            For Each row In dataTable.Rows
                dgvGuestList.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5))
            Next
            dataTable.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan Data Gagal")
        End Try
    End Sub

    Private Sub guestList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub btCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCetak.Click
        Dim sql As String = "select nama,alamat,ktp,noHp,jenisKelamin from tamu where status='menghuni'"
        Try
            FCetakGuestList.DataSetTamu.Clear()
            FCetakGuestList.DataSetTamu.EnforceConstraints = False
            koneksi()
            dataAdapter = New OdbcDataAdapter(sql, connect)
            dataAdapter.Fill(FCetakGuestList.DataSetTamu.tamu)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        FCetakGuestList.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        FCetakGuestList.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        FCetakGuestList.ReportViewer1.ZoomPercent = 25
        FCetakGuestList.ReportViewer1.RefreshReport()
        FCetakGuestList.Show()
    End Sub
End Class