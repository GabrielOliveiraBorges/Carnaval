double[] notas = new double[6];

Console.WriteLine("Digite as 6 notas dos juízes (de 0 a 10):");
for (int i = 0; i < notas.Length; i++)
{
    Console.Write($"Nota do juiz {i + 1}: ");
    notas[i] = double.Parse(Console.ReadLine());
}


double maiorNota = notas[0];
double menorNota = notas[0];

for (int i = 1; i < notas.Length; i++)
{
    if (notas[i] > maiorNota)
        maiorNota = notas[i];
    if (notas[i] < menorNota)
        menorNota = notas[i];
}


double somaNotas = 0;
for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] != maiorNota && notas[i] != menorNota)
    {
        somaNotas += notas[i];
    }
}


Console.WriteLine($"\nNota final do atleta (soma das notas excluindo a maior e a menor): {somaNotas}");

