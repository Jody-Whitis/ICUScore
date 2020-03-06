Public Class Permissions
    Inherits Authenticate

    Public Enum UserStatus
        Debug = -1
        Admin = 1
        User = 2
        Guest = 3
    End Enum

    Public Shared Function IsAdmin() As Boolean
        If CurrentSession.Permissions.Equals(UserStatus.Admin) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function IsUser() As Boolean
        If CurrentSession.Permissions > UserStatus.Debug AndAlso CurrentSession.Permissions < UserStatus.Guest Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
