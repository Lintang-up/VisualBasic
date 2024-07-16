<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transactionInTheCheckOut
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
        Me.dgvTransactionInTheCheckOut = New System.Windows.Forms.DataGridView()
        Me.dgvIdTransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvNamaTamu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvNomorRuangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTipeRuangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTarifRuangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTanggalCheckIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTanggalCheckOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvJumlahHari = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvJumlahDewasa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvJumlahAnak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDiskonInap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTipeMember = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDiskonMember = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvUangMuka = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTotalKurang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvIdTamu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvIdRuangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvTransactionInTheCheckOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTransactionInTheCheckOut
        '
        Me.dgvTransactionInTheCheckOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvTransactionInTheCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactionInTheCheckOut.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvIdTransaksi, Me.dgvNamaTamu, Me.dgvNomorRuangan, Me.dgvTipeRuangan, Me.dgvTarifRuangan, Me.dgvTanggalCheckIn, Me.dgvTanggalCheckOut, Me.dgvJumlahHari, Me.dgvJumlahDewasa, Me.dgvJumlahAnak, Me.dgvDiskonInap, Me.dgvTipeMember, Me.dgvDiskonMember, Me.dgvSubTotal, Me.dgvUangMuka, Me.dgvTotalKurang, Me.dgvIdTamu, Me.dgvIdRuangan})
        Me.dgvTransactionInTheCheckOut.Location = New System.Drawing.Point(12, 12)
        Me.dgvTransactionInTheCheckOut.Name = "dgvTransactionInTheCheckOut"
        Me.dgvTransactionInTheCheckOut.RowTemplate.Height = 24
        Me.dgvTransactionInTheCheckOut.Size = New System.Drawing.Size(1179, 468)
        Me.dgvTransactionInTheCheckOut.TabIndex = 1
        '
        'dgvIdTransaksi
        '
        Me.dgvIdTransaksi.HeaderText = "ID Transaksi"
        Me.dgvIdTransaksi.Name = "dgvIdTransaksi"
        Me.dgvIdTransaksi.Width = 103
        '
        'dgvNamaTamu
        '
        Me.dgvNamaTamu.HeaderText = "Nama Tamu"
        Me.dgvNamaTamu.Name = "dgvNamaTamu"
        Me.dgvNamaTamu.Width = 101
        '
        'dgvNomorRuangan
        '
        Me.dgvNomorRuangan.HeaderText = "Nomor Ruangan"
        Me.dgvNomorRuangan.Name = "dgvNomorRuangan"
        Me.dgvNomorRuangan.Width = 125
        '
        'dgvTipeRuangan
        '
        Me.dgvTipeRuangan.HeaderText = "Tipe Ruangan"
        Me.dgvTipeRuangan.Name = "dgvTipeRuangan"
        Me.dgvTipeRuangan.Width = 113
        '
        'dgvTarifRuangan
        '
        Me.dgvTarifRuangan.HeaderText = "Tarif Ruangan"
        Me.dgvTarifRuangan.Name = "dgvTarifRuangan"
        Me.dgvTarifRuangan.Width = 114
        '
        'dgvTanggalCheckIn
        '
        Me.dgvTanggalCheckIn.HeaderText = "Tanggal Check In"
        Me.dgvTanggalCheckIn.Name = "dgvTanggalCheckIn"
        Me.dgvTanggalCheckIn.Width = 117
        '
        'dgvTanggalCheckOut
        '
        Me.dgvTanggalCheckOut.HeaderText = "Tanggal Check Out"
        Me.dgvTanggalCheckOut.Name = "dgvTanggalCheckOut"
        Me.dgvTanggalCheckOut.Width = 121
        '
        'dgvJumlahHari
        '
        Me.dgvJumlahHari.HeaderText = "Jumlah Hari"
        Me.dgvJumlahHari.Name = "dgvJumlahHari"
        Me.dgvJumlahHari.Width = 99
        '
        'dgvJumlahDewasa
        '
        Me.dgvJumlahDewasa.HeaderText = "Jumlah Dewasa"
        Me.dgvJumlahDewasa.Name = "dgvJumlahDewasa"
        Me.dgvJumlahDewasa.Width = 121
        '
        'dgvJumlahAnak
        '
        Me.dgvJumlahAnak.HeaderText = "Jumlah Anak"
        Me.dgvJumlahAnak.Name = "dgvJumlahAnak"
        Me.dgvJumlahAnak.Width = 105
        '
        'dgvDiskonInap
        '
        Me.dgvDiskonInap.HeaderText = "Diskon Inap"
        Me.dgvDiskonInap.Name = "dgvDiskonInap"
        Me.dgvDiskonInap.Width = 98
        '
        'dgvTipeMember
        '
        Me.dgvTipeMember.HeaderText = "Tipe Member"
        Me.dgvTipeMember.Name = "dgvTipeMember"
        Me.dgvTipeMember.Width = 106
        '
        'dgvDiskonMember
        '
        Me.dgvDiskonMember.HeaderText = "Diskon Member"
        Me.dgvDiskonMember.Name = "dgvDiskonMember"
        Me.dgvDiskonMember.Width = 120
        '
        'dgvSubTotal
        '
        Me.dgvSubTotal.HeaderText = "Sub Total"
        Me.dgvSubTotal.Name = "dgvSubTotal"
        Me.dgvSubTotal.Width = 87
        '
        'dgvUangMuka
        '
        Me.dgvUangMuka.HeaderText = "Uang Muka"
        Me.dgvUangMuka.Name = "dgvUangMuka"
        Me.dgvUangMuka.Width = 96
        '
        'dgvTotalKurang
        '
        Me.dgvTotalKurang.HeaderText = "Total Kurang"
        Me.dgvTotalKurang.Name = "dgvTotalKurang"
        Me.dgvTotalKurang.Width = 105
        '
        'dgvIdTamu
        '
        Me.dgvIdTamu.HeaderText = "Id Tamu"
        Me.dgvIdTamu.Name = "dgvIdTamu"
        Me.dgvIdTamu.Width = 78
        '
        'dgvIdRuangan
        '
        Me.dgvIdRuangan.HeaderText = "Id Ruangan"
        Me.dgvIdRuangan.Name = "dgvIdRuangan"
        Me.dgvIdRuangan.Width = 97
        '
        'transactionInTheCheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 492)
        Me.Controls.Add(Me.dgvTransactionInTheCheckOut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "transactionInTheCheckOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "transactionInTheCheckOut"
        CType(Me.dgvTransactionInTheCheckOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvTransactionInTheCheckOut As System.Windows.Forms.DataGridView
    Friend WithEvents dgvIdTransaksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvNamaTamu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvNomorRuangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvTipeRuangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvTarifRuangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvTanggalCheckIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvTanggalCheckOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvJumlahHari As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvJumlahDewasa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvJumlahAnak As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvDiskonInap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvTipeMember As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvDiskonMember As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvUangMuka As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvTotalKurang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvIdTamu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvIdRuangan As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
