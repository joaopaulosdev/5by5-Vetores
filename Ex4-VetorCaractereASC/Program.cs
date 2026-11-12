Console.WriteLine("-- EXIBIÇÃO CARACTERE E VALOR ASCII --");
void ImprimirVetor(string[] vetor1)
{
    for (int i = 0; i < vetor1.Length; i++)
    {
        Console.Write($"[{vetor1[i]}] ");
    }
}
void PreencherVetor(string[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.Write($"Posição: {i + 1}, caractere a inserir: ");
        vetor[i] = Console.ReadLine()!;
    }
}
void CriarVetorASCII(string[] vetorOrigem, string[] vetorASCII)
{
    int posicao = 0;
    for (int i = 0; i < vetorOrigem.Length; i++)
    {
        vetorASCII[posicao] = vetorOrigem[i];
        vetorASCII[posicao + 1] = ((int)vetorOrigem[i][0]).ToString();
        posicao += 2;

    }
}

string[] vetorCarac = new string[10];

Console.WriteLine("Você tem um vetor de 10 posições!\n");
Console.Write("Insira um caractere para cada posição. \n");

PreencherVetor(vetorCarac);

string[] novoVetor = new string[(vetorCarac.Length) * 2];

CriarVetorASCII(vetorCarac, novoVetor);

Console.WriteLine("PRIMEIRO VETOR:");
ImprimirVetor(vetorCarac);

Console.WriteLine("\nSEGUNDO VETOR:");
ImprimirVetor(novoVetor);

Console.WriteLine("\n\n-- PROGRAMA FINALIZADO --");