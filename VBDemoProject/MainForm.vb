Public Class MainForm
    Dim MyCalcs As New DoSomeMath
    Private Sub ButtonCalcHyp_Click(sender As Object, e As EventArgs) Handles ButtonCalcHyp.Click
        Dim a, b As Double

        If Double.TryParse(TextBoxA.Text, a) Then
            'Read valid number for a from text box.
        Else
            MsgBox("Please enter a valid number for a")
        End If

        If Double.TryParse(TextBoxB.Text, b) Then
            'Read valid number for b from text box.
        Else
            MsgBox("Please enter a valid number for b")
        End If

        TextBoxC.Text = MyCalcs.Pythagoras(a, b)
    End Sub
End Class
