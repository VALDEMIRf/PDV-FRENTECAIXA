<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnEstoqueConsulta
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
        Me.rbData = New System.Windows.Forms.RadioButton()
        Me.rbEntrada = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.lblDataFinal = New System.Windows.Forms.Label()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        Me.dtDataInicio = New System.Windows.Forms.DateTimePicker()
        Me.cbEntrada = New System.Windows.Forms.ComboBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.lblSair = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbData
        '
        Me.rbData.AutoSize = True
        Me.rbData.Location = New System.Drawing.Point(340, 13)
        Me.rbData.Name = "rbData"
        Me.rbData.Size = New System.Drawing.Size(56, 21)
        Me.rbData.TabIndex = 114
        Me.rbData.TabStop = True
        Me.rbData.Text = "Data"
        Me.rbData.UseVisualStyleBackColor = True
        '
        'rbEntrada
        '
        Me.rbEntrada.AutoSize = True
        Me.rbEntrada.Location = New System.Drawing.Point(209, 13)
        Me.rbEntrada.Name = "rbEntrada"
        Me.rbEntrada.Size = New System.Drawing.Size(124, 21)
        Me.rbEntrada.TabIndex = 113
        Me.rbEntrada.TabStop = True
        Me.rbEntrada.Text = "Entrada / Saída"
        Me.rbEntrada.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Buscar:"
        '
        'dtDataFinal
        '
        Me.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataFinal.Location = New System.Drawing.Point(460, 44)
        Me.dtDataFinal.Name = "dtDataFinal"
        Me.dtDataFinal.Size = New System.Drawing.Size(131, 23)
        Me.dtDataFinal.TabIndex = 121
        '
        'lblDataFinal
        '
        Me.lblDataFinal.AutoSize = True
        Me.lblDataFinal.Location = New System.Drawing.Point(414, 47)
        Me.lblDataFinal.Name = "lblDataFinal"
        Me.lblDataFinal.Size = New System.Drawing.Size(42, 17)
        Me.lblDataFinal.TabIndex = 120
        Me.lblDataFinal.Text = "Final:"
        '
        'lblDataInicio
        '
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.Location = New System.Drawing.Point(413, 14)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(44, 17)
        Me.lblDataInicio.TabIndex = 119
        Me.lblDataInicio.Text = "Inicio:"
        '
        'dtDataInicio
        '
        Me.dtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataInicio.Location = New System.Drawing.Point(460, 11)
        Me.dtDataInicio.Name = "dtDataInicio"
        Me.dtDataInicio.Size = New System.Drawing.Size(131, 23)
        Me.dtDataInicio.TabIndex = 118
        '
        'cbEntrada
        '
        Me.cbEntrada.FormattingEnabled = True
        Me.cbEntrada.Items.AddRange(New Object() {"Entrada", "Saída"})
        Me.cbEntrada.Location = New System.Drawing.Point(462, 12)
        Me.cbEntrada.Name = "cbEntrada"
        Me.cbEntrada.Size = New System.Drawing.Size(129, 24)
        Me.cbEntrada.TabIndex = 117
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(12, 73)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(579, 209)
        Me.dg.TabIndex = 122
        '
        'lblSair
        '
        Me.lblSair.AutoSize = True
        Me.lblSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSair.Location = New System.Drawing.Point(12, 15)
        Me.lblSair.Name = "lblSair"
        Me.lblSair.Size = New System.Drawing.Size(33, 17)
        Me.lblSair.TabIndex = 123
        Me.lblSair.Text = "Sair"
        '
        'frnEstoqueConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(609, 294)
        Me.Controls.Add(Me.lblSair)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.dtDataFinal)
        Me.Controls.Add(Me.lblDataFinal)
        Me.Controls.Add(Me.lblDataInicio)
        Me.Controls.Add(Me.dtDataInicio)
        Me.Controls.Add(Me.cbEntrada)
        Me.Controls.Add(Me.rbData)
        Me.Controls.Add(Me.rbEntrada)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frnEstoqueConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas de Estoque"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbData As RadioButton
    Friend WithEvents rbEntrada As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents dtDataFinal As DateTimePicker
    Friend WithEvents lblDataFinal As Label
    Friend WithEvents lblDataInicio As Label
    Friend WithEvents dtDataInicio As DateTimePicker
    Friend WithEvents cbEntrada As ComboBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents lblSair As Label
End Class
