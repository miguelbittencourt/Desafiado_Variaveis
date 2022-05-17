//Exercicio 6
Console.WriteLine("Exercicio 6");
exercicio6();

void exercicio6()
{
    double altura, pesoIdeal;
    Console.WriteLine("Digite sua altura: ");
    altura = double.Parse(Console.ReadLine());
    pesoIdeal = (72.7 * altura) - 58;
    Console.WriteLine($"Seu peso ideal é: {pesoIdeal}kg");
}