Public Class surat_kejandaan_u
    Dim lihat As New tampilkan_data1
    Dim cr As New crud_data
    Private nomor As String
    Private update As Boolean
    Public Property up() As Boolean
        Get
            Return update
        End Get
        Set(ByVal value As Boolean)
            update = value
        End Set
    End Property

    Public Property no() As String
        Get
            Return nomor
        End Get
        Set(ByVal value As String)
            nomor = value
        End Set
    End Property
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Surat_kejandaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Hide()
        
        ComboBox1.Items.Add("Indonesia")
        ComboBox1.Items.Add("Asing")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nama As String = TextBox1.Text
        Dim tempat As String = TextBox2.Text
        Dim tanggal As String = DateTimePicker1.Text
        Dim jk As String
        Dim status As String = ComboBox1.Text

        Dim rt As String = TextBox5.Text
        Dim rw As String = TextBox6.Text
        Dim ds As String = TextBox7.Text
        Dim ket As String = RichTextBox1.Text
        Dim nama_mantan As String = TextBox8.Text
        Dim tempat_mantan As String = TextBox9.Text
        Dim tanggal_mantan As String = DateTimePicker2.Text
        Dim jk_mantan As String = TextBox10.Text
        Dim pekerjaan_manatan = TextBox11.Text


        If RadioButton6.Checked Then
            jk = "Laki-laki"
        Else
            jk = "Perempuan"
        End If
        DataGridView1.DataSource = lihat.hitung1_do
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        If (row.Cells(0).Value.ToString <> "0") Then
            DataGridView1.DataSource = lihat.hitung2_do
            row = DataGridView1.CurrentRow
        End If
        no = Val(row.Cells(0).Value.ToString) + 1
        If up = True Then
            cr.update_kejandaan(no, nama, tempat, tanggal, jk, status, rt, rw, ds, ket, nama_mantan, tempat_mantan, tanggal_mantan, jk_mantan, pekerjaan_manatan)
            up = False
        Else
            cr.insert_kejandaan(no, nama, tempat, tanggal, jk, status, rt, rw, ds, ket, nama_mantan, tempat_mantan, tanggal_mantan, jk_mantan, pekerjaan_manatan)
        End If
        Form1.Panel3.Controls.Clear()
        Form1.Panel1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Panel3.Controls.Clear()
        Form1.Panel1.Enabled = True
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress, TextBox5.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress, TextBox8.KeyPress, TextBox7.KeyPress, TextBox2.KeyPress, TextBox11.KeyPress, TextBox10.KeyPress, TextBox1.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

    End Sub
End Class
