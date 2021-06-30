Public Class CustomerHome
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub FoListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FoListToolStripMenuItem.Click
        FoodList.ShowDialog()
    End Sub

    Private Sub CustomerDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerDetailToolStripMenuItem.Click
        Customer.ShowDialog()
    End Sub

    Private Sub FoodOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FoodOrderToolStripMenuItem.Click
        Food.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class