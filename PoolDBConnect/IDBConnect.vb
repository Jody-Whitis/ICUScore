Imports System.Collections.Generic
Imports System.Linq
Public Interface IDBConnect

    'connect
    Function GetAllPlayers() As Hashtable

    'insert
    Function InsertGame(sqlString As String) As String

    Function InsertPlayer() As String

    'pull up
    Function GetGames(playerName2 As String) As Data.DataSet

    Function GetPlayers() As String

    Function InsertScore() As String

    Function GetAllResults(sqlString As String) As Data.DataSet

End Interface
