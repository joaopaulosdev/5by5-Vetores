Console.WriteLine("-- PROGRAMA DOS 4 VETORES --\n");

int[] vetor = new int[5];
int contaImpar = 0, contaPar = 0;

void imprimirVetor(int[] vetor1)
{
    for (int i = 0; i < vetor1.Length; i++)
    {
        Console.Write($"[{vetor1[i]}] ");
    }
}

for (int i = 0; i < 5; i++)
{
    Console.Write($"Insira o número da posição {i + 1}: ");
    vetor[i] = int.Parse(Console.ReadLine());
    if (vetor[i] % 2 == 0)
    {
        contaPar++;
    }
    else
    {
        contaImpar++;
    }
}
imprimirVetor(vetor);

//IMPRESSÃO VETOR INVERSO
Console.WriteLine("\nImpressão Vetor Inverso:");
int[] vetorInverso = new int[vetor.Length];
int posicao = 0;
for (int i = (vetorInverso.Length - 1); i >= 0; i--)
{    
    vetorInverso[posicao] = vetor[i];
    posicao++;
}
imprimirVetor(vetorInverso);

//CRIAÇÃO, PREENCHIMENTO E EXIBIÇÃO VETORIMPAR
Console.WriteLine("\nImpressão Vetor Ímpar: \n");
int[] vetorImpar = new int[contaImpar];
int contadorOrigem = 0, contador = 0;

while(contador < contaImpar)
{
    
    if (vetor[contadorOrigem] % 2  != 0)
    {
        vetorImpar[contador] = vetor[contadorOrigem];
        contador++;
        contadorOrigem++;
    }
    else
    {
        contadorOrigem++;
    }
}
imprimirVetor(vetorImpar);


//CRIAÇÃO, PREENCHIMENTO E EXIBIÇÃO VETORPAR
Console.WriteLine("\nImpressão Vetor Par: \n");
int[] vetorPar = new int[contaPar];
contadorOrigem = 0;
contador = 0;
while (contador < contaPar)
{
        if (vetor[contadorOrigem] % 2 == 0)
    {
        vetorPar[contador] = vetor[contadorOrigem];
        contador++;
        contadorOrigem++;
    }
    else
    {
        contadorOrigem++;
    }
}
imprimirVetor(vetorPar);

Console.WriteLine("\n\n-- PROGRAMA FINALIZADO --");