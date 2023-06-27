Public Class Cow : Implements Animal, IComparable
    Private pHeight As Double
    Private pWeight As Double
    Public Property height As Double Implements Animal.height
        Get
            Return pHeight
        End Get
        Set(value As Double)
            pHeight = value
        End Set
    End Property

    Public Property weight As Double Implements Animal.weight
        Get
            Return pWeight
        End Get
        Set(value As Double)
            pWeight = value
        End Set
    End Property

    Public Function speed() As Double Implements Animal.speed
        Return pWeight * pHeight / 1000
    End Function

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        If TypeOf obj Is Cow Then
            Return CType(obj, Cow).speed = speed()
        Else
            Return -1
        End If
    End Function
End Class
