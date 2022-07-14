Public Class GradeDeleteConfirm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        GradeDelete.Show()
    End Sub

    Private Sub btnEditData_Click(sender As Object, e As EventArgs) Handles btnEditData.Click
        Me.Hide()
        Grade.Show()
    End Sub
End Class