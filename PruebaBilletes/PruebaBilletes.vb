Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports NavajaSuiza.Application3.App3Logica

<TestClass()> Public Class PruebaBilletes
    <TestMethod()> Public Sub BilletesCorrectos()
        Dim dinero As Integer = 158
        Dim resultadoFinal As String
        Dim resultadoEsperado As String = "1 monedas de 100 pesetas" + vbCrLf + "2 monedas de 25 pesetas"

        ''Se realiza la función con los parametros anteriores
        resultadoFinal = FDivideBilletes(dinero)

        ''Resultado de la prueba
        Assert.AreEqual(resultadoEsperado, resultadoFinal)
    End Sub

    <TestMethod()> Public Sub BilletesValorIncorrecto()
        Dim dinero As Integer = -158
        Dim resultadoFinal As String
        Dim resultadoEsperado As String = "No has introducido" + vbCrLf + "un valor valido"

        ''Se realiza la función con los parametros anteriores
        resultadoFinal = FDivideBilletes(dinero)

        ''Resultado de la prueba
        Assert.AreEqual(resultadoEsperado, resultadoFinal)
    End Sub
End Class