using System;


    public class Ex01
    {
        public static void Executar()
        {
        // Solicitar ao usuário para inserir os valores de A, B e C
        Console.Write("Digite o valor de A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de C: ");
        int c = int.Parse(Console.ReadLine());

        // Verificar se a soma de A e B é menor que C
        if (a + b < c)
        {
            Console.WriteLine("A soma de A e B é menor que C.");
        }
        else
        {
            Console.WriteLine("A soma de A e B não é menor que C.");
        }
    }
}
