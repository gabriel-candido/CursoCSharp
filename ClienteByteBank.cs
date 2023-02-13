using Bytebank.Contas;
using Bytebank.Titular;
using System;

//contacorrente contadoandre = new contacorrente();
//contadoandre.titular = "andre silva";
//contadoandre.conta = "1010-x";
//contadoandre.numeroagencia = 15;
//contadoandre.saldo = 100;
//console.writeline("saldo da conta do cliente " + contadoandre.titular + " é r$" + contadoandre.saldo);

//contacorrente contadamaria = new contacorrente();
//contadamaria.titular = "maria souza";
//contadamaria.conta = "1018-5";
//contadamaria.numeroagencia = 17;
//contadamaria.saldo = 350;
//console.writeline("saldo da conta do cliente " + contadamaria.titular + " é r$" + contadamaria.saldo);

//contacorrente contadopedro = new contacorrente();
//contadopedro.titular = "pedro soares";
//contadopedro.conta = "4242-2";
//contadopedro.numeroagencia = 13;
//contadopedro.saldo = 73;
//console.writeline("saldo da conta do cliente " + contadopedro.titular + " é r$" + contadopedro.saldo);

//contadamaria.exibirdadosdaconta();


////testes de deposito e saque 
//console.writeline("saldo da conta do cliente " + contadoandre.titular + " é r$" + contadoandre.saldo);

//contadoandre.depositar(100);
//console.writeline("saldo da conta do cliente " + contadoandre.titular + " pos deposito é r$" + contadoandre.saldo);

//if (contadoandre.sacar(75) == true)
//{
//    console.writeline("saldo da conta do cliente " + contadoandre.titular + " pos saque é r$" + contadoandre.saldo);
//}
//else
//    console.writeline("saldo insuficiente");


//contacorrente conta = new contacorrente();
//console.writeline($"titular da conta: {conta.titular}");
//console.writeline($"numero da conta: {conta.conta}");
//console.writeline($"numero da agencia {conta.numeroagencia}");
//console.writeline($"saldo da conta {conta.saldo}");
//console.readkey();


////teste de transferencia de saldo entre as contas
//if (contadoandre.transferir(50, contadamaria) == true)
//{
//    console.writeline("saldo da conta do cliente " + contadoandre.titular + " apos transferencia é r$" + contadoandre.saldo);
//    console.writeline("saldo da conta do cliente " + contadamaria.titular + " apos transferencia é r$" + contadamaria.saldo);
//}
//else
//    console.writeLine("Cliente " + contaDoAndre.titular + " com saldo insuficiente");
//
// }

Cliente cliente = new Cliente("Andre silva", "12345678-9", "Analista");
ContaCorrente conta = new ContaCorrente(13, "1010-x", cliente, 100);

Cliente cliente2 = new Cliente("Maria souza", "9876544321-9", "Gerente");
ContaCorrente conta2 =new ContaCorrente(18, "1313-x", cliente2, 500);

Cliente cliente3 = new Cliente("Fulano souza", "9876544321-9", "Gerente");
ContaCorrente conta3 = new ContaCorrente(14, "143-x", cliente3, 500);

Cliente cliente4 = new Cliente("Beltrano souza", "1251484-9", "diretor");
ContaCorrente conta4 = new ContaCorrente(13, "9713-x", cliente4, 320);

Cliente cliente5 = new Cliente("Ciclano souza", "58548-9", "analista");
ContaCorrente conta5 = new ContaCorrente(12, "1341-x", cliente5, 173);

Cliente cliente6 = new Cliente("jose souza", "6468484-9", "coordenador");
ContaCorrente conta6 = new ContaCorrente(11, "1342-x", cliente6, 777);



//Testes
Console.WriteLine(ContaCorrente.totalDeContasCriadas);
Console.WriteLine();

cliente.ExibirDadosDoCliente();
conta.ExibirDadosDaConta();

//Console.WriteLine();

//cliente2.ExibirDadosDoCliente();
//conta2.ExibirDadosDaConta();

//Console.WriteLine();

//cliente3.ExibirDadosDoCliente();
//conta4.ExibirDadosDaConta();

//Console.WriteLine();

//cliente4.ExibirDadosDoCliente();
//conta4.ExibirDadosDaConta();

//Console.WriteLine();

//cliente5.ExibirDadosDoCliente();
//conta5.ExibirDadosDaConta();

//Console.WriteLine();

//cliente6.ExibirDadosDoCliente();
//conta6.ExibirDadosDaConta();
