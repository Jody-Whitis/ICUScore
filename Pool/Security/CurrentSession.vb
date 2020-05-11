Imports Pool

Module CurrentSession
#Region "Vars"
    Public Enum AppState
        NoPlayerEx = -1
        Start = 0
        Register = 1
        SelectPlayer = 2
        Winner = 3
        Switch = 4
        Add = 5
        Edit = 6
        Delete = 7
    End Enum
    Private _userEmail As String
    Private _displayName As String
    Private _permissions As Integer
    Private _isLoggedIn As Boolean = False
    Private _password As String
    Private _iD As Integer
    Private _userStatus As Integer
    Private _twoFactorEnabled As Boolean = False
    Private _subscribed As Boolean = False
    Private _isTwoFactorAuthenticate As Boolean = False
    Private _registered As Boolean = False
    Private _isUsingTempPassword As Boolean = False
    Public PreviousForm As Form = Home
    Public CurrentForm As Form = Nothing
    Private _CurrentScreen As AppState
#End Region

#Region "Properties"
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

    Public Property UserStatus As Integer
        Get
            Return _userStatus
        End Get
        Set(value As Integer)
            _userStatus = value
        End Set
    End Property

    Public Property CurrentScreen As AppState
        Get
            Return _CurrentScreen
        End Get
        Set(value As AppState)
            _CurrentScreen = value
        End Set
    End Property

    Public Property TwoFactorEnabled As Boolean
        Get
            Return _twoFactorEnabled
        End Get
        Set(value As Boolean)
            _twoFactorEnabled = value
        End Set
    End Property

    Public Property Subscribed As Boolean
        Get
            Return _subscribed
        End Get
        Set(value As Boolean)
            _subscribed = value
        End Set
    End Property

    Public Property isTwoFactorCodeAuthenticate As Boolean
        Get
            Return _isTwoFactorAuthenticate
        End Get
        Set(value As Boolean)
            _isTwoFactorAuthenticate = value
        End Set
    End Property

    Public Property Registered As Boolean
        Get
            Return _registered
        End Get
        Set(value As Boolean)
            _registered = value
        End Set
    End Property

    Public Property IsUsingTempPassword As Boolean
        Get
            Return _isUsingTempPassword
        End Get
        Set(value As Boolean)
            _isUsingTempPassword = value
        End Set
    End Property
#End Region

    'Never use this if you are disposing of the form
    'Always when only hiding for navigation
    Public Sub setPreviousForm(ByRef prevForm As Form)
        PreviousForm = prevForm
    End Sub

    Public Sub setCurerntForm(ByRef crtForm As Form)
        CurrentForm = crtForm
    End Sub
End Module
