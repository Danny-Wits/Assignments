'Program: Define and use constants in a simple arithmetic calculation
Module Program
Const PI As Double = 3.14159
Sub Main()
Dim radius As Double = Console.ReadLine()
Dim area As Double = PI * radius * radius
Console.WriteLine("Area of the circle is: " & area)
End Sub
End Module