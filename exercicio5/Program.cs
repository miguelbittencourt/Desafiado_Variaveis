//Exercicio 5
Console.WriteLine("Exercicio 5");
exercicio5();

void exercicio5()
{
    float grauC, grauF;
    Console.WriteLine("Digite a temperatura em graus Fahrenheit");
    grauF = float.Parse(Console.ReadLine());
    grauC = (grauF - 32) * 5 / 9;
    Console.WriteLine($"A temperatura digitada em Grau Fahrenheit convertida em Celsius é: {grauC}");
}