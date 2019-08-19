using System;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {

    static void Main(string[] args)
    {
        int controle = 1;
        int computados = 0;
        int[] votos = new int [23];
        
        Console.WriteLine("Enquete: Quem foi o melhor jogador?");
        while(controle != 0){
            Console.WriteLine("Número do Jogador (0 = fim) :");
            controle = Convert.ToInt32(Console.ReadLine());
            if(controle != 0){
                votos[controle] += 1;
                computados++;
            }
        }

        Console.WriteLine("Resultado da votação:");
        Console.WriteLine("----------------------------------:");
        Console.WriteLine("Foram computados "+ computados+ " Votos.");
        Console.WriteLine("Jogador        Votos               %");

        for(int item = 0; item < votos.Length ; item++){
          if(votos[item] != 0){
            Console.WriteLine("Jogador "+ item +"  Votos ["+votos[item]+"]        "+ ((votos[item]*100)/(computados))+" %");
          }
        }
        

    }
    }
}
