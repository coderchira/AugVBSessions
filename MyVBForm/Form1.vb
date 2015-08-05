Public Class Form1

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        MessageBox.Show("The form is clicked")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClick.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        MessageBox.Show("The button is clicked")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBox.TextChanged
        btnClick.Enabled = True
        txtBox.ForeColor = Color.Red
    End Sub


End Class
