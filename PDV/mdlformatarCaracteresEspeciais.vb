Imports System.Text

Module mdlformatarCaracteresEspeciais
    Public Function UTF8_to_ISO(texto As String) As String
        'Dim isoEncoding = Encoding.GetEncoding("ISO-8859-8")
        Dim isoEncoding = Encoding.GetEncoding("Windows-1252")
        Dim utfEncoding = Encoding.UTF8

        Dim bytesIso As Byte() = utfEncoding.GetBytes(texto)
        Dim bytesUtf As Byte() = Encoding.Convert(utfEncoding, isoEncoding, bytesIso)

        Dim textoISO = utfEncoding.GetString(bytesUtf)

        UTF8_to_ISO = textoISO
    End Function
End Module
