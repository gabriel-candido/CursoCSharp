using BytebankADM.Diretor;
using BytebankADM.Funcionarios;
using BytebankADM.Utilitario;




Funcionario pedro = new Funcionario("Pedro malazarte", "1234567-11", 2000);

Diretoria roberta = new Diretoria("Roberta silva", "48515181-7", 5000);
Console.WriteLine("Dados antes do aumento: ");
pedro.ExibirDadosFuncionario();
roberta.ExibirDadosFuncionario();
Console.WriteLine();

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

pedro.AumentarSalario();
roberta.AumentarSalario();
//Teste

Console.WriteLine("Dados após do aumento: ");
pedro.ExibirDadosFuncionario();
roberta.ExibirDadosFuncionario();
Console.WriteLine();

Console.WriteLine("Salario Roberta: " + roberta.Salario);
