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
        Me.tx_namapenyewa = New System.Windows.Forms.TextBox()
        Me.in_namapenyewa = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tx_notlp = New System.Windows.Forms.TextBox()
        Me.in_notelp = New System.Windows.Forms.Label()
        Me.tx_alamat = New System.Windows.Forms.TextBox()
        Me.in_alamat = New System.Windows.Forms.Label()
        Me.tx_namamobil = New System.Windows.Forms.TextBox()
        Me.in_namamobil = New System.Windows.Forms.Label()
        Me.tx_hargasewa = New System.Windows.Forms.TextBox()
        Me.in_hargasewa = New System.Windows.Forms.Label()
        Me.tx_jumlahhari = New System.Windows.Forms.TextBox()
        Me.in_jumlahhari = New System.Windows.Forms.Label()
        Me.in_totalharga = New System.Windows.Forms.Label()
        Me.kesimpulan = New System.Windows.Forms.GroupBox()
        Me.kes_namamobil = New System.Windows.Forms.Label()
        Me.kes_alamat = New System.Windows.Forms.Label()
        Me.kes_notelp = New System.Windows.Forms.Label()
        Me.kes_namapenyewa = New System.Windows.Forms.Label()
        Me.kes_totalbayar = New System.Windows.Forms.Label()
        Me.kes_jumlahhari = New System.Windows.Forms.Label()
        Me.kes_hargasewa = New System.Windows.Forms.Label()
        Me.bt_keluar = New System.Windows.Forms.Button()
        Me.bt_hitung = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tx_totalbayar = New System.Windows.Forms.TextBox()
        Me.kesimpulan.SuspendLayout()
        Me.SuspendLayout()
        '
        'tx_namapenyewa
        '
        Me.tx_namapenyewa.Location = New System.Drawing.Point(165, 101)
        Me.tx_namapenyewa.Name = "tx_namapenyewa"
        Me.tx_namapenyewa.Size = New System.Drawing.Size(285, 20)
        Me.tx_namapenyewa.TabIndex = 22
        '
        'in_namapenyewa
        '
        Me.in_namapenyewa.AutoSize = True
        Me.in_namapenyewa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.in_namapenyewa.Location = New System.Drawing.Point(31, 99)
        Me.in_namapenyewa.Name = "in_namapenyewa"
        Me.in_namapenyewa.Size = New System.Drawing.Size(119, 20)
        Me.in_namapenyewa.TabIndex = 21
        Me.in_namapenyewa.Text = "Nama Penyewa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 26)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Sewa mobil Sri Rejeki"
        '
        'tx_notlp
        '
        Me.tx_notlp.Location = New System.Drawing.Point(165, 144)
        Me.tx_notlp.Name = "tx_notlp"
        Me.tx_notlp.Size = New System.Drawing.Size(285, 20)
        Me.tx_notlp.TabIndex = 24
        '
        'in_notelp
        '
        Me.in_notelp.AutoSize = True
        Me.in_notelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.in_notelp.Location = New System.Drawing.Point(31, 142)
        Me.in_notelp.Name = "in_notelp"
        Me.in_notelp.Size = New System.Drawing.Size(63, 20)
        Me.in_notelp.TabIndex = 23
        Me.in_notelp.Text = "No Telp"
        '
        'tx_alamat
        '
        Me.tx_alamat.Location = New System.Drawing.Point(165, 185)
        Me.tx_alamat.Name = "tx_alamat"
        Me.tx_alamat.Size = New System.Drawing.Size(285, 20)
        Me.tx_alamat.TabIndex = 26
        '
        'in_alamat
        '
        Me.in_alamat.AutoSize = True
        Me.in_alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.in_alamat.Location = New System.Drawing.Point(31, 183)
        Me.in_alamat.Name = "in_alamat"
        Me.in_alamat.Size = New System.Drawing.Size(59, 20)
        Me.in_alamat.TabIndex = 25
        Me.in_alamat.Text = "Alamat"
        '
        'tx_namamobil
        '
        Me.tx_namamobil.Location = New System.Drawing.Point(165, 230)
        Me.tx_namamobil.Name = "tx_namamobil"
        Me.tx_namamobil.Size = New System.Drawing.Size(285, 20)
        Me.tx_namamobil.TabIndex = 28
        '
        'in_namamobil
        '
        Me.in_namamobil.AutoSize = True
        Me.in_namamobil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.in_namamobil.Location = New System.Drawing.Point(31, 228)
        Me.in_namamobil.Name = "in_namamobil"
        Me.in_namamobil.Size = New System.Drawing.Size(92, 20)
        Me.in_namamobil.TabIndex = 27
        Me.in_namamobil.Text = "Nama Mobil"
        '
        'tx_hargasewa
        '
        Me.tx_hargasewa.Location = New System.Drawing.Point(165, 274)
        Me.tx_hargasewa.Name = "tx_hargasewa"
        Me.tx_hargasewa.Size = New System.Drawing.Size(285, 20)
        Me.tx_hargasewa.TabIndex = 30
        '
        'in_hargasewa
        '
        Me.in_hargasewa.AutoSize = True
        Me.in_hargasewa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.in_hargasewa.Location = New System.Drawing.Point(31, 272)
        Me.in_hargasewa.Name = "in_hargasewa"
        Me.in_hargasewa.Size = New System.Drawing.Size(97, 20)
        Me.in_hargasewa.TabIndex = 29
        Me.in_hargasewa.Text = "Harga Sewa"
        '
        'tx_jumlahhari
        '
        Me.tx_jumlahhari.Location = New System.Drawing.Point(165, 322)
        Me.tx_jumlahhari.Name = "tx_jumlahhari"
        Me.tx_jumlahhari.Size = New System.Drawing.Size(285, 20)
        Me.tx_jumlahhari.TabIndex = 32
        '
        'in_jumlahhari
        '
        Me.in_jumlahhari.AutoSize = True
        Me.in_jumlahhari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.in_jumlahhari.Location = New System.Drawing.Point(31, 320)
        Me.in_jumlahhari.Name = "in_jumlahhari"
        Me.in_jumlahhari.Size = New System.Drawing.Size(93, 20)
        Me.in_jumlahhari.TabIndex = 31
        Me.in_jumlahhari.Text = "Jumlah Hari"
        '
        'in_totalharga
        '
        Me.in_totalharga.AutoSize = True
        Me.in_totalharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.in_totalharga.Location = New System.Drawing.Point(31, 365)
        Me.in_totalharga.Name = "in_totalharga"
        Me.in_totalharga.Size = New System.Drawing.Size(89, 20)
        Me.in_totalharga.TabIndex = 33
        Me.in_totalharga.Text = "Total Bayar"
        '
        'kesimpulan
        '
        Me.kesimpulan.Controls.Add(Me.kes_alamat)
        Me.kesimpulan.Controls.Add(Me.kes_notelp)
        Me.kesimpulan.Controls.Add(Me.kes_namapenyewa)
        Me.kesimpulan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kesimpulan.Location = New System.Drawing.Point(467, 99)
        Me.kesimpulan.Name = "kesimpulan"
        Me.kesimpulan.Size = New System.Drawing.Size(415, 133)
        Me.kesimpulan.TabIndex = 35
        Me.kesimpulan.TabStop = False
        Me.kesimpulan.Text = "kesimpulan"
        '
        'kes_namamobil
        '
        Me.kes_namamobil.AutoSize = True
        Me.kes_namamobil.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.kes_namamobil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kes_namamobil.Location = New System.Drawing.Point(483, 251)
        Me.kes_namamobil.Name = "kes_namamobil"
        Me.kes_namamobil.Size = New System.Drawing.Size(169, 20)
        Me.kes_namamobil.TabIndex = 5
        Me.kes_namamobil.Text = "                                        "
        '
        'kes_alamat
        '
        Me.kes_alamat.AutoSize = True
        Me.kes_alamat.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.kes_alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kes_alamat.Location = New System.Drawing.Point(16, 113)
        Me.kes_alamat.Name = "kes_alamat"
        Me.kes_alamat.Size = New System.Drawing.Size(169, 20)
        Me.kes_alamat.TabIndex = 4
        Me.kes_alamat.Text = "                                        "
        '
        'kes_notelp
        '
        Me.kes_notelp.AutoSize = True
        Me.kes_notelp.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.kes_notelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kes_notelp.Location = New System.Drawing.Point(16, 70)
        Me.kes_notelp.Name = "kes_notelp"
        Me.kes_notelp.Size = New System.Drawing.Size(169, 20)
        Me.kes_notelp.TabIndex = 3
        Me.kes_notelp.Text = "                                        "
        '
        'kes_namapenyewa
        '
        Me.kes_namapenyewa.AutoSize = True
        Me.kes_namapenyewa.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.kes_namapenyewa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kes_namapenyewa.Location = New System.Drawing.Point(16, 32)
        Me.kes_namapenyewa.Name = "kes_namapenyewa"
        Me.kes_namapenyewa.Size = New System.Drawing.Size(169, 20)
        Me.kes_namapenyewa.TabIndex = 2
        Me.kes_namapenyewa.Text = "                                        "
        '
        'kes_totalbayar
        '
        Me.kes_totalbayar.AutoSize = True
        Me.kes_totalbayar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.kes_totalbayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kes_totalbayar.Location = New System.Drawing.Point(483, 380)
        Me.kes_totalbayar.Name = "kes_totalbayar"
        Me.kes_totalbayar.Size = New System.Drawing.Size(169, 20)
        Me.kes_totalbayar.TabIndex = 37
        Me.kes_totalbayar.Text = "                                        "
        '
        'kes_jumlahhari
        '
        Me.kes_jumlahhari.AutoSize = True
        Me.kes_jumlahhari.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.kes_jumlahhari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kes_jumlahhari.Location = New System.Drawing.Point(483, 339)
        Me.kes_jumlahhari.Name = "kes_jumlahhari"
        Me.kes_jumlahhari.Size = New System.Drawing.Size(169, 20)
        Me.kes_jumlahhari.TabIndex = 36
        Me.kes_jumlahhari.Text = "                                        "
        '
        'kes_hargasewa
        '
        Me.kes_hargasewa.AutoSize = True
        Me.kes_hargasewa.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.kes_hargasewa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kes_hargasewa.Location = New System.Drawing.Point(483, 295)
        Me.kes_hargasewa.Name = "kes_hargasewa"
        Me.kes_hargasewa.Size = New System.Drawing.Size(169, 20)
        Me.kes_hargasewa.TabIndex = 38
        Me.kes_hargasewa.Text = "                                        "
        '
        'bt_keluar
        '
        Me.bt_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_keluar.Location = New System.Drawing.Point(615, 18)
        Me.bt_keluar.Name = "bt_keluar"
        Me.bt_keluar.Size = New System.Drawing.Size(100, 26)
        Me.bt_keluar.TabIndex = 40
        Me.bt_keluar.Text = "Hasil"
        Me.bt_keluar.UseVisualStyleBackColor = True
        '
        'bt_hitung
        '
        Me.bt_hitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_hitung.Location = New System.Drawing.Point(456, 18)
        Me.bt_hitung.Name = "bt_hitung"
        Me.bt_hitung.Size = New System.Drawing.Size(100, 26)
        Me.bt_hitung.TabIndex = 39
        Me.bt_hitung.Text = "Hitung"
        Me.bt_hitung.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(615, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 26)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(456, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 26)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Ulangi"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tx_totalbayar
        '
        Me.tx_totalbayar.Location = New System.Drawing.Point(165, 367)
        Me.tx_totalbayar.Name = "tx_totalbayar"
        Me.tx_totalbayar.Size = New System.Drawing.Size(285, 20)
        Me.tx_totalbayar.TabIndex = 34
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bt_keluar)
        Me.Controls.Add(Me.bt_hitung)
        Me.Controls.Add(Me.kes_totalbayar)
        Me.Controls.Add(Me.kes_jumlahhari)
        Me.Controls.Add(Me.kes_hargasewa)
        Me.Controls.Add(Me.kes_namamobil)
        Me.Controls.Add(Me.kesimpulan)
        Me.Controls.Add(Me.tx_totalbayar)
        Me.Controls.Add(Me.in_totalharga)
        Me.Controls.Add(Me.tx_jumlahhari)
        Me.Controls.Add(Me.in_jumlahhari)
        Me.Controls.Add(Me.tx_hargasewa)
        Me.Controls.Add(Me.in_hargasewa)
        Me.Controls.Add(Me.tx_namamobil)
        Me.Controls.Add(Me.in_namamobil)
        Me.Controls.Add(Me.tx_alamat)
        Me.Controls.Add(Me.in_alamat)
        Me.Controls.Add(Me.tx_notlp)
        Me.Controls.Add(Me.in_notelp)
        Me.Controls.Add(Me.tx_namapenyewa)
        Me.Controls.Add(Me.in_namapenyewa)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.kesimpulan.ResumeLayout(False)
        Me.kesimpulan.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tx_namapenyewa As TextBox
    Friend WithEvents in_namapenyewa As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tx_notlp As TextBox
    Friend WithEvents in_notelp As Label
    Friend WithEvents tx_alamat As TextBox
    Friend WithEvents in_alamat As Label
    Friend WithEvents tx_namamobil As TextBox
    Friend WithEvents in_namamobil As Label
    Friend WithEvents tx_hargasewa As TextBox
    Friend WithEvents in_hargasewa As Label
    Friend WithEvents tx_jumlahhari As TextBox
    Friend WithEvents in_jumlahhari As Label
    Friend WithEvents in_totalharga As Label
    Friend WithEvents kesimpulan As GroupBox
    Friend WithEvents kes_alamat As Label
    Friend WithEvents kes_notelp As Label
    Friend WithEvents kes_namapenyewa As Label
    Friend WithEvents kes_namamobil As Label
    Friend WithEvents kes_totalbayar As Label
    Friend WithEvents kes_jumlahhari As Label
    Friend WithEvents kes_hargasewa As Label
    Friend WithEvents bt_keluar As Button
    Friend WithEvents bt_hitung As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents tx_totalbayar As TextBox
End Class
