
Class Bundle

    Private l_objPotters As New List(Of Potter)()

    Function Pickup(Matrix As List(Of Potter)) As List(Of Potter)
        Dim objReturn As New List(Of Potter)()

        For Each Potter As Potter In Matrix
            Dim objClone As Potter = Potter.Clone()
            Dim objQuery As IEnumerable(Of Potter) =
                From objPotter As Potter In Me.l_objPotters
                Where objPotter.Episode.Equals(objClone.Episode)

            If objQuery.Any() Then
                objReturn.Add(objClone)
            Else
                Me.l_objPotters.Add(objClone)
            End If
        Next

        Return objReturn
    End Function

    Function Count() As Integer
        Dim nReturn As Integer = 0

        '1. 一到五集的哈利波特，每一本都是賣100元
        nReturn = Me.l_objPotters.Count * 100

        Select Case Me.l_objPotters.Count
            Case 2 '2. 如果你從這個系列買了兩本不同的書，則會有5%的折扣
                nReturn = nReturn * 0.95
            Case 3 '3. 如果你買了三本不同的書，則會有10%的折扣
                nReturn = nReturn * 0.9
            Case 4 '4. 如果是四本不同的書，則會有20%的折扣
                nReturn = nReturn * 0.8
        End Select
        Return nReturn
    End Function

End Class
