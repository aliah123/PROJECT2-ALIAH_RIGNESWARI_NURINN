Public Class RestaurantHome
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub ChefToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChefToolStripMenuItem.Click
        Chef.ShowDialog()
    End Sub

    Private Sub StaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem.Click
        Staff.ShowDialog()
    End Sub

    Private Sub CustomerDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerDataToolStripMenuItem.Click
        CustomerHome.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class