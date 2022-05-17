ex3Dinamic();

void ex3Dinamic()
{
    Console.WriteLine("Exercicio 3 dinâmico");

    Console.WriteLine("Entre com o total vendido pelo vendedor: ");
    double totalVendido = double.Parse(Console.ReadLine());
    double porcentagemComissao = 0.05;
    double comissaoRecebida = totalVendido * porcentagemComissao;

    Console.WriteLine($"O valor da comissao que o vendedor receberá é: R${comissaoRecebida}");
}