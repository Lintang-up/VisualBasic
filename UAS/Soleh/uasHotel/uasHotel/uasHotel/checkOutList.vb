Imports System.Data.Odbc

Public Class checkOutList

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
            dataAdapter = New OdbcDataAdapter("select * from transaksi where status='Lunas'", connect)
            dataTable = New DataTable
            dataAdapter.Fill(dataTable)
            For Each row In dataTable.Rows
                dgvCheckInList.Rows.Add(row(0), row(1), row(2), row(3), FormatCurrency(row(4), 0),
                                    Format(row(5), "dd-MM-yyyy"), Format(row(6), "dd-MM-yyyy"), row(7), row(8), row(9),
                                    FormatCurrency(row(10), 0), row(11), FormatCurrency(row(12), 0), FormatCurrency(row(13), 0), FormatCurrency(row(14), 0),
                                    FormatCurrency(row(15), 0), FormatCurrency(row(16), 0), FormatCurrency(row(17), 0), row(18), row(19))
            Next
            dataTable.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan Data Gagal")
        End Try
    End Sub

    Private Sub checkOutList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub btCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCetak.Click
        Dim sql As String = "SELECT idTransaksi,namaTamu,nomorRuangan,tipeRuangan,tarifKamar,tanggalCheckIn,tanggalCheckOut,jumlahHari,jumlahDewasa,jumlahAnak,diskonInap,tipeMember,diskonMember,subTotal,uangMuka,totalKurang,bayar,kembalian,idTamu,idRuangan FROM transaksi WHERE status = 'Lunas'"
        Try
            FCetakCheckOutList.DataSetTransaksi.Clear()
            FCetakCheckOutList.DataSetTransaksi.EnforceConstraints = False
            koneksi()
            dataAdapter = New OdbcDataAdapter(sql, connect)
            dataAdapter.Fill(FCetakCheckOutList.DataSetTransaksi.transaksi)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'FCetakCheckOutList.ReportViewer3.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        FCetakCheckOutList.ReportViewer3.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        FCetakCheckOutList.ReportViewer3.ZoomPercent = 100
        FCetakCheckOutList.ReportViewer3.RefreshReport()
        FCetakCheckOutList.Show()
    End Sub
End Class