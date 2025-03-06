Console.Write("Digite sua altura (em metros): ");
double altura = double.Parse(Console.ReadLine());
Console.Write("Digite seu sexo (M para masculino / F para feminino): ");
char sexo = Char.ToUpper(Console.ReadLine()[0]);
double pesoIdeal = 0;
    if (sexo == 'M'){
            
            pesoIdeal = (72.7 * altura) - 58;
     }
    else if (sexo == 'F'){
            
            pesoIdeal = (62.1 * altura) - 44.7;
        }
    else{
            Console.WriteLine("Sexo inválido. Por favor, insira 'M' para masculino ou 'F' para feminino.");
            return;
        }
    Console.WriteLine($"O seu peso ideal é: {pesoIdeal:F2} kg");
    

