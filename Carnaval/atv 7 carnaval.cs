int[] gabarito = new int[5]; 
int[] aposta = new int[10];   
int pontos = 0;               


Console.WriteLine("Digite o gabarito da LOTO (5 números):");
for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o {i + 1}º número do gabarito: ");
    gabarito[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nDigite a sua aposta (10 números):");
for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite o {i + 1}º número da aposta: ");
    aposta[i] = int.Parse(Console.ReadLine());
}


for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (aposta[i] == gabarito[j])
        {
            pontos++;
            break; 
        }
    }
}


Console.WriteLine($"\nVocê acertou {pontos} ponto(s).");


