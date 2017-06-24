Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports NavajaSuiza.Application1.App1Logica

Namespace PruebaNumPrimo
    <TestClass()> Public Class PruebaPrimo
        Dim Apliacacion As New NavajaSuiza.Application1.App1Logica
        ''' <summary>
        ''' Prueba unitaria de la Application1 para numero primo.
        ''' </summary>
        <TestMethod()> Public Sub NumeroPrimo()
            Dim numeroPrimo As Integer = 3
            Dim resultadoFinal As String
            Dim resultadoEsperado As String = "El número 3" + vbCrLf + " es primo."

            ''Se realiza la función con los parametros anteriores
            resultadoFinal = Apliacacion.CalculaPrimo(numeroPrimo)

            ''Resultado de la prueba
            Assert.AreEqual(resultadoEsperado, resultadoFinal)
        End Sub
        ''' <summary>
        ''' Prueba unitaria de la Application1 para numero NO primo.
        ''' </summary>
        <TestMethod()> Public Sub NumeroNoPrimo()
            Dim numeroPrimo As Integer = 4
            Dim resultadoFinal As String
            Dim resultadoEsperado As String = "El número 4" + vbCrLf + " NO es primo."

            ''Se realiza la función con los parametros anteriores
            resultadoFinal = Apliacacion.CalculaPrimo(numeroPrimo)

            ''Resultado de la prueba
            Assert.AreEqual(resultadoEsperado, resultadoFinal)
        End Sub
        ''' <summary>
        ''' Prueba unitaria de la Application1 para conversión incorrecta de numero primo.
        ''' </summary>
        <TestMethod()> Public Sub NumeroNoValido()
            Dim numeroPrimo As Integer = -32
            Dim resultadoFinal As String
            Dim resultadoEsperado As String = "No has introducido " + vbCrLf + " un valor valido.(-32)"

            ''Se realiza la función con los parametros anteriores
            resultadoFinal = Apliacacion.CalculaPrimo(numeroPrimo)

            ''Resultado de la prueba
            Assert.AreEqual(resultadoEsperado, resultadoFinal)
        End Sub
    End Class
End Namespace