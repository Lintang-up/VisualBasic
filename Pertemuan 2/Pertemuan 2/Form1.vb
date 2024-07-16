Public Class Form1

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub bt_apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_apply.Click
        nama.Text = tx_nama.Text
        daftar.Text = tx_no.Text
        alamat.Text = tx_alamat.Text
        jk.Text = tx_jk.Text

    End Sub

    Private Sub bt_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_keluar.Click
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        nama.ForeColor = Color.Red
        daftar.ForeColor = Color.Red
        alamat.ForeColor = Color.Red
        jk.ForeColor = Color.Red
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        nama.ForeColor = Color.Green
        daftar.ForeColor = Color.Green
        alamat.ForeColor = Color.Green
        jk.ForeColor = Color.Green
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        nama.ForeColor = Color.Yellow
        daftar.ForeColor = Color.Yellow
        alamat.ForeColor = Color.Yellow
        jk.ForeColor = Color.Yellow
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        nama.ForeColor = Color.Blue
        daftar.ForeColor = Color.Blue
        alamat.ForeColor = Color.Blue
        jk.ForeColor = Color.Blue

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        nama.Font = New Font("microsoft sans serif", nama.Font.Size, nama.Font.Style Xor FontStyle.Bold)
        daftar.Font = New Font("microsoft sans serif", daftar.Font.Size, daftar.Font.Style Xor FontStyle.Bold)
        alamat.Font = New Font("microsoft sans serif", alamat.Font.Size, alamat.Font.Style Xor FontStyle.Bold)
        jk.Font = New Font("microsoft sans serif", jk.Font.Size, jk.Font.Style Xor FontStyle.Bold)
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        nama.Font = New Font("microsoft sans serif", nama.Font.Size, nama.Font.Style Xor FontStyle.Italic)
        daftar.Font = New Font("microsoft sans serif", daftar.Font.Size, daftar.Font.Style Xor FontStyle.Italic)
        alamat.Font = New Font("microsoft sans serif", alamat.Font.Size, alamat.Font.Style Xor FontStyle.Italic)
        jk.Font = New Font("microsoft sans serif", jk.Font.Size, jk.Font.Style Xor FontStyle.Italic)
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        nama.Font = New Font("microsoft sans serif", nama.Font.Size, nama.Font.Style Xor FontStyle.Underline)
        daftar.Font = New Font("microsoft sans serif", daftar.Font.Size, daftar.Font.Style Xor FontStyle.Underline)
        alamat.Font = New Font("microsoft sans serif", alamat.Font.Size, alamat.Font.Style Xor FontStyle.Underline)
        jk.Font = New Font("microsoft sans serif", jk.Font.Size, jk.Font.Style Xor FontStyle.Underline)
    End Sub
End Class
