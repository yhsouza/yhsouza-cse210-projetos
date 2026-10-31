
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

        while (true)
        {
            Console.Write("Insira o número: ");
            int numero = int.Parse(Console.ReadLine()!);

            if (numero == 0)
            {
                break;
            }

            numeros.Add(numero);
        }

        int soma = 0;

        foreach (int numero in numeros)
        {
            soma += numero;
        }

        Console.WriteLine($"A soma é: {soma}");

        if (numeros.Count > 0)
        {
            double media = (double)soma / numeros.Count;

            Console.WriteLine($"A média é: {media}");

            int maior = numeros[0];

            foreach (int numero in numeros)
            {
                if (numero > maior)
                {
                    maior = numero;
                }
            }

            Console.WriteLine($"O maior número é: {maior}");

            int? menorPositivo = null;

            foreach (int numero in numeros)
            {
                if (numero > 0)
                {
                    if (menorPositivo == null || numero < menorPositivo)
                    {
                        menorPositivo = numero;
                    }
                }
            }

            if (menorPositivo != null)
            {
                Console.WriteLine($"O menor número positivo é: {menorPositivo}");
            }
            else
            {
                Console.WriteLine("Não há números positivos.");
            }

            numeros.Sort();

            Console.WriteLine("A lista reordenada é:");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
        else
        {
            Console.WriteLine("Nenhum número foi inserido.");
        }
    }
}
