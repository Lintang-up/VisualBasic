<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestListInTheCheckIn
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
        Me.dgvGuestListInTheCheckIn = New System.Windows.Forms.DataGridView()
        Me.idTamu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ktp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noHp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenisKelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvGuestListInTheCheckIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvGuestListInTheCheckIn
        '
        Me.dgvGuestListInTheCheckIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGuestListInTheCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGuestListInTheCheckIn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idTamu, Me.nama, Me.alamat, Me.ktp, Me.noHp, Me.jenisKelamin})
        Me.dgvGuestListInTheCheckIn.Location = New System.Drawing.Point(12, 12)
        Me.dgvGuestListInTheCheckIn.Name = "dgvGuestListInTheCheckIn"
        Me.dgvGuestListInTheCheckIn.RowTemplate.Height = 24
        Me.dgvGuestListInTheCheckIn.Size = New System.Drawing.Size(919, 350)
        Me.dgvGuestListInTheCheckIn.TabIndex = 0
        '
        'idTamu
        '
        Me.idTamu.HeaderText = "ID Tamu"
        Me.idTamu.Name = "idTamu"
        '
        'nama
        '
        Me.nama.HeaderText = "nama"
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
        'GuestListInTheCheckIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 374)
        Me.Controls.Add(Me.dgvGuestListInTheCheckIn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "GuestListInTheCheckIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Click To Select Guest"
        CType(Me.dgvGuestListInTheCheckIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvGuestListInTheCheckIn As System.Windows.Forms.DataGridView
    Friend WithEvents idTamu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alamat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ktp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents noHp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jenisKelamin As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
