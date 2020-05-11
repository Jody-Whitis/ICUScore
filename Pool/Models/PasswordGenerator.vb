Imports System.Text

Public Class PasswordGenerator

    Private _generatingChars As String = "abcdefghijklmnopqrstuvwxyz!@#$%^&*?-1234567890"
    Private _generatingLength As Integer = 0
    Private _randomLength As Integer = 0
    Private _generatedPassword As String = String.Empty
    Private _generatorLength As New Random
    Private _isGenerated As Boolean = False

#Region "Properties"
    Public ReadOnly Property GeneratingChars As String
        Get
            Return _generatingChars
        End Get
    End Property

    Public ReadOnly Property GeneratingLength As Integer
        Get
            Return GeneratingChars.Length
        End Get
    End Property

    Public Property RandomLength As Integer
        Get
            Return _generatorLength.Next(6, 14)
        End Get
        Set(value As Integer)
            _randomLength = value
        End Set
    End Property

    Public Property GeneratedPassword As String
        Get
            Return GenerateString()
        End Get
        Set(value As String)
            _generatedPassword = value
        End Set
    End Property

    Public Property IsGenerated As Boolean
        Get
            Return _isGenerated
        End Get
        Set(value As Boolean)
            _isGenerated = value
        End Set
    End Property

#End Region

    ''' <summary>
    ''' Generates random password
    ''' </summary>
    ''' <returns></returns>
    Public Function GenerateString() As String
        Dim generatingString As New StringBuilder
        Try
            For i = 0 To RandomLength
                Dim indexOfChar As Integer = _generatorLength.Next(0, GeneratingLength - 1)
                Dim generatedSingleChar As Char = GeneratingChars(indexOfChar)
                If IsUpperCase(generatedSingleChar) Then
                    generatingString.Append(generatedSingleChar.ToString.ToUpper)
                Else
                    generatingString.Append(generatedSingleChar.ToString.ToLower)
                End If
            Next
        Catch ex As Exception
            IsGenerated = False
            Return String.Empty
        End Try
        IsGenerated = True
        Return generatingString.ToString
    End Function

    ''' <summary>
    ''' Toss up for upper case chars
    ''' </summary>
    ''' <param name="character"></param>
    ''' <returns></returns>
    Private Function IsUpperCase(character As Char) As Boolean
        Dim moduleBit As Integer = _generatorLength.Next(0, 100) Mod 2
        Select Case moduleBit
            Case 1
                Return True
            Case Else
                Return False
        End Select
    End Function

End Class
