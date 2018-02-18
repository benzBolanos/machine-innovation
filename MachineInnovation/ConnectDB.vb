Imports MySql.Data.MySqlClient
Module ConnectDB
    Dim ServerString As String = "host=localhost;user=root;password=;database=db_machine_innovation;"
    Public Sub Open_Connection()
        SqlConnection.ConnectionString = ServerString

        Try
            If SqlConnection.State = ConnectionState.Closed Then
                SqlConnection.Open()
                MsgBox("Connection Success!")
            Else
                SqlConnection.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
