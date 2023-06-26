Imports System
Imports System.IO

Module Program
    Sub Main()
        Dim myBMI1 As BMI = New BMI()
        Dim myBMI2 As BMI = New BMI()
        myBMI1.Height = 60
        myBMI1.Weight = 200
        myBMI2.Height = 61
        myBMI2.Weight = 200
        If myBMI1.CompareTo(myBMI2) > 0 Then
            Console.WriteLine("BMI1 is greater")
        Else
            Console.WriteLine("BMI1 is smaller")
        End If
    End Sub
End Module
