Imports System
Imports System.Security.Cryptography.X509Certificates

Module ConsoleGraphic
    Dim input, input1 As Single
    Dim x, y, x1, y1 As Integer
    Private brush As Char = "0"c
    Sub Main(args As String())
        Console.WriteLine("0 - Hline, 1 - Vline, 2 - закрашенный прямоугольник, 3 - пустой прямоугольник")
        input = Console.ReadLine()
        Console.WriteLine("Хотите изменить построение? 1 - да, 2 - нет.")
        input1 = Console.ReadLine()
        nastroika()
        Select Case input
            Case 0
                If input1 = 1 Then
                    Hline(x, y, x1)
                Else
                    Hline(5, 5, 15)
                End If
            Case 1
                If input1 = 1 Then
                    Vline(x, y, x1)
                Else
                    Vline(5, 5, 15)
                End If
            Case 2
                If input1 = 1 Then
                    Filrect(x, y, x1, y1)
                Else
                    Filrect(5, 5, 50, 25)
                End If
            Case 3
                If input1 = 1 Then
                    Pustcub(x, y, x1, y1)
                Else
                    Pustcub(10, 10, 20, 10)
                End If
        End Select
    End Sub
    Sub Hline(leftx As Byte, topy As Byte, length As Byte)
        Console.SetCursorPosition(leftx, topy)
        For i = 1 To length
            Console.Write(brush)
        Next
    End Sub
    Sub Vline(leftx As Byte, topy As Byte, length As Byte)
        Console.SetCursorPosition(leftx, topy)
        For i = 1 To length
            Console.Write(brush)
            Console.SetCursorPosition(leftx, topy + i)
        Next
    End Sub
    Sub Filrect(leftx As Byte, topy As Byte, width As Byte, height As Byte)
        Console.SetCursorPosition(leftx, topy)
        For j = 0 To height - 1
            Hline(leftx, topy + j, width)
        Next
    End Sub
    Sub Pustcub(leftx As Byte, topy As Byte, width As Byte, height As Byte)
        Console.SetCursorPosition(leftx, topy)
        For i = 1 To width
            Console.Write(brush)
        Next
        For j = 1 To height - 3
            Console.SetCursorPosition(leftx, topy + j)
            Console.Write(brush)
            Console.SetCursorPosition(leftx + width - 1, topy + j)
            Console.WriteLine(brush)
        Next
        Console.SetCursorPosition(leftx, topy + height - 2)
        For i = 1 To width
            Console.Write(brush)
        Next
    End Sub

    Sub nastroika()
        If input1 = 1 Then
            Console.Write("отступ слева = ")
            x = Console.ReadLine()
            Console.Write("отступ сверху = ")
            y = Console.ReadLine()
            Console.Write("длина = ")
            x1 = Console.ReadLine()
            If input = 2 Or input = 3 Then
                Console.Write("высота = ")
                y1 = Console.ReadLine()
            End If
        End If
    End Sub
End Module
