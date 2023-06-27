Public Class BMI : Implements IComparable

    Private pWeight As Decimal
    Private pHeight As Decimal
    Public Property Weight
        Get
            Return pWeight
        End Get
        Set(value)
            pWeight = value
        End Set
    End Property
    Public Property Height
        Get
            Return pHeight
        End Get
        Set(value)
            pHeight = value
        End Set
    End Property
    Public Function BMI_Value()
        Return pWeight / pHeight ^ 2
    End Function

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        If TypeOf obj Is BMI Then
            Return (BMI_Value() - CType(obj, BMI).BMI_Value()) * 1000
        Else
            Return -1
        End If
    End Function
End Class
