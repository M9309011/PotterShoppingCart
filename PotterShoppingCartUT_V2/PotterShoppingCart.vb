
Class PotterShoppingCart
    Private l_objPotters As New List(Of Potter)()

    Sub add(p1 As Potter)
        Me.l_objPotters.Add(p1)
    End Sub

    Function CheckOut() As Integer
        Dim nReturn As Integer = 0

        '1. 一到五集的哈利波特，每一本都是賣100元
        nReturn = Me.l_objPotters.Count * 100

        Select Case Me.l_objPotters.Count
            Case 2 '如果你買了兩本書
                If Me.l_objPotters(0).Episode <> Me.l_objPotters(1).Episode Then
                    '2. 如果你從這個系列買了兩本不同的書，則會有5%的折扣
                    nReturn = nReturn * 0.95
                End If

            Case 3 '如果你買了三本書
                If Me.l_objPotters(0).Episode <> Me.l_objPotters(1).Episode _
                    AndAlso Me.l_objPotters(0).Episode <> Me.l_objPotters(2).Episode _
                    AndAlso Me.l_objPotters(1).Episode <> Me.l_objPotters(2).Episode Then
                    '3. 如果你買了三本不同的書，則會有10%的折扣
                    nReturn = nReturn * 0.9

                ElseIf Me.l_objPotters(0).Episode <> Me.l_objPotters(1).Episode _
                    OrElse Me.l_objPotters(0).Episode <> Me.l_objPotters(2).Episode _
                    OrElse Me.l_objPotters(1).Episode <> Me.l_objPotters(2).Episode Then
                    '2. 如果你從這個系列買了兩本不同的書，則會有5%的折扣
                    nReturn = nReturn * 0.95
                End If
        End Select

        
        Return nReturn
    End Function

End Class
