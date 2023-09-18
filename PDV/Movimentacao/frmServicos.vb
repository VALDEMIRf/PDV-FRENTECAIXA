Imports System.Data.SqlClient
Imports System.Text

Public Class frmServicos

    Dim CodigoServico As Integer

    Private Sub frmServicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        btSalvar.Enabled = False
        Listar()

        CarregarTipoServico()
        CarregarClientes()

        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub DesabilitarCampos()
        txtNumServico.Enabled = False
        cbCliente.Enabled = False
        cbTipoServico.Enabled = False
        mktDtEntrada.Enabled = False
        txtEndereco.Enabled = False
        txtNumero.Enabled = False
        txtCompl.Enabled = False
        txtBairro.Enabled = False
        txtCidade.Enabled = False
        txtUF.Enabled = False
        txtCEP.Enabled = False
        txtTelRes.Enabled = False
        txtTelCel.Enabled = False
        txtEmail.Enabled = False
        txtResponsavel.Enabled = False
        cbGarantia.Enabled = False
        mktDtEntrega.Enabled = False
        mktHora.Enabled = False
        txtValor.Enabled = False
        cbStatusPgto.Enabled = False
        txtObs.Enabled = False

    End Sub

    Private Sub HabilitarCampos()
        txtNumServico.Enabled = True
        cbCliente.Enabled = True
        cbTipoServico.Enabled = True
        mktDtEntrada.Enabled = True
        txtEndereco.Enabled = True
        txtNumero.Enabled = True
        txtCompl.Enabled = True
        txtBairro.Enabled = True
        txtCidade.Enabled = True
        txtUF.Enabled = True
        txtCEP.Enabled = True
        txtTelRes.Enabled = True
        txtTelCel.Enabled = True
        txtEmail.Enabled = True
        txtResponsavel.Enabled = True
        cbGarantia.Enabled = True
        mktDtEntrega.Enabled = True
        mktHora.Enabled = True
        txtValor.Enabled = True
        cbStatusPgto.Enabled = True
        txtObs.Enabled = True
    End Sub

    Private Sub Limpar()
        cbCliente.Focus()
        txtCodigo.Text = ""
        cbCliente.Text = Nothing
        cbTipoServico.Text = Nothing
        mktDtEntrada.Text = ""
        txtEndereco.Text = ""
        txtNumero.Text = ""
        txtCompl.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtUF.Text = Nothing
        txtCEP.Text = ""
        txtTelRes.Text = ""
        txtTelCel.Text = ""
        txtEmail.Text = ""
        txtResponsavel.Text = ""
        cbGarantia.Text = Nothing
        mktDtEntrega.Text = ""
        mktHora.Text = ""
        txtValor.Text = ""
        cbStatusPgto.Text = Nothing
        txtObs.Text = ""

    End Sub

    Private Sub FormatarDG()

        dgvServico.Columns(21).Visible = False
        dgvServico.Columns(22).Visible = False

        dgvServico.Columns(0).HeaderText = "Núm"
        dgvServico.Columns(1).HeaderText = "Cliente"
        dgvServico.Columns(2).HeaderText = "Serviço"
        dgvServico.Columns(3).HeaderText = "Entrada"
        dgvServico.Columns(4).HeaderText = "Endereço"
        dgvServico.Columns(5).HeaderText = "Num"
        dgvServico.Columns(6).HeaderText = "Compl."
        dgvServico.Columns(7).HeaderText = "Bairro"
        dgvServico.Columns(8).HeaderText = "Cidade"
        dgvServico.Columns(9).HeaderText = "UF"
        dgvServico.Columns(10).HeaderText = "CEP"
        dgvServico.Columns(11).HeaderText = "Tel. Res"
        dgvServico.Columns(12).HeaderText = "Tel. Cel"
        dgvServico.Columns(13).HeaderText = "Email"
        dgvServico.Columns(14).HeaderText = "Responsável"
        dgvServico.Columns(15).HeaderText = "Garantia"
        dgvServico.Columns(16).HeaderText = "Entrega"
        dgvServico.Columns(17).HeaderText = "Hora"
        dgvServico.Columns(18).HeaderText = "Valor"
        dgvServico.Columns(19).HeaderText = "Status do Pag."
        dgvServico.Columns(20).HeaderText = "Observações"
        dgvServico.Columns(21).HeaderText = "idCliente"
        dgvServico.Columns(22).HeaderText = "idTipo"

        dgvServico.Columns(0).Width = 50
        dgvServico.Columns(1).Width = 300
        dgvServico.Columns(2).Width = 100
        dgvServico.Columns(3).Width = 90
        dgvServico.Columns(4).Width = 250
        dgvServico.Columns(5).Width = 80
        dgvServico.Columns(6).Width = 150
        dgvServico.Columns(7).Width = 200
        dgvServico.Columns(8).Width = 200
        dgvServico.Columns(9).Width = 50
        dgvServico.Columns(10).Width = 100
        dgvServico.Columns(11).Width = 130
        dgvServico.Columns(12).Width = 130
        dgvServico.Columns(13).Width = 200
        dgvServico.Columns(14).Width = 200
        dgvServico.Columns(15).Width = 150
        dgvServico.Columns(16).Width = 90
        dgvServico.Columns(17).Width = 60
        dgvServico.Columns(18).Width = 80
        dgvServico.Columns(19).Width = 180
        dgvServico.Columns(20).Width = 500



    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_ServicoLista", con)
            da.Fill(dt)
            dgvServico.DataSource = dt

            ContarLinhas()
            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Serviços" + ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Sub CarregarClientes()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            'DA = New SqlDataAdapter("SELECT * FROM tbClientes", con) 
            DA = New SqlDataAdapter("pa_cliente_listar", con)
            DA.Fill(DT)
            cbCliente.DisplayMember = "nome"
            cbCliente.ValueMember = "id_cliente"
            cbCliente.DataSource = DT

            cbClientes.DisplayMember = "nome"
            cbClientes.ValueMember = "id_cliente"
            cbClientes.DataSource = DT
        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Sub CarregarTipoServico()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            'DA = New SqlDataAdapter("SELECT * FROM tbTipoServico", con)
            DA = New SqlDataAdapter("pa_tipoServico_listar", con)

            DA.Fill(DT)
            cbTipoServico.DisplayMember = "tipoServico"
            cbTipoServico.ValueMember = "id_tipo"
            cbTipoServico.DataSource = DT
        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dgvServico.Rows.Count
        lblTotal.Text = CInt(total)
    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        HabilitarCampos()
        Limpar()
        btSalvar.Enabled = True

        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        Dim cmd As SqlCommand

        If cbCliente.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("pa_servicoSalvar", con)
                cmd.CommandType = CommandType.StoredProcedure

                ' cmd.Parameters.AddWithValue("@num_servicos", txtNumServico.Text)
                cmd.Parameters.AddWithValue("@id_cliente", cbCliente.SelectedValue)
                cmd.Parameters.AddWithValue("@id_tipo", cbTipoServico.SelectedValue)
                cmd.Parameters.AddWithValue("@dtEntrada", mktDtEntrada.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@num", txtNumero.Text)
                cmd.Parameters.AddWithValue("@compl", txtCompl.Text)
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@UF", txtUF.Text)
                cmd.Parameters.AddWithValue("@CEP", txtCEP.Text)
                cmd.Parameters.AddWithValue("@telres", txtTelRes.Text)
                cmd.Parameters.AddWithValue("@telcel", txtTelCel.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@responsavel", txtResponsavel.Text)
                cmd.Parameters.AddWithValue("@garantia", cbGarantia.Text)
                cmd.Parameters.AddWithValue("@dtEntrega", mktDtEntrega.Text)
                cmd.Parameters.AddWithValue("@hora", mktHora.Text)
                cmd.Parameters.AddWithValue("@valor", txtValor.Text)
                cmd.Parameters.AddWithValue("@statusPag", cbStatusPgto.Text)
                cmd.Parameters.AddWithValue("@obs", txtObs.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                Listar()
                Limpar()

                btSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cmd As SqlCommand

        If txtCodigo.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("pa_Servico_editar", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@id_servico", txtCodigo.Text)
                cmd.Parameters.AddWithValue("@id_cliente", cbCliente.SelectedValue)
                cmd.Parameters.AddWithValue("@id_tipo", cbTipoServico.SelectedValue)
                cmd.Parameters.AddWithValue("@dtEntrada", mktDtEntrada.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@num", txtNumero.Text)
                cmd.Parameters.AddWithValue("@compl", txtCompl.Text)
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@uf", txtUF.Text)
                cmd.Parameters.AddWithValue("@cep", txtCEP.Text)
                cmd.Parameters.AddWithValue("@telres", txtTelRes.Text)
                cmd.Parameters.AddWithValue("@telcel", txtTelCel.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@responsavel", txtResponsavel.Text)
                cmd.Parameters.AddWithValue("@garantia", cbGarantia.Text)
                cmd.Parameters.AddWithValue("@dtEntrega", mktDtEntrega.Text)
                cmd.Parameters.AddWithValue("@hora", mktHora.Text)
                cmd.Parameters.AddWithValue("@valor", txtValor.Text)
                cmd.Parameters.AddWithValue("@statusPag", cbStatusPgto.Text)
                cmd.Parameters.AddWithValue("@obs", txtObs.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                Listar()
                Limpar()


            Catch ex As Exception
                MessageBox.Show("Erro ao editar os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cmd As SqlCommand

        If txtCodigo.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este serviço?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_Servico_excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_servico", txtCodigo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                Listar()
                Limpar()
                '   totalizar()

                btnExcluir.Enabled = False
                btnEditar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao excluir os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub dgvServico_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServico.CellClick

        Cadastro.Show()

        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        btSalvar.Enabled = False

        HabilitarCampos()

        txtCodigo.Text = dgvServico.CurrentRow.Cells(0).Value
        cbCliente.Text = dgvServico.CurrentRow.Cells(1).Value
        cbTipoServico.Text = dgvServico.CurrentRow.Cells(2).Value
        mktDtEntrada.Text = dgvServico.CurrentRow.Cells(3).Value
        txtEndereco.Text = dgvServico.CurrentRow.Cells(4).Value
        txtNumero.Text = dgvServico.CurrentRow.Cells(5).Value
        txtCompl.Text = dgvServico.CurrentRow.Cells(6).Value
        txtBairro.Text = dgvServico.CurrentRow.Cells(7).Value
        txtCidade.Text = dgvServico.CurrentRow.Cells(8).Value
        txtUF.Text = dgvServico.CurrentRow.Cells(9).Value
        txtCEP.Text = dgvServico.CurrentRow.Cells(10).Value
        txtTelRes.Text = dgvServico.CurrentRow.Cells(11).Value
        txtTelCel.Text = dgvServico.CurrentRow.Cells(12).Value
        txtEmail.Text = dgvServico.CurrentRow.Cells(13).Value
        txtResponsavel.Text = dgvServico.CurrentRow.Cells(14).Value
        cbGarantia.Text = dgvServico.CurrentRow.Cells(15).Value
        mktDtEntrega.Text = dgvServico.CurrentRow.Cells(16).Value
        mktHora.Text = dgvServico.CurrentRow.Cells(17).Value
        txtValor.Text = dgvServico.CurrentRow.Cells(18).Value
        cbStatusPgto.Text = dgvServico.CurrentRow.Cells(19).Value
        txtObs.Text = dgvServico.CurrentRow.Cells(20).Value
    End Sub

    Private Sub rbCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliente.CheckedChanged
        cbCliente.Text = ""
        cbCliente.Visible = True
        dtData.Visible = False
    End Sub

    Private Sub rbData_CheckedChanged(sender As Object, e As EventArgs) Handles rbData.CheckedChanged
        cbCliente.Text = ""
        cbCliente.Visible = False
        dtData.Visible = True
        rbCliente.Visible = False
    End Sub

    Private Sub cbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClientes.SelectedIndexChanged
        'Dim dt As New DataTable
        'Dim da As SqlDataAdapter
        'Dim cmd As SqlCommand
        'Try
        '    abrir()
        '    '  cmd = New SqlCommand("SELECT s.id_servico,c.nome,t.tipoServico,s.dtEntrada,s.endereco,s.num,s.compl,s.bairro,s.cidade,s.uf,s.cep,s.telres,s.telcel,s.email,s.responsavel,s.garantia,s.dtEntrega,s.hora,s.valor,s.statusPag,s.obs,s.id_cliente,s.id_tipo FROM tbServicos as s INNER JOIN tbClientes as c on s.id_cliente=c.id_cliente INNER JOIN tbTipoServico as t on s.id_tipo=t.id_tipo ", con)


        '    ' cmd = New SqlCommand("SELECT s.id_servico,c.nome,t.tipoServico,s.dtEntrada,s.endereco,s.num,s.compl,s.bairro,s.cidade,s.uf,s.cep,s.telres,s.telcel,s.email,s.responsavel,s.garantia,s.dtEntrega,s.hora,s.valor,s.statusPag,s.obs,s.id_cliente,s.id_tipo FROM tbServicos as s INNER JOIN tbClientes as c on s.id_cliente=c.id_cliente INNER JOIN tbTipoServico as t on s.id_tipo=t.id_tipo WHERE s.id_servico = @cli ORDER BY id_servico DESC", con)


        '    '  cmd.Parameters.AddWithValue("@cli", cbCliente.SelectedValue)

        '    da = New SqlDataAdapter(cmd)
        '    da.Fill(dt)
        '    dgvServico.DataSource = dt


        '    FormatarDG()

        'Catch ex As Exception
        '    MessageBox.Show("Erro ao Listar" + ex.Message)
        '    fechar()
        'End Try
    End Sub

    Private Sub dtData_ValueChanged(sender As Object, e As EventArgs) Handles dtData.ValueChanged
        'Dim dt As New DataTable
        'Dim da As SqlDataAdapter
        'Dim cmd As SqlCommand
        'Try
        '    abrir()
        '    ' cmd = New SqlCommand("SELECT s.id_servico,c.nome,t.tipoServico,s.dtEntrada,s.endereco,s.num,s.compl,s.bairro,s.cidade,s.uf,s.cep,s.telres,s.telcel,s.email,s.responsavel,s.garantia,s.dtEntrega,s.hora,s.valor,s.statusPag,s.obs,s.id_cliente,s.id_tipo FROM tbServicos as s INNER JOIN tbClientes as c on s.id_cliente=c.id_cliente INNER JOIN tbTipoServico as t on s.id_tipo=t.id_tipo WHERE s.dtEntrega= @data ORDER BY id_servico DESC", con)

        '    ' cmd.Parameters.AddWithValue("@data", dtData.Text)


        '    '  cmd = New SqlCommand("SELECT s.id_servico,c.nome,t.tipoServico,s.dtEntrada,s.endereco,s.num,s.compl,s.bairro,s.cidade,s.uf,s.cep,s.telres,s.telcel,s.email,s.responsavel,s.garantia,s.dtEntrega,s.hora,s.valor,s.statusPag,s.obs,s.id_cliente,s.id_tipo FROM tbServicos as s INNER JOIN tbClientes as c on s.id_cliente=c.id_cliente INNER JOIN tbTipoServico as t on s.id_tipo=t.id_tipo ", con)

        '    ' cmd.Parameters.AddWithValue("@data", dtData.Text)

        '    da = New SqlDataAdapter(cmd)
        '    da.Fill(dt)
        '    dgvServico.DataSource = dt


        '    FormatarDG()

        'Catch ex As Exception
        '    MessageBox.Show("Erro ao Listar" + ex.Message)
        '    fechar()
        'End Try
    End Sub
End Class