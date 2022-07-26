Imports System.Data.SqlClient
Public Class GradeEditForm
    Dim sql As String = "Data Source=Kumamakura;Initial Catalog=daschule;Integrated Security=True"
    Dim koneksi As New SqlConnection(sql)

    Dim LoadGrades As New Grade
    Public Sub ClearGrade()
        txtStudentsID.Clear()
        txtGrade.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Grade.Show()
    End Sub

    Private Sub btnEditData_Click(sender As Object, e As EventArgs)

        Try
            sql = "Data Source=Kumamakura;Initial Catalog=daschule;Integrated Security=True"
            koneksi = New SqlClient.SqlConnection(sql)
            koneksi.Open()
            cmd = New SqlClient.SqlCommand()
            With cmd
                .Connection = koneksi
                .CommandType = CommandType.StoredProcedure
                .CommandText = "spUpdateDataNilai"
                .Parameters.AddWithValue("@id_siswa", txtStudentsID.Text)
                .Parameters.AddWithValue("@id_mapel", cmbSubject.Text)
                .Parameters.AddWithValue("@id_kelas", cmbClass.Text)
                .Parameters.AddWithValue("@nilai", txtGrade.Text)

                cmd.ExecuteNonQuery()
            End With


            koneksi.Close()
            MsgBox("Data Has Been Saved", vbInformation)

            ClearGrade()
            Me.Hide()
            Grade.Hide()
            LoadGrades.LoadGrade()
            LoadGrades.Show()


        Catch ex As Exception
            koneksi.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

        Me.Hide()
        Grade.Show()
    End Sub

    Private Sub GradeEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Grade.Show()
    End Sub

    Private Sub btnSaveData_Click(sender As Object, e As EventArgs) Handles btnSaveData.Click

        Try
            sql = "Data Source=Kumamakura;Initial Catalog=daschule;Integrated Security=True"
            koneksi = New SqlClient.SqlConnection(sql)
            koneksi.Open()
            cmd = New SqlClient.SqlCommand()
            With cmd
                .Connection = koneksi
                .CommandType = CommandType.StoredProcedure
                .CommandText = "spInputDataNilai"
                .Parameters.AddWithValue("@id_siswa", txtStudentsID.Text)
                .Parameters.AddWithValue("@id_mapel", cmbSubject.Text)
                .Parameters.AddWithValue("@id_kelas", cmbClass.Text)
                .Parameters.AddWithValue("@nilai", txtGrade.Text)

                cmd.ExecuteNonQuery()
            End With


            koneksi.Close()
            MsgBox("Data Has Been Saved", vbInformation)

            ClearGrade()
            Me.Hide()
            Grade.Hide()
            LoadGrades.LoadGrade()
            LoadGrades.Show()

        Catch ex As Exception
            koneksi.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class