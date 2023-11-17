using System;

public class Ex05
{
    public static void Executar()
    {
        // Solicitar ao usuário para inserir um número
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        int resultado;

        // Verificar se o número é positivo ou negativo
        if (numero > 0)
        {
            // Se for positivo, calcular o dobro
            resultado = numero * 2;
            Console.WriteLine($"O dobro de {numero} é {resultado}.");
        }
        else if (numero < 0)
        {
            // Se for negativo, calcular o triplo
            resultado = numero * 3;
            Console.WriteLine($"O triplo de {numero} é {resultado}.");
        }
        else
        {
            // Se for zero, exibir uma mensagem indicando que é zero
            Console.WriteLine("O número é zero.");
        }
    }
}
