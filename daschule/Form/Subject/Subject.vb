Public Class Subject
    Private Sub btnTeacher_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click
        Me.Hide()
        Teacher.Show()
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Me.Hide()
        Student.Show()

    End Sub

    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click
        Me.Hide()
        Classroom.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Grade.Show()
    End Sub
End Class