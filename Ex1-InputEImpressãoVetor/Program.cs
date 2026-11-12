Console.WriteLine("-- INPUT E IMPRESSÃO VETOR --\n");

int qtdPosicoes;
int[] vetor = new int[6];

void imprimirCrescente()
{
    for (int i = 0; i < qtdPosicoes; i++)
    {
        Console.Write($"[{vetor[i]}] ");
    }
}

void imprimirDecrescente()
{
    for (int j = (qtdPosicoes - 1); j >= 0; j--)
    {
        Console.Write($"[{vetor[j]}] ");
    }
}

Console.Write("Insira a quantidade desejada de inserções no vetor: ");
qtdPosicoes = int.Parse(Console.ReadLine());

for (int i = 0; i < qtdPosicoes; i++)
{
    Console.Write($"Insira o número da posição {i + 1}: ");
    vetor[i] = int.Parse(Console.ReadLine());
}


//IMPRESSÃO CRESCENTE
imprimirCrescente();

Console.WriteLine("\n");

//IMPRESSÃO DECRESCENTE
imprimirDecrescente();


Console.WriteLine("\n-- PROGRAMA FINALIZADO --");