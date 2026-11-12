Console.WriteLine("-- EXIBIÇÃO NÚMEROS FIBONACCI");
void imprimirVetor(int[] vetor1)
{
    for (int i = 0; i < vetor1.Length; i++)
    {
        Console.Write($"[{vetor1[i]}] ");
    }
}

Console.Write("Insira  quantidade de números da Sequencia de Fibonacci: ");
int[] vetor = new int[int.Parse(Console.ReadLine()!)];

int contador = 1;
int contadorVetor = 0;

int num1 = 0, num2 = 1, prox;

//LAÇO DE OUTPUT
while (contador <= vetor.Length)
{
    vetor[contadorVetor] = num2;
    contadorVetor++;

    Console.WriteLine("Posição: " + contador + " | Número: " + num2);
    prox = num1 + num2;
    num1 = num2;
    num2 = prox;
    contador++;

}

imprimirVetor(vetor);

Console.WriteLine("\n\n-- PROGRAMA FINALIZADO --");