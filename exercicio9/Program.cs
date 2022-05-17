//Exercicio 9
Console.WriteLine("Exercicio 9");
exercicio9();

void exercicio9()
{
    float valorA, valorB, totalDiv, resto;
    Console.WriteLine("Digite o valor A: ");
    valorA = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor B: ");
    valorB = float.Parse(Console.ReadLine());

    totalDiv = valorA / valorB;
    resto = valorA % valorB;

    Console.WriteLine($"O valor da divisão é: {totalDiv}");

    if (resto == 0)
        Console.WriteLine("O resto da divisão é 0!");
    else Console.WriteLine("O resto da divisão não é 0!");

}