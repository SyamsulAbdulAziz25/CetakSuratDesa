Public Class sktm_1
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Panel3.Controls.Clear()
        Form1.Panel1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim nama As String = TextBox1.Text
        Dim jk As String
        Dim tempat As String = TextBox2.Text
        Dim tanggal As String = DateTimePicker1.Text
        Dim nama_ortu As String = TextBox3.Text
        Dim jalan As String = TextBox5.Text
        Dim rt As String = TextBox6.Text
        Dim rw As String = TextBox7.Text
        Dim ds As String = TextBox4.Text


        If RadioButton6.Checked Then
            jk = "Laki-laki"
        Else
            jk = "Perempuan"
        End If
        If up = True Then
            cr.update_sktm(no, nama, jk, tempat, tanggal, nama_ortu, jalan, rt, rw, ds)

        Else
            cr.insert_sktm(no, nama, jk, tempat, tanggal, nama_ortu, jalan, rt, rw, ds)

        End If
        DataGridView1.DataSource = lihat.hitung1_sktm
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        If (row.Cells(0).Value.ToString <> "0") Then
            DataGridView1.DataSource = lihat.hitung2_sktm
            row = DataGridView1.CurrentRow
        End If
        no = Val(row.Cells(0).Value.ToString) + 1
        Form1.Panel3.Controls.Clear()
        Form1.Panel1.Enabled = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub sktm_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Hide()
       
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress, TextBox6.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress, TextBox3.KeyPress, TextBox2.KeyPress, TextBox1.KeyPress

        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

    End Sub
End Class
