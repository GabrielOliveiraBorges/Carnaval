Console.Write("Digite a venda média mensal: ");
int VendaMediaMensal = int.Parse(Console.ReadLine());

Console.Write("Digite o preço atual do produto (R$): ");
decimal PrecoAtual = decimal.Parse(Console.ReadLine());


decimal NovoPreco = PrecoAtual;


if (VendaMediaMensal < 500 && PrecoAtual < 30)
{
    
    NovoPreco = PrecoAtual * 1.10m;
    Console.WriteLine($"O preço do produto foi aumentado em 10%. Novo preço: R$ {NovoPreco:F2}");
}
else if (VendaMediaMensal >= 500 && PrecoAtual >= 30)
{
    
    NovoPreco = PrecoAtual * 0.80m;
    Console.WriteLine($"O preço do produto foi reduzido em 20%. Novo preço: R$ {NovoPreco:F2}");
}
else
{
    
    Console.WriteLine("Não houve alteração no preço do produto.");
}
    