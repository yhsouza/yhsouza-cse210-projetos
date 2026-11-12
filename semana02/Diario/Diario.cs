using System;
using System.Collections.Generic;
using System.IO;

public class Diario
{
    public List<Registro> _registros = new List<Registro>();

    public void AdicionarRegistro(Registro registro)
    {
        _registros.Add(registro);
    }

    public void ExibirRegistros()
    {
        foreach (Registro registro in _registros)
        {
            registro.Exibir();
        }
    }

    public void SalvarArquivo(string nomeArquivo)    
    {
        using (StreamWriter arquivo = new StreamWriter(nomeArquivo))
        {
            foreach (Registro registro in _registros)
            {
                arquivo.WriteLine($"{registro._data}|{registro._pergunta}|{registro._resposta}");
            }
        }
    }

    public void CarregarArquivo(string nomeArquivo)
{
    string[] linhas = File.ReadAllLines(nomeArquivo);

    _registros.Clear();

    foreach (string linha in linhas)
    {
        string[] partes = linha.Split('|');

        Registro registro = new Registro();

        registro._data = partes[0];
        registro._pergunta = partes[1];
        registro._resposta = partes[2];

        _registros.Add(registro);
    }
}
}