using System;

class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e texto");
        char letra = 'A';
        Console.WriteLine(letra);

        letra = (char)87;
        Console.WriteLine(letra);

        string primeiraFrase = @"Esta é a 
        primeira 
            variavel 
                de texto";
        Console.WriteLine(primeiraFrase);

        Console.WriteLine("Tecle entre pra fechar...");
        Console.ReadLine();
    }
}
