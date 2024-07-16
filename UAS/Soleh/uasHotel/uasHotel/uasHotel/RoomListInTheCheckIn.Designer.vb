<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomListInTheCheckIn
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
        CType(Me.dgvRoomListInTheCheckIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRoomListInTheCheckIn
        '
        Me.dgvRoomListInTheCheckIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRoomListInTheCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoomListInTheCheckIn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idRuangan, Me.noRuangan, Me.tipeRuangan, Me.jumlahHunian})
        Me.dgvRoomListInTheCheckIn.Location = New System.Drawing.Point(12, 12)
        Me.dgvRoomListInTheCheckIn.Name = "dgvRoomListInTheCheckIn"
        Me.dgvRoomListInTheCheckIn.RowTemplate.Height = 24
        Me.dgvRoomListInTheCheckIn.Size = New System.Drawing.Size(643, 424)
        Me.dgvRoomListInTheCheckIn.TabIndex = 0
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
        'RoomListInTheCheckIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 448)
        Me.Controls.Add(Me.dgvRoomListInTheCheckIn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "RoomListInTheCheckIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Click To Select Room"
        CType(Me.dgvRoomListInTheCheckIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvRoomListInTheCheckIn As System.Windows.Forms.DataGridView
    Friend WithEvents idRuangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents noRuangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipeRuangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlahHunian As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
