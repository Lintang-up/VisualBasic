Public Class Tugas_1

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        End
    End Sub

    Private Sub harga_TextChanged(sender As Object, e As EventArgs) Handles harga.TextChanged

    End Sub

    Private Sub Tugas_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        harga.ReadOnly = True
        harga.Enabled = False
    End Sub

    Private Sub ukuran_makanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ukuran_makanan.SelectedIndexChanged
        If jenis_makanan.Text = "Bubur Ayam" Then
            If ukuran_makanan.Text = "Kecil" Then
                harga.Text = 8000
            ElseIf ukuran_makanan.Text = "Biasa" Then
                harga.Text = 10000
            ElseIf ukuran_makanan.Text = "Besar" Then
                harga.Text = 12000
            ElseIf ukuran_makanan.Text = "Besar Besar" Then
                harga.Text = 15000
            End If

        ElseIf jenis_makanan.Text = "Bubur Sapi" Then
            If ukuran_makanan.Text = "Kecil" Then
                harga.Text = 10000
            ElseIf ukuran_makanan.Text = "Biasa" Then
                harga.Text = 12000
            ElseIf ukuran_makanan.Text = "Besar" Then
                harga.Text = 15000
            ElseIf ukuran_makanan.Text = "Besar Besar" Then
                harga.Text = 18000
            End If

        ElseIf jenis_makanan.Text = "Bubur Original" Then
            If ukuran_makanan.Text = "Kecil" Then
                harga.Text = 6000
            ElseIf ukuran_makanan.Text = "Biasa" Then
                harga.Text = 7000
            ElseIf ukuran_makanan.Text = "Besar" Then
                harga.Text = 8000
            ElseIf ukuran_makanan.Text = "Besar Besar" Then
                harga.Text = 10000
            End If

        ElseIf jenis_makanan.Text = "Bubur Coklat" Then
            If ukuran_makanan.Text = "Kecil" Then
                harga.Text = 9000
            ElseIf ukuran_makanan.Text = "Biasa" Then
                harga.Text = 10000
            ElseIf ukuran_makanan.Text = "Besar" Then
                harga.Text = 12000
            ElseIf ukuran_makanan.Text = "Besar Besar" Then
                harga.Text = 15000
            End If

        ElseIf jenis_makanan.Text = "Bubur Strawberry" Then
            If ukuran_makanan.Text = "Kecil" Then
                harga.Text = 9500
            ElseIf ukuran_makanan.Text = "Biasa" Then
                harga.Text = 11000
            ElseIf ukuran_makanan.Text = "Besar" Then
                harga.Text = 13000
            ElseIf ukuran_makanan.Text = "Besar Besar" Then
                harga.Text = 15000
            End If
        End If
    End Sub

    Private Sub jenis_makanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles jenis_makanan.SelectedIndexChanged
        If jenis_makanan.Text = "Bubur Ayam" Then
            If ukuran_makanan.Text = "Kecil" Then
                harga.Text = 8000
            ElseIf ukuran_makanan.Text = "Biasa" Then
                harga.Text = 10000
            ElseIf ukuran_makanan.Text = "Besar" Then
                harga.Text = 12000
            ElseIf ukuran_makanan.Text = "Besar Besar" Then
                harga.Text = 15000
            End If

        ElseIf jenis_makanan.Text = "Bubur Sapi" Then
            If ukuran_makanan.Text = "Kecil" Then
                harga.Text = 10000
            ElseIf ukuran_makanan.Text = "Biasa" Then
                harga.Text = 12000
            ElseIf ukuran_makanan.Text = "Besar" Then
                harga.Text = 15000
            ElseIf ukuran_makanan.Text = "Besar Besar" Then
                harga.Text = 18000
            End If

        ElseIf jenis_makanan.Text = "Bubur Original" Then
            If ukuran_makanan.Text = "Kecil" Then
                harga.Text = 6000
            ElseIf ukuran_makanan.Text = "Biasa" Then
                harga.Text = 7000
            ElseIf ukuran_makanan.Text = "Besar" Then
                harga.Text = 8000
            ElseIf ukuran_makanan.Text = "Besar Besar" Then
                harga.Text = 10000
            End If

        ElseIf jenis_makanan.Text = "Bubur Coklat" Then
            If ukuran_makanan.Text = "Kecil" Then
                harga.Text = 9000
            ElseIf ukuran_makanan.Text = "Biasa" Then
                harga.Text = 10000
            ElseIf ukuran_makanan.Text = "Besar" Then
                harga.Text = 12000
            ElseIf ukuran_makanan.Text = "Besar Besar" Then
                harga.Text = 15000
            End If

        ElseIf jenis_makanan.Text = "Bubur Strawberry" Then
            If ukuran_makanan.Text = "Kecil" Then
                harga.Text = 9500
            ElseIf ukuran_makanan.Text = "Biasa" Then
                harga.Text = 11000
            ElseIf ukuran_makanan.Text = "Besar" Then
                harga.Text = 13000
            ElseIf ukuran_makanan.Text = "Besar Besar" Then
                harga.Text = 15000
            End If
        End If
    End Sub

    Private Sub hitung_Click(sender As Object, e As EventArgs) Handles hitung.Click
        Dim HR As Integer
        Dim JB As Integer
        Dim TH As Integer

        Dim POTONG As Integer
        Dim POT As Integer

        HR = CInt(harga.Text)
        JB = CInt(jumlah_beli.Text)
        TH = (HR * JB)

        total_harga.Text = " " & TH

        If CInt(TH) >= 500000 Then
            POTONG = 50000
            POT = (TH - POTONG)
        Else
            POT = TH
        End If

        potongan.Text = "" & POTONG
        total_bayar.Text = "" & POT
    End Sub
End Class
