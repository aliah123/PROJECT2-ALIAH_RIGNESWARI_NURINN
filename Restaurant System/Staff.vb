Public Class Staff
    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadDataFromDB()
    End Sub

    Public Sub ReadDataFromDB()
        Dim retrieveTable As New DataTable
        Dim RetrieveMySQL As New VBMySQL
        Try
            retrieveTable = RetrieveMySQL.Retrieve_Table("SELECT * FROM staff")
            If retrieveTable.CreateDataReader.HasRows = False Then
                MessageBox.Show("Data Not Found!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Dim row As DataRow
            dgvStaff.Rows.Clear()
            Dim Bil As Integer
            Bil = 1
            For Each row In retrieveTable.Rows
                dgvStaff.Rows.Add(Bil, row("idstaff"), row("nameStaff"), row("positionStaff"), row("phoneNumStaff"), row("genderStaff"), row("dateInChargeStaff"))
                Bil = Bil + 1
            Next
            retrieveTable = Nothing
        Catch ex As Exception
            MessageBox.Show("Process read data failed!" & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvStaff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaff.CellContentClick

        Dim strIdStaff As String
        If e.RowIndex < 0 Then Exit Sub
        strIdStaff = dgvStaff.Item(1, e.RowIndex).Value.ToString()
        UpdateStaff.idStaff = CInt(strIdStaff)
        Dim Result As New ArrayList
        Dim retrieveRow As New VBMySQL
        Dim strSql As String = "SELECT * FROM staff WHERE idstaff = " & strIdStaff
        Try
            Result = retrieveRow.Retrieve_Row(strSql)
        Catch ex As Exception
            MessageBox.Show("Process read data failed!" & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        For Each row As Dictionary(Of String, Object) In Result
            With UpdateStaff
                .txtName.Text = row("nameStaff").ToString()
                .txtPosition.Text = row("positionStaff").ToString()
                .txtphoneNum.Text = row("phoneNumStaff").ToString()
                .txtGender.Text = row("genderStaff").ToString()
                .txtdateInCharge.Text = row("dateInChargeStaff").ToString()
            End With
        Next
        Me.Hide()
        UpdateStaff.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strName As String = txtName.Text
        Dim strPosition As String = txtPosition.Text
        Dim strphoneNum As String = txtphoneNum.Text
        Dim strGender As String = txtGender.Text
        Dim strdateInCharge As String = txtdateInCharge.Text
        Dim strSql = "INSERT INTO staff VALUES (null, '" & strName & "', '" & strPosition & "', '" & strphoneNum & "', '" & strGender & "','" & strdateInCharge & "')"
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
        txtPosition.Clear()
        txtphoneNum.Clear()
        txtGender.Clear()
        txtdateInCharge.Clear()
        Me.Hide()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        txtName.Clear()
        txtPosition.Clear()
        txtphoneNum.Clear()
        txtGender.Clear()
        txtdateInCharge.Clear()
        Me.Hide()
        UpdateStaff.Show()
    End Sub
End Class