//Exercicio 3
Console.WriteLine("Exercicio 3");
exercicio3();

void exercicio3()
{
    double totalVendido = 500000;
    double porcentagemComissao = 0.05;
    double comissaoRecebida = totalVendido * porcentagemComissao;

    Console.WriteLine($"O valor da comissao que o vendedor receberá é: R${comissaoRecebida}");
}
