Imports System

Module Program
    Sub Main(args As String())
        FillRect(5, 6, 10, 5)
    End Sub
    Sub Hline(Len As Integer, leftx As Integer, topy As Integer)
        Console.SetCursorPosition(leftx, topy)
        For i = 1 To Len
            Console.Write("0")
        Next
    End Sub
    Sub Vline(len As Integer, leftx As Integer, topy As Integer)
        Console.SetCursorPosition(leftx, topy)
        For i = 1 To len
            Console.Write("0")
            Console.SetCursorPosition(leftx, topy + i)
        Next
    End Sub

    Sub FillRect(leftx As Integer, topy As Integer, shirina As Integer, visota As Integer)
        For i = 1 To 10
            Hline(shirina, leftx, topy + i)
        Next
    End Sub
End Module
