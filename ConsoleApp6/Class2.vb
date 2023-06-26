Public MustInherit Class shape
    Public distance_across As Double
    Public MustOverride Function area() As Double
End Class

Public Class circle1 : Inherits shape
    Public Overrides Function area() As Double
        Return Math.PI * distance_across
    End Function
End Class

Public Class square1 : Inherits shape
    Public Overrides Function area() As Double
        Return distance_across ^ 2
    End Function
End Class

