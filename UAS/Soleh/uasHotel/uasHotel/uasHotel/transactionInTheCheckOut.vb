Imports System.Data.Odbc
Imports System.Globalization
Public Class transactionInTheCheckOut

    Dim connect As OdbcConnection
    Dim dataReader As OdbcDataReader
    Dim dataAdapter As OdbcDataAdapter
    Dim dataSet As DataSet
    Dim dataTable As DataTable
    Dim cmd As OdbcCommand

    Public idTamu As Integer
    Public idRuangan As Integer

    Sub koneksi()
        connect = New OdbcConnection
        connect.ConnectionString = "dsn=visual_hotel"
        connect.Open()
    End Sub

    Sub tampil()
        dgvTransactionInTheCheckOut.Rows.Clear()
        Try
            koneksi()
            dataAdapter = New OdbcDataAdapter("select * from transaksi where status= 'Belum Lunas'", connect)
            dataTable = New DataTable
            dataAdapter.Fill(dataTable)
            For Each row In dataTable.Rows
                dgvTransactionInTheCheckOut.Rows.Add(row(0), row(1), row(2), row(3), FormatCurrency(row(4), 0),
                                    Format(row(5), "dd-MM-yyyy"), Format(row(6), "dd-MM-yyyy"), row(7), row(8), row(9),
                                    FormatCurrency(row(10), 0), row(11), FormatCurrency(row(12), 0), FormatCurrency(row(13), 0), FormatCurrency(row(14), 0),
                                    FormatCurrency(row(15), 0), row(18), row(19))
            Next
            dataTable.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan Data Gagal")
        End Try
    End Sub

    Private Sub transactionInTheCheckOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Public Shared Property selectedRow As DataGridViewRow

    Private Sub dgvTransactionInTheCheckOut_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvTransactionInTheCheckOut.CellMouseClick
        If e.RowIndex >= 0 Then
            selectedRow = dgvTransactionInTheCheckOut.Rows(e.RowIndex)

            Dim a As String = dgvTransactionInTheCheckOut.Item(0, dgvTransactionInTheCheckOut.CurrentRow.Index).Value
            If a = "" Then
            Else
                Dim tanggalCheckIn As String = transactionInTheCheckOut.selectedRow.Cells(5).Value
                Dim tanggal As DateTime = DateTime.ParseExact(tanggalCheckIn, "dd-MM-yyyy", CultureInfo.InvariantCulture)
                Dim tanggalFormatted As String = tanggal.ToString("dddd, dd MMMM yyyy", CultureInfo.GetCultureInfo("id-ID"))

                Dim tanggalCheckOut As String = transactionInTheCheckOut.selectedRow.Cells(6).Value
                Dim tanggal1 As DateTime = DateTime.ParseExact(tanggalCheckOut, "dd-MM-yyyy", CultureInfo.InvariantCulture)
                Dim tanggalFormatted1 As String = tanggal1.ToString("dddd, dd MMMM yyyy", CultureInfo.GetCultureInfo("id-ID"))



                checkOut.textIdTransaksi.Text = transactionInTheCheckOut.selectedRow.Cells(0).Value
                checkOut.tbNamaTamu.Text = transactionInTheCheckOut.selectedRow.Cells(1).Value
                checkOut.tbNoRuangan.Text = transactionInTheCheckOut.selectedRow.Cells(2).Value
                checkOut.tbTipeRuangan.Text = transactionInTheCheckOut.selectedRow.Cells(3).Value
                checkOut.tbTarifKamar.Text = transactionInTheCheckOut.selectedRow.Cells(4).Value
                checkOut.tbTglCheckIn.Text = tanggalFormatted
                checkOut.tbTglCheckOut.Text = tanggalFormatted1
                checkOut.tbJumlahHari.Text = transactionInTheCheckOut.selectedRow.Cells(7).Value
                checkOut.tbJumlahDewasa.Text = transactionInTheCheckOut.selectedRow.Cells(8).Value
                checkOut.tbJumlahAnak.Text = transactionInTheCheckOut.selectedRow.Cells(9).Value
                checkOut.tbDiskonInap.Text = transactionInTheCheckOut.selectedRow.Cells(10).Value
                checkOut.tbTipeMember.Text = transactionInTheCheckOut.selectedRow.Cells(11).Value
                checkOut.tbDiskonMember.Text = transactionInTheCheckOut.selectedRow.Cells(12).Value
                checkOut.tbSubTotal.Text = transactionInTheCheckOut.selectedRow.Cells(13).Value
                checkOut.tbUangMuka.Text = transactionInTheCheckOut.selectedRow.Cells(14).Value
                checkOut.tbTotalKurang.Text = transactionInTheCheckOut.selectedRow.Cells(15).Value
                checkOut.textIdTransaksi.Visible = True
                idTamu = transactionInTheCheckOut.selectedRow.Cells(16).Value
                idRuangan = transactionInTheCheckOut.selectedRow.Cells(17).Value
            End If
            Me.Hide()
        End If
    End Sub
End Class