Imports System.Management

Class SecurityManager
    Public Function GetSerial() As Long
        Dim cpu As String = ""

        Try
            Dim mc1 As New ManagementClass("Win32_Processor")
            Dim moc1 As ManagementObjectCollection = mc1.GetInstances

            For Each mo As ManagementObject In moc1
                cpu = mo.Properties("processorID").Value.ToString()
                Exit For
            Next

            Dim idcpu As String = ""
            Dim z As Integer = 0
            For Each c As Char In cpu
                If IsNumeric(c) Then
                    z = z + 1
                    idcpu = c & idcpu
                    If z > 3 Then Exit For
                End If

            Next

            idcpu = "1" & idcpu

            Dim sum As Long = 0
            Dim index As Integer = 1
            For Each ch As Char In cpu
                If Char.IsDigit(ch) Then
                    sum += sum + Integer.Parse(ch) * (index * 2)
                ElseIf Char.IsLetter(ch) Then
                    Select Case ch.ToString.ToUpper
                        Case "A"
                            sum += sum + 10 * (index * 2)
                        Case "B"
                            sum += sum + 11 * (index * 2)
                        Case "C"
                            sum += sum + 12 * (index * 2)
                        Case "D"
                            sum += sum + 13 * (index * 2)
                        Case "E"
                            sum += sum + 14 * (index * 2)
                        Case "F"
                            sum += sum + 15 * (index * 2)
                    End Select
                End If

                index += 1
            Next

            Return sum + CType(idcpu, Long)
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function CheckKey() As Long
        Dim x As Long = GetSerial()
        If x = -1 Then Return -1
        Dim y As Long = CType((x * x + 39 / x + 99 * (x / 5)), Long)
        Return y
    End Function
End Class