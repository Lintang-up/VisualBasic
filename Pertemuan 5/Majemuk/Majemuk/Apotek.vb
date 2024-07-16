Public Class Apotek

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jumlah.Text = ""
        jumlah.ReadOnly = True
        proses.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles proses.Click
        Dim brg As String
        Dim jml As Integer

        If IsNumeric(jumlah.Text) Then
            brg = beli.Text
            jml = CInt(jumlah.Text)
            If brg = "Paracetamol " And jml > 3 Then
                MessageBox.Show("Anda akan mendapat bonus 1 hand sanitizer")
            ElseIf brg = "Paramex " Then
                MessageBox.Show("Anda akan mendapat diskon 10%")
            Else
                MessageBox.Show("Terima kasih atas kunjungannya")
            End If
        End If

    End Sub

    Private Sub beli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles beli.SelectedIndexChanged
        jumlah.ReadOnly = False
        proses.Enabled = True
        If beli.Text.Trim = "" Then
            jumlah.Text = ""
            jumlah.ReadOnly = True
            proses.Enabled = False
        End If
        jumlah.Focus()

    End Sub
End Class
