
Public Class Bundle

    Private _Books As List(Of Potter) = New List(Of Potter)()

    Function Pickup(Matrix As List(Of Potter)) As List(Of Potter)
        Dim objReturn As New List(Of Potter)()

        For Each Potter As Potter In Matrix
            Dim objClone As Potter = Potter.Clone()
            Dim objQuery As IEnumerable(Of Potter) =
                From objPotter As Potter In Me._Books
                Where objPotter.Episode.Equals(objClone.Episode)

            If objQuery.Any() Then
                objReturn.Add(objClone)
            Else
                Me._Books.Add(objClone)
            End If
        Next

        Return objReturn
    End Function

    Function Count() As Integer
        Dim nReturn As Integer = 0
        Dim nCount As Integer = Me._Books.Count
        Dim nPrice As Integer = 100
        Dim nTotal As Integer = nPrice * nCount

        Select Case nCount
            Case 1
                nReturn = nTotal
            Case 2
                nReturn = nTotal * 0.95
            Case 3
                nReturn = nTotal * 0.9
            Case 4
                nReturn = nTotal * 0.8
            Case 5
                nReturn = nTotal * 0.75
        End Select

        Return nReturn
    End Function

End Class
