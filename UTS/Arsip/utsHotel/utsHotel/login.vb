Public Class login

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        'Dim name As String = "Admin"
        Dim username As String = "admin"
        Dim password As String = "admin"

        If tbUsername.Text = username And tbPassword.Text = password Then
            Me.Hide()
            tampilanAwal.Show()
        Else
            MessageBox.Show("Username atau Password Salah!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbUsername.Text = ""
            tbPassword.Text = ""
            tbUsername.Focus()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub tbUsername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbPassword.Focus()
        End If
    End Sub

    Private Sub tbPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class