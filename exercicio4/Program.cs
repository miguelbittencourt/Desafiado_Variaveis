//Exercicio 4
Console.WriteLine("Exercicio 4");
exercicio4();

void exercicio4()
{
    float grauC, grauF;
    Console.WriteLine("Digite a temperatura em graus Celsius");
    grauC = float.Parse(Console.ReadLine());
    grauF = (9 * grauC + 160) / 5;
    Console.WriteLine($"A temperatura digitada em Grau Celsius convertida em Fahrenheit é: {grauF}");
}