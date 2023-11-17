using System;

public class Ex09
{
    public static void Executar()
    {
        // Solicitar ao usuário para inserir a altura
        Console.Write("Digite a altura em metros: ");
        double altura = double.Parse(Console.ReadLine());

        // Solicitar ao usuário para inserir o sexo
        Console.Write("Digite o sexo (M/F): ");
        char sexo = char.Parse(Console.ReadLine());

        // Calcular o peso ideal com base no sexo
        double pesoIdeal;

        if (sexo == 'M' || sexo == 'm')
        {
            // Fórmula para homens
            pesoIdeal = (72.7 * altura) - 58;
            Console.WriteLine($"Peso ideal para homens: {pesoIdeal} kg");
        }
        else if (sexo == 'F' || sexo == 'f')
        {
            // Fórmula para mulheres
            pesoIdeal = (62.1 * altura) - 44.7;
            Console.WriteLine($"Peso ideal para mulheres: {pesoIdeal} kg");
        }
        else
        {
            // Se o sexo não for válido, exibir uma mensagem de erro
            Console.WriteLine("Sexo inválido. Use M ou F.");
        }
    }
}
