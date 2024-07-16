<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class data_obat
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
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.kodeobat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaobat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apoteker_k = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.apoteker = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nambat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.kobat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv2
        '
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodeobat, Me.namaobat, Me.apoteker_k})
        Me.dgv2.Location = New System.Drawing.Point(9, 22)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.Size = New System.Drawing.Size(534, 97)
        Me.dgv2.TabIndex = 0
        '
        'kodeobat
        '
        Me.kodeobat.HeaderText = "Kode Obat"
        Me.kodeobat.Name = "kodeobat"
        '
        'namaobat
        '
        Me.namaobat.HeaderText = "Nama Obat"
        Me.namaobat.Name = "namaobat"
        '
        'apoteker_k
        '
        Me.apoteker_k.HeaderText = "Apoteker"
        Me.apoteker_k.Name = "apoteker_k"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv2)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 257)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 135)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kesimpulan"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(358, 200)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 43)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(249, 200)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 43)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "New"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(469, 200)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 43)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(140, 200)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 43)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Apply"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 43)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'apoteker
        '
        Me.apoteker.Location = New System.Drawing.Point(126, 165)
        Me.apoteker.Name = "apoteker"
        Me.apoteker.Size = New System.Drawing.Size(429, 20)
        Me.apoteker.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Apoteker"
        '
        'nambat
        '
        Me.nambat.Location = New System.Drawing.Point(126, 125)
        Me.nambat.Name = "nambat"
        Me.nambat.Size = New System.Drawing.Size(429, 20)
        Me.nambat.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nama Obat"
        '
        'kobat
        '
        Me.kobat.Location = New System.Drawing.Point(126, 83)
        Me.kobat.Name = "kobat"
        Me.kobat.Size = New System.Drawing.Size(429, 20)
        Me.kobat.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Kode Obat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Data Obat"
        '
        'data_obat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 409)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.apoteker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nambat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.kobat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "data_obat"
        Me.Text = "data_obat"
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents apoteker As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nambat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents kobat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents kodeobat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namaobat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apoteker_k As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
