Imports System.Data.Odbc

Public Class roomList
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
        dgvRoomListInTheCheckIn.Rows.Clear()
        Try
            koneksi()
            dataAdapter = New OdbcDataAdapter("select * from ruangan", connect)
            dataTable = New DataTable
            dataAdapter.Fill(dataTable)
            For Each row In dataTable.Rows
                dgvRoomListInTheCheckIn.Rows.Add(row(0), row(1), row(2), row(3), row(4))
            Next
            dataTable.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan Data Gagal")
        End Try
    End Sub

    Private Sub roomList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub btCheckOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCetak.Click
        Dim sql As String = "select nomorRuangan,tipeRuangan,jumlahHunian,status from ruangan"
        Try
            FCetakRoomList.DataSetRuangan.Clear()
            FCetakRoomList.DataSetRuangan.EnforceConstraints = False
            koneksi()
            dataAdapter = New OdbcDataAdapter(sql, connect)
            dataAdapter.Fill(FCetakRoomList.DataSetRuangan.ruangan)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        FCetakRoomList.ReportViewer4.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        FCetakRoomList.ReportViewer4.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        FCetakRoomList.ReportViewer4.ZoomPercent = 25
        FCetakRoomList.ReportViewer4.RefreshReport()
        FCetakRoomList.Show()
    End Sub
End Class