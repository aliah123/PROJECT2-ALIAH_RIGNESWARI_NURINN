Public Class Customer
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadDataFromDB()
    End Sub

    Public Sub ReadDataFromDB()
        Dim retrieveTable As New DataTable
        Dim RetrieveMySQL As New VBMySQL
        Try
            retrieveTable = RetrieveMySQL.Retrieve_Table("SELECT * FROM customer")
            If retrieveTable.CreateDataReader.HasRows = False Then
                MessageBox.Show("Data Not Found!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Dim row As DataRow
            dgvCustomer.Rows.Clear()
            Dim Bil As Integer
            Bil = 1
            For Each row In retrieveTable.Rows
                dgvCustomer.Rows.Add(Bil, row("idcustomer"), row("nameCus"), row("ageCus"), row("addressCus"), row("phoneNumCus"), row("genderCus"))
                Bil = Bil + 1
            Next
            retrieveTable = Nothing
        Catch ex As Exception
            MessageBox.Show("Process read data failed!" & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvCustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomer.CellContentClick
        Dim strIdCustomer As String
        If e.RowIndex < 0 Then Exit Sub
        strIdCustomer = dgvCustomer.Item(1, e.RowIndex).Value.ToString()
        UpdateCustomer.idUpCustomer = CInt(strIdCustomer)
        Dim Result As New ArrayList
        Dim retrieveRow As New VBMySQL
        Dim strSql As String = "SELECT * FROM customer WHERE idcustomer = " & strIdCustomer
        Try
            Result = retrieveRow.Retrieve_Row(strSql)
        Catch ex As Exception
            MessageBox.Show("Process read data failed!" & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        For Each row As Dictionary(Of String, Object) In Result
            With UpdateCustomer
                .txtName.Text = row("nameCus").ToString()
                .txtAge.Text = row("ageCus").ToString()
                .txtAddress.Text = row("addressCus").ToString()
                .txtphoneNum.Text = row("phoneNumCus").ToString()
                .txtGender.Text = row("genderCus").ToString()
            End With
        Next
        Me.Hide()
        UpdateCustomer.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strName As String = txtName.Text
        Dim strAge As String = txtAge.Text
        Dim strAddress As String = txtAddress.Text
        Dim strphoneNum As String = txtphoneNum.Text
        Dim strGender As String = txtGender.Text
        Dim strSql = "INSERT INTO customer VALUES (null, '" & strName & "', '" & strAge & "', '" & strAddress & "',
                     '" & strphoneNum & "', '" & strGender & "')"
        Dim CreateMySQL As New VBMySQL
        Try
            CreateMySQL.Insert_Row(strSql)
        Catch ex As Exception
            MessageBox.Show("Process read data failed!" & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.ReadDataFromDB()
            btnCancel_Click(sender, e)
        End Try

        Me.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtName.Clear()
        txtAge.Clear()
        txtAddress.Clear()
        txtphoneNum.Clear()
        txtGender.Clear()
        Me.Hide()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        txtName.Clear()
        txtAge.Clear()
        txtAddress.Clear()
        txtphoneNum.Clear()
        txtGender.Clear()
        Me.Hide()
        UpdateCustomer.Show()
    End Sub
End Class