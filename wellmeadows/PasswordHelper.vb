Imports System.Security.Cryptography
Imports Microsoft.AspNetCore.Cryptography.KeyDerivation

Public Class PasswordHelper
    Public Shared Function HashPassword(password As String) As String
        ' Generate a 128-bit salt using a cryptographically strong random sequence
        Dim salt(128 \ 8 - 1) As Byte
        Using rng = RandomNumberGenerator.Create()
            rng.GetBytes(salt)
        End Using

        ' Derive a 256-bit subkey (use HMACSHA256 with 10000 iterations)
        Dim hashed As String = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                                                        password:=password,
                                                        salt:=salt,
                                                        prf:=KeyDerivationPrf.HMACSHA256,
                                                        iterationCount:=10000,
                                                        numBytesRequested:=256 \ 8))

        ' Combine the salt and the hash to store
        Return Convert.ToBase64String(salt) & "." & hashed
    End Function

    Public Shared Function VerifyPassword(enteredPassword As String, storedHash As String) As Boolean
        ' Split the stored hash into the salt and the hash
        Dim parts As String() = storedHash.Split("."c)
        Dim salt As Byte() = Convert.FromBase64String(parts(0))
        Dim storedHashedPassword As String = parts(1)

        ' Hash the entered password using the same salt
        Dim hashed As String = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                                                        password:=enteredPassword,
                                                        salt:=salt,
                                                        prf:=KeyDerivationPrf.HMACSHA256,
                                                        iterationCount:=10000,
                                                        numBytesRequested:=256 \ 8))

        ' Compare the entered hashed password with the stored hash
        Return hashed = storedHashedPassword
    End Function
End Class
