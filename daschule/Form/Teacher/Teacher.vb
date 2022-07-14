Public Class Teacher
    Private Sub btnSubject_Click(sender As Object, e As EventArgs) Handles btnSubject.Click
        Me.Hide()
        Subject.Show()
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Me.Hide()
        Student.Show()
    End Sub

    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click
        Me.Hide()
        Classroom.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
        Me.Hide()
        Grade.Show()
    End Sub
End Class