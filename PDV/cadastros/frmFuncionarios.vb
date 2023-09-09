
Imports System.Data.SqlClient
Imports System.IO


Public Class frmFuncionarios

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
    Private Sub frmFuncionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()

        btnSalvar.Enabled = False
        txtBuscarCPF.Visible = False

        Listar()
        CarregarCargos()

        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        rbNome.Checked = True
    End Sub
    Private Sub DesabilitarCampos()
        txtNome.Enabled = False
        cbSexo.Enabled = False
        txtRG.Enabled = False
        txtCPF.Enabled = False
        txtTel.Enabled = False
        txtEmail.Enabled = False
        txtdtNasc.Enabled = False
        txtEndereco.Enabled = False
        txtNumero.Enabled = False
        txtCompl.Enabled = False
        txtBairro.Enabled = False
        txtCidade.Enabled = False
        txtUF.Enabled = False
        txtCEP.Enabled = False
        cbCargo.Enabled = False
        cbTurno.Enabled = False
        dtData.Enabled = False
        txtdtDemissao.Enabled = False

    End Sub

    Private Sub HabilitarCampos()
        txtNome.Enabled = True
        cbSexo.Enabled = True
        txtRG.Enabled = True
        txtCPF.Enabled = True
        txtTel.Enabled = True
        txtEmail.Enabled = True
        txtdtNasc.Enabled = True
        txtEndereco.Enabled = True
        txtNumero.Enabled = True
        txtCompl.Enabled = True
        txtBairro.Enabled = True
        txtCidade.Enabled = True
        txtUF.Enabled = True
        txtCEP.Enabled = True
        cbCargo.Enabled = True
        cbTurno.Enabled = True
        dtData.Enabled = True
        txtdtDemissao.Enabled = True
    End Sub

    Private Sub Limpar()
        txtNome.Focus()
        txtNome.Text = ""
        cbSexo.Text = Nothing
        txtRG.Text = ""
        txtCPF.Text = ""
        txtTel.Text = ""
        txtEmail.Text = ""
        txtdtNasc.Text = ""
        txtEndereco.Text = ""
        txtNumero.Text = ""
        txtCompl.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtUF.Text = Nothing
        txtCEP.Text = ""
        cbCargo.Text = Nothing
        cbTurno.Text = Nothing
        dtData.Text = ""
        txtdtDemissao.Text = ""
        txtBuscar.Text = ""

        ' carregarImagem()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        HabilitarCampos()
        Limpar()
        btnSalvar.Enabled = True

        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand

        If txtCPF.Text <> "" And txtNome.Text <> "" Then

            Try

                'CARREGANDO IMAGEM NO BANCO
                Dim MS As New IO.MemoryStream
                ImagemCarregada.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim byteArray = MS.ToArray

                abrir()
                cmd = New SqlCommand("pa_funcSalvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@sexo", cbSexo.Text)
                cmd.Parameters.AddWithValue("@rg", txtRG.Text)
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text)
                cmd.Parameters.AddWithValue("@telcel", txtTel.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@dtNasc", txtdtNasc.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@num", txtNumero.Text)
                cmd.Parameters.AddWithValue("@compl", txtCompl.Text)
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@UF", txtUF.Text)
                cmd.Parameters.AddWithValue("@cep", txtCEP.Text)
                cmd.Parameters.AddWithValue("@idCargo", cbCargo.SelectedValue) 'cbCliente.SelectedValue
                cmd.Parameters.AddWithValue("@turno", cbTurno.Text)
                cmd.Parameters.AddWithValue("@data_contratado", dtData.Text)
                cmd.Parameters.AddWithValue("@data_demissao", txtdtDemissao.Text)
                cmd.Parameters.AddWithValue("@imagem", byteArray)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

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

        If txtCPF.Text <> "" And txtNome.Text <> "" Then

            Try

                'CARREGANDO IMAGEM NO BANCO
                Dim MS As New IO.MemoryStream
                ImagemCarregada.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim byteArray = MS.ToArray


                abrir()
                cmd = New SqlCommand("pa_funceditar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@sexo", cbSexo.Text)
                cmd.Parameters.AddWithValue("@rg", txtRG.Text)
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text)
                cmd.Parameters.AddWithValue("@telcel", txtTel.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@dtNasc", txtdtNasc.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@num", txtNumero.Text)
                cmd.Parameters.AddWithValue("@compl", txtCompl.Text)
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@UF", txtUF.Text)
                cmd.Parameters.AddWithValue("@cep", txtCEP.Text)
                cmd.Parameters.AddWithValue("@idCargo", cbCargo.SelectedValue)
                cmd.Parameters.AddWithValue("@turno", cbTurno.Text)
                cmd.Parameters.AddWithValue("@data_contratado", dtData.Text)
                cmd.Parameters.AddWithValue("@data_demissao", txtdtDemissao.Text)
                cmd.Parameters.AddWithValue("@imagem", byteArray)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cmd As SqlCommand

        If txtCPF.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este funcionário?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_Funcexcluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

                btnExcluir.Enabled = False
                btnEditar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub btImagem_Click(sender As Object, e As EventArgs) Handles btImagem.Click
        Using OFD As New OpenFileDialog With {.Filter = "Image File(*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"}

            If OFD.ShowDialog = DialogResult.OK Then
                ImagemCarregada = Image.FromFile(OFD.FileName)
                pbImagem.Image = ImagemCarregada
            End If
        End Using
    End Sub

    Private Sub rbNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbNome.CheckedChanged
        txtBuscarCPF.Text = ""
        txtBuscar.Text = ""
        txtBuscar.Visible = True
        txtBuscarCPF.Visible = False
        txtBuscar.Focus()
        Listar()
    End Sub

    Private Sub rbCPF_CheckedChanged(sender As Object, e As EventArgs) Handles rbCPF.CheckedChanged
        txtBuscar.Text = ""
        txtBuscarCPF.Text = ""
        txtBuscar.Visible = False
        txtBuscarCPF.Visible = True
        txtBuscarCPF.Focus()
        Listar()
    End Sub

    Sub CarregarCargos()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_Cargo_listar", con)
            DA.Fill(DT)
            cbCargo.DisplayMember = "cargo"
            cbCargo.ValueMember = "idCargo"
            cbCargo.DataSource = DT
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
            da = New SqlDataAdapter("pa_func_listar", con)
            da.Fill(dt)
            dg.DataSource = dt

            ContarLinhas()

            FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os funcionários" + ex.Message.ToString)
        Finally

            fechar()
        End Try

        'Return dt

    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        dg.Columns(3).Visible = False
        dg.Columns(4).Visible = False
        dg.Columns(19).Visible = False

        dg.Columns(1).HeaderText = "Nome"
        dg.Columns(2).HeaderText = "Sexo"
        dg.Columns(3).HeaderText = "RG"
        dg.Columns(4).HeaderText = "CPF"
        dg.Columns(5).HeaderText = "Telefone"
        dg.Columns(6).HeaderText = "Email"
        dg.Columns(7).HeaderText = "dtNasc"
        dg.Columns(8).HeaderText = "Endereço"
        dg.Columns(9).HeaderText = "Num"
        dg.Columns(10).HeaderText = "Compl"
        dg.Columns(11).HeaderText = "Bairro"
        dg.Columns(12).HeaderText = "Cidade"
        dg.Columns(13).HeaderText = "UF"
        dg.Columns(14).HeaderText = "CEP"
        dg.Columns(15).HeaderText = "Cargo"
        dg.Columns(16).HeaderText = "Turno"
        dg.Columns(17).HeaderText = "Dt Contratação"
        dg.Columns(18).HeaderText = "Dt Demissão"
        dg.Columns(19).HeaderText = "Imagem"

        dg.Columns(5).Width = 130
        dg.Columns(6).Width = 180
        dg.Columns(8).Width = 150
        dg.Columns(9).Width = 50
        dg.Columns(10).Width = 120
        dg.Columns(11).Width = 180
        dg.Columns(12).Width = 180
        dg.Columns(13).Width = 40
        dg.Columns(14).Width = 75
        dg.Columns(15).Width = 120
        dg.Columns(16).Width = 60

    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub

    Sub carregarImagem()

        ' Try

        'Dim img As String = "https://www.buritama.sp.leg.br/imagens/parlamentares-2013-2016/sem-foto.jpg/image"
        'Dim req As System.Net.HttpWebRequest
        'Dim resp As System.Net.HttpWebResponse
        '' req = Net.WebRequest.Create(img)
        'req = req.Create(img)
        'resp = req.GetResponse

        'ImagemCarregada = New Bitmap(resp.GetResponseStream)
        'pbImagem.Image = ImagemCarregada
        'req.Abort()


        ' ImagemCarregada = Image.FromFile("C:\Users\valde\OneDrive\Documentos\Visual Studio 2017\Projetos\PDV\PDV\imagens\imagesemfoto.jpg")


        '  '  ImagemCarregada = Image.FromFile(\ imaagens \ imagesemfoto.jpg)
        ' pbImagem.Image = ImagemCarregada

        ' Catch ex As Exception
        ' MsgBox("<< Erro ao ler a imagem >> " & ex.Message.ToString)
        ' End Try

    End Sub

    Private Sub txtBuscarCPF_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtBuscarCPF.MaskInputRejected
        If txtBuscarCPF.Text = "   .   .   -" And dg.Rows.Count > 0 Then
            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_FuncCpfbuscar", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@cpf", txtBuscarCPF.Text)

                da.Fill(dt)
                dg.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
            Finally

                fechar()
            End Try
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" And dg.Rows.Count > 0 Then

            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_FuncNomebuscar", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@nome", txtBuscar.Text)

                da.Fill(dt)
                dg.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        Cadastro.Show()

        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        btnSalvar.Enabled = False

        HabilitarCampos()
        txtCPF.Enabled = False

        txtNome.Text = dg.CurrentRow.Cells(1).Value
        cbSexo.Text = dg.CurrentRow.Cells(2).Value
        txtRG.Text = dg.CurrentRow.Cells(3).Value
        txtCPF.Text = dg.CurrentRow.Cells(4).Value
        txtTel.Text = dg.CurrentRow.Cells(5).Value
        txtEmail.Text = dg.CurrentRow.Cells(6).Value
        txtdtNasc.Text = dg.CurrentRow.Cells(7).Value
        txtEndereco.Text = dg.CurrentRow.Cells(8).Value
        txtNumero.Text = dg.CurrentRow.Cells(9).Value
        txtCompl.Text = dg.CurrentRow.Cells(10).Value
        txtBairro.Text = dg.CurrentRow.Cells(11).Value
        txtCidade.Text = dg.CurrentRow.Cells(12).Value
        txtUF.Text = dg.CurrentRow.Cells(13).Value
        txtCEP.Text = dg.CurrentRow.Cells(14).Value
        cbCargo.Text = dg.CurrentRow.Cells(15).Value
        cbTurno.Text = dg.CurrentRow.Cells(16).Value
        dtData.Text = dg.CurrentRow.Cells(17).Value
        txtdtDemissao.Text = dg.CurrentRow.Cells(18).Value

        Dim tempImagem As Byte() = DirectCast(dg.CurrentRow.Cells(19).Value, Byte())
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


End Class