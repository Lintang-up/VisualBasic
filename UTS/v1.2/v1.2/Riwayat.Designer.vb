<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Riwayat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Riwayat))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.JudulFilm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Studio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Hari = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.JamTayang = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NoKursi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Harga = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.JumlahTiket = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Discount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalBayar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.JudulFilm, Me.Studio, Me.Hari, Me.JamTayang, Me.NoKursi, Me.Harga, Me.JumlahTiket, Me.Discount, Me.TotalBayar})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(31, 80)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(630, 234)
        Me.ListView1.TabIndex = 113
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'JudulFilm
        '
        Me.JudulFilm.Text = "Judul Film"
        Me.JudulFilm.Width = 126
        '
        'Studio
        '
        Me.Studio.Text = "Studio"
        '
        'Hari
        '
        Me.Hari.Text = "Hari"
        '
        'JamTayang
        '
        Me.JamTayang.Text = "Jam Tayang"
        Me.JamTayang.Width = 70
        '
        'NoKursi
        '
        Me.NoKursi.Text = "Kursi"
        Me.NoKursi.Width = 50
        '
        'Harga
        '
        Me.Harga.Text = "Harga"
        Me.Harga.Width = 70
        '
        'JumlahTiket
        '
        Me.JumlahTiket.Text = "Jumlah"
        Me.JumlahTiket.Width = 50
        '
        'Discount
        '
        Me.Discount.Text = "Disc"
        Me.Discount.Width = 50
        '
        'TotalBayar
        '
        Me.TotalBayar.Text = "Total Bayar"
        Me.TotalBayar.Width = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 25)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "History Transaksi"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 327)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 31)
        Me.Button1.TabIndex = 115
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Riwayat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 381)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Riwayat"
        Me.Text = "Riwayat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents JudulFilm As System.Windows.Forms.ColumnHeader
    Friend WithEvents Studio As System.Windows.Forms.ColumnHeader
    Friend WithEvents Hari As System.Windows.Forms.ColumnHeader
    Friend WithEvents JamTayang As System.Windows.Forms.ColumnHeader
    Friend WithEvents NoKursi As System.Windows.Forms.ColumnHeader
    Friend WithEvents Harga As System.Windows.Forms.ColumnHeader
    Friend WithEvents JumlahTiket As System.Windows.Forms.ColumnHeader
    Friend WithEvents Discount As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TotalBayar As System.Windows.Forms.ColumnHeader
End Class
