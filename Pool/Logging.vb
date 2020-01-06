Imports System.IO
Public Class Logging
    Private _dateofLog As DateTime
    Private _eventTitle As String
    Private _eventDetails As String
    Private _eventEmail As Boolean
    Private _fileLocation As String
    Public Sub New()
    End Sub
    Public Sub New(timestampLog As DateTime, title As String, details As String)
        DateofLog = timestampLog
        EventTitle = title
        EventDetails = details
    End Sub

#Region "Prop"
    Public Property DateofLog As Date
        Get
            Return _dateofLog
        End Get
        Set(value As Date)
            _dateofLog = value
        End Set
    End Property

    Public Property EventTitle As String
        Get
            Return _eventTitle
        End Get
        Set(value As String)
            _eventTitle = value
        End Set
    End Property

    Public Property EventDetails As String
        Get
            Return _eventDetails
        End Get
        Set(value As String)
            _eventDetails = value
        End Set
    End Property
#End Region

    Public Sub LogAction()
        _fileLocation = $"ScoreLog_{DateofLog.ToString("MM-dd-yyyy")}.txt"
        Try
            Using _writeFile = New StreamWriter(_fileLocation, True)
                _writeFile.WriteLine($"{ DateofLog.ToString()} : {EventTitle}")
                _writeFile.WriteLine($"{EventDetails}")
                _writeFile.WriteLine(Environment.NewLine)
            End Using
        Catch ex As Exception
            Debug.Write(ex.ToString)
        End Try
    End Sub

    Public Sub LogActionEmail()
        Dim logEmail As New Email(New String() {"projtestcred@gmail.com"}.ToList)
        _eventEmail = logEmail.SendLogEmail(_fileLocation)
    End Sub

End Class
