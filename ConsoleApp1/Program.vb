Imports System

Module Program
    Sub Main(args As String())
        Dim sum As Integer
        Dim inValue As Integer
        Dim myList As New List(Of Integer)
        Do
            inValue = CInt(Console.ReadLine())
            If inValue <> -1 Then
                sum += inValue
                myList.Add(inValue)
            End If
        Loop Until inValue = -1
        Console.WriteLine(sum / myList.Count)
        For i = 0 To myList.Count - 1
            Console.WriteLine(myList(i))
        Next
    End Sub
End Module
