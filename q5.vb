Module Program
Sub Main()
 ' Read input and convert to integer
Dim a As Integer = Convert.ToInt32(Console.ReadLine())
Dim b As Integer = Convert.ToInt32(Console.ReadLine())
' Arithmetic operators
Console.WriteLine("Addition: " & (a + b))
Console.WriteLine("Multiplication: " & (a * b))
' Relational operators
Console.WriteLine("Is a greater than b? " & (a > b))
' Logical operators
Console.WriteLine("Logical AND: " & ((a > 5) And (b > 15)))
End Sub
End Module