using System;

public class Ex08
{
    public static void Executar()
    {
        // Solicitar ao usuário para inserir três valores inteiros diferentes
        Console.Write("Digite o primeiro valor: ");
        int valor1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        int valor2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro valor: ");
        int valor3 = int.Parse(Console.ReadLine());

        // Encontrar o maior valor
        int maior = Math.Max(Math.Max(valor1, valor2), valor3);

        // Encontrar o menor valor
        int menor = Math.Min(Math.Min(valor1, valor2), valor3);

        // Encontrar o valor do meio
        int meio = (valor1 + valor2 + valor3) - (maior + menor);

        // Mostrar os valores em ordem decrescente
        Console.WriteLine($"Valores em ordem decrescente: {maior}, {meio}, {menor}");
    }
}
