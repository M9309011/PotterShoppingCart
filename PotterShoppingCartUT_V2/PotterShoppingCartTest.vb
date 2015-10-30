Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class PotterShoppingCartTest

    <TestMethod()> Public Sub Buy_One_Book1_then_Pay_100()
        'arrange
        Dim objTarget As New PotterShoppingCart()
        Dim nExpected As Integer = 100
        Dim nActual As Integer = 0

        'act
        objTarget.add(New Potter(1))
        nActual = objTarget.CheckOut()

        'assert
        Assert.AreEqual(nExpected, nActual)

    End Sub

End Class