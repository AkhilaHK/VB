Public MustInherit Class Shape
    'Abstract method : use mustoverride

    Public MustOverride Function Draw() As String
    'virtual method : use override

    Public Overridable Sub Display()
        Console.WriteLine("Vb is Like English")
    End Sub

End Class

Public Class Rectangle
    Inherits Shape

    Public Overrides Function Draw() As String
        Return "Rectangle Drawn"
    End Function

    Public Overrides Sub Display()
        Console.WriteLine("Rectangle is a class that Inherits Shape")


    End Sub
End Class