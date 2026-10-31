
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual o percentual da sua nota? ");
        string valorDigitado = Console.ReadLine();

        double nota = Convert.ToDouble(valorDigitado);
        string letra;

        if (nota >= 90)
        {
            letra = "A";
        }
        else if (nota >= 80)
        {
            letra = "B";
        }
        else if (nota >= 70)
        {
            letra = "C";
        }
        else if (nota >= 60)
        {
            letra = "D";
        }
        else
        {
            letra = "F";
        }

        Console.WriteLine($"Sua nota conceitual é: {letra}");

        if (nota >= 70)
        {
            Console.WriteLine("Parabéns! Você foi aprovado!");
        }
        else
        {
            Console.WriteLine("Continue estudando! Tente novamente.");
        }
    }
}
