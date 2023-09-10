<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeServiçoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosPrestadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadeDeMedidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradaSaídaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NíveisBaixoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarVendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarVendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SangriaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioDoCaixaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradaSaídaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NíveisDoEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosMaisVendidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasPorFuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogofToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JsonReceitaFederalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatarDataGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.pbImagem = New System.Windows.Forms.PictureBox()
        Me.lblAbrirFechar = New System.Windows.Forms.Label()
        Me.lblTextoCaixa = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblHoraSangria = New System.Windows.Forms.Label()
        Me.lblVendasDia = New System.Windows.Forms.Label()
        Me.lblProdutosVendidos = New System.Windows.Forms.Label()
        Me.lblTotSang = New System.Windows.Forms.Label()
        Me.lblVlrAb = New System.Windows.Forms.Label()
        Me.lblHoraAb = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.imagemNivel = New System.Windows.Forms.PictureBox()
        Me.lblNivel = New System.Windows.Forms.Label()
        Me.lblTotalCaixa = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagemNivel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DodgerBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosToolStripMenuItem, Me.EstoqueToolStripMenuItem, Me.VendasToolStripMenuItem, Me.RelatóriosToolStripMenuItem, Me.SairToolStripMenuItem, Me.TestesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1180, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.FuncionariosToolStripMenuItem, Me.ServiçosToolStripMenuItem, Me.CargosToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.ProdutosToolStripMenuItem3, Me.ToolStripMenuItem1})
        Me.CadastrosToolStripMenuItem.Image = CType(resources.GetObject("CadastrosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.CadastrosToolStripMenuItem.Text = "Cadastros"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = CType(resources.GetObject("ClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'FuncionariosToolStripMenuItem
        '
        Me.FuncionariosToolStripMenuItem.Image = CType(resources.GetObject("FuncionariosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FuncionariosToolStripMenuItem.Name = "FuncionariosToolStripMenuItem"
        Me.FuncionariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FuncionariosToolStripMenuItem.Text = "Funcionarios"
        '
        'ServiçosToolStripMenuItem
        '
        Me.ServiçosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoDeServiçoToolStripMenuItem, Me.ServiçosPrestadosToolStripMenuItem})
        Me.ServiçosToolStripMenuItem.Image = CType(resources.GetObject("ServiçosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ServiçosToolStripMenuItem.Name = "ServiçosToolStripMenuItem"
        Me.ServiçosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ServiçosToolStripMenuItem.Text = "Serviços"
        '
        'TipoDeServiçoToolStripMenuItem
        '
        Me.TipoDeServiçoToolStripMenuItem.Name = "TipoDeServiçoToolStripMenuItem"
        Me.TipoDeServiçoToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.TipoDeServiçoToolStripMenuItem.Text = "Tipo de Serviço"
        '
        'ServiçosPrestadosToolStripMenuItem
        '
        Me.ServiçosPrestadosToolStripMenuItem.Name = "ServiçosPrestadosToolStripMenuItem"
        Me.ServiçosPrestadosToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ServiçosPrestadosToolStripMenuItem.Text = "Serviços Prestados"
        '
        'CargosToolStripMenuItem
        '
        Me.CargosToolStripMenuItem.Image = CType(resources.GetObject("CargosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CargosToolStripMenuItem.Name = "CargosToolStripMenuItem"
        Me.CargosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CargosToolStripMenuItem.Text = "Cargos"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.Image = CType(resources.GetObject("FornecedoresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'ProdutosToolStripMenuItem3
        '
        Me.ProdutosToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdutosToolStripMenuItem2, Me.CategoriasToolStripMenuItem, Me.UnidadeDeMedidaToolStripMenuItem})
        Me.ProdutosToolStripMenuItem3.Image = CType(resources.GetObject("ProdutosToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ProdutosToolStripMenuItem3.Name = "ProdutosToolStripMenuItem3"
        Me.ProdutosToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.ProdutosToolStripMenuItem3.Text = "Produtos"
        '
        'ProdutosToolStripMenuItem2
        '
        Me.ProdutosToolStripMenuItem2.Image = CType(resources.GetObject("ProdutosToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ProdutosToolStripMenuItem2.Name = "ProdutosToolStripMenuItem2"
        Me.ProdutosToolStripMenuItem2.Size = New System.Drawing.Size(177, 22)
        Me.ProdutosToolStripMenuItem2.Text = "Produtos"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Image = CType(resources.GetObject("CategoriasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'UnidadeDeMedidaToolStripMenuItem
        '
        Me.UnidadeDeMedidaToolStripMenuItem.Image = CType(resources.GetObject("UnidadeDeMedidaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UnidadeDeMedidaToolStripMenuItem.Name = "UnidadeDeMedidaToolStripMenuItem"
        Me.UnidadeDeMedidaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.UnidadeDeMedidaToolStripMenuItem.Text = "Unidade de Medida"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem1.Text = "Empresa"
        '
        'EstoqueToolStripMenuItem
        '
        Me.EstoqueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntradaSaídaToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.NíveisBaixoToolStripMenuItem})
        Me.EstoqueToolStripMenuItem.Image = CType(resources.GetObject("EstoqueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EstoqueToolStripMenuItem.Name = "EstoqueToolStripMenuItem"
        Me.EstoqueToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EstoqueToolStripMenuItem.Text = "Estoque"
        '
        'EntradaSaídaToolStripMenuItem
        '
        Me.EntradaSaídaToolStripMenuItem.Image = CType(resources.GetObject("EntradaSaídaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EntradaSaídaToolStripMenuItem.Name = "EntradaSaídaToolStripMenuItem"
        Me.EntradaSaídaToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.EntradaSaídaToolStripMenuItem.Text = "Entrada / Saída"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Image = CType(resources.GetObject("ConsultasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'NíveisBaixoToolStripMenuItem
        '
        Me.NíveisBaixoToolStripMenuItem.Image = CType(resources.GetObject("NíveisBaixoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NíveisBaixoToolStripMenuItem.Name = "NíveisBaixoToolStripMenuItem"
        Me.NíveisBaixoToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.NíveisBaixoToolStripMenuItem.Text = "Níveis Baixo"
        '
        'VendasToolStripMenuItem
        '
        Me.VendasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarVendaToolStripMenuItem, Me.ListarVendasToolStripMenuItem, Me.SangriaToolStripMenuItem1})
        Me.VendasToolStripMenuItem.Image = CType(resources.GetObject("VendasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
        Me.VendasToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.VendasToolStripMenuItem.Text = "Vendas"
        '
        'RegistrarVendaToolStripMenuItem
        '
        Me.RegistrarVendaToolStripMenuItem.Image = CType(resources.GetObject("RegistrarVendaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RegistrarVendaToolStripMenuItem.Name = "RegistrarVendaToolStripMenuItem"
        Me.RegistrarVendaToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.RegistrarVendaToolStripMenuItem.Text = "Registrar Venda"
        '
        'ListarVendasToolStripMenuItem
        '
        Me.ListarVendasToolStripMenuItem.Image = CType(resources.GetObject("ListarVendasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListarVendasToolStripMenuItem.Name = "ListarVendasToolStripMenuItem"
        Me.ListarVendasToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ListarVendasToolStripMenuItem.Text = "Listar Vendas"
        '
        'SangriaToolStripMenuItem1
        '
        Me.SangriaToolStripMenuItem1.Image = CType(resources.GetObject("SangriaToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.SangriaToolStripMenuItem1.Name = "SangriaToolStripMenuItem1"
        Me.SangriaToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.SangriaToolStripMenuItem1.Text = "Sangria"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdutosToolStripMenuItem1, Me.VendasToolStripMenuItem1, Me.RelatórioDoCaixaToolStripMenuItem, Me.EntradaSaídaToolStripMenuItem1, Me.NíveisDoEstoqueToolStripMenuItem, Me.ProdutosMaisVendidosToolStripMenuItem, Me.VendasPorFuncionáriosToolStripMenuItem})
        Me.RelatóriosToolStripMenuItem.Image = CType(resources.GetObject("RelatóriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'ProdutosToolStripMenuItem1
        '
        Me.ProdutosToolStripMenuItem1.Image = CType(resources.GetObject("ProdutosToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ProdutosToolStripMenuItem1.Name = "ProdutosToolStripMenuItem1"
        Me.ProdutosToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.ProdutosToolStripMenuItem1.Text = "Catálogo de Produtos"
        '
        'VendasToolStripMenuItem1
        '
        Me.VendasToolStripMenuItem1.Image = CType(resources.GetObject("VendasToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.VendasToolStripMenuItem1.Name = "VendasToolStripMenuItem1"
        Me.VendasToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.VendasToolStripMenuItem1.Text = "Filtro de Vendas"
        '
        'RelatórioDoCaixaToolStripMenuItem
        '
        Me.RelatórioDoCaixaToolStripMenuItem.Image = CType(resources.GetObject("RelatórioDoCaixaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RelatórioDoCaixaToolStripMenuItem.Name = "RelatórioDoCaixaToolStripMenuItem"
        Me.RelatórioDoCaixaToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.RelatórioDoCaixaToolStripMenuItem.Text = "Relatório do Caixa"
        '
        'EntradaSaídaToolStripMenuItem1
        '
        Me.EntradaSaídaToolStripMenuItem1.Image = CType(resources.GetObject("EntradaSaídaToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.EntradaSaídaToolStripMenuItem1.Name = "EntradaSaídaToolStripMenuItem1"
        Me.EntradaSaídaToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.EntradaSaídaToolStripMenuItem1.Text = "Entrada / Saída"
        '
        'NíveisDoEstoqueToolStripMenuItem
        '
        Me.NíveisDoEstoqueToolStripMenuItem.Image = CType(resources.GetObject("NíveisDoEstoqueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NíveisDoEstoqueToolStripMenuItem.Name = "NíveisDoEstoqueToolStripMenuItem"
        Me.NíveisDoEstoqueToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.NíveisDoEstoqueToolStripMenuItem.Text = "Níveis do Estoque"
        '
        'ProdutosMaisVendidosToolStripMenuItem
        '
        Me.ProdutosMaisVendidosToolStripMenuItem.Image = CType(resources.GetObject("ProdutosMaisVendidosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProdutosMaisVendidosToolStripMenuItem.Name = "ProdutosMaisVendidosToolStripMenuItem"
        Me.ProdutosMaisVendidosToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ProdutosMaisVendidosToolStripMenuItem.Text = "Produtos mais Vendidos"
        '
        'VendasPorFuncionáriosToolStripMenuItem
        '
        Me.VendasPorFuncionáriosToolStripMenuItem.Image = CType(resources.GetObject("VendasPorFuncionáriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VendasPorFuncionáriosToolStripMenuItem.Name = "VendasPorFuncionáriosToolStripMenuItem"
        Me.VendasPorFuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.VendasPorFuncionáriosToolStripMenuItem.Text = "Vendas por Funcionários"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem1, Me.LogofToolStripMenuItem})
        Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'SairToolStripMenuItem1
        '
        Me.SairToolStripMenuItem1.Image = CType(resources.GetObject("SairToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem1.Name = "SairToolStripMenuItem1"
        Me.SairToolStripMenuItem1.Size = New System.Drawing.Size(109, 22)
        Me.SairToolStripMenuItem1.Text = "Sair"
        '
        'LogofToolStripMenuItem
        '
        Me.LogofToolStripMenuItem.Image = CType(resources.GetObject("LogofToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogofToolStripMenuItem.Name = "LogofToolStripMenuItem"
        Me.LogofToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.LogofToolStripMenuItem.Text = "Logoff"
        '
        'TestesToolStripMenuItem
        '
        Me.TestesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JsonReceitaFederalToolStripMenuItem, Me.FormatarDataGridToolStripMenuItem})
        Me.TestesToolStripMenuItem.Name = "TestesToolStripMenuItem"
        Me.TestesToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.TestesToolStripMenuItem.Text = "Testes"
        '
        'JsonReceitaFederalToolStripMenuItem
        '
        Me.JsonReceitaFederalToolStripMenuItem.Name = "JsonReceitaFederalToolStripMenuItem"
        Me.JsonReceitaFederalToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.JsonReceitaFederalToolStripMenuItem.Text = "Json Receita Federal"
        '
        'FormatarDataGridToolStripMenuItem
        '
        Me.FormatarDataGridToolStripMenuItem.Name = "FormatarDataGridToolStripMenuItem"
        Me.FormatarDataGridToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.FormatarDataGridToolStripMenuItem.Text = "Formatar Data Grid"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dg.Location = New System.Drawing.Point(640, 212)
        Me.dg.Margin = New System.Windows.Forms.Padding(6)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(510, 400)
        Me.dg.TabIndex = 171
        '
        'pbImagem
        '
        Me.pbImagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbImagem.Location = New System.Drawing.Point(1030, 113)
        Me.pbImagem.Name = "pbImagem"
        Me.pbImagem.Size = New System.Drawing.Size(15, 15)
        Me.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagem.TabIndex = 173
        Me.pbImagem.TabStop = False
        '
        'lblAbrirFechar
        '
        Me.lblAbrirFechar.AutoSize = True
        Me.lblAbrirFechar.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbrirFechar.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lblAbrirFechar.Location = New System.Drawing.Point(1052, 113)
        Me.lblAbrirFechar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAbrirFechar.Name = "lblAbrirFechar"
        Me.lblAbrirFechar.Size = New System.Drawing.Size(75, 15)
        Me.lblAbrirFechar.TabIndex = 172
        Me.lblAbrirFechar.Text = "FECHAR CAIXA"
        '
        'lblTextoCaixa
        '
        Me.lblTextoCaixa.AutoSize = True
        Me.lblTextoCaixa.Font = New System.Drawing.Font("Arial", 33.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoCaixa.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lblTextoCaixa.Location = New System.Drawing.Point(388, 62)
        Me.lblTextoCaixa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTextoCaixa.Name = "lblTextoCaixa"
        Me.lblTextoCaixa.Size = New System.Drawing.Size(349, 51)
        Me.lblTextoCaixa.TabIndex = 174
        Me.lblTextoCaixa.Text = "CAIXA ABERTO"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.Black
        Me.lblUsuario.Location = New System.Drawing.Point(260, 251)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(23, 31)
        Me.lblUsuario.TabIndex = 175
        Me.lblUsuario.Text = "-"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.Black
        Me.lblHora.Location = New System.Drawing.Point(467, 189)
        Me.lblHora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(19, 25)
        Me.lblHora.TabIndex = 177
        Me.lblHora.Text = "-"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.ForeColor = System.Drawing.Color.Black
        Me.lblData.Location = New System.Drawing.Point(260, 189)
        Me.lblData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(19, 25)
        Me.lblData.TabIndex = 176
        Me.lblData.Text = "-"
        '
        'lblHoraSangria
        '
        Me.lblHoraSangria.AutoSize = True
        Me.lblHoraSangria.BackColor = System.Drawing.Color.Transparent
        Me.lblHoraSangria.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraSangria.ForeColor = System.Drawing.Color.Black
        Me.lblHoraSangria.Location = New System.Drawing.Point(260, 309)
        Me.lblHoraSangria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHoraSangria.Name = "lblHoraSangria"
        Me.lblHoraSangria.Size = New System.Drawing.Size(23, 31)
        Me.lblHoraSangria.TabIndex = 178
        Me.lblHoraSangria.Text = "-"
        '
        'lblVendasDia
        '
        Me.lblVendasDia.AutoSize = True
        Me.lblVendasDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendasDia.ForeColor = System.Drawing.Color.Black
        Me.lblVendasDia.Location = New System.Drawing.Point(260, 379)
        Me.lblVendasDia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVendasDia.Name = "lblVendasDia"
        Me.lblVendasDia.Size = New System.Drawing.Size(23, 31)
        Me.lblVendasDia.TabIndex = 179
        Me.lblVendasDia.Text = "-"
        '
        'lblProdutosVendidos
        '
        Me.lblProdutosVendidos.AutoSize = True
        Me.lblProdutosVendidos.BackColor = System.Drawing.Color.Transparent
        Me.lblProdutosVendidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdutosVendidos.ForeColor = System.Drawing.Color.Black
        Me.lblProdutosVendidos.Location = New System.Drawing.Point(260, 438)
        Me.lblProdutosVendidos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProdutosVendidos.Name = "lblProdutosVendidos"
        Me.lblProdutosVendidos.Size = New System.Drawing.Size(23, 31)
        Me.lblProdutosVendidos.TabIndex = 182
        Me.lblProdutosVendidos.Text = "-"
        '
        'lblTotSang
        '
        Me.lblTotSang.AutoSize = True
        Me.lblTotSang.BackColor = System.Drawing.Color.Transparent
        Me.lblTotSang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotSang.ForeColor = System.Drawing.Color.Black
        Me.lblTotSang.Location = New System.Drawing.Point(13, 118)
        Me.lblTotSang.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotSang.Name = "lblTotSang"
        Me.lblTotSang.Size = New System.Drawing.Size(13, 17)
        Me.lblTotSang.TabIndex = 186
        Me.lblTotSang.Text = "-"
        Me.lblTotSang.Visible = False
        '
        'lblVlrAb
        '
        Me.lblVlrAb.AutoSize = True
        Me.lblVlrAb.BackColor = System.Drawing.Color.Transparent
        Me.lblVlrAb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVlrAb.ForeColor = System.Drawing.Color.Black
        Me.lblVlrAb.Location = New System.Drawing.Point(13, 97)
        Me.lblVlrAb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVlrAb.Name = "lblVlrAb"
        Me.lblVlrAb.Size = New System.Drawing.Size(13, 17)
        Me.lblVlrAb.TabIndex = 185
        Me.lblVlrAb.Text = "-"
        Me.lblVlrAb.Visible = False
        '
        'lblHoraAb
        '
        Me.lblHoraAb.AutoSize = True
        Me.lblHoraAb.BackColor = System.Drawing.Color.Transparent
        Me.lblHoraAb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraAb.ForeColor = System.Drawing.Color.Black
        Me.lblHoraAb.Location = New System.Drawing.Point(13, 80)
        Me.lblHoraAb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHoraAb.Name = "lblHoraAb"
        Me.lblHoraAb.Size = New System.Drawing.Size(13, 17)
        Me.lblHoraAb.TabIndex = 184
        Me.lblHoraAb.Text = "-"
        Me.lblHoraAb.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(260, 555)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(29, 31)
        Me.lblTotal.TabIndex = 187
        Me.lblTotal.Text = "0"
        '
        'imagemNivel
        '
        Me.imagemNivel.BackColor = System.Drawing.Color.Transparent
        Me.imagemNivel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imagemNivel.Location = New System.Drawing.Point(1030, 82)
        Me.imagemNivel.Name = "imagemNivel"
        Me.imagemNivel.Size = New System.Drawing.Size(15, 15)
        Me.imagemNivel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagemNivel.TabIndex = 189
        Me.imagemNivel.TabStop = False
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNivel.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lblNivel.Location = New System.Drawing.Point(1052, 83)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(82, 15)
        Me.lblNivel.TabIndex = 190
        Me.lblNivel.Text = "ESTOQUE BAIXO"
        '
        'lblTotalCaixa
        '
        Me.lblTotalCaixa.AutoSize = True
        Me.lblTotalCaixa.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalCaixa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCaixa.ForeColor = System.Drawing.Color.Black
        Me.lblTotalCaixa.Location = New System.Drawing.Point(310, 127)
        Me.lblTotalCaixa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalCaixa.Name = "lblTotalCaixa"
        Me.lblTotalCaixa.Size = New System.Drawing.Size(13, 17)
        Me.lblTotalCaixa.TabIndex = 191
        Me.lblTotalCaixa.Text = "-"
        Me.lblTotalCaixa.Visible = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1180, 637)
        Me.Controls.Add(Me.lblTotalCaixa)
        Me.Controls.Add(Me.lblNivel)
        Me.Controls.Add(Me.imagemNivel)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotSang)
        Me.Controls.Add(Me.lblVlrAb)
        Me.Controls.Add(Me.lblHoraAb)
        Me.Controls.Add(Me.lblProdutosVendidos)
        Me.Controls.Add(Me.lblVendasDia)
        Me.Controls.Add(Me.lblHoraSangria)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblTextoCaixa)
        Me.Controls.Add(Me.pbImagem)
        Me.Controls.Add(Me.lblAbrirFechar)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tela Inicial - PDV"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagemNivel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarVendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDeServiçoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiçosPrestadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarVendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents VendasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LogofToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SangriaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RelatórioDoCaixaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dg As DataGridView
    Friend WithEvents pbImagem As PictureBox
    Friend WithEvents lblAbrirFechar As Label
    Friend WithEvents lblTextoCaixa As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents lblData As Label
    Friend WithEvents lblHoraSangria As Label
    Friend WithEvents lblVendasDia As Label
    Friend WithEvents lblProdutosVendidos As Label
    Friend WithEvents lblTotSang As Label
    Friend WithEvents lblVlrAb As Label
    Friend WithEvents lblHoraAb As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents EstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradaSaídaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NíveisBaixoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradaSaídaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NíveisDoEstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents imagemNivel As PictureBox
    Friend WithEvents lblNivel As Label
    Friend WithEvents lblTotalCaixa As Label
    Friend WithEvents FornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosMaisVendidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JsonReceitaFederalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatarDataGridToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasPorFuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnidadeDeMedidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
