﻿namespace ContaBancaria.Model;

class Program
{
    private static ConsoleKeyInfo consoleKeyInfo;
    
    static void Main(string[] args)
    {
        int opcao;
        Conta c1 = new Conta(1, 12, 1, "Gaspar", 1000000.0M);

        c1.Visualizar();
        c1.SetNumero(345);
        c1.Visualizar();

        c1.Sacar(1000);
        c1.Visualizar();

        c1.Depositar(5000);
        c1.Visualizar();
        
        
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

            opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Criar Conta\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Listar todas as Contas\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Consultar dados da Conta - por número\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Atualizar dados da Conta\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Apagar a Conta\n\n");
                        Console.ResetColor();

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
                        Console.WriteLine("\nBanco do Brazil com Z - O seu Futuro começa aqui!");
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