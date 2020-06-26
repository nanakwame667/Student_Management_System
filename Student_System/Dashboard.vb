Public Class Dashboard
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles BunifuButton6.Click
        Application.Exit()
    End Sub

    Private Sub BunifuButton7_Click(sender As Object, e As EventArgs) Handles BunifuButton7.Click
        AuthenScreen.Show()
        Me.Close()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles adminTab.Click
        indicator.Top = (CType(sender, Control)).Top
        BunifuPages1.SetPage(0)
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles studentTab.Click
        indicator.Top = (CType(sender, Control)).Top
        BunifuPages1.SetPage(1)
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles courseTab.Click
        indicator.Top = (CType(sender, Control)).Top
        BunifuPages1.SetPage(2)
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles classTab.Click
        indicator.Top = (CType(sender, Control)).Top
        BunifuPages1.SetPage(3)
    End Sub

    Private Sub BunifuButton8_Click(sender As Object, e As EventArgs) Handles eventTab.Click
        indicator.Top = (CType(sender, Control)).Top
        BunifuPages1.SetPage(4)
    End Sub

    Private Sub BunifuButton9_Click(sender As Object, e As EventArgs) Handles settingsTab.Click
        indicator.Top = (CType(sender, Control)).Top
        BunifuPages1.SetPage(5)
    End Sub

    Private Sub BunifuPictureBox1_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            BunifuPictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles adminPage.Click

    End Sub

    Private Sub TabPage6_Click(sender As Object, e As EventArgs) Handles TabPage6.Click

    End Sub

    Private Sub addAdmin_Click(sender As Object, e As EventArgs) Handles addAdmin.Click
        adminForm.Show()
    End Sub

    Private Sub addStudent_Click(sender As Object, e As EventArgs) Handles addStudent.Click
        StudentForm.Show()
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles classPage.Click

    End Sub

    Private Sub AddClass_Click(sender As Object, e As EventArgs) Handles AddClass.Click
        ClassForm.Show()
    End Sub

    Private Sub Profile_Click(sender As Object, e As EventArgs) Handles Profile.Click
        StudentProfile.Show()
    End Sub

    Private Sub BunifuDataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView2.CellContentClick

    End Sub
End Class