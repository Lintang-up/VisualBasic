﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Studio = New System.Windows.Forms.ComboBox()
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
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.B_Kembalian = New System.Windows.Forms.TextBox()
        Me.B_Pembayaran = New System.Windows.Forms.TextBox()
        Me.B_TotalBayar = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pemesanan Tiket Bioskop"
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
        Me.GroupBox1.Location = New System.Drawing.Point(22, 69)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(340, 245)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pemesanan"
        '
        'Studio
        '
        Me.Studio.FormattingEnabled = True
        Me.Studio.Location = New System.Drawing.Point(116, 58)
        Me.Studio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Studio.Name = "Studio"
        Me.Studio.Size = New System.Drawing.Size(146, 21)
        Me.Studio.TabIndex = 19
        '
        'Jam_Tayang
        '
        Me.Jam_Tayang.FormattingEnabled = True
        Me.Jam_Tayang.Location = New System.Drawing.Point(116, 122)
        Me.Jam_Tayang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Jam_Tayang.Name = "Jam_Tayang"
        Me.Jam_Tayang.Size = New System.Drawing.Size(146, 21)
        Me.Jam_Tayang.TabIndex = 18
        '
        'Hari
        '
        Me.Hari.FormattingEnabled = True
        Me.Hari.Location = New System.Drawing.Point(116, 90)
        Me.Hari.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Hari.Name = "Hari"
        Me.Hari.Size = New System.Drawing.Size(146, 21)
        Me.Hari.TabIndex = 18
        '
        'Jumlah_Tiket
        '
        Me.Jumlah_Tiket.Location = New System.Drawing.Point(116, 216)
        Me.Jumlah_Tiket.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Jumlah_Tiket.Name = "Jumlah_Tiket"
        Me.Jumlah_Tiket.Size = New System.Drawing.Size(146, 20)
        Me.Jumlah_Tiket.TabIndex = 17
        '
        'Harga
        '
        Me.Harga.Location = New System.Drawing.Point(116, 185)
        Me.Harga.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Harga.Name = "Harga"
        Me.Harga.Size = New System.Drawing.Size(146, 20)
        Me.Harga.TabIndex = 15
        '
        'No_Kursi_2
        '
        Me.No_Kursi_2.FormattingEnabled = True
        Me.No_Kursi_2.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.No_Kursi_2.Location = New System.Drawing.Point(206, 154)
        Me.No_Kursi_2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.No_Kursi_2.Name = "No_Kursi_2"
        Me.No_Kursi_2.Size = New System.Drawing.Size(56, 21)
        Me.No_Kursi_2.TabIndex = 14
        '
        'NO_Kursi_1
        '
        Me.NO_Kursi_1.FormattingEnabled = True
        Me.NO_Kursi_1.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.NO_Kursi_1.Location = New System.Drawing.Point(116, 154)
        Me.NO_Kursi_1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NO_Kursi_1.Name = "NO_Kursi_1"
        Me.NO_Kursi_1.Size = New System.Drawing.Size(60, 21)
        Me.NO_Kursi_1.TabIndex = 13
        '
        'Judul_Film
        '
        Me.Judul_Film.FormattingEnabled = True
        Me.Judul_Film.Location = New System.Drawing.Point(116, 28)
        Me.Judul_Film.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Judul_Film.Name = "Judul_Film"
        Me.Judul_Film.Size = New System.Drawing.Size(146, 21)
        Me.Judul_Film.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 219)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Jumlah Tiket"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 188)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Harga"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 156)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "No. Kursi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 93)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hari"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 124)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Jam Tayang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 61)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Studio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Judul Film"
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
        Me.GroupBox2.Location = New System.Drawing.Point(386, 69)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(374, 256)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(259, 130)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(10, 13)
        Me.Label24.TabIndex = 27
        Me.Label24.Text = ":"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(259, 99)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(10, 13)
        Me.Label25.TabIndex = 26
        Me.Label25.Text = ":"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(88, 132)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(10, 13)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(88, 99)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(10, 13)
        Me.Label27.TabIndex = 24
        Me.Label27.Text = ":"
        '
        'D_NoKursi
        '
        Me.D_NoKursi.AutoSize = True
        Me.D_NoKursi.Location = New System.Drawing.Point(284, 130)
        Me.D_NoKursi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.D_NoKursi.Name = "D_NoKursi"
        Me.D_NoKursi.Size = New System.Drawing.Size(43, 13)
        Me.D_NoKursi.TabIndex = 23
        Me.D_NoKursi.Text = "______"
        '
        'D_JamTayang
        '
        Me.D_JamTayang.AutoSize = True
        Me.D_JamTayang.Location = New System.Drawing.Point(284, 99)
        Me.D_JamTayang.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.D_JamTayang.Name = "D_JamTayang"
        Me.D_JamTayang.Size = New System.Drawing.Size(43, 13)
        Me.D_JamTayang.TabIndex = 22
        Me.D_JamTayang.Text = "______"
        '
        'D_JumlahTiket
        '
        Me.D_JumlahTiket.AutoSize = True
        Me.D_JumlahTiket.Location = New System.Drawing.Point(106, 132)
        Me.D_JumlahTiket.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.D_JumlahTiket.Name = "D_JumlahTiket"
        Me.D_JumlahTiket.Size = New System.Drawing.Size(43, 13)
        Me.D_JumlahTiket.TabIndex = 21
        Me.D_JumlahTiket.Text = "______"
        '
        'D_hari
        '
        Me.D_hari.AutoSize = True
        Me.D_hari.Location = New System.Drawing.Point(106, 99)
        Me.D_hari.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.D_hari.Name = "D_hari"
        Me.D_hari.Size = New System.Drawing.Size(43, 13)
        Me.D_hari.TabIndex = 20
        Me.D_hari.Text = "______"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(24, 231)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 13)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Total Bayar"
        '
        'D_Studio
        '
        Me.D_Studio.AutoSize = True
        Me.D_Studio.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Studio.Location = New System.Drawing.Point(18, 48)
        Me.D_Studio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.D_Studio.Name = "D_Studio"
        Me.D_Studio.Size = New System.Drawing.Size(74, 26)
        Me.D_Studio.TabIndex = 18
        Me.D_Studio.Text = "Studio"
        '
        'D_TotalPesan
        '
        Me.D_TotalPesan.Location = New System.Drawing.Point(120, 162)
        Me.D_TotalPesan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.D_TotalPesan.Name = "D_TotalPesan"
        Me.D_TotalPesan.Size = New System.Drawing.Size(146, 20)
        Me.D_TotalPesan.TabIndex = 17
        Me.D_TotalPesan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'D_TotalBayar
        '
        Me.D_TotalBayar.Location = New System.Drawing.Point(120, 229)
        Me.D_TotalBayar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.D_TotalBayar.Name = "D_TotalBayar"
        Me.D_TotalBayar.Size = New System.Drawing.Size(146, 20)
        Me.D_TotalBayar.TabIndex = 16
        Me.D_TotalBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'D_Discount
        '
        Me.D_Discount.Location = New System.Drawing.Point(120, 197)
        Me.D_Discount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.D_Discount.Name = "D_Discount"
        Me.D_Discount.Size = New System.Drawing.Size(146, 20)
        Me.D_Discount.TabIndex = 15
        Me.D_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 164)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Total Harga"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 132)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Jumlah Tiket"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 199)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Discount"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(196, 130)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "No. Kursi"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 99)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Hari"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(194, 99)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Jam Tayang"
        '
        'D_JudulFilm
        '
        Me.D_JudulFilm.AutoSize = True
        Me.D_JudulFilm.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_JudulFilm.Location = New System.Drawing.Point(17, 16)
        Me.D_JudulFilm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.D_JudulFilm.Name = "D_JudulFilm"
        Me.D_JudulFilm.Size = New System.Drawing.Size(137, 31)
        Me.D_JudulFilm.TabIndex = 1
        Me.D_JudulFilm.Text = "Judul Film"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(20, 328)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(247, 13)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "*pembelian lebih dari 5 mendapatkan discount 10%"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(202, 369)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 50)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(42, 369)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Prosess"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.B_Kembalian)
        Me.GroupBox3.Controls.Add(Me.B_Pembayaran)
        Me.GroupBox3.Controls.Add(Me.B_TotalBayar)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(386, 362)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(340, 143)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bayar"
        '
        'B_Kembalian
        '
        Me.B_Kembalian.Location = New System.Drawing.Point(120, 92)
        Me.B_Kembalian.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.B_Kembalian.Name = "B_Kembalian"
        Me.B_Kembalian.Size = New System.Drawing.Size(146, 20)
        Me.B_Kembalian.TabIndex = 16
        Me.B_Kembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'B_Pembayaran
        '
        Me.B_Pembayaran.Location = New System.Drawing.Point(120, 57)
        Me.B_Pembayaran.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.B_Pembayaran.Name = "B_Pembayaran"
        Me.B_Pembayaran.Size = New System.Drawing.Size(146, 20)
        Me.B_Pembayaran.TabIndex = 16
        Me.B_Pembayaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'B_TotalBayar
        '
        Me.B_TotalBayar.Location = New System.Drawing.Point(120, 24)
        Me.B_TotalBayar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.B_TotalBayar.Name = "B_TotalBayar"
        Me.B_TotalBayar.Size = New System.Drawing.Size(146, 20)
        Me.B_TotalBayar.TabIndex = 16
        Me.B_TotalBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(24, 93)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 13)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Kembalian"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 58)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 13)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Pembayaran"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Total Bayar"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(660, 509)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 25)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Bayar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(2, 2)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(31, 26)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "<"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 555)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Pemesanan Tiket Bioskop"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Studio As System.Windows.Forms.ComboBox
    Friend WithEvents Jam_Tayang As System.Windows.Forms.ComboBox
    Friend WithEvents Hari As System.Windows.Forms.ComboBox
    Friend WithEvents Jumlah_Tiket As System.Windows.Forms.TextBox
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents B_Kembalian As System.Windows.Forms.TextBox
    Friend WithEvents B_Pembayaran As System.Windows.Forms.TextBox
    Friend WithEvents B_TotalBayar As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
