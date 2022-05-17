//Exercicio 7
Console.WriteLine("Exercicio 7");
float somaNotas = 0;
exercicio7(somaNotas);

void exercicio7(float s_Notas)
{

    for (int i = 1; i <= 4; i++)
    {
        Console.WriteLine($"Escreva a Nota {i} do aluno: ");
        float _nota = float.Parse(Console.ReadLine());
        s_Notas += _nota;
    }

    float media = s_Notas / 4;
    Console.WriteLine($"A média do aluno é: {media}");
    if (media > 7)
        Console.WriteLine("Aluno Aprovado!");
    else Console.WriteLine("Aluno Reprovado!");

}