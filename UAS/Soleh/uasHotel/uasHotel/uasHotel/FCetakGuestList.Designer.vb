﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCetakGuestList
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
        Me.tamuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTamu = New uasHotel.DataSetTamu()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.tamuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTamu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tamuBindingSource
        '
        Me.tamuBindingSource.DataMember = "tamu"
        Me.tamuBindingSource.DataSource = Me.DataSetTamu
        '
        'DataSetTamu
        '
        Me.DataSetTamu.DataSetName = "DataSetTamu"
        Me.DataSetTamu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tamuBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "uasHotel.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1045, 535)
        Me.ReportViewer1.TabIndex = 0
        '
        'FCetakGuestList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 535)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FCetakGuestList"
        Me.Text = "FCetakGuestList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tamuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTamu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tamuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetTamu As uasHotel.DataSetTamu
End Class
