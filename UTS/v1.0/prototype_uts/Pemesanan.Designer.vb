<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pemesanan
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Jam_Tayang = New System.Windows.Forms.ComboBox()
        Me.Hari = New System.Windows.Forms.ComboBox()
        Me.Jumlah_Tiket = New System.Windows.Forms.TextBox()
        Me.Harga = New System.Windows.Forms.TextBox()
        Me.No_Kursi_2 = New System.Windows.Forms.ComboBox()
        Me.NO_Kursi_1 = New System.Windows.Forms.ComboBox()
        Me.Judul_Film = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.D_NoKursi = New System.Windows.Forms.Label()
        Me.D_JamTayang = New System.Windows.Forms.Label()
        Me.D_JumlahTiket = New System.Windows.Forms.Label()
        Me.D_hari = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.D_Studio = New System.Windows.Forms.Label()
        Me.D_TotalPesan = New System.Windows.Forms.TextBox()
        Me.D_TotalBayar = New System.Windows.Forms.TextBox()
        Me.D_Discount = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.D_JudulFilm = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Studio = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(282, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(461, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pemesanan Tiket Bioskop"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Judul Film"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Studio)
        Me.GroupBox1.Controls.Add(Me.Jam_Tayang)
        Me.GroupBox1.Controls.Add(Me.Hari)
        Me.GroupBox1.Controls.Add(Me.Jumlah_Tiket)
        Me.GroupBox1.Controls.Add(Me.Harga)
        Me.GroupBox1.Controls.Add(Me.No_Kursi_2)
        Me.GroupBox1.Controls.Add(Me.NO_Kursi_1)
        Me.GroupBox1.Controls.Add(Me.Judul_Film)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 366)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pemesanan"
        '
        'Jam_Tayang
        '
        Me.Jam_Tayang.FormattingEnabled = True
        Me.Jam_Tayang.Items.AddRange(New Object() {"12.00", "14.20", "16.30", "19.00", "22.00"})
        Me.Jam_Tayang.Location = New System.Drawing.Point(134, 160)
        Me.Jam_Tayang.Name = "Jam_Tayang"
        Me.Jam_Tayang.Size = New System.Drawing.Size(194, 24)
        Me.Jam_Tayang.TabIndex = 18
        '
        'Hari
        '
        Me.Hari.FormattingEnabled = True
        Me.Hari.Items.AddRange(New Object() {"Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu"})
        Me.Hari.Location = New System.Drawing.Point(134, 119)
        Me.Hari.Name = "Hari"
        Me.Hari.Size = New System.Drawing.Size(194, 24)
        Me.Hari.TabIndex = 18
        '
        'Jumlah_Tiket
        '
        Me.Jumlah_Tiket.Location = New System.Drawing.Point(134, 278)
        Me.Jumlah_Tiket.Name = "Jumlah_Tiket"
        Me.Jumlah_Tiket.Size = New System.Drawing.Size(194, 22)
        Me.Jumlah_Tiket.TabIndex = 17
        '
        'Harga
        '
        Me.Harga.Location = New System.Drawing.Point(134, 238)
        Me.Harga.Name = "Harga"
        Me.Harga.Size = New System.Drawing.Size(194, 22)
        Me.Harga.TabIndex = 15
        '
        'No_Kursi_2
        '
        Me.No_Kursi_2.FormattingEnabled = True
        Me.No_Kursi_2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.No_Kursi_2.Location = New System.Drawing.Point(254, 200)
        Me.No_Kursi_2.Name = "No_Kursi_2"
        Me.No_Kursi_2.Size = New System.Drawing.Size(74, 24)
        Me.No_Kursi_2.TabIndex = 14
        '
        'NO_Kursi_1
        '
        Me.NO_Kursi_1.FormattingEnabled = True
        Me.NO_Kursi_1.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.NO_Kursi_1.Location = New System.Drawing.Point(134, 200)
        Me.NO_Kursi_1.Name = "NO_Kursi_1"
        Me.NO_Kursi_1.Size = New System.Drawing.Size(78, 24)
        Me.NO_Kursi_1.TabIndex = 13
        '
        'Judul_Film
        '
        Me.Judul_Film.FormattingEnabled = True
        Me.Judul_Film.Items.AddRange(New Object() {"Jerapah Makan Sayur", "Spiderman EndGame", "Puss In The Boot The Last Live", "Kungfu Panda 6", "Cars 4", "Mummies", "Ant Man"})
        Me.Judul_Film.Location = New System.Drawing.Point(134, 35)
        Me.Judul_Film.Name = "Judul_Film"
        Me.Judul_Film.Size = New System.Drawing.Size(194, 24)
        Me.Judul_Film.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Jumlah Tiket"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Harga"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 17)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "No. Kursi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hari"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Jam Tayang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Studio"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.D_NoKursi)
        Me.GroupBox2.Controls.Add(Me.D_JamTayang)
        Me.GroupBox2.Controls.Add(Me.D_JumlahTiket)
        Me.GroupBox2.Controls.Add(Me.D_hari)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.D_Studio)
        Me.GroupBox2.Controls.Add(Me.D_TotalPesan)
        Me.GroupBox2.Controls.Add(Me.D_TotalBayar)
        Me.GroupBox2.Controls.Add(Me.D_Discount)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.D_JudulFilm)
        Me.GroupBox2.Location = New System.Drawing.Point(547, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(499, 315)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(345, 160)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(12, 17)
        Me.Label24.TabIndex = 27
        Me.Label24.Text = ":"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(345, 122)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(12, 17)
        Me.Label25.TabIndex = 26
        Me.Label25.Text = ":"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(117, 163)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(12, 17)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(117, 122)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(12, 17)
        Me.Label27.TabIndex = 24
        Me.Label27.Text = ":"
        '
        'D_NoKursi
        '
        Me.D_NoKursi.AutoSize = True
        Me.D_NoKursi.Location = New System.Drawing.Point(379, 160)
        Me.D_NoKursi.Name = "D_NoKursi"
        Me.D_NoKursi.Size = New System.Drawing.Size(56, 17)
        Me.D_NoKursi.TabIndex = 23
        Me.D_NoKursi.Text = "______"
        '
        'D_JamTayang
        '
        Me.D_JamTayang.AutoSize = True
        Me.D_JamTayang.Location = New System.Drawing.Point(379, 122)
        Me.D_JamTayang.Name = "D_JamTayang"
        Me.D_JamTayang.Size = New System.Drawing.Size(56, 17)
        Me.D_JamTayang.TabIndex = 22
        Me.D_JamTayang.Text = "______"
        '
        'D_JumlahTiket
        '
        Me.D_JumlahTiket.AutoSize = True
        Me.D_JumlahTiket.Location = New System.Drawing.Point(134, 163)
        Me.D_JumlahTiket.Name = "D_JumlahTiket"
        Me.D_JumlahTiket.Size = New System.Drawing.Size(56, 17)
        Me.D_JumlahTiket.TabIndex = 21
        Me.D_JumlahTiket.Text = "______"
        '
        'D_hari
        '
        Me.D_hari.AutoSize = True
        Me.D_hari.Location = New System.Drawing.Point(134, 122)
        Me.D_hari.Name = "D_hari"
        Me.D_hari.Size = New System.Drawing.Size(56, 17)
        Me.D_hari.TabIndex = 20
        Me.D_hari.Text = "______"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(32, 284)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 17)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Total Bayar"
        '
        'D_Studio
        '
        Me.D_Studio.AutoSize = True
        Me.D_Studio.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Studio.Location = New System.Drawing.Point(24, 59)
        Me.D_Studio.Name = "D_Studio"
        Me.D_Studio.Size = New System.Drawing.Size(91, 31)
        Me.D_Studio.TabIndex = 18
        Me.D_Studio.Text = "Studio"
        '
        'D_TotalPesan
        '
        Me.D_TotalPesan.Location = New System.Drawing.Point(160, 200)
        Me.D_TotalPesan.Name = "D_TotalPesan"
        Me.D_TotalPesan.Size = New System.Drawing.Size(194, 22)
        Me.D_TotalPesan.TabIndex = 17
        Me.D_TotalPesan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'D_TotalBayar
        '
        Me.D_TotalBayar.Location = New System.Drawing.Point(160, 282)
        Me.D_TotalBayar.Name = "D_TotalBayar"
        Me.D_TotalBayar.Size = New System.Drawing.Size(194, 22)
        Me.D_TotalBayar.TabIndex = 16
        Me.D_TotalBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'D_Discount
        '
        Me.D_Discount.Location = New System.Drawing.Point(160, 242)
        Me.D_Discount.Name = "D_Discount"
        Me.D_Discount.Size = New System.Drawing.Size(194, 22)
        Me.D_Discount.TabIndex = 15
        Me.D_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 17)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Total Pesan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 163)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 17)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Jumlah Tiket"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 245)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 17)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Discount"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(262, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 17)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "No. Kursi"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(27, 122)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 17)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Hari"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(259, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 17)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Jam Tayang"
        '
        'D_JudulFilm
        '
        Me.D_JudulFilm.AutoSize = True
        Me.D_JudulFilm.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_JudulFilm.Location = New System.Drawing.Point(23, 20)
        Me.D_JudulFilm.Name = "D_JudulFilm"
        Me.D_JudulFilm.Size = New System.Drawing.Size(165, 38)
        Me.D_JudulFilm.TabIndex = 1
        Me.D_JudulFilm.Text = "Judul Film"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(33, 444)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(331, 17)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "*pembelian lebih dari 5 mendapatkan discount 10%"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(547, 421)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 62)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Prosess"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(758, 421)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 62)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Studio
        '
        Me.Studio.FormattingEnabled = True
        Me.Studio.Items.AddRange(New Object() {"Studio 1", "Studio 2", "Studio 3", "Studio 4", "Studio 5"})
        Me.Studio.Location = New System.Drawing.Point(134, 77)
        Me.Studio.Name = "Studio"
        Me.Studio.Size = New System.Drawing.Size(194, 24)
        Me.Studio.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 526)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Harga As System.Windows.Forms.TextBox
    Friend WithEvents No_Kursi_2 As System.Windows.Forms.ComboBox
    Friend WithEvents NO_Kursi_1 As System.Windows.Forms.ComboBox
    Friend WithEvents Judul_Film As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Jumlah_Tiket As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents D_NoKursi As System.Windows.Forms.Label
    Friend WithEvents D_JamTayang As System.Windows.Forms.Label
    Friend WithEvents D_JumlahTiket As System.Windows.Forms.Label
    Friend WithEvents D_hari As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents D_Studio As System.Windows.Forms.Label
    Friend WithEvents D_TotalPesan As System.Windows.Forms.TextBox
    Friend WithEvents D_TotalBayar As System.Windows.Forms.TextBox
    Friend WithEvents D_Discount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents D_JudulFilm As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Jam_Tayang As System.Windows.Forms.ComboBox
    Friend WithEvents Hari As System.Windows.Forms.ComboBox
    Friend WithEvents Studio As System.Windows.Forms.ComboBox

End Class
