Imports System.Data.SqlClient

Public Class Grade
    Dim sql As String = "Data Source=Kumamakura;Initial Catalog=daschule;Integrated Security=True"
    Dim koneksi As New SqlConnection(sql)
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

    Private Sub btnSubject_Click(sender As Object, e As EventArgs) Handles btnSubject.Click
        Me.Hide()
        Subject.Show()
    End Sub

    Private Sub btnTeacher_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click
        Me.Hide()
        Teacher.Show()
    End Sub

    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click
        Me.Hide()
        Classroom.Show()
    End Sub

    Private Sub Grade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrade()
    End Sub


    Public Sub LoadGrade()
        koneksi.Open()
        DGSiswa.Update()
        DGSiswa.Refresh()
        Dim Sql As String = "SELECT * FROM vAllGrade"
        Dim adaptor As New SqlDataAdapter(Sql, koneksi)
        Dim data As New DataSet()

        adaptor.Fill(data, "vAllGrade")
        DGSiswa.DataSource = data
        DGSiswa.DataMember = "vAllGrade"

        koneksi.Close()
    End Sub

    Public Sub Student_Load()
        LoadGrade()
    End Sub
End Class