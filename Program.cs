using System.ComponentModel.DataAnnotations;
using Projeto_SENAI_20._05.models;

// Pessoa pessoa = new Pessoa();
// Aluno aluno = new Aluno();
// Professor professor = new Professor();
// Diretor diretor = new Diretor();

// pessoa.Nome = "Joana";
// pessoa.Idade = 19;
// pessoa.Apresentar();

// Console.WriteLine("");

// professor.Nome="Flexa";
// professor.Idade =30;
// professor.Salario =10000;
// professor.Apresentar();

// Console.WriteLine("");

// aluno.Nome = "Evellyn";
// aluno.Idade = 17;
// aluno.Nota = 10;
// aluno.Apresentar();

// Console.WriteLine("");

// diretor.Nome = "Elvis";
// diretor.Idade = 32;
// diretor.Salario = 15000;
// diretor.Apresentar();

// Console.WriteLine("");

//////////////////////////////////////////////////////////////////////////////////////

Funcionario funcionario = new Funcionario();
Gerente gerente = new Gerente();
Desenvolvedor desenvolvedor = new Desenvolvedor();
Estagiario estagiario = new Estagiario();

List<Funcionario> funcionarios = new List<Funcionario>();

gerente.Nome = "Roberto";
gerente.Salario = 3000;

desenvolvedor.Nome = "Joana";
desenvolvedor.Salario = 2000;

estagiario.Nome = "Evellyn";
estagiario.Salario = 1000;



funcionarios.Add(gerente);
funcionarios.Add(desenvolvedor);
funcionarios.Add(estagiario);

for(int i = 0; i < 3; i++ ){
funcionarios[i].ApresentarSalario();}


////////////////////////////////////////////////////////////////////////////////////////////////

ContaBancaria conta = new ContaBancaria();
ContaCorrente contaCorrente = new ContaCorrente();
ContaPoupanca contaPoupanca = new ContaPoupanca();


contaCorrente.Numero = 1;
contaCorrente.Titular = "Joana";
contaCorrente.TaxaSaque = 5;

contaCorrente.Depositar(1000);

contaCorrente.Sacar(200);

Console.WriteLine("=== CONTA CORRENTE ===");
contaCorrente.MostrarDados();

Console.WriteLine();



contaPoupanca.Numero = 2;
contaPoupanca.Titular = "Carlos";
contaPoupanca.RendimentoMensal = 2;

contaPoupanca.Depositar(2000);

contaPoupanca.AplicarRendimento();

Console.WriteLine("=== CONTA POUPANÇA ===");
contaPoupanca.MostrarDados();