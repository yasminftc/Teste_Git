using System;
class Program {
  public static void Main (string[] args) {
    
    string Nome = "YASMIN";
    string Nome2 = "Fellipe";
    int IdadeYasmin = 18;
    int idadeFellipe = 17;

    if (idadeFellipe>IdadeYasmin){ 
    Console.WriteLine ($"{Nome} tem {idadeFellipe- IdadeYasmin} anos de diferença a menos de tu");
    }

    else{
    Console.WriteLine ($"{Nome} tem {IdadeYasmin - idadeFellipe} anos a mais de tu");
    }
    
  }
}
