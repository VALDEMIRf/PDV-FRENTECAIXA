Imports Microsoft.Reporting.WinForms

Public Class frmRelProdutosVendidos
    Private Sub frmRelProdutosVendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtDataInicio.Text = Now.ToShortDateString
        dtDataFinal.Text = Now.ToShortDateString

        InicarRel()

    End Sub

    Sub InicarRel()
        Me.QuantidadeVendidaDataTableAdapter.Fill(Me.ProdutosDataSet.QuantidadeVendidaData, dtDataInicio.Text, dtDataFinal.Text)

        Dim parametro(1) As ReportParameter
        parametro(0) = New ReportParameter("data_inicial", dtDataInicio.Value)

        parametro(1) = New ReportParameter("data_final", dtDataFinal.Value)

        Me.ReportViewer1.LocalReport.SetParameters(parametro)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub lblSair_Click(sender As Object, e As EventArgs) Handles lblSair.Click
        Me.Close()
    End Sub

    Private Sub dtDataInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtDataInicio.ValueChanged
        InicarRel()
    End Sub

    Private Sub dtDataFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtDataFinal.ValueChanged
        InicarRel()
    End Sub
End Class