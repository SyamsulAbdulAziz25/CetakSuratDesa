﻿Public Class Surat_Kedudaan
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

    Shared Property r4 As Object

    Shared Property r5 As Object

    Private Sub Surat_Kedudaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nama As String = TextBox1.Text
        Dim tempat As String = TextBox3.Text
        Dim tanggal As String = DateTimePicker1.Text
        Dim kwn As String = TextBox4.Text
        Dim agama As String
        Dim pekerjaan As String = TextBox4.Text
        Dim jalan As String = TextBox5.Text
        Dim rt As String = TextBox6.Text
        Dim ds As String = TextBox7.Text
        Dim bin As String = TextBox7.Text

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
            cr.update_kedudaan(no, nama, tempat, tanggal, pekerjaan, agama, jalan, rt, ds)
        Else
            cr.insert_kedudaan(no, nama, tempat, tanggal, pekerjaan, agama, jalan, rt, ds)
        End If

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress, TextBox4.KeyPress, TextBox3.KeyPress, TextBox1.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class