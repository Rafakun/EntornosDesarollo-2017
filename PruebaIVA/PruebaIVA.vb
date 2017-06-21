Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class PruebaIVA
    <TestMethod()> Public Sub CalcularIVACorrecto()
        Dim numeroIVA As Double = 167.23
        Dim IVA As Integer = 21
        Dim ResultadoFinal As String
        Dim ResultadoEsperado As String = "El total con 21% IVA es: 202,3483"

        ''Se realiza la función con los parametros anteriores
        ResultadoFinal = NavajaSuiza.Application4.App4Logica.CalculaIVA(numeroIVA, IVA)

        ''Resultado de la prueba
        Assert.AreEqual(ResultadoEsperado, ResultadoFinal)
    End Sub

    <TestMethod()> Public Sub CalcularIVAIncorrecto()
        Dim numeroIVA As Double = -167.23
        Dim IVA As Integer = 21
        Dim ResultadoFinal As String
        Dim ResultadoEsperado As String = "No has introducido un valor valido."

        ''Se realiza la función con los parametros anteriores
        ResultadoFinal = NavajaSuiza.Application4.App4Logica.CalculaIVA(numeroIVA, IVA)

        ''Resultado de la prueba
        Assert.AreEqual(ResultadoEsperado, ResultadoFinal)
    End Sub
End Class