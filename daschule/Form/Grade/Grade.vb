Public Class Grade
    Private Sub DGSiswa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSiswa.CellContentClick

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub btnAddData_Click(sender As Object, e As EventArgs) Handles btnAddData.Click
        Me.Hide()
        GradeAddForm.Show()
    End Sub

    Private Sub btnEditData_Click(sender As Object, e As EventArgs) Handles btnEditData.Click
        Me.Hide()
        GradeEditForm.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.Hide()
        GradeDelete.Show()
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Me.Hide()
        Student.Show()
    End Sub
End Class