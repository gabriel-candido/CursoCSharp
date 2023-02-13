using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytebank.Titular;

namespace Bytebank.Contas
{
    public class ContaCorrente
    {
        public static int totalDeContasCriadas { get; private set; }
        
        private int numeroAgencia;
        public int NumeroAgencia
        {
            get { return this.numeroAgencia; }
            private set 
            {
                if( value>0)
                this.numeroAgencia = value;

            }
        }

      //  private string conta;
        public string Conta { get; set; }


        // private Cliente titular;
        public Cliente titular; //{ get; set; }
      

        private double saldo;

        //funcoes
        public void Depositar(double valor)
        {
            saldo += valor;
        }
        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
                return false;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);

                return true;
            }
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Numero da conta: " + Conta);
            Console.WriteLine("Numero da agencia: " + NumeroAgencia);
            Console.WriteLine("Saldo da conta = " + saldo);
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
                return;
            else
                this.saldo = valor;
        }

        public double GetSaldo()
        {
            return this.saldo;

        }

        public ContaCorrente(int numero_agencia, string numero_conta, Cliente cliente, double saldo)
        {
            this.NumeroAgencia =numero_agencia;
            this.Conta = numero_conta;
            this.titular= cliente;
            this.saldo= saldo;

            totalDeContasCriadas++;

        }
    }
}

