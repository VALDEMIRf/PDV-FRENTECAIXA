<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelVendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelVendas))
        Me.ListadeVendasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendasDataSet = New PDV.VendasDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dtData = New System.Windows.Forms.DateTimePicker()
        Me.cbFuncionario = New System.Windows.Forms.ComboBox()
        Me.ListadeVendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListadeVendasTableAdapter = New PDV.VendasDataSetTableAdapters.ListadeVendasTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ListadeVendasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadeVendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListadeVendasBindingSource1
        '
        Me.ListadeVendasBindingSource1.DataMember = "ListadeVendas"
        Me.ListadeVendasBindingSource1.DataSource = Me.VendasDataSet
        '
        'VendasDataSet
        '
        Me.VendasDataSet.DataSetName = "VendasDataSet"
        Me.VendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ListadeVendasBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PDV.RelVendas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 41)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(816, 369)
        Me.ReportViewer1.TabIndex = 0
        '
        'dtData
        '
        Me.dtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtData.Location = New System.Drawing.Point(689, 12)
        Me.dtData.Name = "dtData"
        Me.dtData.Size = New System.Drawing.Size(99, 20)
        Me.dtData.TabIndex = 1
        '
        'cbFuncionario
        '
        Me.cbFuncionario.FormattingEnabled = True
        Me.cbFuncionario.Location = New System.Drawing.Point(526, 11)
        Me.cbFuncionario.Name = "cbFuncionario"
        Me.cbFuncionario.Size = New System.Drawing.Size(121, 21)
        Me.cbFuncionario.TabIndex = 2
        '
        'ListadeVendasBindingSource
        '
        Me.ListadeVendasBindingSource.DataMember = "ListadeVendas"
        Me.ListadeVendasBindingSource.DataSource = Me.VendasDataSet
        '
        'ListadeVendasTableAdapter
        '
        Me.ListadeVendasTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(436, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Funcionario:"
        '
        'frmRelVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(821, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbFuncionario)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendas por Data"
        CType(Me.ListadeVendasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadeVendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ListadeVendasBindingSource As BindingSource
    Friend WithEvents VendasDataSet As VendasDataSet
    Friend WithEvents ListadeVendasTableAdapter As VendasDataSetTableAdapters.ListadeVendasTableAdapter
    Friend WithEvents ListadeVendasBindingSource1 As BindingSource
    Friend WithEvents dtData As DateTimePicker
    Friend WithEvents cbFuncionario As ComboBox
    Friend WithEvents Label1 As Label
End Class
