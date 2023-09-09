Public Class testecn

    Public Function IsCNPJ(ByVal strCNPJ As String) As Boolean

        IsCNPJ = False

        Dim a, j, d1, d2 As Double

        Dim i As Integer

        If Len(strCNPJ) <> 14 Then

            IsCNPJ = False

            Exit Function

        End If



        'If Not IsOnlyNumber(strCNPJ) Then

        '    IsCNPJ = False

        '    Exit Function

        'End If



        a = 0

        i = 0

        d1 = 0

        d2 = 0

        j = 5

        For i = 1 To 12 Step 1

            a = a + (Val(Mid(strCNPJ, i, 1)) * j)

            j = Convert.ToDouble(IIf(j > 2, j - 1, 9))

        Next i

        a = a Mod 11

        d1 = Convert.ToDouble(IIf(a > 1, 11 - a, 0))

        a = 0

        i = 0

        j = 6

        For i = 1 To 13 Step 1

            a = a + (Val(Mid(strCNPJ, i, 1)) * j)

            j = Convert.ToDouble(IIf(j > 2, j - 1, 9))

        Next i

        a = a Mod 11

        d2 = Convert.ToDouble(IIf(a > 1, 11 - a, 0))

        If (d1 = Val(Mid(strCNPJ, 13, 1)) And d2 = Val(Mid(strCNPJ, 14, 1))) Then

            IsCNPJ = True

        Else

            IsCNPJ = False

        End If

    End Function
End Class
