Imports System
Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter number of centimeters:")
        Dim sm, dm, ostatok, m, input As Decimal
        input = Console.ReadLine()
        m = input \ 100
        ostatok = input Mod 100
        dm = ostatok \ 10
        sm = ostatok Mod 10
        Console.WriteLine("{0} sm is: {1} m, {2} dm, {3} sm", input, m, dm, sm)
    End Sub
End Module
