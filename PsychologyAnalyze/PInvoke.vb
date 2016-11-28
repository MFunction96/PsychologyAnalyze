Public Module PInvoke

    Public Enum ERROR_CODE
        ERROR_SUCCESS = &H0
        ERROR_FILE_NOT_FOUND = &H2
        ERROR_PATH_NOT_FOUND = &H3
        ERROR_ACCESS_DENIED = &H5
        ERROR_INVALID_HANDLE = &H6
        ERROR_INVALID_PARAMETER = &H57
        ERROR_NOACCESS = &H3E6
    End Enum

    Friend NotInheritable Class NativeMethods

        Private Sub New()
        End Sub

        <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
        Friend Shared Function WritePrivateProfileSection(
                               ByVal lpAppName As String,
                               ByVal lpString As String,
                               ByVal lpFileName As String) _
                               As Boolean
        End Function
        <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
        Friend Shared Function GetPrivateProfileString(
                               ByVal lpAppName As String,
                               ByVal lpKeyName As String,
                               ByVal lpDefault As String,
                               ByVal lpReturnedString As String,
                               ByVal nSize As Integer,
                               ByVal lpFileName As String) _
                               As Integer
        End Function

        <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
        Friend Shared Function WritePrivateProfileString(
                               ByVal lpAppName As String,
                               ByVal lpKeyName As String,
                               ByVal lpString As String,
                               ByVal lpFileName As String) _
                               As Boolean
        End Function

    End Class
End Module