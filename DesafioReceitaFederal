using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 1790;

        if (1900.00 <= salario && salario <= 2800.00)
            Console.WriteLine("O IR é de 7,5%, desconto maximo de R$142,00");
        else
        {
            if (2800.01 <= salario && salario <= 3751.00)
                Console.WriteLine("O IR é de 15%, desconto maximo de R$350,00");
            else
            {
                if (3751.01 <= salario)
                    Console.WriteLine("Aliquota maxima, O IR é de 22,5%, desconto maximo de R$636,00");
                else
                    Console.WriteLine("Isento porque o salario é " + salario + ", ou seja menor que 1900");

            }

        }

    }
}
