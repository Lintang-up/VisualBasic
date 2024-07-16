<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addGuest
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rtbAlamat = New System.Windows.Forms.RichTextBox()
        Me.cbJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.btUlang = New System.Windows.Forms.Button()
        Me.btSimpan = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNoHp = New System.Windows.Forms.TextBox()
        Me.tbKtp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btHapus = New System.Windows.Forms.Button()
        Me.dgvAddGuest = New System.Windows.Forms.DataGridView()
        Me.idTamu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ktp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noHp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenisKelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvAddGuest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(781, 491)
        Me.TabControl1.TabIndex = 999
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(773, 462)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add Guest"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.rtbAlamat)
        Me.GroupBox1.Controls.Add(Me.cbJenisKelamin)
        Me.GroupBox1.Controls.Add(Me.btUlang)
        Me.GroupBox1.Controls.Add(Me.btSimpan)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbNoHp)
        Me.GroupBox1.Controls.Add(Me.tbKtp)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbNama)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(117, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 375)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'rtbAlamat
        '
        Me.rtbAlamat.Location = New System.Drawing.Point(224, 79)
        Me.rtbAlamat.Name = "rtbAlamat"
        Me.rtbAlamat.Size = New System.Drawing.Size(233, 60)
        Me.rtbAlamat.TabIndex = 6
        Me.rtbAlamat.Text = ""
        '
        'cbJenisKelamin
        '
        Me.cbJenisKelamin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJenisKelamin.FormattingEnabled = True
        Me.cbJenisKelamin.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cbJenisKelamin.Location = New System.Drawing.Point(224, 210)
        Me.cbJenisKelamin.Name = "cbJenisKelamin"
        Me.cbJenisKelamin.Size = New System.Drawing.Size(233, 28)
        Me.cbJenisKelamin.TabIndex = 9
        '
        'btUlang
        '
        Me.btUlang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUlang.Location = New System.Drawing.Point(140, 297)
        Me.btUlang.Name = "btUlang"
        Me.btUlang.Size = New System.Drawing.Size(110, 33)
        Me.btUlang.TabIndex = 35
        Me.btUlang.Text = "Ulang"
        Me.btUlang.UseVisualStyleBackColor = True
        '
        'btSimpan
        '
        Me.btSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSimpan.Location = New System.Drawing.Point(281, 297)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(110, 33)
        Me.btSimpan.TabIndex = 10
        Me.btSimpan.Text = "Simpan"
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(75, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 20)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(75, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "No. Hp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "KTP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Alamat"
        '
        'tbNoHp
        '
        Me.tbNoHp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNoHp.Location = New System.Drawing.Point(224, 178)
        Me.tbNoHp.Name = "tbNoHp"
        Me.tbNoHp.Size = New System.Drawing.Size(233, 27)
        Me.tbNoHp.TabIndex = 8
        '
        'tbKtp
        '
        Me.tbKtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKtp.Location = New System.Drawing.Point(224, 145)
        Me.tbKtp.Name = "tbKtp"
        Me.tbKtp.Size = New System.Drawing.Size(233, 27)
        Me.tbKtp.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Nama"
        '
        'tbNama
        '
        Me.tbNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNama.Location = New System.Drawing.Point(224, 46)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(233, 27)
        Me.tbNama.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(201, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 25)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Tambah Tamu"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btHapus)
        Me.TabPage2.Controls.Add(Me.dgvAddGuest)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(773, 462)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Guest List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btHapus
        '
        Me.btHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHapus.Location = New System.Drawing.Point(6, 423)
        Me.btHapus.Name = "btHapus"
        Me.btHapus.Size = New System.Drawing.Size(110, 33)
        Me.btHapus.TabIndex = 37
        Me.btHapus.Text = "Hapus"
        Me.btHapus.UseVisualStyleBackColor = True
        '
        'dgvAddGuest
        '
        Me.dgvAddGuest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAddGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAddGuest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idTamu, Me.nama, Me.alamat, Me.ktp, Me.noHp, Me.jenisKelamin})
        Me.dgvAddGuest.Location = New System.Drawing.Point(6, 6)
        Me.dgvAddGuest.Name = "dgvAddGuest"
        Me.dgvAddGuest.RowHeadersVisible = False
        Me.dgvAddGuest.RowTemplate.Height = 24
        Me.dgvAddGuest.Size = New System.Drawing.Size(761, 411)
        Me.dgvAddGuest.TabIndex = 0
        '
        'idTamu
        '
        Me.idTamu.HeaderText = "ID"
        Me.idTamu.Name = "idTamu"
        '
        'nama
        '
        Me.nama.HeaderText = "Nama"
        Me.nama.Name = "nama"
        '
        'alamat
        '
        Me.alamat.HeaderText = "Alamat"
        Me.alamat.Name = "alamat"
        '
        'ktp
        '
        Me.ktp.HeaderText = "KTP"
        Me.ktp.Name = "ktp"
        '
        'noHp
        '
        Me.noHp.HeaderText = "No. Hp"
        Me.noHp.Name = "noHp"
        '
        'jenisKelamin
        '
        Me.jenisKelamin.HeaderText = "Jenis Kelamin"
        Me.jenisKelamin.Name = "jenisKelamin"
        '
        'addGuest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 515)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "addGuest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addGuest"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvAddGuest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbJenisKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents btUlang As System.Windows.Forms.Button
    Friend WithEvents btSimpan As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbNoHp As System.Windows.Forms.TextBox
    Friend WithEvents tbKtp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btHapus As System.Windows.Forms.Button
    Friend WithEvents dgvAddGuest As System.Windows.Forms.DataGridView
    Friend WithEvents rtbAlamat As System.Windows.Forms.RichTextBox
    Friend WithEvents idTamu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alamat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ktp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents noHp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jenisKelamin As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
