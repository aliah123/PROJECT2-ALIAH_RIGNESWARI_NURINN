Public Class Food
    Private Sub Food_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadDataFromDB()
    End Sub

    Public Sub ReadDataFromDB()
        Dim retrieveTable As New DataTable
        Dim RetrieveMySQL As New VBMySQL
        Try
            retrieveTable = RetrieveMySQL.Retrieve_Table("SELECT * FROM Food")
            If retrieveTable.CreateDataReader.HasRows = False Then
                MessageBox.Show("Data Not Found!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Dim row As DataRow
            dgvFood.Rows.Clear()
            Dim Bil As Integer
            Bil = 1
            For Each row In retrieveTable.Rows
                dgvFood.Rows.Add(Bil, row("idfood"), row("itemCode"), row("nameFood"), row("quantity"), row("type"))
                Bil = Bil + 1
            Next
            retrieveTable = Nothing
        Catch ex As Exception
            MessageBox.Show("Process read data failed!" & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvFood_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFood.CellContentClick
        Dim strIdFood As String
        If e.RowIndex < 0 Then Exit Sub
        strIdFood = dgvFood.Item(1, e.RowIndex).Value.ToString()
        UpdateFood.idFood = CInt(strIdFood)
        Dim Result As New ArrayList
        Dim retrieveRow As New VBMySQL
        Dim strSql As String = "SELECT * FROM food WHERE idfood = " & strIdFood
        Try
            Result = retrieveRow.Retrieve_Row(strSql)
        Catch ex As Exception
            MessageBox.Show("Process read data failed!" & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        For Each row As Dictionary(Of String, Object) In Result
            With UpdateFood
                .txtCode.Text = row("itemCode").ToString()
                .txtName.Text = row("nameFood").ToString()
                .txtQuantity.Text = row("quantity").ToString()
                .txtType.Text = row("type").ToString()
            End With
        Next
        Me.Hide()
        UpdateFood.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strCode As String = txtCode.Text
        Dim strName As String = txtName.Text
        Dim strQuantity As String = txtQuantity.Text
        Dim strType As String = txtType.Text

        Dim strSql = "INSERT INTO food VALUES (null, '" & strCode & "', '" & strName & "', '" & strQuantity & "', '" & strType & "')"
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
        txtCode.Clear()
        txtName.Clear()
        txtQuantity.Clear()
        txtType.Clear()
        Me.Hide()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        txtCode.Clear()
        txtName.Clear()
        txtQuantity.Clear()
        txtType.Clear()
        Me.Hide()
        UpdateFood.Show()
    End Sub
End Class