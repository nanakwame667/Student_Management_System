Public Class StudentForm
    Private Sub studSave_Click(sender As Object, e As EventArgs) Handles studSave.Click

        Me.Close()
    End Sub

    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub studClass_onItemSelected(sender As Object, e As EventArgs) Handles studClass.onItemSelected

    End Sub

    Private Sub studScores_Click(sender As Object, e As EventArgs) Handles studScores.Click
        ScoreForm.Show()
    End Sub
End Class