using ContaBancaria.Controller;

namespace ContaBancaria.Model;

class Program
{
    private static ConsoleKeyInfo consoleKeyInfo;
    
    static void Main(string[] args)
    {
        int opcao, agencia,numero, tipo, aniversario;
        string? titular;
        decimal saldo, limite;


        ContaController contas = new ContaController();
        
        ContaCorrente cc1 = new ContaCorrente(contas.GerarNumero() , 123, 1, "Samantha", 100000000.0M, 1000M);
        contas.Cadastrar(cc1);
    
        ContaPoupanca cp1 = new ContaPoupanca(contas.GerarNumero(), 123, 1, "Samantha", 100000000.0M, 01);
        contas.Cadastrar(cp1);
   
        
        while (true)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*****************************************************");
            Console.WriteLine("                                                     ");
            Console.WriteLine("                  BANK OF THE FUTURE                 ");
            Console.WriteLine("                                                     ");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("                                                     ");
            Console.WriteLine("            1 - Criar Conta                          ");
            Console.WriteLine("            2 - Listar todas as Contas               ");
            Console.WriteLine("            3 - Buscar Conta por Numero              ");
            Console.WriteLine("            4 - Atualizar Dados da Conta             ");
            Console.WriteLine("            5 - Apagar Conta                         ");
            Console.WriteLine("            6 - Sacar                                ");
            Console.WriteLine("            7 - Depositar                            ");
            Console.WriteLine("            8 - Transferir valores entre Contas      ");
            Console.WriteLine("            9 - Sair                                 ");
            Console.WriteLine("                                                     ");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Entre com a opção desejada:                          ");
            Console.WriteLine("                                                     ");
            Console.ResetColor();
            
            //Tratamento de execeção para impedir a digitação de strings no menu
            try
            {
            opcao = Convert.ToInt32(Console.ReadLine());

            }catch(FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite um valor inteiro entre 1 e 9!");
                opcao = 0;
                Console.ResetColor();
            }

                switch (opcao)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Criar Conta\n\n");
                        Console.ResetColor();

                        Console.Write("Digite o Número da Agência: ");
                        agencia = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o Nome do Titular: ");
                        titular = Console.ReadLine();

                        titular??= string.Empty;

                        do {
                        Console.Write("""

                            1 - Conta Corrente
                            2 - Conta Poupança

                            Digite o Tipo da Conta:

                        """);
                        tipo = Convert.ToInt32(Console.ReadLine());
                        }while(tipo != 1 && tipo !=2);

                        Console.Write("Digite o Saldo da Conta: ");
                        saldo = Convert.ToDecimal(Console.ReadLine());

                        switch(tipo)
                        {
                            case 1:
                                Console.Write("Digite o Limite da Conta: ");
                                limite = Convert.ToDecimal(Console.ReadLine());
                                contas.Cadastrar(new ContaCorrente(contas.GerarNumero(),agencia, tipo, titular, saldo, limite));
                                break;
                            case 2:
                                Console.Write("Digite o Aniversário da Conta: ");
                                aniversario = Convert.ToInt32(Console.ReadLine());
                                contas.Cadastrar(new ContaPoupanca(contas.GerarNumero(),agencia, tipo, titular, saldo, aniversario));
                                break;
                        }
                       
                        KeyPress();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Listar todas as Contas\n\n");
                        Console.ResetColor();
                        contas.ListarTodas();
                        KeyPress();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Consultar dados da Conta - por número\n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número da conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                        contas.ProcurarPorNumero(numero);

                        KeyPress();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Atualizar dados da Conta\n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o numero da conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        var conta = contas.BuscarNaCollection(numero);

                        if(conta is not null)
                        {

                            Console.Write("Digite o Número da Agência: ");
                            agencia = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Digite o Nome do Titular: ");
                            titular = Console.ReadLine();

                            titular??= string.Empty;

                            Console.Write("Digite o Saldo da Conta: ");
                            saldo = Convert.ToDecimal(Console.ReadLine());

                            tipo = conta.GetTipo();

                            switch(tipo)
                            {
                                case 1:
                                    Console.Write("Digite o Limite da Conta: ");
                                    limite = Convert.ToDecimal(Console.ReadLine());

                                    contas.Atualizar(new ContaCorrente(numero ,agencia, tipo, titular, saldo, limite));
                                    break;
                                case 2:
                                    Console.Write("Digite o Aniversário da Conta: ");
                                    aniversario = Convert.ToInt32(Console.ReadLine());

                                    contas.Atualizar(new ContaPoupanca(numero ,agencia, tipo, titular, saldo, aniversario));
                                    break;
                            }

                        }
                        else{
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"A conta n° {numero} não foi encontrada !");
                            Console.ResetColor();
                        }

                        KeyPress();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Apagar a Conta\n\n");
                        Console.ResetColor();
                        
                        Console.WriteLine("Digite o numero da conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                        contas.Deletar(numero);

                        KeyPress();
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Saque\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Depósito\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 8:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Transferência entre Contas\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 9:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nBank of the future - O seu Futuro começa aqui!");
                        Sobre();
                        Console.ResetColor();
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpção Inválida!\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                }

        }

         static void Sobre()
        {
            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("Projeto Desenvolvido por: Eduardo Serodio Souto");
            Console.WriteLine("Email - eduardo.serodio@outlook.com");
            Console.WriteLine("https://github.com/EduSerodio/ContaBancaria");
            Console.WriteLine("*********************************************************");

        }

        static void KeyPress()
        {
            do
            {
                Console.Write("\nPressione Enter para Continuar...");
                consoleKeyInfo = Console.ReadKey();
            } while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }

    }
}