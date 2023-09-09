Imports System.Data.SqlClient

Public Class frmPrincipal

    Private imagemCarregada As Image
    Dim data As Date

    Dim abertura As Boolean

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblUsuario.Text = usuarioNome
        If (usuarioNome = "admin") Then

            FuncionariosToolStripMenuItem.Enabled = True

        End If

        Listar()
        totalizar()
        '   limpar()

    End Sub

    Private Sub frmPrincipal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        VerificarNiveis()
        verificarAbertura()
        Listar()
        totalizar()

        lblVlrAb.Text = 0

        If abertura = True Then
            CarregarDados()
        End If

        '  limpar()
    End Sub


    Private Sub frmPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = Now.ToLongTimeString()
        lblData.Text = Now.ToShortDateString()

    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            abrir()
            '   cmd = New SqlCommand("pa_VendasListar", con)
            cmd = New SqlCommand("SELECT ven.id_vendas,ven.num_vendas,pro.nome,cli.nome,pro.valor_venda,ven.quantidade,ven.valor,ven.funcionario,ven.data_venda,ven.id_produto,ven.id_cliente FROM tbVendas as ven INNER JOIN tbProdutos as pro on ven.id_produto=pro.id_produto INNER JOIN tbClientes  as cli on ven.id_cliente =cli.id_cliente WHERE ven.data_venda= @data and ven.funcionario=@funcionario order by num_vendas desc", con)
            ' cmd = New SqlCommand("SELECT ven.id_vendas,ven.num_vendas,pro.nome,cli.nome,pro.valor_venda,ven.quantidade,ven.valor,ven.funcionario,ven.data_venda,ven.id_produto,ven.id_cliente FROM tbVendas as ven INNER JOIN tbProdutos as pro on ven.id_produto=pro.id_produto INNER JOIN tbClientes  as cli on ven.id_cliente =cli.id_cliente WHERE ven.data_venda= convert(char(10),getdate(),103) and ven.funcionario=@funcionario order by num_vendas desc", con)


            'da = New SqlDataAdapter("pa_VendasLista", con)
            cmd.Parameters.AddWithValue("@data", Now.Date())
            cmd.Parameters.AddWithValue("@funcionario", usuarioNome)

            da = New SqlDataAdapter(cmd)

            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()

            lblVendasDia.Text = dg.Rows.Count()

            SomarQuantidadeProdutos()



        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as vendas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        dg.Columns(9).Visible = False
        dg.Columns(10).Visible = False
        dg.Columns(8).Visible = False
        dg.Columns(7).Visible = False
        dg.Columns(4).Visible = False
        dg.Columns(1).Visible = False

        dg.Columns(1).HeaderText = "Núm Venda"
        dg.Columns(2).HeaderText = "Produto"
        dg.Columns(3).HeaderText = "Cliente"
        dg.Columns(4).HeaderText = "Valor Unit"
        dg.Columns(5).HeaderText = "Quantidade"
        dg.Columns(6).HeaderText = "Valor Total"
        dg.Columns(7).HeaderText = "Funcionario"
        dg.Columns(8).HeaderText = "Data Venda"

        dg.Columns(1).Width = 65
        dg.Columns(2).Width = 160
        dg.Columns(3).Width = 150
        dg.Columns(4).Width = 80
        dg.Columns(5).Width = 80
        dg.Columns(6).Width = 100
        dg.Columns(7).Width = 140
        dg.Columns(8).Width = 85

    End Sub

    Sub SomarQuantidadeProdutos()
        Dim quant As Decimal
        For Each linha As DataGridViewRow In dg.Rows
            quant = quant + linha.Cells(5).Value
        Next
        lblProdutosVendidos.Text = quant
    End Sub


    Sub VerificarFechamento()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            abrir()

            cmd = New SqlCommand("SELECT * FROM tbCaixa WHERE funcionario=@func AND data_ab=@data", con)
            'da = New SqlDataAdapter("pa_produtoListar", con)
            cmd.Parameters.AddWithValue("@func", usuarioNome)
            cmd.Parameters.AddWithValue("@data", Now.ToShortDateString)
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            dg.DataSource = dt


            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os dados do caixa" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub totalizar()
        Dim total As Decimal
        For Each lin As DataGridViewRow In dg.Rows
            total = total + lin.Cells(6).Value
        Next

        lblTotal.Text = total
    End Sub

    'Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
    '    Dim form = New frmProdutos

    '    form.ShowDialog()
    'End Sub

    Private Sub ProdutosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem1.Click
        Dim form = New frmRelProdutos

        form.ShowDialog()
    End Sub

    Private Sub FuncionariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionariosToolStripMenuItem.Click
        Dim form = New frmFuncionarios

        form.ShowDialog()
    End Sub

    Private Sub CargosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargosToolStripMenuItem.Click
        Dim form = New frmCargos

        form.ShowDialog()
    End Sub

    Private Sub TipoDeServiçoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeServiçoToolStripMenuItem.Click
        Dim form = New frmTipoServico

        form.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim form = New frmClientes

        form.ShowDialog()
    End Sub

    Private Sub ServiçosPrestadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiçosPrestadosToolStripMenuItem.Click
        Dim form = New frmServicos

        form.ShowDialog()
    End Sub

    Private Sub SairToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub LogofToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogofToolStripMenuItem.Click
        Dim form = New frmLogin
        Me.Hide()
        form.ShowDialog()
        '   Me.Close()
    End Sub

    Private Sub RegistrarVendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarVendaToolStripMenuItem.Click
        'pa_verificar_abertura

        data = Now.ToShortDateString()

        Dim cmd As New SqlCommand("pa_verificar_abertura", con)

        Try
            abrir()
            cmd.CommandType = 4
            With cmd.Parameters
                .AddWithValue("@data", data)
                .AddWithValue("@funcionario", usuarioNome)
                .Add("@msg", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()
            End With

            Dim msg As String = cmd.Parameters("@msg").Value


            If (msg = "Abra primeiro o Caixa" Or lblTextoCaixa.Text = "CAIXA FECHADO") Then
                MessageBox.Show("O Caixa não está aberto! ")

            Else
                Dim form = New frmVendas

                form.ShowDialog()
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao Acessar! " + ex.Message.ToString)
            fechar()
        End Try

    End Sub

    Private Sub ListarVendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarVendasToolStripMenuItem.Click
        Dim form = New frmListarVendas

        form.ShowDialog()
    End Sub

    Private Sub VendasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VendasToolStripMenuItem1.Click
        Dim form = New frmRelVendas

        form.ShowDialog()
    End Sub

    Private Sub SangriaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SangriaToolStripMenuItem1.Click
        Dim formP As Form
        formP = frmSangria
        Dim form = New frmLoginAdm(formP)

        form.ShowDialog()
    End Sub

    Sub carregarImagem()
        ' Dim img As String
        'If abertura = True Then
        '    pbImagem.Image = My.Resources.caixaaberto
        'Else
        '    pbImagem.Image = My.Resources.caixafechado
        'End If


        If abertura = True Then
            pbImagem.Image = My.Resources.btVerde
            lblTextoCaixa.Text = "CAIXA ABERTO"
            lblAbrirFechar.Text = "FECHAR CAIXA"
        Else
            pbImagem.Image = My.Resources.btVermelho
            lblTextoCaixa.Text = "CAIXA FECHADO"
            lblAbrirFechar.Text = "ABRIR CAIXA"
        End If

    End Sub



    Sub verificarAbertura()
        data = Now.ToShortDateString()

        Dim cmd As New SqlCommand("pa_verificar_abertura", con)

        Try
            abrir()
            cmd.CommandType = 4
            With cmd.Parameters
                .AddWithValue("@data", data)
                .AddWithValue("@funcionario", usuarioNome)
                .Add("@msg", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()
            End With

            Dim msg As String = cmd.Parameters("@msg").Value


            If (msg = "Abra primeiro o Caixa") Then
                abertura = False
                carregarImagem()
            Else
                abertura = True
                carregarImagem()
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao Acessar! " + ex.Message.ToString)
            fechar()
        End Try
    End Sub

    Private Sub pbImagem_Click(sender As Object, e As EventArgs)

        If abertura = True Then
            Dim valor_abertura As Decimal
            valor_abertura = lblVlrAb.Text

            Dim quant_vendas As Integer
            quant_vendas = lblVendasDia.Text

            Dim prod_vendidos As Integer
            prod_vendidos = lblProdutosVendidos.Text

            Dim total_vendido As Decimal
            total_vendido = lblTotal.Text

            Dim valor_sangria As Decimal
            valor_sangria = lblTotSang.Text

            Dim formP = New frmFecharCaixa(valor_abertura, quant_vendas, prod_vendidos, total_vendido, valor_sangria)


            Dim form = New frmLoginAdm(formP)
            form.ShowDialog()
        Else
            Dim valorAb As Decimal
            valorAb = lblVlrAb.Text
            If valorAb > 0 Then
                MsgBox("O caixa não pode ser aberto novamente Hoje!")
            Else
                Dim formP As Form
                formP = frmAbrirCaixa
                Dim form = New frmLoginAdm(formP)
                form.ShowDialog()
            End If

        End If
    End Sub

    Private Sub CarregarDados()
        Dim cmd As New SqlCommand("pa_buscarDadosCaixa", con)

        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@data_ab", Now.ToShortDateString())
            cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
            cmd.Parameters.Add("@hora_ab", SqlDbType.Time).Direction = 2
            cmd.Parameters.Add("@hora_sangria", SqlDbType.Time).Direction = 2
            'cmd.Parameters.Add("@quant_vendas", SqlDbType.Int).Direction = 2
            cmd.Parameters.Add("@valor_ab", SqlDbType.Decimal).Direction = 2
            cmd.Parameters.Add("@valor_sangria", SqlDbType.Decimal).Direction = 2
            cmd.Parameters.Add("@total_caixa", SqlDbType.Decimal).Direction = 2

            cmd.ExecuteNonQuery()

            Dim hora_ab As TimeSpan = cmd.Parameters("@hora_ab").Value
            lblHoraAb.Text = hora_ab.ToString()
            ' lblHoraAb.Text = CStr(hora_ab)

            Dim hora_sangria As TimeSpan = cmd.Parameters("@hora_sangria").Value
            lblHoraSangria.Text = hora_sangria.ToString()

            Dim valor_ab As Decimal = cmd.Parameters("@valor_ab").Value
            lblVlrAb.Text = CStr(valor_ab)

            Dim valor_sangria As Decimal = cmd.Parameters("@valor_sangria").Value
            lblTotSang.Text = CStr(valor_sangria)

            Dim total_caixa As Decimal = cmd.Parameters("@total_caixa").Value
            lblTotalCaixa.Text = CStr(total_caixa)

            If total_caixa > 0 Then
                abertura = False
                carregarImagem()
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        fechar()

    End Sub

    Private Sub RelatórioDoCaixaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioDoCaixaToolStripMenuItem.Click
        Dim form = New frmRelCaixa

        form.ShowDialog()
    End Sub

    Private Sub pbImagem_Click_1(sender As Object, e As EventArgs) Handles pbImagem.Click

        If abertura = True Then
            Dim valor_abertura As Decimal
            valor_abertura = lblVlrAb.Text

            Dim quant_vendas As Integer
            quant_vendas = lblVendasDia.Text

            Dim prod_vendidos As Integer
            prod_vendidos = lblProdutosVendidos.Text

            Dim total_vendido As Decimal
            total_vendido = lblTotal.Text

            Dim valor_sangria As Decimal
            valor_sangria = lblTotSang.Text

            Dim formP = New frmFecharCaixa(valor_abertura, quant_vendas, prod_vendidos, total_vendido, valor_sangria)


            Dim form = New frmLoginAdm(formP)
            form.ShowDialog()
        Else
            Dim valorAb As Decimal
            valorAb = lblVlrAb.Text
            If valorAb > 0 Then
                MsgBox("O caixa não pode ser aberto novamente Hoje!")
            Else
                Dim formP As Form
                formP = frmAbrirCaixa
                Dim form = New frmLoginAdm(formP)
                form.ShowDialog()
            End If

        End If
    End Sub

    Sub limpar()
        lblData.Text = ""
        lblHora.Text = ""
        lblUsuario.Text = ""
        lblHoraSangria.Text = ""
        lblVendasDia.Text = ""
        lblProdutosVendidos.Text = ""
        lblTotal.Text = ""

    End Sub

    Private Sub EntradaSaídaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaSaídaToolStripMenuItem.Click
        Dim form = New frmEstoque(0)
        form.ShowDialog()
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem.Click
        Dim form = New frnEstoqueConsulta
        form.ShowDialog()
    End Sub

    Private Sub NíveisBaixoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NíveisBaixoToolStripMenuItem.Click
        Dim form = New frmNivel
        form.ShowDialog()
    End Sub

    Private Sub EntradaSaídaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EntradaSaídaToolStripMenuItem1.Click
        Dim form = New frmRelEstoque
        form.ShowDialog()
    End Sub

    Private Sub NíveisDoEstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NíveisDoEstoqueToolStripMenuItem.Click
        Dim form = New frmRelNiveis
        form.ShowDialog()
    End Sub

    Sub VerificarNiveis()
        Dim cmd As New SqlCommand("pa_verificar_nivel", con)

        Try
            abrir()
            cmd.CommandType = 4
            With cmd.Parameters

                .Add("@msg", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()
            End With



            Dim msg As String = cmd.Parameters("@msg").Value


            If (msg = "Estoque Baixo") Then
                ' MsgBox("O Nível de estoque está baixo")

                imagemNivel.Image = My.Resources.btVermelho
                lblNivel.Text = "ESTOQUE BAIXO"

            Else
                imagemNivel.Image = My.Resources.btVerde
                lblNivel.Text = "ESTOQUE BOM"

            End If


        Catch ex As Exception
            MessageBox.Show("Erro ao Verificar Nível" + ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub imagemNivel_Click(sender As Object, e As EventArgs) Handles imagemNivel.Click
        Dim form = New frmNivel
        form.ShowDialog()
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        Dim form = New frmCadFornecedores
        form.ShowDialog()
    End Sub

    Private Sub ProdutosMaisVendidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosMaisVendidosToolStripMenuItem.Click
        Dim form = New frmRelProdutosVendidos
        form.ShowDialog()
    End Sub


    Private Sub JsonReceitaFederalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JsonReceitaFederalToolStripMenuItem.Click
        Dim form = New TestesJson
        form.ShowDialog()
    End Sub

    Private Sub FormatarDataGridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormatarDataGridToolStripMenuItem.Click
        Dim form = New frmFormatDataGrid
        form.ShowDialog()
    End Sub

    Private Sub VendasPorFuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendasPorFuncionáriosToolStripMenuItem.Click
        Dim form = New frmRelVendaData
        form.ShowDialog()
    End Sub

    Private Sub ProdutosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem2.Click
        Dim form = New frmProdutos
        form.ShowDialog()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        Dim form = New frmCategoriaProdutos
        form.ShowDialog()
    End Sub

    Private Sub UnidadeDeMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadeDeMedidaToolStripMenuItem.Click
        Dim form = New frmUnidadesMedidas
        form.ShowDialog()
    End Sub
End Class
