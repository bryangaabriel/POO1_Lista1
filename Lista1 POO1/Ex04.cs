using System;

public class Ex04
{
    public static void Executar()
    {
        // Solicitar ao usuário para inserir dois valores inteiros, A e B
        Console.Write("Digite o valor de A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        int b = int.Parse(Console.ReadLine());

        int c; // Variável para armazenar o resultado

        // Verificar se os valores de A e B são iguais
        if (a == b)
        {
            // Se forem iguais, somar os dois valores
            c = a + b;
            Console.WriteLine($"Os valores são iguais. A + B = {c}");
        }
        else
        {
            // Se não forem iguais, multiplicar A por B
            c = a * b;
            Console.WriteLine($"Os valores são diferentes. A * B = {c}");
        }
    }
}
