Public Interface ILogin
    Function GetLogin() As Boolean
    Function UpdatePassword() As Boolean
    Function GetPermissions(userType As Integer, isLogin As Boolean) As Boolean
    Function CompareHash(hashFromPwD As Byte(), hashFromDB As Byte()) As Boolean
End Interface
