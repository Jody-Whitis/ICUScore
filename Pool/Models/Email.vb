Imports System.Net.Mail
Imports System.Text
Imports System.IO
Public Class Email
    Private _addressList As List(Of String)
    Private _scoreList As IEnumerable
    'Private Const userCreditals As String = "projtestcred@gmail.com"
    'Private Const passCreditals As String = "aolknqyzcrhcemec"
    Private emailTempsFolder As String = (Path.GetDirectoryName(Application.StartupPath).Replace("\bin", "") & "\EmailTemps").ToString
#Region "Prop"
    Public Sub New(eAddresses As List(Of String), ds As IEnumerable)
        AddressList = eAddresses
        ScoreList = ds
    End Sub

    Public Property AddressList As List(Of String)
        Get
            Return _addressList
        End Get
        Set(value As List(Of String))
            _addressList = value
        End Set
    End Property

    Public Property ScoreList As IEnumerable
        Get
            Return _scoreList
        End Get
        Set(value As IEnumerable)
            _scoreList = value
        End Set
    End Property
#End Region
    Public Sub New()
    End Sub

    Public Sub New(eAddresses As List(Of String))
        AddressList = eAddresses
    End Sub

    ''' <summary>
    ''' Check if we have a list of addresses.
    ''' Using the app settings and the list of addresses passed,
    ''' Send a table of all recent updated stats in the past week
    ''' that were passed in constructor after condition checks.
    ''' Only send of we have at least one row from the stats dataset.
    ''' </summary>
    Public Sub SendWeekEmail()
        Try
            If AddressList Is Nothing Or AddressList.Count <= 0 Then
                Exit Sub
            End If
            Dim smtp As New SmtpClient
            Dim eMail As New MailMessage()
            Dim bodyTable As New StringBuilder
            Dim emailLogTemp As String = File.ReadAllText(emailTempsFolder & "\WeeklyScoreTemp.html").ToString
            Dim emailSplit As String() = emailLogTemp.Split("~")
            Dim counterStats As Integer = 0
            With smtp
                .UseDefaultCredentials = My.Settings.emailDefaultCreds
                .Credentials = New Net.NetworkCredential(My.Settings.emailCreds, My.Settings.passEmailCreds)
                .Port = My.Settings.emailPort
                .EnableSsl = True
                .Host = My.Settings.emailServer
            End With
            eMail = New MailMessage()
            With eMail
                .Sender = New MailAddress(My.Settings.senderEmail)
                .From = New MailAddress("scores@score.com")
                .IsBodyHtml = True
                .Subject = $"Scores for {Now.ToString("MM/dd/yyyy")}"
            End With
            For Each address In AddressList
                eMail.To.Add(address)
            Next
            With bodyTable
                .Append(emailSplit.First.Replace("=Date=", Now.ToString("MM/dd/yyyy")))
                For Each stat In ScoreList
                    .Append(emailSplit(1).Replace("=stat1=", stat(0)).Replace("=stat2=", stat(1)).
                        Replace("=stat3=", stat(2)))
                    counterStats += 1
                Next
                .Append(emailSplit.Last)
            End With
            eMail.Body = bodyTable.ToString
            If counterStats > 0 Then
                smtp.Send(eMail)
            End If
        Catch ex As Exception
            Dim exceptionLog As New Logging(Now, "Weekly Email: ", ex.ToString)
            exceptionLog.LogAction()
        End Try
    End Sub

    Public Function SendLogEmail(fileName As String) As Boolean
        Dim logSend As Boolean = False
        Dim emailLogTemp As String = File.ReadAllText(emailTempsFolder & "\LogEmailTemp.html").ToString
        Try
            If AddressList Is Nothing Or AddressList.Count <= 0 Then
                Return logSend
            End If
            Dim smtp As New SmtpClient
            Dim eMail As New MailMessage()
            Dim bodyTable As New StringBuilder
            With smtp
                .UseDefaultCredentials = My.Settings.emailDefaultCreds
                .Credentials = New Net.NetworkCredential(My.Settings.emailCreds, My.Settings.passEmailCreds)
                .Port = My.Settings.emailPort
                .EnableSsl = True
                .Host = My.Settings.emailServer
            End With
            eMail = New MailMessage()
            With eMail
                .Sender = New MailAddress(My.Settings.senderEmail)
                .From = New MailAddress("scores@score.com")
                .IsBodyHtml = True
                .Subject = $"Log for {Now.ToString("MM/dd/yyyy")}"
            End With
            For Each address In AddressList
                eMail.To.Add(address)
            Next
            Dim imgAttachment As New Attachment(emailTempsFolder & "\suprisedPikachu.png")
            eMail.Attachments.Add(imgAttachment)
            With bodyTable
                .Append(emailLogTemp.Replace("=Date=", Now.ToString("MM/dd/yyyy")))
            End With
            Dim attachmentLog As System.Net.Mail.Attachment
            attachmentLog = New System.Net.Mail.Attachment(fileName)
            eMail.Attachments.Add(attachmentLog)
            eMail.Body = bodyTable.ToString
            If eMail.Attachments.Count > 0 Then
                smtp.Send(eMail)
                logSend = True
            End If
        Catch ex As Exception
            Dim exceptionLog As New Logging(Now, "Log Email: ", ex.ToString)
            exceptionLog.LogAction()
            Return logSend
        End Try
        Return logSend
    End Function

    Public Function SendPasswordReminder(ByVal user As String, ByVal timeStamp As DateTime) As Boolean
        Dim reminderSend As Boolean = False
        Dim smtp As New SmtpClient
        Dim eMail As New MailMessage()
        Dim bodyTable As New StringBuilder
        Dim counterStats As Integer = 0
        Dim emailPasswordTemp As String = File.ReadAllText(emailTempsFolder & "\EmailPasswordReminder.html").ToString
        Try
            With smtp
                .UseDefaultCredentials = My.Settings.emailDefaultCreds
                .Credentials = New Net.NetworkCredential(My.Settings.emailCreds, My.Settings.passEmailCreds)
                .Port = My.Settings.emailPort
                .EnableSsl = True
                .Host = My.Settings.emailServer
            End With
            eMail = New MailMessage()

            With eMail
                .Sender = New MailAddress(My.Settings.senderEmail)
                .From = New MailAddress("scores@score.com")
                .IsBodyHtml = True
                .Subject = $"Password Reminder for {user}"
            End With
            For Each address In AddressList
                eMail.To.Add(address)
            Next
            With bodyTable
                .Append(emailPasswordTemp)
            End With
            eMail.Body = bodyTable.ToString.Replace("=User=", user).Replace("=monthsPast=", DateDiff(DateInterval.Month, timeStamp, Now))
            Dim rsAttached As New Attachment(emailTempsFolder & "\rollSafe.jpg")
            eMail.Attachments.Add(rsAttached)
            smtp.Send(eMail)
            reminderSend = True
        Catch ex As Exception
            Dim logAction As New Logging
            logAction.LogAction()
            Return reminderSend
        End Try
        Return reminderSend
    End Function
End Class
