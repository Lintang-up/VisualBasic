<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
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
        Me.ID_Transaksi = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cb1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Jenis_Kelamin = New System.Windows.Forms.TextBox()
        Me.Alamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Harga_Obat = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Cb2 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Apoteker = New System.Windows.Forms.TextBox()
        Me.Nama_Obat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Jumlah_Obat = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Jumlah_Harga = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_rm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_p = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_h = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Data Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Transaksi"
        '
        'ID_Transaksi
        '
        Me.ID_Transaksi.Location = New System.Drawing.Point(160, 58)
        Me.ID_Transaksi.Name = "ID_Transaksi"
        Me.ID_Transaksi.ReadOnly = True
        Me.ID_Transaksi.Size = New System.Drawing.Size(147, 20)
        Me.ID_Transaksi.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cb1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Jenis_Kelamin)
        Me.GroupBox1.Controls.Add(Me.Alamat)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Nama)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 154)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pasien"
        '
        'Cb1
        '
        Me.Cb1.FormattingEnabled = True
        Me.Cb1.Location = New System.Drawing.Point(134, 16)
        Me.Cb1.Name = "Cb1"
        Me.Cb1.Size = New System.Drawing.Size(140, 21)
        Me.Cb1.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Alamat"
        '
        'Jenis_Kelamin
        '
        Me.Jenis_Kelamin.Location = New System.Drawing.Point(134, 118)
        Me.Jenis_Kelamin.Name = "Jenis_Kelamin"
        Me.Jenis_Kelamin.ReadOnly = True
        Me.Jenis_Kelamin.Size = New System.Drawing.Size(140, 20)
        Me.Jenis_Kelamin.TabIndex = 2
        '
        'Alamat
        '
        Me.Alamat.Location = New System.Drawing.Point(134, 85)
        Me.Alamat.Name = "Alamat"
        Me.Alamat.ReadOnly = True
        Me.Alamat.Size = New System.Drawing.Size(140, 20)
        Me.Alamat.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nama"
        '
        'Nama
        '
        Me.Nama.Location = New System.Drawing.Point(134, 50)
        Me.Nama.Name = "Nama"
        Me.Nama.ReadOnly = True
        Me.Nama.Size = New System.Drawing.Size(140, 20)
        Me.Nama.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "NoRM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Harga Obat"
        '
        'Harga_Obat
        '
        Me.Harga_Obat.Location = New System.Drawing.Point(134, 117)
        Me.Harga_Obat.Name = "Harga_Obat"
        Me.Harga_Obat.ReadOnly = True
        Me.Harga_Obat.Size = New System.Drawing.Size(140, 20)
        Me.Harga_Obat.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Cb2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Apoteker)
        Me.GroupBox2.Controls.Add(Me.Nama_Obat)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Harga_Obat)
        Me.GroupBox2.Location = New System.Drawing.Point(384, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 154)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Obat"
        '
        'Cb2
        '
        Me.Cb2.FormattingEnabled = True
        Me.Cb2.Location = New System.Drawing.Point(134, 12)
        Me.Cb2.Name = "Cb2"
        Me.Cb2.Size = New System.Drawing.Size(140, 21)
        Me.Cb2.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Apoteker"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Nama Obat"
        '
        'Apoteker
        '
        Me.Apoteker.Location = New System.Drawing.Point(134, 84)
        Me.Apoteker.Name = "Apoteker"
        Me.Apoteker.ReadOnly = True
        Me.Apoteker.Size = New System.Drawing.Size(140, 20)
        Me.Apoteker.TabIndex = 2
        '
        'Nama_Obat
        '
        Me.Nama_Obat.Location = New System.Drawing.Point(134, 51)
        Me.Nama_Obat.Name = "Nama_Obat"
        Me.Nama_Obat.ReadOnly = True
        Me.Nama_Obat.Size = New System.Drawing.Size(140, 20)
        Me.Nama_Obat.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Kode Obat"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(31, 256)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 17)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Jumlah Obat"
        '
        'Jumlah_Obat
        '
        Me.Jumlah_Obat.Enabled = False
        Me.Jumlah_Obat.Location = New System.Drawing.Point(34, 279)
        Me.Jumlah_Obat.Name = "Jumlah_Obat"
        Me.Jumlah_Obat.Size = New System.Drawing.Size(140, 20)
        Me.Jumlah_Obat.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(210, 256)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Jumlah Harga"
        '
        'Jumlah_Harga
        '
        Me.Jumlah_Harga.Location = New System.Drawing.Point(213, 279)
        Me.Jumlah_Harga.Name = "Jumlah_Harga"
        Me.Jumlah_Harga.ReadOnly = True
        Me.Jumlah_Harga.Size = New System.Drawing.Size(140, 20)
        Me.Jumlah_Harga.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(482, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(635, 275)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(385, 276)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Simpan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgv2
        '
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.no_rm, Me.nama_p, Me.kode_o, Me.nama_o, Me.harga_o, Me.jumlah_o, Me.jumlah_h})
        Me.dgv2.Location = New System.Drawing.Point(34, 321)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.Size = New System.Drawing.Size(676, 196)
        Me.dgv2.TabIndex = 6
        '
        'ID
        '
        Me.ID.HeaderText = "ID_Transaksi"
        Me.ID.Name = "ID"
        Me.ID.Width = 80
        '
        'no_rm
        '
        Me.no_rm.HeaderText = "No RM"
        Me.no_rm.Name = "no_rm"
        Me.no_rm.Width = 70
        '
        'nama_p
        '
        Me.nama_p.HeaderText = "Nama Pasien"
        Me.nama_p.Name = "nama_p"
        '
        'kode_o
        '
        Me.kode_o.HeaderText = "Kode Obat"
        Me.kode_o.Name = "kode_o"
        Me.kode_o.Width = 40
        '
        'nama_o
        '
        Me.nama_o.HeaderText = "Nama Obat"
        Me.nama_o.Name = "nama_o"
        '
        'harga_o
        '
        Me.harga_o.HeaderText = "Harga Obat"
        Me.harga_o.Name = "harga_o"
        Me.harga_o.Width = 98
        '
        'jumlah_o
        '
        Me.jumlah_o.HeaderText = "Jumlah Obat"
        Me.jumlah_o.Name = "jumlah_o"
        Me.jumlah_o.Width = 45
        '
        'jumlah_h
        '
        Me.jumlah_h.HeaderText = "Jumlah Harga"
        Me.jumlah_h.Name = "jumlah_h"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(311, 58)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(16, 18)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "R"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(23, 23)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "<"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 538)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.dgv2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Jumlah_Harga)
        Me.Controls.Add(Me.Jumlah_Obat)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ID_Transaksi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Transaksi"
        Me.Text = "Transaksi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ID_Transaksi As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cb1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Jenis_Kelamin As System.Windows.Forms.TextBox
    Friend WithEvents Alamat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Nama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Harga_Obat As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Apoteker As System.Windows.Forms.TextBox
    Friend WithEvents Nama_Obat As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Jumlah_Obat As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Jumlah_Harga As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents Cb2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents no_rm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_p As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kode_o As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_o As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga_o As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah_o As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah_h As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
