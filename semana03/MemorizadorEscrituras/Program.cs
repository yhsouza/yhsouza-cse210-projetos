
using System;

class Program
{
    static void Main()
    {
        Referencia referencia1 = new Referencia();

        referencia1._livro = "Provérbios";
        referencia1._capitulo = 3;
        referencia1._versiculoInicial = 5;
        referencia1._versiculoFinal = 6;

        string texto = "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento. Reconhece-o em todos os teus caminhos e ele endireitará as tuas veredas.";

        Escritura escritura1 = new Escritura(referencia1, texto);

        string resposta = "";

        Console.WriteLine("Escolha o nível de dificuldade:");
        Console.WriteLine("1 - Fácil");
        Console.WriteLine("2 - Médio");
        Console.WriteLine("3 - Difícil");

        Console.Write("Sua escolha: ");
        string nivel = Console.ReadLine() ?? "";

        int quantidade = 3;

        if (nivel == "1")
        {
            quantidade = 1;
        }
        else if (nivel == "2")
        {
            quantidade = 3;
        }
        else if (nivel == "3")
        {
            quantidade = 5;
        }

        while (resposta != "sair" && !escritura1.TodasOcultas())
        {
            Console.Clear();

            escritura1.Exibir();

            Console.WriteLine();
            Console.WriteLine("Pressione Enter para continuar ou digite 'sair' para encerrar.");

            resposta = (Console.ReadLine() ?? "").Trim().ToLower();

            if (resposta == "")
            {
                escritura1.OcultarPalavras(quantidade);
            }
        }

        Console.Clear();
        escritura1.Exibir();

        Console.WriteLine();
        Console.WriteLine("Programa encerrado!");
    }
}
