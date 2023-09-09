<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRelProdutosVendidos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelProdutosVendidos))
        Me.QuantidadeVendidaDataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutosDataSet = New PDV.ProdutosDataSet()
        Me.dtDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.lblDataFinal = New System.Windows.Forms.Label()
        Me.dtDataInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        Me.lblSair = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbProdutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbProdutosTableAdapter = New PDV.ProdutosDataSetTableAdapters.tbProdutosTableAdapter()
        Me.QuantidadeVendidaDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuantidadeVendidaDataTableAdapter = New PDV.ProdutosDataSetTableAdapters.QuantidadeVendidaDataTableAdapter()
        CType(Me.QuantidadeVendidaDataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantidadeVendidaDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuantidadeVendidaDataBindingSource1
        '
        Me.QuantidadeVendidaDataBindingSource1.DataMember = "QuantidadeVendidaData"
        Me.QuantidadeVendidaDataBindingSource1.DataSource = Me.ProdutosDataSet
        '
        'ProdutosDataSet
        '
        Me.ProdutosDataSet.DataSetName = "ProdutosDataSet"
        Me.ProdutosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtDataFinal
        '
        Me.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataFinal.Location = New System.Drawing.Point(492, 13)
        Me.dtDataFinal.Name = "dtDataFinal"
        Me.dtDataFinal.Size = New System.Drawing.Size(131, 20)
        Me.dtDataFinal.TabIndex = 135
        '
        'lblDataFinal
        '
        Me.lblDataFinal.AutoSize = True
        Me.lblDataFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataFinal.Location = New System.Drawing.Point(443, 13)
        Me.lblDataFinal.Name = "lblDataFinal"
        Me.lblDataFinal.Size = New System.Drawing.Size(43, 18)
        Me.lblDataFinal.TabIndex = 134
        Me.lblDataFinal.Text = "Final:"
        '
        'dtDataInicio
        '
        Me.dtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataInicio.Location = New System.Drawing.Point(286, 12)
        Me.dtDataInicio.Name = "dtDataInicio"
        Me.dtDataInicio.Size = New System.Drawing.Size(131, 20)
        Me.dtDataInicio.TabIndex = 132
        '
        'lblDataInicio
        '
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataInicio.Location = New System.Drawing.Point(234, 12)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(46, 18)
        Me.lblDataInicio.TabIndex = 133
        Me.lblDataInicio.Text = "Inicio:"
        '
        'lblSair
        '
        Me.lblSair.AutoSize = True
        Me.lblSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSair.Location = New System.Drawing.Point(12, 14)
        Me.lblSair.Name = "lblSair"
        Me.lblSair.Size = New System.Drawing.Size(37, 20)
        Me.lblSair.TabIndex = 137
        Me.lblSair.Text = "Sair"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.QuantidadeVendidaDataBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PDV.RelProdutosVendidos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(9, 39)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(625, 575)
        Me.ReportViewer1.TabIndex = 138
        '
        'tbProdutosBindingSource
        '
        Me.tbProdutosBindingSource.DataMember = "tbProdutos"
        Me.tbProdutosBindingSource.DataSource = Me.ProdutosDataSet
        '
        'tbProdutosTableAdapter
        '
        Me.tbProdutosTableAdapter.ClearBeforeFill = True
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
        'frmRelProdutosVendidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(641, 617)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.lblSair)
        Me.Controls.Add(Me.dtDataFinal)
        Me.Controls.Add(Me.lblDataFinal)
        Me.Controls.Add(Me.dtDataInicio)
        Me.Controls.Add(Me.lblDataInicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelProdutosVendidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produtos mais Vendidos"
        CType(Me.QuantidadeVendidaDataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantidadeVendidaDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtDataFinal As DateTimePicker
    Friend WithEvents lblDataFinal As Label
    Friend WithEvents dtDataInicio As DateTimePicker
    Friend WithEvents lblDataInicio As Label
    Friend WithEvents tbProdutosBindingSource As BindingSource
    Friend WithEvents ProdutosDataSet As ProdutosDataSet
    Friend WithEvents tbProdutosTableAdapter As ProdutosDataSetTableAdapters.tbProdutosTableAdapter
    Friend WithEvents lblSair As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents QuantidadeVendidaDataBindingSource As BindingSource
    Friend WithEvents QuantidadeVendidaDataTableAdapter As ProdutosDataSetTableAdapters.QuantidadeVendidaDataTableAdapter
    Friend WithEvents QuantidadeVendidaDataBindingSource1 As BindingSource
End Class
