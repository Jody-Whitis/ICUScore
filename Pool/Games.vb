Imports System.IO
Imports PoolDBConnect

Public Class Games
    Implements PoolDBConnect.IDBConnect
    Private _gameMode As String
    Private _gameID As Integer
    Private _Score As Integer
    Private DBConnection As String = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & Path.GetDirectoryName(Application.StartupPath) & "\LocalResults.mdf;Integrated Security=True").Replace("\bin", "")
    Dim scoresDB As New ScoreDBConnect(DBConnection)
#Region "Prop"
    Public Property GameMode As String
        Get
            Return _gameMode
        End Get
        Set(value As String)
            _gameMode = value
        End Set
    End Property

    Public Property GameID As Integer
        Get
            Return _gameID
        End Get
        Set(value As Integer)
            _gameID = value
        End Set
    End Property

    Public Property Score As Integer
        Get
            Return _Score
        End Get
        Set(value As Integer)
            _Score = value
        End Set
    End Property
#End Region
    Public Function GetAllPlayers() As Hashtable Implements IDBConnect.GetAllPlayers
        Dim ds As New DataSet
        Dim allPlayers As New Hashtable
        Dim sqlString = String.Empty
        sqlString = $"exec selGames @wins=0"
        'sqlString = "Select gameMode,gameId from Games"
        ds = scoresDB.DBSQL(sqlString)
        Try
            For i = 0 To ds.Tables(0).Rows.Count - 1
                allPlayers.Add(ds.Tables(0).Rows(i).Item("gameId"), ds.Tables(0).Rows(i).Item("gameMode"))
            Next
        Catch ex As Exception
            allPlayers.Add(0, "Error")
            Return allPlayers
        End Try
        Return allPlayers
    End Function

    Public Function InsertGame(sqlString As String) As String Implements IDBConnect.InsertGame
        Dim ds As New DataSet
        Dim retval As String = String.Empty
        'sql for inserting scores
        ds = scoresDB.DBSQL(sqlString)
        If ds Is Nothing Then
            Return "Error"
        End If
        'Try
        '   retval = ds.Tables(0).Rows(0).Item(0).ToString
        'Catch ex As Exception
        '    retval = "Error: saving score"
        'End Try
        Return retval
    End Function

    Public Function InsertPlayer() As String Implements IDBConnect.InsertPlayer
        Throw New NotImplementedException()
    End Function

    Public Overloads Function GetGames(sqlString As String) As Data.DataSet Implements IDBConnect.GetGames
        Dim ds As New DataSet
        ds = scoresDB.DBSQL(sqlString)
        Return ds
#Region "beta set"
        'Dim allPlayers = New String(ds.Tables(0).Rows.Count) {}
        'Try
        '    For i = 0 To ds.Tables(0).Rows.Count - 1
        '        allPlayers(i) = (ds.Tables(0).Rows(i).Item(0))
        '    Next
        'Catch ex As Exception
        '    allPlayers(0) = ("Error")
        '    Return allPlayers
        'End Try
        'Return allPlayers
#End Region
    End Function

    Public Function GetPlayers() As String Implements IDBConnect.GetPlayers
        Throw New NotImplementedException()
    End Function

    Public Function InsertScore() As String Implements IDBConnect.InsertScore
        Throw New NotImplementedException()
    End Function

    Public Function GetAllResults(sqlString As String) As Data.DataSet Implements IDBConnect.GetAllResults
        Dim ds As New DataSet
        ds = scoresDB.DBSQL(sqlString)
        Return ds
    End Function
End Class
