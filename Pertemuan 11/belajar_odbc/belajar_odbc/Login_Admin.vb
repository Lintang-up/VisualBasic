Public Class Login_Admin

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If username.Text = "admin" And password.Text = "1234" Then
            Form_Home.Show()
            Me.Hide()
        Else
            MsgBox("Silahkan Masukkan Username dan Password yang benar!!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Login_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Select()
    End Sub
End Class