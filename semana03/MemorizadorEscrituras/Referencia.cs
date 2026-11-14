public class Referencia
{
    public string _livro = "";
    public int _capitulo;
    public int _versiculoInicial;
    public int _versiculoFinal;

    public string Exibir()
    {
        if (_versiculoInicial == _versiculoFinal)
        {
            return $"{_livro} {_capitulo}:{_versiculoInicial}";
        }
        else
        {
            return $"{_livro} {_capitulo}:{_versiculoInicial}-{_versiculoFinal}";
        }
    }
}