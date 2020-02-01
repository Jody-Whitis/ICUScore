Public Class Permissions
    Inherits Authenticate

    Public Enum UserStatus
        Debug = -1
        Admin = 1
        User = 2
        Guest = 3
    End Enum

    Public Function IsAdmin(userMod As Integer) As Boolean
        If userMod.Equals(1) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function IsUser(userMod As Integer) As Boolean
        If userMod.Equals(2) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
