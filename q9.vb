'Program: Combine constants and expressions to calculate the area of a rectangle.
Module Program
Sub Main()
Const Length As Integer = Convert.toInt32(Console.ReadLine())
Const Width As Integer = Convert.toInt32(Console.ReadLine())
Dim area As Integer = Length * Width
Console.WriteLine("Area of the rectangle: " & area)
End Sub
End Module