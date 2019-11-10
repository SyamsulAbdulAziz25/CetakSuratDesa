Public Class ubah_sandi
    Dim ub As New crud_data
    Dim lihat As New tampilkan_data1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim tanya = MsgBox("Apa anda yakin???", MsgBoxStyle.OkCancel, "Ubah Password")
        If tanya = vbOK Then
            ub.update_pass(TextBox1.Text, TextBox2.Text)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub ubah_sandi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = lihat.lihat_sandi
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        'PictureBox2.Focus()
        TextBox1.Text = row.Cells(0).Value.ToString
        TextBox2.Text = row.Cells(1).Value.ToString
    End Sub


    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Text = ""
    End Sub
End Class