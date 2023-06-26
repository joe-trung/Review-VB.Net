Imports System
Imports System.IO

Module Program
    Sub Main()
        Dim fs As FileStream = New FileStream("indata.txt", FileMode.Open, FileAccess.Read)
        Dim sr As StreamReader = New StreamReader(fs)
        Dim sum As Integer
        Dim inData As String
        Do
            inData = sr.ReadLine()
            sum += CInt(inData)
        Loop Until inData = Nothing
        Console.WriteLine(sum.ToString("n"))
    End Sub
End Module
