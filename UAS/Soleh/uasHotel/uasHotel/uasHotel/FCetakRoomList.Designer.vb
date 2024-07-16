<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCetakRoomList
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
        Me.ruanganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetRuangan = New uasHotel.DataSetRuangan()
        Me.ReportViewer4 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.ruanganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetRuangan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ruanganBindingSource
        '
        Me.ruanganBindingSource.DataMember = "ruangan"
        Me.ruanganBindingSource.DataSource = Me.DataSetRuangan
        '
        'DataSetRuangan
        '
        Me.DataSetRuangan.DataSetName = "DataSetRuangan"
        Me.DataSetRuangan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer4
        '
        Me.ReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetRuangan"
        ReportDataSource1.Value = Me.ruanganBindingSource
        Me.ReportViewer4.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer4.LocalReport.ReportEmbeddedResource = "uasHotel.Report4.rdlc"
        Me.ReportViewer4.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer4.Name = "ReportViewer4"
        Me.ReportViewer4.Size = New System.Drawing.Size(951, 539)
        Me.ReportViewer4.TabIndex = 0
        '
        'FCetakRoomList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 539)
        Me.Controls.Add(Me.ReportViewer4)
        Me.Name = "FCetakRoomList"
        Me.Text = "FCetakRoomList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ruanganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetRuangan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer4 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ruanganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetRuangan As uasHotel.DataSetRuangan
End Class
