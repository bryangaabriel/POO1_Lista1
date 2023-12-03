using System;

public class Ex11
{
    public static void Executar()
    {
        // Solicitar ao usuário para inserir o preço do produto
        Console.Write("Digite o preço do produto: ");
        double preco = double.Parse(Console.ReadLine());

        // Solicitar ao usuário para inserir o código da condição de pagamento
        Console.Write("Digite o código da condição de pagamento: ");
        int codigoCondicao = int.Parse(Console.ReadLine());

        // Calcular o valor a ser pago com base na condição de pagamento
        double valorPago;

        switch (codigoCondicao)
        {
            case 1:
                // À vista em dinheiro ou cheque, recebe 10% de desconto
                valorPago = preco - (preco * 0.10);
                break;
            case 2:
                // À vista no cartão de crédito, recebe 15% de desconto
                valorPago = preco - (preco * 0.15);
                break;
            case 3:
                // Em duas vezes, preço normal de etiqueta sem juros
                valorPago = preco;
                break;
            case 4:
                // Em duas vezes, preço normal de etiqueta mais juros de 10%
                valorPago = preco * 1.10;
                break;
            default:
                // Condição de pagamento inválida
                Console.WriteLine("Código de condição de pagamento inválido.");
                return;
        }

        // Exibir o resultado
        Console.WriteLine($"Valor a ser pago: {valorPago:C}");
    }
}
