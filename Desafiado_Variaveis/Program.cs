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


//Exercicio 3
Console.WriteLine("Exercicio 3");
exercicio3();

void exercicio3()
{
    double totalVendido = 500000;
    double porcentagemComissao = 0.05;
    double comissaoRecebida = totalVendido * porcentagemComissao;

    Console.WriteLine($"O valor da comissao que o vendedor receberá é: R${comissaoRecebida}");
}


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



//Exercicio 10
Console.WriteLine("Exercicio 10");
Console.WriteLine("Os exercicios que não possuem entrada de dados pelo usuario são: 1, 2 e 3");
Console.WriteLine("Aqui abaixo estarão estes exercícios desenvolvidos dinamicamente:");

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

ex2Dinamic();

void ex2Dinamic()
{
    Console.WriteLine("Exercicio 2 dinâmico");

    Console.WriteLine("Entre com a cotação do euro: ");
    double cotacaoEuro = double.Parse(Console.ReadLine());
    Console.WriteLine("Entre com o valor em euro que deseja converter: ");
    double valorEuro = double.Parse(Console.ReadLine());
    double valorEuroReal = cotacaoEuro * valorEuro;
    Console.WriteLine($"O valor {valorEuro} EUR convertido para Real é: R${valorEuroReal}");
}


ex3Dinamic();

void ex3Dinamic()
{
    Console.WriteLine("Exercicio 3 dinâmico");

    Console.WriteLine("Entre com o total vendido pelo vendedor: ");
    double totalVendido = double.Parse(Console.ReadLine());
    double porcentagemComissao = 0.05;
    double comissaoRecebida = totalVendido * porcentagemComissao;

    Console.WriteLine($"O valor da comissao que o vendedor receberá é: R${comissaoRecebida}");
}