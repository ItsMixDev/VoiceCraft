Imports System.Runtime.InteropServices
Imports System.Threading
Public Class Emulator

    Private Declare Sub keybd_event Lib "user32.dll" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)

    <DllImport("User32.dll", SetLastError:=False, CallingConvention:=CallingConvention.StdCall, CharSet:=CharSet.Auto)>
    Public Shared Function MapVirtualKey(ByVal uCode As UInt32, ByVal uMapType As UInt32) As UInt32
    End Function

    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As IntPtr) 'Long may have to change to type Int32 or DWORD
    Dim LEFTDOWN As Integer = &H2
    Dim LEFTUP As Integer = &H4
    Dim RIGHTDOWN As Integer = &H8
    Dim RIGHTUP As Integer = &H10
    Dim MIDDLEUP As Integer = &H40
    Dim MIDDLEDOWN As Integer = &H20

    Dim mining As Boolean = False
    Dim eating As Boolean = False
    Dim walking As Boolean = False
    Dim sneaking As Boolean = False

    Public Sub Mine()
        mining = True
        mouse_event(2, 0, 0, 0, IntPtr.Zero)
    End Sub

    Public Sub Eat()
        eating = True
        mouse_event(RIGHTDOWN, 0, 0, 0, IntPtr.Zero)
        Thread.Sleep(2000)
        If eating Then
            eating = False
            mouse_event(RIGHTUP, 0, 0, 1, IntPtr.Zero)
        End If
    End Sub

    Public Sub Interact()
        If mining Then
            mining = False
            mouse_event(LEFTUP, 0, 0, 0, IntPtr.Zero)
        End If
        mouse_event(RIGHTDOWN, 0, 0, 0, IntPtr.Zero)
        mouse_event(RIGHTUP, 0, 0, 0, IntPtr.Zero)
    End Sub

    Public Sub Attack()
        If mining Then
            mining = False
            mouse_event(LEFTUP, 0, 0, 0, IntPtr.Zero)
        End If
        mouse_event(LEFTDOWN, 0, 0, 0, IntPtr.Zero)
        mouse_event(LEFTUP, 0, 0, 0, IntPtr.Zero)
    End Sub

    Public Sub StopAll()
        If mining Then
            mining = False
            mouse_event(LEFTUP, 0, 0, 0, IntPtr.Zero)
        End If
        If walking Then
            walking = False
            keybd_event(Keys.W, MapVirtualKey(Keys.W, 0), 2, 0)
            keybd_event(Keys.S, MapVirtualKey(Keys.S, 0), 2, 0)
        End If
        If eating Then
            eating = False
            mouse_event(RIGHTUP, 0, 0, 0, IntPtr.Zero)
        End If
        If sneaking Then
            sneaking = False
            keybd_event(Keys.LShiftKey, MapVirtualKey(Keys.LShiftKey, 0), 2, 0)
        End If
    End Sub

    Private Sub MoveCursor(offsetX As Integer, offsetY As Integer)
        Dim newPos As Point = New Point(Cursor.Position.X + offsetX, Cursor.Position.Y + offsetY)
        Cursor.Position = New Point(Cursor.Position.X, Cursor.Position.Y - 1)
        Thread.Sleep(50)
        Cursor.Position = newPos
    End Sub

    Public Sub Up()
        MoveCursor(0, -20)
    End Sub

    Public Sub BigUp()
        MoveCursor(0, -200)
    End Sub

    Public Sub Down()
        MoveCursor(0, 20)
    End Sub
    Public Sub BigDown()
        MoveCursor(0, 200)
    End Sub
    Public Sub Right()
        MoveCursor(20, 0)
    End Sub
    Public Sub BigRight()
        MoveCursor(200, 0)
    End Sub
    Public Sub Left()
        MoveCursor(-20, 0)
    End Sub
    Public Sub BigLeft()
        MoveCursor(-200, 0)
    End Sub

    Public Sub Forward()
        walking = True
        keybd_event(Keys.S, MapVirtualKey(Keys.S, 0), 2, 0)
        keybd_event(Keys.W, MapVirtualKey(Keys.W, 0), 0, 0)
    End Sub

    Public Sub Back()
        walking = True
        keybd_event(Keys.W, MapVirtualKey(Keys.W, 0), 2, 0)
        keybd_event(Keys.S, MapVirtualKey(Keys.S, 0), 0, 0)
    End Sub

    Public Sub Sneak()
        sneaking = True
        keybd_event(Keys.LShiftKey, MapVirtualKey(Keys.LShiftKey, 0), 0, 0)
    End Sub

    Public Sub Quit()
        keybd_event(Keys.Escape, MapVirtualKey(Keys.Escape, 0), 0, 0)
        Thread.Sleep(10)
        keybd_event(Keys.Escape, MapVirtualKey(Keys.Escape, 0), 2, 0)
    End Sub

    Public Sub OpenInventory()
        keybd_event(Keys.E, MapVirtualKey(Keys.E, 0), 0, 0)
        Thread.Sleep(10)
        keybd_event(Keys.E, MapVirtualKey(Keys.E, 0), 2, 0)
    End Sub

    Public Sub Jump()
        keybd_event(Keys.Space, MapVirtualKey(Keys.Space, 0), 0, 0)
        Thread.Sleep(100)
        keybd_event(Keys.Space, MapVirtualKey(Keys.Space, 0), 2, 0)
    End Sub

    Public Sub Drop()
        keybd_event(Keys.Q, MapVirtualKey(Keys.Q, 0), 0, 0)
        Thread.Sleep(10)
        keybd_event(Keys.Q, MapVirtualKey(Keys.Q, 0), 2, 0)
    End Sub
    Public Sub DropAll()
        keybd_event(Keys.LControlKey, MapVirtualKey(Keys.LControlKey, 0), 0, 0)
        keybd_event(Keys.Q, MapVirtualKey(Keys.Q, 0), 0, 0)
        Thread.Sleep(10)
        keybd_event(Keys.Q, MapVirtualKey(Keys.Q, 0), 2, 0)
        keybd_event(Keys.LControlKey, MapVirtualKey(Keys.LControlKey, 0), 2, 0)
    End Sub

    Public Sub Hb1()
        keybd_event(Keys.D1, MapVirtualKey(Keys.D1, 0), 0, 0)
        Thread.Sleep(100)
        keybd_event(Keys.D1, MapVirtualKey(Keys.D1, 0), 2, 0)
    End Sub

    Public Sub Hb2()
        keybd_event(Keys.D2, MapVirtualKey(Keys.D2, 0), 0, 0)
        Thread.Sleep(100)
        keybd_event(Keys.D2, MapVirtualKey(Keys.D2, 0), 2, 0)
    End Sub
    Public Sub Hb3()
        keybd_event(Keys.D3, MapVirtualKey(Keys.D3, 0), 0, 0)
        Thread.Sleep(100)
        keybd_event(Keys.D3, MapVirtualKey(Keys.D3, 0), 2, 0)
    End Sub

    Public Sub Hb4()
        keybd_event(Keys.D4, MapVirtualKey(Keys.D4, 0), 0, 0)
        Thread.Sleep(100)
        keybd_event(Keys.D4, MapVirtualKey(Keys.D4, 0), 2, 0)
    End Sub

    Public Sub Hb5()
        keybd_event(Keys.D5, MapVirtualKey(Keys.D5, 0), 0, 0)
        Thread.Sleep(100)
        keybd_event(Keys.D5, MapVirtualKey(Keys.D5, 0), 2, 0)
    End Sub
    Public Sub Hb6()
        keybd_event(Keys.D6, MapVirtualKey(Keys.D6, 0), 0, 0)
        Thread.Sleep(100)
        keybd_event(Keys.D6, MapVirtualKey(Keys.D6, 0), 2, 0)
    End Sub

    Public Sub Hb7()
        keybd_event(Keys.D7, MapVirtualKey(Keys.D7, 0), 0, 0)
        Thread.Sleep(100)
        keybd_event(Keys.D7, MapVirtualKey(Keys.D7, 0), 2, 0)
    End Sub
    Public Sub Hb8()
        keybd_event(Keys.D8, MapVirtualKey(Keys.D8, 0), 0, 0)
        Thread.Sleep(100)
        keybd_event(Keys.D8, MapVirtualKey(Keys.D8, 0), 2, 0)
    End Sub
    Public Sub Hb9()
        keybd_event(Keys.D9, MapVirtualKey(Keys.D9, 0), 0, 0)
        Thread.Sleep(100)
        keybd_event(Keys.D9, MapVirtualKey(Keys.D9, 0), 2, 0)
    End Sub

End Class
