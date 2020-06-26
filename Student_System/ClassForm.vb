Imports System.Drawing.Text
Imports Bunifu.UI.WinForms.BunifuButton

Public Class ClassForm
    Private Subjects As New ArrayList()

    Private Sub ClassForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub subSave_Click(sender As Object, e As EventArgs) Handles subSave.Click
        Dim Subject As String = addSubject.Text.Trim.ToLower
        If Subject.Length = 0 Then
            MessageBox.Show("Please enter a subject", "Subject Error")
        ElseIf Subjects.Contains(Subject) Then
            MessageBox.Show("The SubjectList contains the same subject name", "Change Subject")
        Else
            Subjects.Add(Subject)
            Dim subjectButton As New BunifuButton()
            subjectButton.Text = Subject
            subjectButton.IdleFillColor = Color.White
            subjectButton.IdleBorderRadius = 10
            subjectButton.IdleBorderColor = Color.FromArgb(40, 21, 100)
            subjectButton.ForeColor = Color.FromArgb(40, 21, 100)
            subjectButton.OnPressedState.FillColor = Color.FromArgb(40, 21, 100)
            subjectButton.OnPressedState.ForeColor = Color.White
            subjectButton.OnPressedState.BorderColor = Color.White
            subjectButton.onHoverState.FillColor = Color.FromArgb(40, 21, 100)
            subjectButton.OnPressedState.ForeColor = Color.White
            subjectButton.OnPressedState.BorderColor = Color.White
            subjectButton.IdleIconRightImage = Image.FromFile("C:\Users\NANAKAY\Downloads\icons8-cancel-40.png")
            addSubjectList.Controls.Add(subjectButton)
        End If
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles saveClass.Click
        If className.Text.Trim.Length = 0 & classFee.Text.Trim.Length = 0 Then
            MessageBox.Show("Please these are required fields", "Field Empty")
        Else
            Dashboard.classPage.Show()
            Me.Close()
        End If
    End Sub

    Private Sub className_TextChanged(sender As Object, e As EventArgs) Handles className.TextChanged
        If Text.Trim.Length = 0 Then
            MessageBox.Show("Please field is required", "Empty")
        End If
    End Sub

    Private Sub classFee_TextChanged(sender As Object, e As EventArgs) Handles classFee.TextChanged
        If Text.Trim.Length = 0 Then
            MessageBox.Show("Please field is required", "Empty")
        End If
    End Sub
End Class