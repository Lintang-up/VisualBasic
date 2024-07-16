Public Class Pemesanan

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NO_Kursi_1.SelectedIndexChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Harga.ReadOnly = True
    End Sub

    Private Sub Judul_Film_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Judul_Film.SelectedIndexChanged
        If Judul_Film.Text = "Jerapah Makan Sayur" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Spiderman EndGame" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Puss In The Boot The Last Live" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Kungfu Panda 6" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Cars 4" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Mummies" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Ant Man" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub D_JudulFilm_Click(sender As Object, e As EventArgs) Handles D_JudulFilm.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Judul_Film.Text = "" Or Studio.Text = "" Or Hari.Text = "" Or Jumlah_Tiket.Text = "" Or Jam_Tayang.Text = "" Or NO_Kursi_1.Text = "" Or No_Kursi_2.Text = "" Then
            MsgBox("Silahkan Lengkapi Data Dahulu!")
        Else
            D_JudulFilm.Text = Judul_Film.Text
            D_Studio.Text = Studio.Text
            D_hari.Text = Hari.Text
            D_JumlahTiket.Text = Jumlah_Tiket.Text
            D_JamTayang.Text = Jam_Tayang.Text + " WIB"
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
        End If
    End Sub

    Private Sub Hari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Hari.SelectedIndexChanged
        If Judul_Film.Text = "Jerapah Makan Sayur" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Spiderman EndGame" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Puss In The Boot The Last Live" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Kungfu Panda 6" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Cars 4" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Mummies" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Ant Man" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Studio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Studio.SelectedIndexChanged
        If Judul_Film.Text = "Jerapah Makan Sayur" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Spiderman EndGame" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Puss In The Boot The Last Live" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Kungfu Panda 6" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Cars 4" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Mummies" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Ant Man" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Jam_Tayang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Jam_Tayang.SelectedIndexChanged
        If Judul_Film.Text = "Jerapah Makan Sayur" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 25000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 25000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 30000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Spiderman EndGame" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 40000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Puss In The Boot The Last Live" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 33000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 52000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 46000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Kungfu Panda 6" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 37000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 38000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 42000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 48000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 45000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Cars 4" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 36000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 32000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 50000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Mummies" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 27000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 30000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 28000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 35000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 37000
                    End If
                End If
            End If
        End If

        If Judul_Film.Text = "Ant Man" Then
            If Studio.Text = "Studio 1" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
            End If
            If Studio.Text = "Studio 2" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
            End If
            If Studio.Text = "Studio 3" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
            End If
            If Studio.Text = "Studio 4" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
            End If
            If Studio.Text = "Studio 5" Then
                If Hari.Text = "Senin" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Selasa" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Rabu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Kamis" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Jumat" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 40000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 45000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 43000
                    End If
                End If
                If Hari.Text = "Sabtu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
                If Hari.Text = "Minggu" Then
                    If Jam_Tayang.Text = "12.00" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "14.20" Then
                        Harga.Text = 50000
                    ElseIf Jam_Tayang.Text = "16.30" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "19.00" Then
                        Harga.Text = 55000
                    ElseIf Jam_Tayang.Text = "22.00" Then
                        Harga.Text = 53000
                    End If
                End If
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
        D_JudulFilm.Text = ""
        D_Studio.Text = ""
        D_hari.Text = ""
        D_JumlahTiket.Text = ""
        D_JamTayang.Text = ""
        D_NoKursi.Text = ""
        D_TotalPesan.Text = ""
        D_Discount.Text = ""
        D_TotalBayar.Text = ""

    End Sub

    Private Sub Harga_TextChanged(sender As Object, e As EventArgs) Handles Harga.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
