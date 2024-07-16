<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pembayaran
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
        Me.bt_keluar = New System.Windows.Forms.Button()
        Me.bt_hitung = New System.Windows.Forms.Button()
        Me.kes_messeage = New System.Windows.Forms.Label()
        Me.kes_total = New System.Windows.Forms.Label()
        Me.kesimpulan = New System.Windows.Forms.GroupBox()
        Me.tx_alamat = New System.Windows.Forms.TextBox()
        Me.tx_nopen = New System.Windows.Forms.TextBox()
        Me.tx_nama = New System.Windows.Forms.TextBox()
        Me.in_jk = New System.Windows.Forms.Label()
        Me.in_alamat = New System.Windows.Forms.Label()
        Me.in_nopen = New System.Windows.Forms.Label()
        Me.in_nama = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tx_jk = New System.Windows.Forms.ComboBox()
        Me.tx_harga = New System.Windows.Forms.TextBox()
        Me.tx_jo = New System.Windows.Forms.TextBox()
        Me.in_harga = New System.Windows.Forms.Label()
        Me.in_jo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.kesimpulan.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_keluar
        '
        Me.bt_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_keluar.Location = New System.Drawing.Point(611, 99)
        Me.bt_keluar.Name = "bt_keluar"
        Me.bt_keluar.Size = New System.Drawing.Size(100, 63)
        Me.bt_keluar.TabIndex = 25
        Me.bt_keluar.Text = "Keluar"
        Me.bt_keluar.UseVisualStyleBackColor = True
        '
        'bt_hitung
        '
        Me.bt_hitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_hitung.Location = New System.Drawing.Point(452, 99)
        Me.bt_hitung.Name = "bt_hitung"
        Me.bt_hitung.Size = New System.Drawing.Size(100, 63)
        Me.bt_hitung.TabIndex = 24
        Me.bt_hitung.Text = "Hitung"
        Me.bt_hitung.UseVisualStyleBackColor = True
        '
        'kes_messeage
        '
        Me.kes_messeage.AutoSize = True
        Me.kes_messeage.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.kes_messeage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kes_messeage.Location = New System.Drawing.Point(16, 84)
        Me.kes_messeage.Name = "kes_messeage"
        Me.kes_messeage.Size = New System.Drawing.Size(169, 20)
        Me.kes_messeage.TabIndex = 3
        Me.kes_messeage.Text = "                                        "
        '
        'kes_total
        '
        Me.kes_total.AutoSize = True
        Me.kes_total.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.kes_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kes_total.Location = New System.Drawing.Point(16, 32)
        Me.kes_total.Name = "kes_total"
        Me.kes_total.Size = New System.Drawing.Size(169, 20)
        Me.kes_total.TabIndex = 2
        Me.kes_total.Text = "                                        "
        '
        'kesimpulan
        '
        Me.kesimpulan.Controls.Add(Me.kes_messeage)
        Me.kesimpulan.Controls.Add(Me.kes_total)
        Me.kesimpulan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kesimpulan.Location = New System.Drawing.Point(452, 282)
        Me.kesimpulan.Name = "kesimpulan"
        Me.kesimpulan.Size = New System.Drawing.Size(328, 133)
        Me.kesimpulan.TabIndex = 23
        Me.kesimpulan.TabStop = False
        Me.kesimpulan.Text = "kesimpulan"
        '
        'tx_alamat
        '
        Me.tx_alamat.Location = New System.Drawing.Point(138, 185)
        Me.tx_alamat.Name = "tx_alamat"
        Me.tx_alamat.Size = New System.Drawing.Size(285, 20)
        Me.tx_alamat.TabIndex = 21
        '
        'tx_nopen
        '
        Me.tx_nopen.Location = New System.Drawing.Point(138, 142)
        Me.tx_nopen.Name = "tx_nopen"
        Me.tx_nopen.Size = New System.Drawing.Size(285, 20)
        Me.tx_nopen.TabIndex = 20
        '
        'tx_nama
        '
        Me.tx_nama.Location = New System.Drawing.Point(138, 102)
        Me.tx_nama.Name = "tx_nama"
        Me.tx_nama.Size = New System.Drawing.Size(285, 20)
        Me.tx_nama.TabIndex = 19
        '
        'in_jk
        '
        Me.in_jk.AutoSize = True
        Me.in_jk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.in_jk.Location = New System.Drawing.Point(4, 227)
        Me.in_jk.Name = "in_jk"
        Me.in_jk.Size = New System.Drawing.Size(106, 20)
        Me.in_jk.TabIndex = 18
        Me.in_jk.Text = "Jenis Kelamin"
        '
        'in_alamat
        '
        Me.in_alamat.AutoSize = True
        Me.in_alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.in_alamat.Location = New System.Drawing.Point(4, 185)
        Me.in_alamat.Name = "in_alamat"
        Me.in_alamat.Size = New System.Drawing.Size(59, 20)
        Me.in_alamat.TabIndex = 17
        Me.in_alamat.Text = "Alamat"
        '
        'in_nopen
        '
        Me.in_nopen.AutoSize = True
        Me.in_nopen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.in_nopen.Location = New System.Drawing.Point(4, 142)
        Me.in_nopen.Name = "in_nopen"
        Me.in_nopen.Size = New System.Drawing.Size(121, 20)
        Me.in_nopen.TabIndex = 16
        Me.in_nopen.Text = "No.Pendaftaran"
        '
        'in_nama
        '
        Me.in_nama.AutoSize = True
        Me.in_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.in_nama.Location = New System.Drawing.Point(4, 100)
        Me.in_nama.Name = "in_nama"
        Me.in_nama.Size = New System.Drawing.Size(51, 20)
        Me.in_nama.TabIndex = 15
        Me.in_nama.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 26)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Form Data Pasien"
        '
        'tx_jk
        '
        Me.tx_jk.FormattingEnabled = True
        Me.tx_jk.Location = New System.Drawing.Point(138, 226)
        Me.tx_jk.Name = "tx_jk"
        Me.tx_jk.Size = New System.Drawing.Size(285, 21)
        Me.tx_jk.TabIndex = 6
        '
        'tx_harga
        '
        Me.tx_harga.Location = New System.Drawing.Point(138, 313)
        Me.tx_harga.Name = "tx_harga"
        Me.tx_harga.Size = New System.Drawing.Size(285, 20)
        Me.tx_harga.TabIndex = 29
        '
        'tx_jo
        '
        Me.tx_jo.Location = New System.Drawing.Point(138, 270)
        Me.tx_jo.Name = "tx_jo"
        Me.tx_jo.Size = New System.Drawing.Size(285, 20)
        Me.tx_jo.TabIndex = 28
        '
        'in_harga
        '
        Me.in_harga.AutoSize = True
        Me.in_harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.in_harga.Location = New System.Drawing.Point(4, 313)
        Me.in_harga.Name = "in_harga"
        Me.in_harga.Size = New System.Drawing.Size(53, 20)
        Me.in_harga.TabIndex = 27
        Me.in_harga.Text = "Harga"
        '
        'in_jo
        '
        Me.in_jo.AutoSize = True
        Me.in_jo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.in_jo.Location = New System.Drawing.Point(4, 270)
        Me.in_jo.Name = "in_jo"
        Me.in_jo.Size = New System.Drawing.Size(99, 20)
        Me.in_jo.TabIndex = 26
        Me.in_jo.Text = "Jumlah Obat"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(452, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 63)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Ualngi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tx_harga)
        Me.Controls.Add(Me.tx_jo)
        Me.Controls.Add(Me.in_harga)
        Me.Controls.Add(Me.in_jo)
        Me.Controls.Add(Me.tx_jk)
        Me.Controls.Add(Me.bt_keluar)
        Me.Controls.Add(Me.bt_hitung)
        Me.Controls.Add(Me.kesimpulan)
        Me.Controls.Add(Me.tx_alamat)
        Me.Controls.Add(Me.tx_nopen)
        Me.Controls.Add(Me.tx_nama)
        Me.Controls.Add(Me.in_jk)
        Me.Controls.Add(Me.in_alamat)
        Me.Controls.Add(Me.in_nopen)
        Me.Controls.Add(Me.in_nama)
        Me.Controls.Add(Me.Label1)
        Me.Name = "pembayaran"
        Me.Text = "pembayaran"
        Me.kesimpulan.ResumeLayout(False)
        Me.kesimpulan.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_keluar As Button
    Friend WithEvents bt_hitung As Button
    Friend WithEvents kes_messeage As Label
    Friend WithEvents kes_total As Label
    Friend WithEvents kesimpulan As GroupBox
    Friend WithEvents tx_alamat As TextBox
    Friend WithEvents tx_nopen As TextBox
    Friend WithEvents tx_nama As TextBox
    Friend WithEvents in_jk As Label
    Friend WithEvents in_alamat As Label
    Friend WithEvents in_nopen As Label
    Friend WithEvents in_nama As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tx_jk As ComboBox
    Friend WithEvents tx_harga As TextBox
    Friend WithEvents tx_jo As TextBox
    Friend WithEvents in_harga As Label
    Friend WithEvents in_jo As Label
    Friend WithEvents Button1 As Button
End Class
