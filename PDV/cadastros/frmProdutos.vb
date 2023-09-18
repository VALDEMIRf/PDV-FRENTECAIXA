Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text.pdf

Public Class frmProdutos

    Private ImagemCarregada As Image
    Private _create As Net.HttpWebRequest

    Private Property Create(img As String) As Net.HttpWebRequest
        Get
            Return _create
        End Get
        Set(value As Net.HttpWebRequest)
            _create = value
        End Set
    End Property


    Private Sub frmProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' carregarImagem()


        DesabilitarCampos()
        btnSalvar.Enabled = False

        CarregarFornecedor()
        CarregarCategoriaProdutos()
        CarregarUnidadesMedidas()

        Listar()

        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub frmProdutos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        carregarImagem()
    End Sub

    Sub CarregarFornecedor()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_fornecedor_listar", con)
            DA.Fill(DT)
            cbFornecedor.DisplayMember = "razaoSocial"
            cbFornecedor.ValueMember = "id_fornecedor"
            cbFornecedor.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub


    Sub CarregarCategoriaProdutos()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_categoriaProdutos_listar", con)
            DA.Fill(DT)
            cbCategoria.DisplayMember = "categoria"
            cbCategoria.ValueMember = "id_categoria"
            cbCategoria.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub


    Sub CarregarUnidadesMedidas()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_unidadeMedida_listar", con)
            DA.Fill(DT)
            cbUnidade.DisplayMember = "unidadeMedida"
            cbUnidade.ValueMember = "id_unidade"
            cbUnidade.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            '  da = New SqlDataAdapter("SELECT * FROM tbProdutos", con)
            da = New SqlDataAdapter("pa_produtoListar", con)
            da.Fill(dt)
            dg.DataSource = dt

            ContarLinhas()
            FormatarDG()


        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os produtos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub DesabilitarCampos()
        txtNome.Enabled = False
        txtDescricao.Enabled = False
        txtQuantidade.Enabled = False
        txtValor.Enabled = False
        txtValorCompra.Enabled = False
        txtNivel.Enabled = False
        cbFornecedor.Enabled = False

    End Sub

    Private Sub HabilitarCampos()
        txtNome.Enabled = True
        txtDescricao.Enabled = True
        'txtQuantidade.Enabled = True
        txtValor.Enabled = True
        txtValorCompra.Enabled = True
        txtNivel.Enabled = True
        cbFornecedor.Enabled = True
        cbCategoria.Enabled = True
        cbUnidade.Enabled = True
    End Sub

    Private Sub Limpar()
        txtNome.Focus()
        txtNome.Text = ""
        txtDescricao.Text = ""
        txtQuantidade.Text = "0"
        txtValor.Text = ""
        txtValorCompra.Text = ""
        txtBuscar.Text = ""
        txtNivel.Text = "0"
        cbCategoria.Text = " "
        cbFornecedor.Text = Nothing
        cbUnidade.Text = Nothing
        cbCategoria.Text = Nothing
        txtCodBarras.Text = ""
        imgCodBar.Image = Nothing
        carregarImagem()

    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        dg.Columns(9).Visible = False
        dg.Columns(15).Visible = False
        dg.Columns(16).Visible = False
        dg.Columns(17).Visible = False
        dg.Columns(18).Visible = False
        dg.Columns(19).Visible = False
        dg.Columns(20).Visible = False

        dg.Columns(1).HeaderText = "Nome"
        dg.Columns(2).HeaderText = "Descrição"
        dg.Columns(3).HeaderText = "Categoria"
        dg.Columns(4).HeaderText = "Unidade"
        dg.Columns(5).HeaderText = "Quant."
        dg.Columns(6).HeaderText = "Vlr de Compra"
        dg.Columns(7).HeaderText = "Vlr de Venda"
        dg.Columns(8).HeaderText = "Dt Cadastro"
        'dg.Columns(9).HeaderText = "Imagem"
        dg.Columns(10).HeaderText = "Nível Mínimo"
        dg.Columns(11).HeaderText = "Quant. Vendida"
        dg.Columns(12).HeaderText = "Código de Barras"
        dg.Columns(13).HeaderText = "Razão Social"
        dg.Columns(14).HeaderText = "Fantasia"
        'dg.Columns(15).HeaderText = "id_fornecedor"
        'dg.Columns(16).HeaderText = "id_fornecedor"
        'dg.Columns(17).HeaderText = "id_categoria"
        'dg.Columns(18).HeaderText = "id_unidade"
        'dg.Columns(19).HeaderText = "id_categoria"
        'dg.Columns(20).HeaderText = "id_unidade"

        dg.Columns(2).Width = 180
        dg.Columns(1).Width = 120
        dg.Columns(3).Width = 90
        dg.Columns(4).Width = 80
        dg.Columns(5).Width = 50
        dg.Columns(6).Width = 60
        dg.Columns(7).Width = 60
        dg.Columns(8).Width = 80
        dg.Columns(10).Width = 55
        dg.Columns(11).Width = 70
        dg.Columns(12).Width = 100
        dg.Columns(13).Width = 190

    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub

    Private Sub btImagem_Click(sender As Object, e As EventArgs) Handles btImagem.Click
        pbImagem.Visible = True
        Using OFD As New OpenFileDialog With {.Filter = "Image File(*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"}

            If OFD.ShowDialog = DialogResult.OK Then
                ImagemCarregada = Image.FromFile(OFD.FileName)
                pbImagem.Image = ImagemCarregada
            End If
        End Using
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        HabilitarCampos()
        Limpar()
        btnSalvar.Enabled = True
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        txtVlrCompra.Visible = False
        txtVlr.Visible = False
        txtValorCompra.Visible = True
        txtValor.Visible = True

        ' pbImagem.Visible = False
        'carregarImagem()
        '  CriarCodigoBarras()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand

        If txtNome.Text <> "" Then
            If pbImagem.Image.Equals(Nothing) Then
                errErro.SetError(pbImagem, "Escolha uma imagem")
                Exit Sub
            Else
                'MessageBox.Show("certo")
            End If

            Try

                'CARREGANDO IMAGEM NO BANCO
                Dim MS As New IO.MemoryStream
                ImagemCarregada.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim byteArray = MS.ToArray

                Dim vlcompra = Replace(txtValorCompra.Text, ",", ".")
                Dim vlVenda = Replace(txtValor.Text, ",", ".")

                abrir()
                cmd = New SqlCommand("pa_produtoSalvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@valor_compra", vlcompra)
                cmd.Parameters.AddWithValue("@valor_venda", vlVenda)
                cmd.Parameters.AddWithValue("@data_cadastro", Now.Date())
                cmd.Parameters.AddWithValue("@imagem", byteArray)
                cmd.Parameters.AddWithValue("@nivel_minimo", txtNivel.Text)
                cmd.Parameters.AddWithValue("@id_fornecedor", cbFornecedor.SelectedValue)
                cmd.Parameters.AddWithValue("@quant_vendida", 0)
                cmd.Parameters.AddWithValue("@codigo_barras", txtCodBarras.Text)
                cmd.Parameters.AddWithValue("@id_categoria", cbCategoria.SelectedValue)
                cmd.Parameters.AddWithValue("@id_unidade", cbUnidade.SelectedValue)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                ' PrintPreviewDialog1.Show()


                Listar()
                Limpar()

                btnSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
            Finally
                fechar()

            End Try
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cmd As SqlCommand

        If txtNome.Text <> "" Then

            Try

                'CARREGANDO IMAGEM NO BANCO
                Dim MS As New IO.MemoryStream
                ImagemCarregada.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim byteArray = MS.ToArray

                abrir()
                cmd = New SqlCommand("pa_produtoEditar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_produto", txtCodigo.Text)
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@valor_compra", txtValorCompra.Text)
                cmd.Parameters.AddWithValue("@valor_venda", txtValor.Text)
                cmd.Parameters.AddWithValue("@imagem", byteArray)
                cmd.Parameters.AddWithValue("@nivel_minimo", txtNivel.Text)
                cmd.Parameters.AddWithValue("@id_fornecedor", cbFornecedor.SelectedValue)


                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

            Catch ex As Exception
                MessageBox.Show("Erro ao Editar os dados" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cmd As SqlCommand

        If txtCodigo.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este Produto?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_produtoExcluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_produto", txtCodigo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

                btnExcluir.Enabled = False
                btnEditar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao excluir o Produto" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick

        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        btnSalvar.Enabled = False

        txtVlrCompra.Visible = True
        txtVlr.Visible = True
        txtValorCompra.Visible = False
        txtValor.Visible = False

        HabilitarCampos()

        'dg.Columns("nivel_minimo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Cadastro.Show()

        txtCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtNome.Text = dg.CurrentRow.Cells(1).Value
        txtDescricao.Text = dg.CurrentRow.Cells(2).Value
        cbCategoria.Text = dg.CurrentRow.Cells(3).Value
        cbFornecedor.Text = dg.CurrentRow.Cells(13).Value
        cbUnidade.Text = dg.CurrentRow.Cells(4).Value
        txtQuantidade.Text = dg.CurrentRow.Cells(3).Value
        txtVlrCompra.Text = CInt(dg.CurrentRow.Cells(6).Value).ToString("R$ #,###.00")
        txtVlr.Text = CInt(dg.CurrentRow.Cells(7).Value).ToString("R$ #,###.00")
        txtNivel.Text = CInt(dg.CurrentRow.Cells(10).Value)
        txtNivel.Text = CInt(dg.CurrentRow.Cells(10).Value)
        txtQuantidade.Text = CInt(dg.CurrentRow.Cells(5).Value)
        txtCodBarras.Text = dg.CurrentRow.Cells(12).Value

        CriarCodigoBarras()

        Dim tempImagem As Byte() = DirectCast(dg.CurrentRow.Cells(9).Value, Byte())
        If tempImagem Is Nothing Then
            MessageBox.Show("Imagem não localizada", "Erro")
            Exit Sub
        End If
        Dim strArquivo As String = Convert.ToString(DateTime.Now.ToFileTime())
        Dim fs As New FileStream(strArquivo, FileMode.CreateNew, FileAccess.Write)
        fs.Write(tempImagem, 0, tempImagem.Length)
        fs.Flush()
        fs.Close()
        ImagemCarregada = Image.FromFile(strArquivo)
        pbImagem.Image = ImagemCarregada

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" And dg.Rows.Count > 0 Then

            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_produtoBuscarNome", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@nome", txtBuscar.Text)
                da.SelectCommand.Parameters.AddWithValue("@codigo_barras", txtBuscar.Text)

                da.Fill(dt)
                dg.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Sub carregarImagem()

        ' Try

        Dim img As String = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQChBDtDqstMB0SDouMEzlGL8AJmAULEUbxBBJe9vYM3TxSVsmybYyHyFTteUZi-fkJOu0&usqp=CAU"
        ' Dim img As String = My.Resources.imagesemfoto
        Dim req As System.Net.HttpWebRequest
        Dim resp As System.Net.HttpWebResponse
        req = Net.WebRequest.Create(img)
        req = req.Create(img)

        resp = req.GetResponse

        ImagemCarregada = New Bitmap(resp.GetResponseStream)
        pbImagem.Image = ImagemCarregada
        req.Abort()



        ' ImagemCarregada = Image.FromFile("C:\Users\valde\OneDrive\Documentos\Visual Studio 2017\Projetos\PDV\PDV\imagens\imagesemfoto.jpg")
        '  pbImagem.Image = My.Resources.imagesemfoto

        'ImagemCarregada = Image.FromFile(\ imaagens \ imagesemfoto.jpg)
        ' pbImagem.Image = ImagemCarregada

        ' Catch ex As Exception
        '    MsgBox("<< Erro ao ler a imagem >> " & ex.Message.ToString)
        ' End Try

    End Sub

    Sub CriarCodigoBarras()

        Dim codBarras As New Barcode128

        With codBarras
            .BarHeight = 50
            .Code = txtCodBarras.Text
            .GenerateChecksum = True
            .CodeType = Barcode.CODE128

            Try
                Dim bmp As New Bitmap(.CreateDrawingImage(Color.Black, Color.White))
                Dim img As Image
                img = New Bitmap(bmp.Width, bmp.Height)

                Dim g As Graphics = Graphics.FromImage(img)
                g.FillRectangle(New SolidBrush(Color.White), 0, 0, bmp.Width, bmp.Height)
                g.DrawImage(bmp, 0, 0)
                imgCodBar.Image = img

            Catch ex As Exception
                MsgBox("Erro" + ex.Message.ToString)
            End Try

        End With

    End Sub

    Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bmp As New Bitmap(imgCodBar.Width, imgCodBar.Height)
        imgCodBar.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub txtCodBarras_TextChanged(sender As Object, e As EventArgs) Handles txtCodBarras.TextChanged
        CriarCodigoBarras()
    End Sub

    Private Sub txtValorCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorCompra.KeyPress
        Select Case (txtValorCompra.TextLength)
            Case 4
                txtValorCompra.SelectionStart = 5
        End Select
    End Sub



    Public Shared Sub Moeda(ByRef txt As TextBox)
        Dim n As String = String.Empty
        Dim v As Double = 0
        Try
            n = txt.Text.Replace(",", "").Replace(".", "")
            If n.Equals("") Then n = ""
            n = n.PadLeft(3, "0")
            If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length - 1)
            v = Convert.ToDouble(n) / 100
            txt.Text = String.Format("{0:N}", v)
            txt.SelectionStart = txt.Text.Length
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub txtValorCompra_TextChanged(sender As Object, e As EventArgs) Handles txtValorCompra.TextChanged
        frmProdutos.Moeda(txtValorCompra)
    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
        frmProdutos.Moeda(txtValor)
    End Sub

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress
        Select Case (txtValor.TextLength)
            Case 4
                txtValor.SelectionStart = 5
        End Select
    End Sub
End Class