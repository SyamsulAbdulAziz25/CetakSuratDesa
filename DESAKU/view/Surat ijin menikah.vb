Public Class Surat_ijin_menikah
    Dim jk As String
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
    Private Sub Surat_ijin_menikah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Indonesia")
        ComboBox1.Items.Add("Asing")

        With ComboBox2.Items
            .Add("1")
            .Add("2")
            .Add("3")
            .Add("4")
        End With

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        jk = "Laki-Laki"
        Label10.Text = "Istri Terdahulu"
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        jk = "Perempuan"
        Label10.Text = "Suami Terdahulu"
    End Sub

    Sub lihat_istri()
        If jk = "Laki-laki" And RadioButton10.Checked Then
            Label15.Visible = True
            ComboBox2.Visible = True
        Else
            Label15.Visible = False
            ComboBox2.Visible = False
        End If
    End Sub
    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        lihat_istri()
        TextBox8.Visible = False
        Label10.Visible = False
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        lihat_istri()
        TextBox8.Visible = False
        Label10.Visible = False
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        TextBox8.Visible = True
        Label10.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim nama As String = TextBox1.Text
        Dim jk As String
        Dim tempat As String = TextBox2.Text
        Dim tanggal As String = DateTimePicker1.Text
        Dim kwn As String = ComboBox1.Text
        Dim agama As String
        Dim pekerjaan As String = TextBox3.Text
        Dim jalan As String = TextBox4.Text
        Dim rt As String = TextBox5.Text
        Dim ds As String = TextBox6.Text
        Dim bin As String = TextBox7.Text
        Dim status As String
        Dim b_istri As String = ComboBox2.Text
        Dim i_dulu As String = TextBox8.Text

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
      
        If RadioButton8.Checked Then
            status = "Jejaka"
        ElseIf RadioButton9.Checked Then
            status = "Duda"
        Else
            status = "Beristri"
        End If

        If RadioButton6.Checked Then
            jk = "Laki-laki"
        Else
            jk = "Perempuan"
        End If
        If up = True Then
            cr.update_ijin_menikah(no, nama, jk, tempat, tanggal, kwn, agama, pekerjaan, jalan, rt, ds, bin, status, b_istri, i_dulu)
        Else
            cr.insert_ijin_menikah(no, nama, jk, tempat, tanggal, kwn, agama, pekerjaan, jalan, rt, ds, bin, status, b_istri, i_dulu)

        End If
        Me.Close()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress, TextBox5.KeyPress

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress, TextBox6.KeyPress, TextBox3.KeyPress, TextBox2.KeyPress, TextBox1.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

    End Sub
End Class