<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class roomList
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
        Me.dgvRoomListInTheCheckIn = New System.Windows.Forms.DataGridView()
        Me.idRuangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noRuangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipeRuangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlahHunian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btCetak = New System.Windows.Forms.Button()
        CType(Me.dgvRoomListInTheCheckIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRoomListInTheCheckIn
        '
        Me.dgvRoomListInTheCheckIn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRoomListInTheCheckIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRoomListInTheCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoomListInTheCheckIn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idRuangan, Me.noRuangan, Me.tipeRuangan, Me.jumlahHunian, Me.status})
        Me.dgvRoomListInTheCheckIn.Location = New System.Drawing.Point(12, 37)
        Me.dgvRoomListInTheCheckIn.Name = "dgvRoomListInTheCheckIn"
        Me.dgvRoomListInTheCheckIn.RowHeadersVisible = False
        Me.dgvRoomListInTheCheckIn.RowTemplate.Height = 24
        Me.dgvRoomListInTheCheckIn.Size = New System.Drawing.Size(763, 411)
        Me.dgvRoomListInTheCheckIn.TabIndex = 1
        '
        'idRuangan
        '
        Me.idRuangan.HeaderText = "ID Ruangan"
        Me.idRuangan.Name = "idRuangan"
        '
        'noRuangan
        '
        Me.noRuangan.HeaderText = "Nomor Ruangan"
        Me.noRuangan.Name = "noRuangan"
        '
        'tipeRuangan
        '
        Me.tipeRuangan.HeaderText = "Tipe Ruangan"
        Me.tipeRuangan.Name = "tipeRuangan"
        '
        'jumlahHunian
        '
        Me.jumlahHunian.HeaderText = "Jumlah Hunian"
        Me.jumlahHunian.Name = "jumlahHunian"
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(294, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Daftar Room"
        '
        'btCetak
        '
        Me.btCetak.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCetak.Location = New System.Drawing.Point(12, 454)
        Me.btCetak.Name = "btCetak"
        Me.btCetak.Size = New System.Drawing.Size(110, 33)
        Me.btCetak.TabIndex = 135
        Me.btCetak.Text = "Cetak"
        Me.btCetak.UseVisualStyleBackColor = True
        '
        'roomList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 499)
        Me.Controls.Add(Me.btCetak)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvRoomListInTheCheckIn)
        Me.Name = "roomList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "roomList"
        CType(Me.dgvRoomListInTheCheckIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvRoomListInTheCheckIn As System.Windows.Forms.DataGridView
    Friend WithEvents idRuangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents noRuangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipeRuangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlahHunian As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btCetak As System.Windows.Forms.Button
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
