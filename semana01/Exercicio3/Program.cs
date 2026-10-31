
using System;

class Program
{
    static void Main(string[] args)
    {
        string jogarNovamente = "sim";

        while (jogarNovamente == "sim")
        {
            Random random = new Random();
            int numeroMagico = random.Next(1, 101);

            int palpite = 0;
            int tentativas = 0;

            while (palpite != numeroMagico)
            {
                Console.Write("Qual é o seu palpite? ");
                palpite = int.Parse(Console.ReadLine()!);

                tentativas++;

                if (palpite < numeroMagico)
                {
                    Console.WriteLine("Mais alto");
                }
                else if (palpite > numeroMagico)
                {
                    Console.WriteLine("Mais baixo");
                }
                else
                {
                    Console.WriteLine("Você adivinhou!");
                }
            }

            Console.WriteLine($"Você acertou em {tentativas} tentativas!");

            Console.Write("Deseja jogar novamente? (sim/não): ");
            jogarNovamente = Console.ReadLine()!.Trim().ToLower();
        }

        Console.WriteLine("Obrigado por jogar!");
    }
}
