Public Class Form1
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim Login As New Login()

        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnChef_Click(sender As Object, e As EventArgs) Handles btnChef.Click
        Dim Login As New Login()

        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnCus_Click(sender As Object, e As EventArgs) Handles btnCus.Click
        Dim Login As New Login()

        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
