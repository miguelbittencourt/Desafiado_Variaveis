ex2Dinamic();

void ex2Dinamic()
{
    Console.WriteLine("Exercicio 2 dinâmico");

    Console.WriteLine("Entre com a cotação do euro: ");
    double cotacaoEuro = double.Parse(Console.ReadLine());
    Console.WriteLine("Entre com o valor em euro que deseja converter: ");
    double valorEuro = double.Parse(Console.ReadLine());
    double valorEuroReal = cotacaoEuro * valorEuro;
    Console.WriteLine($"O valor {valorEuro} EUR convertido para Real é: R${valorEuroReal}");
}