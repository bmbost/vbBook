Module Module1

    Sub Main()
        Console.WriteLine("Welcome to Visual Basic!")
        Console.Write("Please type your name: ")
        Dim name As String
        name = Console.ReadLine()
        Console.WriteLine("Hello, {0}!", name)
        Console.WriteLine()
        Console.WriteLine("Press Enter to quit...")
        Console.ReadLine()
    End Sub

End Module
