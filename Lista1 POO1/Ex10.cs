using System;

public class Ex10
{
    public static void Executar()
    {
        // Solicitar ao usuário para inserir o peso e a altura
        Console.Write("Digite o peso em kg: ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura em metros: ");
        double altura = double.Parse(Console.ReadLine());

        // Calcular o IMC
        double imc = peso / (altura * altura);

        // Determinar a condição de peso
        string condicao;

        if (imc < 18.5)
        {
            condicao = "Abaixo do peso";
        }
        else if (imc >= 18.5 && imc < 25)
        {
            condicao = "Peso normal";
        }
        else if (imc >= 25 && imc < 30)
        {
            condicao = "Acima do peso";
        }
        else
        {
            condicao = "Obeso";
        }

        // Exibir o resultado
        Console.WriteLine($"IMC: {imc:F2}");
        Console.WriteLine($"Condição: {condicao}");
    }
}
