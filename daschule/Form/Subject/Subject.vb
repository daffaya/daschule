Imports System.Data.SqlClient
Public Class Subject
    Dim sql As String = "Data Source=Kumamakura;Initial Catalog=daschule;Integrated Security=True"
    Dim koneksi As New SqlConnection(sql)
    Private Sub btnTeacher_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click
        Me.Hide()
        Teacher.Show()
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Me.Hide()
        Student.Show()

    End Sub

    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click
        Me.Hide()
        Classroom.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Grade.Show()
    End Sub

    Private Sub Subject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubject()
    End Sub


    Public Sub LoadSubject()
        koneksi.Open()
        DGSiswa.Update()
        DGSiswa.Refresh()
        Dim Sql As String = "SELECT * FROM vAllSubject"
        Dim adaptor As New SqlDataAdapter(Sql, koneksi)
        Dim data As New DataSet()

        adaptor.Fill(data, "vAllSubject")
        DGSiswa.DataSource = data
        DGSiswa.DataMember = "vAllSubject"

        koneksi.Close()
    End Sub

End Class