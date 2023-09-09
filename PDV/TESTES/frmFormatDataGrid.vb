Public Class frmFormatDataGrid
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim v As clsTesteVendas = New clsTesteVendas()
        Dim listaVendas = v.GetVendas()

        ConfigurarGrade(listaVendas)
    End Sub

    Private Sub ConfigurarGrade(listaVendas As List(Of clsTesteVendas))
        With DataGridView1
            .Rows.Clear()
            .Columns.Clear()

            'Cabeçalho
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.Brown
            .ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue
            ' .ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold + FontStyle.Italic)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)

            'Linhas dos daods
            ' .DefaultCellStyle.ForeColor = Color.Blue
            .DefaultCellStyle.ForeColor = Color.FromArgb(94, 88, 43)
            .DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 204)
            .DefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)



            .Columns.Add("Id", "Id")
            .Columns("Id").Width = 50

            .Columns.Add("Representate", "Representante")
            .Columns("Representate").Width = 200

            .Columns.Add("Sexo", "Sexo")
            .Columns("Sexo").Width = 50
            .Columns("Sexo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Sexo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns.Add("Meta", "Meta")
            .Columns("Meta").Width = 100
            .Columns("Meta").DefaultCellStyle.Format = "N2"
            .Columns("Meta").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Meta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns.Add("Realizado", "Realizado")
            .Columns("Realizado").Width = 100
            .Columns("Realizado").DefaultCellStyle.Format = "N2"
            .Columns("Realizado").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Realizado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns.Add("Resultado", "Resultado %")
            .Columns("Resultado").Width = 100
            .Columns("Resultado").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Resultado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns.Add("Participacao", "Participação %")
            .Columns("Participacao").Width = 100
            .Columns("Participacao").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Participacao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns.Add("MetaAtingida", "Atingiu meta")
            .Columns("MetaAtingida").Width = 100
            .Columns("MetaAtingida").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("MetaAtingida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns.Add("Nota", "Nota")
            .Columns("Nota").Width = 100
            .Columns("Nota").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Nota").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            For Each r In listaVendas
                .Rows.Add(r.Id, r.Representante, r.Sexo, r.Meta, r.Realizado, r.Resultado, r.Participacao, r.MetaAtingida, r.Nota)
            Next

            For Each row As DataGridViewRow In .Rows
                If row.Cells("MetaAtingida").Value = "Sim" Then
                    row.Cells("MetaAtingida").Style.ForeColor = Color.Blue
                Else
                    row.Cells("MetaAtingida").Style.ForeColor = Color.Red
                End If

                row.Cells("Nota").Style.ForeColor = ColorirNota(row.Cells("Nota").Value)

                If row.Cells("Nota").Value = "Ruím" Then
                    row.DefaultCellStyle.BackColor = Color.Yellow
                End If

            Next

        End With
    End Sub

    Private Function ColorirNota(nota As String) As Color
        Select Case nota
            Case "Ótimo"
                Return Color.Blue
            Case "Bom"
                Return Color.Green
            Case "Regular"
                Return Color.Orange
            Case "Ruím"
                Return Color.Red
            Case Else
                Return Color.Black
        End Select
    End Function

    Private Sub frmFormatDataGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class