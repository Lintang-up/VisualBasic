<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkOutList
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
        Me.btCetak = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvCheckInList = New System.Windows.Forms.DataGridView()
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
        Me.bayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kembalian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idTamu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idRuangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCheckInList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btCetak
        '
        Me.btCetak.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCetak.Location = New System.Drawing.Point(12, 471)
        Me.btCetak.Name = "btCetak"
        Me.btCetak.Size = New System.Drawing.Size(110, 33)
        Me.btCetak.TabIndex = 54
        Me.btCetak.Text = "Cetak"
        Me.btCetak.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(506, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 25)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Daftar Check Out"
        '
        'dgvCheckInList
        '
        Me.dgvCheckInList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCheckInList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvCheckInList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvIdTransaksi, Me.dgvNamaTamu, Me.dgvNomorRuangan, Me.dgvTipeRuangan, Me.dgvTarifRuangan, Me.dgvTanggalCheckIn, Me.dgvTanggalCheckOut, Me.dgvJumlahHari, Me.dgvJumlahDewasa, Me.dgvJumlahAnak, Me.dgvDiskonInap, Me.dgvTipeMember, Me.dgvDiskonMember, Me.dgvSubTotal, Me.dgvUangMuka, Me.dgvTotalKurang, Me.bayar, Me.kembalian, Me.idTamu, Me.idRuangan})
        Me.dgvCheckInList.Location = New System.Drawing.Point(12, 37)
        Me.dgvCheckInList.Name = "dgvCheckInList"
        Me.dgvCheckInList.RowHeadersVisible = False
        Me.dgvCheckInList.RowTemplate.Height = 24
        Me.dgvCheckInList.Size = New System.Drawing.Size(1164, 427)
        Me.dgvCheckInList.TabIndex = 52
        '
        'dgvIdTransaksi
        '
        Me.dgvIdTransaksi.HeaderText = "ID Transaksi"
        Me.dgvIdTransaksi.Name = "dgvIdTransaksi"
        Me.dgvIdTransaksi.Width = 112
        '
        'dgvNamaTamu
        '
        Me.dgvNamaTamu.HeaderText = "Nama Tamu"
        Me.dgvNamaTamu.Name = "dgvNamaTamu"
        Me.dgvNamaTamu.Width = 110
        '
        'dgvNomorRuangan
        '
        Me.dgvNomorRuangan.HeaderText = "Nomor Ruangan"
        Me.dgvNomorRuangan.Name = "dgvNomorRuangan"
        Me.dgvNomorRuangan.Width = 137
        '
        'dgvTipeRuangan
        '
        Me.dgvTipeRuangan.HeaderText = "Tipe Ruangan"
        Me.dgvTipeRuangan.Name = "dgvTipeRuangan"
        Me.dgvTipeRuangan.Width = 123
        '
        'dgvTarifRuangan
        '
        Me.dgvTarifRuangan.HeaderText = "Tarif Ruangan"
        Me.dgvTarifRuangan.Name = "dgvTarifRuangan"
        Me.dgvTarifRuangan.Width = 124
        '
        'dgvTanggalCheckIn
        '
        Me.dgvTanggalCheckIn.HeaderText = "Tanggal Check In"
        Me.dgvTanggalCheckIn.Name = "dgvTanggalCheckIn"
        Me.dgvTanggalCheckIn.Width = 143
        '
        'dgvTanggalCheckOut
        '
        Me.dgvTanggalCheckOut.HeaderText = "Tanggal Check Out"
        Me.dgvTanggalCheckOut.Name = "dgvTanggalCheckOut"
        Me.dgvTanggalCheckOut.Width = 155
        '
        'dgvJumlahHari
        '
        Me.dgvJumlahHari.HeaderText = "Jumlah Hari"
        Me.dgvJumlahHari.Name = "dgvJumlahHari"
        Me.dgvJumlahHari.Width = 108
        '
        'dgvJumlahDewasa
        '
        Me.dgvJumlahDewasa.HeaderText = "Jumlah Dewasa"
        Me.dgvJumlahDewasa.Name = "dgvJumlahDewasa"
        Me.dgvJumlahDewasa.Width = 132
        '
        'dgvJumlahAnak
        '
        Me.dgvJumlahAnak.HeaderText = "Jumlah Anak"
        Me.dgvJumlahAnak.Name = "dgvJumlahAnak"
        Me.dgvJumlahAnak.Width = 114
        '
        'dgvDiskonInap
        '
        Me.dgvDiskonInap.HeaderText = "Diskon Inap"
        Me.dgvDiskonInap.Name = "dgvDiskonInap"
        Me.dgvDiskonInap.Width = 107
        '
        'dgvTipeMember
        '
        Me.dgvTipeMember.HeaderText = "Tipe Member"
        Me.dgvTipeMember.Name = "dgvTipeMember"
        Me.dgvTipeMember.Width = 116
        '
        'dgvDiskonMember
        '
        Me.dgvDiskonMember.HeaderText = "Diskon Member"
        Me.dgvDiskonMember.Name = "dgvDiskonMember"
        Me.dgvDiskonMember.Width = 131
        '
        'dgvSubTotal
        '
        Me.dgvSubTotal.HeaderText = "Sub Total"
        Me.dgvSubTotal.Name = "dgvSubTotal"
        Me.dgvSubTotal.Width = 94
        '
        'dgvUangMuka
        '
        Me.dgvUangMuka.HeaderText = "Uang Muka"
        Me.dgvUangMuka.Name = "dgvUangMuka"
        Me.dgvUangMuka.Width = 105
        '
        'dgvTotalKurang
        '
        Me.dgvTotalKurang.HeaderText = "Total Kurang"
        Me.dgvTotalKurang.Name = "dgvTotalKurang"
        Me.dgvTotalKurang.Width = 115
        '
        'bayar
        '
        Me.bayar.HeaderText = "Bayar"
        Me.bayar.Name = "bayar"
        Me.bayar.Width = 70
        '
        'kembalian
        '
        Me.kembalian.HeaderText = "Kembalian"
        Me.kembalian.Name = "kembalian"
        Me.kembalian.Width = 99
        '
        'idTamu
        '
        Me.idTamu.HeaderText = "ID Tamu"
        Me.idTamu.Name = "idTamu"
        Me.idTamu.Width = 86
        '
        'idRuangan
        '
        Me.idRuangan.HeaderText = "Id Ruangan"
        Me.idRuangan.Name = "idRuangan"
        Me.idRuangan.Width = 106
        '
        'checkOutList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 516)
        Me.Controls.Add(Me.btCetak)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvCheckInList)
        Me.Name = "checkOutList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "checkOutList"
        CType(Me.dgvCheckInList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btCetak As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvCheckInList As System.Windows.Forms.DataGridView
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
    Friend WithEvents bayar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kembalian As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idTamu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idRuangan As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
