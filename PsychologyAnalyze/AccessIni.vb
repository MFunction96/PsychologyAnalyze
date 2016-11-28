Public Enum IniTypes
    GetConfig
    WriteConfig
End Enum

Public Class AccessIni

    Public Function Ini _
                    (ByVal lpApplicationName As String,
                    ByVal lpKeyName As String,
                    ByVal lpFileName As String,
                    ByVal IniType As IniTypes,
                    Optional ByVal lpString As String = vbNullString) _
                    As String

        Dim IniTemp As Long
        Dim IniResult As String
        Static lpFilePath As String

        lpFilePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + lpFileName

        If IniType = IniTypes.GetConfig Then

            IniTemp = NativeMethods.GetPrivateProfileString(lpApplicationName, lpKeyName, vbNullString, IniResult, &H400, lpFilePath)
            Ini = Replace(IniResult, Chr(0), vbNullString)
            If Ini = vbNullString Then
                MsgBox("未找到相应配置数据", vbCritical + vbOKOnly, "错误")
            End If
        Else
            IniTemp = NativeMethods.WritePrivateProfileString(lpApplicationName, lpKeyName, lpString, lpFilePath)
        End If

    End Function

End Class
