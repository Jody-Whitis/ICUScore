Module UserMod
    Private _userEmail As String
    Private _displayName As String
    Private _permissions As Integer
    Private _isLoggedIn As Boolean = False
    Private _password As String
    Private _iD As Integer

    Public Property UserEmail As String
        Get
            Return _userEmail
        End Get
        Set(value As String)
            _userEmail = value
        End Set
    End Property

    Public Property DisplayName As String
        Get
            Return _displayName
        End Get
        Set(value As String)
            _displayName = value
        End Set
    End Property

    Public Property Permissions As Integer
        Get
            Return _permissions
        End Get
        Set(value As Integer)
            _permissions = value
        End Set
    End Property

    Public Property IsLoggedIn As Boolean
        Get
            Return _isLoggedIn
        End Get
        Set(value As Boolean)
            _isLoggedIn = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(value As Integer)
            _iD = value
        End Set
    End Property
End Module
