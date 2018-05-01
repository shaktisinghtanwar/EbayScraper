'
' Created by SharpDevelop.
' User: Hammuoda
' Date: 28/04/2015
' Time: 00:00
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.




'

Imports System.Management


Partial Class Form1
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
				End If
		End If
		MyBase.Dispose(disposing)	
	End Sub
	

	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
        Me.btnActivate = New System.Windows.Forms.Button()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cancel = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'btnActivate
        '
        Me.btnActivate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnActivate.Location = New System.Drawing.Point(52, 334)
        Me.btnActivate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(100, 28)
        Me.btnActivate.TabIndex = 10
        Me.btnActivate.Text = "Activate"
        Me.btnActivate.UseVisualStyleBackColor = true
        '
        'txtKey
        '
        Me.txtKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtKey.Location = New System.Drawing.Point(29, 302)
        Me.txtKey.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(257, 22)
        Me.txtKey.TabIndex = 9
        '
        'txtSerial
        '
        Me.txtSerial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtSerial.Location = New System.Drawing.Point(29, 270)
        Me.txtSerial.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.ReadOnly = true
        Me.txtSerial.Size = New System.Drawing.Size(257, 22)
        Me.txtSerial.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(-72, 305)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Activation Key"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(-75, 270)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Serial Number"
        '
        'cancel
        '
        Me.cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cancel.Location = New System.Drawing.Point(160, 334)
        Me.cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 28)
        Me.cancel.TabIndex = 11
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = true
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.label3.Location = New System.Drawing.Point(5, 69)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(377, 48)
        Me.label3.TabIndex = 12
        Me.label3.Text = "Copy and paste the following serial number along with your full name into an emai"& _ 
    "l and send it to:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label4.Location = New System.Drawing.Point(72, 11)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(215, 28)
        Me.label4.TabIndex = 13
        Me.label4.Text = "Activation Instructions"
        '
        'label5
        '
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.label5.Location = New System.Drawing.Point(5, 43)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(296, 28)
        Me.label5.TabIndex = 14
        Me.label5.Text = "In order to activate this software:"
        '
        'label6
        '
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Underline)
        Me.label6.ForeColor = System.Drawing.Color.Blue
        Me.label6.Location = New System.Drawing.Point(5, 121)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(263, 28)
        Me.label6.TabIndex = 15
        Me.label6.Text = "activate@topsellingitemfinder.com "
        '
        'label7
        '
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.label7.Location = New System.Drawing.Point(5, 159)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(360, 55)
        Me.label7.TabIndex = 16
        Me.label7.Text = "You will then receive an email with the activation key which you could copy from "& _ 
    "the email and paste into the ""Activation Key"" field below."
        '
        'label8
        '
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.label8.Location = New System.Drawing.Point(5, 231)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(156, 28)
        Me.label8.TabIndex = 17
        Me.label8.Text = "Then click ""Activate""."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 348)
        Me.ControlBox = false
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.btnActivate)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(383, 395)
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(383, 395)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activation"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
	Private label8 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Friend cancel As System.Windows.Forms.Button
	Friend Label1 As System.Windows.Forms.Label
	Friend Label2 As System.Windows.Forms.Label
	Friend txtSerial As System.Windows.Forms.TextBox
	Friend txtKey As System.Windows.Forms.TextBox
	Friend btnActivate As System.Windows.Forms.Button
End Class

