<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelCaixa
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFunc = New System.Windows.Forms.ComboBox()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CaixaDataSet = New PDV.caixaDataSet()
        Me.TbCaixaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbCaixaTableAdapter = New PDV.caixaDataSetTableAdapters.tbCaixaTableAdapter()
        Me.VendasDataSet = New PDV.VendasDataSet()
        Me.ListadeVendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListadeVendasTableAdapter = New PDV.VendasDataSetTableAdapters.ListadeVendasTableAdapter()
        CType(Me.CaixaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCaixaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadeVendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Funcionário:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(497, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Data:"
        '
        'cbFunc
        '
        Me.cbFunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFunc.FormattingEnabled = True
        Me.cbFunc.Location = New System.Drawing.Point(357, 10)
        Me.cbFunc.Name = "cbFunc"
        Me.cbFunc.Size = New System.Drawing.Size(121, 26)
        Me.cbFunc.TabIndex = 2
        '
        'dt
        '
        Me.dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt.Location = New System.Drawing.Point(546, 12)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(96, 24)
        Me.dt.TabIndex = 3
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TbCaixaBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.ListadeVendasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PDV.RelCaixa.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 41)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(816, 464)
        Me.ReportViewer1.TabIndex = 4
        '
        'CaixaDataSet
        '
        Me.CaixaDataSet.DataSetName = "caixaDataSet"
        Me.CaixaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbCaixaBindingSource
        '
        Me.TbCaixaBindingSource.DataMember = "tbCaixa"
        Me.TbCaixaBindingSource.DataSource = Me.CaixaDataSet
        '
        'TbCaixaTableAdapter
        '
        Me.TbCaixaTableAdapter.ClearBeforeFill = True
        '
        'VendasDataSet
        '
        Me.VendasDataSet.DataSetName = "VendasDataSet"
        Me.VendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'frmRelCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(833, 517)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.cbFunc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório Final de Caixa"
        CType(Me.CaixaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCaixaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadeVendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbFunc As ComboBox
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TbCaixaBindingSource As BindingSource
    Friend WithEvents CaixaDataSet As caixaDataSet
    Friend WithEvents TbCaixaTableAdapter As caixaDataSetTableAdapters.tbCaixaTableAdapter
    Friend WithEvents ListadeVendasBindingSource As BindingSource
    Friend WithEvents VendasDataSet As VendasDataSet
    Friend WithEvents ListadeVendasTableAdapter As VendasDataSetTableAdapters.ListadeVendasTableAdapter
End Class
