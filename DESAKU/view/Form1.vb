Public Class Form1
    Dim lapor As New Laporan_data
    Dim akun As New akun
    Dim imun As New Imun_catin
    Dim sktm As New sktm_1
    Dim surat_ijin_menikah As New surat_ijin_menika_u
    Dim surat_kedudaan As New surat_kedudaan_u
    Dim surat_kejandaan As New surat_kejandaan_u

    Dim surat_pindah As New surat_pindah_u
    Dim surat_domisili As New surat_domisili_u
    Dim surat_ket_bel_nika As New surat_ket_belum_nikah_u


    Private Sub Button18_Click(sender As Object, e As EventArgs)
        Surat_ijin_menikah.Show()
    End Sub


    Private Sub SuratIjinMenikahToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Surat_ijin_menikah.Show()
    End Sub

    Private Sub ImunisasiCatinToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Imunisasi_catin.Show()
    End Sub

    Private Sub SuratBelumMenikahToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Surat_ket_belum_nikah.Show()
    End Sub


    Private Sub SuratPernyataanJandaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Surat_kejandaan.Show()
    End Sub

    Private Sub SuratPernyataanDudaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Surat_Kedudaan.Show()
    End Sub

    Private Sub SKTMToolStripMenuItem_Click(sender As Object, e As EventArgs)
        SKTM.Show()
    End Sub



    Private Sub SuratPindahToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Surat_pindah.Show()
    End Sub

    Private Sub SuratDomisiliToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Surat_domisili.Show()
    End Sub

    
    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        'Surat_ijin_menikah.Show()
        Panel3.Controls.Clear()
        Panel3.Controls.Add(surat_ijin_menikah)
        Panel1.Enabled = False
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        'Imunisasi_catin.Show()
        Panel3.Controls.Clear()
        Panel3.Controls.Add(imun)
        Panel1.Enabled = False
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        'Surat_ket_belum_nikah.Show()
        Panel3.Controls.Clear()
        Panel3.Controls.Add(surat_ket_bel_nika)
        Panel1.Enabled = False
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        ' surat_kejandaan.Show()
        Panel3.Controls.Clear()
        Panel3.Controls.Add(surat_kejandaan)
        Panel1.Enabled = False
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        ' surat_kedudaan.Show()
        Panel3.Controls.Clear()
        Panel3.Controls.Add(surat_kedudaan)
        Panel1.Enabled = False
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        'SKTM.Show()
        Panel3.Controls.Clear()
        Panel3.Controls.Add(sktm)
        Panel1.Enabled = False
    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem18.Click
        ' surat_pindah.Show()
        Panel3.Controls.Clear()
        Panel3.Controls.Add(surat_pindah)
        Panel1.Enabled = False
    End Sub

    Private Sub ToolStripMenuItem19_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem19.Click
        ' surat_domisili.Show()
        Panel3.Controls.Clear()
        Panel3.Controls.Add(surat_domisili)
        Panel1.Enabled = False
    End Sub

    Private Sub ToolStripMenuItem44_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem44.Click
        Panel3.Controls.Add(lapor)
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Panel3.Controls.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = TimeOfDay
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Panel1.Enabled = False
        Panel3.Controls.Clear()
        Panel3.Controls.Add(akun)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        ubah_sandi.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim tanya = MsgBox("Apa anda yakin???", MsgBoxStyle.OkCancel, "Ubah Password")
        If tanya = vbOK Then
            pass2.Close()
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripMenuItem57_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem57.Click

    End Sub
End Class
