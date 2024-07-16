<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class guestList
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btCetak = New System.Windows.Forms.Button()
        Me.dgvGuestList = New System.Windows.Forms.DataGridView()
        Me.idTamu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ktp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noHp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenisKelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvGuestList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(383, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 25)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Daftar Tamu"
        '
        'btCetak
        '
        Me.btCetak.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCetak.Location = New System.Drawing.Point(12, 469)
        Me.btCetak.Name = "btCetak"
        Me.btCetak.Size = New System.Drawing.Size(110, 33)
        Me.btCetak.TabIndex = 51
        Me.btCetak.Text = "Cetak"
        Me.btCetak.UseVisualStyleBackColor = True
        '
        'dgvGuestList
        '
        Me.dgvGuestList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvGuestList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGuestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGuestList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idTamu, Me.nama, Me.alamat, Me.ktp, Me.noHp, Me.jenisKelamin})
        Me.dgvGuestList.Location = New System.Drawing.Point(12, 37)
        Me.dgvGuestList.Name = "dgvGuestList"
        Me.dgvGuestList.RowHeadersVisible = False
        Me.dgvGuestList.RowTemplate.Height = 24
        Me.dgvGuestList.Size = New System.Drawing.Size(900, 426)
        Me.dgvGuestList.TabIndex = 52
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
        'guestList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 514)
        Me.Controls.Add(Me.dgvGuestList)
        Me.Controls.Add(Me.btCetak)
        Me.Controls.Add(Me.Label2)
        Me.Name = "guestList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "guestList"
        CType(Me.dgvGuestList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btCetak As System.Windows.Forms.Button
    Friend WithEvents dgvGuestList As System.Windows.Forms.DataGridView
    Friend WithEvents idTamu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alamat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ktp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents noHp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jenisKelamin As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
