Public Class Chef
    Private Sub Chef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadDataFromDB()
    End Sub

    Public Sub ReadDataFromDB()
        Dim retrieveTable As New DataTable
        Dim RetrieveMySQL As New VBMySQL
        Try
            retrieveTable = RetrieveMySQL.Retrieve_Table("SELECT * FROM chef")
            If retrieveTable.CreateDataReader.HasRows = False Then
                MessageBox.Show("Data Not Found!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Dim row As DataRow
            dgvChef.Rows.Clear()
            Dim Bil As Integer
            Bil = 1
            For Each row In retrieveTable.Rows
                dgvChef.Rows.Add(Bil, row("idchef"), row("namechef"), row("positionChef"), row("phoneNumChef"), row("genderChef"), row("dateInChargeChef"))
                Bil = Bil + 1
            Next
            retrieveTable = Nothing
        Catch ex As Exception
            MessageBox.Show("Process read data failed!" & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvChef_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChef.CellContentClick

        Dim strIdchef As String
        If e.RowIndex < 0 Then Exit Sub
        strIdchef = dgvChef.Item(1, e.RowIndex).Value.ToString()
        UpdateChef.idChef = CInt(strIdchef)
        Dim Result As New ArrayList
        Dim retrieveRow As New VBMySQL
        Dim strSql As String = "SELECT * FROM chef WHERE idchef = " & strIdchef
        Try
            Result = retrieveRow.Retrieve_Row(strSql)
        Catch ex As Exception
            MessageBox.Show("Process read data failed!" & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        For Each row As Dictionary(Of String, Object) In Result
            With UpdateChef
                .txtName.Text = row("namechef").ToString()
                .txtPosition.Text = row("positionChef").ToString()
                .txtphoneNum.Text = row("phoneNumChef").ToString()
                .txtGender.Text = row("genderChef").ToString()
                .txtdateInCharge.Text = row("dateInChargeChef").ToString()
            End With
        Next
        Me.Hide()
        UpdateChef.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim strName As String = txtName.Text
        Dim strPosition As String = txtPosition.Text
        Dim strphoneNum As String = txtphoneNum.Text
        Dim strGender As String = txtGender.Text
        Dim strdateInCharge As String = txtdateInCharge.Text
        Dim strSql = "INSERT INTO chef VALUES (null, '" & strName & "', '" & strPosition & "', '" & strphoneNum & "', '" & strGender & "', '" & strdateInCharge & "')"
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
        'Me.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        txtName.Show()
        txtPosition.Clear()
        txtphoneNum.Clear()
        txtGender.Clear()
        txtdateInCharge.Clear()
        Me.Hide()
        UpdateChef.Show()
    End Sub
End Class