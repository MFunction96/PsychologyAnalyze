Public Class AccessIni

    Public Function GetConfig(ByVal lpApplicationName As String,
                    ByVal lpKeyName As String,
                    ByVal lpFileName As String) _
                    As String

        Dim temp As String
        Dim iniTemp As Integer
        Dim iniResult As String = vbNullString * &H400
        Static lpFilePath As String

        lpFilePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + lpFileName
        iniTemp = NativeMethods.GetPrivateProfileString(lpApplicationName, lpKeyName, vbNullString, iniResult, &H400, lpFilePath)
        temp = Trim(iniResult)
        If temp = vbNullString Then
            MsgBox("未找到相应配置数据", vbCritical + vbOKOnly, "错误")
        End If

        Return temp

    End Function

    Public Sub WriteConfig(
               ByVal lpApplicationName As String,
               ByVal lpKeyName As String,
               ByVal lpFileName As String,
               ByVal lpString As String)

        Dim iniTemp As Long
        Static lpFilePath As String

        lpFilePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + lpFileName
        iniTemp = NativeMethods.WritePrivateProfileString(lpApplicationName, lpKeyName, lpString, lpFilePath)

    End Sub

End Class
