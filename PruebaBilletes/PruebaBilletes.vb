Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports NavajaSuiza.Application3.App3Logica

<TestClass()> Public Class PruebaBilletes
    ''' <summary>
    ''' Prueba unitaria de la Application3 para cuando se le pasa un número correcto.
    ''' </summary>
    <TestMethod()> Public Sub BilletesCorrectos()
        Dim dinero As Integer = 158
        Dim resultadoFinal As String
        Dim resultadoEsperado As String = "1 monedas de 100 pesetas" + vbCrLf + "2 monedas de 25 pesetas"

        ''Se realiza la función con los parametros anteriores
        resultadoFinal = FDivideBilletes(dinero)

        ''Resultado de la prueba
        Assert.AreEqual(resultadoEsperado, resultadoFinal)
    End Sub
    ''' <summary>
    ''' Prueba unitaria de la Application3 para cuando se le pasa un número incorrecto.
    ''' </summary>
    <TestMethod()> Public Sub BilletesNumeroIncorrecto()
        Dim dinero As Integer = -158
        Dim resultadoFinal As String
        Dim resultadoEsperado As String = "No has introducido" + vbCrLf + "un número valido"

        ''Se realiza la función con los parametros anteriores
        resultadoFinal = FDivideBilletes(dinero)

        ''Resultado de la prueba
        Assert.AreEqual(resultadoEsperado, resultadoFinal)
    End Sub
    ''' <summary>
    ''' Prueba unitaria de la Application3 para cuando se le pasa un valor incorrecto.
    ''' </summary>
    <TestMethod()> Public Sub BilletesValorIncorrecto()
        Dim dinero As String = "abc"
        Dim resultadoFinal As String
        Dim resultadoEsperado As String = "No has introducido" + vbCrLf + "un valor válido."

        ''Se realiza la función con los parametros anteriores
        resultadoFinal = FDivideBilletes(dinero)

        ''Resultado de la prueba
        Assert.AreEqual(resultadoEsperado, resultadoFinal)
    End Sub
End Class