<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarVendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListarVendas))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtData = New System.Windows.Forms.DateTimePicker()
        Me.rbData = New System.Windows.Forms.RadioButton()
        Me.rbFuncionario = New System.Windows.Forms.RadioButton()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbFuncionario = New System.Windows.Forms.ComboBox()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.lblSair = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(259, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(327, 40)
        Me.Label2.TabIndex = 183
        Me.Label2.Text = "LISTA DE VENDAS "
        '
        'dtData
        '
        Me.dtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtData.Location = New System.Drawing.Point(355, 60)
        Me.dtData.Name = "dtData"
        Me.dtData.Size = New System.Drawing.Size(157, 20)
        Me.dtData.TabIndex = 182
        '
        'rbData
        '
        Me.rbData.AutoSize = True
        Me.rbData.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbData.ForeColor = System.Drawing.Color.Black
        Me.rbData.Location = New System.Drawing.Point(288, 58)
        Me.rbData.Name = "rbData"
        Me.rbData.Size = New System.Drawing.Size(57, 22)
        Me.rbData.TabIndex = 181
        Me.rbData.TabStop = True
        Me.rbData.Text = "Data"
        Me.rbData.UseVisualStyleBackColor = True
        '
        'rbFuncionario
        '
        Me.rbFuncionario.AutoSize = True
        Me.rbFuncionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFuncionario.ForeColor = System.Drawing.Color.Black
        Me.rbFuncionario.Location = New System.Drawing.Point(178, 57)
        Me.rbFuncionario.Name = "rbFuncionario"
        Me.rbFuncionario.Size = New System.Drawing.Size(104, 22)
        Me.rbFuncionario.TabIndex = 180
        Me.rbFuncionario.TabStop = True
        Me.rbFuncionario.Text = "Funcionario"
        Me.rbFuncionario.UseVisualStyleBackColor = True
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCliente.ForeColor = System.Drawing.Color.Black
        Me.rbCliente.Location = New System.Drawing.Point(100, 56)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(71, 22)
        Me.rbCliente.TabIndex = 179
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        Me.rbCliente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "Buscar:"
        '
        'cbFuncionario
        '
        Me.cbFuncionario.FormattingEnabled = True
        Me.cbFuncionario.Location = New System.Drawing.Point(355, 60)
        Me.cbFuncionario.Name = "cbFuncionario"
        Me.cbFuncionario.Size = New System.Drawing.Size(157, 21)
        Me.cbFuncionario.TabIndex = 177
        '
        'cbCliente
        '
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(355, 59)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(157, 21)
        Me.cbCliente.TabIndex = 176
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dg.Location = New System.Drawing.Point(9, 90)
        Me.dg.Margin = New System.Windows.Forms.Padding(6)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(887, 349)
        Me.dg.TabIndex = 184
        '
        'lblSair
        '
        Me.lblSair.AutoSize = True
        Me.lblSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSair.ForeColor = System.Drawing.Color.Black
        Me.lblSair.Location = New System.Drawing.Point(838, 20)
        Me.lblSair.Name = "lblSair"
        Me.lblSair.Size = New System.Drawing.Size(37, 20)
        Me.lblSair.TabIndex = 185
        Me.lblSair.Text = "Sair"
        '
        'frmListarVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(911, 454)
        Me.Controls.Add(Me.lblSair)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Me.rbData)
        Me.Controls.Add(Me.rbFuncionario)
        Me.Controls.Add(Me.rbCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbFuncionario)
        Me.Controls.Add(Me.cbCliente)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListarVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListarVendas"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents dtData As DateTimePicker
    Friend WithEvents rbData As RadioButton
    Friend WithEvents rbFuncionario As RadioButton
    Friend WithEvents rbCliente As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cbFuncionario As ComboBox
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents lblSair As Label
End Class
