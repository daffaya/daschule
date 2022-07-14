Public Class StudentDeleteConfirm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        StudentDelete.Show()
    End Sub

    Private Sub btnEditData_Click(sender As Object, e As EventArgs) Handles btnEditData.Click
        Me.Hide()
        Student.Show()
    End Sub
End Class