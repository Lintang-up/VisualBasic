Imports System.Data.Odbc

Public Class GuestListInTheCheckIn

    Dim connect As OdbcConnection
    Dim dataReader As OdbcDataReader
    Dim dataAdapter As OdbcDataAdapter
    Dim dataSet As DataSet
    Dim dataTable As DataTable
    Dim cmd As OdbcCommand

    'variabel bantu
    Public dataIdTamu As Integer
    Public dataNama As String
    Public dataAlamat As String
    Public dataKtp As String
    Public dataNoHp As String
    Public dataJenisKelamin As String


    Sub koneksi()
        connect = New OdbcConnection
        connect.ConnectionString = "dsn=visual_hotel"
        connect.Open()
    End Sub

    Sub tampil()
        dgvGuestListInTheCheckIn.Rows.Clear()
        Try
            koneksi()
            dataAdapter = New OdbcDataAdapter("select * from tamu where status= 'menunggu'", connect)
            dataTable = New DataTable
            dataAdapter.Fill(dataTable)
            For Each row In dataTable.Rows
                dgvGuestListInTheCheckIn.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5))
            Next
            dataTable.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan Data Gagal")
        End Try
    End Sub

    Private Sub GuestListInTheCheckIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Public Shared Property selectedRow As DataGridViewRow

    Private Sub dgvGuestListInTheCheckIn_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvGuestListInTheCheckIn.CellMouseClick
        If e.RowIndex >= 0 Then
            selectedRow = dgvGuestListInTheCheckIn.Rows(e.RowIndex)

            On Error Resume Next
            dataIdTamu = GuestListInTheCheckIn.selectedRow.Cells(0).Value
            dataNama = GuestListInTheCheckIn.selectedRow.Cells(1).Value
            dataAlamat = GuestListInTheCheckIn.selectedRow.Cells(2).Value
            dataKtp = GuestListInTheCheckIn.selectedRow.Cells(3).Value
            dataNoHp = GuestListInTheCheckIn.selectedRow.Cells(4).Value
            dataJenisKelamin = GuestListInTheCheckIn.selectedRow.Cells(5).Value
            checkIn.tbNamaTamu.Text = dataNama
            connect.Close()
            Me.Hide()
        End If
    End Sub
End Class