//Exercício 2
Console.WriteLine("Exercicio 2");
exercicio2();

void exercicio2()
{
    Console.WriteLine("Entre com a cotação do euro: ");
    double cotacaoEuro = double.Parse(Console.ReadLine());
    double valorEuro = 750.0;
    double valorEuroReal = cotacaoEuro * valorEuro;
    Console.WriteLine($"O valor de 750 EUR em Real é: R${valorEuroReal}");
}