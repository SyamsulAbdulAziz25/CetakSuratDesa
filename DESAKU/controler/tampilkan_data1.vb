Imports MySql.Data.MySqlClient
Public Class tampilkan_data1
    Inherits koneksi
    Public Function lihat_catin() As DataTable
        Dim dt As New DataTable
        Dim str As String = "select * from imunisasi_catin"
        Try
            adp = New MySqlDataAdapter(str, konek())
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in " & ex.Message)
        End Try
        Return dt
    End Function
    Public Function lihat_surat_pindah() As DataTable
        Dim dt As New DataTable
        Dim str As String = "select * from surat_pindah"
        Try
            adp = New MySqlDataAdapter(str, konek())
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function lihat_sktm() As DataTable
        Dim dt As New DataTable
        Dim str As String = "select * from sktm"
        Try
            adp = New MySqlDataAdapter(str, konek())
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function lihat_surat_ijin_menikah() As DataTable
        Dim dt As New DataTable
        Dim str As String = "select * from surat_ijin_menikah"
        Try
            adp = New MySqlDataAdapter(str, konek())
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function lihat_surat_kedudaan() As DataTable
        Dim dt As New DataTable
        Dim str As String = "select * from surat_kedudaan"
        Try
            adp = New MySqlDataAdapter(str, konek())
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function lihat_surat_kejandaan() As DataTable
        Dim dt As New DataTable
        Dim str As String = "select * from surat_kejandaan"
        Try
            adp = New MySqlDataAdapter(str, konek())
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function lihat_surat_domisili() As DataTable
        Dim dt As New DataTable
        Dim str As String = "select * from surat_domisili"
        Try
            adp = New MySqlDataAdapter(str, konek())
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in " & ex.Message)
        End Try
        Return dt
    End Function
    Public Function lihat_surat_ket_belum_nikah() As DataTable
        Dim dt As New DataTable
        Dim str As String = "select * from surat_ket_belum_nikah"
        Try
            adp = New MySqlDataAdapter(str, konek())
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in " & ex.Message)
        End Try
        Return dt
    End Function
    Public Function lihat_akun() As DataTable
        Dim dt As New DataTable
        Dim str As String = "select * from akun"
        Try
            adp = New MySqlDataAdapter(str, konek())
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in " & ex.Message)
        End Try
        Return dt
    End Function
    Public Function lihat_sandi() As DataTable
        Dim dt As New DataTable
        Dim str As String = "select * from log_in"
        Try
            adp = New MySqlDataAdapter(str, konek())
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in " & ex.Message)
        End Try
        Return dt
    End Function
    Public Function cari_catin(cari As String) As DataTable
        Dim dt As New DataTable
        Dim str As String = "select * from imunisasi_catin WHERE Nama like'%" & cari & "%' or NIK like'%" & cari & "%' or id_surat'" & cari & "'"
        Try
            adp = New MySqlDataAdapter(str, konek())
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in " & ex.Message)
        End Try
        Return dt
    End Function
    Public Function cari_surat_pindah(cari As String) As DataTable
        Dim dt As New DataTable
        Dim str As String = "select * from  surat_pindah WHERE Nama like'%" & cari & "%' or NIK like'%" & cari & "%' or  id_surat like'%" & cari & "%'"

        Try
            adp = New MySqlDataAdapter(str, konek())
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function cari_sktm(cari As String) As DataTable
        Dim dt As New DataTable
        Dim str As String = "select * from sktm where Nama like'%" & cari & "%' or  id_surat like'%" & cari & "%'"

        Try
            adp = New MySqlDataAdapter(str, konek())
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function cari_surat_ijin_menikah(cari As String) As DataTable
        Dim dt As New DataTable
        Dim str As String = "select * from surat_ijin_menikah WHERE Nama like'%" & cari & "%' or  id_surat like'%" & cari & "%'"
        Try
            adp = New MySqlDataAdapter(str, konek())
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function cari_surat_kedudaan(cari As String) As DataTable
        Dim dt As New DataTable
        Dim str As String = "select * from surat_kedudaan WHERE Nama like'%" & cari & "%' or  id_surat like'%" & cari & "%'"
        Try
            adp = New MySqlDataAdapter(str, konek())
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function cari_surat_kejandaan(cari As String) As DataTable
        Dim dt As New DataTable
        Dim str As String = "select * from surat_kejandaan WHERE Nama like'%" & cari & "%' or  id_surat like'%" & cari & "%'"
        Try
            adp = New MySqlDataAdapter(str, konek())
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function cari_surat_domisili(cari As String) As DataTable
        Dim dt As New DataTable
        Dim str As String = "select * from surat_domisili WHERE Nama like'%" & cari & "%' or id_surat like'%" & cari & "%'"
        Try
            adp = New MySqlDataAdapter(str, konek())
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in " & ex.Message)
        End Try
        Return dt
    End Function
    Public Function cari_surat_ket_belum_nikah(cari As String) As DataTable
        Dim dt As New DataTable
        Dim str As String = "select * from surat_ket_belum_nikah WHERE Nama like'%" & cari & "%' or id_surat lke '%" & cari & "%'"
        Try
            adp = New MySqlDataAdapter(str, konek())
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in " & ex.Message)
        End Try
        Return dt
    End Function


    Public Function hitung1_do()
        Dim dt = New DataTable
        Dim str As String = "select count(*) from surat_domisili"
        Try
            ' koneksi()
            adp = New MySqlDataAdapter(str, konek)
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in" & ex.Message)
        End Try
        Return dt
    End Function
    Public Function hitung2_do()
        Dim dt = New DataTable
        Dim str As String = "select max(Id_surat) from surat_domisili"
        Try
            ' koneksi()
            adp = New MySqlDataAdapter(str, konek)
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in" & ex.Message)
        End Try
        Return dt
    End Function

    Public Function hitung1_ca()
        Dim dt = New DataTable
        Dim str As String = "select count(*) from imunisasi_catin"
        Try
            ' koneksi()
            adp = New MySqlDataAdapter(str, konek)
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in" & ex.Message)
        End Try
        Return dt
    End Function
    Public Function hitung2_ca()
        Dim dt = New DataTable
        Dim str As String = "select max(Id_surat) from imunisasi_catin"
        Try
            ' koneksi()
            adp = New MySqlDataAdapter(str, konek)
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in" & ex.Message)
        End Try
        Return dt
    End Function

    Public Function hitung1_sktm()
        Dim dt = New DataTable
        Dim str As String = "select count(*) from sktm"
        Try
            ' koneksi()
            adp = New MySqlDataAdapter(str, konek)
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in" & ex.Message)
        End Try
        Return dt
    End Function
    Public Function hitung2_sktm()
        Dim dt = New DataTable
        Dim str As String = "select max(Id_surat) from sktm"
        Try
            ' koneksi()
            adp = New MySqlDataAdapter(str, konek)
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in" & ex.Message)
        End Try
        Return dt
    End Function

    Public Function hitung1_ijin_menikah()
        Dim dt = New DataTable
        Dim str As String = "select count(*) from surat_ijin_menikah"
        Try
            ' koneksi()
            adp = New MySqlDataAdapter(str, konek)
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in" & ex.Message)
        End Try
        Return dt
    End Function
    Public Function hitung2_ijin_menikah()
        Dim dt = New DataTable
        Dim str As String = "select max(Id_surat) from surat_ijin_menikah"
        Try
            ' koneksi()
            adp = New MySqlDataAdapter(str, konek)
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in" & ex.Message)
        End Try
        Return dt
    End Function


    Public Function hitung1_kedudaan()
        Dim dt = New DataTable
        Dim str As String = "select count(*) from surat_kedudaan"
        Try
            ' koneksi()
            adp = New MySqlDataAdapter(str, konek)
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in" & ex.Message)
        End Try
        Return dt
    End Function
    Public Function hitung2_kedudaan()
        Dim dt = New DataTable
        Dim str As String = "select max(Id_surat) from surat_kedudaan"
        Try
            ' koneksi()
            adp = New MySqlDataAdapter(str, konek)
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in" & ex.Message)
        End Try
        Return dt
    End Function


    Public Function hitung1_kejandaan()
        Dim dt = New DataTable
        Dim str As String = "select count(*) from surat_kejandaan"
        Try
            ' koneksi()
            adp = New MySqlDataAdapter(str, konek)
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in" & ex.Message)
        End Try
        Return dt
    End Function
    Public Function hitung2_kejandaan()
        Dim dt = New DataTable
        Dim str As String = "select max(Id_surat) from surat_kejandaan"
        Try
            ' koneksi()
            adp = New MySqlDataAdapter(str, konek)
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in" & ex.Message)
        End Try
        Return dt
    End Function



    Public Function hitung1_pindah()
        Dim dt = New DataTable
        Dim str As String = "select count(*) from surat_pindah"
        Try
            ' koneksi()
            adp = New MySqlDataAdapter(str, konek)
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in" & ex.Message)
        End Try
        Return dt
    End Function
    Public Function hitung2_pindah()
        Dim dt = New DataTable
        Dim str As String = "select max(Id_surat) from surat_pindah"
        Try
            ' koneksi()
            adp = New MySqlDataAdapter(str, konek)
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in" & ex.Message)
        End Try
        Return dt
    End Function


    Public Function hitung1_ket()
        Dim dt = New DataTable
        Dim str As String = "select count(*) from surat_ket_belum_nikah"
        Try
            ' koneksi()
            adp = New MySqlDataAdapter(str, konek)
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in" & ex.Message)
        End Try
        Return dt
    End Function
    Public Function hitung2_ket()
        Dim dt = New DataTable
        Dim str As String = "select max(Id_surat) from surat_ket_belum_nikah"
        Try
            ' koneksi()
            adp = New MySqlDataAdapter(str, konek)
            adp.Fill(dt)
        Catch ex As Exception
            MsgBox("Error in" & ex.Message)
        End Try
        Return dt
    End Function


End Class
