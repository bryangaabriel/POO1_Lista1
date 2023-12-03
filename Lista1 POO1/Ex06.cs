using System;

public class Ex06
{
    public static void Executar()
    {
        // Solicitar ao usuário para inserir dois valores booleanos
        Console.Write("Digite o primeiro valor booleano (true/false): ");
        bool valor1 = bool.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor booleano (true/false): ");
        bool valor2 = bool.Parse(Console.ReadLine());

        // Verificar se ambos os valores são VERDADEIROS
        if (valor1 && valor2)
        {
            Console.WriteLine("Ambos os valores são VERDADEIROS.");
        }
        else
        {
            Console.WriteLine("Pelo menos um dos valores não é VERDADEIRO.");
        }
    }
}
