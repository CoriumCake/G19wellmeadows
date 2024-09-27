Imports System.Data.SqlClient

Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Get the entered username and password
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Define your connection string
        Dim connectionString As String = "Data Source=graphite\DB1101171;Initial Catalog=dbWellsmeadowsHospitalG19;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

        ' Create the SQL query to check for the user
        Dim query As String = "SELECT COUNT(*) FROM staff WHERE Username = @Username AND PasswordHash = @PasswordHash"

        ' Create a new connection to the database
        Using connection As New SqlConnection(connectionString)
            ' Create the SQL command
            Using command As New SqlCommand(query, connection)
                ' Add parameters to prevent SQL injection
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@PasswordHash", password)

                ' Open the connection
                connection.Open()

                ' Execute the query and get the result (1 if the user exists, 0 if not)
                Dim userCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' Check if the user exists
                If userCount > 0 Then
                    Dim dashboardForm As New Dashboard()
                    dashboardForm.Show()
                    Me.Hide() ' Hide the login form

                    ' TODO: Redirect to another form or take further action after successful login
                Else
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

End Class
