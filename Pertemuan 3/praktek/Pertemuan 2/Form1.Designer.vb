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
        Me.tx_nama = New System.Windows.Forms.TextBox()
        Me.tx_no = New System.Windows.Forms.TextBox()
        Me.tx_alamat = New System.Windows.Forms.TextBox()
        Me.tx_jk = New System.Windows.Forms.TextBox()
        Me.kesimpulan = New System.Windows.Forms.GroupBox()
        Me.nama = New System.Windows.Forms.Label()
        Me.daftar = New System.Windows.Forms.Label()
        Me.alamat = New System.Windows.Forms.Label()
        Me.jk = New System.Windows.Forms.Label()
        Me.bt_apply = New System.Windows.Forms.Button()
        Me.bt_keluar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.kesimpulan.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Data Pasien"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No.Pendaftaran"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jenis Kelamin"
        '
        'tx_nama
        '
        Me.tx_nama.Location = New System.Drawing.Point(146, 68)
        Me.tx_nama.Name = "tx_nama"
        Me.tx_nama.Size = New System.Drawing.Size(285, 20)
        Me.tx_nama.TabIndex = 5
        '
        'tx_no
        '
        Me.tx_no.Location = New System.Drawing.Point(146, 108)
        Me.tx_no.Name = "tx_no"
        Me.tx_no.Size = New System.Drawing.Size(285, 20)
        Me.tx_no.TabIndex = 6
        '
        'tx_alamat
        '
        Me.tx_alamat.Location = New System.Drawing.Point(146, 151)
        Me.tx_alamat.Name = "tx_alamat"
        Me.tx_alamat.Size = New System.Drawing.Size(285, 20)
        Me.tx_alamat.TabIndex = 7
        '
        'tx_jk
        '
        Me.tx_jk.Location = New System.Drawing.Point(146, 193)
        Me.tx_jk.Name = "tx_jk"
        Me.tx_jk.Size = New System.Drawing.Size(285, 20)
        Me.tx_jk.TabIndex = 8
        '
        'kesimpulan
        '
        Me.kesimpulan.Controls.Add(Me.jk)
        Me.kesimpulan.Controls.Add(Me.alamat)
        Me.kesimpulan.Controls.Add(Me.daftar)
        Me.kesimpulan.Controls.Add(Me.nama)
        Me.kesimpulan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kesimpulan.Location = New System.Drawing.Point(16, 240)
        Me.kesimpulan.Name = "kesimpulan"
        Me.kesimpulan.Size = New System.Drawing.Size(415, 133)
        Me.kesimpulan.TabIndex = 9
        Me.kesimpulan.TabStop = False
        Me.kesimpulan.Text = "kesimpulan"
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(16, 32)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(169, 20)
        Me.nama.TabIndex = 2
        Me.nama.Text = "                                        "
        '
        'daftar
        '
        Me.daftar.AutoSize = True
        Me.daftar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.daftar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.daftar.Location = New System.Drawing.Point(16, 84)
        Me.daftar.Name = "daftar"
        Me.daftar.Size = New System.Drawing.Size(169, 20)
        Me.daftar.TabIndex = 3
        Me.daftar.Text = "                                        "
        '
        'alamat
        '
        Me.alamat.AutoSize = True
        Me.alamat.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alamat.Location = New System.Drawing.Point(222, 32)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(169, 20)
        Me.alamat.TabIndex = 4
        Me.alamat.Text = "                                        "
        '
        'jk
        '
        Me.jk.AutoSize = True
        Me.jk.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.jk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jk.Location = New System.Drawing.Point(222, 84)
        Me.jk.Name = "jk"
        Me.jk.Size = New System.Drawing.Size(169, 20)
        Me.jk.TabIndex = 5
        Me.jk.Text = "                                        "
        '
        'bt_apply
        '
        Me.bt_apply.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_apply.Location = New System.Drawing.Point(476, 65)
        Me.bt_apply.Name = "bt_apply"
        Me.bt_apply.Size = New System.Drawing.Size(100, 63)
        Me.bt_apply.TabIndex = 10
        Me.bt_apply.Text = "Apply"
        Me.bt_apply.UseVisualStyleBackColor = True
        '
        'bt_keluar
        '
        Me.bt_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_keluar.Location = New System.Drawing.Point(476, 151)
        Me.bt_keluar.Name = "bt_keluar"
        Me.bt_keluar.Size = New System.Drawing.Size(100, 63)
        Me.bt_keluar.TabIndex = 11
        Me.bt_keluar.Text = "Keluar"
        Me.bt_keluar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(604, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 82)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Warna"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(17, 23)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(54, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "merah"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(17, 46)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Kuning"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(107, 23)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "hijau"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(107, 46)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(42, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "biru"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(604, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 146)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Font Style"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(23, 27)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(53, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Tebal"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(23, 60)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(54, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Miring"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(23, 94)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(86, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Garis Bawah"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(837, 385)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bt_keluar)
        Me.Controls.Add(Me.bt_apply)
        Me.Controls.Add(Me.kesimpulan)
        Me.Controls.Add(Me.tx_jk)
        Me.Controls.Add(Me.tx_alamat)
        Me.Controls.Add(Me.tx_no)
        Me.Controls.Add(Me.tx_nama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Data Pasien"
        Me.kesimpulan.ResumeLayout(False)
        Me.kesimpulan.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tx_nama As System.Windows.Forms.TextBox
    Friend WithEvents tx_no As System.Windows.Forms.TextBox
    Friend WithEvents tx_alamat As System.Windows.Forms.TextBox
    Friend WithEvents tx_jk As System.Windows.Forms.TextBox
    Friend WithEvents kesimpulan As System.Windows.Forms.GroupBox
    Friend WithEvents jk As System.Windows.Forms.Label
    Friend WithEvents alamat As System.Windows.Forms.Label
    Friend WithEvents daftar As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.Label
    Friend WithEvents bt_apply As System.Windows.Forms.Button
    Friend WithEvents bt_keluar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox

End Class
