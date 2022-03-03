Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnmenos_Click(sender As Object, e As EventArgs) Handles btnmenos.Click
        Dim numeroEntrante As String = numero1.Text
        numeroEntrante = Restar(numeroEntrante)
        numero1.Text = numeroEntrante
    End Sub

    Function Restar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero - 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function

    Private Sub btnmenos2_Click(sender As Object, e As EventArgs) Handles btnmenos2.Click
        Dim numeroEntrante As String = numero2.Text
        numeroEntrante = Restar(numeroEntrante)
        numero2.Text = numeroEntrante
    End Sub

    Private Sub btnmas_Click(sender As Object, e As EventArgs) Handles btnmas.Click
        Dim numeroEntrante As String = numero1.Text
        numeroEntrante = Sumar(numeroEntrante)
        numero1.Text = numeroEntrante
    End Sub

    Function Sumar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero + 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function

    Private Sub btnmas2_Click(sender As Object, e As EventArgs) Handles btnmas2.Click
        Dim numeroEntrante As String = numero2.Text
        numeroEntrante = Sumar(numeroEntrante)
        numero2.Text = numeroEntrante
    End Sub

    'Codigo Suma
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim txtA = numero1.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = numero2.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoSuma = Suma(numA, numB)
        lbResultado.Text = "El resultado de A + B es " + resultadoSuma.ToString()
    End Sub

    Function Suma(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA + numB
        Return resultado
    End Function


    'Codigo Resta
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim txtA = numero1.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = numero2.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoResta = Resta(numA, numB)
        lbResultado.Text = "El resultado de A - B es " + resultadoResta.ToString()
    End Sub

    Function Resta(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA - numB
        Return resultado
    End Function

    'Codigo Multiplicacion
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim txtA = numero1.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = numero2.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoMultiplicacion = Multiplicacion(numA, numB)
        lbResultado.Text = "El resultado de A * B es " + resultadoMultiplicacion.ToString()
    End Sub

    Function Multiplicacion(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA * numB
        Return resultado
    End Function

    'Codigo Division
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim txtA = numero1.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = numero2.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoDivision = Division(numA, numB)
        lbResultado.Text = "El resultado de A / B es " + resultadoDivision.ToString()
    End Sub

    Function Division(numA As Double, numB As Double) As Double
        Dim resultado As Double
        resultado = numA / numB
        Return resultado
    End Function

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        lbResultado.Text = "El resultado es: "
        numero1.Text = "0"
        numero2.Text = "0"
    End Sub
End Class
