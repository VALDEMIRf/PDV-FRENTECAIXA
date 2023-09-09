<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelVendaData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelVendaData))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ProdutosDataSet = New PDV.ProdutosDataSet()
        Me.QuantidadeVendidaDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuantidadeVendidaDataTableAdapter = New PDV.ProdutosDataSetTableAdapters.QuantidadeVendidaDataTableAdapter()
        Me.lblSair = New System.Windows.Forms.Label()
        Me.dtDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.lblDataFinal = New System.Windows.Forms.Label()
        Me.dtDataInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        CType(Me.ProdutosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantidadeVendidaDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.QuantidadeVendidaDataBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PDV.RelVendasData.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(22, 39)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(613, 574)
        Me.ReportViewer1.TabIndex = 0
        '
        'ProdutosDataSet
        '
        Me.ProdutosDataSet.DataSetName = "ProdutosDataSet"
        Me.ProdutosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuantidadeVendidaDataBindingSource
        '
        Me.QuantidadeVendidaDataBindingSource.DataMember = "QuantidadeVendidaData"
        Me.QuantidadeVendidaDataBindingSource.DataSource = Me.ProdutosDataSet
        '
        'QuantidadeVendidaDataTableAdapter
        '
        Me.QuantidadeVendidaDataTableAdapter.ClearBeforeFill = True
        '
        'lblSair
        '
        Me.lblSair.AutoSize = True
        Me.lblSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSair.Location = New System.Drawing.Point(18, 14)
        Me.lblSair.Name = "lblSair"
        Me.lblSair.Size = New System.Drawing.Size(37, 20)
        Me.lblSair.TabIndex = 142
        Me.lblSair.Text = "Sair"
        '
        'dtDataFinal
        '
        Me.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataFinal.Location = New System.Drawing.Point(440, 15)
        Me.dtDataFinal.Name = "dtDataFinal"
        Me.dtDataFinal.Size = New System.Drawing.Size(131, 20)
        Me.dtDataFinal.TabIndex = 141
        '
        'lblDataFinal
        '
        Me.lblDataFinal.AutoSize = True
        Me.lblDataFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataFinal.Location = New System.Drawing.Point(391, 15)
        Me.lblDataFinal.Name = "lblDataFinal"
        Me.lblDataFinal.Size = New System.Drawing.Size(43, 18)
        Me.lblDataFinal.TabIndex = 140
        Me.lblDataFinal.Text = "Final:"
        '
        'dtDataInicio
        '
        Me.dtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataInicio.Location = New System.Drawing.Point(234, 14)
        Me.dtDataInicio.Name = "dtDataInicio"
        Me.dtDataInicio.Size = New System.Drawing.Size(131, 20)
        Me.dtDataInicio.TabIndex = 138
        '
        'lblDataInicio
        '
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataInicio.Location = New System.Drawing.Point(182, 14)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(46, 18)
        Me.lblDataInicio.TabIndex = 139
        Me.lblDataInicio.Text = "Inicio:"
        '
        'frmRelVendaData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 617)
        Me.Controls.Add(Me.lblSair)
        Me.Controls.Add(Me.dtDataFinal)
        Me.Controls.Add(Me.lblDataFinal)
        Me.Controls.Add(Me.dtDataInicio)
        Me.Controls.Add(Me.lblDataInicio)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelVendaData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Vendas por Data"
        CType(Me.ProdutosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantidadeVendidaDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents QuantidadeVendidaDataBindingSource As BindingSource
    Friend WithEvents ProdutosDataSet As ProdutosDataSet
    Friend WithEvents QuantidadeVendidaDataTableAdapter As ProdutosDataSetTableAdapters.QuantidadeVendidaDataTableAdapter
    Friend WithEvents lblSair As Label
    Friend WithEvents dtDataFinal As DateTimePicker
    Friend WithEvents lblDataFinal As Label
    Friend WithEvents dtDataInicio As DateTimePicker
    Friend WithEvents lblDataInicio As Label
End Class
