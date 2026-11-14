public class Palavra
{
    public string _texto = "";
    public bool _oculta = false;

    public void Ocultar()
    {
        _oculta = true;
    }

    public string Exibir()
    {
        if (_oculta)
        {
            return new string('_', _texto.Length);
        }
        else
        {
            return _texto;
        }
    }
}