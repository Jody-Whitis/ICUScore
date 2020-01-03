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

    Public Sub SendWeekEmail()
        Try
            If AddressList Is Nothing Or AddressList.Count <= 0 Then
                Exit Sub
            End If
            Dim smtp As New SmtpClient
            Dim eMail As New MailMessage()
            Dim bodyTable As New StringBuilder
            Dim counterStats As Integer = 0
            smtp.UseDefaultCredentials = My.Settings.emailDefaultCreds
            smtp.Credentials = New Net.NetworkCredential(My.Settings.emailCreds, My.Settings.passEmailCreds)
            smtp.Port = My.Settings.emailPort
            smtp.EnableSsl = True
            smtp.Host = "smtp.gmail.com"

            eMail = New MailMessage()
            eMail.Sender = New MailAddress("scoretest@something.com")
            eMail.From = New MailAddress("scores@score.com")
            For Each address In AddressList
                eMail.To.Add(address)
            Next
            If ScoreList IsNot Nothing Then
                eMail.Subject = $"Scores from {Now.ToString("MM/dd/yyyy")}"
            End If
            eMail.IsBodyHtml = True

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
            MsgBox(ex.InnerException.ToString)
        End Try
    End Sub
End Class
