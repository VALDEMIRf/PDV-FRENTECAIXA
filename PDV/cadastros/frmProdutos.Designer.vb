<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdutos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProdutos))
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.btImagem = New System.Windows.Forms.Button()
        Me.pbImagem = New System.Windows.Forms.PictureBox()
        Me.txtValorCompra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btSair = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbFornecedor = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNivel = New System.Windows.Forms.TextBox()
        Me.errErro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtCodBarras = New System.Windows.Forms.TextBox()
        Me.imgCodBar = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Cadastro = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbUnidade = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Consulta = New System.Windows.Forms.TabPage()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCodBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Cadastro.SuspendLayout()
        Me.Consulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.Color.White
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.DefaultCellStyle = DataGridViewCellStyle1
        Me.dg.GridColor = System.Drawing.Color.CadetBlue
        Me.dg.Location = New System.Drawing.Point(7, 37)
        Me.dg.Margin = New System.Windows.Forms.Padding(4)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(982, 280)
        Me.dg.TabIndex = 0
        '
        'btImagem
        '
        Me.btImagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btImagem.FlatAppearance.BorderSize = 0
        Me.btImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btImagem.ForeColor = System.Drawing.Color.Transparent
        Me.btImagem.Image = CType(resources.GetObject("btImagem.Image"), System.Drawing.Image)
        Me.btImagem.Location = New System.Drawing.Point(942, 175)
        Me.btImagem.Margin = New System.Windows.Forms.Padding(4)
        Me.btImagem.Name = "btImagem"
        Me.btImagem.Size = New System.Drawing.Size(48, 28)
        Me.btImagem.TabIndex = 160
        Me.btImagem.UseVisualStyleBackColor = True
        '
        'pbImagem
        '
        Me.pbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImagem.Image = Global.PDV.My.Resources.Resources.imagesemfoto
        Me.pbImagem.Location = New System.Drawing.Point(799, 7)
        Me.pbImagem.Margin = New System.Windows.Forms.Padding(4)
        Me.pbImagem.Name = "pbImagem"
        Me.pbImagem.Size = New System.Drawing.Size(200, 150)
        Me.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagem.TabIndex = 159
        Me.pbImagem.TabStop = False
        '
        'txtValorCompra
        '
        Me.txtValorCompra.Location = New System.Drawing.Point(687, 34)
        Me.txtValorCompra.Margin = New System.Windows.Forms.Padding(5)
        Me.txtValorCompra.Name = "txtValorCompra"
        Me.txtValorCompra.Size = New System.Drawing.Size(89, 22)
        Me.txtValorCompra.TabIndex = 158
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(573, 34)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 16)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "Valor de Compra:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(687, 83)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(5)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(88, 22)
        Me.txtValor.TabIndex = 156
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(686, 177)
        Me.txtQuantidade.Margin = New System.Windows.Forms.Padding(5)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(89, 22)
        Me.txtQuantidade.TabIndex = 155
        Me.txtQuantidade.Text = "0"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(5, 5)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(35, 22)
        Me.txtCodigo.TabIndex = 154
        Me.txtCodigo.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(582, 83)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "Valor de Venda:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(108, 69)
        Me.txtDescricao.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(419, 71)
        Me.txtDescricao.TabIndex = 147
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(30, 89)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Descrição:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(603, 180)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 16)
        Me.Label7.TabIndex = 151
        Me.Label7.Text = "Quantidade:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(108, 28)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(423, 22)
        Me.txtNome.TabIndex = 146
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(55, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "Nome:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(78, 8)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(137, 22)
        Me.txtBuscar.TabIndex = 149
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "Buscar:"
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
        Me.btSair.Location = New System.Drawing.Point(361, 23)
        Me.btSair.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(73, 33)
        Me.btSair.TabIndex = 165
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(914, 325)
        Me.Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 20)
        Me.Label11.TabIndex = 167
        Me.Label11.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(963, 326)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(14, 20)
        Me.lblTotal.TabIndex = 166
        Me.lblTotal.Text = "-"
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
        Me.btnExcluir.Location = New System.Drawing.Point(272, 20)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(87, 37)
        Me.btnExcluir.TabIndex = 164
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(186, 18)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(83, 36)
        Me.btnEditar.TabIndex = 163
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = False
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
        Me.btnSalvar.Location = New System.Drawing.Point(94, 17)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(87, 37)
        Me.btnSalvar.TabIndex = 162
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
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
        Me.btnNovo.Location = New System.Drawing.Point(7, 17)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(81, 37)
        Me.btnNovo.TabIndex = 161
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNovo)
        Me.GroupBox1.Controls.Add(Me.btSair)
        Me.GroupBox1.Controls.Add(Me.btnSalvar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnExcluir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 397)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(438, 69)
        Me.GroupBox1.TabIndex = 168
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(597, 133)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 169
        Me.Label6.Text = "Nível Mínimo:"
        '
        'cbFornecedor
        '
        Me.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFornecedor.Enabled = False
        Me.cbFornecedor.FormattingEnabled = True
        Me.cbFornecedor.Location = New System.Drawing.Point(108, 149)
        Me.cbFornecedor.Name = "cbFornecedor"
        Me.cbFornecedor.Size = New System.Drawing.Size(419, 24)
        Me.cbFornecedor.TabIndex = 182
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(21, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 16)
        Me.Label8.TabIndex = 183
        Me.Label8.Text = "Fornecedor:"
        '
        'txtNivel
        '
        Me.txtNivel.Location = New System.Drawing.Point(686, 130)
        Me.txtNivel.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(89, 22)
        Me.txtNivel.TabIndex = 184
        '
        'errErro
        '
        Me.errErro.ContainerControl = Me
        '
        'txtCodBarras
        '
        Me.txtCodBarras.Location = New System.Drawing.Point(812, 231)
        Me.txtCodBarras.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCodBarras.Name = "txtCodBarras"
        Me.txtCodBarras.Size = New System.Drawing.Size(187, 22)
        Me.txtCodBarras.TabIndex = 185
        '
        'imgCodBar
        '
        Me.imgCodBar.Location = New System.Drawing.Point(812, 261)
        Me.imgCodBar.Name = "imgCodBar"
        Me.imgCodBar.Size = New System.Drawing.Size(188, 50)
        Me.imgCodBar.TabIndex = 187
        Me.imgCodBar.TabStop = False
        '
        'PrintDocument1
        '
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Cadastro)
        Me.TabControl1.Controls.Add(Me.Consulta)
        Me.TabControl1.Location = New System.Drawing.Point(8, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1016, 384)
        Me.TabControl1.TabIndex = 188
        '
        'Cadastro
        '
        Me.Cadastro.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Cadastro.Controls.Add(Me.Label13)
        Me.Cadastro.Controls.Add(Me.cbUnidade)
        Me.Cadastro.Controls.Add(Me.Label12)
        Me.Cadastro.Controls.Add(Me.cbCategoria)
        Me.Cadastro.Controls.Add(Me.Label10)
        Me.Cadastro.Controls.Add(Me.imgCodBar)
        Me.Cadastro.Controls.Add(Me.txtNivel)
        Me.Cadastro.Controls.Add(Me.Label2)
        Me.Cadastro.Controls.Add(Me.Label6)
        Me.Cadastro.Controls.Add(Me.txtCodigo)
        Me.Cadastro.Controls.Add(Me.btImagem)
        Me.Cadastro.Controls.Add(Me.txtCodBarras)
        Me.Cadastro.Controls.Add(Me.pbImagem)
        Me.Cadastro.Controls.Add(Me.txtNome)
        Me.Cadastro.Controls.Add(Me.Label5)
        Me.Cadastro.Controls.Add(Me.txtDescricao)
        Me.Cadastro.Controls.Add(Me.cbFornecedor)
        Me.Cadastro.Controls.Add(Me.txtValorCompra)
        Me.Cadastro.Controls.Add(Me.Label4)
        Me.Cadastro.Controls.Add(Me.Label8)
        Me.Cadastro.Controls.Add(Me.txtValor)
        Me.Cadastro.Controls.Add(Me.Label7)
        Me.Cadastro.Controls.Add(Me.txtQuantidade)
        Me.Cadastro.Controls.Add(Me.Label3)
        Me.Cadastro.Location = New System.Drawing.Point(4, 25)
        Me.Cadastro.Name = "Cadastro"
        Me.Cadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.Cadastro.Size = New System.Drawing.Size(1008, 355)
        Me.Cadastro.TabIndex = 0
        Me.Cadastro.Text = "Cadastro"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.SteelBlue
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(867, 208)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 18)
        Me.Label13.TabIndex = 192
        Me.Label13.Text = "Cód. de Barras:"
        '
        'cbUnidade
        '
        Me.cbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidade.Enabled = False
        Me.cbUnidade.FormattingEnabled = True
        Me.cbUnidade.Location = New System.Drawing.Point(108, 221)
        Me.cbUnidade.Name = "cbUnidade"
        Me.cbUnidade.Size = New System.Drawing.Size(106, 24)
        Me.cbUnidade.TabIndex = 190
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(42, 225)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 16)
        Me.Label12.TabIndex = 191
        Me.Label12.Text = "Unidade:"
        '
        'cbCategoria
        '
        Me.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategoria.Enabled = False
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(108, 179)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(193, 24)
        Me.cbCategoria.TabIndex = 188
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(35, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 189
        Me.Label10.Text = "Categoria:"
        '
        'Consulta
        '
        Me.Consulta.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Consulta.Controls.Add(Me.dg)
        Me.Consulta.Controls.Add(Me.txtBuscar)
        Me.Consulta.Controls.Add(Me.Label11)
        Me.Consulta.Controls.Add(Me.lblTotal)
        Me.Consulta.Controls.Add(Me.Label1)
        Me.Consulta.Location = New System.Drawing.Point(4, 25)
        Me.Consulta.Name = "Consulta"
        Me.Consulta.Padding = New System.Windows.Forms.Padding(3)
        Me.Consulta.Size = New System.Drawing.Size(1008, 355)
        Me.Consulta.TabIndex = 1
        Me.Consulta.Text = "Consulta"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1036, 478)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciamento de Produtos"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCodBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Cadastro.ResumeLayout(False)
        Me.Cadastro.PerformLayout()
        Me.Consulta.ResumeLayout(False)
        Me.Consulta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dg As DataGridView
    Friend WithEvents btImagem As Button
    Friend WithEvents pbImagem As PictureBox
    Friend WithEvents txtValorCompra As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btSair As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbFornecedor As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNivel As TextBox
    Friend WithEvents errErro As ErrorProvider
    Friend WithEvents txtCodBarras As TextBox
    Friend WithEvents imgCodBar As PictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Cadastro As TabPage
    Friend WithEvents Consulta As TabPage
    Friend WithEvents cbUnidade As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbCategoria As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label13 As Label
End Class
