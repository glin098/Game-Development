Public Class Form1
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnExpo.Click
        Dim dblNum1, dblNum2, dblAnswer As Double
        Dim strName As String

        dblNum1 = Convert.ToDouble(txtNum1.Text)
        dblNum2 = Convert.ToDouble(txtNum2.Text)
        strName = txtName.Text

        dblAnswer = dblNum1 ^ dblNum2

        lblOpSign.Text = "^"
        lblOutput.Text = "Hello " & strName & "!" & ControlChars.NewLine & dblNum1 & "^" & dblNum2 & " = " & dblAnswer
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Dim dblNum1, dblNum2, dblAnswer As Double
        Dim strName As String

        dblNum1 = Convert.ToDouble(txtNum1.Text)
        dblNum2 = Convert.ToDouble(txtNum2.Text)
        strName = txtName.Text

        dblAnswer = dblNum1 Mod dblNum2

        lblOpSign.Text = "%"
        lblOutput.Text = "Hello " & strName & "!" & ControlChars.NewLine & dblNum1 & "%" & dblNum2 & " = " & dblAnswer
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnIntDivision.Click
        Dim intNum1, intNum2, intAnswer As Integer
        Dim strName As String

        intNum1 = Convert.ToInt32(txtNum1.Text)
        intNum2 = Convert.ToInt32(txtNum2.Text)
        strName = txtName.Text

        intAnswer = intNum1 \ intNum2

        lblOpSign.Text = "\"
        lblOutput.Text = "Hello " & strName & "!" & ControlChars.NewLine & intNum1 & "\" & intNum2 & " = " & intAnswer
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblOutput.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim intNum1, intNum2, intAnswer As Integer
        Dim strName As String

        intNum1 = Convert.ToInt32(txtNum1.Text)
        intNum2 = Convert.ToInt32(txtNum2.Text)
        strName = txtName.Text

        intAnswer = intNum1 + intNum2

        lblOpSign.Text = "+"
        lblOutput.Text = "Hello " & strName & "!" & ControlChars.NewLine & intNum1 & "+" & intNum2 & " = " & intAnswer
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Dim dblNum1, dblNum2, dblAnswer As Double
        Dim strName As String

        dblNum1 = Convert.ToDouble(txtNum1.Text)
        dblNum2 = Convert.ToDouble(txtNum2.Text)
        strName = txtName.Text

        dblAnswer = dblNum1 / dblNum2

        lblOpSign.Text = "/"
        lblOutput.Text = "Hello " & strName & "!" & ControlChars.NewLine & dblNum1 & "/" & dblNum2 & " = " & dblAnswer
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Dim dblNum1, dblNum2, dblAnswer As Double
        Dim strName As String

        dblNum1 = Convert.ToDouble(txtNum1.Text)
        dblNum2 = Convert.ToDouble(txtNum2.Text)
        strName = txtName.Text

        dblAnswer = dblNum1 * dblNum2

        lblOpSign.Text = "x"
        lblOutput.Text = "Hello " & strName & "!" & ControlChars.NewLine & dblNum1 & "x" & dblNum2 & " = " & dblAnswer
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        Dim dblNum1, dblNum2, dblAnswer As Double
        Dim strName As String

        dblNum1 = Convert.ToDouble(txtNum1.Text)
        dblNum2 = Convert.ToDouble(txtNum2.Text)
        strName = txtName.Text

        dblAnswer = dblNum1 - dblNum2

        lblOpSign.Text = "-"
        lblOutput.Text = "Hello " & strName & "!" & ControlChars.NewLine & dblNum1 & "-" & dblNum2 & " = " & dblAnswer
    End Sub
End Class
