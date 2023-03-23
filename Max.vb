Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter 5 numbers")
        Dim input(4) As Integer
        For i = 0 To 4
            input(i) = Console.ReadLine
        Next
        Dim n As Integer = Max(input)
        Console.WriteLine("input ({0}) = {1}", n, input(n))
    End Sub
    Function Max(list As Integer()) As Integer
        Max = 0
        For i = 0 To 4
            If list(i) > list(Max) Then
                Max = i
            End If
        Next
    End Function
    Sub printRevers(list As Integer())
        For i = list.Length - 1 To 0 Step -1
            Console.WriteLine(list(i))
        Next
    End Sub

    Sub printreRevers(list As String())
        For i = list.Length - 1 To 0 Step -1
            Console.WriteLine(list(i))
        Next
    End Sub
    Sub print(list As Integer())
        For i = 0 To list.Length - 1
            Console.WriteLine(list(i))
        Next
    End Sub


    Sub print(list As String())
        For i = 0 To list.Length - 1
            Console.WriteLine(list(i))
        Next
    End Sub

    Function find(list As Integer(), n As Integer) As Integer
        For i = 0 To list.Length - 1
            If list(i) = n Then
                find = i
                Exit Function
            End If
        Next
        find = -1
    End Function
End Module
