Module Program
Dim globalVar As Integer = 100 ' Global variable
Sub Main()
Dim localVar As Integer = 50 ' Local variable
Console.WriteLine("Local Variable: " & localVar)
Console.WriteLine("Global Variable: " & globalVar)
GlobalVarTest()
End Sub
Sub GlobalVarTest()
Console.WriteLine("Accessing Global Variable from another method: " & globalVar)
End Sub
End Module