

//Exercício 1
float idadeMinima, idadeMaxima, idadeMedia;

idadeMinima = 20;
idadeMaxima = 50;
idadeMedia = (idadeMinima + idadeMaxima) / 2;

Console.WriteLine($"A idade média dos alunos é: {idadeMedia}");

//Exercício 2
Console.WriteLine("Entre com a cotação do euro: ");
double cotacaoEuro = double.Parse(Console.ReadLine());
Console.WriteLine("Entre com o valor que deseja converter de Euro para Real: ");
double valorEuro = double.Parse(s: Console.ReadLine());
double valorEuroReal = cotacaoEuro * valorEuro;
Console.WriteLine($"O valor em Real é: {valorEuroReal}");