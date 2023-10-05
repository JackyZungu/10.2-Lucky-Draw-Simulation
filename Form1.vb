Public Class Form1
    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click
        Dim myNum As Integer

        Dim LuckyNum As Integer = Int(Rnd() * 10) + 1

        myNum = InputBox("Enter your lucky number and click OK")

        If myNum > LuckyNum Then
            MsgBox("Your number is too big")

        ElseIf myNum < LuckyNum Then
            MsgBox("Your number is too small")
        Else
            MsgBox("Congratulation! You strike the lucky number")
        End If
    End Sub
End Class
