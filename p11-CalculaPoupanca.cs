using System;

class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10.2 - Calcula poupança com for");

        double investimento = 1000;
        double inicial = investimento;
        int mes;
        //rendimento de 0,5% 0,005 ao mês
        /*
        while (mes <= 360)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mes " + mes + " você tem: " + investimento);
            mes++;
        }*/

        for (mes = 1;mes <= 12; mes++)
        {
            investimento *=1.005;

            Console.WriteLine("No mes " + mes + " você tem: " + investimento);
        }

        Console.WriteLine("saldo Inicial: " + inicial);
        Console.WriteLine("Saldo após " + (mes - 1) + " meses é: " + investimento);
        Console.WriteLine("Tecle enter pra sair...");
        Console.ReadLine();

    }
}
