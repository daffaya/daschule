Public Class GradeAddForm

    Dim LoadGrades As New Grade
    Public Sub ClearStudent()
        txtStudentsID.Clear()
        txtKKM.Clear()
        txtGrade.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Grade.Show()
    End Sub

    Private Sub btnEditData_Click(sender As Object, e As EventArgs) Handles btnSaveData.Click
        Me.Hide()
        Grade.Show()
    End Sub



End Class