using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEDRAPAPELTESOURA
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolhaPlayer, nomePlayer = "";
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {

                int pontuacaoPlayer = 0;
                int pontuacaCPU = 0;

                while (pontuacaoPlayer < 3 && pontuacaCPU < 3)
                {
                    Console.Write("Digite seu nome Jogador:    ");
                    nomePlayer = Console.ReadLine();
                    Console.Write("Escolha sua arma: PEDRA, PAPEL and TESOURA:    ");
                    escolhaPlayer = Console.ReadLine();
                    escolhaPlayer = escolhaPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            Console.WriteLine("Computador escolheu PEDRA");
                            if (escolhaPlayer == "PEDRA")
                            {
                                Console.WriteLine("Empate :/ !!\n\n");
                            }
                            else if (escolhaPlayer == "PAPEL")
                            {
                                Console.WriteLine("VOCÊ GANHOU!!\n\n");
                                pontuacaoPlayer++;
                            }
                            else if (escolhaPlayer == "TESOURA")
                            {
                                Console.WriteLine("CPU GANHOU!!\n\n");
                                pontuacaCPU++;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Computador escolheu PAPEL");
                            if (escolhaPlayer == "PAPEL")
                            {
                                Console.WriteLine("Empate!!\n\n");
                            }
                            else if (escolhaPlayer == "PEDRA")
                            {
                                Console.WriteLine("CPU GANHOU!!\n\n");
                                pontuacaCPU++;
                            }
                            else if (escolhaPlayer == "TESOURA")
                            {
                                Console.WriteLine("VOCÊ GANHOU!!\n\n");
                                pontuacaoPlayer++;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Computador escolheu TESOURA");
                            if (escolhaPlayer == "TESOURA")
                            {
                                Console.WriteLine("Empate!!\n\n");
                            }
                            else if (escolhaPlayer == "PEDRA")
                            {
                                Console.WriteLine("VOCÊ GANHOU!!\n\n");
                                pontuacaoPlayer++;
                            }
                            else if (escolhaPlayer == "PAPEL")
                            {
                                Console.WriteLine("CPU GANHOU!!\n\n");
                                pontuacaCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Entrada Inválida!");
                            break;
                    }

                    Console.WriteLine("\n\nPontuação:\t{0}:\t{1}\tCPU:\t{2}", nomePlayer, pontuacaoPlayer, pontuacaCPU);

                }

                if (pontuacaoPlayer == 3)
                {
                    Console.WriteLine(nomePlayer + "VENCEU!");
                }
                else if (pontuacaCPU == 3)
                {
                    Console.WriteLine("CPU VENCEU!");
                }
                else
                {
                    Console.WriteLine("EMPATE!");
                }

                Console.WriteLine("Deseja Iniciar um Novo Jogo?(s/n)");
                string loop = Console.ReadLine();
                if (loop == "s")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {
                    Console.WriteLine("Opção Inválida");
                }

            }
        }
    }
}