<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelEstoque
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.EstoquePorDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.estoquesDataSet = New PDV.estoquesDataSet()
        Me.BuscarEntradasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarSaidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarEntradasSaidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSair = New System.Windows.Forms.Label()
        Me.dtDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.lblDataFinal = New System.Windows.Forms.Label()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        Me.dtDataInicio = New System.Windows.Forms.DateTimePicker()
        Me.cbEntrada = New System.Windows.Forms.ComboBox()
        Me.rbData = New System.Windows.Forms.RadioButton()
        Me.rbEntrada = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EstoquePorDataTableAdapter = New PDV.estoquesDataSetTableAdapters.EstoquePorDataTableAdapter()
        Me.EstoquePorDataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarEntradasTableAdapter = New PDV.estoquesDataSetTableAdapters.BuscarEntradasTableAdapter()
        Me.BuscarSaidasTableAdapter = New PDV.estoquesDataSetTableAdapters.BuscarSaidasTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BuscarEntradasSaidasTableAdapter = New PDV.estoquesDataSetTableAdapters.BuscarEntradasSaidasTableAdapter()
        CType(Me.EstoquePorDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estoquesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarEntradasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarSaidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarEntradasSaidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EstoquePorDataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EstoquePorDataBindingSource
        '
        Me.EstoquePorDataBindingSource.DataMember = "EstoquePorData"
        Me.EstoquePorDataBindingSource.DataSource = Me.estoquesDataSet
        '
        'estoquesDataSet
        '
        Me.estoquesDataSet.DataSetName = "estoquesDataSet"
        Me.estoquesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuscarEntradasBindingSource
        '
        Me.BuscarEntradasBindingSource.DataMember = "BuscarEntradas"
        Me.BuscarEntradasBindingSource.DataSource = Me.estoquesDataSet
        '
        'BuscarSaidasBindingSource
        '
        Me.BuscarSaidasBindingSource.DataMember = "BuscarSaidas"
        Me.BuscarSaidasBindingSource.DataSource = Me.estoquesDataSet
        '
        'BuscarEntradasSaidasBindingSource
        '
        Me.BuscarEntradasSaidasBindingSource.DataMember = "BuscarEntradasSaidas"
        Me.BuscarEntradasSaidasBindingSource.DataSource = Me.estoquesDataSet
        '
        'lblSair
        '
        Me.lblSair.AutoSize = True
        Me.lblSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSair.Location = New System.Drawing.Point(17, 24)
        Me.lblSair.Name = "lblSair"
        Me.lblSair.Size = New System.Drawing.Size(37, 20)
        Me.lblSair.TabIndex = 132
        Me.lblSair.Text = "Sair"
        '
        'dtDataFinal
        '
        Me.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataFinal.Location = New System.Drawing.Point(311, 62)
        Me.dtDataFinal.Name = "dtDataFinal"
        Me.dtDataFinal.Size = New System.Drawing.Size(131, 26)
        Me.dtDataFinal.TabIndex = 131
        '
        'lblDataFinal
        '
        Me.lblDataFinal.AutoSize = True
        Me.lblDataFinal.Location = New System.Drawing.Point(254, 67)
        Me.lblDataFinal.Name = "lblDataFinal"
        Me.lblDataFinal.Size = New System.Drawing.Size(53, 20)
        Me.lblDataFinal.TabIndex = 130
        Me.lblDataFinal.Text = "Final:"
        '
        'lblDataInicio
        '
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.Location = New System.Drawing.Point(250, 34)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(57, 20)
        Me.lblDataInicio.TabIndex = 129
        Me.lblDataInicio.Text = "Inicio:"
        '
        'dtDataInicio
        '
        Me.dtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataInicio.Location = New System.Drawing.Point(313, 29)
        Me.dtDataInicio.Name = "dtDataInicio"
        Me.dtDataInicio.Size = New System.Drawing.Size(131, 26)
        Me.dtDataInicio.TabIndex = 128
        '
        'cbEntrada
        '
        Me.cbEntrada.FormattingEnabled = True
        Me.cbEntrada.Items.AddRange(New Object() {"Entrada", "Saída"})
        Me.cbEntrada.Location = New System.Drawing.Point(311, 94)
        Me.cbEntrada.Name = "cbEntrada"
        Me.cbEntrada.Size = New System.Drawing.Size(129, 28)
        Me.cbEntrada.TabIndex = 127
        '
        'rbData
        '
        Me.rbData.AutoSize = True
        Me.rbData.Location = New System.Drawing.Point(173, 49)
        Me.rbData.Name = "rbData"
        Me.rbData.Size = New System.Drawing.Size(66, 24)
        Me.rbData.TabIndex = 126
        Me.rbData.TabStop = True
        Me.rbData.Text = "Data"
        Me.rbData.UseVisualStyleBackColor = True
        '
        'rbEntrada
        '
        Me.rbEntrada.AutoSize = True
        Me.rbEntrada.Location = New System.Drawing.Point(4, 49)
        Me.rbEntrada.Name = "rbEntrada"
        Me.rbEntrada.Size = New System.Drawing.Size(152, 24)
        Me.rbEntrada.TabIndex = 125
        Me.rbEntrada.TabStop = True
        Me.rbEntrada.Text = "Entrada / Saída"
        Me.rbEntrada.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbEntrada)
        Me.GroupBox1.Controls.Add(Me.cbEntrada)
        Me.GroupBox1.Controls.Add(Me.dtDataFinal)
        Me.GroupBox1.Controls.Add(Me.rbData)
        Me.GroupBox1.Controls.Add(Me.lblDataFinal)
        Me.GroupBox1.Controls.Add(Me.dtDataInicio)
        Me.GroupBox1.Controls.Add(Me.lblDataInicio)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(254, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 133)
        Me.GroupBox1.TabIndex = 133
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Métodos de Pesquisa"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.EstoquePorDataBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.BuscarEntradasBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.BuscarSaidasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PDV.RelEstoquePorDatas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(8, 151)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(688, 401)
        Me.ReportViewer1.TabIndex = 134
        '
        'EstoquePorDataTableAdapter
        '
        Me.EstoquePorDataTableAdapter.ClearBeforeFill = True
        '
        'EstoquePorDataBindingSource1
        '
        Me.EstoquePorDataBindingSource1.DataMember = "EstoquePorData"
        Me.EstoquePorDataBindingSource1.DataSource = Me.estoquesDataSet
        '
        'BuscarEntradasTableAdapter
        '
        Me.BuscarEntradasTableAdapter.ClearBeforeFill = True
        '
        'BuscarSaidasTableAdapter
        '
        Me.BuscarSaidasTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.DocumentMapWidth = 49
        ReportDataSource4.Name = "DataSet1"
        ReportDataSource4.Value = Me.BuscarEntradasSaidasBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "PDV.RelEntradaSaida.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(8, 151)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(686, 401)
        Me.ReportViewer2.TabIndex = 135
        '
        'BuscarEntradasSaidasTableAdapter
        '
        Me.BuscarEntradasSaidasTableAdapter.ClearBeforeFill = True
        '
        'frmRelEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(712, 553)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblSair)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Entradas e Saídas"
        CType(Me.EstoquePorDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estoquesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarEntradasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarSaidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarEntradasSaidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EstoquePorDataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSair As Label
    Friend WithEvents dtDataFinal As DateTimePicker
    Friend WithEvents lblDataFinal As Label
    Friend WithEvents lblDataInicio As Label
    Friend WithEvents dtDataInicio As DateTimePicker
    Friend WithEvents cbEntrada As ComboBox
    Friend WithEvents rbData As RadioButton
    Friend WithEvents rbEntrada As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EstoquePorDataBindingSource As BindingSource
    Friend WithEvents estoquesDataSet As estoquesDataSet
    Friend WithEvents EstoquePorDataTableAdapter As estoquesDataSetTableAdapters.EstoquePorDataTableAdapter
    Friend WithEvents EstoquePorDataBindingSource1 As BindingSource
    Friend WithEvents BuscarEntradasBindingSource As BindingSource
    Friend WithEvents BuscarSaidasBindingSource As BindingSource
    Friend WithEvents BuscarEntradasTableAdapter As estoquesDataSetTableAdapters.BuscarEntradasTableAdapter
    Friend WithEvents BuscarSaidasTableAdapter As estoquesDataSetTableAdapters.BuscarSaidasTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BuscarEntradasSaidasBindingSource As BindingSource
    Friend WithEvents BuscarEntradasSaidasTableAdapter As estoquesDataSetTableAdapters.BuscarEntradasSaidasTableAdapter
End Class
