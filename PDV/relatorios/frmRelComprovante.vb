


Public Class frmRelComprovante

    Public Sub New(ByVal num As String)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        Me.ComprovanteTableAdapter.Fill(Me.VendasDataSet.Comprovante, num)

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub frmRelComprovante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'VendasDataSet.Comprovante'. Você pode movê-la ou removê-la conforme necessário.

    End Sub
End Class