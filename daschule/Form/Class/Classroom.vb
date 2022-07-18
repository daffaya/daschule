Imports System.Data.SqlClient

Public Class Classroom
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSubject.Click
        Me.Hide()
        Subject.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click
        Me.Hide()
        Teacher.Show()
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Me.Hide()
        Student.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Grade.Show()
    End Sub

    Private Sub Classroom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClassroom()
    End Sub

    'GANTI VIEW NYA!
    Public Sub LoadClassroom()
        koneksi.Open()
        DGSiswa.Update()
        DGSiswa.Refresh()
        Dim Sql As String = "SELECT * FROM vAllStudent"
        Dim adaptor As New SqlDataAdapter(Sql, koneksi)
        Dim data As New DataSet()

        adaptor.Fill(data, "vAllStudent")
        DGSiswa.DataSource = data
        DGSiswa.DataMember = "vAllStudent"

        koneksi.Close()
    End Sub

End Class