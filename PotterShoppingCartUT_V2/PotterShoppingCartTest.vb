﻿Imports System.Text
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

    <TestMethod()> Public Sub Buy_One_Book1_and_One_Book2_then_Pay_190()
        'arrang
        Dim objTarget As PotterShoppingCart = New PotterShoppingCart()
        Dim nExpected As Integer = 190
        Dim nActual As Integer = 0

        'act
        objTarget.add(New Potter(1))
        objTarget.add(New Potter(2))
        nActual = objTarget.CheckOut()

        'assert
        Assert.AreEqual(nExpected, nActual)
    End Sub

    <TestMethod()> Public Sub Buy_One_Book1_and_One_Book2_and_One_Book3_then_Pay_270()
        'arrang
        Dim objTarget As PotterShoppingCart = New PotterShoppingCart()
        Dim nExpected As Integer = 270
        Dim nActual As Integer = 0

        'act
        objTarget.add(New Potter(1))
        objTarget.add(New Potter(2))
        objTarget.add(New Potter(3))
        nActual = objTarget.CheckOut()

        'assert
        Assert.AreEqual(nExpected, nActual)
    End Sub

End Class