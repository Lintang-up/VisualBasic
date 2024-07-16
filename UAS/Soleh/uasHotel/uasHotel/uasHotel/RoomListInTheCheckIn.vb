Imports System.Data.Odbc

Public Class RoomListInTheCheckIn

    Dim connect As OdbcConnection
    Dim dataReader As OdbcDataReader
    Dim dataAdapter As OdbcDataAdapter
    Dim dataSet As DataSet
    Dim dataTable As DataTable
    Dim cmd As OdbcCommand

    'variabel bantu
    Public dataIdRuangan As Integer
    Public dataNomorRuangan As String
    Public dataTipeRuangan As String
    Public dataJumlahHunian As String
    Public dataHarga As Integer

    Sub koneksi()
        connect = New OdbcConnection
        connect.ConnectionString = "dsn=visual_hotel"
        connect.Open()
    End Sub

    Sub tampil()
        dgvRoomListInTheCheckIn.Rows.Clear()
        Try
            koneksi()
            dataAdapter = New OdbcDataAdapter("select * from ruangan where status='kosong'", connect)
            dataTable = New DataTable
            dataAdapter.Fill(dataTable)
            For Each row In dataTable.Rows
                dgvRoomListInTheCheckIn.Rows.Add(row(0), row(1), row(2), row(3))
            Next
            dataTable.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan Data Gagal")
        End Try
    End Sub

    Private Sub RoomListInTheCheckIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Public Shared Property selectedRoomRow As DataGridViewRow

    Private Sub dgvRoomListInTheCheckIn_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvRoomListInTheCheckIn.CellMouseClick
        If e.RowIndex >= 0 Then
            selectedRoomRow = dgvRoomListInTheCheckIn.Rows(e.RowIndex)

            On Error Resume Next
            dataIdRuangan = RoomListInTheCheckIn.selectedRoomRow.Cells(0).Value
            dataNomorRuangan = RoomListInTheCheckIn.selectedRoomRow.Cells(1).Value
            dataTipeRuangan = RoomListInTheCheckIn.selectedRoomRow.Cells(2).Value
            dataJumlahHunian = RoomListInTheCheckIn.selectedRoomRow.Cells(3).Value
            checkIn.tbNoRuangan.Text = dataNomorRuangan
            checkIn.tbTipeRuangan.Text = dataTipeRuangan
            connect.Close()

            If dataTipeRuangan = "Single" Then
                dataHarga = 100000
            ElseIf dataTipeRuangan = "Double" Then
                dataHarga = 150000
            ElseIf dataTipeRuangan = "Deluxe" Then
                dataHarga = 225000
            ElseIf dataTipeRuangan = "Kids" Then
                dataHarga = 125000
            End If

            checkIn.tbTarifKamar.Text = FormatCurrency(dataHarga, 0)

            Me.Hide()
        End If
    End Sub
End Class