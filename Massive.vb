Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices

Module Program
    Enum SortType
        Ascending
        Descending
    End Enum
    Sub Main(args As String())
        Console.WriteLine("Enter 5 numbers")
        Dim input(4) As String
        For i = 0 To input.Length - 1
            input(i) = Console.ReadLine
        Next

        BubbleSort(input)
        print(input)

        'Dim n As Integer = Max(input)
        'Dim j As Integer = Min(input)
        'Console.WriteLine("input ({0}) = {1}", n, input(n))
        'Console.WriteLine("input ({0}) = {1}", j, input(j))
        'Add(input, 999, 2)
        ' Dim m As Integer = Min1(input)
        '' If m > 0 Then
        '  Dim d As String = input(0)
        ' input(0) = input(m)
        ' input(m) = d
        ' End If

        ' m = Min1(input, 1)
        ' Del(input, 0)
        '  print(input)

        ' If m > 1 Then
        'im d As String = input(0)
        'input(0) = input(m)
        'input(m) = d
        ' End If
    End Sub
    'Sub Add(ByRef list As Integer(), value As Integer, index As Integer)
    '    If index < 0 Or index > list.Length Then Exit Sub
    '    ReDim Preserve list(list.Length)
    '    For i = list.Length - 1 To index + 1 Step -1
    '        list(i) = list(i - 1)
    '    Next
    '    list(index) = value
    'End Sub
    Sub Del(ByRef list As String(), index As Integer)
        If index < 0 Or index > list.Length - 1 Then Exit Sub
        For i = index To list.Length - 2
            list(i) = list(i + 1)
        Next
        ReDim Preserve list(list.Length - 2)
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
    'Function Min1(list As String(), start As Optional) As Integer
    '    Min1 = start
    '    For i = start + 1 To list.Length - 1
    '        If list(i) < list(Min1) Then
    '            Min1 = i
    '        End If
    '    Next
    'End Function
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
    Sub BubbleSort(list As String(), Optional dir As SortType = SortType.Ascending)
        Dim b As String
        For j = 0 To list.Length - 2
            For i = 0 To list.Length - 2 - j
                If list(i) > list(i + 1) Then
                    b = list(i)
                    list(i) = list(i + 1)
                    list(i + 1) = b
                End If
            Next
        Next
    End Sub
End Module

