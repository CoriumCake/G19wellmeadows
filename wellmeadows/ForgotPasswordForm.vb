Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class ForgotPasswordForm
    ' Variable to store the OTP
    Private otp As String
    ' Variable to store the email for later password reset
    Private userEmail As String

    Private Sub ForgotPasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show only the email and OTP panel at the start
        a.Visible = True
        pnlNewPassword.Visible = False

        ' Set password masking for both textboxes
        txtNewPassword.PasswordChar = "*" ' Masking with asterisk
        txtConfirmPassword.PasswordChar = "*" ' Masking with asterisk
    End Sub

    ' Generate a random OTP
    Private Function GenerateOTP() As String
        Dim rnd As New Random()
        Return rnd.Next(100000, 999999).ToString() ' Generate a 6-digit OTP
    End Function

    ' Send OTP to the provided email using SMTP
    Private Sub SendOTP(email As String)
        otp = GenerateOTP() ' Generate OTP

        Try
            ' Set up the email
            Dim mail As New MailMessage()
            mail.From = New MailAddress("G19wellmeadows@gmail.com") ' Your email
            mail.To.Add(email)
            mail.Subject = "Your OTP Code"
            mail.Body = "Your OTP code is: " & otp

            ' SMTP configuration for Gmail
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587 ' Use port 587 for TLS/SSL
            smtp.Credentials = New Net.NetworkCredential("G19wellmeadows@gmail.com", "ngwd saoo nxtv gsnt") ' Your Gmail address and app password
            smtp.EnableSsl = True

            ' Send the email
            smtp.Send(mail)

            MessageBox.Show("OTP has been sent to your email.")
        Catch ex As Exception
            MessageBox.Show("Error sending OTP: " & ex.Message)
        End Try
    End Sub

    ' Handle email submission and OTP sending
    Private Sub btnSendOTP_Click(sender As Object, e As EventArgs) Handles btnSendOTP.Click
        Dim email As String = txtEmail.Text

        ' Check if email exists in the database
        Dim query As String = "SELECT COUNT(*) FROM staff WHERE email = @Email"
        Using connection As New SqlConnection("Data Source=graphite\DB1101171;Initial Catalog=dbWellsmeadowsHospitalG19;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Email", email)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                If count > 0 Then
                    ' Email exists, send OTP and store email for later steps
                    userEmail = email
                    SendOTP(email)
                Else
                    MessageBox.Show("Email not found.")
                End If
            End Using
        End Using
    End Sub

    ' Handle OTP submission and validation
    Private Sub btnSubmitOTP_Click(sender As Object, e As EventArgs) Handles btnSubmitOTP.Click
        Dim enteredOTP As String = txtOTP.Text

        ' Validate the OTP
        If enteredOTP = otp Then
            ' OTP is correct, show the new password panel and hide the OTP panel
            pnlEmailAndOTP.Visible = False
            pnlNewPassword.Visible = True
            pnlNewPassword.BringToFront()  ' Ensure pnlNewPassword is brought to the front
            pnlNewPassword.Refresh()       ' Force refresh to make sure it's rendered properly
        Else
            MessageBox.Show("Invalid OTP. Please try again.")
        End If
    End Sub

    ' Handle new password submission and updating in the database
    ' Inside ForgotPasswordForm
    Private Sub btnSubmitNewPassword_Click(sender As Object, e As EventArgs) Handles btnSubmitNewPassword.Click
        Dim newPassword As String = txtNewPassword.Text
        Dim confirmPassword As String = txtConfirmPassword.Text

        ' Check if passwords match
        If newPassword <> confirmPassword Then
            MessageBox.Show("Passwords do not match. Please try again.")
            Return
        End If

        ' Update the password in the database
        Dim query As String = "UPDATE staff SET passwordHash = @Password WHERE email = @Email"
        Using connection As New SqlConnection("Data Source=graphite\DB1101171;Initial Catalog=dbWellsmeadowsHospitalG19;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Password", newPassword)
                command.Parameters.AddWithValue("@Email", userEmail)
                connection.Open()
                command.ExecuteNonQuery()

                MessageBox.Show("Password successfully updated.")

                ' Instantiate the login form and show it
                Dim loginForm As New Form1() ' Ensure this matches your login form's name
                loginForm.Show()

                ' Close the current form (ForgotPasswordForm)
                Me.Hide()
            End Using
        End Using
    End Sub

End Class
