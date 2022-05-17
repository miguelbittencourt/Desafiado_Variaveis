//Exercicio 8
Console.WriteLine("Exercicio 8");
exercicio8();

void exercicio8()
{
    float valorA, valorB, totalSub;
    Console.WriteLine("Digite o valor A: ");
    valorA = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor B: ");
    valorB = float.Parse(Console.ReadLine());

    totalSub = valorA - valorB;
    Console.WriteLine($"O valor total da subtração é: {totalSub}");

    if (totalSub >= 0)
        Console.WriteLine("Valor Positivo!");
    else Console.WriteLine("Valor Negativo!");
}