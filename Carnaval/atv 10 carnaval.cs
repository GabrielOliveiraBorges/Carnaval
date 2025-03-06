int[,] A = new int[4, 4];
Console.WriteLine("Digite os 16 elementos da matriz 4x4:");

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"Elemento [{i + 1},{j + 1}]: ");
        A[i, j] = int.Parse(Console.ReadLine());
    }
}


int somaHachurada = 0;

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        
        if (i != j)
        {
            somaHachurada += A[i, j];
        }
    }
}


Console.WriteLine($"\nSoma das partes hachuradas (fora da diagonal principal): {somaHachurada}");


