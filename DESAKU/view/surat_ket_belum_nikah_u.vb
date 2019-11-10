Public Class surat_ket_belum_nikah_u
    Dim lihat As New tampilkan_data1
    Dim cr As New crud_data
    Private update As Boolean
    Public Property up() As Boolean
        Get
            Return update
        End Get
        Set(ByVal value As Boolean)
            update = value
        End Set
    End Property

    Private nomor As String

    Public Property no() As String
        Get
            Return nomor
        End Get
        Set(ByVal value As String)
            nomor = value
        End Set
    End Property
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.DataSource = lihat.hitung1_ket
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        If (row.Cells(0).Value.ToString <> "0") Then
            DataGridView1.DataSource = lihat.hitung2_ket
            row = DataGridView1.CurrentRow
        End If
        no = Val(row.Cells(0).Value.ToString) + 1
        Dim nama As String = TextBox1.Text
        Dim jk As String
        Dim tempat As String = TextBox3.Text
        Dim tanggal As String = DateTimePicker1.Text
        Dim kwn As String = ComboBox2.Text
        Dim agama As String
        Dim pekerjaan As String = TextBox4.Text
        Dim jalan As String = TextBox5.Text
        Dim rt As String = TextBox6.Text
        Dim rw As String = TextBox7.Text
        Dim ds As String = TextBox2.Text
        Dim untuk As String = RichTextBox1.Text

        If RadioButton6.Checked Then
            jk = "Laki-laki"
        Else
            jk = "Perempuan"
        End If
        If RadioButton1.Checked Then
            agama = "Islam"
        ElseIf RadioButton2.Checked Then
            agama = "Kristen"
        ElseIf RadioButton3.Checked Then
            agama = "Budha"
        ElseIf RadioButton4.Checked Then
            agama = "Hindu"
        Else
            agama = "Konghuchu"
        End If
        If up = True Then
            cr.update_ket_belum_menikah(no, nama, jk, tempat, tanggal, kwn, agama, pekerjaan, jalan, rt, rw, ds, untuk)
            up = False
        Else
            cr.insert_ket_belum_menikah(no, nama, jk, tempat, tanggal, kwn, agama, pekerjaan, jalan, rt, rw, ds, untuk)
        End If
        '  Form1.Panel3.Controls.Clear()
        Form1.Panel1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Panel3.Controls.Clear()
        Form1.Panel1.Enabled = True
    End Sub

    Private Sub Surat_ket_belum_nikah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DataGridView1.Hide()
        ComboBox2.Items.Add("Indonesia")
        ComboBox2.Items.Add("Asing")

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress, TextBox3.KeyPress, TextBox2.KeyPress, TextBox1.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If


    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress, TextBox6.KeyPress

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class
