Public Class akun
    Dim cr As New crud_data
    Dim tampil As New tampilkan_data1
   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Kepala As String = TextBox1.Text
        Dim BPD As String = TextBox2.Text
        Dim Sekdes As String = TextBox3.Text
        Dim Kaur_pemerintahan As String = TextBox4.Text
        Dim Kaur_pembangunan = TextBox5.Text
        Dim Kaur_pemuda = TextBox6.Text
        Dim Bedahara = TextBox7.Text
        Dim tanya = MsgBox("Lanjutkan Ubah Akun", MsgBoxStyle.OkCancel, "Ubah Data!!!")
        If tanya = vbOK Then
            cr.update_akun(Kepala, BPD, Sekdes, Kaur_pemerintahan, Kaur_pembangunan, Kaur_pemuda, Bedahara)
            DataGridView1.DataSource = tampil.lihat_akun
        End If

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
      
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Panel3.Controls.Clear()
        Form1.Panel1.Enabled = True
    End Sub

    Private Sub akun_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.DataSource = tampil.lihat_akun
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        TextBox1.Text = row.Cells(1).Value.ToString
        TextBox2.Text = row.Cells(2).Value.ToString
        TextBox3.Text = row.Cells(3).Value.ToString
        TextBox4.Text = row.Cells(4).Value.ToString
        TextBox5.Text = row.Cells(5).Value.ToString
        TextBox6.Text = row.Cells(6).Value.ToString
        TextBox7.Text = row.Cells(7).Value.ToString

    End Sub
End Class
