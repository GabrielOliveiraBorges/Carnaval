int[] D = new int[20];


Console.WriteLine("Digite 20 elementos para o vetor D:");
for (int i = 0; i < D.Length; i++)
{
    Console.Write($"Elemento {i + 1}: ");
    D[i] = int.Parse(Console.ReadLine());
}


Console.Write("Digite o valor de N: ");
int N = int.Parse(Console.ReadLine());


Console.WriteLine("\nVetor compactado (elementos maiores que N):");
foreach (int valor in D)
{
    if (valor > N)
    {
        Console.Write(valor + " ");
    }
}


