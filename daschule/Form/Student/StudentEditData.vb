Public Class StudentEditData

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Student.Show()
    End Sub

    Private Sub btnEditData_Click(sender As Object, e As EventArgs) Handles btnEditData.Click
        Try
            sql = "Data Source=Kumamakura;Initial Catalog=daschule;Integrated Security=True"
            koneksi = New SqlClient.SqlConnection(sql)
            koneksi.Open()
            cmd = New SqlClient.SqlCommand()
            With cmd
                .Connection = koneksi
                .CommandType = CommandType.StoredProcedure
                .CommandText = "spInputDataSiswa"
                .Parameters.AddWithValue("@id_siswa", txtStudentsID.Text)
                .Parameters.AddWithValue("@nama", txtStudentsName.Text)
                .Parameters.AddWithValue("@alamat", txtStudentsAddress.Text)
                .Parameters.AddWithValue("@jenis_kelamin", cmbGender.Text)
                .Parameters.AddWithValue("@tempat_lahir", txtStudentsBirthPlace.Text)
                .Parameters.AddWithValue("@tanggal_lahir", dateBirthday.Value.Date)

                cmd.ExecuteNonQuery()
            End With
            koneksi.Close()
            MsgBox("Data Has Been Saved", vbInformation)
            Me.Hide()
            Student.Show()
        Catch ex As Exception
            koneksi.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

End Class