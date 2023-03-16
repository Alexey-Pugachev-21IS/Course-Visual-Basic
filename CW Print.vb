Imports System


Module Program
        Sub Main(args As String())
            Console.WriteLine("Enter 5 numbers")
            Dim input(4) As Integer
        Dim n As Integer
        n = Console.ReadLine
        For i = 0 To 4
            input(i) = Console.ReadLine
        Next
        Console.WriteLine("Which nubmer you want to find?")
        For i = 0 To input.Length - 1
            If input(i) = 21 Then
                Console.WriteLine("Index of 21 = {0}", i)
            End If
        Next

    End Sub

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
            find = -1
        Next
    End Function
End Module