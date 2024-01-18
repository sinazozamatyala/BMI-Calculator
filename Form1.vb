Public Class Form1
    Private Sub lblCalculate_Click(sender As Object, e As EventArgs) Handles lblCalculate.Click

        Dim height, weight, bmi As Double
        weight = Val(txtWeight.Text)
        height = Val(txtHeight.Text)
        bmi = weight / (height) ^ 2 'BMI formular

        txtBMI.Text = bmi

        If bmi < 18 Then
            txtComment.Text = "You are under weight"
        ElseIf 18 <= bmi And bmi < 26 Then
            txtComment.Text = "You are normal"
        Else
            txtComment.Text = "You are over weight"
        End If
    End Sub
End Class
