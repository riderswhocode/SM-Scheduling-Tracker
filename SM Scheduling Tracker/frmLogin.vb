Imports System.DirectoryServices.ActiveDirectory
Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim email = txtEmail.Text.Trim()
            Dim password = txtPassword.Text.Trim()

            Using sqlcon = New MySqlConnection(Module1.conString)
                sqlcon.Open()
                Dim query As String = "SELECT user_id, email, password, fullname FROM tbl_user " +
                                       "WHERE email = @email AND password = @password"
                Using sqlcmd = New MySqlCommand(query, sqlcon)
                    sqlcmd.Parameters.AddWithValue("@email", email)
                    sqlcmd.Parameters.AddWithValue("@password", password)

                    Using sqldr = sqlcmd.ExecuteReader
                        If sqldr.HasRows Then
                            frmMain.Show()
                            Me.Close()
                        Else
                            MsgBox("Invalid Email or Password")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
