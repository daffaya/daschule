﻿Imports System.Data.SqlClient

Public Class Student
    Private Sub Student_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Student_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEditData.Click
        Me.Hide()
        StudentEditData.Show()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnAddData_Click(sender As Object, e As EventArgs) Handles btnAddData.Click
        Me.Hide()
        StudentAddForm.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.Hide()
        StudentDelete.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

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

    Private Sub DGSiswa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSiswa.CellContentClick
        sql = "Data Source=Kumamakura;Initial Catalog=daschule;Integrated Security=True"
        koneksi = New SqlClient.SqlConnection(sql)
        koneksi.Open()

        cmd = New SqlClient.SqlCommand("SELECT id_siswa, nama, jenis_kelamin, tempat_lahir, tanggal_lahir FROM vAllStudent", koneksi)
        adaptor = New SqlDataAdapter
        adaptor.SelectCommand = cmd

        ass = New DataTable
        ass.Clear()
        adaptor.Fill(ass)
        DGSiswa.DataSource = ass

        koneksi.Close()
    End Sub
End Class