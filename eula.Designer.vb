'
' Created by SharpDevelop.
' User: Hammuoda
' Date: 03/05/2015
' Time: 02:46
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class eula
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
		Me.eulatxt = New System.Windows.Forms.TextBox()
		Me.agree = New System.Windows.Forms.Button()
		Me.cancel = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'eulatxt
		'
		Me.eulatxt.Location = New System.Drawing.Point(1, 2)
		Me.eulatxt.Multiline = true
		Me.eulatxt.Name = "eulatxt"
		Me.eulatxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.eulatxt.Size = New System.Drawing.Size(817, 492)
		Me.eulatxt.TabIndex = 3
		'
		'agree
		'
		Me.agree.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.agree.Location = New System.Drawing.Point(284, 504)
		Me.agree.Name = "agree"
		Me.agree.Size = New System.Drawing.Size(110, 30)
		Me.agree.TabIndex = 1
		Me.agree.Text = "Agree"
		Me.agree.UseVisualStyleBackColor = true
		AddHandler Me.agree.Click, AddressOf Me.AgreeClick
		'
		'cancel
		'
		Me.cancel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cancel.Location = New System.Drawing.Point(416, 504)
		Me.cancel.Name = "cancel"
		Me.cancel.Size = New System.Drawing.Size(110, 30)
		Me.cancel.TabIndex = 2
		Me.cancel.Text = "Decline"
		Me.cancel.UseVisualStyleBackColor = true
		AddHandler Me.cancel.Click, AddressOf Me.CancelClick
		'
		'eula
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(818, 546)
		Me.ControlBox = false
		Me.Controls.Add(Me.cancel)
		Me.Controls.Add(Me.agree)
		Me.Controls.Add(Me.eulatxt)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = false
		Me.MaximumSize = New System.Drawing.Size(824, 574)
		Me.MinimizeBox = false
		Me.MinimumSize = New System.Drawing.Size(824, 574)
		Me.Name = "eula"
		Me.Text = "END USER LICENSE AGREEMENT"
		AddHandler Load, AddressOf Me.EulaLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private cancel As System.Windows.Forms.Button
	Private agree As System.Windows.Forms.Button
	Private eulatxt As System.Windows.Forms.TextBox
End Class
