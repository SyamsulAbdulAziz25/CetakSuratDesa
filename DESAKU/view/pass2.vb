Public Class pass2
    Dim lihat As New tampilkan_data1
    Dim row As DataGridViewRow
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox2.UseSystemPasswordChar = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub pass2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox2.UseSystemPasswordChar = True
        DataGridView1.DataSource = lihat.lihat_sandi
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        row = DataGridView1.CurrentRow
        Try

            If TextBox1.Text <> row.Cells(0).Value.ToString Or TextBox2.Text <> row.Cells(1).Value.ToString Then
                MsgBox("Username atau Passworsd Tidak dikenali!!!", MsgBoxStyle.Critical, "Maaf!!")

            Else
                Me.Hide()
                Form1.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If TextBox1.Text <> row.Cells(0).Value.ToString Or TextBox2.Text <> row.Cells(1).Value.ToString Then
            MsgBox("Username atau Passworsd Tidak dikenali!!!", MsgBoxStyle.Critical, "Maaf!!")

        Else
            Me.Hide()
            Form1.Show()
        End If
    End Sub
End Class