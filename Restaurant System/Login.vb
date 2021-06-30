Public Class Login
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "admin" Then
            'MessageBox.Show("Login Sucessfully!")
            RestaurantHome.Show()
            Hide()

        ElseIf txtUsername.Text = "chef" And txtPassword.Text = "chef" Then
            'MessageBox.Show("Login Sucessfully!")
            RestaurantHome.Show()
            Hide()

        ElseIf txtUsername.Text = "customer" And txtPassword.Text = "customer" Then
            'MessageBox.Show("Login Sucessfully!")
            CustomerHome.Show()
            Hide()

        Else
            MessageBox.Show("Login Failed!")
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class