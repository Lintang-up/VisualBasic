<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PemilihanCase
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.oke = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.nilai = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input Nilai Siswa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama MHS"
        '
        'oke
        '
        Me.oke.Location = New System.Drawing.Point(44, 230)
        Me.oke.Name = "oke"
        Me.oke.Size = New System.Drawing.Size(157, 41)
        Me.oke.TabIndex = 3
        Me.oke.Text = "Proses Nilai"
        Me.oke.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(323, 230)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 41)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(186, 93)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(282, 20)
        Me.nama.TabIndex = 5
        '
        'nilai
        '
        Me.nilai.Location = New System.Drawing.Point(186, 152)
        Me.nilai.Name = "nilai"
        Me.nilai.Size = New System.Drawing.Size(282, 20)
        Me.nilai.TabIndex = 6
        '
        'PemilihanCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 316)
        Me.Controls.Add(Me.nilai)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.oke)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PemilihanCase"
        Me.Text = "PemilihanCase"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents oke As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents nilai As System.Windows.Forms.TextBox
End Class
