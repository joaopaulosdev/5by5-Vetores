Console.WriteLine("-- EXIBIÇÃO CARACTERE E VALOR ASCII --");
void imprimirVetor(string[] vetor1)
{
    for (int i = 0; i < vetor1.Length; i++)
    {
        Console.Write($"[{vetor1[i]}] ");
    }
}

string[] vetorCarac = new string[10];

Console.Write("Insira um caractere para cada uma das 10 posições! \n");

for(int i = 0; i < vetorCarac.Length; i++)
{
    Console.Write($"Posição: {i + 1}, caractere a inserir: ");
    vetorCarac[i] = Console.ReadLine()!;
}

string[] novoVetor = new string[(vetorCarac.Length)*2];
int posicao = 0;
for(int i = 0; i < vetorCarac.Length; i++)
{
    novoVetor[posicao] = vetorCarac[i];
    novoVetor[posicao + 1] = ((int)vetorCarac[i][0]).ToString();
    posicao += 2;

}

Console.WriteLine("PRIMEIRO VETOR:");
imprimirVetor(vetorCarac);

Console.WriteLine("\nSEGUNDO VETOR:");
imprimirVetor(novoVetor);

Console.WriteLine("\n\n-- PROGRAMA FINALIZADO --");