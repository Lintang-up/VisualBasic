<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addRoom
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
        Me.dgvRoomListInAddRoom = New System.Windows.Forms.DataGridView()
        Me.idRuangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noRuangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipeRuangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlahHunian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbTipeRuangan = New System.Windows.Forms.ComboBox()
        Me.btSimpan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbJumlahHunian = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNoRuang = New System.Windows.Forms.TextBox()
        Me.btClear = New System.Windows.Forms.Button()
        Me.btHapus = New System.Windows.Forms.Button()
        CType(Me.dgvRoomListInAddRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(291, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 25)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Tambah Ruangan"
        '
        'dgvRoomListInAddRoom
        '
        Me.dgvRoomListInAddRoom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRoomListInAddRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRoomListInAddRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoomListInAddRoom.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idRuangan, Me.noRuangan, Me.tipeRuangan, Me.jumlahHunian, Me.status})
        Me.dgvRoomListInAddRoom.Location = New System.Drawing.Point(12, 186)
        Me.dgvRoomListInAddRoom.Name = "dgvRoomListInAddRoom"
        Me.dgvRoomListInAddRoom.RowHeadersVisible = False
        Me.dgvRoomListInAddRoom.RowTemplate.Height = 24
        Me.dgvRoomListInAddRoom.Size = New System.Drawing.Size(684, 355)
        Me.dgvRoomListInAddRoom.TabIndex = 28
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
        'cbTipeRuangan
        '
        Me.cbTipeRuangan.BackColor = System.Drawing.Color.White
        Me.cbTipeRuangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipeRuangan.FormattingEnabled = True
        Me.cbTipeRuangan.Items.AddRange(New Object() {"Single", "Double", "Deluxe", "Kids"})
        Me.cbTipeRuangan.Location = New System.Drawing.Point(183, 80)
        Me.cbTipeRuangan.Name = "cbTipeRuangan"
        Me.cbTipeRuangan.Size = New System.Drawing.Size(233, 28)
        Me.cbTipeRuangan.TabIndex = 38
        '
        'btSimpan
        '
        Me.btSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSimpan.Location = New System.Drawing.Point(244, 147)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(110, 33)
        Me.btSimpan.TabIndex = 39
        Me.btSimpan.Text = "Tambah"
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Jumlah Hunian"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Tipe Ruangan"
        '
        'tbJumlahHunian
        '
        Me.tbJumlahHunian.BackColor = System.Drawing.Color.White
        Me.tbJumlahHunian.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbJumlahHunian.Location = New System.Drawing.Point(183, 114)
        Me.tbJumlahHunian.Name = "tbJumlahHunian"
        Me.tbJumlahHunian.ReadOnly = True
        Me.tbJumlahHunian.Size = New System.Drawing.Size(233, 27)
        Me.tbJumlahHunian.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Nomor Ruangan"
        '
        'tbNoRuang
        '
        Me.tbNoRuang.BackColor = System.Drawing.Color.White
        Me.tbNoRuang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNoRuang.Location = New System.Drawing.Point(183, 47)
        Me.tbNoRuang.Name = "tbNoRuang"
        Me.tbNoRuang.ReadOnly = True
        Me.tbNoRuang.Size = New System.Drawing.Size(233, 27)
        Me.tbNoRuang.TabIndex = 36
        '
        'btClear
        '
        Me.btClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClear.Location = New System.Drawing.Point(128, 147)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(110, 33)
        Me.btClear.TabIndex = 43
        Me.btClear.Text = "Clear"
        Me.btClear.UseVisualStyleBackColor = True
        '
        'btHapus
        '
        Me.btHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHapus.Location = New System.Drawing.Point(12, 147)
        Me.btHapus.Name = "btHapus"
        Me.btHapus.Size = New System.Drawing.Size(110, 33)
        Me.btHapus.TabIndex = 43
        Me.btHapus.Text = "Hapus"
        Me.btHapus.UseVisualStyleBackColor = True
        '
        'addRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 553)
        Me.Controls.Add(Me.btHapus)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.cbTipeRuangan)
        Me.Controls.Add(Me.btSimpan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbJumlahHunian)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbNoRuang)
        Me.Controls.Add(Me.dgvRoomListInAddRoom)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "addRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addRoom"
        CType(Me.dgvRoomListInAddRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvRoomListInAddRoom As System.Windows.Forms.DataGridView
    Friend WithEvents idRuangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents noRuangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipeRuangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlahHunian As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbTipeRuangan As System.Windows.Forms.ComboBox
    Friend WithEvents btSimpan As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbJumlahHunian As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbNoRuang As System.Windows.Forms.TextBox
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btClear As System.Windows.Forms.Button
    Friend WithEvents btHapus As System.Windows.Forms.Button
End Class
