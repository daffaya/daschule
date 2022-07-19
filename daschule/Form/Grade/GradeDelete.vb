Imports System.Data.SqlClient
Public Class GradeDelete
    Dim sql As String = "Data Source=Kumamakura;Initial Catalog=daschule;Integrated Security=True"
    Dim koneksi As New SqlConnection(sql)

    Dim LoadGrades As New Grade
    Public Sub ClearGrade()
        txtStudentsID.Clear()
        txtSubjectName.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Grade.Show()
    End Sub

    Private Sub btnEditData_Click(sender As Object, e As EventArgs) Handles btnEditData.Click
        koneksi.Open()

        Dim command As SqlCommand = New SqlCommand("spDeleteDataNilai", koneksi)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@id_siswa", SqlDbType.VarChar).Value = txtStudentsID.Text.Trim()
        command.Parameters.AddWithValue("@nama", SqlDbType.VarChar).Value = txtSubjectName.Text.Trim()

        command.ExecuteNonQuery()

        MessageBox.Show("Data has been deleted!")


        koneksi.Close()

        Me.Hide()
        Student.Hide()
        LoadGrades.LoadGrade()
        LoadGrades.Show()
    End Sub


End Class