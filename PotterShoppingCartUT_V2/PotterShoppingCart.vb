
Class PotterShoppingCart
    Private l_objPotters As New List(Of Potter)()

    Sub add(p1 As Potter)
        Me.l_objPotters.Add(p1)
    End Sub

    Function CheckOut() As Integer
        Dim nReturn As Integer = 0
        Dim objPotters As List(Of Potter) = Me.l_objPotters
        Dim objBundles As New List(Of Bundle)()

        While objPotters.Count > 0
            Dim objBundle As New Bundle()

            objPotters = objBundle.Pickup(objPotters)
            objBundles.add(objBundle)
        End While

        For Each objBundle As Bundle In objBundles
            nReturn += objBundle.Count()
        Next

        Return nReturn
    End Function

End Class
