Public Class adminForm
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub adminSave_Click(sender As Object, e As EventArgs) Handles adminSave.Click
        Dashboard.adminPage.Show()
        Me.Close()
    End Sub
End Class