using Projeto_SENAI_20._05.models;

Pessoa pessoa = new Pessoa();
Aluno aluno = new Aluno();
Professor professor = new Professor();
Diretor diretor = new Diretor();
Funcionario funcionario = new Funcionario();
Gerente gerente = new Gerente();
Desenvolvedor desenvolvedor = new Desenvolvedor();
Estagiario estagiario = new Estagiario();
ContaCorrente contaCorrente = new ContaCorrente();
ContaPoupanca contaPoupanca = new ContaPoupanca();
Guerreiro guerreiro = new Guerreiro();
Mago mago = new Mago();
Arqueiro arqueiro = new Arqueiro();

int opcao = -1;

while (opcao != 0)
{
    Console.WriteLine("===== MENU =====");
    Console.WriteLine("1 - Escola");
    Console.WriteLine("2 - Funcionários");
    Console.WriteLine("3 - Banco");
    Console.WriteLine("4 - Jogo");
    Console.WriteLine("5 - Delivery");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("1 - Pessoa");
            Console.WriteLine("2 - Aluno");
            Console.WriteLine("3 - Professor");
            Console.WriteLine("4 - Diretor");
            int op1 = int.Parse(Console.ReadLine());

            switch (op1)
            {
                case 1:

                    Console.Write("Nome: ");
                    pessoa.Nome = Console.ReadLine();

                    Console.Write("Idade: ");
                    pessoa.Idade = int.Parse(Console.ReadLine());

                    pessoa.Apresentar();
                    break;

                case 2:

                    Console.Write("Nome: ");
                    aluno.Nome = Console.ReadLine();

                    Console.Write("Idade: ");
                    aluno.Idade = int.Parse(Console.ReadLine());

                    Console.Write("Nota: ");
                    aluno.Nota = double.Parse(Console.ReadLine());

                    aluno.Apresentar();
                    break;

                case 3:

                    Console.Write("Nome: ");
                    professor.Nome = Console.ReadLine();

                    Console.Write("Idade: ");
                    professor.Idade = int.Parse(Console.ReadLine());

                    Console.Write("Salário: ");
                    professor.Salario = decimal.Parse(Console.ReadLine());

                    professor.Apresentar();
                    break;

                case 4:

                    Console.Write("Nome: ");
                    diretor.Nome = Console.ReadLine();

                    Console.Write("Idade: ");
                    diretor.Idade = int.Parse(Console.ReadLine());

                    Console.Write("Salário: ");
                    diretor.Salario = decimal.Parse(Console.ReadLine());

                    diretor.Apresentar();
                    break;
            }
            break;

        case 2:
            Console.WriteLine("1 - Funcionário");
            Console.WriteLine("2 - Gerente");
            Console.WriteLine("3 - Desenvolvedor");
            Console.WriteLine("4 - Estagiário");
            int op2 = int.Parse(Console.ReadLine());

            switch (op2)
            {
                case 1:

                    Console.Write("Nome: ");
                    funcionario.Nome = Console.ReadLine();

                    Console.Write("Salário: ");
                    funcionario.Salario = double.Parse(Console.ReadLine());

                    funcionario.ApresentarSalario();
                    break;

                case 2:

                    Console.Write("Nome: ");
                    gerente.Nome = Console.ReadLine();

                    Console.Write("Salário: ");
                    gerente.Salario = double.Parse(Console.ReadLine());

                    gerente.ApresentarSalario();
                    break;

                case 3:

                    Console.Write("Nome: ");
                    desenvolvedor.Nome = Console.ReadLine();

                    Console.Write("Salário: ");
                    desenvolvedor.Salario = double.Parse(Console.ReadLine());

                    desenvolvedor.ApresentarSalario();
                    break;

                case 4:

                    Console.Write("Nome: ");
                    estagiario.Nome = Console.ReadLine();

                    Console.Write("Salário: ");
                    estagiario.Salario = double.Parse(Console.ReadLine());

                    estagiario.ApresentarSalario();
                    break;
            }
            break;

        case 3:
            Console.WriteLine("1 - Conta Corrente");
            Console.WriteLine("2 - Conta Poupança");
            int op3 = int.Parse(Console.ReadLine());

            switch (op3)
            {
                case 1:


                    Console.Write("Número: ");
                    contaCorrente.Numero = int.Parse(Console.ReadLine());

                    Console.Write("Titular: ");
                    contaCorrente.Titular = Console.ReadLine();

                    Console.Write("Taxa de saque: ");
                    contaCorrente.TaxaSaque = double.Parse(Console.ReadLine());

                    Console.Write("Depósito: ");
                    double deposito = double.Parse(Console.ReadLine());
                    contaCorrente.Depositar(deposito);

                    Console.Write("Saque: ");
                    double saque = double.Parse(Console.ReadLine());
                    contaCorrente.Sacar(saque);

                    contaCorrente.MostrarDados();
                    break;

                case 2:


                    Console.Write("Número: ");
                    contaPoupanca.Numero = int.Parse(Console.ReadLine());

                    Console.Write("Titular: ");
                    contaPoupanca.Titular = Console.ReadLine();

                    Console.Write("Depósito: ");
                    double depositoP = double.Parse(Console.ReadLine());
                    contaPoupanca.Depositar(depositoP);

                    Console.Write("Rendimento mensal: ");
                    contaPoupanca.RendimentoMensal = double.Parse(Console.ReadLine());

                    contaPoupanca.AplicarRendimento();
                    contaPoupanca.MostrarDados();
                    break;
            }
            break;

        case 4:
            Console.WriteLine("1 - Guerreiro");
            Console.WriteLine("2 - Mago");
            Console.WriteLine("3 - Arqueiro");
            int op4 = int.Parse(Console.ReadLine());

            switch (op4)
            {
                case 1:


                    Console.Write("Nome: ");
                    guerreiro.Nome = Console.ReadLine();

                    Console.Write("Vida: ");
                    guerreiro.VidaPersonagem = int.Parse(Console.ReadLine());

                    Console.Write("Ataque: ");
                    guerreiro.Ataque = int.Parse(Console.ReadLine());

                    Console.Write("Espada: ");
                    guerreiro.Espada = Console.ReadLine();

                    guerreiro.MostrarDados();
                    break;

                case 2:


                    Console.Write("Nome: ");
                    mago.Nome = Console.ReadLine();

                    Console.Write("Vida: ");
                    mago.VidaPersonagem = int.Parse(Console.ReadLine());

                    Console.Write("Ataque: ");
                    mago.Ataque = int.Parse(Console.ReadLine());

                    Console.Write("Mana: ");
                    mago.Mana = int.Parse(Console.ReadLine());

                    mago.MostrarDados();
                    break;

                case 3:


                    Console.Write("Nome: ");
                    arqueiro.Nome = Console.ReadLine();

                    Console.Write("Vida: ");
                    arqueiro.VidaPersonagem = int.Parse(Console.ReadLine());

                    Console.Write("Ataque: ");
                    arqueiro.Ataque = int.Parse(Console.ReadLine());

                    Console.Write("Flechas: ");
                    arqueiro.Flechas = int.Parse(Console.ReadLine());

                    arqueiro.MostrarDados();
                    break;
            }
            break;

        case 5:
            Console.WriteLine("1 - Pedido Normal");
            Console.WriteLine("2 - Pedido Expresso");
            Console.WriteLine("3 - Pedido Internacional");
            int op5 = int.Parse(Console.ReadLine());

            Pedido pedido = null;

            switch (op5)
            {
                case 1:
                    pedido = new PedidoNormal();
                    break;

                case 2:
                    pedido = new PedidoExpresso();
                    break;

                case 3:
                    pedido = new PedidoInternacional();
                    break;
            }

            Console.Write("Valor total: ");
            pedido.ValorTotal = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do pedido: R$ " + pedido.ValorTotal);
            Console.WriteLine("Entrega: R$ " + pedido.CalcularEntrega());
            Console.WriteLine("Total final: R$ " + (pedido.ValorTotal + pedido.CalcularEntrega()));
            break;

        case 0:
            Console.WriteLine("Saindo...");
            break;
    }
}