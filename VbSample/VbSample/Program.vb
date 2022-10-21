Imports System
Imports System.Drawing

Module Program
    Sub Main(args As String())
        Dim objSample As New Sample()
        objSample.StringProperty = "Vb is Like English"
        objSample.PrintSomeValue()
        Dim value As String = objSample.GetSomeValue()
        Console.WriteLine("value = " + value)

        Dim objRectangle As New Rectangle()
        Dim drawn As String = objRectangle.Draw()
        objRectangle.Display()

        Console.WriteLine(drawn)

    End Sub

    Private Sub CallingFunction()
        Dim names As List(Of String) = ReturnNames()
        For index = 0 To names.Count - 1
            Console.WriteLine(names(index))
        Next
    End Sub
    'knowm as function when the method returns a value
    Private Function ReturnNames() As List(Of String)
        Dim strNames As New List(Of String)
        strNames.Add("Eena")
        strNames.Add("Meena")
        strNames.Add("Deeka")
        Return strNames
    End Function
    'known as subroutine when the method does not return anything
    Private Sub Arithmatic()
        Subtract(500, 200)
        Multiply(10, 20)
        Divide(10, 5)
    End Sub

    Private Sub Divide(v1 As Integer, v2 As Integer)
        Console.WriteLine(v1 / v2)
    End Sub

    Private Sub Multiply(v1 As Integer, v2 As Integer)
        Console.WriteLine(v1 * v2)
    End Sub

    Private Sub Subtract(v1 As Integer, v2 As Integer)
        Console.WriteLine(v1 - v2)
    End Sub

    Private Sub Add()
        Dim n1 As Integer = 100
        Dim n2 As Integer = 100
        Dim result As Integer = n1 + n2
        Console.WriteLine(result)
    End Sub
End Module
