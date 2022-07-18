Public Class EntSiswa

    Private _IdSiswa As String
    Private _NamaSiswa As String
    Private _JenisKelamin As String
    Private _TempatLahir As String
    Private _TanggalLahir As String

    Public Property Id_Siswa As String
        Get
            Return _IdSiswa
        End Get
        Set(value As String)
            _IdSiswa = value
        End Set
    End Property

    Public Property NamaSiswa As String
        Get
            Return _NamaSiswa
        End Get
        Set(value As String)
            _NamaSiswa = value
        End Set
    End Property

    Public Property JenisKelamin As String
        Get
            Return _JenisKelamin
        End Get
        Set(value As String)
            _JenisKelamin = value
        End Set
    End Property

    Public Property TempatLahir As String
        Get
            Return _TempatLahir
        End Get
        Set(value As String)
            _TempatLahir = value
        End Set
    End Property

    Public Property TanggalLahir As String
        Get
            Return _TanggalLahir
        End Get
        Set(value As String)
            _TanggalLahir = value
        End Set
    End Property
End Class