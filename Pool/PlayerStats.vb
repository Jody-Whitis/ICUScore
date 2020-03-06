Imports System.IO
Imports PoolDBConnect
Imports PoolDBConnect.ScoreDBConnect

Public Class PlayerStats
    Implements PoolDBConnect.IDBConnect
#Region "vars"
    Private PlayerName As String
    Private _pID As Integer
    Private Wins As Int32
    Private Loses As Int32
    Private lastOp As String
    Private Results As String
    Private winsAgainst As Integer
    Private _isFound As Integer
    'Private DBConnection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" &
    '    "C:\Users\jwhitis\source\repos\Pool\Pool\LocalResults.mdf;Integrated Security=True"
#End Region
    Private DBConnection As String = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & Path.GetDirectoryName(Application.StartupPath) & "\LocalResults.mdf;Integrated Security=True").Replace("\bin", "")
    Dim scoresDB As New ScoreDBConnect(DBConnection)

#Region "Properties"
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

    Public Property WinsAgainst1 As Integer
        Get
            Return winsAgainst
        End Get
        Set(value As Integer)
            winsAgainst = value
        End Set
    End Property

    Public Property PID As Integer
        Get
            Return _pID
        End Get
        Set(value As Integer)
            _pID = value
        End Set
    End Property

    Public Property IsFound As Integer
        Get
            Return _isFound
        End Get
        Set(value As Integer)
            _isFound = value
        End Set
    End Property
#End Region
    Public Function InsertGame(sqlString As String) As String Implements IDBConnect.InsertGame
        Dim ds As New DataSet
#Region "beta2sql"
        'With sqlConnection
        '    .ConnectionString = DBConnection
        '    .Open()
        'End With
        'Wins1 += 1
        'adapter = New SqlDataAdapter("exec dbo.[insWins_v1.1] @newPlayer = '" & PlayerName1 & "',@wins = " & Wins1, sqlConnection)
        'adapter.Fill(ds)

        'Try
        '    adapter = New SqlDataAdapter("select wins from Players where playerName in ('" & PlayerName1 & "')", sqlConnection)
        '    adapter.Fill(ds)
        '    Return ds.Tables(0).Rows(0).Item(0).ToString
        'Catch ex As Exception
        '    sqlConnection.Close()
        '    Return "Error: Game not saved"

        'Finally
        '    sqlConnection.Close()
        'End Try
#End Region
        sqlString = String.Empty
        Wins1 += 1
        ds = scoresDB.DBSQL($"exec dbo.[insWins_v1.1] @newPlayer = '{PlayerName}',@wins = {Wins1}")
        ds = scoresDB.DBSQL($"exec [selPlayers_v1.1] @playerId={PID},@wins={Wins1}") 'test sp
        Try
            Return ds.Tables(0).Rows(0).Item("Wins").ToString
        Catch
            Return String.Empty
        End Try
    End Function

    Public Function InsertPlayer() As String Implements IDBConnect.InsertPlayer
#Region "beta2 sql"
        'Dim dbCommand As New SqlCommand
        'With sqlConnection
        '    .ConnectionString = DBConnection
        '    .Open()
        'End With
        'Dim command As String = "exec insNewPlayer @newPlayer='" & PlayerName1 & "'"
        'Try
        '    With dbCommand
        '        .Connection = sqlConnection
        '        .CommandText = command
        '        .ExecuteNonQuery()
        '    End With
        '    Return String.Empty
        'Catch ex As Exception
        '    sqlConnection.Close()
        '    Return "Error adding player"

        'Finally
        '    sqlConnection.Close()
        'End Try
#End Region
        Dim ds As New DataSet
        Dim sqlString = String.Empty
        sqlString = $"exec insNewPlayer @newPlayer='{PlayerName1.Trim}'"
        ds = scoresDB.DBSQL(sqlString)
        Try
            Return ds.Tables(0).Rows(0).Item(0).ToString
        Catch ex As DataException
            Return String.Empty
        End Try
    End Function

    Public Function SearchPvPStats(ByVal opponentID As Integer, ByVal gameId As Integer) As DataSet
        Dim ds As New DataSet
        Dim sqlString = String.Empty
        sqlString = $"exec [selPvPStats] @pID ={PID},@p2Id = {opponentID},@gID = {gameId},@pvpID = {-1}"
        ds = scoresDB.DBSQL(sqlString)

        Return ds
    End Function

    Public Function InsertPvPStats(ByVal opponentID As Integer, ByVal pvpID As Integer, ByVal gID As Integer) As String
        Dim sqlstring As String = $"exec [inPvPStats] @pvpID = {pvpID},@pID={PID},@p2ID={opponentID},@win={WinsAgainst1},@winner={PlayerName1}, @gID={gID},@timeStamp='{Now.ToString()}'"
        Dim ds As New DataSet
        ds = scoresDB.DBSQL(sqlstring)
        If ds.Equals(Nothing) Then
            Return "Error"
        Else
            Return String.Empty
        End If
    End Function

    Public Function GetGames(playerName2 As String) As Data.DataSet Implements IDBConnect.GetGames
        Dim ds As New DataSet
        Dim retVal = New String(2) {}
#Region "sucky sql"
        'With sqlConnection
        '    .ConnectionString = DBConnection
        '    .Open()
        'End With

        'adapter = New SqlDataAdapter("Select wins from Players where playerName In ('" & PlayerName1 & "','" & playerName2 & "')", sqlConnection)
        'adapter.Fill(ds)

        ''save new wins if null txtbox wins, else then insert new game results.
        'Try
        '    retVal(0) = ds.Tables(0).Rows(0).Item(0).ToString
        '    retVal(1) = ds.Tables(0).Rows(1).Item(0).ToString
        'Catch ex As Exception
        '    sqlConnection.Close()
        '    retVal(0) = "Error"
        '    Return retVal
        'Finally
        '    sqlConnection.Close()
        'End Try
#End Region
        Dim sqlString = String.Empty
        sqlString = $"exec [selPlayers_v1.1] @playerId={PID},@wins={Wins1}"
        'sqlString = "Select wins from Players where playerName In ('" & PlayerName1 & "','" & playerName2 & "')"
        ds = scoresDB.DBSQL(sqlString)
        Return ds
        'Try
        '    retVal(0) = ds.Tables(0).Rows(0).Item(0).ToString
        '    retVal(1) = ds.Tables(0).Rows(1).Item(0).ToString
        'Catch ex As Exception
        '    retVal(0) = "Error"
        'End Try
        'Return retVal
    End Function

    Public Function InsertResult() As String Implements IDBConnect.InsertScore
        Dim ds As New DataSet
        Dim retval As String = String.Empty
        ds = scoresDB.DBSQL("select wins from Players where playerName in ('" & PlayerName1 & "')")
        ds = scoresDB.DBSQL("select wins from Players where playerName in ('" & PlayerName1 & "')")

        Try
            retval = ds.Tables(0).Rows(0).Item(0).ToString
        Catch ex As Exception
            retval = "Error"
        End Try
        Return retval
    End Function
    Public Function GetPlayers() As String Implements IDBConnect.GetPlayers
        Dim ds As New DataSet
#Region "beta2 sql"
        'Try
        'With SqlConnection
        '    .ConnectionString = DBConnection
        '    .Open()
        'End With
        '    'Search by player name
        '    adapter = New SqlDataAdapter("Select wins from Players where playerName In ('" & PlayerName1 & "')", sqlConnection)
        '    adapter.Fill(ds)
        '    Wins1 = ds.Tables(0).Rows(0).Item(0).ToString
        'Catch ex As Exception
        '    sqlConnection.Close()
        '    Return "Name not found"
        'Finally
        '    sqlConnection.Close()
        'End Try
#End Region
        Dim sqlString = String.Empty

        sqlString = $"exec [selPlayers_v1.1] @playerId={PID},@wins={Wins1}"

        ds = scoresDB.DBSQL(sqlString)
        Try
            Wins1 = ds.Tables(0).Rows(0).Item(0).ToString
        Catch ex As Exception
            Return "Name not found"
        End Try
        Return String.Empty
    End Function

    Public Overridable Function getRivarly(ByVal challengerWins) As Boolean
        Dim averageWins As Double = WinsAgainst1 / challengerWins
        If challengerWins > 5 AndAlso averageWins >= 0.9 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function IDBConnect_GetAllPlayers() As Hashtable Implements IDBConnect.GetAllPlayers
        Dim ds As New DataSet
        Dim allPlayers As New Hashtable
#Region "beta2 sql"
        'With sqlConnection
        '    .ConnectionString = DBConnection
        '    .Open()
        'End With

        'adapter = New SqlDataAdapter("Select Playername from Players", sqlConnection)
        'adapter.Fill(ds)

        'Try
        '    For i = 0 To ds.Tables(0).Rows.Count - 1
        '        allPlayers.Add(ds.Tables(0).Rows(i).Item(0))
        '    Next
        'Catch ex As Exception
        '    sqlConnection.Close()
        '    allPlayers.Add("Error")
        'Finally
        '    sqlConnection.Close()
        'End Try
#End Region
        Dim sqlString = String.Empty
        sqlString = $"exec selAllPlayers @wins=0"
        ds = scoresDB.DBSQL(sqlString)
        Try
            For i = 0 To ds.Tables(0).Rows.Count - 1
                allPlayers.Add(ds.Tables(0).Rows(i).Item("id"), ds.Tables(0).Rows(i).Item("playerName"))
            Next
        Catch ex As Exception
            allPlayers.Add(0, "Error")
            Return allPlayers
        End Try
        Return allPlayers
    End Function

    Public Function GetAllPlayersRegistered(registeredBit As Boolean) As Hashtable
        Dim ds As New DataSet
        Dim allplayers As New Hashtable
        Dim registered As Int16 = Convert.ToInt16(registeredBit)
        Dim sqlString = String.Empty
        sqlString = $"exec selAllPlayers @wins = 0"
        ds = scoresDB.DBSQL(sqlString)
        Try
            Dim filteredByRegistered As List(Of DataRow) = (From rows In ds.Tables(0).AsEnumerable Where
                                           rows.Item("Registered") = registered Or rows.Item("id").Equals(CurrentSession.ID) Select rows).ToList
            For i =0 To filteredByRegistered.Count -1
                allplayers.Add(filteredByRegistered.Item(i).ItemArray.First, filteredByRegistered.Item(i).ItemArray(1))
            Next
        Catch ex As Exception
            allplayers.Add(0, "Error")
        End Try
        Return allplayers
    End Function

    Public Function GetAllResults(sqlString As String) As Data.DataSet Implements IDBConnect.GetAllResults
        Dim ds As New DataSet
        ds = scoresDB.DBSQL(sqlString)
        Return ds
    End Function
End Class
