Public Class Imun_catin
    Dim cr As New crud_data
    Dim lihat As New tampilkan_data1
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

    Private Sub Imunisasi_catin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Indonesia")
        ComboBox1.Items.Add("Asing")
        DataGridView1.Hide()
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Panel3.Controls.Clear()
        Form1.Panel1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim nama As String = TextBox1.Text
        Dim tempat As String = TextBox2.Text
        Dim tanggal As String = DateTimePicker1.Text
        Dim kwn As String = ComboBox1.Text
        Dim agama As String
        Dim pekerjaan As String = TextBox3.Text
        Dim rt As String = TextBox5.Text
        Dim rw As String = TextBox6.Text
        Dim ds As String = TextBox7.Text
        Dim kec As String = TextBox4.Text
        Dim kab As String = TextBox8.Text
        Dim nik As String = TextBox9.Text
        Dim mulai As String = DateTimePicker2.Text

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
        DataGridView1.DataSource = lihat.hitung1_ca
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        If (row.Cells(0).Value <> "0") Then
            DataGridView1.DataSource = lihat.hitung2_ca
            row = DataGridView1.CurrentRow
        End If
        no = Val(row.Cells(0).Value.ToString) + 1

        If up = True Then
            cr.update_S_catin(no, nama, tempat, tanggal, kwn, agama, pekerjaan, rt, rw, ds, kec, kab, nik, mulai)
            up = False
        Else
            cr.insert_S_catin(no, nama, tempat, tanggal, kwn, agama, pekerjaan, rt, rw, ds, kec, kab, nik, mulai)

        End If
        Form1.Panel3.Controls.Clear()
        Form1.Panel1.Enabled = True
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
       
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        TextBox9.MaxLength = 16
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress, TextBox7.KeyPress, TextBox4.KeyPress, TextBox3.KeyPress, TextBox2.KeyPress, TextBox1.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress, TextBox5.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class
