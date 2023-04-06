Imports System
Imports System.Transactions

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter name, mass and number - ")
        Dim input(2) As String
        For i = 0 To input.Length - 1
            input(i) = Console.ReadLine
        Next
        Dim n, m, num As String
        n = input(0)
        m = input(1)
        num = input(2)
        Console.WriteLine("{0}. Name = {1}, Mass = {2}", num, n, m)
    End Sub
End Module
