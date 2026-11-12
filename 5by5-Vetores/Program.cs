int[] numbers = new int[4];
int contador = 0;

void preencherVetor()
{
    do
    {
        Console.Write($"Informe um número desejado na posição {contador + 1}: ");
        numbers[contador] = int.Parse(Console.ReadLine());
        contador++;

    } while (contador < numbers.Length);
}

void imprimirVetor()
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"[{numbers[i]}]");
    }
}

preencherVetor();
imprimirVetor();

Console.WriteLine("\n-- Aplicação Encerrada --\n");