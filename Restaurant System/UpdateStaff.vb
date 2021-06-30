Public Class UpdateStaff
    Public idStaff As Integer

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strName As String = txtName.Text
        Dim strPosition As String = txtPosition.Text
        Dim strphoneNum As String = txtphoneNum.Text
        Dim strGender As String = txtGender.Text
        Dim strdateInCharge As String = txtdateInCharge.Text
        Dim strSql = "UPDATE staff SET nameStaff = '" & strName & "', position = '" & strPosition & "',
        phoneNum = '" & strphoneNum & "', gender = '" & strGender & "',dateInCharge = '" & strdateInCharge & "' WHERE idstaff = " & idStaff
        Dim UpdateMySQL As New VBMySQL
        Try
            UpdateMySQL.Insert_Row(strSql)
        Catch ex As Exception
            MessageBox.Show("Process save data failed!" & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Staff.ReadDataFromDB()
            btnCancel_Click(sender, e)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtName.Clear()
        txtPosition.Clear()
        txtphoneNum.Clear()
        txtGender.Clear()
        txtdateInCharge.Clear()
        Me.Hide()
        Staff.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim DeleteMySQL As New VBMySQL
        Dim strSql As String = "DELETE FROM staff WHERE idstaff = " & idStaff
        Try
            DeleteMySQL.Delete_Row(strSql)
        Catch ex As Exception
            MessageBox.Show("Process delete data failed!" & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Chef.ReadDataFromDB()
            btnCancel_Click(sender, e)
        End Try
    End Sub

End Class