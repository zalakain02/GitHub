Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine(vbCrLf + "Como Te Lamas? ")
        Dim name = Console.ReadLine()
        Dim currentDate = DateTime.Now
        Console.WriteLine($"{vbCrLf}Hola, {name},  {currentDate:d}  a las {currentDate:t}!")
        Console.Write(vbCrLf + "Presiona una tecla para continuar... ")
        Console.ReadKey(True)
    End Sub
End Module
