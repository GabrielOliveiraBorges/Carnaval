
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Digite Vertebrado  ou Invertebrado:");
    string p1 = Console.ReadLine();
    
    string Palavra1 = p1.ToUpper();
    
    if(Palavra1 != "VERTEBRADO"){
        if(Palavra1 != "INVERTEBRADO"){
            Console.WriteLine("Error!");
        }
    }
    Console.WriteLine("Digite Ave, Mamifero, Inseto ou Anelideo:");
    string p2 = Console.ReadLine();
    
    string Palavra2 = p2.ToUpper();
    
    if(Palavra2 != "AVE"){
        if(Palavra2 != "MAMIFERO"){
            if(Palavra2 != "INSETO"){
                if(Palavra2 != "ANELIDEO"){
                    Console.WriteLine("ERROR");
                }
            }
        }
    }
    Console.WriteLine("Digite Carnivoro, onivoro, herbivoro, hematofago ou  herbivoro");
    string p3 = Console.ReadLine();
    
    string Palavra3 = p3.ToUpper();
    
    
    if(Palavra3 != "CARNIVORO"){
        if(Palavra3 != "ONIVORO"){
            if(Palavra3 != "HEMATOFAGO"){
                if(Palavra3 != "HERBIVORO"){
                    Console.WriteLine("Error!");
                }
            }
        }
    }
    
    if(Palavra1 == "VERTEBRADO" && Palavra2 == "AVE" && Palavra3 == "CARNIVORO"){
        Console.WriteLine($"Seu animal é uma AGUIA!");
    }
    if(Palavra1 == "VERTEBRADO" && Palavra2 == "AVE" && Palavra3 == "ONIVORO"){
        Console.WriteLine($"Seu animal é uma POMBA!");
    }
    if(Palavra1 == "VERTEBRADO" && Palavra2 == "MAMIFERO" && Palavra3 == "ONIVORO"){
        Console.WriteLine($"Seu animal é um HOMEM!");
    }
    if(Palavra1 == "VERTEBRADO" && Palavra2 == "MAMIFERO" && Palavra3 == "HERBIVORO"){
        Console.WriteLine($"Seu animal é uma VACA!");
    }
    if(Palavra1 == "INVERTEBRADO" && Palavra2 == "INSETO" && Palavra3 == "HEMATOFAGO"){
        Console.WriteLine($"Seu animal é uma PULGA!");
    }
    if(Palavra1 == "INVERTEBRADO" && Palavra2 == "INSETO" && Palavra3 == "HERBIVORO"){
        Console.WriteLine($"Seu animal é uma LARGATA!");
    }
    if(Palavra1 == "INVERTEBRADO" && Palavra2 == "ANELIDEO" && Palavra3 == "HEMATOFAGO"){
        Console.WriteLine($"Seu animal é uma SANGUESSUGA!");
    }
    if(Palavra1 == "INVERTEBRADO" && Palavra2 == "ANELIDEO" && Palavra3 == "ONIVORO"){
        Console.WriteLine($"Seu animal é uma MINHOCA!");
    }
    
    
    
   
  }
}