Public Class GradeEditForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Grade.Show()
    End Sub

    Private Sub btnEditData_Click(sender As Object, e As EventArgs) Handles btnSaveData.Click
        Me.Hide()
        Grade.Show()
    End Sub

    Private Sub GradeEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class