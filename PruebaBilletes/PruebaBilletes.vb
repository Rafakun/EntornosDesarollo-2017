Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class PruebaBilletes

    <TestMethod()> Public Sub BilletesCorrectos()
        Dim dinero As Integer = 158
        Dim ResultadoFinal As String
        Dim ResultadoEsperado As String = "1 monedas de 100 pesetas" + vbCrLf + "2 monedas de 25 pesetas"

        ''Se realiza la función con los parametros anteriores
        ResultadoFinal = NavajaSuiza.Application3.App3Logica.FDivideBilletes(dinero)

        ''Resultado de la prueba
        Assert.AreEqual(ResultadoEsperado, ResultadoFinal)
    End Sub

    <TestMethod()> Public Sub BilletesValorIncorrecto()
        Dim dinero As Integer = -158
        Dim ResultadoFinal As String
        Dim ResultadoEsperado As String = "Error en la introducción del dinero"

        ''Se realiza la función con los parametros anteriores
        ResultadoFinal = NavajaSuiza.Application3.App3Logica.FDivideBilletes(dinero)

        ''Resultado de la prueba
        Assert.AreEqual(ResultadoEsperado, ResultadoFinal)
    End Sub
End Class