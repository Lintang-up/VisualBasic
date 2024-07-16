Public Class daftarPengunjung
    Public frmDaftarPengunjung As daftarPengunjung
    Public Sub tampilkanData()
        ListView1.Items.Clear()

        Dim data As List(Of String()) = Form1.getData()

        For Each item In data
            With ListView1.Items.Add(item(0))
                .SubItems.Add(item(1))
                .SubItems.Add(item(2))
                .SubItems.Add(item(3))
                .SubItems.Add(item(4))
                .SubItems.Add(item(5))
                .SubItems.Add(item(6))
                .SubItems.Add(item(7))
                .SubItems.Add(item(8))
                .SubItems.Add(item(9))
                .SubItems.Add(item(10))
                .SubItems.Add(item(11))
                .SubItems.Add(item(12))
                .SubItems.Add(item(13))
                .SubItems.Add(item(14))
                .SubItems.Add(item(15))
                .SubItems.Add(item(16))

            End With
        Next
    End Sub

    Private Sub kembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kembali.Click
        Me.Hide()
        tampilanAwal.Show()
    End Sub

    Private Sub daftarPengunjung_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cek apakah variabel publik frmDaftarPengunjung telah di-set dari form tambah pengunjung
        If Not IsNothing(frmDaftarPengunjung) Then
            'Loop melalui semua item yang telah ditambahkan ke ListView di form tambah pengunjung
            For Each item As ListViewItem In frmDaftarPengunjung.ListView1.Items
                'Tambahkan item ke ListView di form daftar pengunjung
                Me.ListView1.Items.Add(item.Clone())
            Next
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = ListView1.SelectedItems(0)
            ListView1.Items.Remove(item)
        End If
    End Sub
End Class