<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tugas_1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ukuran_makanan = New System.Windows.Forms.ComboBox()
        Me.jenis_makanan = New System.Windows.Forms.ComboBox()
        Me.jumlah_beli = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.hitung = New System.Windows.Forms.Button()
        Me.quit = New System.Windows.Forms.Button()
        Me.Nota = New System.Windows.Forms.GroupBox()
        Me.total_bayar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.potongan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.total_harga = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.Nota.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(305, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Warung Sabu"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ukuran_makanan)
        Me.GroupBox1.Controls.Add(Me.jenis_makanan)
        Me.GroupBox1.Controls.Add(Me.jumlah_beli)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.harga)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(51, 90)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(482, 191)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaksi"
        '
        'ukuran_makanan
        '
        Me.ukuran_makanan.FormattingEnabled = True
        Me.ukuran_makanan.Items.AddRange(New Object() {"Kecil", "Biasa", "Besar", "Besar Besar"})
        Me.ukuran_makanan.Location = New System.Drawing.Point(163, 61)
        Me.ukuran_makanan.Name = "ukuran_makanan"
        Me.ukuran_makanan.Size = New System.Drawing.Size(299, 24)
        Me.ukuran_makanan.TabIndex = 7
        '
        'jenis_makanan
        '
        Me.jenis_makanan.FormattingEnabled = True
        Me.jenis_makanan.Items.AddRange(New Object() {"Bubur Ayam", "Bubur Sapi", "Bubur Original", "Bubur Coklat", "Bubur Strawberry"})
        Me.jenis_makanan.Location = New System.Drawing.Point(163, 17)
        Me.jenis_makanan.Name = "jenis_makanan"
        Me.jenis_makanan.Size = New System.Drawing.Size(299, 24)
        Me.jenis_makanan.TabIndex = 6
        '
        'jumlah_beli
        '
        Me.jumlah_beli.Location = New System.Drawing.Point(163, 151)
        Me.jumlah_beli.Name = "jumlah_beli"
        Me.jumlah_beli.Size = New System.Drawing.Size(299, 22)
        Me.jumlah_beli.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ukuran Makanan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Makanan"
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(163, 108)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(299, 22)
        Me.harga.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(48, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(255, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "*potongan Rp 50.000 untuk pembeliaan Rp 500.000"
        '
        'hitung
        '
        Me.hitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hitung.ForeColor = System.Drawing.Color.DimGray
        Me.hitung.Location = New System.Drawing.Point(50, 314)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(119, 34)
        Me.hitung.TabIndex = 3
        Me.hitung.Text = "Hitung"
        Me.hitung.UseVisualStyleBackColor = True
        '
        'quit
        '
        Me.quit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quit.ForeColor = System.Drawing.Color.DimGray
        Me.quit.Location = New System.Drawing.Point(408, 314)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(105, 34)
        Me.quit.TabIndex = 4
        Me.quit.Text = "Quit"
        Me.quit.UseVisualStyleBackColor = True
        '
        'Nota
        '
        Me.Nota.BackColor = System.Drawing.Color.Transparent
        Me.Nota.Controls.Add(Me.total_bayar)
        Me.Nota.Controls.Add(Me.Label9)
        Me.Nota.Controls.Add(Me.potongan)
        Me.Nota.Controls.Add(Me.Label7)
        Me.Nota.Controls.Add(Me.Label8)
        Me.Nota.Controls.Add(Me.total_harga)
        Me.Nota.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Nota.Location = New System.Drawing.Point(51, 379)
        Me.Nota.Name = "Nota"
        Me.Nota.Size = New System.Drawing.Size(482, 136)
        Me.Nota.TabIndex = 5
        Me.Nota.TabStop = False
        Me.Nota.Text = "Nota"
        '
        'total_bayar
        '
        Me.total_bayar.Location = New System.Drawing.Point(164, 108)
        Me.total_bayar.Name = "total_bayar"
        Me.total_bayar.Size = New System.Drawing.Size(299, 22)
        Me.total_bayar.TabIndex = 11
        Me.total_bayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Total Bayar"
        '
        'potongan
        '
        Me.potongan.Location = New System.Drawing.Point(164, 64)
        Me.potongan.Name = "potongan"
        Me.potongan.Size = New System.Drawing.Size(299, 22)
        Me.potongan.TabIndex = 9
        Me.potongan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Potongan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total Harga"
        '
        'total_harga
        '
        Me.total_harga.Location = New System.Drawing.Point(163, 21)
        Me.total_harga.Name = "total_harga"
        Me.total_harga.Size = New System.Drawing.Size(299, 22)
        Me.total_harga.TabIndex = 6
        Me.total_harga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImage = Global.Tugas.My.Resources.Resources.b2
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox4.Location = New System.Drawing.Point(661, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(104, 95)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImage = Global.Tugas.My.Resources.Resources.bubur
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Location = New System.Drawing.Point(572, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(173, 156)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.BackgroundImage = Global.Tugas.My.Resources.Resources.b1
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(104, 95)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'Tugas_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tugas.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(777, 527)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Nota)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.hitung)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Tugas_1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.Nota.ResumeLayout(false)
        Me.Nota.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ukuran_makanan As System.Windows.Forms.ComboBox
    Friend WithEvents jenis_makanan As System.Windows.Forms.ComboBox
    Friend WithEvents jumlah_beli As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents harga As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents hitung As System.Windows.Forms.Button
    Friend WithEvents quit As System.Windows.Forms.Button
    Friend WithEvents Nota As System.Windows.Forms.GroupBox
    Friend WithEvents total_bayar As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents potongan As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents total_harga As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox

End Class
