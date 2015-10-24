
Public Class PotterShoppingCart

    Private _Books As List(Of Potter) = Nothing

    Public Sub New()
        Me._Books = New List(Of Potter)()
    End Sub

    Sub add(Potter As Potter)
        Me.add(Potter, 1)
    End Sub

    Sub add(potter As Potter, p2 As Integer)
        For nCount As Integer = 1 To p2
            Me._Books.Add(potter.Clone())
        Next
    End Sub

    Function CheckOut() As Integer
        Dim nReturn As Integer = 0
        Dim Books As List(Of Potter) = Me._Books
        Dim Bundles As List(Of Bundle) = New List(Of bundle)()

        While Books.Count > 0
            Dim Bundle As New Bundle()

            Books = Bundle.Pickup(Books)
            Bundles.Add(Bundle)
        End While

        For Each Bundle As Bundle In Bundles
            nReturn += Bundle.Count()
        Next

        Return nReturn
    End Function

End Class
