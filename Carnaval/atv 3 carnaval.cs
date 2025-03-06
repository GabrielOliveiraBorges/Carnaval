Console.Write("Digite o número de horas trabalhadas no mês: ");
        int horasTrabalhadasPorMes = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor do salário por hora (R$): ");
        decimal salarioPorHora = decimal.Parse(Console.ReadLine());

        
        int horasNormaisPorSemana = 40;
        int semanasPorMes = 4;
        int horasNormaisPorMes = horasNormaisPorSemana * semanasPorMes;

        
        decimal salarioNormal = horasNormaisPorMes * salarioPorHora;

        /
        decimal salarioTotal;
        if (horasTrabalhadasPorMes > horasNormaisPorMes)
        {
            
            int horasExtras = horasTrabalhadasPorMes - horasNormaisPorMes;
            decimal valorHoraExtra = salarioPorHora * 1.50m; 
            decimal salarioExtras = horasExtras * valorHoraExtra;

            
            salarioTotal = salarioNormal + salarioExtras;
        }
        else
        {
           
            salarioTotal = horasTrabalhadasPorMes * salarioPorHora;
        }

        
        Console.WriteLine($"O salário total do funcionário é: R$ {salarioTotal:F2}");




