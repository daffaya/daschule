Imports System.Data.SqlClient

Public Class Student

    Dim sql As String = "Data Source=Kumamakura;Initial Catalog=daschule;Integrated Security=True"
    Dim koneksi As New SqlConnection(sql)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEditData.Click
        Me.Hide()
        StudentEditData.Show()
    End Sub

    Private Sub btnAddData_Click(sender As Object, e As EventArgs) Handles btnAddData.Click
        Dim tambah As New StudentAddForm()
        StudentAddForm.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.Hide()
        StudentDelete.Show()
    End Sub

    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
        Me.Hide()
        Grade.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnClass.Click
        Me.Hide()
        Classroom.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnTeacher.Click
        Me.Hide()
        Teacher.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSubject.Click
        Me.Hide()
        Subject.Show()
    End Sub

    Public Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudent()
    End Sub

    Public Sub LoadStudent()
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

    Public Sub Student_Load()
        LoadStudent()
    End Sub
End Class