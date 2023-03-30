Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter 5 numbers")
        Dim input(4) As Integer
        For i = 0 To input.Length - 1
            input(i) = Console.ReadLine
        Next
        'Dim n As Integer = Max(input)
        'Dim j As Integer = Min(input)
        'Console.WriteLine("input ({0}) = {1}", n, input(n))
        'Console.WriteLine("input ({0}) = {1}", j, input(j))
        Add(input, 999, 2)
        print(input)
    End Sub
    Sub Add(ByRef list As Integer(), value As Integer, index As Integer)
        If index < 0 Or index > list.Length Then Exit Sub
        ReDim Preserve list(list.Length)
        For i = list.Length - 1 To index + 1 Step -1
            list(i) = list(i - 1)
        Next
        list(index) = value
    End Sub
    Function Max(list As Integer()) As Integer
        Max = 0
        For i = 0 To list.Length - 1
            If list(i) > list(Max) Then
                Max = i
            End If
        Next
    End Function
    Function Min(list As Integer()) As Integer
        Min = 0
        For i = 0 To list.Length - 1
            If list(i) < list(Min) Then
                Min = i
            End If
        Next
    End Function
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
        For i = 0 To list.Length - n
            If list(i) = n Then
                find = i
                Exit Function
            End If
        Next
        find = -1
    End Function
End Module

