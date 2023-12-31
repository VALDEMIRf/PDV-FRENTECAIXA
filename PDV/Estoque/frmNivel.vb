﻿Imports System.Data.SqlClient

Public Class frmNivel
    Private Sub frmNivel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir() 'pa_produtoBuscarMinimo

            da = New SqlDataAdapter("pa_produtoBuscarMinimo", con)
            da.Fill(dt)
            dg.DataSource = dt

            ContarLinhas()
            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar" + ex.Message)
            fechar()
        End Try

    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False

        dg.Columns(7).Visible = False

        dg.Columns(1).HeaderText = "Nome"
        dg.Columns(2).HeaderText = "Descriçao"
        dg.Columns(3).HeaderText = "Quantidade"
        dg.Columns(4).HeaderText = "Valor Compra"
        dg.Columns(5).HeaderText = "Valor Venda"
        dg.Columns(6).HeaderText = "dt Cadastro"
        dg.Columns(7).HeaderText = "Imagem"
        dg.Columns(8).HeaderText = "Nível Minimo"

        dg.Columns(1).Width = 130
        dg.Columns(2).Width = 130
        dg.Columns(3).Width = 70


    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub

    Private Sub dg_DoubleClick(sender As Object, e As EventArgs) Handles dg.DoubleClick
        Dim id_produto As Integer
        id_produto = dg.CurrentRow.Cells(0).Value
        Me.Close()
        Dim form = New frmEstoque(id_produto)

        form.ShowDialog()


    End Sub

    Private Sub frmNivel_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Listar()
    End Sub

    Private Sub lblSair_Click(sender As Object, e As EventArgs) Handles lblSair.Click
        Me.Close()
    End Sub
End Class