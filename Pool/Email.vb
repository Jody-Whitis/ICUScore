Imports System.Net.Mail
Imports System.Text

Public Class Email
    Private _addressList As List(Of String)
    Private _scoreList As IEnumerable
    'Private Const userCreditals As String = "projtestcred@gmail.com"
    'Private Const passCreditals As String = "aolknqyzcrhcemec"

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
                .Sender = New MailAddress("scoretest@something.com")
                .From = New MailAddress("scores@score.com")
                .IsBodyHtml = True
                .Subject = $"Scores for {Now.ToString("MM/dd/yyyy")}"
            End With
            For Each address In AddressList
                eMail.To.Add(address)
            Next
            'Table to be filled with stats
            With bodyTable
#Region "Table header"

                .Append("<table style=""border: 7px solid blue;margin-left:auto;margin-right:auto;background-color:Aqua;")
                .Append("width:100%;border-collapse:collapse;border-spacing:0;"">")

                .Append("<tr>")
                .Append("<td style=""font-size:14px;text-align:center;color:green"">")
                .Append("<b>")
                .Append($"{Now.ToString("MM/dd/yyyy")}")
                .Append("</b>")
                .Append("</td>")
                .Append("</tr>")
                .Append("</table>")

                .Append("<table style=""border: 2px solid blue;margin-left:auto;margin-right:auto;background-color:Aqua;")
                .Append("width:100%;border-collapse:collapse;border-spacing:0;"">")
                .Append("<tr style=""border:1px solid green;color:green;font-size:18px;background-color:Aqua;text-align:center;width:33%;border-collapse:collapse;border-spacing:0;"">")
                .Append("<td style=""border:1px solid green;color:green;font-size:18px;background-color:Aqua;text-align:center;width:33%;border-collapse:collapse;border-spacing:0;""><b>Name</b></td>")
                .Append("<td style=""border:1px solid green;color:green;font-size:18px;background-color:Aqua;text-align:center;width:33%;border-collapse:collapse;border-spacing:0;""><b>Mode</b></td>")
                .Append("<td style=""border:1px solid green;color:green;font-size:18px;background-color:Aqua;text-align:center;width:33%;border-collapse:collapse;border-spacing:0;""><b>Score</b></td>")
                .Append("</tr>")
#End Region
                For Each stat In ScoreList
                    .Append("<b>")
                    .Append("<tr style=""border:1px solid green;color:green;font-size:18px;background-color:Aqua;text-align:center;width:33%;border-collapse:collapse;border-spacing:0;"">")
#Region "Table cells"
                    .Append("<td style=""border:1px solid green;width:33%;border-collapse:collapse;border-spacing:0;"">")
                    .Append(stat(0))
                    .Append("</td>")
                    .Append("<td style=""border:1px solid green;width:33%;border-collapse:collapse;border-spacing:0;"">")
                    .Append(stat(1))
                    .Append("</td>")
                    .Append("<td style=""border:1px solid green;width:33%;border-collapse:collapse;border-spacing:0;"">")
                    .Append(stat(2))
                    .Append("</td>")
#End Region
                    .Append("</tr>")
                    counterStats += 1
                Next
                .Append("</table>")
                .Append("</b>")
            End With
            eMail.Body = bodyTable.ToString
            If counterStats > 0 Then
                smtp.Send(eMail)
            Else
                'MsgBox("nothing to send")
            End If
        Catch ex As Exception
            Dim exceptionLog As New Logging(Now, "Weekly Email: ", ex.ToString)
            exceptionLog.LogAction()
            MsgBox(ex.InnerException.ToString)
        End Try
    End Sub

    Public Function SendLogEmail(fileName As String) As Boolean
        Dim logSend As Boolean = False
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
                .Sender = New MailAddress("scoretest@something.com")
                .From = New MailAddress("scores@score.com")
                .IsBodyHtml = True
                .Subject = $"Log for {Now.ToString("MM/dd/yyyy")}"
            End With
            For Each address In AddressList
                eMail.To.Add(address)
            Next

            With bodyTable
#Region "Table header"

                .Append("<table style=""border: 7px solid blue;margin-left:auto;margin-right:auto;background-color:Aqua;")
                .Append("width:100%;border-collapse:collapse;border-spacing:0;"">")

                .Append("<tr>")
                .Append("<td style=""font-size:14px;text-align:center;color:red"">")
                .Append("<b>")
                .Append($"Log for {Now.ToString("MM/dd/yyyy")}")
                .Append("</b>")
                .Append("</td>")
                .Append("</tr>")
                .Append("</table>")
#End Region

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
End Class
