using System;

class Program {
  public static void Main (string[] args) {
    
    string Nome = "YASMIN";
    int IdadeYasmin = 18;

    Console.WriteLine ("Digite sua idade para calcular a diferença de idades");
    int idadeColeguinha =  int.Parse(Console.ReadLine());

    if (idadeColeguinha>IdadeYasmin){ 
    Console.WriteLine ($"{Nome} tem {idadeColeguinha- IdadeYasmin} anos de diferença a menos de tu");
    }

    else{
    Console.WriteLine ($"{Nome} tem {IdadeYasmin - idadeColeguinha} anos de diferença a mais de tu");
    }
    
  }
}