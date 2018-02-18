Imports MySql.Data.MySqlClient
Public Class frmlogin
    Public Shared USERNAME As String = ""

    Dim ServerString As String = "host=localhost;user=root;password=;database=db_machine_innovation;"
    Dim SqlConnection As MySqlConnection = New MySqlConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            SqlConnection.ConnectionString = ServerString
            SqlConnection.Open()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Login_User(SQLStatement As String)
        Dim Reader As MySqlDataReader

        Try
            Dim Command = New MySqlCommand(SQLStatement, SqlConnection)
            Reader = Command.ExecuteReader

            If Reader.Read Then
                USERNAME = Reader.GetString("username")
                Dashboard.Show()
            Else
                MsgBox("Username or password is incorrect!")
                SqlConnection.Close()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim SQLStatement As String = "SELECT * from tbl_user where username ='" & txt_username.Text & "' and password='" & txt_password.Text & "'"
        Login_User(SQLStatement)
    End Sub
End Class
