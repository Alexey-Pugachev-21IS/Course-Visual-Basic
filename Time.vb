Imports System
Imports System.Transactions

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter number of seconds:")
        Dim input, hrs, nado, min, sec As Decimal
        input = Console.ReadLine()
        hrs = input \ 3600
        nado = input Mod 3600
        min = nado \ 60                            'Без вашей утренней подсказки это сделать нереально, я вчера до 2 часов сидел
        sec = min Mod 60
        Console.WriteLine("{0} seconds is: {1} hour(s), {2} minute(s), {3} second(s)", input, hrs, min, sec)
    End Sub
End Module
