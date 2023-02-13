using BytebankADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankADM.Diretor
{
    public class Diretoria:Funcionario
    {
        public string Nome { get; set; }

        public string Cpf { get; private set; }
        public double Salario { get;  set; }
        
        public Diretoria(string nome, string Cpf, double salario):base(nome, Cpf,salario)
        {
            this.Nome = nome;
            this.Cpf = Cpf;
            this.Salario = salario;
        }

        public override double GetBonificacao()
        {
            return this.Salario + base.GetBonificacao();
        }

        public override void AumentarSalario()
        {
             this.Salario *= 1.15;
        }
    }
}

