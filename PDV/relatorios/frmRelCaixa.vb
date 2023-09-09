Imports System.Data.SqlClient

Public Class frmRelCaixa
    Private Sub frmRelCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dt.Value = Now.ToShortDateString
        cbFunc.Text = usuarioNome

        CarregarFuncionarios()

        IniciarRel()

    End Sub

    Sub CarregarFuncionarios()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_func_listar", con)
            DA.Fill(DT)
            cbFunc.DisplayMember = "nome"
            cbFunc.ValueMember = "id_func"
            cbFunc.DataSource = DT
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        fechar()
    End Sub

    Private Sub cbFunc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFunc.SelectedIndexChanged
        IniciarRel()
    End Sub

    Sub IniciarRel()
        'TODO: esta linha de código carrega dados na tabela 'caixaDataSet.tbCaixa'. Você pode movê-la ou removê-la conforme necessário.
        Me.TbCaixaTableAdapter.Fill(Me.CaixaDataSet.tbCaixa, cbFunc.Text, dt.Value)
        Me.ListadeVendasTableAdapter.Fill(Me.VendasDataSet.ListadeVendas, dt.Value, cbFunc.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub dt_ValueChanged(sender As Object, e As EventArgs) Handles dt.ValueChanged
        IniciarRel()
    End Sub
End Class