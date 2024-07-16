Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nama.Text = " "
        nilai_p.Text = " "
        nilai_k.Text = " "
        rata_rata.Text = "                                                        "
        keterangan.Text = "                                                        "
        nama.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nilaip As Integer
        Dim nilaik As String
        Dim nilair As String
        nilaip = CInt(nilai_p.Text)
        nilaik = CSng(nilai_k.Text)
        nilair = ((nilaik + nilaip) / 2)

        rata_rata.Text = " " & nilair

        If CInt(rata_rata.Text) >= 65 Then
            keterangan.Text = "LULUS                                                "
        Else
            keterangan.Text = "Tidak LULUS                                    "
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles rata_rata.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
