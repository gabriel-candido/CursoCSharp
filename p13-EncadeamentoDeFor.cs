using System;

class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 13 - encadeando for");

        //*
        //** 
        //***
        //****

        for (int contadorDeLinhas = 0; contadorDeLinhas < 10; contadorDeLinhas++)
        {
            for (int contadorDeColunas = 0; contadorDeColunas < 10; contadorDeColunas++)
            {
                Console.Write("*");
                if (contadorDeColunas >= contadorDeLinhas)
                    break;
            }

            Console.WriteLine();
        }
    


        Console.WriteLine("Tecle enter pra sair...");
        Console.ReadLine();

    }
}
