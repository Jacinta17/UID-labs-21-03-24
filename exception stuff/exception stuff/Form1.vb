Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim answer, n1, n2 As Integer

        Try
            n1 = Val(TextBox1.Text)
            n2 = TextBox2.Text
            If (n1 = 0 Or n2 = 0) Then
                Throw New ApplicationException(" zero exception")
            ElseIf (n1 > 10 & n2 > 10) Then
                Throw New ApplicationException(" no")
            Else

                answer = n1 \ n2
            End If

        Catch ex As DivideByZeroException
            MsgBox(ex.ToString)
        Catch ex As InvalidCastException
            MsgBox("empty string")
        Catch ex As ApplicationException
            MsgBox(" change the number to anythg other than zero")

        Finally
            MsgBox(answer)
        End Try

    End Sub
End Class
