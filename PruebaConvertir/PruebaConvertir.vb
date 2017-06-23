Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class PruebaConvertir
    Dim aplicacion As New NavajaSuiza.Application2.App2Logica

    <TestMethod()> Public Sub ConversionPesetas()
        Dim dinero As Integer = 1
        Dim tipoConversion As Integer = 0
        Dim resultadoFinal As String
        Dim resultadoEsperado As String = "166,39 Pesetas"

        ''Se realiza la función con los parametros anteriores
        resultadoFinal = aplicacion.ConvertirDinero(dinero, tipoConversion)

        ''Resultado de la prueba
        Assert.AreEqual(resultadoEsperado, resultadoFinal)
    End Sub

    <TestMethod()> Public Sub ConversionEuros()
        Dim dinero As Integer = 1000
        Dim tipoConversion As Integer = 1
        Dim resultadoFinal As String
        Dim resultadoEsperado As String = "6,01 €"

        ''Se realiza la función con los parametros anteriores
        resultadoFinal = aplicacion.ConvertirDinero(dinero, tipoConversion)

        ''Resultado de la prueba
        Assert.AreEqual(resultadoEsperado, resultadoFinal)
    End Sub

    <TestMethod()> Public Sub ConversionErronea()
        Dim dinero As Integer = -12
        Dim tipoConversion As Integer = 0
        Dim resultadoFinal As String
        Dim resultadoEsperado As String = "No has introducido" + vbCrLf + "un valor valido."

        ''Se realiza la función con los parametros anteriores
        resultadoFinal = aplicacion.ConvertirDinero(dinero, tipoConversion)

        ''Resultado de la prueba
        Assert.AreEqual(resultadoEsperado, resultadoFinal)
    End Sub
End Class