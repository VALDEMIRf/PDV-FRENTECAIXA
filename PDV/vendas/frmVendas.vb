Imports System.Data.SqlClient
Imports System.IO

Public Class frmVendas

    Dim id_venda As Integer

    'Sub New(id_vendas As Integer)


    '    InitializeComponent()

    '    Me.id_venda = id_vendas

    'End Sub
    Private Sub frmVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpar()
        txtCodBarras.Focus()

        DesabilitarCampos()
        btnSalvar.Enabled = False


        lblUsuario.Text = usuarioNome
        lblEmpresa.Text = idempresa

        If id_venda > 0 Then
            cbProduto.SelectedValue = id_venda
            ' txtQuantidade.Enabled = True
            btnSalvar.Enabled = True

        End If

        Listar()

        btnExcluir.Enabled = False
        btRelatorio.Enabled = False

        totalizar()
    End Sub

    Private Sub DesabilitarCampos()
        txtNumVenda.Enabled = False
        txtEstoque.Enabled = False
        txtQuantidade.Enabled = False
        txtValor.Enabled = False
        cbCliente.Enabled = False
        cbProduto.Enabled = False
        btRelatorio.Enabled = False

    End Sub

    Private Sub HabilitarCampos()
        txtNumVenda.Enabled = True
        ' txtEstoque.Enabled = True
        txtQuantidade.Enabled = True
        ' txtValor.Enabled = True
        cbCliente.Enabled = True
        cbProduto.Enabled = True
    End Sub

    Private Sub Limpar()
        txtCodBarras.Focus()
        txtNumVenda.Text = ""
        'txtBuscar.Text = ""
        ' txtEstoque.Text = ""
        txtQuantidade.Text = ""
        'txtValor.Text = ""
        'cbCliente.Text = Nothing
        'cbProduto.Text = Nothing
    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        dg.Columns(3).Visible = False
        dg.Columns(8).Visible = False
        dg.Columns(9).Visible = False
        dg.Columns(10).Visible = False
        dg.Columns(4).Visible = False
        dg.Columns(7).Visible = False


        dg.Columns(1).HeaderText = "N° Venda"
        dg.Columns(2).HeaderText = "Descrição"
        ' dg.Columns(3).HeaderText = "Cliente"
        dg.Columns(4).HeaderText = "Vlr. Unit"
        dg.Columns(5).HeaderText = "Quant"
        dg.Columns(6).HeaderText = "Vlr. Total"
        dg.Columns(7).HeaderText = "Cód. Barras"
        ' dg.Columns(8).HeaderText = "Funcionário"
        ' dg.Columns(9).HeaderText = "Dt Venda"


        dg.Columns(1).Width = 60
        dg.Columns(2).Width = 180
        dg.Columns(4).Width = 90
        dg.Columns(5).Width = 50
        dg.Columns(6).Width = 90
        dg.Columns(7).Width = 130
        dg.Columns(9).Width = 70


    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            abrir()

            cmd = New SqlCommand("SELECT ven.id_vendas, ven.num_vendas, pro.nome, cli.nome, pro.valor_venda, ven.quantidade,ven.valor, ven.funcionario, ven.data_venda, ven.id_produto, ven.id_cliente FROM tbVendas as ven INNER JOIN tbProdutos as pro on ven.id_produto=pro.id_produto INNER JOIN tblClientes  as cli on ven.id_cliente = cli.id_cliente WHERE ven.data_venda= @data and ven.funcionario=@funcionario order by num_vendas desc", con)

            cmd.Parameters.AddWithValue("@data", Now.ToShortDateString)
            cmd.Parameters.AddWithValue("@funcionario", usuarioNome)

            da = New SqlDataAdapter(cmd)

            da.Fill(dt)

            dg.DataSource = dt

            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as vendas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Sub CarregarProdutos()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_produtoListar", con)
            DA.Fill(DT)
            cbProduto.DisplayMember = "nome"
            cbProduto.ValueMember = "id_produto"
            cbProduto.DataSource = DT
        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Sub CarregarClientes()
        'Dim DT As New DataTable
        'Dim DA As SqlDataAdapter
        'Try
        '    abrir()
        '    DA = New SqlDataAdapter("pa_cliente_listar", con)

        '    DA.Fill(DT)
        '    cbCliente.DisplayMember = "nome"
        '    cbCliente.ValueMember = "id_cliente"
        '    cbCliente.DataSource = DT
        'Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        'Finally
        '    fechar()
        'End Try

    End Sub



    Private Sub btnNovo_Click_1(sender As Object, e As EventArgs) Handles btnNovo.Click
        CarregarClientes()
        CarregarProdutos()
        HabilitarCampos()
        Limpar()
        btnSalvar.Enabled = True

        btnExcluir.Enabled = False
        gerarnum()
    End Sub

    Private Sub atualizarValor()
        Dim cmd As New SqlCommand("pa_Vendas_buscarValorProd", con)
        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
            cmd.Parameters.Add("@valor_venda", SqlDbType.Decimal).Direction = 2
            cmd.Parameters.Add("@quant", SqlDbType.Int).Direction = 2
            cmd.Parameters.Add("@quant_vendida", SqlDbType.Int).Direction = 2
            cmd.Parameters.Add("@codigo_barras", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim valor As Decimal = cmd.Parameters("@valor_venda").Value
            txtValor.Text = CStr(valor)

            Dim quant As Int32 = cmd.Parameters("@quant").Value
            txtEstoque.Text = CStr(quant)

            Dim quant_vendida As Int32 = cmd.Parameters("@quant_vendida").Value
            txtQuantVendida.Text = CStr(quant_vendida)

            ' ----------------------------------------------------------------------------

            'Dim cmd2 As New SqlCommand("pa_produtoBuscaFoto", con)
            Dim cmd2 As New SqlCommand("select imagem from tbProdutos where id_produto = @id_produto", con)

            cmd2.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
            cmd2.ExecuteNonQuery()

            Dim tempImagem As Byte() = DirectCast(cmd2.ExecuteScalar, Byte())
            '  Dim tempImagem As Byte() = DirectCast(cmd.Parameters("@imagem").Value, Byte())
            If tempImagem Is Nothing Then
                MessageBox.Show("Imagem não localizada", "Erro")
                Exit Sub
            End If
            Dim strArquivo As String = Convert.ToString(DateTime.Now.ToFileTime())
            Dim fs As New FileStream(strArquivo, FileMode.CreateNew, FileAccess.Write)
            fs.Write(tempImagem, 0, tempImagem.Length)
            fs.Flush()
            fs.Close()

            pbImagem.Image = Image.FromFile(strArquivo)

            Dim cod_barras As String = cmd.Parameters("@codigo_barras").Value
            txtCodBarras.Text = cod_barras

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        fechar()
    End Sub

    Private Sub atualizarValorCod()
        Dim cmd As New SqlCommand("pa_Vendas_buscarCodBarras", con)
        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@codigo_barras", txtCodBarras.Text)
            cmd.Parameters.Add("@id_produto", SqlDbType.Int).Direction = 2
            cmd.ExecuteNonQuery()

            Dim id_produto As Int32 = cmd.Parameters("@id_produto").Value
            cbProduto.SelectedValue = id_produto

            My.Computer.Audio.Play(My.Resources.barCode, AudioPlayMode.WaitToComplete)

        Catch ex As Exception
            ' MsgBox("Produto não encontrado")
        End Try
        fechar()
    End Sub
    Private Sub btnSalvar_Click_2(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand

        Dim quantidade As Decimal
        Dim estoque As Decimal
        Dim Totestoque As Decimal
        Dim quant_vendida As Decimal
        Dim TotQuantidade As Decimal

        quantidade = txtQuantidade.Text
        estoque = txtEstoque.Text
        Totestoque = estoque - quantidade

        quant_vendida = txtQuantVendida.Text
        TotQuantidade = quant_vendida + quantidade


        If txtNumVenda.Text <> "" And Totestoque >= 0 Then
            Dim total As Decimal
            Dim valor As Decimal
            Dim quant As Decimal

            valor = txtValor.Text
            quant = txtQuantidade.Text

            total = valor * quant

            Try
                abrir()

                'ABATENDO PRODUTOS NO ESTOQUE

                cmd = New SqlCommand("pa_produtoEditarEstoque", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@quantidade", Totestoque)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.ExecuteNonQuery()

                '=======================================================================================================================

                'ACRESCENTAR QUANTIDADE DE PRODUTOS VENDIDOS
                cmd = New SqlCommand("pa_produtoEditarQuantidadeVendida", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@quant_vendida", TotQuantidade)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.ExecuteNonQuery()
                '===================================================================================================================================

                'SALVAR SAÍDA NA TABELA ESTOQUE

                cmd = New SqlCommand("pa_estoqueSalvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@descricao", "Saída")
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@data_alteracao", Now.ToShortDateString())
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@motivo", "Venda")
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                '=================================================================================================================================================== 

                cmd = New SqlCommand("pa_Vendas_salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@num_vendas", txtNumVenda.Text)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@id_cliente", cbCliente.SelectedValue)
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@valor", total)
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@data_venda", Now.Date())
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                atualizarValor()
                ' Listar()

                BuscarVenda()
                totalizar()

                cbCliente.Enabled = False
                txtNumVenda.Enabled = False
                txtValor.Enabled = False
                txtEstoque.Enabled = False

                txtQuantidade.Text = ""

                btRelatorio.Enabled = True

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message)
                fechar()
            End Try
        Else
            MsgBox("A quantidade em estoque é Insuficiente!!!")

        End If
    End Sub


    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs)

        btnExcluir.Enabled = True
        btnSalvar.Enabled = False
        btRelatorio.Enabled = True
        HabilitarCampos()

        txtCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtNumVenda.Text = dg.CurrentRow.Cells(1).Value
        cbProduto.SelectedValue = dg.CurrentRow.Cells(9).Value
        cbCliente.SelectedValue = dg.CurrentRow.Cells(10).Value
        txtQuantidade.Text = CInt(dg.CurrentRow.Cells(5).Value)
        ' txtValor.Text = CInt(dg.CurrentRow.Cells(5).Value)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)
        Dim cmd As SqlCommand

        If txtNumVenda.Text <> "" Then

            Dim total As Decimal
            Dim valor As Decimal
            Dim quant As Decimal

            valor = txtValor.Text
            quant = txtQuantidade.Text

            total = valor * quant


            Try
                abrir()
                cmd = New SqlCommand("pa_Vendas_editar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_vendas", txtCodigo.Text)
                cmd.Parameters.AddWithValue("@num_vendas", txtNumVenda.Text)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@valor", total)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                Listar()
                Limpar()
                totalizar()

            Catch ex As Exception
                MessageBox.Show("Erro ao editar os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btnExcluir_Click_2(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim quantidade As Decimal
        Dim estoque As Decimal
        Dim Totestoque As Decimal
        Dim quant_vendida As Decimal
        Dim TotQuantidade As Decimal

        quantidade = txtQuantidade.Text
        estoque = txtEstoque.Text
        Totestoque = estoque + quantidade


        quant_vendida = txtQuantVendida.Text
        TotQuantidade = quant_vendida - quantidade


        Dim cmd As SqlCommand

        If txtCodigo.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir esta venda?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()


                'SALVAR SAÍDA NA TABELA ESTOQUE

                cmd = New SqlCommand("pa_estoqueSalvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@descricao", "Entrada")
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@data_alteracao", Now.ToShortDateString())
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@motivo", "Cancelamento")
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()



                '-------------------------------------------------------------------------------------------------------
                'RETIRAR QUANTIDADE DE PRODUTOS VENDIDOS
                cmd = New SqlCommand("pa_produtoEditarQuantidadeVendida", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@quant_vendida", TotQuantidade)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.ExecuteNonQuery()

                '-------------------------------------------------------------------------------------------------------

                'DEVOLVENDO QUANTIDADE AO ESTOQUE

                cmd = New SqlCommand("pa_produtoEditarEstoque", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@quantidade", Totestoque)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.ExecuteNonQuery()

                '-------------------------------------------------------------------------------------------------------                                             

                cmd = New SqlCommand("pa_Vendas_excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_vendas", txtCodigo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                atualizarValor()
                Listar()
                Limpar()
                totalizar()

                atualizarValor()

                btnExcluir.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao excluir os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub totalizar()
        Dim total As Decimal
        For Each lin As DataGridViewRow In dg.Rows
            total = total + lin.Cells(6).Value
        Next

        lblTotal.Text = total
    End Sub

    Private Sub txtBuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" And dg.Rows.Count > 0 Then
            Listar()
            totalizar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_Vendas_buscar", con) 'pa_Vendas_buscar
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@num_vendas", txtBuscar.Text)
                da.Fill(dt)
                dg.DataSource = dt

                totalizar()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar as vendas" + ex.Message)
                fechar()
            End Try
        End If
    End Sub


    Private Sub BuscarVenda()
        If txtNumVenda.Text = "" Then
            Listar()
            totalizar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_Vendas_buscar", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@num_vendas", txtNumVenda.Text)

                da.Fill(dt)
                dg.DataSource = dt


                totalizar()


            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub gerarnum()
        Dim cmd As New SqlCommand("pa_VendabuscarNum", con)  'pa_VendaSbuscarNumero
        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.Add("@num_vendas", SqlDbType.Int).Direction = 2

            cmd.ExecuteNonQuery()

            Dim num As Integer = cmd.Parameters("@num_vendas").Value

            Dim numAleatorio As Random = New Random()
            Dim valorInteiro As Integer = numAleatorio.Next(10000000)

            txtNumVenda.Text = valorInteiro.ToString()

            'EXEMPLO DADO POR PORTAL HUGO CURSOS

            ' Dim hora As String = Now.Second
            'Dim hora As String = Now.ToLongTimeString
            'Dim strNumeros() As String = hora.Split(":")
            'Dim ultimaParte As String = strNumeros(2)
            'Dim num_final As Integer
            'num_final = num + 1
            ' Dim num_pers As String
            'num_pers = num_final.ToString + hora


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        fechar()

    End Sub

    Private Sub btRelatorio_Click_2(sender As Object, e As EventArgs) Handles btRelatorio.Click
        If txtNumVenda.Text = "" Then
            MsgBox("Selecione uma venda na tabela!")
            Exit Sub
        End If

        Dim num As String
        num = txtNumVenda.Text

        Dim form = New frmRelComprovante(num)

        form.ShowDialog()
    End Sub





    Private Sub btSair_Click_2(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub cbProduto_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbProduto.SelectedIndexChanged
        atualizarValor()
    End Sub

    Private Sub txtCodBarras_TextChanged(sender As Object, e As EventArgs) Handles txtCodBarras.TextChanged
        atualizarValorCod()
    End Sub

    Private Sub txtCodBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodBarras.KeyDown
        If e.Control = True And e.KeyCode = Keys.NumPad1 Then
            ' MsgBox("Tecla 1 pressionada")
            txtCodBarras.Text = ""
        End If
    End Sub

    Private Sub txtQuantidade_TextChanged(sender As Object, e As EventArgs) Handles txtQuantidade.TextChanged
        If txtQuantidade.Text <> "0" And txtValor.Text <> "" Then
            Dim valor As Decimal
            Dim quant As Decimal
            Dim total As Decimal
            valor = txtValor.Text
            quant = txtQuantidade.Text
            total = valor * quant
            lblTotalUnit.Text = total
        End If
    End Sub

    Private Sub txtDesconto_TextChanged(sender As Object, e As EventArgs) Handles txtDesconto.TextChanged
        If lblTotal.Text <> "0" And txtDesconto.Text <> "" Then
            Dim subTotal As Decimal
            Dim desc As Decimal
            Dim total As Decimal
            subTotal = lblTotal.Text
            desc = txtDesconto.Text
            total = subTotal - desc
            lblTotalCompra.Text = total
        End If
    End Sub
End Class