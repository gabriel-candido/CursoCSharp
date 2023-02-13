using System;

class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 12 - investindfo a longo prazo");

        double investimento = 1000;
        double inicial = investimento;

        double fatorDeRendimento = 1.005;
        int ano;
        for(ano=1; ano <= 5; ano++) 
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                //investimento = investimento + investimento * 0.005;
                investimento *= fatorDeRendimento;
                Console.WriteLine("No mes " + mes + " ano " + ano+" você tem: " + investimento);

            }
            fatorDeRendimento += 0.001;
        }

        Console.WriteLine("saldo Inicial: " + inicial);
        Console.WriteLine("Saldo após " + (ano-1) + " anos é: " + investimento);
        Console.WriteLine("Tecle enter pra sair...");
        Console.ReadLine();

    }
}
