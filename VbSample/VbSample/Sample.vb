Public Class Sample
    Private strProperty As String
    Public Property StringProperty() As String
        Get
            Return strProperty
        End Get
        Set(ByVal value As String)
            strProperty = value
        End Set
    End Property

    Public Function GetSomeValue() As String
        Return " A new Vb Function"
    End Function

    Public Sub PrintSomeValue()
        Console.WriteLine("Printing values from Sample class")
    End Sub

End Class
