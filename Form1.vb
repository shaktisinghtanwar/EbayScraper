Imports Microsoft.Win32
'
' Created by SharpDevelop.
' User: Hammuoda
' Date: 28/04/2015
' Time: 00:00
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.

'

Public Partial Class Form1
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim serial As Long
        Dim sm As New SecurityManager
        serial = sm.GetSerial
        txtSerial.Text = CType(serial,string)
    End Sub


Public Property key as Long

	

Dim i As Integer	
	
	
    'Sub BtnActivateClick(sender As Object, e As EventArgs) Handles btnActivate.Click

    '    i = i + 1
    '    '5368185072


    '    If Not Long.TryParse(txtKey.Text, key) Then
    '        MessageBox.Show("Invalid activation key")
    '        Exit Sub
    '    End If


    '    Dim sm As New SecurityManager
    '    If sm.CheckKey() = key Then
    '        Me.Hide()
    '        MessageBox.Show("Activation was successful")
    '        eula.ShowDialog()

    '    Else

    '        MessageBox.Show("Activation was unsuccessful")
    '        If i > 2 Then
    '            Me.Dispose()
    '            MainForm.Close()
    '        End If

    '    End If

    'End Sub

    Sub CancelClick(sender As Object, e As EventArgs)   'Handles cancel.Click
    MainForm.Close()
    End Sub
	
    Sub Label6Click(sender As Object, e As EventArgs) 'Handles label6.Click
    Process.Start("mailto:" & "activate@topsellingitemfinder.com" & "?subject=Serial Number:" & txtSerial.Text)
    End Sub

Private Sub btnActivate_Click(sender As Object, e As EventArgs) 'Handles btnActivate.Click
 i = i + 1
        '5368185072
        If Not Long.TryParse(txtKey.Text, key) Then
            MessageBox.Show("Invalid activation key")
            Exit Sub
        End If

        Dim sm As New SecurityManager
        If sm.CheckKey() = key Then
            Me.Hide()
            MessageBox.Show("Activation was successful")
            eula.ShowDialog()

        Else

            MessageBox.Show("Activation was unsuccessful")
            If i > 2 Then
                Me.Dispose()
                MainForm.Close()
            End If

        End If
    End Sub

End Class
