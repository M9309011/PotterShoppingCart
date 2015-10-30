
Class PotterShoppingCart
    Private l_objPotters As New List(Of Potter)()

    Sub add(p1 As Potter)
        Me.l_objPotters.Add(p1)
    End Sub

    Function CheckOut() As Integer
        Dim nReturn As Integer = 0

        '1. 一到五集的哈利波特，每一本都是賣100元
        nReturn = Me.l_objPotters.Count * 100
        If Me.l_objPotters.Count = 2 _
            AndAlso Me.l_objPotters(0).Episode <> Me.l_objPotters(1).Episode Then
            '2. 如果你從這個系列買了兩本不同的書，則會有5%的折扣
            nReturn = nReturn * 0.95
        End If
        
        Return nReturn
    End Function

End Class
