using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

public class Emprego
{
    public string _nome;
    public string _empresa;
    public string _cargo;
    public string _anoInicio;
    public string _anoFim;

}
   public class Program
{
    public static void Main()
    {
        Emprego emprego1 = new Emprego();

        emprego1._nome = "João";
        emprego1._empresa = "Microsoft";
        emprego1._cargo = "Engenheiro de Software";
        emprego1._anoInicio = "2020";
        emprego1._anoFim = "2025";

        Console.WriteLine($"{emprego1._cargo} - {emprego1._empresa} - {emprego1._anoInicio} - {emprego1._anoFim}");

        Emprego emprego2 = new Emprego();

        emprego2._nome = "João";
        emprego2._empresa = "Microsoft";
        emprego2._cargo = "Engenheiro de Software";
        emprego2._anoInicio = "2019";
        emprego2._anoFim = "2022";

       // Console.WriteLine(emprego2._empresa);

        
         Emprego exibir = new Emprego();

        exibir._nome = "João";
        exibir._empresa = "Apple";
        exibir._cargo = "Gerente";
        exibir._anoInicio = "2022";
        exibir._anoFim = "2023";

        Console.WriteLine($"{exibir._cargo} - {exibir._anoInicio} - {exibir._anoFim}");
    }

}