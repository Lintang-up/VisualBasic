Public Class login

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub btLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLogin.Click
        Dim username As String = "admin"
        Dim password As String = "admin"

        If tbUsername.Text = username And tbPassword.Text = password Then
            Me.Hide()
            dashboard.Show()

        Else
            MessageBox.Show("Username atau Password Salah!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbUsername.Text = ""
            tbPassword.Text = ""
            tbUsername.Focus()
        End If
    End Sub

    Private Sub chbLihatPassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbLihatPassword.CheckedChanged
        If chbLihatPassword.Checked = True Then
            tbPassword.PasswordChar = ""
        Else
            tbPassword.PasswordChar = "●"
        End If
    End Sub

    Private Sub btExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExit.Click
        End
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class