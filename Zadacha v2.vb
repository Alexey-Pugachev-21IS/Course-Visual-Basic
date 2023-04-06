Imports System
Imports System.Transactions

Module Program
    Sub Main(args As String())
        Dim numoflines As Integer
        Console.WriteLine("Enter a number of lines in nakladnaya - ")
        numoflines = Console.ReadLine
        For i = 1 To numoflines
            Console.WriteLine("Enter name - ")
            Dim name As String
            Dim mass As Double
            Dim number As Integer
            name = Console.ReadLine
            Console.WriteLine("Enter mass - ")
            mass = Console.ReadLine
            Console.WriteLine("Enter number - ")
            number = Console.ReadLine
            Console.WriteLine("Name = {0}, Mass = {1}", name, mass)
            Console.WriteLine("Number - {0}", number)
        Next
    End Sub
End Module
