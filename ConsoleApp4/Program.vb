Imports System

Module Program
    Sub Main(args As String())
        Try
            Dim myCow As Cow = New Cow()
            myCow.Milk()
        Catch ex As CowException
            Console.WriteLine("There was a cow exception")
        Catch ex As Exception
            Console.WriteLine("There was a general exxception")
        End Try
    End Sub
End Module
