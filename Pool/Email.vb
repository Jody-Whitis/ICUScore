Imports System.Net.Mail
Imports System.Text

Public Class Email
    Private _addressList As String()
    Private _scoreList As IEnumerable
    'Private Const userCreditals As String = "projtestcred@gmail.com"
    'Private Const passCreditals As String = "aolknqyzcrhcemec"

#Region "Prop"
    Public Sub New(eAddresses As String(), ds As IEnumerable)
        AddressList = eAddresses
        ScoreList = ds
    End Sub

    Public Property AddressList As String()
        Get
            Return _addressList
        End Get
        Set(value As String())
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

    Public Sub New(eAddresses As String())
        AddressList = eAddresses
    End Sub

    Public Sub SendWeekEmail()
        Try
            If AddressList Is Nothing OrElse AddressList.Count <= 0 Then
                Exit Sub
            End If
            Dim smtp As New SmtpClient
            Dim eMail As New MailMessage()
            Dim bodyTable As New StringBuilder
            smtp.UseDefaultCredentials = False
            smtp.Credentials = New Net.NetworkCredential(My.Settings.emailCreds, My.Settings.passEmailCreds)
            smtp.Port = My.Settings.emailPort
            smtp.EnableSsl = True
            smtp.Host = "smtp.gmail.com"

            eMail = New MailMessage()
            eMail.From = New MailAddress("scoretest@something.com")
            For Each address In AddressList
                eMail.To.Add(address)
            Next
            If ScoreList Is Nothing Then
                eMail.Subject = "HHHEYYYYYYYY"
            End If
            eMail.IsBodyHtml = True

            With bodyTable
#Region "Table header"
                .Append("<table style=""border: 2px solid blue"">")
                .Append("<tr style=""border:1px solid green;width:30px"">")
                .Append("<td style=""border:1px solid green;width:30px"">Name</td>")
                .Append("<td style=""border:1px solid green;width:30px"">Mode</td>")
                .Append("<td style=""border:1px solid green;width:30px"">Score</td>")
                .Append("</tr>")
#End Region
                For Each stat In ScoreList
                    .Append("<tr>")
#Region "Table cells"
                    .Append("<td style=""border:1px solid green;width:30px"">")
                    .Append(stat(0))
                    .Append("</td>")
                    .Append("<td style=""border:1px solid green;width:30px"">")
                    .Append(stat(1))
                    .Append("</td>")
                    .Append("<td style=""border:1px solid green;width:30px"">")
                    .Append(stat(2))
                    .Append("</td>")
#End Region
                    .Append("</tr>")
                Next
                .Append("</table>")
            End With

            eMail.Body = bodyTable.ToString
            smtp.Send(eMail)
        Catch ex As Exception
            MsgBox(ex.InnerException.ToString)
        End Try
    End Sub
End Class
