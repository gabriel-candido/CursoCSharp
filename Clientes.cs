using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Titular
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public void ExibirDadosDoCliente()
        {
            Console.WriteLine("Titular da conta: " + Nome);
            Console.WriteLine("CPF do titular: " +Cpf);
            Console.WriteLine("Profissao: " + Profissao);
        }

        public Cliente(string nome, string cpf, string profissao)
        {
            Nome = nome;
            Cpf = cpf;
            Profissao = profissao;
        }
    }


}
