using System;

public class Ex03
{
    public static void Executar()
    {
        // Solicitar ao usuário para inserir um número
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        // Verificar se o número é par ou ímpar
        if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} é um número par.");
        }
        else
        {
            Console.WriteLine($"{numero} é um número ímpar.");
        }
    }
}
