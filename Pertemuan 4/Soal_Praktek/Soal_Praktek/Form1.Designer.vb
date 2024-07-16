<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.nilai_p = New System.Windows.Forms.TextBox()
        Me.nilai_k = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.rata_rata = New System.Windows.Forms.Label()
        Me.keterangan = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(101, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Penentuan Kelulusan Matakuliah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(28, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Mahasiswa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(28, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nilai Praktek"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(28, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nilai Kuis"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(28, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nilai rata-rata"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(28, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Keterangan"
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(180, 89)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(235, 20)
        Me.nama.TabIndex = 6
        '
        'nilai_p
        '
        Me.nilai_p.Location = New System.Drawing.Point(180, 127)
        Me.nilai_p.Name = "nilai_p"
        Me.nilai_p.Size = New System.Drawing.Size(235, 20)
        Me.nilai_p.TabIndex = 7
        '
        'nilai_k
        '
        Me.nilai_k.Location = New System.Drawing.Point(180, 166)
        Me.nilai_k.Name = "nilai_k"
        Me.nilai_k.Size = New System.Drawing.Size(235, 20)
        Me.nilai_k.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(22, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 48)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Proses"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(141, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 48)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Ulangi"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(327, 284)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 48)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'rata_rata
        '
        Me.rata_rata.AutoSize = True
        Me.rata_rata.BackColor = System.Drawing.Color.White
        Me.rata_rata.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rata_rata.Location = New System.Drawing.Point(181, 210)
        Me.rata_rata.Name = "rata_rata"
        Me.rata_rata.Size = New System.Drawing.Size(232, 17)
        Me.rata_rata.TabIndex = 14
        Me.rata_rata.Text = "                                                        "
        '
        'keterangan
        '
        Me.keterangan.AutoSize = True
        Me.keterangan.BackColor = System.Drawing.Color.White
        Me.keterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keterangan.Location = New System.Drawing.Point(181, 246)
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Size = New System.Drawing.Size(232, 17)
        Me.keterangan.TabIndex = 15
        Me.keterangan.Text = "                                                        "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Soal_Praktek.My.Resources.Resources.back
        Me.ClientSize = New System.Drawing.Size(440, 363)
        Me.Controls.Add(Me.keterangan)
        Me.Controls.Add(Me.rata_rata)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nilai_k)
        Me.Controls.Add(Me.nilai_p)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Aplikasi Kelulusan Matakuliah"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents nilai_p As System.Windows.Forms.TextBox
    Friend WithEvents nilai_k As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents rata_rata As System.Windows.Forms.Label
    Friend WithEvents keterangan As System.Windows.Forms.Label

End Class
