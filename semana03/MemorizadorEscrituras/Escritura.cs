using System;
using System.Collections.Generic;

public class Escritura
{
    public Referencia _referencia;
    public List<Palavra> _palavras = new List<Palavra>();

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;

        string[] partes = texto.Split(' ');

        foreach (string parte in partes)
        {
            Palavra palavra = new Palavra();

            palavra._texto = parte;

            _palavras.Add(palavra);
        }
    }

    public void Exibir()
    {
        Console.WriteLine(_referencia.Exibir());

        foreach (Palavra palavra in _palavras)
        {
            Console.Write(palavra.Exibir() + " ");
        }

        Console.WriteLine();
    }

    public void OcultarPalavras(int quantidade)
    {
    Random sorteio = new Random();

    

    for (int i = 0; i < quantidade; i++)
    {
        List<Palavra> visiveis = new List<Palavra>();

        foreach (Palavra palavra in _palavras)
        {
            if (palavra._oculta == false)
            {
                visiveis.Add(palavra);
            }
        }

        if (visiveis.Count == 0)
        {
            break;
        }

        int numero = sorteio.Next(visiveis.Count);

        visiveis[numero].Ocultar();
    }

    }

    public bool TodasOcultas()
    {
    foreach (Palavra palavra in _palavras)
    {
        if (palavra._oculta == false)
        {
            return false;
        }
    }

    return true;
    }
}