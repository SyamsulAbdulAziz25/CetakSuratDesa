Imports MySql.Data.MySqlClient
Public Class koneksi
    Public connstr As String = "server=localhost;user id=root;database=db_desa"
    Private kon As New MySqlConnection(connstr)
    Public adp As MySqlDataAdapter
    Public cmd As MySqlCommand

    Protected Function konek() As MySqlConnection
        Try
            If kon.State = ConnectionState.Closed Then
                kon.Open()
                'ElseIf kon.State = ConnectionState.Open Then
                '    kon.Close()
            End If
        Catch ex As Exception
            MsgBox("Error connection in:" + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return kon
    End Function
End Class
