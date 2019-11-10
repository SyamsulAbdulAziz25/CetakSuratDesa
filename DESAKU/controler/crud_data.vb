Imports MySql.Data.MySqlClient
Public Class crud_data
    Inherits koneksi
    Public Sub insert_S_catin(no As String, nama As String, tempat As String, tanggal As String, kewarganegaraan As String, agama As String, pekerjaan As String, rt As String, rw As String, ds As String, kec As String, kota As String, nik As String, mulai As String)

        Try
            Dim query As String
            query = "insert into imunisasi_catin values('" & no & "','" & nama & "','" & tempat & "','" & tanggal & "','" & kewarganegaraan & "','" & agama & "','" & pekerjaan & "','" & rt & "','" & rw & "','" & ds & "','" & kec & "','" & kota & "','" & nik & "','" & mulai & "')"
            cmd = New MySqlCommand(query, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Insert data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub
    Public Sub insert_sktm(no As String, nama As String, jenis As String, tempat As String, tanggal As String, nama_ortu As String, jalan As String, rt As String, rw As String, ds As String)

        Try
            Dim query As String
            query = "insert into sktm values('" & no & "','" & nama & "','" & jenis & "','" & tempat & "','" & tanggal & "','" & nama_ortu & "','" & jalan & "','" & rt & "','" & rw & "','" & ds & "')"
            cmd = New MySqlCommand(query, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Insert data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub
    Public Sub insert_ijin_menikah(no As String, nama As String, jenis_kelamin As String, tempat As String, tanggal As String, kewarganegaraan As String, agama As String, pekerjaan As String, jalan As String, rt As String, ds As String, b As String, status As String, bistri As String, istri_dulu As String)

        Try
            Dim query As String
            query = "insert into surat_ijin_menikah values('" & no & "','" & nama & "','" & jenis_kelamin & "','" & tempat & "','" & tanggal & "','" & kewarganegaraan & "','" & agama & "','" & pekerjaan & "','" & jalan & "','" & rt & "','" & ds & "','" & b & "','" & status & "','" & bistri & "','" & istri_dulu & "')"
            cmd = New MySqlCommand(query, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Insert data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub

    Public Sub insert_kedudaan(no As String, nama As String, tempat As String, tanggal As String, pekerjaan As String, agama As String, jalan As String, rt As String, ds As String)

        Try
            Dim query As String
            query = "insert into surat_kedudaan values('" & no & "','" & nama & "','" & tempat & "','" & tanggal & "','" & pekerjaan & "','" & agama & "','" & jalan & "','" & rt & "','" & ds & "')"
            cmd = New MySqlCommand(query, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Insert data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub


    Public Sub insert_kejandaan(no As String, nama As String, tempat As String, tanggal As String, jenis_kelamin As String, status As String, rt As String, rw As String, ds As String, keterangan As String, nama_mantan As String, tempat_mantan As String, tanggal_mantan As String, jenis_mantan As String, pekerjaan_mantan As String)

        Try
            Dim query As String
            query = "insert into surat_kejandaan values('" & no & "','" & nama & "','" & tempat & "','" & tanggal & "','" & jenis_kelamin & "','" & status & "','" & rt & "','" & rw & "','" & ds & "','" & keterangan & "','" & nama_mantan & "','" & tempat_mantan & "','" & tanggal_mantan & "','" & jenis_mantan & "','" & pekerjaan_mantan & "')"
            cmd = New MySqlCommand(query, konek())
            cmd.ExecuteNonQuery()
            MsgBox("Insert data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub
    Public Sub insert_surat_pindah(no As String, nama As String, nik As String, kk As String, tempat As String, tanggal As String, jenis_kelamin As String, kewarganegaraan As String, agama As String, rt As String, rw As String, ds As String, kab As String, rtke As String, rwke As String, desake As String, kabke As String, alasan As String, ikut As String)

        Try
            Dim query As String
            query = "insert into surat_pindah values('" & no & "','" & nama & "','" & nik & "','" & kk & "','" & tempat & "','" & tanggal & "','" & jenis_kelamin & "','" & kewarganegaraan & "','" & agama & "','" & rt & "','" & rw & "','" & ds & "','" & kab & "','" & rtke & "','" & rwke & "','" & desake & "','" & kabke & "','" & alasan & "','" & ikut & "')"
            cmd = New MySqlCommand(query, konek())
            cmd.ExecuteNonQuery()
            MsgBox("Insert data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub
    Public Sub insert_domisili(no As String, nama As String, tempat As String, tanggal As String, pekerjaan As String, jalan As String, rt As String, ds As String)

        Try
            Dim query As String
            query = "insert into surat_domisili values('" & no & "','" & nama & "','" & tempat & "','" & tanggal & "','" & pekerjaan & "','" & jalan & "','" & rt & "','" & ds & "')"
            cmd = New MySqlCommand(query, konek())
            cmd.ExecuteNonQuery()
            MsgBox("Insert data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub

    Public Sub insert_ket_belum_menikah(no As String, nama As String, jk As String, tempat As String, tanggal As String, warganegara As String, agama As String, pekerjaan As String, jalan As String, rt As String, rw As String, ds As String, untuk As String)

        Try
            Dim query As String
            query = "insert into surat_ket_belum_nikah values('" & no & "','" & nama & "','" & jk & "','" & tempat & "','" & tanggal & "','" & warganegara & "','" & agama & "','" & pekerjaan & "','" & jalan & "','" & rt & "','" & rw & "','" & ds & "','" & untuk & "')"
            cmd = New MySqlCommand(query, konek())
            cmd.ExecuteNonQuery()
            MsgBox("Insert data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try
    End Sub
    Public Sub hapus_s_catin(no As String)
        Try
            Dim query As String
            query = "delete from imunisasi_catin where Id_surat='" & no & "'"
            cmd = New MySqlCommand(query, konek())
            cmd.ExecuteNonQuery()
            MsgBox("Hapus data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub

    Public Sub hapus_sktm(no As String)
        Try
            Dim query As String
            query = "delete from sktm where Id_surat='" & no & "'"
            cmd = New MySqlCommand(query, konek())
            cmd.ExecuteNonQuery()
            MsgBox("Hapus data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub

    Public Sub hapus_surat_ijin_menikah(no As String)
        Try
            Dim query As String
            query = "delete from surat_ijin_menikah where Id_surat='" & no & "'"
            cmd = New MySqlCommand(query, konek())
            cmd.ExecuteNonQuery()
            MsgBox("Hapus data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub

    Public Sub hapus_surat_kedudaan(no As String)
        Try
            Dim query As String
            query = "delete from surat_kedudaan where Id_surat='" & no & "'"
            cmd = New MySqlCommand(query, konek())
            cmd.ExecuteNonQuery()
            MsgBox("Hapus data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub

    Public Sub hapus_surat_kejandaan(no As String)
        Try
            Dim query As String
            query = "delete from surat_kejandaan where Id_surat='" & no & "'"
            cmd = New MySqlCommand(query, konek())
            cmd.ExecuteNonQuery()
            MsgBox("Hapus data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try
    End Sub

    Public Sub hapus_surat_pindah(no As String)
        Try
            Dim query As String
            query = "delete from surat_pindah where Id_surat='" & no & "'"
            cmd = New MySqlCommand(query, konek())
            cmd.ExecuteNonQuery()
            MsgBox("Hapus data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub

    Public Sub hapus_surat_domisili(no As String)
        Try
            Dim query As String
            query = "delete from surat_domisili where Id_surat='" & no & "'"
            cmd = New MySqlCommand(query, konek())
            cmd.ExecuteNonQuery()
            MsgBox("Hapus data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try
    End Sub

    Public Sub hapus_surat_ket_belum_nikah(no As String)
        Try
            Dim query As String
            query = "delete from surat_ket_belum_nikah where Id_surat='" & no & "'"
            cmd = New MySqlCommand(query, konek())
            cmd.ExecuteNonQuery()
            MsgBox("Hapus data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try
    End Sub

    Public Sub update_S_catin(no As String, nama As String, tempat As String, tanggal As String, kewarganegaraan As String, agama As String, pekerjaan As String, rt As String, rw As String, ds As String, kec As String, kota As String, nik As String, mulai As String)

        Try
            Dim query As String
            query = "update imunisasi_catin set Nama='" & nama & "',Tempat_lahir='" & tempat & "',Tanggal_lahir='" & tanggal & "',Kewarganegaraan='" & kewarganegaraan & "',Agama='" & agama & "',Pekerjaan='" & pekerjaan & "',RT='" & rt & "',RW='" & rw & "',Desa='" & ds & "',Kec='" & kec & "',Kota='" & kota & "',NIK='" & nik & "',Mulai_berlaku='" & mulai & "' where Id_surat='" & no & "'"
            cmd = New MySqlCommand(query, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Update data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub
    Public Sub update_sktm(no As String, nama As String, jenis As String, tempat As String, tanggal As String, nama_ortu As String, jalan As String, rt As String, rw As String, ds As String)

        Try
            Dim query As String
            query = "update sktm set Nama='" & nama & "',Jenis_kelamin='" & jenis & "',Tempat_lahir='" & tempat & "',Tanggal_lahir='" & tanggal & "',Nama_orangtua='" & nama_ortu & "',Jalan='" & jalan & "',RT='" & rt & "',RT='" & rt & "',WR='" & rw & "' where Id_surat='" & no & "'"
            cmd = New MySqlCommand(query, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Update data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub
    Public Sub update_ijin_menikah(no As String, nama As String, jenis_kelamin As String, tempat As String, tanggal As String, kewarganegaraan As String, agama As String, pekerjaan As String, jalan As String, rt As String, ds As String, b As String, status As String, bistri As String, istri_dulu As String)

        Try
            Dim query As String
            query = "update surat_ijin_menikah set Nama='" & nama & "',Jenis_kelamin='" & jenis_kelamin & "',Tempat_lahir='" & tempat & "',Tanggal_lahir='" & tanggal & "',Kewarganegaraan='" & kewarganegaraan & "',Agama='" & agama & "',Pekerjaan='" & pekerjaan & "',Jalan='" & jalan & "',RT='" & rt & "',Desa='" & ds & "',Bin='" & b & "',Status='" & status & "',Banyak_istri='" & bistri & "',Istri_dulu='" & istri_dulu & "' where Id_surat='" & no & "'"
            cmd = New MySqlCommand(query, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Update data berhasil")
            ' konek()
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub

    Public Sub update_kedudaan(no As String, nama As String, tempat As String, tanggal As String, pekerjaan As String, agama As String, jalan As String, rt As String, ds As String)

        Try
            Dim query As String
            query = "update surat_kedudaan set Nama='" & nama & "',Tempat_lahir='" & tempat & "',Tanggal_lahir='" & tanggal & "',Pekerjaan='" & pekerjaan & "',Agama='" & agama & "',Jalan='" & jalan & "',RT='" & rt & "',Desa='" & ds & "' where Id_surat='" & no & "'"
            cmd = New MySqlCommand(query, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Update data berhasil duda")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub


    Public Sub update_kejandaan(no As String, nama As String, tempat As String, tanggal As String, jenis_kelamin As String, status As String, rt As String, rw As String, ds As String, keterangan As String, nama_mantan As String, tempat_mantan As String, tanggal_mantan As String, jenis_mantan As String, pekerjaan_mantan As String)

        Try
            Dim query As String
            query = "update surat_kejandaan set Nama='" & nama & "',Tempat_lahir='" & tempat & "',Tanggal_lahir='" & tanggal & "',Jenis_kelamin='" & jenis_kelamin & "',Status_perkawinan='" & status & "',RT='" & rt & "',RW='" & rw & "',Desa='" & ds & "',Keterangan='" & keterangan & "',Nama_mantan_suami='" & nama_mantan & "',Tempat_lahir_suami='" & tempat_mantan & "',Tanggal_lahir_suami='" & tanggal_mantan & "',Jenis_kelamin_suami='" & jenis_mantan & "',Pekerjaan_terakhir_suami='" & pekerjaan_mantan & "' where Id_surat='" & no & "'"
            cmd = New MySqlCommand(query, konek())
            cmd.ExecuteNonQuery()
            MsgBox("Update data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub
    Public Sub update_pindah(no As String, nama As String, nik As String, kk As String, tempat As String, tanggal As String, jenis_kelamin As String, kewarganegaraan As String, agama As String, rt As String, rw As String, ds As String, kab As String, rtke As String, rwke As String, desake As String, kabke As String, alasan As String, ikut As String)

        Try
            Dim query As String
            query = "update surat_pindah set Nama='" & nama & "',NIK='" & nik & "',KK='" & kk & "',Tempat_lahir='" & tempat & "',Tanggal_lahir='" & tanggal & "',Jenis_kelamin='" & jenis_kelamin & "',Kewarganegaraan='" & kewarganegaraan & "',Agama='" & agama & "',RT='" & rt & "',RW='" & rw & "',Desa='" & ds & "',Kab='" & kab & "',RT2='" & rtke & "',RW2='" & rwke & "',Desa2='" & desake & "',Kab2='" & kabke & "',Alasan='" & alasan & "',Ikut='" & ikut & "' where Id_surat='" & no & "'"
            cmd = New MySqlCommand(query, konek())
            cmd.ExecuteNonQuery()
            MsgBox("Update data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub
    Public Sub update_domisili(no As String, nama As String, tempat As String, tanggal As String, pekerjaan As String, jalan As String, rt As String, ds As String)

        Try
            Dim query As String
            query = "update surat_domisili set Nama='" & nama & "',Tempat_lahir='" & tempat & "',Tanggal_lahir='" & tanggal & "',Pekerjaan='" & pekerjaan & "',Jalan='" & jalan & "',RT='" & rt & "',Desa='" & ds & "' where Id_surat='" & no & "'"
            cmd = New MySqlCommand(query, konek())
            cmd.ExecuteNonQuery()
            MsgBox("Update data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub

    Public Sub update_ket_belum_menikah(no As String, nama As String, jk As String, tempat As String, tanggal As String, warganegara As String, agama As String, pekerjaan As String, jalan As String, rt As String, rw As String, ds As String, untuk As String)

        Try
            Dim query As String
            query = " update surat_ket_belum_nikah set Nama='" & nama & "',Jenis_kelamin='" & jk & "',Tempat_lahir='" & tempat & "',Tanggal_lahir='" & tanggal & "',Kewarganegaraan='" & warganegara & "',Agama='" & agama & "',Pekerjaan='" & pekerjaan & "',Jalan='" & jalan & "',RT='" & rt & "',RW='" & rw & "',Desa='" & ds & "',Peruntukan='" & untuk & "' where Id_surat='" & no & "'"
            cmd = New MySqlCommand(query, konek())
            cmd.ExecuteNonQuery()
            MsgBox("Update data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try
    End Sub
    Public Sub update_akun(kepala As String, bpd As String, sekdes As String, k_pemerintahan As String, k_pembangunan As String, k_pemuda As String, bendahar As String)

        Try
            Dim query As String
            query = " update akun set Nama_kepala_desa='" & kepala & "',BPD='" & bpd & "',Sekdes='" & sekdes & "',Kaur_pemerintahan='" & k_pembangunan & "',Kaur_pembangunan='" & k_pembangunan & "',Kaur_pemuda_dan_olahraga='" & k_pemuda & "',Bendahara='" & bendahar & "' where Id_desa='1'"
            cmd = New MySqlCommand(query, konek())
            cmd.ExecuteNonQuery()
            MsgBox("Update data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try
    End Sub
    Public Sub update_pass(nama As String, pass As String)

        Try
            Dim query As String
            query = " update log_in set Nama_pengguna='" & nama & "',Sandi='" & pass & "'"
            cmd = New MySqlCommand(query, konek())
            cmd.ExecuteNonQuery()
            MsgBox("Update data berhasil")
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try
    End Sub
End Class

