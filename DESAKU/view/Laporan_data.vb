Public Class Laporan_data

    Dim data As New tampilkan_data1
    Dim cr As New crud_data

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        DataGridView1.DataSource = data.lihat_surat_ijin_menikah
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        DataGridView1.DataSource = data.lihat_surat_kedudaan
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        DataGridView1.DataSource = data.lihat_catin()
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        DataGridView1.DataSource = data.lihat_surat_pindah
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        DataGridView1.DataSource = data.lihat_sktm
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        DataGridView1.DataSource = data.lihat_surat_kejandaan
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        DataGridView1.DataSource = data.lihat_surat_ket_belum_nikah
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        DataGridView1.DataSource = data.lihat_surat_domisili()
    End Sub

    Private Sub Laporan_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function pilih()
        Dim pilihan As String
        If RadioButton1.Checked Then
            pilihan = "Imunisasi_catin"
        ElseIf RadioButton2.Checked Then
            pilihan = "SKTM"
        ElseIf RadioButton3.Checked Then
            pilihan = "Ijin_menikah"
        ElseIf RadioButton4.Checked Then
            pilihan = "Kedudaan"
        ElseIf RadioButton5.Checked Then
            pilihan = "Kejandaan"
        ElseIf RadioButton7.Checked Then
            pilihan = "Ket_belum_nikah"
        ElseIf RadioButton6.Checked Then
            pilihan = "Pindah"
        Else
            pilihan = "Domisili"
        End If
        Return pilihan
    End Function
    Sub perbaharui()
        If pilih() = "Imunisasi_catin" Then
            DataGridView1.DataSource = data.lihat_catin()
        ElseIf pilih() = "SKTM" Then
            DataGridView1.DataSource = data.lihat_sktm
        ElseIf pilih() = "Ijin_menikah" Then
            DataGridView1.DataSource = data.lihat_surat_ijin_menikah
        ElseIf pilih() = "Kedudaan" Then
            DataGridView1.DataSource = data.lihat_surat_kedudaan
        ElseIf pilih() = "Kejandaan" Then
            DataGridView1.DataSource = data.lihat_surat_kejandaan
        ElseIf pilih() = "Ket_belum_nikah" Then
            DataGridView1.DataSource = data.lihat_surat_ket_belum_nikah
        ElseIf pilih() = "Pindah" Then
            DataGridView1.DataSource = data.lihat_surat_pindah

        ElseIf pilih() = "Domisili" Then
            DataGridView1.DataSource = data.lihat_surat_domisili
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        perbaharui()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Dim par As String = row.Cells(0).Value.ToString
        Dim tanya = MsgBox("Hapus Data !!!", MsgBoxStyle.OkCancel, "Peringatan")
        If tanya = vbOK Then
            If pilih() = "Imunisasi_catin" Then
                cr.hapus_s_catin(par)
            ElseIf pilih() = "SKTM" Then
                cr.hapus_sktm(par)
            ElseIf pilih() = "Ijin_menikah" Then
                cr.hapus_surat_ijin_menikah(par)
            ElseIf pilih() = "Kedudaan" Then
                cr.hapus_surat_kedudaan(par)
            ElseIf pilih() = "Kejandaan" Then
                cr.hapus_surat_kejandaan(par)
            ElseIf pilih() = "Ket_belum_nikah" Then
                cr.hapus_surat_ket_belum_nikah(par)
            ElseIf pilih() = "Pindah" Then
                cr.hapus_surat_pindah(par)
            ElseIf pilih() = "Domisili" Then
                cr.hapus_surat_domisili(par)
            End If
            perbaharui()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        pilih()
        Try

       
        If pilih() = "Imunisasi_catin" Then
            Imunisasi_catin.no = row.Cells(0).Value.ToString
            Imunisasi_catin.TextBox1.Text = row.Cells(1).Value.ToString
            Imunisasi_catin.TextBox2.Text = row.Cells(2).Value.ToString
            Imunisasi_catin.DateTimePicker1.Text = row.Cells(3).Value.ToString
            Imunisasi_catin.ComboBox1.Text = row.Cells(4).Value.ToString
            If row.Cells(5).Value.ToString = "Islam" Then
                Imunisasi_catin.RadioButton1.Checked = True
            ElseIf row.Cells(5).Value.ToString = "Islam" Then
                Imunisasi_catin.RadioButton2.Checked = True
            ElseIf row.Cells(5).Value.ToString = "Islam" Then
                Imunisasi_catin.RadioButton3.Checked = True
            ElseIf row.Cells(5).Value.ToString = "Islam" Then
                Imunisasi_catin.RadioButton4.Checked = True
            Else
                Imunisasi_catin.RadioButton5.Checked = True
            End If

            Imunisasi_catin.TextBox3.Text = row.Cells(6).Value.ToString
            Imunisasi_catin.TextBox5.Text = row.Cells(7).Value.ToString
            Imunisasi_catin.TextBox6.Text = row.Cells(8).Value.ToString
            Imunisasi_catin.TextBox7.Text = row.Cells(9).Value.ToString
            Imunisasi_catin.TextBox4.Text = row.Cells(10).Value.ToString
            Imunisasi_catin.TextBox8.Text = row.Cells(11).Value.ToString
            Imunisasi_catin.TextBox9.Text = row.Cells(12).Value.ToString
            Imunisasi_catin.DateTimePicker2.Text = row.Cells(13).Value.ToString
            Imunisasi_catin.up = True
            Imunisasi_catin.Show()
        ElseIf pilih() = "SKTM" Then
            
            SKTM.no = row.Cells(0).Value.ToString
            SKTM.TextBox1.Text = row.Cells(1).Value.ToString
            If row.Cells(2).Value.ToString = "Laki-laki" Then
                SKTM.RadioButton6.Checked = True
            Else
                SKTM.RadioButton7.Checked = True
            End If
            SKTM.TextBox2.Text = row.Cells(3).Value.ToString
            SKTM.DateTimePicker1.Text = row.Cells(4).Value.ToString
            SKTM.TextBox3.Text = row.Cells(5).Value.ToString
            SKTM.TextBox5.Text = row.Cells(6).Value.ToString
            SKTM.TextBox6.Text = row.Cells(7).Value.ToString
            SKTM.TextBox7.Text = row.Cells(8).Value.ToString
            SKTM.TextBox4.Text = row.Cells(9).Value.ToString
            SKTM.up = True
            SKTM.Show()
        ElseIf pilih() = "Ijin_menikah" Then
            Surat_ijin_menikah.no = row.Cells(0).Value.ToString
            Surat_ijin_menikah.TextBox1.Text = row.Cells(1).Value.ToString

            If row.Cells(2).Value.ToString = "Laki_laki" Then
                Surat_ijin_menikah.RadioButton6.Checked = True
            Else
                Surat_ijin_menikah.RadioButton7.Checked = True
            End If
            Surat_ijin_menikah.TextBox2.Text = row.Cells(3).Value.ToString
            Surat_ijin_menikah.DateTimePicker1.Text = row.Cells(4).Value.ToString()
            Surat_ijin_menikah.ComboBox1.Text = row.Cells(5).Value.ToString
            If row.Cells(6).Value.ToString = "Islam" Then
                Surat_ijin_menikah.RadioButton1.Checked = True
            ElseIf row.Cells(6).Value.ToString = "Kristen" Then
                Surat_ijin_menikah.RadioButton2.Checked = True
            ElseIf row.Cells(6).Value.ToString = "Budha" Then
                Surat_ijin_menikah.RadioButton3.Checked = True
            ElseIf row.Cells(6).Value.ToString = "Hindu" Then
                Surat_ijin_menikah.RadioButton4.Checked = True
            Else
                Surat_ijin_menikah.RadioButton5.Checked = True
            End If

            Surat_ijin_menikah.TextBox3.Text = row.Cells(7).Value.ToString
            Surat_ijin_menikah.TextBox4.Text = row.Cells(8).Value.ToString
            Surat_ijin_menikah.TextBox5.Text = row.Cells(9).Value.ToString
            Surat_ijin_menikah.TextBox6.Text = row.Cells(10).Value.ToString
            Surat_ijin_menikah.TextBox7.Text = row.Cells(11).Value.ToString

            If row.Cells(12).Value.ToString = "Jejaka" Then
                Surat_ijin_menikah.RadioButton8.Checked = True
            ElseIf row.Cells(12).Value.ToString = "Duda" Then
                Surat_ijin_menikah.RadioButton9.Checked = True
            Else
                Surat_ijin_menikah.RadioButton10.Checked = True
            End If
            Surat_ijin_menikah.ComboBox2.Text = row.Cells(13).Value.ToString
            Surat_ijin_menikah.TextBox8.Text = row.Cells(14).Value.ToString
            Surat_ijin_menikah.up = True
            Surat_ijin_menikah.Show()
        ElseIf pilih() = "Kedudaan" Then
            Surat_Kedudaan.no = row.Cells(0).Value.ToString
            Surat_Kedudaan.TextBox1.Text = row.Cells(1).Value.ToString
            Surat_Kedudaan.TextBox3.Text = row.Cells(2).Value.ToString
            Surat_Kedudaan.DateTimePicker1.Text = row.Cells(3).Value.ToString
            Surat_Kedudaan.TextBox4.Text = row.Cells(4).Value.ToString
            If row.Cells(5).Value.ToString = "Islam" Then
                Surat_Kedudaan.RadioButton1.Checked = True
            ElseIf row.Cells(5).Value.ToString = "Kristen" Then
                Surat_Kedudaan.RadioButton2.Checked = True
            ElseIf row.Cells(5).Value.ToString = "Budha" Then
                Surat_Kedudaan.RadioButton3.Checked = True
            ElseIf row.Cells(5).Value.ToString = "Hindu" Then
                Surat_Kedudaan.RadioButton4.Checked = True
            Else
                Surat_Kedudaan.RadioButton5.Checked = True
            End If
            Surat_Kedudaan.TextBox5.Text = row.Cells(6).Value.ToString
            Surat_Kedudaan.TextBox6.Text = row.Cells(7).Value.ToString
            Surat_Kedudaan.TextBox7.Text = row.Cells(8).Value.ToString
            Surat_Kedudaan.Show()
            Surat_Kedudaan.up = True
        ElseIf pilih() = "Kejandaan" Then
            Surat_kejandaan.no = row.Cells(0).Value.ToString
            Surat_kejandaan.TextBox1.Text = row.Cells(1).Value.ToString
            Surat_kejandaan.TextBox2.Text = row.Cells(2).Value.ToString
            Surat_kejandaan.DateTimePicker1.Text = row.Cells(3).Value.ToString
            Dim jk As String
            If row.Cells(4).Value.ToString = "Laki-laki" Then
                SKTM.RadioButton6.Checked = True
            Else
                SKTM.RadioButton7.Checked = True
            End If
            Surat_kejandaan.ComboBox1.Text = row.Cells(5).Value.ToString

            Surat_kejandaan.TextBox5.Text = row.Cells(6).Value.ToString
            Surat_kejandaan.TextBox6.Text = row.Cells(7).Value.ToString
            Surat_kejandaan.TextBox7.Text = row.Cells(8).Value.ToString
            Surat_kejandaan.RichTextBox1.Text = row.Cells(9).Value.ToString
            Surat_kejandaan.TextBox8.Text = row.Cells(10).Value.ToString
            Surat_kejandaan.TextBox9.Text = row.Cells(11).Value.ToString
            Surat_kejandaan.DateTimePicker2.Text = row.Cells(12).Value.ToString
            Surat_kejandaan.TextBox10.Text = row.Cells(13).Value.ToString
            Surat_kejandaan.TextBox11.Text = row.Cells(14).Value.ToString
            Surat_kejandaan.Show()
            Surat_kejandaan.up = True
           
        ElseIf pilih() = "Ket_belum_nikah" Then
            Surat_ket_belum_nikah.no = row.Cells(0).Value.ToString
            Surat_ket_belum_nikah.TextBox1.Text = row.Cells(1).Value.ToString
            Surat_ket_belum_nikah.TextBox3.Text = row.Cells(3).Value.ToString
            Surat_ket_belum_nikah.DateTimePicker1.Text = row.Cells(4).Value.ToString
            Surat_ket_belum_nikah.ComboBox2.Text = row.Cells(5).Value.ToString
            '   Surat_ket_belum_nikah.TextBox5.Text = row.Cells(5).Value.ToString
            If row.Cells(6).Value.ToString = "Islam" Then
                Surat_ket_belum_nikah.RadioButton1.Checked = True
            ElseIf row.Cells(6).Value.ToString = "Kristen" Then
                Surat_ket_belum_nikah.RadioButton2.Checked = True
            ElseIf row.Cells(6).Value.ToString = "Budha" Then
                Surat_ket_belum_nikah.RadioButton3.Checked = True
            ElseIf row.Cells(6).Value.ToString = "Hindu" Then
                Surat_ket_belum_nikah.RadioButton4.Checked = True
            Else
                Surat_ket_belum_nikah.RadioButton5.Checked = True
            End If
            Surat_ket_belum_nikah.TextBox4.Text = row.Cells(7).Value.ToString
            Surat_ket_belum_nikah.TextBox5.Text = row.Cells(8).Value.ToString
            Surat_ket_belum_nikah.TextBox6.Text = row.Cells(9).Value.ToString
            Surat_ket_belum_nikah.TextBox7.Text = row.Cells(10).Value.ToString
            Surat_ket_belum_nikah.TextBox2.Text = row.Cells(11).Value.ToString
            Surat_ket_belum_nikah.RichTextBox1.Text = row.Cells(12).Value.ToString

            If row.Cells(6).Value.ToString = "Islam" Then
                Surat_ket_belum_nikah.RadioButton1.Checked = True
            ElseIf row.Cells(6).Value.ToString = "Kristen" Then
                Surat_ket_belum_nikah.RadioButton2.Checked = True
            ElseIf row.Cells(6).Value.ToString = "Budha" Then
                Surat_ket_belum_nikah.RadioButton3.Checked = True
            ElseIf row.Cells(6).Value.ToString = "Hindu" Then
                Surat_ket_belum_nikah.RadioButton4.Checked = True
            Else
                Surat_ket_belum_nikah.RadioButton5.Checked = True
            End If

            If row.Cells(2).Value.ToString = "Laki_laki" Then
                Surat_ket_belum_nikah.RadioButton6.Checked = True
            Else
                Surat_ket_belum_nikah.RadioButton7.Checked = True
            End If

            Surat_ket_belum_nikah.Show()
            Surat_ket_belum_nikah.up = True
        ElseIf pilih() = "Pindah" Then
            Surat_pindah.no = row.Cells(0).Value.ToString
            Surat_pindah.TextBox1.Text = row.Cells(1).Value.ToString
            Surat_pindah.TextBox2.Text = row.Cells(2).Value.ToString
            Surat_pindah.TextBox3.Text = row.Cells(3).Value.ToString
            Surat_pindah.TextBox4.Text = row.Cells(4).Value.ToString
            Surat_pindah.DateTimePicker1.Text = row.Cells(5).Value.ToString
            If row.Cells(6).Value.ToString = "Laki_laki" Then
                Surat_ijin_menikah.RadioButton1.Checked = True
            Else
                Surat_ijin_menikah.RadioButton2.Checked = True
            End If
            Surat_pindah.ComboBox1.Text = row.Cells(7).Value.ToString
            If row.Cells(8).Value.ToString = "Islam" Then
                Surat_pindah.r2.Checked = True
            ElseIf row.Cells(8).Value.ToString = "Kristen" Then
                Surat_pindah.r3.Checked = True
            ElseIf row.Cells(8).Value.ToString = "Budha" Then
                Surat_pindah.r4.Checked = True
            ElseIf row.Cells(8).Value.ToString = "Hindu" Then
                Surat_pindah.r5.Checked = True
            Else
                Surat_Kedudaan.RadioButton5.Checked = True
            End If
            Surat_pindah.TextBox9.Text = row.Cells(9).Value.ToString
            Surat_pindah.TextBox10.Text = row.Cells(10).Value.ToString
            Surat_pindah.TextBox11.Text = row.Cells(11).Value.ToString
            Surat_pindah.TextBox12.Text = row.Cells(12).Value.ToString

            Surat_pindah.TextBox13.Text = row.Cells(13).Value.ToString
            Surat_pindah.TextBox14.Text = row.Cells(14).Value.ToString
            Surat_pindah.TextBox15.Text = row.Cells(15).Value.ToString
            Surat_pindah.TextBox16.Text = row.Cells(16).Value.ToString
            Surat_pindah.RichTextBox1.Text = row.Cells(17).Value.ToString
            Surat_pindah.TextBox17.Text = row.Cells(18).Value.ToString
            Surat_pindah.up = True
            Surat_pindah.Show()
        ElseIf pilih() = "Domisili" Then
            Surat_domisili.no = row.Cells(0).Value.ToString
            Surat_domisili.TextBox1.Text = row.Cells(1).Value.ToString
            Surat_domisili.TextBox3.Text = row.Cells(2).Value.ToString
            Surat_domisili.DateTimePicker1.Text = row.Cells(3).Value.ToString
            Surat_domisili.TextBox4.Text = row.Cells(4).Value.ToString
            Surat_domisili.TextBox5.Text = row.Cells(5).Value.ToString
            Surat_domisili.TextBox6.Text = row.Cells(6).Value.ToString
            Surat_domisili.TextBox7.Text = row.Cells(7).Value.ToString
            Surat_domisili.up = True
            Surat_domisili.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        pilih()
        If pilih() = "Imunisasi_catin" Then
            DataGridView1.DataSource = data.cari_catin(TextBox1.Text.Trim)
        ElseIf pilih() = "SKTM" Then
            DataGridView1.DataSource = data.cari_sktm(TextBox1.Text.Trim)
        ElseIf pilih() = "Ijin_menikah" Then
            DataGridView1.DataSource = data.cari_surat_ijin_menikah(TextBox1.Text.Trim)
        ElseIf pilih() = "Kedudaan" Then
            DataGridView1.DataSource = data.cari_surat_kedudaan(TextBox1.Text.Trim)
        ElseIf pilih() = "Kejandaan" Then
            DataGridView1.DataSource = data.cari_surat_kejandaan(TextBox1.Text.Trim)
        ElseIf pilih() = "Ket_belum_nikah" Then
            DataGridView1.DataSource = data.cari_surat_ket_belum_nikah(TextBox1.Text.Trim)
        ElseIf pilih() = "Pindah" Then
            DataGridView1.DataSource = data.cari_surat_pindah(TextBox1.Text.Trim)

        ElseIf pilih() = "Domisili" Then
            DataGridView1.DataSource = data.cari_surat_domisili(TextBox1.Text.Trim)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        
        pilih()
        If pilih() = "Imunisasi_catin" Then
            form_cr_catin.k = row.Cells(0).Value.ToString
            form_cr_catin.Show()
        ElseIf pilih() = "SKTM" Then
            printing.k = row.Cells(0).Value.ToString
            printing.Show()
        ElseIf pilih() = "Ijin_menikah" Then
            'DataGridView1.DataSource = data.cari_surat_ijin_menikah(TextBox1.Text.Trim)
        ElseIf pilih() = "Kedudaan" Then
            form_print_duda.k = row.Cells(0).Value.ToString
            form_print_duda.Show()
        ElseIf pilih() = "Kejandaan" Then
            'MsgBox("Maaf proseses printing belumtersedia")
            'DataGridView1.DataSource = data.cari_surat_kejandaan(TextBox1.Text.Trim)
        ElseIf pilih() = "Ket_belum_nikah" Then
            'DataGridView1.DataSource = data.cari_surat_ket_belum_nikah(TextBox1.Text.Trim)
        ElseIf pilih() = "Pindah" Then
            '            DataGridView1.DataSource = data.cari_surat_pindah(TextBox1.Text.Trim)

        ElseIf pilih() = "Domisili" Then
            Form2.k = row.Cells(0).Value.ToString
            Form2.Show()

        End If
        'Dim tanya = MsgBox("Lamjutkan printing !!!", MsgBoxStyle.OkCancel, "Printing")
    End Sub
End Class
