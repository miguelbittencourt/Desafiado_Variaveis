//Exercício 1

Console.WriteLine("Exercicio 1");
exercicio1();

void exercicio1()
{
    float idadeMinima, idadeMaxima, idadeMedia;

    idadeMinima = 20;
    idadeMaxima = 50;
    idadeMedia = (idadeMinima + idadeMaxima) / 2;

    Console.WriteLine($"A idade média dos alunos é: {idadeMedia}");
}