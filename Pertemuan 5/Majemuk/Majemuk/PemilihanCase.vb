Public Class PemilihanCase

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles nama.TextChanged
        oke.Enabled = True
        If nama.Text.Trim = "" Or nilai.Text.Trim = "" Then
            oke.Enabled = False
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles nilai.TextChanged
        oke.Enabled = True
        If nama.Text.Trim = "" Or nilai.Text.Trim = "" Then
            oke.Enabled = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles oke.Click
        Select Case nama.Text.Trim.ToUpper
            Case "GILANG"
                MessageBox.Show("Nama saya Gilang", "HASIL")
            Case "WIDHI"
                MessageBox.Show("Nama saya om widhi", "HASIL")
            Case "LINTANG"
                MessageBox.Show("Nama saya Lintang", "HASIL")
            Case Else
                MessageBox.Show("Anda Bukan Siswa sini", "HASIL")
        End Select
        On Error Resume Next
        Select Case CInt(nilai.Text.Trim)
            Case Is < 60
                MessageBox.Show("Nilai anda kurang dari 60", "TABEL NILAI")
            Case Is < 80
                MessageBox.Show("Nilai anda dalam range 60-80", "TABEL NILAI")
            Case Is <= 100
                MessageBox.Show("Nilai anda dalam range 80-100", "TABEL")
            Case Else
                MessageBox.Show("Nilai anda tidak valid", "Pesan")
        End Select

    End Sub
End Class