Public Class UpdateCustomer
    Public idUpCustomer As Integer

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim strName As String = txtName.Text
        Dim strAge As String = txtAge.Text
        Dim strAddress As String = txtAddress.Text
        Dim strphoneNum As String = txtphoneNum.Text
        Dim strGender As String = txtGender.Text
        Dim strSql = "UPDATE customer SET name = '" & strName & "', age = '" & strAge & "', address = '" & strAddress & "',
        phoneNum = '" & strphoneNum & "', gender = '" & strGender & "' WHERE idcustomer = " & idUpCustomer
        Dim UpdateMySQL As New VBMySQL
        Try
            UpdateMySQL.Insert_Row(strSql)
        Catch ex As Exception
            MessageBox.Show("Process save data failed!" & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Chef.ReadDataFromDB()
            btnCancel_Click(sender, e)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtName.Clear()
        txtAge.Clear()
        txtAddress.Clear()
        txtphoneNum.Clear()
        txtGender.Clear()
        Me.Hide()
        Customer.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim DeleteMySQL As New VBMySQL
        Dim strSql As String = "DELETE FROM customer WHERE idcustomer = " & idUpCustomer
        Try
            DeleteMySQL.Delete_Row(strSql)
        Catch ex As Exception
            MessageBox.Show("Process delete data failed!" & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Customer.ReadDataFromDB()
            btnCancel_Click(sender, e)
        End Try
    End Sub

End Class