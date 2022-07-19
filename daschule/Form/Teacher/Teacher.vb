Imports System.Data.SqlClient
Public Class Teacher
    Dim sql As String = "Data Source=Kumamakura;Initial Catalog=daschule;Integrated Security=True"
    Dim koneksi As New SqlConnection(sql)
    Private Sub btnSubject_Click(sender As Object, e As EventArgs) Handles btnSubject.Click
        Me.Hide()
        Subject.Show()
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Me.Hide()
        Student.Show()
    End Sub

    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click
        Me.Hide()
        Classroom.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
        Me.Hide()
        Grade.Show()
    End Sub

    Private Sub Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTeacher()
    End Sub

    Public Sub LoadTeacher()
        koneksi.Open()
        DGSiswa.Update()
        DGSiswa.Refresh()
        Dim Sql As String = "SELECT * FROM vAllTeacher"
        Dim adaptor As New SqlDataAdapter(Sql, koneksi)
        Dim data As New DataSet()

        adaptor.Fill(data, "vAllTeacher")
        DGSiswa.DataSource = data
        DGSiswa.DataMember = "vAllTeacher"

        koneksi.Close()
    End Sub
End Class