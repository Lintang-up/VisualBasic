Public Class Riwayat
    Public frmDaftarPengunjung As Riwayat
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
            End With
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Awal.Show()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class