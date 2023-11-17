using System;

public class Ex12
{
    public static void Executar()
    {
        // Solicitar ao usuário para inserir o número de identificação do aluno
        Console.Write("Digite o número de identificação do aluno: ");
        int numeroAluno = int.Parse(Console.ReadLine());

        // Solicitar ao usuário para inserir as três notas do aluno
        Console.Write("Digite a nota 1: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        double nota3 = double.Parse(Console.ReadLine());

        // Solicitar ao usuário para inserir a média dos exercícios
        Console.Write("Digite a média dos exercícios: ");
        double mediaExercicios = double.Parse(Console.ReadLine());

        // Calcular a média de aproveitamento
        double mediaAproveitamento = (nota1 + nota2 * 2 + nota3 * 3 + mediaExercicios) / 7;

        // Determinar o conceito
        char conceito;

        if (mediaAproveitamento >= 90)
        {
            conceito = 'A';
        }
        else if (mediaAproveitamento >= 75)
        {
            conceito = 'B';
        }
        else if (mediaAproveitamento >= 60)
        {
            conceito = 'C';
        }
        else if (mediaAproveitamento >= 40)
        {
            conceito = 'D';
        }
        else
        {
            conceito = 'E';
        }

        // Exibir os resultados
        Console.WriteLine($"Número do aluno: {numeroAluno}");
        Console.WriteLine($"Notas: {nota1}, {nota2}, {nota3}");
        Console.WriteLine($"Média dos exercícios: {mediaExercicios}");
        Console.WriteLine($"Média de aproveitamento: {mediaAproveitamento:F2}");
        Console.WriteLine($"Conceito: {conceito}");

        // Verificar se o aluno está aprovado ou reprovado
        if (conceito == 'A' || conceito == 'B' || conceito == 'C')
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}
