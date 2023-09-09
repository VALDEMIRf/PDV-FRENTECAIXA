Public Class TestesJson
    Dim listaVeiculos = New List(Of clsVeiculo)


    Private Sub TestesJson_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        Dim veiculo = New clsVeiculo()
        listaVeiculos.clear()
        veiculo.ListaVeiculos(listaVeiculos)
        'For Each veiculo In listaVeiculos
        'MessageBox.Show(veiculo.Nome)
        ' txtVeiculos.Text = veiculo.Nome
        '  txtv2.Text = veiculo.Nome
        '  Next

        Dim x = clsJson.SerializarLista(listaVeiculos)
        ' txtVeiculos.Text = x
        clsArquivo.JsonSalvar(x, "C:\Users\valde\OneDrive\Documentos\Visual Studio 2017\Backup Files\teste\veiculos.json")
        MessageBox.Show(x)
    End Sub

    Private Sub btCarregar_Click(sender As Object, e As EventArgs) Handles btCarregar.Click
        listaVeiculos = clsArquivo.JsonCarregar("C:\Users\valde\OneDrive\Documentos\Visual Studio 2017\Backup Files\teste\veiculos.json")

        For Each veiculo In listaVeiculos
            MessageBox.Show(veiculo.Nome)
            'txtVeiculos.Text = veiculo.Nome
            'txtv2.Text = veiculo.Nome
        Next
    End Sub
End Class