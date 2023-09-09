Imports System.Data.SqlClient

Public Class frmLoginAdm

    Dim form As Form

    Sub New(formP As Form)

        InitializeComponent()

        form = formP

    End Sub


    Private Sub frmLoginAdm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnAcesso_Click(sender As Object, e As EventArgs) Handles btnAcesso.Click
        Dim usuario As String = "Admin"
        Dim senha As String = txtSenha.Text

        If senha = "" Then
            MsgBox("Preencha os Campos!!")
        Else

            Dim cmd As New SqlCommand("pa_Login", con)

            Try
                abrir()
                cmd.CommandType = 4
                With cmd.Parameters
                    .AddWithValue("@nome", usuario)
                    .AddWithValue("@cpf", senha)
                    .Add("@msg", SqlDbType.VarChar, 100).Direction = 2
                    cmd.ExecuteNonQuery()
                End With



                Dim msg As String = cmd.Parameters("@msg").Value


                If (msg = "Dados Incorretos") Then
                    txtSenha.Clear()
                    txtSenha.Clear()
                    txtSenha.Focus()
                Else
                    '  Dim f = New frmSangria
                    Me.Hide()
                    form.ShowDialog()
                End If

            Catch ex As Exception
                MessageBox.Show("Erro ao Acessar! " + ex.Message.ToString)
                fechar()
            End Try

        End If
    End Sub


End Class