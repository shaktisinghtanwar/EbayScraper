'
' Created by SharpDevelop.
' User: Hammuoda
' Date: 22/04/2015
' Time: 14:44
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Imports Microsoft.Win32
Imports System.Data

Partial Public Class MainForm
    Public Sub New()
        ' The Me.InitializeComponent call is required for Windows Forms designer support.
        Me.InitializeComponent()


        ' TODO : Add constructor code after InitializeComponents
        '
    End Sub


    Sub Button1Click(ByVal sender As Object, ByVal e As EventArgs) Handles searchbtn.Click
        label6.Text = ""
        dataGridView1.Rows.Clear()
        Dim URL As String
        Dim nb As Integer

        If urltxt.Text.ToLower().StartsWith("www.") Then
            urltxt.Text = "http://" & urltxt.Text
        End If

        URL = urltxt.Text

        URL = Replace(URL, "https://", "http://")

        If Val(textBox2.Text) < 1 Then
            nb = 1

        Else

            If Val(textBox2.Text) > 500 Then
                'textBox2.Text= 500				
                nb = 500
            Else
                nb = CType(textBox2.Text, Integer)
            End If

        End If


        progressBar1.Minimum = 0
        progressBar1.Value = 2
        progressBar1.Maximum = 100
        progressBar1.Step = CType(100 / nb, Integer)
        progressBar1.Visible = True

        For pg As Integer = 1 To nb

            If nb > 1 Then
                URL = URL & "?_fss=1&LH_BIN=1&_pgn=" & pg & "&rt=nc"
            Else
                URL = URL & "?_fss=1&LH_BIN=1&rt=nc"
            End If

            Dim inStream As StreamReader
            Dim webRequest As WebRequest
            Dim webresponse As WebResponse
            Dim content As String
            Dim content1 As String
            Dim nextwebresponce As WebResponse
            Dim strim As StreamReader
            
            Dim nextwebresponce2 As WebResponse
            Dim strim2 As StreamReader

            Dim nextwebRequest As WebRequest
            Dim nextwebRequest2 As WebRequest
            Dim todaycout As Integer
            Dim yesturadycount As Integer
            Dim lastdaycount As Integer


            Try
                webRequest = WebRequest.Create(URL)
                webresponse = webRequest.GetResponse()
                inStream = New StreamReader(webresponse.GetResponseStream())

                Dim reader As StreamReader = New StreamReader(webresponse.GetResponseStream(), System.Text.Encoding.UTF8)
                content = reader.ReadToEnd()

                ' Store HTML page as a file for debug purposes
                'File.WriteAllText("log.txt", content)
            Catch ex As Exception
                If inStream Is Nothing Then
                    MessageBox.Show("Please put a valid URL in the category URL field before pressing 'Start Search'" & vbCrLf & "If this issue persists please ensure you have a working internet connection.", "Alert")
                    progressBar1.Visible = False
                    Exit Sub
                End If

            End Try
            Dim htmlDocument As New HtmlAgilityPack.HtmlDocument()
            htmlDocument.LoadHtml(content)

            Dim names As New Dictionary(Of String, String) 

            Dim titleXPath As String = "//li[@class='s-item']//h3[@class='s-item__title']"
            dim titleNodes = htmlDocument.DocumentNode.SelectNodes(titleXPath)

            For Each node In titleNodes
                If Not names.ContainsKey(node.InnerText)
                     names.Add( node.InnerText,node.ParentNode.GetAttributeValue("href",""))
                End If
               
            Next

            Dim offerUrls As New Dictionary(Of String, String) 

            For Each entry In names

                        nextwebRequest = WebRequest.Create(entry.Value)
                        nextwebresponce = nextwebRequest.GetResponse()
                        strim = New StreamReader(nextwebresponce.GetResponseStream())
                        Dim reader As StreamReader = New StreamReader(nextwebresponce.GetResponseStream(), System.Text.Encoding.UTF8)
                        content1 = reader.ReadToEnd()
                                        
                        htmlDocument = New HtmlAgilityPack.HtmlDocument()

                        htmlDocument.LoadHtml(content1)
                        Dim nextUrlNode = htmlDocument.DocumentNode.SelectSingleNode("//span[@class='qtyTxt vi-bboxrev-dsplblk  vi-qty-fixAlignment feedbackON']//a")

                       offerUrls.Add(entry.Key , nextUrlNode.GetAttributeValue("href",""))


            Next   

            'OldWay(content, content1, nextwebresponce, strim, content2, nextwebresponce2, strim2, nextwebRequest, nextwebRequest2, todaycout, yesturadycount, lastdaycount)
        Next

        Dim z As Integer = dataGridView1.RowCount
        dataGridView1.Sort(dataGridView1.Columns(1), ListSortDirection.Descending)
        label6.Text = (z) & " Items Found"
        label6.Visible = True
        MessageBox.Show((z) & " Items Found", "Alert")
        progressBar1.Visible = False
    End Sub

    Private Sub OldWay(content As String, ByRef content1 As String, ByRef nextwebresponce As WebResponse, ByRef strim As StreamReader, ByRef content2 As String, ByRef nextwebresponce2 As WebResponse, ByRef strim2 As StreamReader, ByRef nextwebRequest As WebRequest, ByRef nextwebRequest2 As WebRequest, ByRef todaycout As Integer, ByRef yesturadycount As Integer, ByRef lastdaycount As Integer)
        Dim wb As New WebBrowser
        With wb
            .DocumentText = content
            .ScriptErrorsSuppressed = True
        End With
        'webresponse.Close()



        progressBar1.PerformStep()

        Dim li As System.Windows.Forms.HtmlDocument = wb.Document

        Do Until (wb.ReadyState = WebBrowserReadyState.Complete)
            Application.DoEvents()
        Loop


        wb.Dispose()
        Dim lielemCollection As HtmlElementCollection = li.GetElementsByTagName("li")

        Dim ContentStr As String
        Dim titletxt As String
        Dim price As String
        Dim valuelimit As String

        '	MsgBox(lielemCollection.Count)
        Dim breakLoop As Boolean = False
        For Each parentElement As HtmlElement In lielemCollection
            Dim elementName As String = parentElement.GetAttribute("className").ToLower()

            If elementName.Contains("s-item") Then

                Dim H3classStr As String = parentElement.GetElementsByTagName("h3")(0).GetAttribute("className")

                ContentStr = ""
                titletxt = ""
                price = ""
                lastdaycount = 0
                yesturadycount = 0
                todaycout = 0
                valuelimit = ""
                If ((H3classStr IsNot Nothing) And (H3classStr.Length <> 0)) Then
                    If (H3classStr.ToLower().Contains("s-item__title")) Then

                        '------------TITLE------------ 
                        titletxt = parentElement.GetElementsByTagName("h3")(0).InnerText
                        '------------URL--------------
                        ContentStr = parentElement.GetElementsByTagName("a")(0).GetAttribute("href")
                        '------------SOLD Number--------


                        '  Dim divelemCollection = parentElement.GetElementsByTagName("span")


                        nextwebRequest = WebRequest.Create(ContentStr)
                        nextwebresponce = nextwebRequest.GetResponse()
                        strim = New StreamReader(nextwebresponce.GetResponseStream())
                        Dim reader As StreamReader = New StreamReader(nextwebresponce.GetResponseStream(), System.Text.Encoding.UTF8)
                        content1 = reader.ReadToEnd()

                        Dim htmlDocument As New HtmlAgilityPack.HtmlDocument()
                        htmlDocument.LoadHtml(content)


                        Dim web As New WebBrowser
                        With web
                            .DocumentText = content1
                            .ScriptErrorsSuppressed = True
                        End With
                        Dim node As System.Windows.Forms.HtmlDocument = web.Document

                        Do Until (web.ReadyState = WebBrowserReadyState.Complete)
                            Application.DoEvents()
                        Loop
                        Dim divcollection As HtmlElementCollection = node.GetElementsByTagName("div")
                        For Each divlimit As HtmlElement In divcollection
                            Dim aaa = divlimit.GetAttribute("role")
                            If aaa.Contains("main") And Not String.IsNullOrEmpty(valuelimit) Then
                                Dim limit = divlimit.InnerText

                                Dim pattern As String = "Quantity:(.*?)available"
                                Dim elementmat As MatchCollection = Regex.Matches(limit, pattern)
                                For Each match As Match In elementmat
                                    valuelimit = match.Groups(1).Value
                                    Exit For
                                Next

                            End If
                            If Not String.IsNullOrEmpty(valuelimit) Then
                                Exit For
                            End If
                        Next

                        Dim nodeCollection As HtmlElementCollection = node.GetElementsByTagName("span")
                        For Each parent As HtmlElement In nodeCollection
                            If String.IsNullOrEmpty(price) Then
                                Exit For
                            End If

                            Dim elementN As String = parent.GetAttribute("className").ToLower()
                            Dim aaaa = parent.GetAttribute("itemprop").ToLower()

                            If aaaa.Contains("price") Then
                                If Not String.IsNullOrEmpty(aaaa) Then
                                    If aaaa.Contains("pricecurrency") Then
                                    Else
                                        price = parent.InnerText
                                    End If

                                End If


                            End If
                            If elementN.Contains("soldwithfeedback") Then

                                Dim Cont = parent.GetElementsByTagName("a")(0).GetAttribute("href")
                                nextwebRequest2 = WebRequest.Create(Cont)
                                nextwebresponce2 = nextwebRequest2.GetResponse()
                                strim2 = New StreamReader(nextwebresponce2.GetResponseStream())
                                Dim readerr As StreamReader = New StreamReader(nextwebresponce2.GetResponseStream(), System.Text.Encoding.UTF8)
                                content2 = readerr.ReadToEnd()
                                Dim webbrowser As New WebBrowser

                                With webbrowser
                                    .DocumentText = content2
                                    .ScriptErrorsSuppressed = True
                                End With
                                Dim nodes As System.Windows.Forms.HtmlDocument = webbrowser.Document
                                Do Until (webbrowser.ReadyState = WebBrowserReadyState.Complete)
                                    Application.DoEvents()
                                Loop
                                Dim nodeCollection2 As HtmlElementCollection = nodes.GetElementsByTagName("tr")
                                For Each parent1 As HtmlElement In nodeCollection2


                                    Dim elementN1 As String = parent1.GetAttribute("td").ToString()
                                    Try
                                        Dim tds = parent1.GetElementsByTagName("td")
                                        Dim txt1 As String = Nothing
                                        If tds.Count() > 0 Then
                                            txt1 = tds(0).InnerText
                                        End If


                                        If Not String.IsNullOrEmpty(txt1) Then
                                            Dim elementmatch As MatchCollection = Regex.Matches(txt1, "(.+?)(PST|PDT)")

                                            For Each m As Match In elementmatch

                                                Dim today = DateTime.Today.ToString("MMM-dd-yy")
                                                If m.Value.Contains(today) Then
                                                    todaycout = todaycout + 1
                                                End If
                                                Dim yesturday = DateTime.Today.AddDays(-1).ToString("MMM-dd-yy")
                                                If m.Value.Contains(yesturday) Then
                                                    yesturadycount = yesturadycount + 1
                                                Else
                                                    lastdaycount = lastdaycount + 1
                                                End If
                                            Next

                                        End If

                                    Catch ex As Exception

                                    End Try

                                Next
                            End If

                        Next

                        Dim divelemCollection = parentElement.GetElementsByTagName("span")


                        For Each div As HtmlElement In divelemCollection

                            Dim classStr As String = div.GetAttribute("className")

                            If ((classStr IsNot Nothing) And (classStr.Length <> 0)) Then
                                If (classStr.ToLower().Contains("s-item__hotness")) And InStr(div.InnerText, "sold") > 0 And Val(div.InnerText) >= Val(textBox3.Text) Then
                                    ' Fill in the data grid with a List
                                    Dim n As Integer = dataGridView1.Rows.Add()
                                    dataGridView1.Rows.Item(n).Cells(0).Value = titletxt
                                    dataGridView1.Rows.Item(n).Cells(1).Value = Val(div.InnerText.Trim)
                                    dataGridView1.Rows.Item(n).Cells(2).Value = ContentStr
                                    dataGridView1.Rows.Item(n).Cells(3).Value = todaycout
                                    dataGridView1.Rows.Item(n).Cells(4).Value = yesturadycount
                                    dataGridView1.Rows.Item(n).Cells(5).Value = lastdaycount
                                    dataGridView1.Rows.Item(n).Cells(6).Value = price
                                    'dataGridView1.Rows.Item(n).Cells(7).Value = valuelimit


                                End If
                            End If
                        Next
                        '------------------------------------       
                    End If
                End If


            ElseIf (elementName.Contains("lvresult")) Then

                Dim H3classStr As String = parentElement.GetElementsByTagName("h3")(0).GetAttribute("className")

                ContentStr = ""
                titletxt = ""
                If ((H3classStr IsNot Nothing) And (H3classStr.Length <> 0)) Then
                    If (H3classStr.ToLower().Equals("s-item__title") Or H3classStr.ToLower().Equals("lvtitle")) Then

                        '------------TITLE------------ 
                        titletxt = parentElement.GetElementsByTagName("h3")(0).InnerText
                        '------------URL--------------
                        ContentStr = parentElement.GetElementsByTagName("a")(0).GetAttribute("href")
                        '------------SOLD Number------------ 


                        Dim divelemCollection = parentElement.GetElementsByTagName("div")

                        For Each div As HtmlElement In divelemCollection

                            Dim classStr As String = div.GetAttribute("className")

                            If ((classStr IsNot Nothing) And (classStr.Length <> 0) And (div.InnerText IsNot Nothing)) Then
                                If (classStr.ToLower().Equals("s-item__hotness") Or classStr.ToLower().Contains("hotness-signal")) And div.InnerText.ToLower().Contains("sold") Then
                                    'And Val(div.InnerText) >= Val(textBox3.Text)
                                    Dim soldString As String = div.InnerText.ToLower().Replace("sold", "").Trim().Trim(New Char() {"+"c})

                                    If (Val(soldString) >= Val(textBox3.Text)) Then

                                        ' Fill in the data grid with a List
                                        Dim n As Integer = dataGridView1.Rows.Add()
                                        dataGridView1.Rows.Item(n).Cells(0).Value = titletxt
                                        dataGridView1.Rows.Item(n).Cells(1).Value = soldString
                                        dataGridView1.Rows.Item(n).Cells(2).Value = ContentStr


                                    End If
                                End If
                            End If

                        Next
                        '------------------------------------       
                    End If
                End If
            End If
        Next
    End Sub

    Sub DataGridView1CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dataGridView1.CellContentClick
        If e.RowIndex >= 0 And e.ColumnIndex = 0 Then
            Process.Start(dataGridView1(2, e.RowIndex).Value.ToString)
        End If
    End Sub

    Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles textBox2.GotFocus
        If textBox2.Text = " ie:10" Then
            textBox2.ForeColor = Color.Black
            textBox2.Text = ""
        End If
    End Sub


    Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles textBox2.LostFocus
        If textBox2.Text = Nothing Then
            textBox2.ForeColor = Color.Gray
            textBox2.Text = " ie:10"
        End If
        If Val(textBox2.Text) > 500 Then
            textBox2.Text = 500
        End If
    End Sub


    Sub TextBox3_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles textBox3.GotFocus
        If textBox3.Text = " ie:250" Then
            textBox3.ForeColor = Color.Black
            textBox3.Text = ""
        End If
    End Sub

    Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles textBox3.LostFocus
        If textBox3.Text = Nothing Then
            textBox3.ForeColor = Color.Gray
            textBox3.Text = " ie:250"
        End If
    End Sub


    Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBox3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Sub clrbtnClick(ByVal sender As Object, ByVal e As EventArgs) Handles clrbtn.Click
        label6.Text = ""
        dataGridView1.Rows.Clear()
    End Sub



    Sub MainFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Me.Visible = False
        Dim button As New Button
        button.Location = New Point(41, 201)
        button.Height = 50
        button.Width = 173
        button.Text = "Buy It Now Results"
        button.Name = "button1"
        button.Font = New Font("Georgia", 11.5)
        button.Font = New Font(button.Font, FontStyle.Bold)
        button.BackColor = Color.White
        button.ForeColor = Color.Black
        button.FlatStyle = FlatStyle.Popup
        button.Enabled = False
        progressBar1.Location = New Point(224, 208)

        Me.label7.Text = "V 2.0"
        Me.Text = "Top Selling Item Finder V 2.0"
        Me.label9.Text = "Copyright 2018 Tech App Software "
        Me.MinimizeBox = True

        Controls.Add(button)
        Dim key As Long

        Try
            Dim regconnexion As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\TOP SELLER", False)
            key = CType(regconnexion.GetValue("sn"), Long)
        Catch ex As Exception

        End Try

        Dim sm As New SecurityManager
        If sm.CheckKey() = -1 Then
            MsgBox("This machine cannot be identified")
            Application.Exit()
        ElseIf sm.CheckKey = key Then
        Else
            Form1.ShowDialog()

            If Not Long.TryParse(Form1.txtKey.Text, key) Then
                Application.Exit()
            End If

            If sm.CheckKey() = key Then
                Exit Sub
            End If
            MessageBox.Show("Activation was unsuccessful!")
            Application.Exit()
        End If



        'MessageBox.Show(Form1.key)

    End Sub





    Sub Label8Click(ByVal sender As Object, ByVal e As EventArgs) Handles label8.Click
        Process.Start("http://www.ebay.com/sch/allcategories/all-categories")
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub txt_limit_TextChanged(sender As Object, e As EventArgs) Handles txt_limit.TextChanged
        Try

            For Each row As DataGridViewRow In dataGridView1.Rows
                If row.Cells(4).Value.ToString.ToLower.StartsWith(txt_limit.Text) Then
                    row.Visible = True
                Else
                    row.Visible = False
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
