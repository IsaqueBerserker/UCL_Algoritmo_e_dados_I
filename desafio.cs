using System; 
using System.Collections.Generic; 
  
class desafio 
{ 
      
static int MAX = 1000;  //colocar um valor maximo aqui
  
static List<int> primos = new List<int>(); 
  

static void peneiraSundaram() 
{ 
    
    Boolean[] captura = new Boolean[MAX / 2 + 100]; 
  
    //registrar todos numeros que nao geram numero primo fazendo assim : 2*i+1 
    for (int i = 1; i <= (Math.Sqrt(MAX) - 1) / 2; i++) 
        for (int j = (i * (i + 1)) << 1; j <= MAX / 2; j = j + 2 * i + 1) 
            captura[j] = true; 
  
    // como 2 é um numero primo 
    primos.Add(2); 
   
    for (int i = 1; i <= MAX / 2; i++) 
        if (captura[i] == false) 
            primos.Add(2 * i + 1); 
} 
  
// funcao para achar os primos
static void acharPrimos(int n) 
{ 
    //1# condição:  se o numero n é par or menor q 3 
    if (n <= 2 || n % 2 != 0) 
    { 
        Console.WriteLine("Proibido fazer isso mané! "); 
        return; 
    } 
  
    
    for (int i = 0 ; primos[i] <= n / 2; i++) 
    { 
        // Achar a diferenca 
        int diferenca = n - primos[i]; 
  
        //se a diferença tbm é um numero primo
        if (primos.Contains(diferenca)) 
        { 
            // mostrar a soma
            Console.WriteLine(primos[i] + " + " + diferenca + " = " + n); 
            return; 
        } 
    } 
} 
  

public static void Main (String[] args)  
{ 
     
    peneiraSundaram(); 
  
    //testando
    acharPrimos(4); 
    acharPrimos(38); 
    acharPrimos(100); 
} 
} 
  