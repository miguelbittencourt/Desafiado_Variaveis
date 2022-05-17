//Exercicio 10
Console.WriteLine("Exercicio 10");
//Os exercicios que não possuem entrada de dados pelo usuario são: 1, 2 e 3
//vou separar em tres projetos, ex1Dinamic, ex2Dinamic e ex3Dinamic

ex1Dinamic();

void ex1Dinamic()
{
    Console.WriteLine("Exercicio 1 dinâmico");

    float idadeMinima, idadeMaxima, idadeMedia;

    Console.WriteLine("Digite a idade mínima: ");
    idadeMinima = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite a idade máxima: ");
    idadeMaxima = float.Parse(Console.ReadLine());
    idadeMedia = (idadeMinima + idadeMaxima) / 2;

    Console.WriteLine($"A idade média dos alunos é: {idadeMedia}");
}