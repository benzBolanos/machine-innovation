Imports MySql.Data.MySqlClient
Public Class Dashboard
    Dim ServerString As String = "host=localhost;user=root;password=;database=db_machine_innovation;"
    Dim SqlConnection As MySqlConnection = New MySqlConnection
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection.ConnectionString = ServerString

        Dim SQLStatement As String = "SELECT * from tbl_user where username ='" & frmlogin.USERNAME & "'"
        Dim Reader As MySqlDataReader

        Try
            SqlConnection.Open()
            Dim Command = New MySqlCommand(SQLStatement, SqlConnection)
            Reader = Command.ExecuteReader

            If Reader.Read Then
                Dim first_name As String = Reader.GetString("fname")
                Dim middle_initial As String = Reader.GetString("mname").Substring(0, 1)
                Dim last_name As String = Reader.GetString("lname")

                txt_welcome.Text = first_name & " " & middle_initial & ". " & last_name
            Else
                MsgBox("Not Logged in!")
                frmlogin.Show()
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class