﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelComprovante
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ComprovanteBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendasDataSet = New PDV.VendasDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ComprovanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprovanteTableAdapter = New PDV.VendasDataSetTableAdapters.ComprovanteTableAdapter()
        Me.ComprovanteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ComprovanteBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprovanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprovanteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComprovanteBindingSource2
        '
        Me.ComprovanteBindingSource2.DataMember = "Comprovante"
        Me.ComprovanteBindingSource2.DataSource = Me.VendasDataSet
        '
        'VendasDataSet
        '
        Me.VendasDataSet.DataSetName = "VendasDataSet"
        Me.VendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ComprovanteBindingSource2
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PDV.RelComprovante.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(671, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'ComprovanteBindingSource
        '
        Me.ComprovanteBindingSource.DataMember = "Comprovante"
        Me.ComprovanteBindingSource.DataSource = Me.VendasDataSet
        '
        'ComprovanteTableAdapter
        '
        Me.ComprovanteTableAdapter.ClearBeforeFill = True
        '
        'ComprovanteBindingSource1
        '
        Me.ComprovanteBindingSource1.DataMember = "Comprovante"
        Me.ComprovanteBindingSource1.DataSource = Me.VendasDataSet
        '
        'frmRelComprovante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(671, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelComprovante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprovante da Venda"
        CType(Me.ComprovanteBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprovanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprovanteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ComprovanteBindingSource As BindingSource
    Friend WithEvents VendasDataSet As VendasDataSet
    Friend WithEvents ComprovanteTableAdapter As VendasDataSetTableAdapters.ComprovanteTableAdapter
    Friend WithEvents ComprovanteBindingSource2 As BindingSource
    Friend WithEvents ComprovanteBindingSource1 As BindingSource
End Class
