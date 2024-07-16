<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCetakCheckIn
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.relasiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetStruk = New uasHotel.DataSetStruk()
        Me.rvCetakCheckIn = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.relasiTableAdapter = New uasHotel.DataSetStrukTableAdapters.relasiTableAdapter()
        Me.DataSetRuangan = New uasHotel.DataSetRuangan()
        Me.ruanganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.relasiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetStruk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetRuangan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ruanganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'relasiBindingSource
        '
        Me.relasiBindingSource.DataMember = "relasi"
        Me.relasiBindingSource.DataSource = Me.DataSetStruk
        '
        'DataSetStruk
        '
        Me.DataSetStruk.DataSetName = "DataSetStruk"
        Me.DataSetStruk.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rvCetakCheckIn
        '
        Me.rvCetakCheckIn.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetStrukCheckIn"
        ReportDataSource1.Value = Me.relasiBindingSource
        Me.rvCetakCheckIn.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvCetakCheckIn.LocalReport.ReportEmbeddedResource = "uasHotel.Report5.rdlc"
        Me.rvCetakCheckIn.Location = New System.Drawing.Point(0, 0)
        Me.rvCetakCheckIn.Name = "rvCetakCheckIn"
        Me.rvCetakCheckIn.Size = New System.Drawing.Size(786, 509)
        Me.rvCetakCheckIn.TabIndex = 0
        '
        'relasiTableAdapter
        '
        Me.relasiTableAdapter.ClearBeforeFill = True
        '
        'DataSetRuangan
        '
        Me.DataSetRuangan.DataSetName = "DataSetRuangan"
        Me.DataSetRuangan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ruanganBindingSource
        '
        Me.ruanganBindingSource.DataMember = "ruangan"
        Me.ruanganBindingSource.DataSource = Me.DataSetRuangan
        '
        'FCetakCheckIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 509)
        Me.Controls.Add(Me.rvCetakCheckIn)
        Me.Name = "FCetakCheckIn"
        Me.Text = "FCetakCheckIn"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.relasiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetStruk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetRuangan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ruanganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvCetakCheckIn As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents relasiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetStruk As uasHotel.DataSetStruk
    Friend WithEvents relasiTableAdapter As uasHotel.DataSetStrukTableAdapters.relasiTableAdapter
    Friend WithEvents ruanganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetRuangan As uasHotel.DataSetRuangan
End Class
