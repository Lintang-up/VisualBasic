Imports System.Data.Odbc

Public Class checkInList
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
        dgvCheckInList.Rows.Clear()
        Try
            koneksi()
            dataAdapter = New OdbcDataAdapter("select * from transaksi where status='Belum Lunas'", connect)
            dataTable = New DataTable
            dataAdapter.Fill(dataTable)
            For Each row In dataTable.Rows
                dgvCheckInList.Rows.Add(row(0), row(1), row(2), row(3), FormatCurrency(row(4), 0),
                                    Format(row(5), "dd-MM-yyyy"), Format(row(6), "dd-MM-yyyy"), row(7), row(8), row(9),
                                    FormatCurrency(row(10), 0), row(11), FormatCurrency(row(12), 0), FormatCurrency(row(13), 0), FormatCurrency(row(14), 0),
                                    FormatCurrency(row(15), 0))
            Next
            dataTable.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan Data Gagal")
        End Try
    End Sub

    Private Sub checkInList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub btCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCetak.Click
        Dim sql As String = "SELECT idTransaksi,namaTamu,nomorRuangan,tipeRuangan,tarifKamar,tanggalCheckIn,tanggalCheckOut,jumlahHari,jumlahDewasa,jumlahAnak,diskonInap,tipeMember,diskonMember,subTotal,uangMuka,totalKurang,idTamu,idRuangan FROM transaksi WHERE status = 'Belum Lunas'"
        Try
            FCetakCheckInList.DataSetTransaksi.Clear()
            FCetakCheckInList.DataSetTransaksi.EnforceConstraints = False
            koneksi()
            dataAdapter = New OdbcDataAdapter(sql, connect)
            dataAdapter.Fill(FCetakCheckInList.DataSetTransaksi.transaksi)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'FCetakCheckInList.ReportViewer2.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        FCetakCheckInList.ReportViewer2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        FCetakCheckInList.ReportViewer2.ZoomPercent = 100
        FCetakCheckInList.ReportViewer2.RefreshReport()
        FCetakCheckInList.Show()
    End Sub
End Class