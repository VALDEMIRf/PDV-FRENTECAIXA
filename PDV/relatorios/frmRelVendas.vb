﻿Imports System.Data.SqlClient

Public Class frmRelVendas
    Private Sub frmRelVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'VendasDataSet.ListadeVendas'. Você pode movê-la ou removê-la conforme necessário.

        dtData.Value = Now.Date()

        CarregarFuncionarios()

        rel()

    End Sub

    Sub CarregarFuncionarios()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_func_listar", con)
            DA.Fill(DT)
            cbFuncionario.DisplayMember = "nome"
            cbFuncionario.ValueMember = "id_func"
            cbFuncionario.DataSource = DT
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        fechar()
    End Sub

    Private Sub dtData_ValueChanged(sender As Object, e As EventArgs) Handles dtData.ValueChanged

        rel()
    End Sub

    Private Sub rel()
        Me.ListadeVendasTableAdapter.Fill(Me.VendasDataSet.ListadeVendas, dtData.Text, cbFuncionario.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cbFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFuncionario.SelectedIndexChanged

        rel()
    End Sub
End Class