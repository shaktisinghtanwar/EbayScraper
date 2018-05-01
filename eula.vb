'
' Created by SharpDevelop.
' User: Hammuoda
' Date: 03/05/2015
' Time: 02:46
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports Microsoft.Win32
Public Partial Class eula
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub EulaLoad(sender As Object, e As EventArgs)
		eulatxt.Text="END USER LICENSE AGREEMENT " & vbCrLf & vbCrLf & vbCrLf & 
		"This copy of Top Selling Item Finder (the software product) and accompanying documentation is licensed and not sold. This Software Product is protected by copyright laws and treaties, as well as laws and treaties related to other forms of intellectual property. Tech App Software or its subsidiaries, affiliates, and suppliers (collectively 'Tech App Software') own intellectual property rights in the Software Product is subject to these rights and to all the terms and conditions of this End User License Agreement (Agreement)" & vbCrLf & vbCrLf &  
		"Acceptance" & vbCrLf & vbCrLf & 
		" YOU ACCEPT AND AGREE TO BE BOUND BY THE TERMS OF THIS AGREEMENT BY SELECTING THE ‘ACCEPT ‘ POTION AND DOWNLOADING THE SOFTWARE PRODUCT OR BY INSTALLING, USING, OR COPYING THE SOFTWARE PRODUCT. YOU MUST AGREE TO ALL OF THE TERMS OF THIS AGREEMENT BEFORE YOU WILL BE ALLOWED TO DOWNLOAD THE SOFTWARE PRODUCT. IF YOU DO NOT AGREE TO ALL OF THE TERMS OF THIS AGREEMENT, YOU MUST SELECT 'DECLINE' AND YOU MUST NOT INSTALL, USE, OR COPY THE SOFTWARE PRODUCT."  & vbCrLf & vbCrLf & 
		" License Grant "& vbCrLf & vbCrLf & 
		" This Agreement entitles you to install and use one copy of the Software Product. In addition, you may make one archival copy of the Software Product. The archival copy must be on a storage medium other than a hard drive, and may only be used for the reinstallation of the Software Product, or the installation of the Software Product on more than one computer at any given time, on a system that allows shared use of applications on a multi-user network, or on any configuration or system of computers that allows multiple users. Multiple copy use or installation is only allowed if you obtain an appropriate licensing agreement for each user and each copy of the Software Product." & vbCrLf & vbCrLf &
		" Restrictions on Transfer " & vbCrLf & vbCrLf &
		" Without first obtaining the express written consent of Tech App Software, you may not assign your rights and obligations under this Agreement, or redistribute, encumber, sell, rent, lease, sublicense, or otherwise transfer your rights to the Software Product." & vbCrLf & vbCrLf &
		" Restrictions on Use " & vbCrLf & vbCrLf &
		" You may not use, copy, or install the Software Product on any system with more than one computer, or permit the use, copying, or installation of the Software Product by more than one user or on more than one computer. If you hold multiple, validly licensed copies, you may not use, copy, or install the Software Product on any system with more than the number of computers permitted by license, or permit the use, copying, or installation by more users, or on more computers than the number permitted by license." & vbCrLf & vbCrLf &
		" You may not decompile, 'reverse-engineer', disassemble, or otherwise attempt to derive the source code for the Software Product." & vbCrLf & vbCrLf &
		" Restrictions on Alteration" & vbCrLf & vbCrLf &
		" You may not modify the Software Product or create any derivative work of the Software Product or its accompanying documentation. Derivative works include but are not limited to translations. You may not alter any files or libraries in any portion of the Software Product." & vbCrLf & vbCrLf &
		" Restrictions on Copying" & vbCrLf & vbCrLf &
		" You may not copy any part of the Software Product except to the extent that licensed use inherently demands the creation of a temporary copy stored in computer memory and not permanently affixed on storage medium. You may make one archival copy which must be stored on a medium other than a computer hard drive." & vbCrLf & vbCrLf &
		" Limited Software Product Warranty" & vbCrLf & vbCrLf &
		" For a period of 30 days from the date of shipment or from the date that you download the Software Product, as applicable, Tech App Software warrants that when properly installed and used under normal conditions, the Software Product will perform substantially as advertised." & vbCrLf & vbCrLf &
		" Disclaimer of Warranties and Limitation of Liability" & vbCrLf & vbCrLf &
		" UNLESS OTHERWISE EXPLICITLY AGREED TO IN WRITING BY TECH APP SOFTWARE, TECH APP SOFTWARE MAKES NO OTHER WARRANTIES, EXPRESS OR IMPLIED, IN FACT OR IN LAW, INCLUDING, BUT NOT LIMITED TO, ANY IMPLIED WARRANTIES OF MERCHANTABLITIY OR FIRNESS FOR A PARTICULAR PERPOSE OTHER THAN AS SET FORTH IN THIS AGREEMENT OR IN THE LIMITED WARRANTY DOCUMENTS PROVIDED WITH THE SOFTWARE PRODUCT." & vbCrLf & vbCrLf &
		" Tech App Software makes no warranty that the Software Product will meet your requirements or operate under your specific conditions of use. Tech App Software makes no warranty that operation of the Software Product will be secure, error free, or free from interruption. YOU MUST DETERMINE WHETHER THE SOFTWARE PRODUCT SUFFICIENTLY EETS YOUR REQUIREMENTS FOR SECURITY AND UNINTERRUPTABILITY. YOU BEAR SOLE RESPONSIBILITY AND ALL LIABILITY FOR ANY LOSS INCURRED DUE TO FAILURE OF THE SOFTWARE PRODUCT TO MEET YOUR REQUIREMENTS. TECH APP SOFTWARER WILL NOT, UNDER ANY CIRCUMSTANCES, BE RESPONSIBLE OR LIABLE FOR THE LOSS OF DATA ON ANY COMPUTER OR INFORMATION STORAGE DEVICE. " & vbCrLf & vbCrLf &
		" UNDER NO CIRCUMSTANCES SHALL TECH APP SOFTWARE, ITS DIRECTORS, OFFICERS, EMPLOYEES OR AGENTS BE LIABLE TO YOU OR ANY OTHER PARTY FOR INDIRECT, CONSEQUENTIAL, SPECIAL, INCIDENTAL, PUNITIVE, OR EXEPLARY DAMAGES OF ANY KIND (INCLUDING LOSS REVENUES OR PROFITS OR LOSS OF BUSINESS) RESULTING FROM THIS AGREEMENT, OR FROM THE FURNISHING, PERFORMANCE, INSTALLATION , OR USE OF THE SOFTWARE PRODUCT, WHETHER DUE TO A BREACH OF CONTRACT, BREACH OF WARRANTY, OR THE NEGLIGENCE OF TECH APP SOFTWARE OR ANY OTHER PARTY, EVEN IF TECH APP SOFTWARE IS ADVISED BEFOREHAND OF THE POSSIBILITY OF SUCH DAMAGES. TO THE EXTENT THAT THE APPLICABLE JURISDICTION LIMITS TECH APP SOFTWARE’S ABLITITY TO DISCLAIM ANY IMPLIED WARRANTIES, THIS DISCLAIMER SHALL BE EFFECTIVE TO THE MAXIMUM EXTENT PERMITTED." & vbCrLf & vbCrLf &
		" Limitation of Remedies and Damages" & vbCrLf & vbCrLf &
		" Your remedy for a breach of this Agreement or of any warranty included in this Agreement is the correction or replacement of the Software Product. Selection of whether to correct or replace shall be solely at the discretion of Tech App Software. Tech App Software reserves the right to substitute the functionally equivalent copy of the Software Product as a replacement. If Tech App Software is unable to provide a replacement or substitute Software Product or corrections to the Software Product, Your sole alternate remedy shall be a refund of the purchase price for the Software Product exclusive of any costs for shipping and handling." & vbCrLf & vbCrLf &
		" Any claims must be made within the applicable warranty period. All warranties cover only defects arising under normal use and do not include malfunctions or failure resulting from misuse, abuse, neglect, alteration, problems with electrical power, acts of nature, unusual temperatures or humidity, improper  installation, or damage determined by Tech App Software to have been caused by you. All limited warranties on the Software Product are granted only to you and are non-transferable. You agree to indemnify and hold Tech App Software harmless from all claims, judgments, liabilities, expenses, or costs arising from your breach of this Agreement and/or acts or omissions." & vbCrLf & vbCrLf &
		" Governing Law, Jurisdiction and Costs" & vbCrLf & vbCrLf &
		" This Agreement is governed by the laws of New Jersey, without regard to New Jersey’s conflict or choice of law provisions." & vbCrLf & vbCrLf &
		" Severability" & vbCrLf & vbCrLf &
		" If any provision of this Agreement shall be held to be invalid or unenforceable, the remainder of this Agreement shall remain in full force and effect. To the extent any express or implied restrictions are not permitted by applicable laws, these express or implied restrictions shall remain in force and effect to the maximum extent permitted by such applicable laws." & vbCrLf & vbCrLf &
		" " & vbCrLf & vbCrLf 

		
		
	End Sub
	
	Sub AgreeClick(sender As Object, e As EventArgs)
		Dim regconnexion As RegistryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\TOP SELLER")
		Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\TOP SELLER", "sn", Form1.key.ToString)
        MainForm.show()	
		Me.Close
		Form1.close
		
	End Sub
	
	Sub CancelClick(sender As Object, e As EventArgs)
	MainForm.Close()	
	End Sub
End Class
