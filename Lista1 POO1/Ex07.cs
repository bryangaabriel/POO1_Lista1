using System;

public class Ex07
{
    public static void Executar()
    {
        // Solicitar ao usuário para inserir um número
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        // Verificar se o número é par ou ímpar
        if (numero % 2 == 0)
        {
            // Se for par, somar 5
            numero += 5;
            Console.WriteLine($"O número é par. Resultado: {numero}");
        }
        else
        {
            // Se for ímpar, somar 8
            numero += 8;
            Console.WriteLine($"O número é ímpar. Resultado: {numero}");
        }
    }
}
