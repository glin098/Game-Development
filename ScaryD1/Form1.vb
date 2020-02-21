Public Class frmScary
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub picFav_DoubleClick(sender As Object, e As EventArgs) Handles picFav.DoubleClick
        picFav.Hide()
        lblHello.Text = "Where did I go?!?"
    End Sub

    Private Sub lblHello_Click(sender As Object, e As EventArgs) Handles lblHello.Click
        lblHello.Font = New Font("Old English Text MT", 28.0, FontStyle.Bold)
        lblHello.ForeColor = Color.DarkGreen
        lblHello.Text = "WOW!!!!!!"
    End Sub

    Private Sub lblHello_DoubleClick(sender As Object, e As EventArgs) Handles lblHello.DoubleClick
        lblHello.Font = New Font("Old English Text MT", 28.0, FontStyle.Bold)
        lblHello.ForeColor = Color.Blue
        lblHello.Text = "Hello There!"
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        picFav.Show()
        lblHello.Text = "Hello There!"
    End Sub

    Private Sub frmScary_Load(sender As Object, e As EventArgs) Handles Me.Load
        picFav.Hide()
        lblHello.Text = "What is this?"
    End Sub

    Private Sub tmrAppear_Tick(sender As Object, e As EventArgs) Handles tmrAppear.Tick
        picFav.Show()
        tmrAppear.Enabled = False
    End Sub

    Private Sub tmrDisappear_Tick(sender As Object, e As EventArgs) Handles tmrDisappear.Tick
        picFav.Hide()
        lblHello.Text = "Where did I go??"
        tmrDisappear.Enabled = False
    End Sub

    Private Sub tmrReappear_Tick(sender As Object, e As EventArgs) Handles tmrReappear.Tick
        picFav.Show()
        lblHello.Text = "Peak-a-boo! I got you!!!!"
        tmrReappear.Enabled = False
    End Sub
End Class
