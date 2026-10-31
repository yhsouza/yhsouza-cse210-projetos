using ExemploFundamentos.Common.Models;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("SP");
listaString.Add("SP");

Console.WriteLine("Percorrendo a lista com o FOR");
for(int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição {contador} - {listaString[contador]}");
}