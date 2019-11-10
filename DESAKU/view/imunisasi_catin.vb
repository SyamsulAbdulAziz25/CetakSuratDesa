Public Class imunisasi_catin

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

    Private Sub Imunisasi_catin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Indonesia")
        ComboBox1.Items.Add("Asing")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
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
        If up = True Then
            cr.update_S_catin(no, nama, tempat, tanggal, kwn, agama, pekerjaan, rt, rw, ds, kec, kab, nik, mulai)
            up = False
        Else
            cr.insert_S_catin(no, nama, tempat, tanggal, kwn, agama, pekerjaan, rt, rw, ds, kec, kab, nik, mulai)

        End If
        Me.Close()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress, TextBox1.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress, TextBox7.KeyPress, TextBox4.KeyPress, TextBox3.KeyPress, MyBase.KeyPress, ComboBox1.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        TextBox9.MaxLength = 16
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

    End Sub
End Class