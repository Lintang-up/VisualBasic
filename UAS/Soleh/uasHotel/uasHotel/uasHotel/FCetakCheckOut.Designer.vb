<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCetakCheckOut
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
        Me.rvCetakCheckOut = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.relasiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetStruk = New uasHotel.DataSetStruk()
        Me.relasiTableAdapter = New uasHotel.DataSetStrukTableAdapters.relasiTableAdapter()
        CType(Me.relasiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetStruk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rvCetakCheckOut
        '
        Me.rvCetakCheckOut.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetCetakCheckOut"
        ReportDataSource1.Value = Me.relasiBindingSource
        Me.rvCetakCheckOut.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvCetakCheckOut.LocalReport.ReportEmbeddedResource = "uasHotel.Report6.rdlc"
        Me.rvCetakCheckOut.Location = New System.Drawing.Point(0, 0)
        Me.rvCetakCheckOut.Name = "rvCetakCheckOut"
        Me.rvCetakCheckOut.Size = New System.Drawing.Size(708, 468)
        Me.rvCetakCheckOut.TabIndex = 0
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
        'relasiTableAdapter
        '
        Me.relasiTableAdapter.ClearBeforeFill = True
        '
        'FCetakStrukCheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 468)
        Me.Controls.Add(Me.rvCetakCheckOut)
        Me.Name = "FCetakStrukCheckOut"
        Me.Text = "FCetakStrukCheckOut"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.relasiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetStruk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvCetakCheckOut As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents relasiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetStruk As uasHotel.DataSetStruk
    Friend WithEvents relasiTableAdapter As uasHotel.DataSetStrukTableAdapters.relasiTableAdapter
End Class
