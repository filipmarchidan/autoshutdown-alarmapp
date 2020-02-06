Module Module1
    ' api declare
    Public Declare Function GetTickCount Lib "kernel32" () As Long

    ' is one sec. ?
    Public FPS_LastCheck As Long

    ' FPS were counted
    Public FPS_Count As Long

    ' here is the actual FPS number
    Public FPS_Current As Integer

    ' highest FPS
    Public FPS_Highest As Integer
End Module
