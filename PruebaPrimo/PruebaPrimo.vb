Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace PruebaNumPrimo
    <TestClass()> Public Class PruebaPrimo

        <TestMethod()> Public Sub NumeroPrimo()
            Dim NumeroPrimo As Integer = 3
            Dim ResultadoFinal As String
            Dim ResultadoEsperado As String = "El número 3 es primo."

            ''Se realiza la función con los parametros anteriores
            ResultadoFinal = NavajaSuiza.Application1.App1Logica.CalculaPrimo(NumeroPrimo)

            ''Resultado de la prueba
            Assert.AreEqual(ResultadoEsperado, ResultadoFinal)
        End Sub
        <TestMethod()> Public Sub NumeroNoPrimo()
            Dim NumeroPrimo As Integer = 4
            Dim ResultadoFinal As String
            Dim ResultadoEsperado As String = "El número 4 NO es primo."

            ''Se realiza la función con los parametros anteriores
            ResultadoFinal = NavajaSuiza.Application1.App1Logica.CalculaPrimo(NumeroPrimo)

            ''Resultado de la prueba
            Assert.AreEqual(ResultadoEsperado, ResultadoFinal)
        End Sub

        <TestMethod()> Public Sub NumeroNoValido()
            Dim NumeroPrimo As Integer = -32
            Dim ResultadoFinal As String
            Dim ResultadoEsperado As String = "No has introducido un valor valido.(-32)"

            ''Se realiza la función con los parametros anteriores
            ResultadoFinal = NavajaSuiza.Application1.App1Logica.CalculaPrimo(NumeroPrimo)

            ''Resultado de la prueba
            Assert.AreEqual(ResultadoEsperado, ResultadoFinal)
        End Sub
    End Class
End Namespace