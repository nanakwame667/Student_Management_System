Public Class AuthenScreen
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Me.Hide()
        Dashboard.Show()

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub BunifuTextBox3_TextChanged(sender As Object, e As EventArgs) Handles BunifuTextBox3.TextChanged

    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        BunifuPages1.SetPage(1)
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        BunifuPages1.SetPage(0)
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        BunifuPages1.SetPage(2)

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub BunifuButton8_Click(sender As Object, e As EventArgs) Handles BunifuButton8.Click
        BunifuPages1.SetPage(0)
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        BunifuPages1.SetPage(0)
    End Sub
End Class
