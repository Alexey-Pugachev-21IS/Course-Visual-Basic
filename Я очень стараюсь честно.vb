Imports System
Module TimeConverter
    Sub Main(args As String())
        Dim dec As Decimal
        Dim dbl As Double
        Dim sng As Single
        Dim rub As Integer
        Dim kop As Integer
        dec = 0.0000001
        dbl = 0.0000001
        sng = 0.0000001
        'Console.WriteLine(dec)
        'Console.WriteLine(dbl)
        'Console.WriteLine(sng)
        Dim input As Integer
        Console.WriteLine("¬ведите сумму в копейках: ")
        input = Console.ReadLine()
        sng = input / 100
        rub = input / 100
        kop = input Mod 100
        Console.WriteLine("{0} копеек = {1} рублей", input, sng)
        Console.WriteLine("{0} копеек = {1} рублей {2} копеек", input, rub, kop)
    End Sub
End Module
