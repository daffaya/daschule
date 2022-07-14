Public Class GradeDelete
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Grade.Show()
    End Sub

    Private Sub btnEditData_Click(sender As Object, e As EventArgs) Handles btnEditData.Click
        Me.Hide()
        GradeDeleteConfirm.Show()
    End Sub
End Class