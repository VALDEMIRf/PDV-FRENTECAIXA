Imports Newtonsoft.Json

Public Class clsJson
    Public Shared Function SerializarLista(lista As List(Of clsVeiculo)) As String
        Dim StrJson = JsonConvert.SerializeObject(lista, Formatting.Indented)
        Return StrJson
    End Function


    Public Shared Function DesserializarLista(strJson As String) As List(Of clsVeiculo)
        Return JsonConvert.DeserializeObject(Of List(Of clsVeiculo))(strJson)

    End Function
End Class
