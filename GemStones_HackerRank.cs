using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
/*Juninho descobriu várias rochas. Cada rocha é composta por vários elementos, 
e cada elemento é representado por uma letra minúscula latina de 'a' a 'z'. Um elemento pode estar presente diversas vezes em uma rocha.
Um elemento é chamado de "elemento-gema" se ocorrer pelo menos uma vez em cada uma das rochas.
Dada a lista de rochas com suas composições,
 você tem que imprimir quantos tipos diferentes de elementos-gema Juninho tem.
*/

namespace GemStones
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            List<int[]> list = new List<int[]>();
            GetArrayOfLetters get = new GetArrayOfLetters();
            for (int i = 0; i < cases; i++)
            {
                string texto = Console.ReadLine();
                list.Add(get.GetLetters(texto));
            }
            int result = 0;
            for (int i = 0; i < list[0].Length; i++)
            {
                if (list.All(x => x[i] > 0))
                    result++;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    public class GetArrayOfLetters
    {
        public int[] GetLetters(string texto)
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            int[] letras = new int[26];
            texto.Select(x => x.ToString()).ToList().ForEach(x => letras[abc.IndexOf(x)]++);
            return letras;
        }
    }
}