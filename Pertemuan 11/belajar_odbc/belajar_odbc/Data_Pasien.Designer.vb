<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Pasien
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
        Me.no_rm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nama_pasien = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Alamat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat_pasien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jeniskelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JK = New System.Windows.Forms.ComboBox()
        Me.Cetak = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Data Pasien"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No RM"
        '
        'no_rm
        '
        Me.no_rm.Location = New System.Drawing.Point(153, 89)
        Me.no_rm.Name = "no_rm"
        Me.no_rm.ReadOnly = True
        Me.no_rm.Size = New System.Drawing.Size(172, 20)
        Me.no_rm.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama"
        '
        'nama_pasien
        '
        Me.nama_pasien.Location = New System.Drawing.Point(153, 131)
        Me.nama_pasien.Name = "nama_pasien"
        Me.nama_pasien.Size = New System.Drawing.Size(172, 20)
        Me.nama_pasien.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Alamat"
        '
        'Alamat
        '
        Me.Alamat.Location = New System.Drawing.Point(153, 171)
        Me.Alamat.Name = "Alamat"
        Me.Alamat.Size = New System.Drawing.Size(172, 20)
        Me.Alamat.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(385, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 43)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(494, 203)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 43)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(494, 88)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 43)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv1)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 255)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 244)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kesimpulan"
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nama, Me.alamat_pasien, Me.jeniskelamin})
        Me.dgv1.Location = New System.Drawing.Point(9, 19)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(534, 219)
        Me.dgv1.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "ID Pasien"
        Me.id.Name = "id"
        '
        'nama
        '
        Me.nama.HeaderText = "nama pasien"
        Me.nama.Name = "nama"
        '
        'alamat_pasien
        '
        Me.alamat_pasien.HeaderText = "alamat"
        Me.alamat_pasien.Name = "alamat_pasien"
        '
        'jeniskelamin
        '
        Me.jeniskelamin.HeaderText = "jenis kelamin"
        Me.jeniskelamin.Name = "jeniskelamin"
        '
        'JK
        '
        Me.JK.FormattingEnabled = True
        Me.JK.Items.AddRange(New Object() {"Laki - Laki", "Perempuan"})
        Me.JK.Location = New System.Drawing.Point(153, 215)
        Me.JK.Margin = New System.Windows.Forms.Padding(2)
        Me.JK.Name = "JK"
        Me.JK.Size = New System.Drawing.Size(172, 21)
        Me.JK.TabIndex = 5
        '
        'Cetak
        '
        Me.Cetak.Location = New System.Drawing.Point(385, 148)
        Me.Cetak.Name = "Cetak"
        Me.Cetak.Size = New System.Drawing.Size(86, 43)
        Me.Cetak.TabIndex = 6
        Me.Cetak.Text = "Cetak"
        Me.Cetak.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(23, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Data_Pasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 522)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Cetak)
        Me.Controls.Add(Me.JK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Alamat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nama_pasien)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.no_rm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Data_Pasien"
        Me.Text = "DataPasien"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents no_rm As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nama_pasien As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Alamat As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alamat_pasien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jeniskelamin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JK As System.Windows.Forms.ComboBox
    Friend WithEvents Cetak As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
