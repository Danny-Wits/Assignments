Module Program
Sub Main()
Dim num As Integer = 10
Dim doubleNum As Double
' Implicit casting
doubleNum = num
Console.WriteLine("Implicit Casting (Integer to Double): " & doubleNum)
' Explicit casting
Dim str As String = "123"
Dim castedNum As Integer = CInt(str)
Console.WriteLine("Explicit Casting (String to Integer): " & castedNum)
End Sub
End Module