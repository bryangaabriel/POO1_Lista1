using System;

class Menu
{
    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("Escolha um exercício (1 a 12) para executar ou 0 para sair:");
            Console.Write("Opção: ");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindo do programa. Até mais!");
                        break;
                    case 1:
                        Ex01.Executar();
                        break;
                    case 2:
                        Ex02.Executar();
                        break;
                    case 3:
                        Ex03.Executar();
                        break;
                    case 4:
                        Ex04.Executar();
                        break;
                    case 5:
                        Ex05.Executar();
                        break;
                    case 6:
                        Ex06.Executar();
                        break;
                    case 7:
                        Ex07.Executar();
                        break;
                    case 8:
                        Ex08.Executar();
                        break;
                    case 9:
                        Ex09.Executar();
                        break;
                    case 10:
                        Ex10.Executar();
                        break;
                    case 11:
                        Ex11.Executar();
                        break;
                    case 12:
                        Ex12.Executar();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }

            Console.WriteLine();
        } while (opcao != 0);
    }
}
