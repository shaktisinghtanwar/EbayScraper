'
' Created by SharpDevelop.
' User: Hammuoda
' Date: 22/04/2015
' Time: 14:44
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'


Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.urltxt = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.url = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wb = New System.Windows.Forms.WebBrowser()
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.clrbtn = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_limit = New System.Windows.Forms.TextBox()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.label1, "label1")
        Me.label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.label1.Name = "label1"
        '
        'label2
        '
        resources.ApplyResources(Me.label2, "label2")
        Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label2.Name = "label2"
        '
        'urltxt
        '
        resources.ApplyResources(Me.urltxt, "urltxt")
        Me.urltxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.urltxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.urltxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.urltxt.ForeColor = System.Drawing.Color.Gray
        Me.urltxt.Name = "urltxt"
        '
        'label3
        '
        resources.ApplyResources(Me.label3, "label3")
        Me.label3.Name = "label3"
        '
        'textBox2
        '
        Me.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.textBox2, "textBox2")
        Me.textBox2.ForeColor = System.Drawing.Color.Gray
        Me.textBox2.Name = "textBox2"
        '
        'label4
        '
        resources.ApplyResources(Me.label4, "label4")
        Me.label4.Name = "label4"
        '
        'label5
        '
        resources.ApplyResources(Me.label5, "label5")
        Me.label5.Name = "label5"
        '
        'textBox3
        '
        Me.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.textBox3, "textBox3")
        Me.textBox3.ForeColor = System.Drawing.Color.Gray
        Me.textBox3.Name = "textBox3"
        '
        'searchbtn
        '
        resources.ApplyResources(Me.searchbtn, "searchbtn")
        Me.searchbtn.ForeColor = System.Drawing.Color.White
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.UseVisualStyleBackColor = False
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.dataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.dataGridView1, "dataGridView1")
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.title, Me.sold, Me.url, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView1.ShowCellErrors = False
        Me.dataGridView1.ShowEditingIcon = False
        Me.dataGridView1.ShowRowErrors = False
        '
        'title
        '
        Me.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.title.DefaultCellStyle = DataGridViewCellStyle3
        resources.ApplyResources(Me.title, "title")
        Me.title.Name = "title"
        Me.title.ReadOnly = True
        Me.title.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'sold
        '
        Me.sold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.sold.DefaultCellStyle = DataGridViewCellStyle4
        resources.ApplyResources(Me.sold, "sold")
        Me.sold.Name = "sold"
        Me.sold.ReadOnly = True
        Me.sold.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'url
        '
        Me.url.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        resources.ApplyResources(Me.url, "url")
        Me.url.Name = "url"
        Me.url.ReadOnly = True
        Me.url.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column1
        '
        resources.ApplyResources(Me.Column1, "Column1")
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        resources.ApplyResources(Me.Column2, "Column2")
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        resources.ApplyResources(Me.Column3, "Column3")
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        resources.ApplyResources(Me.Column4, "Column4")
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'wb
        '
        Me.wb.AllowNavigation = False
        Me.wb.AllowWebBrowserDrop = False
        Me.wb.IsWebBrowserContextMenuEnabled = False
        resources.ApplyResources(Me.wb, "wb")
        Me.wb.Name = "wb"
        Me.wb.WebBrowserShortcutsEnabled = False
        '
        'progressBar1
        '
        resources.ApplyResources(Me.progressBar1, "progressBar1")
        Me.progressBar1.Name = "progressBar1"
        '
        'clrbtn
        '
        resources.ApplyResources(Me.clrbtn, "clrbtn")
        Me.clrbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.clrbtn.Name = "clrbtn"
        Me.clrbtn.UseVisualStyleBackColor = False
        '
        'label6
        '
        resources.ApplyResources(Me.label6, "label6")
        Me.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label6.Name = "label6"
        '
        'label7
        '
        resources.ApplyResources(Me.label7, "label7")
        Me.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label7.Name = "label7"
        '
        'label8
        '
        Me.label8.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.label8, "label8")
        Me.label8.ForeColor = System.Drawing.Color.Blue
        Me.label8.Name = "label8"
        '
        'label9
        '
        resources.ApplyResources(Me.label9, "label9")
        Me.label9.Name = "label9"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'txt_limit
        '
        resources.ApplyResources(Me.txt_limit, "txt_limit")
        Me.txt_limit.Name = "txt_limit"
        '
        'MainForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Controls.Add(Me.txt_limit)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.clrbtn)
        Me.Controls.Add(Me.progressBar1)
        Me.Controls.Add(Me.wb)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.searchbtn)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.urltxt)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents clrbtn As System.Windows.Forms.Button
    Private WithEvents progressBar1 As System.Windows.Forms.ProgressBar
    Private WithEvents wb As System.Windows.Forms.WebBrowser
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents searchbtn As System.Windows.Forms.Button
    Private WithEvents textBox3 As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents urltxt As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sold As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents url As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents txt_limit As System.Windows.Forms.TextBox
End Class

