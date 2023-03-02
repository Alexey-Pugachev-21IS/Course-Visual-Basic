Imports System

Module TimeConverter
    Sub Main(args As String())
        Dim input As Decimal
        Dim Min As UShort
        Dim Hrs As UShort
        Console.WriteLine("Please, enter number of seconds: ")
        input = Console.ReadLine()
        Min = input / 60
        Hrs = Min / 60
        Console.WriteLine("{0} seconds = {1} hours = {2} minutes", input, Hrs, Min)
        Console.WriteLine("Do u want to see more accurate results? If you do - enter number of seconds again:")
        Dim inputted As Decimal
        Dim Minutes As Decimal
        Dim Hours As Decimal
        inputted = Console.ReadLine()
        Minutes = inputted / 60
        Hours = Minutes / 60
        Console.WriteLine("{0} seconds = {1} hours, {2} minutes", inputted, Hours, Minutes)
        Console.WriteLine("Then I use the Mod I only see some issues, but if u wanna see that - enter number of seconds again:")
        Dim input1 As Decimal
        Dim Min1 As Decimal
        Dim Hrs1 As Decimal
        input1 = Console.ReadLine()
        Min1 = input1 Mod 60
        Hrs1 = Min1 Mod 60
        Console.WriteLine("{0} seconds = {1} hours = {2} minutes", input1, Hrs1, Min1)
        Console.WriteLine("Thats it")
    End Sub
End Module

