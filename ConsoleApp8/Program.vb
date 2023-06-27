Imports System

Module Program
    Sub Main(args As String())
        Dim mycow1 As Cow = New Cow()
        Dim mycow2 As Cow = New Cow()
        mycow1.height = 10
        mycow1.weight = 200
        mycow2.height = 12
        mycow2.weight = 202
        Dim x As Integer = mycow1.CompareTo(mycow2)
    End Sub
End Module
