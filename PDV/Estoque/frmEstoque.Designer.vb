<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstoque))
        Me.cbProduto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEstoque = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbDescricao = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.cbBuscar = New System.Windows.Forms.ComboBox()
        Me.txtCodigo = New System.Windows.Forms.Label()
        Me.txtQuantVendida = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.imagem = New System.Windows.Forms.PictureBox()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbProduto
        '
        Me.cbProduto.FormattingEnabled = True
        Me.cbProduto.Location = New System.Drawing.Point(136, 36)
        Me.cbProduto.Name = "cbProduto"
        Me.cbProduto.Size = New System.Drawing.Size(203, 24)
        Me.cbProduto.TabIndex = 115
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(74, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Produto"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(136, 94)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(70, 23)
        Me.txtQuantidade.TabIndex = 111
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(46, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Quantidade:"
        '
        'txtEstoque
        '
        Me.txtEstoque.Enabled = False
        Me.txtEstoque.Location = New System.Drawing.Point(136, 122)
        Me.txtEstoque.Name = "txtEstoque"
        Me.txtEstoque.Size = New System.Drawing.Size(70, 23)
        Me.txtEstoque.TabIndex = 119
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(67, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Estoque:"
        '
        'cbDescricao
        '
        Me.cbDescricao.FormattingEnabled = True
        Me.cbDescricao.Items.AddRange(New Object() {"Entrada", "Saída"})
        Me.cbDescricao.Location = New System.Drawing.Point(136, 66)
        Me.cbDescricao.Name = "cbDescricao"
        Me.cbDescricao.Size = New System.Drawing.Size(203, 24)
        Me.cbDescricao.TabIndex = 118
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(57, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Descrição:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(75, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Buscar:"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(10, 178)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(555, 221)
        Me.dg.TabIndex = 123
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNovo)
        Me.GroupBox1.Controls.Add(Me.btSair)
        Me.GroupBox1.Controls.Add(Me.btnSalvar)
        Me.GroupBox1.Controls.Add(Me.btnExcluir)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 406)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(358, 50)
        Me.GroupBox1.TabIndex = 169
        Me.GroupBox1.TabStop = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.Transparent
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(7, 10)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(81, 37)
        Me.btnNovo.TabIndex = 161
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'btSair
        '
        Me.btSair.BackColor = System.Drawing.Color.Transparent
        Me.btSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSair.FlatAppearance.BorderSize = 0
        Me.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = CType(resources.GetObject("btSair.Image"), System.Drawing.Image)
        Me.btSair.Location = New System.Drawing.Point(276, 13)
        Me.btSair.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(75, 30)
        Me.btSair.TabIndex = 165
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(93, 9)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(90, 37)
        Me.btnSalvar.TabIndex = 162
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(184, 8)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(90, 36)
        Me.btnExcluir.TabIndex = 164
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'cbBuscar
        '
        Me.cbBuscar.FormattingEnabled = True
        Me.cbBuscar.Items.AddRange(New Object() {"Entrada", "Saída"})
        Me.cbBuscar.Location = New System.Drawing.Point(136, 6)
        Me.cbBuscar.Name = "cbBuscar"
        Me.cbBuscar.Size = New System.Drawing.Size(203, 24)
        Me.cbBuscar.TabIndex = 170
        '
        'txtCodigo
        '
        Me.txtCodigo.AutoSize = True
        Me.txtCodigo.ForeColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(9, 9)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(16, 17)
        Me.txtCodigo.TabIndex = 171
        Me.txtCodigo.Text = "0"
        Me.txtCodigo.Visible = False
        '
        'txtQuantVendida
        '
        Me.txtQuantVendida.Location = New System.Drawing.Point(136, 150)
        Me.txtQuantVendida.Name = "txtQuantVendida"
        Me.txtQuantVendida.Size = New System.Drawing.Size(70, 23)
        Me.txtQuantVendida.TabIndex = 172
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(23, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 17)
        Me.Label6.TabIndex = 173
        Me.Label6.Text = "Quant. Vendida"
        '
        'imagem
        '
        Me.imagem.Location = New System.Drawing.Point(455, 17)
        Me.imagem.Name = "imagem"
        Me.imagem.Size = New System.Drawing.Size(100, 100)
        Me.imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagem.TabIndex = 121
        Me.imagem.TabStop = False
        '
        'frmEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(582, 467)
        Me.Controls.Add(Me.txtQuantVendida)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.cbBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.imagem)
        Me.Controls.Add(Me.txtEstoque)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbDescricao)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbProduto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Estoque"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.imagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbProduto As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEstoque As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbDescricao As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dg As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnNovo As Button
    Friend WithEvents btSair As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents cbBuscar As ComboBox
    Friend WithEvents txtCodigo As Label
    Friend WithEvents txtQuantVendida As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents imagem As PictureBox
End Class
