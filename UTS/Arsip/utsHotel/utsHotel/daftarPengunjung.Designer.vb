<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class daftarPengunjung
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.NamaPengunjung = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tipeKamar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.noKamar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.namaKamar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kodeKunci = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hargaSewa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lamaInap = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.checkIn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.checkOut = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.biayaInap = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.jumlahOrangMakan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.biayaMakan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.jumlahHariTour = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.biayaTour = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.jumlahOrangSpa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.biayaSpa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totalBayar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kembali = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(514, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(251, 25)
        Me.Label11.TabIndex = 111
        Me.Label11.Text = "DAFTAR PENGUNJUNG"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NamaPengunjung, Me.tipeKamar, Me.noKamar, Me.namaKamar, Me.kodeKunci, Me.hargaSewa, Me.lamaInap, Me.checkIn, Me.checkOut, Me.biayaInap, Me.jumlahOrangMakan, Me.biayaMakan, Me.jumlahHariTour, Me.biayaTour, Me.jumlahOrangSpa, Me.biayaSpa, Me.totalBayar})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 66)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1386, 287)
        Me.ListView1.TabIndex = 112
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'NamaPengunjung
        '
        Me.NamaPengunjung.Text = "Nama Pengunjung"
        Me.NamaPengunjung.Width = 126
        '
        'tipeKamar
        '
        Me.tipeKamar.Text = "Tipe Kamar"
        Me.tipeKamar.Width = 86
        '
        'noKamar
        '
        Me.noKamar.Text = "Nomor Kamar"
        Me.noKamar.Width = 102
        '
        'namaKamar
        '
        Me.namaKamar.Text = "Nama Kamar"
        Me.namaKamar.Width = 102
        '
        'kodeKunci
        '
        Me.kodeKunci.Text = "Kode Kunci"
        Me.kodeKunci.Width = 111
        '
        'hargaSewa
        '
        Me.hargaSewa.Text = "Harga Sewa"
        Me.hargaSewa.Width = 107
        '
        'lamaInap
        '
        Me.lamaInap.Text = "Lama Inap"
        Me.lamaInap.Width = 81
        '
        'checkIn
        '
        Me.checkIn.Text = "Check In"
        Me.checkIn.Width = 114
        '
        'checkOut
        '
        Me.checkOut.Text = "Check Out"
        Me.checkOut.Width = 116
        '
        'biayaInap
        '
        Me.biayaInap.Text = "Biaya Inap"
        Me.biayaInap.Width = 106
        '
        'jumlahOrangMakan
        '
        Me.jumlahOrangMakan.Text = "Jumlah Orang Makan"
        Me.jumlahOrangMakan.Width = 146
        '
        'biayaMakan
        '
        Me.biayaMakan.Text = "Biaya Makan"
        Me.biayaMakan.Width = 105
        '
        'jumlahHariTour
        '
        Me.jumlahHariTour.Text = "Jumlah Hari Tour Guide"
        Me.jumlahHariTour.Width = 162
        '
        'biayaTour
        '
        Me.biayaTour.Text = "Biaya Tour Guide"
        Me.biayaTour.Width = 129
        '
        'jumlahOrangSpa
        '
        Me.jumlahOrangSpa.Text = "Jumlah Orang Spa"
        Me.jumlahOrangSpa.Width = 131
        '
        'biayaSpa
        '
        Me.biayaSpa.Text = "Biaya Spa"
        Me.biayaSpa.Width = 97
        '
        'totalBayar
        '
        Me.totalBayar.Text = "Total Bayar"
        Me.totalBayar.Width = 95
        '
        'kembali
        '
        Me.kembali.Location = New System.Drawing.Point(38, 379)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(75, 30)
        Me.kembali.TabIndex = 113
        Me.kembali.Text = "Kembali"
        Me.kembali.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(147, 379)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 30)
        Me.btnHapus.TabIndex = 114
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'daftarPengunjung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1410, 450)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.kembali)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label11)
        Me.Name = "daftarPengunjung"
        Me.Text = "daftarPengunjung"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents NamaPengunjung As System.Windows.Forms.ColumnHeader
    Friend WithEvents tipeKamar As System.Windows.Forms.ColumnHeader
    Friend WithEvents noKamar As System.Windows.Forms.ColumnHeader
    Friend WithEvents namaKamar As System.Windows.Forms.ColumnHeader
    Friend WithEvents kodeKunci As System.Windows.Forms.ColumnHeader
    Friend WithEvents hargaSewa As System.Windows.Forms.ColumnHeader
    Friend WithEvents lamaInap As System.Windows.Forms.ColumnHeader
    Friend WithEvents checkIn As System.Windows.Forms.ColumnHeader
    Friend WithEvents checkOut As System.Windows.Forms.ColumnHeader
    Friend WithEvents biayaInap As System.Windows.Forms.ColumnHeader
    Friend WithEvents jumlahOrangMakan As System.Windows.Forms.ColumnHeader
    Friend WithEvents biayaMakan As System.Windows.Forms.ColumnHeader
    Friend WithEvents jumlahHariTour As System.Windows.Forms.ColumnHeader
    Friend WithEvents biayaTour As System.Windows.Forms.ColumnHeader
    Friend WithEvents jumlahOrangSpa As System.Windows.Forms.ColumnHeader
    Friend WithEvents biayaSpa As System.Windows.Forms.ColumnHeader
    Friend WithEvents totalBayar As System.Windows.Forms.ColumnHeader
    Friend WithEvents kembali As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
End Class
