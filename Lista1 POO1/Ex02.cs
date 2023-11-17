using System;

public class Ex02
{
    public static void Executar()
    {
        // Solicitar ao usuário para inserir o nome
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        // Solicitar ao usuário para inserir o sexo
        Console.Write("Digite o sexo (M/F): ");
        char sexo = char.Parse(Console.ReadLine());

        // Solicitar ao usuário para inserir o estado civil
        Console.Write("Digite o estado civil: ");
        string estadoCivil = Console.ReadLine();

        // Verificar se o sexo é "F" e o estado civil é "CASADA"
        if (sexo == 'F' && estadoCivil.ToUpper() == "CASADA")
        {
            // Se sim, solicitar o tempo de casada
            Console.Write("Digite o tempo de casada (em anos): ");
            int tempoCasada = int.Parse(Console.ReadLine());

            // Exibir as informações
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"Estado Civil: {estadoCivil}");
            Console.WriteLine($"Tempo de Casada: {tempoCasada} anos");
        }
        else
        {
            // Se não, exibir as informações sem o tempo de casada
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"Estado Civil: {estadoCivil}");
        }
    }
}
