Imports System.Data.SqlClient

Public Class StudentDelete
    Dim LoadStudents As New Student

    Dim sql As String = "Data Source=Kumamakura;Initial Catalog=daschule;Integrated Security=True"
    Dim koneksi As New SqlConnection(sql)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Student.Show()
    End Sub

    Private Sub btnEditData_Click(sender As Object, e As EventArgs) Handles btnDeleteData.Click
        koneksi.Open()

        Dim command As SqlCommand = New SqlCommand("spDeleteDataSiswa", koneksi)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@id_siswa", SqlDbType.VarChar).Value = txtStudentsID.Text.Trim()

        command.ExecuteNonQuery()

        MessageBox.Show("Data has been deleted!")


        koneksi.Close()

        Me.Hide()
        Student.Hide()
        LoadStudents.LoadStudent()
        LoadStudents.Show()

    End Sub

    Private Sub StudentDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


End Class