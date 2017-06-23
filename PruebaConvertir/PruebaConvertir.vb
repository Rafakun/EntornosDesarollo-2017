Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class PruebaConvertir

    <TestMethod()> Public Sub ConversionPesetas()
        Dim dinero As Integer = 1
        Dim tipoConversion As Integer = 0
        Dim ResultadoFinal As String
        Dim ResultadoEsperado As String = "166,39 Pesetas"

        ''Se realiza la función con los parametros anteriores
        ResultadoFinal = NavajaSuiza.Application2.App2Logica.ConvertirDinero(dinero, tipoConversion)

        ''Resultado de la prueba
        Assert.AreEqual(ResultadoEsperado, ResultadoFinal)
    End Sub

    <TestMethod()> Public Sub ConversionEuros()
        Dim dinero As Integer = 1000
        Dim tipoConversion As Integer = 1
        Dim ResultadoFinal As String
        Dim ResultadoEsperado As String = "6,01 €"

        ''Se realiza la función con los parametros anteriores
        ResultadoFinal = NavajaSuiza.Application2.App2Logica.ConvertirDinero(dinero, tipoConversion)

        ''Resultado de la prueba
        Assert.AreEqual(ResultadoEsperado, ResultadoFinal)
    End Sub

    <TestMethod()> Public Sub ConversionErronea()
        Dim dinero As Integer = -12
        Dim tipoConversion As Integer = 0
        Dim ResultadoFinal As String
        Dim ResultadoEsperado As String = "No has introducido un valor valido."

        ''Se realiza la función con los parametros anteriores
        ResultadoFinal = NavajaSuiza.Application2.App2Logica.ConvertirDinero(dinero, tipoConversion)

        ''Resultado de la prueba
        Assert.AreEqual(ResultadoEsperado, ResultadoFinal)
    End Sub
End Class