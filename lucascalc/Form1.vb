Public Class Form1
    'first value and last value'
    Dim firstValue, secondValue, result As Double
    Dim operat As String
    Dim operatorDoubleClicked As Integer = 1
    Dim a As Integer = -1


    'this is the dot button'
    Private Sub Button25_Click(sender As Object, e As EventArgs)
        'maxmize button'

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If txtDisplay.Text.Contains(".") Then

        Else
            txtDisplay.Text += "."
        End If

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click


        If txtDisplay.Text = "" Then
            secondValue = 0
        Else
            secondValue = txtDisplay.Text
        End If

        If operat = "+" Then

            result = firstValue + secondValue


            txtDisplay.Text = result
        ElseIf operat = "-" Then
            result = firstValue - secondValue
            txtDisplay.Text = result
        ElseIf operat = "X" Then
            result = firstValue * secondValue
            txtDisplay.Text = result
        ElseIf operat = "÷" Then
            result = firstValue / secondValue
            txtDisplay.Text = result
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtDisplay.Text = "0"

        firstValue = 0
        secondValue = 0
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim sqrt As Double = Math.Sqrt(txtDisplay.Text)
        txtDisplay.Text = sqrt

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtDisplay.Text = txtDisplay.Text * txtDisplay.Text

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim oneOverX As Double
        oneOverX = 1 / txtDisplay.Text
        txtDisplay.Text = oneOverX
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtDisplay.Text.Length = 1 Then

            txtDisplay.Text = "0"
        ElseIf txtDisplay.Text.Length > 1 Then

            a = txtDisplay.Text.Length - 1

            If a < txtDisplay.Text.Length Then

                txtDisplay.Text = txtDisplay.Text.Remove(a)
            End If

        End If
    End Sub

    Private Sub OPERATORS(sender As Object, e As EventArgs) Handles Button8.Click, Button20.Click, Button16.Click, Button12.Click
        Dim button As Button = sender


        firstValue = txtDisplay.Text
        txtDisplay.Text = ""
        operat = button.Text
        '' txtBox1.Text += button.Text


    End Sub


    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Me.Close()

    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN(sender As Object, e As EventArgs) Handles Button9.Click, Button22.Click, Button19.Click, Button18.Click, Button17.Click, Button15.Click, Button14.Click, Button13.Click, Button11.Click, Button10.Click
        Dim button As Button = sender

        If txtDisplay.Text = "0" Then

            txtDisplay.Text = button.Text
        Else
            txtDisplay.Text += button.Text
        End If
    End Sub
End Class
'COPY AT YOUR OWN RISK ESPECIALLY MALCOM AND COUNCILOR'