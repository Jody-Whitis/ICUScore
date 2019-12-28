Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class ScoreDBConnect
    Private _connectionString As String
    Private sqlConnection As New SqlConnection
    Private adapter As New SqlDataAdapter

    Public Sub New(connectionString1 As String)
        Me.ConnectionString1 = connectionString1
    End Sub

    Public Property ConnectionString1 As String
        Get
            Return _connectionString
        End Get
        Set(value As String)
            _connectionString = value
        End Set
    End Property

    Private Sub OpenConn()
        With sqlConnection
            .ConnectionString = ConnectionString1
            .Open()
        End With
    End Sub

    Private Sub CloseConn()
        sqlConnection.Close()
    End Sub

    Public Function DBSQL(addGame As String) As DataSet
        Dim ds As New DataSet
        Try
            OpenConn()
            adapter = New SqlDataAdapter(addGame, sqlConnection)
            adapter.Fill(ds)
        Catch ex As Exception
            CloseConn()
            Return Nothing
        Finally
            CloseConn()
        End Try
        Return ds
    End Function

End Class
