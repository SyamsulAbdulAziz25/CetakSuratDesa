Public Class Surat_pindah
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

        Dim nama As String = TextBox1.Text
        Dim nik As String = TextBox2.Text
        Dim kk As String = TextBox3.Text
        Dim tempat As String = TextBox4.Text
        Dim tanggal As String = DateTimePicker1.Text
        Dim jk As String
        Dim kwn As String = ComboBox1.Text
        Dim agama As String
        Dim rt As String = TextBox9.Text
        Dim rw As String = TextBox10.Text
        Dim ds As String = TextBox11.Text
        Dim kab As String = TextBox12.Text

        Dim rtke As String = TextBox13.Text
        Dim rwke As String = TextBox14.Text
        Dim dske As String = TextBox15.Text
        Dim kabke As String = TextBox16.Text
        Dim alasan As String = RichTextBox1.Text
        Dim pengikut As String = TextBox17.Text


        If r2.Checked Then
            agama = "Islam"
        ElseIf r3.Checked Then
            agama = "Kristen"
        ElseIf r4.Checked Then
            agama = "Budha"
        ElseIf r5.Checked Then
            agama = "Hindu"
        Else
            agama = "Konghuchu"

        End If
        If RadioButton1.Checked Then
            jk = "Laki-laki"
        Else
            jk = "Perempuan"
        End If
        If up = True Then
            cr.update_pindah(no, nama, nik, kk, tempat, tanggal, jk, kwn, agama, rt, rw, ds, kab, rtke, rwke, dske, kabke, alasan, pengikut)
            up = False
        Else
            cr.insert_surat_pindah(no, nama, nik, kk, tempat, tanggal, jk, kwn, agama, rt, rw, ds, kab, rtke, rwke, dske, kabke, alasan, pengikut)
        End If
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Surat_pindah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Indonesia")
        ComboBox1.Items.Add("Asing")
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)
        TextBox2.MaxLength = 16
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs)
        TextBox3.MaxLength = 16
    End Sub

    Private Sub TextBox3_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress, TextBox2.KeyPress

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress, TextBox17.KeyPress, TextBox14.KeyPress, TextBox13.KeyPress, TextBox10.KeyPress

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress, TextBox16.KeyPress, TextBox15.KeyPress, TextBox12.KeyPress, TextBox11.KeyPress, TextBox1.KeyPress

        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

    End Sub
End Class