<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkInList
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btCetak = New System.Windows.Forms.Button()
        CType(Me.dgvCheckInList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCheckInList
        '
        Me.dgvCheckInList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCheckInList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvCheckInList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCheckInList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvIdTransaksi, Me.dgvNamaTamu, Me.dgvNomorRuangan, Me.dgvTipeRuangan, Me.dgvTarifRuangan, Me.dgvTanggalCheckIn, Me.dgvTanggalCheckOut, Me.dgvJumlahHari, Me.dgvJumlahDewasa, Me.dgvJumlahAnak, Me.dgvDiskonInap, Me.dgvTipeMember, Me.dgvDiskonMember, Me.dgvSubTotal, Me.dgvUangMuka, Me.dgvTotalKurang})
        Me.dgvCheckInList.Location = New System.Drawing.Point(12, 37)
        Me.dgvCheckInList.Name = "dgvCheckInList"
        Me.dgvCheckInList.RowHeadersVisible = False
        Me.dgvCheckInList.RowTemplate.Height = 24
        Me.dgvCheckInList.Size = New System.Drawing.Size(1150, 423)
        Me.dgvCheckInList.TabIndex = 1
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
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(499, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 25)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Daftar Check In"
        '
        'btCetak
        '
        Me.btCetak.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCetak.Location = New System.Drawing.Point(12, 466)
        Me.btCetak.Name = "btCetak"
        Me.btCetak.Size = New System.Drawing.Size(110, 33)
        Me.btCetak.TabIndex = 51
        Me.btCetak.Text = "Cetak"
        Me.btCetak.UseVisualStyleBackColor = True
        '
        'checkInList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 511)
        Me.Controls.Add(Me.btCetak)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvCheckInList)
        Me.Name = "checkInList"
        Me.Text = "checkInList"
        CType(Me.dgvCheckInList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btCetak As System.Windows.Forms.Button
End Class
