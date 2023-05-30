Imports System

Module Program
    Function Y(x)
        Y = Math.Sin(x) + Math.Sqrt(x)
    End Function
    Sub Main(args As String())
        Dim list() As Decimal = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim i As Integer = 0
        For x As Decimal = 0 To 1 Step 0.1
            Y(x)
            list(i) = Y(x)
            Console.WriteLine("Y = {0}, List = {1}, X = {2}", Y(x), list(i), x)
        Next
    End Sub
End Module
