Imports System

Module Program
    Public num1 As Integer
    Public num2 As Integer
    Public answer As Integer
    Sub Main()
        Console.WriteLine("Escribe un número y pulsa Enter")
        num1 = Console.ReadLine()
        Console.WriteLine("Escribe otro número para sumar al anterior y pulsa Enter")
        num2 = Console.ReadLine()
        answer = num1 + num2
        Console.WriteLine("Su suma es " & answer)
        Console.ReadLine()
    End Sub
End Module
