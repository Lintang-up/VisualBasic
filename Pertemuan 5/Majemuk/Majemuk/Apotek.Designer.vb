<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Apotek
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
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.beli = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.proses = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'jumlah
        '
        Me.jumlah.Location = New System.Drawing.Point(118, 131)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(279, 20)
        Me.jumlah.TabIndex = 0
        '
        'beli
        '
        Me.beli.FormattingEnabled = True
        Me.beli.Items.AddRange(New Object() {"Paracetamol ", "Paramex "})
        Me.beli.Location = New System.Drawing.Point(118, 71)
        Me.beli.Name = "beli"
        Me.beli.Size = New System.Drawing.Size(279, 21)
        Me.beli.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nama Obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "jumlah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(125, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apotek Gilang Sehat"
        '
        'proses
        '
        Me.proses.Location = New System.Drawing.Point(44, 206)
        Me.proses.Name = "proses"
        Me.proses.Size = New System.Drawing.Size(134, 56)
        Me.proses.TabIndex = 5
        Me.proses.Text = "Proses"
        Me.proses.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(244, 206)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 56)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Apotek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 300)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.proses)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.beli)
        Me.Controls.Add(Me.jumlah)
        Me.Name = "Apotek"
        Me.Text = "Majemuk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents jumlah As System.Windows.Forms.TextBox
    Friend WithEvents beli As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents proses As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
