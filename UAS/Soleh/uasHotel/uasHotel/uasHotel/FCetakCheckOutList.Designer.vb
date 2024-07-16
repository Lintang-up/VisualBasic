<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCetakCheckOutList
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.transaksiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTransaksi = New uasHotel.DataSetTransaksi()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetRuangan = New uasHotel.DataSetRuangan()
        Me.ruanganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.transaksiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetRuangan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ruanganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'transaksiBindingSource
        '
        Me.transaksiBindingSource.DataMember = "transaksi"
        Me.transaksiBindingSource.DataSource = Me.DataSetTransaksi
        '
        'DataSetTransaksi
        '
        Me.DataSetTransaksi.DataSetName = "DataSetTransaksi"
        Me.DataSetTransaksi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSetCheckOutList"
        ReportDataSource2.Value = Me.transaksiBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "uasHotel.Report3.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(908, 520)
        Me.ReportViewer3.TabIndex = 0
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
        'FCetakCheckOutList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 520)
        Me.Controls.Add(Me.ReportViewer3)
        Me.Name = "FCetakCheckOutList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FCetakCheckOutList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.transaksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetRuangan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ruanganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents transaksiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetTransaksi As uasHotel.DataSetTransaksi
    Friend WithEvents ruanganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetRuangan As uasHotel.DataSetRuangan
End Class
