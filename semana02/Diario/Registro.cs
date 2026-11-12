using System;

public class Registro
{
    
    public string _data ="";
    public string _pergunta ="";
    public string _resposta ="";

   public void Exibir()
{
    Console.WriteLine($"Data: {_data}");
    Console.WriteLine($"Pergunta: {_pergunta}");
    Console.WriteLine($"Resposta: {_resposta}");
}
}