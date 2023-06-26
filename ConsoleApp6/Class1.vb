Public Class circle
    Public diameter As Double
    Public Function area() As Double
        Return Math.PI * diameter
    End Function
End Class

Public Class square
    Public length As Double
    Public Function area() As Double
        Return length ^ 2
    End Function
End Class

Public Function GetArea(inShape As shape)
    Return inShape.area()
End Function