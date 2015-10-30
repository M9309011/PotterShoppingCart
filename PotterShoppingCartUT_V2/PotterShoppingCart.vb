
Class PotterShoppingCart
    Private l_objPotters As New List(Of Potter)()

    Sub add(p1 As Potter)
        Me.l_objPotters.Add(p1)
    End Sub

    Function CheckOut() As Integer
        '1. 一到五集的哈利波特，每一本都是賣100元
        Return Me.l_objPotters.Count * 100
    End Function

End Class
