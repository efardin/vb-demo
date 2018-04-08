Public Class DoSomeMath
    Private Cpl(10) As Double

    Public Function Pythagoras(ByVal a As Double, b As Double) As Double
        Return Math.Sqrt(a * a + b * b)
    End Function
End Class
