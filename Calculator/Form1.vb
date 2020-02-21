Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Dim dblNum1, dblNum2, dblAnswer As Double

        dblNum1 = Convert.ToDouble(txtNum1.Text)
        dblNum2 = Convert.ToDouble(txtNum2.Text)

        dblAnswer = dblNum1 / dblNum2

        lblOpSign.Text = "/"
        lblOutput.Text = Convert.ToString(dblAnswer)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblOpSign.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblOutput.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        'Declaring Variables
        Dim intNum1, intNum2, intAnswer As Integer

        'Input/Store Values
        intNum1 = Convert.ToInt32(txtNum1.Text)
        intNum2 = Convert.ToInt32(txtNum2.Text)

        'Math Calculations
        intAnswer = intNum1 + intNum2

        'Output
        lblOpSign.Text = "+"
        lblOutput.Text = Convert.ToString(intAnswer)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnIntDiv.Click
        Dim intNum1, intNum2, intAnswer As Integer

        intNum1 = Convert.ToInt32(txtNum1.Text)
        intNum2 = Convert.ToInt32(txtNum2.Text)

        intAnswer = intNum1 \ intNum2

        lblOpSign.Text = "\"
        lblOutput.Text = Convert.ToString(intAnswer)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Dim dblNum1, dblNum2, dblAnswer As Double

        dblNum1 = Convert.ToDouble(txtNum1.Text)
        dblNum2 = Convert.ToDouble(txtNum2.Text)

        dblAnswer = dblNum1 Mod dblNum2

        lblOpSign.Text = "%"
        lblOutput.Text = Convert.ToString(dblAnswer)
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Dim dblNum1, dblNum2, dblAnswer As Double

        dblNum1 = Convert.ToDouble(txtNum1.Text)
        dblNum2 = Convert.ToDouble(txtNum2.Text)

        dblAnswer = dblNum1 - dblNum2

        lblOpSign.Text = "-"
        lblOutput.Text = Convert.ToString(dblAnswer)
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        Dim dblNum1, dblNum2, dblAnswer As Double

        dblNum1 = Convert.ToDouble(txtNum1.Text)
        dblNum2 = Convert.ToDouble(txtNum2.Text)

        dblAnswer = dblNum1 * dblNum2

        lblOpSign.Text = "x"
        lblOutput.Text = Convert.ToString(dblAnswer)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnExpo_Click(sender As Object, e As EventArgs) Handles btnExpo.Click
        Dim dblNum1, dblNum2, dblAnswer As Double

        dblNum1 = Convert.ToDouble(txtNum1.Text)
        dblNum2 = Convert.ToDouble(txtNum2.Text)

        dblAnswer = dblNum1 ^ dblNum2

        lblOpSign.Text = "^"
        lblOutput.Text = Convert.ToString(dblAnswer)
    End Sub
End Class
