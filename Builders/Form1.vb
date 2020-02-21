Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblDiameter, dblPrice, dblCircumference, dblTotalPrice As Double
        Const decPI As Decimal = 3.1415D

        dblDiameter = Convert.ToDouble(txtDiameter.Text)
        dblPrice = Convert.ToDouble(txtPrice.Text)

        dblCircumference = dblDiameter * decPI
        lblOutputCir.Text = "The circumference is " & dblCircumference.ToString("F3")

        dblTotalPrice = dblPrice * dblCircumference
        lblOutputPrice.Text = "The total price of the material is " & dblTotalPrice.ToString("C2")
    End Sub

    Private Sub lblDiameter_Click(sender As Object, e As EventArgs) Handles lblDiameter.Click

    End Sub

    Private Sub lblPrice_Click(sender As Object, e As EventArgs) Handles lblPrice.Click

    End Sub
End Class
