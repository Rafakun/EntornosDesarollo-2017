Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports NavajaSuiza.Application4.App4Logica

<TestClass()> Public Class PruebaIVA
    <TestMethod()> Public Sub CalcularIVACorrecto()
        Dim numeroIVA As Double = 167.23
        Dim IVA As Integer = 21
        Dim resultadoFinal As String
        Dim resultadoEsperado As String = "El total con 21% IVA es: 202,3483"

        ''Se realiza la función con los parametros anteriores
        ''resultadoFinal = NavajaSuiza.Application4.App4Logica.CalculaIVA(numeroIVA, IVA)
        resultadoFinal = CalculaIVA(numeroIVA, IVA)

        ''Resultado de la prueba
        Assert.AreEqual(resultadoEsperado, resultadoFinal)
    End Sub

    <TestMethod()> Public Sub CalcularIVAIncorrecto()
        Dim numeroIVA As Double = -167.23
        Dim IVA As Integer = 21
        Dim resultadoFinal As String
        Dim resultadoEsperado As String = "No has introducido" + vbCrLf + "un valor valido."

        ''Se realiza la función con los parametros anteriores
        resultadoFinal = CalculaIVA(numeroIVA, IVA)

        ''Resultado de la prueba
        Assert.AreEqual(resultadoEsperado, resultadoFinal)
    End Sub
End Class
