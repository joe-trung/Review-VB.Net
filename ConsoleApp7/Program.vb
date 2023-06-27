Imports System

Module Program
    Sub Main(args As String())
        Dim myT As Triangle = New Triangle
        myT.side1 = 10
        myT.side2 = 10
        Console.WriteLine(myT.area())
    End Sub
End Module
