Public Class clsVeiculo
    Property Nome As String
    Property Ano As Short
    Property Cor As String
    Property Valor As Decimal

    Public Sub New()

    End Sub

    Public Sub New(nome As String, ano As Short, cor As String, valor As Decimal)
        Me.Nome = nome
        Me.Ano = ano
        Me.Cor = cor
        Me.Valor = valor

    End Sub

    Public Sub ListaVeiculos(lista As List(Of clsVeiculo))
        lista.Add(New clsVeiculo("FORD FIESTA 1.0 MPI PERSONNALIT SEDAN 4P", 2005, "Prata", 11550D))
        lista.Add(New clsVeiculo("KIA CERATO 1.6 EX3 SEDAN 16V 4P", 2012, "Prata", 32550D))
        lista.Add(New clsVeiculo("HYUNDAI HB20 1.0 COMFORT 12V FLEX 4P ", 2017, "Branco", 38745D))
        lista.Add(New clsVeiculo("CITROEN C3 5 TENDANCE 8V FLEX 4P", 2014, "Vermelho", 31395D))
        lista.Add(New clsVeiculo("TOYOTA HILUX 2.8 SRV 4X4 CD 16V 4P", 2016, "Prata", 136500D))

    End Sub
End Class
