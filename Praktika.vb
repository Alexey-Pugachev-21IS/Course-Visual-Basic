Imports System
Imports System.Net.Security
Imports System.Reflection.Metadata.Ecma335

Module Praktika
    Sub Main(args As String())
        Console.WriteLine("16 вариант, Y = Min(A + C, min(B-4, C+2))")
        Dim Y, A, B, C, RBr As Integer
        Console.WriteLine("Enter A number:")
        A = Console.ReadLine()
        Console.WriteLine("Enter B number:")
        B = Console.ReadLine()
        Console.WriteLine("Enter C number:")
        C = Console.ReadLine()
        If (B - 4) < (C + 2) Then
            RBr = B - 4
        Else
            RBr = C + 2
        End If
        If (A + C) < RBr Then
            Y = A + C
        Else
            Y = RBr
        End If
        Console.WriteLine("Y = Min(A+C, min(B-4, C+2)) = {0}", Y)
    End Sub
End Module

