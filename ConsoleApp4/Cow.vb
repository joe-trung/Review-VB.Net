Public Class Cow
    Public spots As Integer
    Public Overrides Function Equals(ByVal inObj As Object) As Boolean
        If TypeOf inObj Is Cow Then
            Return CType(inObj, Cow).spots = spots
        Else
            Return inObj.GetHashCode = MyClass.GetHashCode
        End If
    End Function

    Public Overloads Function Equals(ByVal inCow As Cow) As Boolean
        Return inCow.spots = spots
    End Function
End Class
