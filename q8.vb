'Program: Unbox an object type back to a value type.
Module Program
Sub Main()
Dim obj As Object = 60
Dim num As Integer = CType(obj, Integer) ' Unboxing
Console.WriteLine("Unboxed Integer: " & num)
End Sub
End Module