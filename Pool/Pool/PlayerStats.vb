Public Class PlayerStats
    Private PlayerName As String
    Private Wins As Int32
    Private Loses As Int32
    Private lastOp As String
    Private Results As String
    Private winsAgainst As List(Of String)

    Public Property PlayerName1 As String
        Get
            Return PlayerName
        End Get
        Set(value As String)
            PlayerName = value
        End Set
    End Property

    Public Property Wins1 As Integer
        Get
            Return Wins
        End Get
        Set(value As Integer)
            Wins = value
        End Set
    End Property

    Public Property Loses1 As Integer
        Get
            Return Loses
        End Get
        Set(value As Integer)
            Loses = value
        End Set
    End Property

    Public Property LastOp1 As String
        Get
            Return lastOp
        End Get
        Set(value As String)
            lastOp = value
        End Set
    End Property

    Public Property Results1 As String
        Get
            Return Results
        End Get
        Set(value As String)
            Results = value
        End Set
    End Property

    Public Property WinsAgainst1 As List(Of String)
        Get
            Return winsAgainst
        End Get
        Set(value As List(Of String))
            winsAgainst = value
        End Set
    End Property


End Class
