Public Class surat_domisili_u
    Dim cr As New crud_data
    Private nomor As String

    Public Property no() As String
        Get
            Return nomor
        End Get
        Set(ByVal value As String)
            nomor = value
        End Set
    End Property

    Private update As Boolean
    Public Property up() As Boolean
        Get
            Return update
        End Get
        Set(ByVal value As Boolean)
            update = value
        End Set
    End Property
    Dim lihat As New tampilkan_data1

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.DataSource = lihat.hitung1_do
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        If (row.Cells(0).Value.ToString <> "0") Then
            DataGridView1.DataSource = lihat.hitung2_do
            row = DataGridView1.CurrentRow
        End If
        no = Val(row.Cells(0).Value.ToString) + 1
        Dim nama As String = TextBox1.Text
        Dim tempat As String = TextBox3.Text
        Dim tanggal As String = DateTimePicker1.Text
        Dim pek As String = TextBox4.Text
        Dim jalan As String = TextBox5.Text
        Dim rt As String = TextBox6.Text
        Dim ds As String = TextBox7.Text
        If up = True Then
            cr.update_domisili(no, nama, tempat, tanggal, pek, jalan, rt, ds)
            up = False
        Else
            cr.insert_domisili(no, nama, tempat, tanggal, pek, jalan, rt, ds)
        End If
        Form1.Panel3.Controls.Clear()
        Form1.Panel1.Enabled = True
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Panel3.Controls.Clear()
        Form1.Panel1.Enabled = True
    End Sub

    Private Sub surat_domisili_u_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Hide()
        
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress, TextBox5.KeyPress, TextBox4.KeyPress, TextBox3.KeyPress, TextBox1.KeyPress

        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

    End Sub
End Class
