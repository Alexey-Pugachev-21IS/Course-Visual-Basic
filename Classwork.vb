Imports System

Module Classwork
    Sub Main(args As String())
        Console.WriteLine("Enter 5 numbers")
        Dim input(4) As String
        For i = 0 To input.Length - 1
            input(i) = Console.ReadLine
        Next

        Sort(input)
        Print(input)
    End Sub
    Function Min(list As String(), index As Integer) As Integer
        Min = index
        For i = index + 1 To list.Length - 1
            If list(i) < list(Min) Then
                Min = i
            End If
        Next
    End Function
    Sub Sort(list As String())
        For i = 0 To list.Length - 1
            Dim x As Integer
            Dim b As String
            x = Min(list, i)
            If x > i Then
                b = list(i)
                list(i) = list(x)
                list(x) = b
            End If
        Next
    End Sub

    Sub Print(args As String())
        For i = 0 To args.Length - 1
            Console.WriteLine(args(i))
        Next
    End Sub
End Module