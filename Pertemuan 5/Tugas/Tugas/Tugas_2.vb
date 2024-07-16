Public Class Tugas_2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim N1 As Integer
        Dim N2 As Integer
        Dim N3 As Integer
        N1 = CInt(Tugas_Absen.Text)
        N2 = CInt(UTS.Text)
        N3 = CInt(UAS.Text)

        Dim N_1 As Integer
        Dim N_2 As Integer
        Dim N_3 As Integer
        N_1 = (N1 * 0.3)
        N_2 = (N2 * 0.3)
        N_3 = (N3 * 0.4)

        Dim NA As Integer
        NA = (N_1 + N_2 + N_3 - 3)
        Nilai_Akhir.Text = NA

        If CStr(NA) >= "90" Then
            Grade.Text = "A"
        ElseIf CStr(NA) >= "80" Then
            Grade.Text = "B"
        ElseIf CStr(NA) >= "70" Then
            Grade.Text = "C"
        ElseIf CStr(NA) >= "60" Then
            Grade.Text = "D"
        ElseIf CStr(NA) < "59" Then
            Grade.Text = "E"
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Nama.Text = " "
        NIM.Text = " "
        Tugas_Absen.Text = " "
        UTS.Text = " "
        UAS.Text = " "
        Nama.Focus()

        Nilai_Akhir.Text = " "
        Grade.Text = " "
    End Sub

    Private Sub Tugas_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nilai_Akhir.ReadOnly = True
        Nilai_Akhir.Enabled = False
        Grade.ReadOnly = True
        Grade.Enabled = False
    End Sub
End Class