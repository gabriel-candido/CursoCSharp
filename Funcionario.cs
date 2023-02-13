using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string Nome, string Cpf, double salario)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;
        }

        public virtual double GetBonificacao()
        {
            return this.Salario * 0.1;
        }

        public virtual void AumentarSalario()
        {
            this.Salario *= 1.1;
        }

        public void ExibirDadosFuncionario()
        {
            Console.WriteLine("Nome: "+ this.Nome);
            Console.WriteLine("CPF: " + this.Cpf);
            Console.WriteLine("Salario: " + this.Salario);

        }
    }
}
