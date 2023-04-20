Imports System
Imports System.ComponentModel

Module Program
    Sub Main()
        Dim x, y, p, a, b As Double
        x = 2.1
        y = -1.7
        a = (Math.Cos((Math.Abs(x * y))) ^ 3) - 1
        b = Math.E ^ x * y - Math.Abs(y) * Math.Sin(x)
        p = a * Math.Log((Math.Abs(b)) - 3.1 * Math.Cos(b)) / Math.Sqrt(Math.Abs(x + (a ^ 2 * b)))
        Console.WriteLine("p = {0}", p)
    End Sub
End Module
