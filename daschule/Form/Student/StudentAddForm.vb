Public Class StudentAddForm
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtStudentsID.TextChanged

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub StudentAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Student.Show()
    End Sub

    Private Sub btnEditData_Click(sender As Object, e As EventArgs) Handles btnEditData.Click
        Try
            koneksi.Open()
            cmd = New SqlClient.SqlCommand()
            With cmd
                .Connection = koneksi
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_InputDataSiswa"
                .Parameters.AddWithValue("@id_siswa", txtStudentsID.Text)
                .Parameters.AddWithValue("@nama", txtStudentsName.Text)
                .Parameters.AddWithValue("@alamat", txtStudentsAddress.Text)
                .Parameters.AddWithValue("@jenis_kelamin", cmbGender.Text)
                .Parameters.AddWithValue("@tempat_lahir", txtStudentsBirthPlace.Text)
                .Parameters.AddWithValue("@tanggal_lahir", dateBirthday.Text)
                cmd.ExecuteNonQuery()
            End With
            koneksi.Close()
            MsgBox("Data Has Been Saved", vbInformation)
        Catch ex As Exception
            koneksi.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

        Me.Hide()
        Student.Show()
    End Sub

End Class