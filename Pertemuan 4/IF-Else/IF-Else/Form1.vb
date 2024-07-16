Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nama.Text = " "
        nim.Text = " "
        nilai.Text = " "
        nama.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CInt(nilai.Text) >= 65 Then
            MessageBox.Show("Selamat Anda dinyatakan LULUS", "HASIL TOEFL",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Anda dinyatakan TIDAKL LULUS", "HASIL TOEFL",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
