Imports System.Data.SqlClient

Public Class frnEstoqueConsulta
    Private Sub frnEstoqueConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        lblDataFinal.Visible = False
        lblDataInicio.Visible = False
        dtDataInicio.Visible = False
        dtDataFinal.Visible = False
    End Sub

    Private Sub rbEntrada_CheckedChanged(sender As Object, e As EventArgs) Handles rbEntrada.CheckedChanged
        Listar()
        cbEntrada.Text = ""
        cbEntrada.Visible = True

        lblDataFinal.Visible = False
        lblDataInicio.Visible = False
        dtDataInicio.Visible = False
        dtDataFinal.Visible = False
    End Sub

    Private Sub rbData_CheckedChanged(sender As Object, e As EventArgs) Handles rbData.CheckedChanged
        Listar()
        cbEntrada.Text = ""
        cbEntrada.Visible = False

        lblDataFinal.Visible = True
        lblDataInicio.Visible = True
        dtDataInicio.Visible = True
        dtDataFinal.Visible = True
    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir() 'pa_estoqueBuscargeral
            da = New SqlDataAdapter("pa_estoqueBuscargeral", con)
            'da = New SqlDataAdapter("SELECT est.id_estoque, pro.nome, est.descricao, est.quantidade, est.data_alteracao, est.id_produto, est.funcionario from estoque as est INNER JOIN produtos as pro on est.id_produto = pro.id_produto order by id_estoque desc", con)
            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar" + ex.Message)
            fechar()
        End Try

    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        dg.Columns(5).Visible = False

        dg.Columns(1).HeaderText = "Produto"
        dg.Columns(2).HeaderText = "Descrição"
        dg.Columns(3).HeaderText = "Quantidade"
        dg.Columns(4).HeaderText = "Data"

        dg.Columns(6).HeaderText = "Funcionário"

    End Sub

    Private Sub dtDataInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtDataInicio.ValueChanged
        buscarPorData()
    End Sub
    Sub buscarPorData()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_EstoquebuscarEntreDatas", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@data_inicial", dtDataInicio.Text)
            da.SelectCommand.Parameters.AddWithValue("@data_final", dtDataFinal.Value)

            da.Fill(dt)
            dg.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar" + ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub dtDataFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtDataFinal.ValueChanged
        buscarPorData()
    End Sub

    Private Sub cbEntrada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEntrada.SelectedIndexChanged
        If cbEntrada.Text = "" And dg.Rows.Count > 0 Then
            Listar()


        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_EstoqueEntradabuscar", con)
                ' da = New SqlDataAdapter("SELECT est.id_estoque, pro.nome, est.descricao, est.quantidade, est.data_alteracao, est.id_produto, est.funcionario FROM tbEstoque as est INNER JOIN tbProdutos as pro on est.id_produto = pro.id_produto WHERE est.descricao = @descricao order by est.id_estoque desc ", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@descricao", cbEntrada.Text)

                da.Fill(dt)
                dg.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub lblSair_Click(sender As Object, e As EventArgs) Handles lblSair.Click
        Me.Close()
    End Sub

    Private Sub dg_DoubleClick(sender As Object, e As EventArgs) Handles dg.DoubleClick
        Dim id_estoque As Integer
        id_estoque = dg.CurrentRow.Cells(0).Value
        'Me.Close()
        Dim form = New frmEstoque(id_estoque)

        form.ShowDialog()
    End Sub
End Class