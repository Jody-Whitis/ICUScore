Public Class Permissions
    Inherits Authenticate

    Public Enum UserStatus
        Debug = -1
        Admin = 1
        User = 2
        Guest = 3
    End Enum

    Public Function IsAdmin() As Boolean
        If UserMod.Permissions.Equals(UserStatus.Admin) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function IsUser() As Boolean
        If UserMod.Permissions > UserStatus.Debug AndAlso UserMod.Permissions < UserStatus.Guest Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
