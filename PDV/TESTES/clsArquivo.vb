Imports System.IO
Imports Newtonsoft

Public Class clsArquivo
    Public Shared Sub JsonSalvar(strJson As String, path As String)
        Try
            Using sw = New StreamWriter(path)
                sw.WriteLine(strJson)
            End Using
        Catch ex As Exception
            MessageBox.Show("Falha:" + ex.Message.ToString())
        End Try
    End Sub

    Public Shared Function JsonCarregar(path As String) As List(Of clsVeiculo)
        Dim strJson = ""
        Dim lista = New List(Of clsVeiculo)

        Try
            Using sr = New StreamReader(path)
                strJson = sr.ReadToEnd()
                lista = clsJson.DesserializarLista(strJson)
            End Using

        Catch ex As Exception
            MessageBox.Show("Falha:" + ex.Message.ToString())
        End Try
        Return lista
    End Function
End Class
