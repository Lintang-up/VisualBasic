Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Judul_Film.Items.Add("Jerapah Makan Sayur")
        Judul_Film.Items.Add("Spiderman EndGame")
        Judul_Film.Items.Add("High School DXD")
        Judul_Film.Items.Add("Cars 4")

        Harga.ReadOnly = True
        D_TotalPesan.ReadOnly = True
        D_Discount.ReadOnly = True
        D_TotalBayar.ReadOnly = True
        B_TotalBayar.ReadOnly = True
        B_Kembalian.ReadOnly = True
    End Sub

    Private Sub Judul_Film_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Judul_Film.SelectedIndexChanged
        If Judul_Film.Text = "Jerapah Makan Sayur" Then
            Hari.Text = ""
            Studio.Text = ""
            Jam_Tayang.Text = ""
            NO_Kursi_1.Text = ""
            No_Kursi_2.Text = ""
            Harga.Text = ""
            Jumlah_Tiket.Text = ""

            Studio.Items.Clear()
            Studio.Items.Add("Studio 1")
            Studio.Items.Add("Studio 3")
            Studio.Items.Add("Studio 4")
            If Studio.Text = "Studio 1" Then
                Hari.Items.Clear()
                Hari.Items.Add("Senin")
                Hari.Items.Add("Selasa")
                Hari.Items.Add("Jumat")
            ElseIf Studio.Text = "Studio 3" Then
                Hari.Items.Clear()
                Hari.Items.Add("Senin")
                Hari.Items.Add("Rabu")
            ElseIf Studio.Text = "Studio 4" Then
                Hari.Items.Clear()
                Hari.Items.Add("Sabtu")
                Hari.Items.Add("Minggu")
            End If

        ElseIf Judul_Film.Text = "Spiderman EndGame" Then
            Hari.Text = ""
            Studio.Text = ""
            Jam_Tayang.Text = ""
            NO_Kursi_1.Text = ""
            No_Kursi_2.Text = ""
            Harga.Text = ""
            Jumlah_Tiket.Text = ""

            Studio.Items.Clear()
            Studio.Items.Add("Studio 2")
            Studio.Items.Add("Studio 5")
            If Studio.Text = "Studio 2" Then
                Hari.Items.Clear()
                Hari.Items.Add("Senin")
                Hari.Items.Add("Rabu")
            ElseIf Studio.Text = "Studio 5" Then
                Hari.Items.Clear()
                Hari.Items.Add("Sabtu")
                Hari.Items.Add("Minggu")
            End If

        ElseIf Judul_Film.Text = "High School DXD" Then
            Hari.Text = ""
            Studio.Text = ""
            Jam_Tayang.Text = ""
            NO_Kursi_1.Text = ""
            No_Kursi_2.Text = ""
            Harga.Text = ""
            Jumlah_Tiket.Text = ""

            Studio.Items.Clear()
            Studio.Items.Add("Studio 1")
            Studio.Items.Add("Studio 2")
            If Studio.Text = "Studio 1" Then
                Hari.Items.Clear()
                Hari.Items.Add("Selasa")
                Hari.Items.Add("Rabu")
                Hari.Items.Add("Jumat")
            ElseIf Studio.Text = "Studio 2" Then
                Hari.Items.Clear()
                Hari.Items.Add("Sabtu")
                Hari.Items.Add("Minggu")
            End If

        ElseIf Judul_Film.Text = "Cars 4" Then
            Hari.Text = ""
            Studio.Text = ""
            Jam_Tayang.Text = ""
            NO_Kursi_1.Text = ""
            No_Kursi_2.Text = ""
            Harga.Text = ""
            Jumlah_Tiket.Text = ""

            Studio.Items.Clear()
            Studio.Items.Add("Studio 3")
            Studio.Items.Add("Studio 4")
            Studio.Items.Add("Studio 5")
            If Studio.Text = "Studio 3" Then
                Hari.Items.Clear()
                Hari.Items.Add("Senin")
                Hari.Items.Add("Kamis")
            ElseIf Studio.Text = "Studio 4" Then
                Hari.Items.Clear()
                Hari.Items.Add("Selasa")
                Hari.Items.Add("Jumat")
            ElseIf Studio.Text = "Studio 5" Then
                Hari.Items.Clear()
                Hari.Items.Add("Sabtu")
                Hari.Items.Add("Minggu")
            End If
        End If
    End Sub

    Private Sub Studio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Studio.SelectedIndexChanged
        If Judul_Film.Text = "Jerapah Makan Sayur" Then
            If Studio.Text = "Studio 1" Then
                Hari.Text = ""
                Studio.Text = ""
                Jam_Tayang.Text = ""
                NO_Kursi_1.Text = ""
                No_Kursi_2.Text = ""
                Harga.Text = ""
                Jumlah_Tiket.Text = ""

                Hari.Items.Clear()
                Hari.Items.Add("Senin")
                Hari.Items.Add("Selasa")
                Hari.Items.Add("Jumat")
            ElseIf Studio.Text = "Studio 3" Then
                Hari.Text = ""
                Studio.Text = ""
                Jam_Tayang.Text = ""
                NO_Kursi_1.Text = ""
                No_Kursi_2.Text = ""
                Harga.Text = ""
                Jumlah_Tiket.Text = ""

                Hari.Items.Clear()
                Hari.Items.Add("Senin")
                Hari.Items.Add("Rabu")
            ElseIf Studio.Text = "Studio 4" Then
                Hari.Text = ""
                Studio.Text = ""
                Jam_Tayang.Text = ""
                NO_Kursi_1.Text = ""
                No_Kursi_2.Text = ""
                Harga.Text = ""
                Jumlah_Tiket.Text = ""

                Hari.Items.Clear()
                Hari.Items.Add("Sabtu")
                Hari.Items.Add("Minggu")
            End If

        ElseIf Judul_Film.Text = "Spiderman EndGame" Then
            If Studio.Text = "Studio 2" Then
                Hari.Text = ""
                Studio.Text = ""
                Jam_Tayang.Text = ""
                NO_Kursi_1.Text = ""
                No_Kursi_2.Text = ""
                Harga.Text = ""
                Jumlah_Tiket.Text = ""

                Hari.Items.Clear()
                Hari.Items.Add("Senin")
                Hari.Items.Add("Rabu")
            ElseIf Studio.Text = "Studio 5" Then
                Hari.Text = ""
                Studio.Text = ""
                Jam_Tayang.Text = ""
                NO_Kursi_1.Text = ""
                No_Kursi_2.Text = ""
                Harga.Text = ""
                Jumlah_Tiket.Text = ""

                Hari.Items.Clear()
                Hari.Items.Add("Sabtu")
                Hari.Items.Add("Minggu")
            End If

        ElseIf Judul_Film.Text = "High School DXD" Then
            If Studio.Text = "Studio 1" Then
                Hari.Text = ""
                Studio.Text = ""
                Jam_Tayang.Text = ""
                NO_Kursi_1.Text = ""
                No_Kursi_2.Text = ""
                Harga.Text = ""
                Jumlah_Tiket.Text = ""

                Hari.Items.Clear()
                Hari.Items.Add("Selasa")
                Hari.Items.Add("Rabu")
                Hari.Items.Add("Jumat")
            ElseIf Studio.Text = "Studio 2" Then
                Hari.Text = ""
                Studio.Text = ""
                Jam_Tayang.Text = ""
                NO_Kursi_1.Text = ""
                No_Kursi_2.Text = ""
                Harga.Text = ""
                Jumlah_Tiket.Text = ""

                Hari.Items.Clear()
                Hari.Items.Add("Sabtu")
                Hari.Items.Add("Minggu")
            End If

        ElseIf Judul_Film.Text = "Cars 4" Then
            If Studio.Text = "Studio 3" Then
                Hari.Text = ""
                Studio.Text = ""
                Jam_Tayang.Text = ""
                NO_Kursi_1.Text = ""
                No_Kursi_2.Text = ""
                Harga.Text = ""
                Jumlah_Tiket.Text = ""

                Hari.Items.Clear()
                Hari.Items.Add("Senin")
                Hari.Items.Add("Kamis")
            ElseIf Studio.Text = "Studio 4" Then
                Hari.Text = ""
                Studio.Text = ""
                Jam_Tayang.Text = ""
                NO_Kursi_1.Text = ""
                No_Kursi_2.Text = ""
                Harga.Text = ""
                Jumlah_Tiket.Text = ""

                Hari.Items.Clear()
                Hari.Items.Add("Selasa")
                Hari.Items.Add("Jumat")
            ElseIf Studio.Text = "Studio 5" Then
                Hari.Text = ""
                Studio.Text = ""
                Jam_Tayang.Text = ""
                NO_Kursi_1.Text = ""
                No_Kursi_2.Text = ""
                Harga.Text = ""
                Jumlah_Tiket.Text = ""

                Hari.Items.Clear()
                Hari.Items.Add("Sabtu")
                Hari.Items.Add("Minggu")
            End If
        End If
    End Sub

    Private Sub Hari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Hari.SelectedIndexChanged
        If Judul_Film.Text = "Jerapah Makan Sayur" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("13.00 WIB")
                    Jam_Tayang.Items.Add("15.30 WIB")
                    Jam_Tayang.Items.Add("19.00 WIB")
                ElseIf Hari.Text = "Selasa" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("11.00 WIB")
                    Jam_Tayang.Items.Add("18.00 WIB")
                ElseIf Hari.Text = "Jumat" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("14.00 WIB")
                    Jam_Tayang.Items.Add("18.00 WIB")
                End If
            ElseIf Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("12.00 WIB")
                    Jam_Tayang.Items.Add("14.30 WIB")
                ElseIf Hari.Text = "Rabu" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("12.30 WIB")
                End If

            ElseIf Studio.Text = "Studio 4" Then
                If Hari.Text = "Sabtu" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("12.30 WIB")
                    Jam_Tayang.Items.Add("15.30 WIB")
                    Jam_Tayang.Items.Add("19.30 WIB")
                ElseIf Hari.Text = "Minggu" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("13.30 WIB")
                    Jam_Tayang.Items.Add("16.00 WIB")
                    Jam_Tayang.Items.Add("20.00 WIB")
                End If
            End If

        ElseIf Judul_Film.Text = "Spiderman EndGame" Then
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("14.30 WIB")
                ElseIf Hari.Text = "Rabu" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("17.30 WIB")
                    Jam_Tayang.Items.Add("20.00 WIB")
                ElseIf Hari.Text = "Jumat" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("14.00 WIB")
                    Jam_Tayang.Items.Add("18.00 WIB")
                End If
            ElseIf Studio.Text = "Studio 5" Then
                If Hari.Text = "Sabtu" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("12.00 WIB")
                    Jam_Tayang.Items.Add("14.30 WIB")
                ElseIf Hari.Text = "Minggu" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("15.00 WIB")
                    Jam_Tayang.Items.Add("19.30 WIB")
                End If
            End If

        ElseIf Judul_Film.Text = "High School DXD" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Selasa" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("15.30 WIB")
                ElseIf Hari.Text = "Rabu" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("17.00 WIB")
                ElseIf Hari.Text = "Jumat" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("14.00 WIB")
                End If
            ElseIf Studio.Text = "Studio 2" Then
                If Hari.Text = "Sabtu" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("12.00 WIB")
                ElseIf Hari.Text = "Minggu" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("14.00 WIB")
                    Jam_Tayang.Items.Add("17.30 WIB")
                End If
            End If

        ElseIf Judul_Film.Text = "Cars 4" Then
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("12.30 WIB")
                ElseIf Hari.Text = "Kamis" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("14.40 WIB")
                End If
            ElseIf Studio.Text = "Studio 4" Then
                If Hari.Text = "Selasa" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("16.00 WIB")
                    Jam_Tayang.Items.Add("20.00 WIB")
                ElseIf Hari.Text = "Jumat" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("14.00 WIB")
                End If
            ElseIf Studio.Text = "Studio 5" Then
                If Hari.Text = "Sabtu" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("15.00 WIB")
                    Jam_Tayang.Items.Add("18.30 WIB")
                ElseIf Hari.Text = "Minggu" Then
                    Jam_Tayang.Text = ""
                    NO_Kursi_1.Text = ""
                    No_Kursi_2.Text = ""
                    Harga.Text = ""
                    Jumlah_Tiket.Text = ""

                    Jam_Tayang.Items.Clear()
                    Jam_Tayang.Items.Add("16.00 WIB")
                    Jam_Tayang.Items.Add("19.30 WIB")
                End If
            End If
        End If



        If Judul_Film.Text = "Jerapah Makan Sayur" Then
            If Hari.Text = "Sabtu" Or Hari.Text = "Minggu" Then
                Harga.Text = 40000
            Else
                Harga.Text = 30000
            End If
        ElseIf Judul_Film.Text = "Spiderman EndGame" Then
            If Hari.Text = "Sabtu" Or Hari.Text = "Minggu" Then
                Harga.Text = 55000
            Else
                Harga.Text = 35000
            End If
        ElseIf Judul_Film.Text = "High School DXD" Then
            If Hari.Text = "Sabtu" Or Hari.Text = "Minggu" Then
                Harga.Text = 40000
            Else
                Harga.Text = 25000
            End If
        ElseIf Judul_Film.Text = "Cars 4" Then
            If Hari.Text = "Sabtu" Or Hari.Text = "Minggu" Then
                Harga.Text = 50000
            Else
                Harga.Text = 40000
            End If
        End If
    End Sub

    Private Sub Harga_TextChanged(sender As Object, e As EventArgs) Handles Harga.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Judul_Film.Text = "" Or Studio.Text = "" Or Hari.Text = "" Or Jumlah_Tiket.Text = "" Or Jam_Tayang.Text = "" Or NO_Kursi_1.Text = "" Or No_Kursi_2.Text = "" Then
            MsgBox("Silahkan Lengkapi Data Dahulu!")
        Else
            D_JudulFilm.Text = Judul_Film.Text
            D_Studio.Text = Studio.Text
            D_hari.Text = Hari.Text
            D_JumlahTiket.Text = Jumlah_Tiket.Text
            D_JamTayang.Text = Jam_Tayang.Text
            D_NoKursi.Text = NO_Kursi_1.Text + No_Kursi_2.Text

            Dim HR As Integer
            Dim JB As Integer
            Dim TH As Integer
            HR = CInt(Harga.Text)
            JB = CInt(Jumlah_Tiket.Text)
            TH = (HR * JB)

            Dim DISC As Integer
            Dim POT As Integer
            If CInt(JB) >= 5 Then
                DISC = TH * 0.1
                POT = (TH - DISC)
            Else
                POT = TH
            End If

            D_TotalPesan.Text = "RP " & TH
            D_Discount.Text = "RP " & DISC
            D_TotalBayar.Text = "RP " & POT

            B_TotalBayar.Text = "RP " & POT
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Judul_Film.Text = "" Or Studio.Text = "" Or Hari.Text = "" Or Jumlah_Tiket.Text = "" Or Jam_Tayang.Text = "" Or NO_Kursi_1.Text = "" Or No_Kursi_2.Text = "" Then
            MsgBox("Silahkan Lengkapi Data Dahulu!")
        Else
            Dim HR As Integer
            Dim JB As Integer
            Dim TH As Integer
            HR = CInt(Harga.Text)
            JB = CInt(Jumlah_Tiket.Text)
            TH = (HR * JB)

            Dim DISC As Integer
            Dim DISC1 As String
            Dim POT As Integer
            If CInt(JB) >= 5 Then
                DISC1 = "10%"
                DISC = TH * 0.1
                POT = (TH - DISC)
            Else
                POT = TH
            End If

            If B_Pembayaran.Text = " " Or B_Pembayaran.Text < POT Then
                MsgBox("Silahkan Masukkan Angka Yang Valid")
            Else
                Dim Pembayar As Integer
                Dim Kembali As Integer
                Pembayar = B_Pembayaran.Text
                Kembali = Pembayar - POT
                B_Kembalian.Text = "RP " & Kembali

                H_JudulFilm = D_JudulFilm.Text
                H_Studio = D_Studio.Text
                H_hari = D_hari.Text
                H_JamTayang = D_JamTayang.Text
                H_NoKursi = D_NoKursi.Text
                H_Harga = Harga.Text
                H_JumlahTiket = D_JumlahTiket.Text
                H_Discount = DISC1
                H_TotalBayar = D_TotalBayar.Text

                history_tiket.Add({H_JudulFilm, H_Studio, H_hari, H_JamTayang, H_NoKursi, H_Harga, H_JumlahTiket, H_Discount, H_TotalBayar})
                Riwayat.ListView1.Items.Add(New ListViewItem({H_JudulFilm, H_Studio, H_hari, H_JamTayang, H_NoKursi, H_Harga, H_JumlahTiket, H_Discount, H_TotalBayar}))
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Judul_Film.Focus()
        Judul_Film.Text = ""
        Studio.Text = ""
        Hari.Text = ""
        Jam_Tayang.Text = ""
        NO_Kursi_1.Text = ""
        No_Kursi_2.Text = ""
        Harga.Text = ""
        Jumlah_Tiket.Text = ""

        D_JudulFilm.Text = "Judul Film"
        D_Studio.Text = "Studio"
        D_hari.Text = "______"
        D_JumlahTiket.Text = "______"
        D_JamTayang.Text = "______"
        D_NoKursi.Text = "______"
        D_TotalPesan.Text = ""
        D_Discount.Text = ""
        D_TotalBayar.Text = ""

        B_TotalBayar.Text = ""
        B_Pembayaran.Text = ""
        B_Kembalian.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Awal.Show()
    End Sub

    Public H_JudulFilm, H_Studio, H_hari, H_JamTayang, H_NoKursi, H_Harga, H_JumlahTiket, H_Discount, H_TotalBayar As String
    Private history_tiket As New List(Of String())

    Public Function getData() As List(Of String())
        Return history_tiket
    End Function
End Class
